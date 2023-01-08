TEXTURE2D(_UASSTexture);
SAMPLER(sampler_UASSTexture);


half3 LightingPhysicallyBased_(BRDFData brdfData, BRDFData brdfDataClearCoat, Light light, half3 normalWS, half3 viewDirectionWS, half clearCoatMask, bool specularHighlightsOff, float2 screenUV)
{
	float4 uass = SAMPLE_TEXTURE2D_X(_UASSTexture, sampler_UASSTexture, screenUV);
	if (uass.a == 1.0)
		light.shadowAttenuation *= uass.x;
	return LightingPhysicallyBased(brdfData, brdfDataClearCoat, light.color, light.direction, light.distanceAttenuation * light.shadowAttenuation, normalWS, viewDirectionWS, clearCoatMask, specularHighlightsOff);
}


half4 UniversalFragmentPBR_(InputData inputData, SurfaceData surfaceData)
{
#ifdef _SPECULARHIGHLIGHTS_OFF
	bool specularHighlightsOff = true;
#else
	bool specularHighlightsOff = false;
#endif

	BRDFData brdfData;

	// NOTE: can modify alpha
	InitializeBRDFData(surfaceData.albedo, surfaceData.metallic, surfaceData.specular, surfaceData.smoothness, surfaceData.alpha, brdfData);

	BRDFData brdfDataClearCoat = (BRDFData)0;
#if defined(_CLEARCOAT) || defined(_CLEARCOATMAP)
	// base brdfData is modified here, rely on the compiler to eliminate dead computation by InitializeBRDFData()
	InitializeBRDFDataClearCoat(surfaceData.clearCoatMask, surfaceData.clearCoatSmoothness, brdfData, brdfDataClearCoat);
#endif

	// To ensure backward compatibility we have to avoid using shadowMask input, as it is not present in older shaders
#if defined(SHADOWS_SHADOWMASK) && defined(LIGHTMAP_ON)
	half4 shadowMask = inputData.shadowMask;
#elif !defined (LIGHTMAP_ON)
	half4 shadowMask = unity_ProbesOcclusion;
#else
	half4 shadowMask = half4(1, 1, 1, 1);
#endif

	Light mainLight = GetMainLight(inputData.shadowCoord, inputData.positionWS, shadowMask);

#if defined(_SCREEN_SPACE_OCCLUSION)
	AmbientOcclusionFactor aoFactor = GetScreenSpaceAmbientOcclusion(inputData.normalizedScreenSpaceUV);
	mainLight.color *= aoFactor.directAmbientOcclusion;
	surfaceData.occlusion = min(surfaceData.occlusion, aoFactor.indirectAmbientOcclusion);
#endif

	MixRealtimeAndBakedGI(mainLight, inputData.normalWS, inputData.bakedGI);
	half3 color = GlobalIllumination(brdfData, brdfDataClearCoat, surfaceData.clearCoatMask,
		inputData.bakedGI, surfaceData.occlusion,
		inputData.normalWS, inputData.viewDirectionWS);
	color += LightingPhysicallyBased_(brdfData, brdfDataClearCoat,
		mainLight,
		inputData.normalWS, inputData.viewDirectionWS,
		surfaceData.clearCoatMask, specularHighlightsOff, inputData.normalizedScreenSpaceUV);

#ifdef _ADDITIONAL_LIGHTS
	uint pixelLightCount = GetAdditionalLightsCount();
	for (uint lightIndex = 0u; lightIndex < pixelLightCount; ++lightIndex)
	{
		Light light = GetAdditionalLight(lightIndex, inputData.positionWS, shadowMask);
#if defined(_SCREEN_SPACE_OCCLUSION)
		light.color *= aoFactor.directAmbientOcclusion;
#endif
		color += LightingPhysicallyBased_(brdfData, brdfDataClearCoat,
			light,
			inputData.normalWS, inputData.viewDirectionWS,
			surfaceData.clearCoatMask, specularHighlightsOff, inputData.normalizedScreenSpaceUV);
	}
#endif

#ifdef _ADDITIONAL_LIGHTS_VERTEX
	color += inputData.vertexLighting * brdfData.diffuse;
#endif

	color += surfaceData.emission;

	return half4(color, surfaceData.alpha);
}


half4 UniversalFragmentPBR_(InputData inputData, half3 albedo, half metallic, half3 specular,
	half smoothness, half occlusion, half3 emission, half alpha)
{
	SurfaceData s;
	s.albedo = albedo;
	s.metallic = metallic;
	s.specular = specular;
	s.smoothness = smoothness;
	s.occlusion = occlusion;
	s.emission = emission;
	s.alpha = alpha;
	s.clearCoatMask = 0.0;
	s.clearCoatSmoothness = 1.0;
	return UniversalFragmentPBR_(inputData, s);
}