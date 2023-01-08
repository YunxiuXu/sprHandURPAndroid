
//ClipToView
float4 ClipToViewSpace(float4 p, float4x4 InverseProjection)
{
	float4 t = mul(InverseProjection, p);
	return t / t.w;
}

struct Light
{
	float3 boundingConePos;
	//float3 boundingConeDir;//todo:try float3 padding here instead of this var while AB'ing performance
	float  boundingConeLength;
	float  boundingConeRadius;
	float  boundingConeBackadd;
	float4x4 mat;//[0][0] [0][1] [0][2] [0][3] horizontal slice
	float3 minMaxDist;
};

