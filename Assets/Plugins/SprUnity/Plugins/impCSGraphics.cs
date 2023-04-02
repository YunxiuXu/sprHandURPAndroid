using System;
using System.Runtime.InteropServices;
namespace SprCs {
    public partial class SprExport {
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRVisualDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRVisualDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRFrameTransformMatrix();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRFrameTransformMatrix(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRFrameDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRFrameDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRFrameDesc_addr_transform(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRFrameDesc_set_transform(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRDummyFrameDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRDummyFrameDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRKey();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRKey(IntPtr _this);
	[DllImport("SprExport")]
	public static extern uint Spr_GRKey_get_time(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRKey_set_time(IntPtr _this, uint value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRKey_vector_addr_values(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRKey_vector_set_values(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRAnimationKey();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRAnimationKey(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_GRAnimationKey_get_keyType(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationKey_set_keyType(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationKey_vector_get_keys(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationKey_vector_set_keys(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRAnimationDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRAnimationDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationDesc_vector_get_keys(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationDesc_vector_set_keys(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRAnimationSetDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRAnimationSetDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRAnimationControllerDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRAnimationControllerDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRBlendMeshDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRBlendMeshDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRBlendMeshDesc_vector_get_positions(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRBlendMeshDesc_vector_set_positions(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRBlendMeshDesc_vector_get_normals(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRBlendMeshDesc_vector_set_normals(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRBlendMeshDesc_vector_get_colors(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRBlendMeshDesc_vector_set_colors(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRBlendMeshDesc_vector_get_texCoords(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRBlendMeshDesc_vector_set_texCoords(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRBlendMeshDesc_vector_addr_faces(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRBlendMeshDesc_vector_set_faces(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRBlendMeshDesc_vector_get_blends(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRBlendMeshDesc_vector_set_blends(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRBlendMeshDesc_vector_get_matrixIndices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRBlendMeshDesc_vector_set_matrixIndices(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRBlendMeshDesc_vector_get_numMatrix(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRBlendMeshDesc_vector_set_numMatrix(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRMeshFace();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRMeshFace(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_GRMeshFace_get_nVertices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMeshFace_set_nVertices(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshFace_array_addr_indices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMeshFace_array_set_indices(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRSkinWeightDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRSkinWeightDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSkinWeightDesc_addr_offset(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRSkinWeightDesc_set_offset(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSkinWeightDesc_vector_addr_indices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRSkinWeightDesc_vector_set_indices(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSkinWeightDesc_vector_addr_weights(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRSkinWeightDesc_vector_set_weights(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRMeshDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRMeshDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshDesc_vector_get_vertices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMeshDesc_vector_set_vertices(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshDesc_vector_get_faces(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMeshDesc_vector_set_faces(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshDesc_vector_get_normals(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMeshDesc_vector_set_normals(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshDesc_vector_get_faceNormals(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMeshDesc_vector_set_faceNormals(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshDesc_vector_get_colors(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMeshDesc_vector_set_colors(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshDesc_vector_get_texCoords(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMeshDesc_vector_set_texCoords(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshDesc_vector_addr_materialList(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMeshDesc_vector_set_materialList(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRFont();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRFont_8(int h, string f);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRFont_9(int h);
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRFont(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_GRFont_get_height(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRFont_set_height(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_GRFont_get_width(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRFont_set_width(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_GRFont_get_weight(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRFont_set_weight(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRFont_get_face(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRFont_set_face(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_GRFont_FreeString_face(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern uint Spr_GRFont_get_color(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRFont_set_color(IntPtr _this, uint value);
	[DllImport("SprExport")]
	public static extern char Spr_GRFont_get_bItalic(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRFont_set_bItalic(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern void Spr_GRFont_SetColor(IntPtr _this, uint c);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRLightDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRLightDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRLightDesc_addr_ambient(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRLightDesc_set_ambient(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRLightDesc_addr_diffuse(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRLightDesc_set_diffuse(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRLightDesc_addr_specular(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRLightDesc_set_specular(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRLightDesc_addr_position(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRLightDesc_set_position(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_GRLightDesc_get_range(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRLightDesc_set_range(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_GRLightDesc_get_attenuation0(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRLightDesc_set_attenuation0(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_GRLightDesc_get_attenuation1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRLightDesc_set_attenuation1(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_GRLightDesc_get_attenuation2(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRLightDesc_set_attenuation2(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRLightDesc_addr_spotDirection(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRLightDesc_set_spotDirection(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_GRLightDesc_get_spotFalloff(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRLightDesc_set_spotFalloff(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_GRLightDesc_get_spotInner(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRLightDesc_set_spotInner(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_GRLightDesc_get_spotCutoff(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRLightDesc_set_spotCutoff(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRMaterialDesc();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRMaterialDesc_8(IntPtr a, IntPtr d, IntPtr s, IntPtr e, float p);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRMaterialDesc_9(IntPtr c, float p);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRMaterialDesc_10(IntPtr c);
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRMaterialDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMaterialDesc_addr_ambient(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMaterialDesc_set_ambient(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMaterialDesc_addr_diffuse(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMaterialDesc_set_diffuse(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMaterialDesc_addr_specular(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMaterialDesc_set_specular(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMaterialDesc_addr_emissive(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMaterialDesc_set_emissive(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_GRMaterialDesc_get_power(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMaterialDesc_set_power(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMaterialDesc_get_texname(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMaterialDesc_set_texname(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_GRMaterialDesc_FreeString_texname(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern char Spr_GRMaterialDesc_IsOpaque(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_GRMaterialDesc_Is3D(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRCameraDesc();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRCameraDesc_7(IntPtr sz, IntPtr c, float f, float b, int t);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRCameraDesc_8(IntPtr sz, IntPtr c, float f, float b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRCameraDesc_9(IntPtr sz, IntPtr c, float f);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRCameraDesc_10(IntPtr sz, IntPtr c);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRCameraDesc_11(IntPtr sz);
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRCameraDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRCameraDesc_addr_size(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRCameraDesc_set_size(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRCameraDesc_addr_center(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRCameraDesc_set_center(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_GRCameraDesc_get_front(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRCameraDesc_set_front(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_GRCameraDesc_get_back(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRCameraDesc_set_back(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern int Spr_GRCameraDesc_get_type(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRCameraDesc_set_type(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRShadowLightDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRShadowLightDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_GRShadowLightDesc_get_directional(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShadowLightDesc_set_directional(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRShadowLightDesc_addr_position(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShadowLightDesc_set_position(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRShadowLightDesc_addr_lookat(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShadowLightDesc_set_lookat(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRShadowLightDesc_addr_up(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShadowLightDesc_set_up(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRShadowLightDesc_addr_size(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShadowLightDesc_set_size(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_GRShadowLightDesc_get_fov(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShadowLightDesc_set_fov(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_GRShadowLightDesc_get_front(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShadowLightDesc_set_front(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_GRShadowLightDesc_get_back(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShadowLightDesc_set_back(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern int Spr_GRShadowLightDesc_get_texWidth(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShadowLightDesc_set_texWidth(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_GRShadowLightDesc_get_texHeight(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShadowLightDesc_set_texHeight(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern float Spr_GRShadowLightDesc_get_offset(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShadowLightDesc_set_offset(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRShadowLightDesc_addr_color(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShadowLightDesc_set_color(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRSceneDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRSceneDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRSdkDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRSdkDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_SFBlendLocation();
	[DllImport("SprExport")]
	public static extern void Spr_delete_SFBlendLocation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern uint Spr_SFBlendLocation_get_uBlendMatrix(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_SFBlendLocation_set_uBlendMatrix(IntPtr _this, uint value);
	[DllImport("SprExport")]
	public static extern uint Spr_SFBlendLocation_get_aWeight(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_SFBlendLocation_set_aWeight(IntPtr _this, uint value);
	[DllImport("SprExport")]
	public static extern uint Spr_SFBlendLocation_get_aMatrixIndices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_SFBlendLocation_set_aMatrixIndices(IntPtr _this, uint value);
	[DllImport("SprExport")]
	public static extern uint Spr_SFBlendLocation_get_aNumMatrix(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_SFBlendLocation_set_aNumMatrix(IntPtr _this, uint value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRShaderDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRShaderDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRShaderDesc_get_vsname(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShaderDesc_set_vsname(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_GRShaderDesc_FreeString_vsname(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRShaderDesc_get_fsname(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShaderDesc_set_fsname(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_GRShaderDesc_FreeString_fsname(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern char Spr_GRShaderDesc_get_bEnableLighting(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShaderDesc_set_bEnableLighting(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_GRShaderDesc_get_bEnableTexture2D(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShaderDesc_set_bEnableTexture2D(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_GRShaderDesc_get_bEnableTexture3D(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShaderDesc_set_bEnableTexture3D(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_GRShaderDesc_get_bShadowCreate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShaderDesc_set_bShadowCreate(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_GRShaderDesc_get_bShadowRender(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShaderDesc_set_bShadowRender(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_GRShaderDesc_get_bEnableBlending(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShaderDesc_set_bEnableBlending(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern int Spr_GRShaderDesc_get_numBlendMatrices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShaderDesc_set_numBlendMatrices(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRShaderFormat();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRShaderFormat(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRSphereDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRSphereDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_GRSphereDesc_get_radius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRSphereDesc_set_radius(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern int Spr_GRSphereDesc_get_slices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRSphereDesc_set_slices(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_GRSphereDesc_get_stacks(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRSphereDesc_set_stacks(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRVertexElement();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRVertexElement(IntPtr _this);
	[DllImport("SprExport")]
	public static extern short Spr_GRVertexElement_get_stream(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRVertexElement_set_stream(IntPtr _this, short value);
	[DllImport("SprExport")]
	public static extern short Spr_GRVertexElement_get_offset(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRVertexElement_set_offset(IntPtr _this, short value);
	[DllImport("SprExport")]
	public static extern byte Spr_GRVertexElement_get_type(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRVertexElement_set_type(IntPtr _this, byte value);
	[DllImport("SprExport")]
	public static extern byte Spr_GRVertexElement_get_method(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRVertexElement_set_method(IntPtr _this, byte value);
	[DllImport("SprExport")]
	public static extern byte Spr_GRVertexElement_get_usage(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRVertexElement_set_usage(IntPtr _this, byte value);
	[DllImport("SprExport")]
	public static extern byte Spr_GRVertexElement_get_usageIndex(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRVertexElement_set_usageIndex(IntPtr _this, byte value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_Position2f(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_Position3f(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_Position4f(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_Normal3f(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_TexCoords2f(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_TexCoords4f(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_Color4b(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_Color4f(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_Color3f(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_BlendNf(ulong o, ulong n);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_Blend4f(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_Blend3f(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_Blend2f(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_Blend1f(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_MatrixIndicesNf(ulong o, ulong n);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_NumBonesNf(ulong o, ulong n);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_MatrixIndices4f(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexElement_NumBones4f(ulong o);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRVertexArray();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRVertexArray(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexArray_addr_format(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRVertexArray_set_format(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexArray_get_buffer(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRVertexArray_set_buffer(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRVisualIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRVisualIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVisualIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRVisualIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVisualIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVisualIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_GRVisualIf_Render(IntPtr _this, IntPtr r);
	[DllImport("SprExport")]
	public static extern void Spr_GRVisualIf_Rendered(IntPtr _this, IntPtr r);
	[DllImport("SprExport")]
	public static extern void Spr_GRVisualIf_Enable(IntPtr _this, bool on);
	[DllImport("SprExport")]
	public static extern void Spr_GRVisualIf_Enable_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_GRVisualIf_IsEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVisualIf_GetMaterial(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRVisualIf_SetMaterial(IntPtr _this, IntPtr mat);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRFrameIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRFrameIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRFrameIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRFrameIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRFrameIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRFrameIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRFrameIf_GetParent(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRFrameIf_SetParent(IntPtr _this, IntPtr fr);
	[DllImport("SprExport")]
	public static extern int Spr_GRFrameIf_NChildren(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRFrameIf_GetChildren(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRDummyFrameIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRDummyFrameIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRDummyFrameIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRDummyFrameIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRDummyFrameIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRDummyFrameIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRAnimationIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRAnimationIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationIf_BlendPose(IntPtr _this, float time, float weight);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationIf_ResetPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationIf_LoadInitialPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationIf_GetAnimationKey(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern int Spr_GRAnimationIf_NAnimationKey(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationIf_DeletePose(IntPtr _this, float t);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRAnimationSetIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRAnimationSetIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationSetIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationSetIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationSetIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationSetIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationSetIf_BlendPose(IntPtr _this, float time, float weight);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationSetIf_ResetPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationSetIf_LoadInitialPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationSetIf_GetChildObject(IntPtr _this, ulong p);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationSetIf_SetCurrentAnimationPose(IntPtr _this, float t);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationSetIf_DeleteAnimationPose(IntPtr _this, float t);
	[DllImport("SprExport")]
	public static extern float Spr_GRAnimationSetIf_GetLastKeyTime(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRAnimationControllerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRAnimationControllerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationControllerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationControllerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationControllerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationControllerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationControllerIf_BlendPose(IntPtr _this, IntPtr name, float time, float weight);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationControllerIf_ResetPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRAnimationControllerIf_LoadInitialPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_GRAnimationControllerIf_AddChildObject(IntPtr _this, IntPtr o);
	[DllImport("SprExport")]
	public static extern char Spr_GRAnimationControllerIf_DelChildObject(IntPtr _this, IntPtr o);
	[DllImport("SprExport")]
	public static extern ulong Spr_GRAnimationControllerIf_NChildObject(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationControllerIf_GetChildObject(IntPtr _this, ulong p);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRAnimationControllerIf_GetAnimationSet(IntPtr _this, ulong p);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRBlendMeshIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRBlendMeshIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRBlendMeshIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRBlendMeshIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRBlendMeshIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRBlendMeshIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRSkinWeightIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRSkinWeightIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSkinWeightIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRSkinWeightIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSkinWeightIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSkinWeightIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRMeshIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRMeshIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMeshIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_GRMeshIf_NVertex(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_GRMeshIf_NTriangle(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_GRMeshIf_NFace(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshIf_GetVertices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshIf_GetNormals(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshIf_GetColors(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshIf_GetTexCoords(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshIf_GetFaces(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshIf_GetFaceNormals(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshIf_GetMaterialIndices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMeshIf_SwitchCoordinate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMeshIf_EnableTex3D(IntPtr _this, bool on);
	[DllImport("SprExport")]
	public static extern void Spr_GRMeshIf_EnableTex3D_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_GRMeshIf_IsTex3D(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMeshIf_CreateSkinWeight(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRLightIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRLightIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRLightIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRLightIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRLightIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRLightIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRMaterialIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRMaterialIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMaterialIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRMaterialIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMaterialIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRMaterialIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_GRMaterialIf_IsOpaque(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRCameraIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRCameraIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRCameraIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRCameraIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRCameraIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRCameraIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRCameraIf_GetFrame(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRCameraIf_SetFrame(IntPtr _this, IntPtr fr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRShadowLightIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRShadowLightIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRShadowLightIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShadowLightIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRShadowLightIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRShadowLightIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRRenderBaseIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRRenderBaseIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderBaseIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderBaseIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderBaseIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetViewport(IntPtr _this, IntPtr pos, IntPtr sz);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderBaseIf_GetViewportPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderBaseIf_GetViewportSize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_ClearBuffer(IntPtr _this, bool color, bool depth);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_ClearBuffer_1(IntPtr _this, bool color);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_ClearBuffer_2(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SwapBuffers(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_GetClearColor(IntPtr _this, IntPtr color);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetClearColor(IntPtr _this, IntPtr color);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_BeginScene(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_EndScene(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_PushProjectionMatrix(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_PopProjectionMatrix(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_PushModelMatrix(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_PopModelMatrix(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_ClearBlendMatrix(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetVertexFormat(IntPtr _this, IntPtr e);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawDirect(IntPtr _this, int ty, IntPtr vtx, ulong count, ulong stride);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawDirect_1(IntPtr _this, int ty, IntPtr vtx, ulong count);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawIndexed(IntPtr _this, int ty, uint idx, IntPtr vtx, ulong count, ulong stride);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawIndexed_1(IntPtr _this, int ty, uint idx, IntPtr vtx, ulong count);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawArrays(IntPtr _this, int ty, IntPtr arrays, ulong count);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawArrays_1(IntPtr _this, int ty, ulong idx, IntPtr arrays, ulong count);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawPoint(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawLine(IntPtr _this, IntPtr p0, IntPtr p1);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawSpline(IntPtr _this, IntPtr p0, IntPtr v0, IntPtr p1, IntPtr v1, int ndiv);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawSpline_1(IntPtr _this, IntPtr p0, IntPtr v0, IntPtr p1, IntPtr v1);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawArrow(IntPtr _this, IntPtr p0, IntPtr p1, float rbar, float rhead, float lhead, int slice, bool solid);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawBox(IntPtr _this, float sx, float sy, float sz, bool solid);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawBox_1(IntPtr _this, float sx, float sy, float sz);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawSphere(IntPtr _this, float radius, int slices, int stacks, bool solid);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawSphere_1(IntPtr _this, float radius, int slices, int stacks);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawEllipsoid(IntPtr _this, IntPtr radius, int slices, int stacks, bool solid);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawEllipsoid_1(IntPtr _this, IntPtr radius, int slices, int stacks);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawCone(IntPtr _this, float radius, float height, int slice, bool solid);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawCone_1(IntPtr _this, float radius, float height, int slice);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawCylinder(IntPtr _this, float radius, float height, int slice, bool solid, bool cap);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawCylinder_1(IntPtr _this, float radius, float height, int slice, bool solid);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawCylinder_2(IntPtr _this, float radius, float height, int slice);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawDisk(IntPtr _this, float radius, int slice, bool solid);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawDisk_1(IntPtr _this, float radius, int slice);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawCapsule(IntPtr _this, float radius, float height, int slice, bool solid);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawCapsule_1(IntPtr _this, float radius, float height, int slice);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawCapsule_2(IntPtr _this, float radius, float height);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawRoundCone(IntPtr _this, float rbottom, float rtop, float height, int slice, bool solid);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawRoundCone_1(IntPtr _this, float rbottom, float rtop, float height, int slice);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawRoundCone_2(IntPtr _this, float rbottom, float rtop, float height);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawGrid(IntPtr _this, float size, int slice, float lineWidth);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawGrid_1(IntPtr _this, float size, int slice);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawCurve(IntPtr _this, IntPtr curve);
	[DllImport("SprExport")]
	public static extern int Spr_GRRenderBaseIf_StartList(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_EndList(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawList(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_ReleaseList(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetFont(IntPtr _this, IntPtr font);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawFont(IntPtr _this, IntPtr pos, IntPtr str);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_DrawFont_1(IntPtr _this, IntPtr pos, IntPtr str);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetMaterial(IntPtr _this, IntPtr mat);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetMaterial_1(IntPtr _this, IntPtr mat);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetMaterial_2(IntPtr _this, int matname);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetMaterial_3(IntPtr _this, int matname, float alpha);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetPointSize(IntPtr _this, float sz, bool smooth);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetPointSize_1(IntPtr _this, float sz);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetLineWidth(IntPtr _this, float w, bool smooth);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetLineWidth_1(IntPtr _this, float w);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_PushLight(IntPtr _this, IntPtr light);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_PushLight_1(IntPtr _this, IntPtr light);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_PopLight(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_GRRenderBaseIf_NLights(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetDepthWrite(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetDepthTest(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetDepthFunc(IntPtr _this, int f);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetAlphaTest(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetAlphaMode(IntPtr _this, int src, int dest);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetLighting(IntPtr _this, bool l);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetTexture2D(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetTexture3D(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern uint Spr_GRRenderBaseIf_LoadTexture(IntPtr _this, IntPtr filename);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetTextureImage(IntPtr _this, IntPtr id, int components, int xsize, int ysize, int format, string tb);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetBlending(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderBaseIf_CreateShader(IntPtr _this, IntPtr sd);
	[DllImport("SprExport")]
	public static extern char Spr_GRRenderBaseIf_SetShader(IntPtr _this, IntPtr shader);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_SetShadowLight(IntPtr _this, IntPtr sld);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_EnterShadowMapGeneration(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderBaseIf_LeaveShadowMapGeneration(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRRenderIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRRenderIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderIf_SetDevice(IntPtr _this, IntPtr dev);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderIf_GetDevice(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderIf_SetCamera(IntPtr _this, IntPtr cam);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderIf_GetCamera(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderIf_Reshape(IntPtr _this, IntPtr pos, IntPtr screenSize);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderIf_GetPixelSize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderIf_GetReservedColor(IntPtr _this, int matname);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderIf_ScreenToCamera(IntPtr _this, int x, int y, float depth, bool LorR);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRRenderIf_ScreenToCamera_1(IntPtr _this, int x, int y, float depth);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderIf_EnterScreenCoordinate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRRenderIf_LeaveScreenCoordinate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRDeviceIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRDeviceIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRDeviceIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRDeviceIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRDeviceIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRDeviceIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_GRDeviceIf_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRDeviceGLIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRDeviceGLIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRDeviceGLIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRDeviceGLIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRDeviceGLIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRDeviceGLIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_GRDeviceGLIf_CheckGLVersion(IntPtr _this, int major, int minor);
	[DllImport("SprExport")]
	public static extern int Spr_GRDeviceGLIf_GetGLMajorVersion(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_GRDeviceGLIf_GetGLMinorVersion(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRDeviceGLIf_SetGLVersion(IntPtr _this, int major, int minor);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRSceneIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRSceneIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSceneIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRSceneIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSceneIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSceneIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_GRSceneIf_Render(IntPtr _this, IntPtr r);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSceneIf_GetWorld(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSceneIf_GetCamera(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRSceneIf_SetCamera(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern void Spr_GRSceneIf_SetCamera_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSceneIf_GetAnimationController(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSceneIf_GetSdk(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRSdkIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRSdkIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSdkIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRSdkIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSdkIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSdkIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSdkIf_CreateRender(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSdkIf_CreateDeviceGL(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSdkIf_CreateScene(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSdkIf_CreateScene_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSdkIf_GetScene(IntPtr _this, ulong i);
	[DllImport("SprExport")]
	public static extern ulong Spr_GRSdkIf_NScene(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRSdkIf_MergeScene(IntPtr _this, IntPtr scene0, IntPtr scene1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSdkIf_CreateSdk();
	[DllImport("SprExport")]
	public static extern void Spr_GRSdkIf_RegisterSdk();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRShaderIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRShaderIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRShaderIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRShaderIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRShaderIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRShaderIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_GRShaderIf_GetProgramID(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_GRSphereIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_GRSphereIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSphereIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_GRSphereIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSphereIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRSphereIf_GetIfInfoStatic();
    }
}
