Shader "Hidden/UASS" 
{
	Properties
	{
		_BlueNoiseTex("Blue Noise", 2D) = "gray" {}
	}
	SubShader
	{
		ZWrite Off ZTest Always Blend Off Cull Off

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile _ INDIRECT_ALGO
			#include "UnityCG.cginc"

			float4x4 _InverseViewMatrix;
			sampler2D_float _CameraDepthTexture;
			float4 _CameraDepthTexture_TexelSize;
			float _K;
			float4 _Light;
			float _ShadowStrength;
			float4 test;
			sampler2D _BlueNoiseTex;

			#include "Common.cginc"
			Texture2D<int2> lightsGrid;
			Buffer<uint> lightsIndexBuffer;
			StructuredBuffer<Light> lights;

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};
			struct v2f
			{
				float4 vertex : SV_POSITION;
				float2 uv : TEXCOORD0;
			};

			v2f vert(appdata v)
			{
				v2f i;

				i.vertex = float4(v.vertex.xy, 0.0, 1.0);
				i.uv = v.vertex.xy * 0.5 + 0.5;
				#if UNITY_UV_STARTS_AT_TOP
				i.uv.y = 1.0 - i.uv.y;
				#endif

				return i;
			}

			
			inline float sphereShadow(in float3 ro, in float3 rd, in float4 sph, in float k)
			{
				float3 oc = ro - sph.xyz;
				float b = dot(oc, rd);
				float c = dot(oc, oc) - sph.w*sph.w;
				float h = b * b - c;

				// physically plausible shadow
				float d = sqrt(max(0.0, sph.w*sph.w - h)) - sph.w;
				float t = -b - sqrt(max(h, 0.0));
				return (t < 0.0) ? /*1.0*/step(-0.00001, c) : smoothstep(0.0, 1.0, 2.5*k*d / t);
				//return (t < 0.0) ? /*1.0*/step(-0.00001, c) : saturate(2.5*k*d / t);
				//return (t < 0.0) ? /*1.0*/step(-0.00001, c) : smoothstep(0.0, 1.0, lerp(2.5*k*d / t, 1.0, saturate(c/sph.w / 500)));

				// cheap alternative
				//return (b > 0.0) ? step(-0.0001, c) : smoothstep(0.0, 1.0, h*k*4 / b);
			}
			inline float capsuleShadow(in float3 ro, in float3 rd, in float3 a, in float3 b, in float r, in float k)
			{
				float3 ba = b - a;
				float3 oa = ro - a;

				// closest distance between ray and segment
				// naive way to solve the 2x2 system of equations
				float oad = dot(oa, rd);
				float dba = dot(rd, ba);
				float baba = dot(ba, ba);
				float oaba = dot(oa, ba);
				float2 th = float2(-oad * baba + dba * oaba, oaba - oad * dba) / (baba - dba * dba);
				// fizzer's way to solve the 2x2 system of equations
				//float3 th = mul(transpose(float3x3(-rd, ba, cross(rd, ba))), oa);//can cpu calculate this? transpose(float3x3(-rd, ba, cross(rd, ba)))

				th.x = max(th.x, 0.0001);
				th.y = saturate(th.y);
				float3  p = a + ba * th.y;
				float3  q = ro + rd * th.x;
				float d = length(p - q) - r;

				// fake shadow
				float s = saturate(k*d / th.x);
				return s * s*(3.0 - 2.0*s);
			}
			inline float dot2(in float3 v) { return dot(v, v); }
			inline float segShadow(in float3 ro, in float3 rd, in float3 pa, float sh)
			{
				float dm = dot(rd.yz, rd.yz);
				float k1 = (ro.x - pa.x)*dm;
				float k2 = (ro.x + pa.x)*dm;
				float2  k5 = (ro.yz + pa.yz)*dm;
				float k3 = dot(ro.yz + pa.yz, rd.yz);
				float2  k4 = (pa.yz + pa.yz)*rd.yz;
				float2  k6 = (pa.yz + pa.yz)*dm;

				for (int i = 0; i < 4; i++)
				{
					float2  s = float2(i & 1, i >> 1);
					float t = dot(s, k4) - k3;

					if (t > 0.0)
						sh = min(sh, dot2(float3(clamp(-rd.x*t, k1, k2), k5 - k6 * s) + rd * t) / (t*t));
						//sh = min(sh, lerp(dot2(float3(clamp(-rd.x*t, k1, k2), k5 - k6 * s) + rd * t) / (t*t), 1.0, t / 1000.0));//distfade tests<V
					//lerp(2.5*k*d / t, 1.0, saturate(c / sph.w / 500)
				}
				return sh;
			}
			inline float sdBox(float3 p, float3 b)
			{
				float3 d = abs(p) - b;
				return min(max(d.x, max(d.y, d.z)), 0.0) + length(max(d, 0.0));
			}
			inline float boxShadow(float3 ro, float3 rd, float4x4 txx, float3 rad, float sk, bool cheap, float fadeDist)
			{
				float3 rdd = mul(txx, float4(rd, 0.0)).xyz;
				float3 roo = mul(txx, float4(ro, 1.0)).xyz;


				float3 m = 1.0 / rdd;
				float3 n = m * roo;
				float3 k = abs(m)*rad;

				float3 t1 = -n - k;
				float3 t2 = -n + k;

				float tN = max(max(t1.x, t1.y), t1.z);
				float tF = min(min(t2.x, t2.y), t2.z);

				#ifdef INDIRECT_ALGO		
					//float dist = pow(sdBox(roo, rad), 2);
					float dist = sdBox(roo, rad);
					dist = smoothstep(0, 1, dist / fadeDist / sk);
					//dist = smoothstep(0, 1, atan(dist) * 10 / fadeDist / sk);
					//dist = smoothstep(0, 1, pow(dist / fadeDist / sk, 2));
					//dist = smoothstep(0, 1, sqrt(dist) / fadeDist / sk);
					
				#endif

				if (cheap)
				{
					#ifdef INDIRECT_ALGO
						if (tN < tF && tF >= 0.0) return lerp(0.0, 1.0, dist);
					#else
						if (tN < tF && tF >= 0.0) return 0.0;
					#endif
					if (tF < 0.0) return 1.0;
					float sh = saturate(0.3*(sk*2.0)*(tN - tF) / tN);
					#ifdef INDIRECT_ALGO
						return lerp(sh * sh*(3.0 - 2.0*sh), 1.0, dist);
					#else
						return sh * sh*(3.0 - 2.0*sh);
					#endif
				}
				else
				{
					#ifdef INDIRECT_ALGO
						if (tN<tF && tF>=0.0) return lerp(0.0, 1.0, dist);
					#else
						if (tN < tF && tF >= 0.0) return 0.0;
					#endif
					float sh = 1.0;
					sh = segShadow(roo.xyz, rdd.xyz, rad.xyz, sh);
					sh = segShadow(roo.yzx, rdd.yzx, rad.yzx, sh);
					sh = segShadow(roo.zxy, rdd.zxy, rad.zxy, sh);
					sh = saturate(sk*sqrt(sh));
					#ifdef INDIRECT_ALGO
						return lerp(sh * sh*(3.0 - 2.0*sh), 1.0, dist);
					#else
						return /*sh*/sh * sh*(3.0 - 2.0*sh);//..3-2.. is same as smoothstep
					#endif
				}
			}
			//
			#define PI 3.14159265359
			float acosFast(float inX)
			{
				float x = abs(inX);
				float res = -0.156583f * x + (0.5 * PI);
				res *= sqrt(1.0f - x);
				return (inX >= 0) ? res : PI - res;
			}
			float SphericalCapIntersectionAreaFast(float fRadius0, float fRadius1, float fDist)
			{
				float fArea;

				if (fDist <= max(fRadius0, fRadius1) - min(fRadius0, fRadius1))
				{
					// One cap is completely inside the other
					fArea = 6.283185308f - 6.283185308f * cos(min(fRadius0, fRadius1));
				}
				else if (fDist >= fRadius0 + fRadius1)
				{
					// No intersection exists
					fArea = 0;
				}
				else
				{
					float fDiff = abs(fRadius0 - fRadius1);
					fArea = smoothstep(0.0f,
						1.0f,
						1.0f - saturate((fDist - fDiff) / (fRadius0 + fRadius1 - fDiff)));
					//fArea = 1.0f - saturate((fDist - fDiff) / (fRadius0 + fRadius1 - fDiff));
					fArea *= 6.283185308f - 6.283185308f * cos(min(fRadius0, fRadius1));
				}
				return fArea;
			}
			float atanFastPos(float x)
			{
				float t0 = (x < 1.0f) ? x : 1.0f / x;
				float t1 = t0 * t0;
				float poly = 0.0872929f;
				poly = -0.301895f + poly * t1;
				poly = 1.0f + poly * t1;
				poly = poly * t0;
				return (x < 1.0f) ? poly : (0.5 * PI) - poly;
			}
			void GenerateCoordinateSystem(float3 ZAxis, out float3 XAxis, out float3 YAxis)
			{
				// Generates arbitrary but valid perpendicular unit vectors to ZAxis(UP). ZAxis should be unit length.
				if (abs(ZAxis.x) > abs(ZAxis.y))
				{
					float InverseLength = 1.0f / sqrt(dot(ZAxis.xz, ZAxis.xz));
					XAxis = float3(-ZAxis.z * InverseLength, 0.0f, ZAxis.x * InverseLength);
				}
				else
				{
					float InverseLength = 1.0f / sqrt(dot(ZAxis.yz, ZAxis.yz));
					XAxis = float3(0.0f, ZAxis.z * InverseLength, -ZAxis.y * InverseLength);
				}

				YAxis = cross(ZAxis, XAxis);
			}
			float sphereShadow(float3 WorldRayStart, float3 UnitRayDirection, float LightAngle, float4 SphereCenterAndRadius, float MaxDist, float LightVectorLength) 
			{
				float DistanceToShadowSphere = length(SphereCenterAndRadius.xyz - WorldRayStart);
				float3 UnitVectorToShadowSphere = (SphereCenterAndRadius.xyz - WorldRayStart) / DistanceToShadowSphere;

				float AngleBetween = acosFast(dot(UnitVectorToShadowSphere, UnitRayDirection));
				float IntersectionArea = SphericalCapIntersectionAreaFast(LightAngle, atanFastPos(SphereCenterAndRadius.w / DistanceToShadowSphere), AngleBetween);
				if (_Light.w > 0) 
				{
					// To prevent discontinuity, we use the ratio of the distance difference to the sphere's radius as a smooth factor
					IntersectionArea = lerp(IntersectionArea, 0, saturate((DistanceToShadowSphere - LightVectorLength + SphereCenterAndRadius.w) / SphereCenterAndRadius.w));
				}
				float AreaOfLight = 6.283185308f - 6.283185308f * cos(LightAngle);
				float ConeConeIntersection = 1 - saturate(IntersectionArea / AreaOfLight);
				
				float MaxOcclusionDistance = MaxDist * SphereCenterAndRadius.w / (_Light.w > 0 ? LightVectorLength / _Light.w : 1);
				ConeConeIntersection = lerp(ConeConeIntersection, 1, saturate(DistanceToShadowSphere * (1.0 / MaxOcclusionDistance) * 3 - 2));

				return ConeConeIntersection;
			}
			float capsuleShadow(float3 WorldRayStart, float3 UnitRayDirection, float LightAngle, float4 CapsuleCenterAndRadius, float4 CapsuleOrientationAndLength, float MaxDist, float LightVectorLength)
			{
				float3 CapsuleSpaceX;
				float3 CapsuleSpaceY;
				float3 CapsuleSpaceZ = CapsuleOrientationAndLength.xyz;
				GenerateCoordinateSystem(CapsuleSpaceZ, CapsuleSpaceX, CapsuleSpaceY);

				float CapsuleZScale = CapsuleCenterAndRadius.w / (.5f * CapsuleOrientationAndLength.w + CapsuleCenterAndRadius.w);
				CapsuleSpaceZ *= CapsuleZScale;

				float3 CapsuleCenterToRayStart = WorldRayStart - CapsuleCenterAndRadius.xyz;
				float3 CapsuleSpaceRayStart = float3(dot(CapsuleCenterToRayStart, CapsuleSpaceX), dot(CapsuleCenterToRayStart, CapsuleSpaceY), dot(CapsuleCenterToRayStart, CapsuleSpaceZ));

				float3 CapsuleSpaceRayDirection = float3(dot(UnitRayDirection, CapsuleSpaceX), dot(UnitRayDirection, CapsuleSpaceY), dot(UnitRayDirection, CapsuleSpaceZ));

				float DistanceToShadowSphere = length(CapsuleSpaceRayStart);
				float3 UnitVectorToShadowSphere = -CapsuleSpaceRayStart / DistanceToShadowSphere;
				UnitRayDirection = normalize(CapsuleSpaceRayDirection);

				float AngleBetween = acosFast(dot(UnitVectorToShadowSphere, UnitRayDirection));
				float IntersectionArea = SphericalCapIntersectionAreaFast(LightAngle, atanFastPos(CapsuleCenterAndRadius.w / DistanceToShadowSphere), AngleBetween);
				if (_Light.w > 0)
				{
					// To prevent discontinuity, we use the ratio of the distance difference to the capsule's radius as a smooth factor
					IntersectionArea = lerp(IntersectionArea, 0, saturate((DistanceToShadowSphere - LightVectorLength + CapsuleCenterAndRadius.w) / CapsuleCenterAndRadius.w));
				}
				float AreaOfLight = 6.283185308f - 6.283185308f * cos(LightAngle);
				float ConeConeIntersection = 1 - saturate(IntersectionArea / AreaOfLight);

				//float MaxOcclusionDistance = 10. * CapsuleCenterAndRadius.w / LightAngle;
				float MaxOcclusionDistance = MaxDist * CapsuleCenterAndRadius.w / (_Light.w > 0 ? LightVectorLength / _Light.w : 1);
				ConeConeIntersection = lerp(ConeConeIntersection, 1, saturate(DistanceToShadowSphere * (1.0 / MaxOcclusionDistance) * 3 - 2));

				//ConeConeIntersection = lerp(MinVisibility, 1, ConeConeIntersection);
				//ConeConeIntersection = smoothstep(0, 1, ConeConeIntersection);

				return ConeConeIntersection;
			}
			//
			float3 viewSpacePosAtUV(float2 uv)
			{
				float3 viewSpaceRay = mul(_InverseViewMatrix, float4(uv * 2.0 - 1.0, 1.0, 1.0) * _ProjectionParams.z);
				float rawDepth = SAMPLE_DEPTH_TEXTURE(_CameraDepthTexture, uv);
				return viewSpaceRay * Linear01Depth(rawDepth);
			}
			half3 viewNormalAtUV(float2 uv)
			{
				half3 viewSpacePos_c = viewSpacePosAtUV(uv + float2(0.0, 0.0)  * _CameraDepthTexture_TexelSize.xy);
				half3 viewSpacePos_l = viewSpacePosAtUV(uv + float2(-1.0, 0.0) * _CameraDepthTexture_TexelSize.xy);
				half3 viewSpacePos_r = viewSpacePosAtUV(uv + float2(1.0, 0.0)  * _CameraDepthTexture_TexelSize.xy);
				half3 viewSpacePos_d = viewSpacePosAtUV(uv + float2(0.0, -1.0) * _CameraDepthTexture_TexelSize.xy);
				half3 viewSpacePos_u = viewSpacePosAtUV(uv + float2(0.0, 1.0)  * _CameraDepthTexture_TexelSize.xy);
				half3 l = viewSpacePos_c - viewSpacePos_l;
				half3 r = viewSpacePos_r - viewSpacePos_c;
				half3 d = viewSpacePos_c - viewSpacePos_d;
				half3 u = viewSpacePos_u - viewSpacePos_c;
				half3 hDeriv = abs(l.z) < abs(r.z) ? l : r;
				half3 vDeriv = abs(d.z) < abs(u.z) ? d : u;
				half3 viewNormal = normalize(cross(hDeriv, vDeriv));
				return viewNormal;
			}
			float3 normalFromDepth(float2 uv)
			{
				float2 offset1 = float2(0.0, 0.001);
				float2 offset2 = float2(0.001, 0.0);

				float depth = LinearEyeDepth(tex2D(_CameraDepthTexture, uv)).r;
				float depth1 = LinearEyeDepth(tex2D(_CameraDepthTexture, uv + offset1)).r;
				float depth2 = LinearEyeDepth(tex2D(_CameraDepthTexture, uv + offset2)).r;

				float3 p1 = float3(offset1, depth1 - depth);
				float3 p2 = float3(offset2, depth2 - depth);

				float3 normal = cross(p1, p2);
				normal.z = -normal.z;

				return normalize(normal);
			}
			
			float4 frag(v2f i) : SV_Target
			{
				//return 1;
				float2 uv = i.uv;

				uint2 grid = lightsGrid[(uint2)(float2(uv.x, 1.0 - uv.y)/*<-*/ * _ScreenParams.xy / 32.0)];
				uint n = min(1024, grid.y);
				if (n == 0) return float4(1.0, 1.0, 0, 0);

				// read depth and reconstruct world position
				float2 texelSize = 0.5 * _CameraDepthTexture_TexelSize.xy;
				float2 taps[4] = { float2(uv + float2(-1,-1)*texelSize), float2(uv + float2(-1,1)*texelSize),
					float2(uv + float2(1,-1)*texelSize), float2(uv + float2(1,1)*texelSize) };
				float depth = min(SAMPLE_DEPTH_TEXTURE(_CameraDepthTexture, taps[0]), min(SAMPLE_DEPTH_TEXTURE(_CameraDepthTexture, taps[1]), 
					min(SAMPLE_DEPTH_TEXTURE(_CameraDepthTexture, taps[2]), SAMPLE_DEPTH_TEXTURE(_CameraDepthTexture, taps[3]))));

				//if (Linear01Depth(depth) > 0.999) return float4(1.0, depth, 0, 0);
				float linDepth = LinearEyeDepth(depth);
				float2 projectionMultipliers = float2(unity_CameraProjection._11, unity_CameraProjection._22);
				float3 vpos = float3((uv * 2 - 1) / projectionMultipliers, -1) * linDepth;
				float3 wsPos = mul(_InverseViewMatrix, float4(vpos, 1)).xyz;

				float3 lightDir = normalize(_Light.xyz - (wsPos * (_Light.w > 0))) + 0.0001;
				float3 bias = /*linDepth / 200;*/ sqrt(length(_WorldSpaceCameraPos.xyz - wsPos)) / 50.0/*25.*/;

				const float k = _K;
				#ifdef INDIRECT_ALGO
				float lightAngle = lerp(0, PI / 2., 180. / k / 180.);
				//lightAngle = atanFastPos(1 / /**/length(_Light.xyz - wsPos)/**/);
				float lightVectorLength = _Light.w > 0 ? length(_Light.xyz - wsPos) : 0;
				#endif

				float shadow = 1.0;
				for (uint i = 0; i < n; ++i)
				{
					//shadow *= 0.85; continue;
					float4x4 mat = lights[lightsIndexBuffer[grid.x + i]].mat;
					float3 minMaxDist = lights[lightsIndexBuffer[grid.x + i]].minMaxDist;
					float3 biasedWsPos = wsPos + lightDir * max(bias, minMaxDist.x);
					if (mat[3][3] == 1) //SPHERE
					{
					#ifdef INDIRECT_ALGO
						float3 pos = float3(mat[0][0], mat[1][0], mat[2][0]) +lightDir*mat[3][0]/4;
						shadow *= sphereShadow(biasedWsPos, lightDir, lightAngle, float4(pos.x, pos.y, pos.z, mat[3][0]), minMaxDist.y, lightVectorLength);
						//shadow *= sphereShadow(wsPos, lightDir, lightAngle, float4(mat[0][0], mat[1][0], mat[2][0], mat[3][0]), minMaxDist.y);
					#else
						shadow *= sphereShadow(biasedWsPos, lightDir, float4(mat[0][0], mat[1][0], mat[2][0], mat[3][0]), k * 0.5);
					#endif
					}
					else if (mat[3][3] == 2) //CAPSULE
					{
					#ifdef INDIRECT_ALGO
						float3 a = float3(mat[0][0], mat[1][0], mat[2][0]);
						float3 b = float3(mat[0][1], mat[1][1], mat[2][1]);
						float r = mat[3][0];
						float4 CapsuleCenterAndRadius = float4(lerp(a, b, 0.5) /**/+lightDir*r/4/**/, r);
						float4 CapsuleOrientationAndLength = float4(normalize(b - a), distance(a, b));
						shadow *= capsuleShadow(/*wsPos*/biasedWsPos, lightDir, lightAngle, CapsuleCenterAndRadius, CapsuleOrientationAndLength, minMaxDist.y, lightVectorLength);
					#else
						shadow *= capsuleShadow(biasedWsPos, lightDir, float3(mat[0][0], mat[1][0], mat[2][0]), float3(mat[0][1], mat[1][1], mat[2][1]), mat[3][0], k);
					#endif
					}
					else if (mat[3][3] == 3 || mat[3][3] == 4) //BOX
					{
						float4 v = mat[3];
						mat[3] = float4(0.0, 0.0, 0.0, 1.0);
						shadow *= boxShadow(biasedWsPos, lightDir, mat, v.xyz, k, v.w == 4, minMaxDist.y);
					}
					//else if (5) //MASK_SPHERE //if pixel inside sphere/Capsule/Box shadow=1.0 break;
					if (shadow == 0.0) break;
				}

				shadow = lerp(_ShadowStrength, 1.0, shadow);
				shadow *= lerp(lerp(tex2D(_BlueNoiseTex, (wsPos.x + wsPos.y + wsPos.z) * 5) + 0.75, 1.0, 1.0 - shadow), 1.0, shadow);//0.03ms on overkill

				//float3 normal = mul((float3x3)_InverseViewMatrix, viewNormalAtUV/*normalFromDepth*/(uv)/* * float3(1.0, 1.0, -1.0)*/);
				//if (dot(normal, _Light.xyz) < 0)
					//shadow = 1.0;
				return float4(shadow, depth, 0, 0);
			}


			ENDCG
		}

		Pass
		{
			ZWrite Off ZTest Always Blend Off Cull Off

			Blend DstColor Zero // Multiplicative
			//BlendOp Min
			//Blend One One

			CGPROGRAM

			#pragma vertex vert
			#pragma fragment frag
			#pragma exclude_renderers nomrt
			#pragma multi_compile_fog
			#include "UnityCG.cginc"

			sampler2D_float _CameraDepthTexture;
			float4 _CameraDepthTexture_TexelSize;
			sampler2D _SourceTex;
			float4 _SourceTex_TexelSize;
			float4 _Color;

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};
			struct v2f
			{
				float4 vertex : SV_POSITION;
				float2 uv : TEXCOORD0;
			};
			v2f vert(appdata v)
			{
				v2f i;

				i.vertex = float4(v.vertex.xy, 0.0, 1.0);
				i.uv = v.vertex.xy * 0.5 + 0.5;
				#if UNITY_UV_STARTS_AT_TOP
				i.uv.y = 1.0 - i.uv.y;
				#endif

				return i;
			}
			

			void frag(v2f i, out float4 outDiffuse : SV_Target0)
			{
				//uint2 grid = lightsGrid[(uint2)(float2(i.uv.x, 1.0 - i.uv.y)/*<-*/ * _ScreenParams.xy / 32.0)];
				//uint n = grid.y;
				//if (n == 0) discard;

				//float shadow = tex2D(_SourceTex, i.uv).x;
				//
				float2 LowResBufferSize = _SourceTex_TexelSize.zw;
				float2 LowResTexelSize = _SourceTex_TexelSize.xy;
				float2 Corner00UV = floor(i.uv * LowResBufferSize - .5f) / LowResBufferSize + .5f * LowResTexelSize;
				float2 BilinearWeights = (i.uv - Corner00UV) * LowResBufferSize;

				float2 TextureValues00 = tex2D(_SourceTex, Corner00UV).xy;//x is shadow, y is depth it used
				float2 TextureValues10 = tex2D(_SourceTex, Corner00UV + float2(LowResTexelSize.x, 0)).xy;
				float2 TextureValues01 = tex2D(_SourceTex, Corner00UV + float2(0, LowResTexelSize.y)).xy;
				float2 TextureValues11 = tex2D(_SourceTex, Corner00UV + LowResTexelSize).xy;

				float4 CornerWeights = float4(
				 (1 - BilinearWeights.y) * (1 - BilinearWeights.x),
				 (1 - BilinearWeights.y) * BilinearWeights.x,
				 BilinearWeights.y * (1 - BilinearWeights.x),
				 BilinearWeights.y * BilinearWeights.x);

				float Epsilon = /*.0001f*//*-.0001f*/0.0f; //<----

				float4 CornerDepths = abs(float4(TextureValues00.y, TextureValues10.y, TextureValues01.y, TextureValues11.y));
				float SceneDepth = SAMPLE_DEPTH_TEXTURE(_CameraDepthTexture, i.uv);
				if (Linear01Depth(SceneDepth) == 1.0) { outDiffuse = 1.0; return; }
				float4 DepthWeights = 1.0f / (abs(CornerDepths - SceneDepth.xxxx) + Epsilon);
				float4 FinalWeights = CornerWeights * DepthWeights;

				float InterpolatedResult =
				 (FinalWeights.x * TextureValues00.x
					 + FinalWeights.y * TextureValues10.x
					 + FinalWeights.z * TextureValues01.x
					 + FinalWeights.w * TextureValues11.x)
				 / dot(FinalWeights, 1);

				float shadow = InterpolatedResult;
				//

				outDiffuse = float4(shadow, shadow, shadow, 1.0);
			}

			ENDCG
		}

	}
}