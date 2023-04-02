using System;
using System.Runtime.InteropServices;
namespace SprCs {
    public partial class SprExport {
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHMaterial();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHMaterial(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_density(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_density(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_mu(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_mu(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_mu0(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_mu0(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_e(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_e(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_rotationFriction(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_rotationFriction(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_spring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_spring(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_damper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_damper(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_reflexSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_reflexSpring(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_reflexDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_reflexDamper(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_frictionSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_frictionSpring(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_frictionDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_frictionDamper(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_vibA(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_vibA(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_vibB(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_vibB(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_vibW(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_vibW(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_vibT(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_vibT(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern char Spr_PHMaterial_get_vibContact(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_vibContact(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHMaterial_get_vibFric(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_vibFric(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_timeVaryFrictionA(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_timeVaryFrictionA(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_timeVaryFrictionB(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_timeVaryFrictionB(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_timeVaryFrictionC(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_timeVaryFrictionC(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_frictionViscosity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_frictionViscosity(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_stribeckVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_stribeckVelocity(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHMaterial_get_stribeckmu(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_stribeckmu(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMaterial_vector_addr_mus(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_vector_set_mus(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMaterial_vector_addr_mu0s(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_vector_set_mu0s(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMaterial_vector_addr_timeVaryFrictionAs(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_vector_set_timeVaryFrictionAs(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMaterial_vector_addr_timeVaryFrictionBs(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_vector_set_timeVaryFrictionBs(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMaterial_vector_addr_timeVaryFrictionDs(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_vector_set_timeVaryFrictionDs(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMaterial_vector_addr_timeVaryFrictionCs(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_vector_set_timeVaryFrictionCs(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMaterial_vector_addr_stribeckVelocitys(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_vector_set_stribeckVelocitys(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMaterial_vector_addr_stribeckmus(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_vector_set_stribeckmus(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMaterial_vector_addr_c(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_vector_set_c(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMaterial_vector_addr_bristleK(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_vector_set_bristleK(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern int Spr_PHMaterial_get_velocityFieldMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_velocityFieldMode(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMaterial_addr_velocityFieldAxis(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_velocityFieldAxis(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern double Spr_PHMaterial_get_velocityFieldMagnitude(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMaterial_set_velocityFieldMagnitude(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMaterial_CalcVelocity(IntPtr _this, IntPtr pos, IntPtr normal);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDShapeDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDShapeDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapeDesc_addr_material(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeDesc_set_material(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDConvexMeshDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDConvexMeshDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDConvexMeshDesc_vector_get_vertices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDConvexMeshDesc_vector_set_vertices(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDConvexMeshInterpolateDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDConvexMeshInterpolateDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDSphereDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDSphereDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_CDSphereDesc_get_radius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDSphereDesc_set_radius(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDEllipsoidDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDEllipsoidDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDEllipsoidDesc_addr_radius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDEllipsoidDesc_set_radius(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDCapsuleDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDCapsuleDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_CDCapsuleDesc_get_radius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDCapsuleDesc_set_radius(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_CDCapsuleDesc_get_length(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDCapsuleDesc_set_length(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDRoundConeDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDRoundConeDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDRoundConeDesc_addr_radius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDRoundConeDesc_set_radius(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_CDRoundConeDesc_get_length(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDRoundConeDesc_set_length(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDBoxDesc();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDBoxDesc_2(IntPtr bs);
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDBoxDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDBoxDesc_addr_boxsize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDBoxDesc_set_boxsize(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDShapePairState();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDShapePairState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapePairState_addr_normal(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapePairState_set_normal(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern double Spr_CDShapePairState_get_depth(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapePairState_set_depth(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern uint Spr_CDShapePairState_get_lastContactCount(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapePairState_set_lastContactCount(IntPtr _this, uint value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDBounds();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDBounds_3(IntPtr min0, IntPtr max0);
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDBounds(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDBounds_addr_min(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDBounds_set_min(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDBounds_addr_max(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDBounds_set_max(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern void Spr_CDBounds_set(IntPtr _this, IntPtr min0, IntPtr max0);
	[DllImport("SprExport")]
	public static extern void Spr_CDBounds_clamp(IntPtr _this, IntPtr pos);
	[DllImport("SprExport")]
	public static extern char Spr_CDBounds_isEmpty(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDBounds_minimum(IntPtr _this, IntPtr self, IntPtr other);
	[DllImport("SprExport")]
	public static extern void Spr_CDBounds_maximum(IntPtr _this, IntPtr self, IntPtr other);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDSpatialHashTableDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDSpatialHashTableDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDShapeIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDShapeIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapeIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapeIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapeIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetStaticFriction(IntPtr _this, float mu0);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_GetStaticFriction(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetDynamicFriction(IntPtr _this, float mu);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_GetDynamicFriction(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetElasticity(IntPtr _this, float e);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_GetElasticity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetDensity(IntPtr _this, float d);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_GetDensity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetContactSpring(IntPtr _this, float K);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_GetContactSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetContactDamper(IntPtr _this, float D);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_GetContactDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetReflexSpring(IntPtr _this, float K);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_GetReflexSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetReflexDamper(IntPtr _this, float D);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_GetReflexDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetFrictionSpring(IntPtr _this, float K);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_GetFrictionSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetFrictionDamper(IntPtr _this, float D);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_GetFrictionDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetVibration(IntPtr _this, float vibA, float vibB, float vibW);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetVibA(IntPtr _this, float vibA);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_GetVibA(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetVibB(IntPtr _this, float vibB);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_GetVibB(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetVibW(IntPtr _this, float vibW);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_GetVibW(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetVibT(IntPtr _this, float vibT);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_GetVibT(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetVibContact(IntPtr _this, bool vibContact);
	[DllImport("SprExport")]
	public static extern char Spr_CDShapeIf_GetVibContact(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapeIf_GetMaterial(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_SetMaterial(IntPtr _this, IntPtr mat);
	[DllImport("SprExport")]
	public static extern float Spr_CDShapeIf_CalcVolume(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapeIf_CalcCenterOfMass(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapeIf_CalcMomentOfInertia(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_CDShapeIf_IsInside(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_CalcBBox(IntPtr _this, IntPtr bbmin, IntPtr bbmax, IntPtr pose);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeIf_CalcBBox_1(IntPtr _this, IntPtr bbmin, IntPtr bbmax);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDConvexIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDConvexIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDConvexIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDConvexIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDConvexIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDConvexIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern double Spr_CDConvexIf_CurvatureRadius(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDConvexIf_Normal(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDFaceIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDFaceIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDFaceIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDFaceIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDFaceIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDFaceIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_CDFaceIf_NIndex(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDFaceIf_GetIndices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDQuadFaceIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDQuadFaceIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDQuadFaceIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDQuadFaceIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDQuadFaceIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDQuadFaceIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_CDQuadFaceIf_NIndex(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDQuadFaceIf_GetIndices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDConvexMeshIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDConvexMeshIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDConvexMeshIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDConvexMeshIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDConvexMeshIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDConvexMeshIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDConvexMeshIf_GetFace(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern int Spr_CDConvexMeshIf_NFace(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDConvexMeshIf_GetVertices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_CDConvexMeshIf_NVertex(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDConvexMeshInterpolateIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDConvexMeshInterpolateIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDConvexMeshInterpolateIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDConvexMeshInterpolateIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDConvexMeshInterpolateIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDConvexMeshInterpolateIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDSphereIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDSphereIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDSphereIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDSphereIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDSphereIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDSphereIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern float Spr_CDSphereIf_GetRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDSphereIf_SetRadius(IntPtr _this, float r);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDEllipsoidIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDEllipsoidIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDEllipsoidIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDEllipsoidIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDEllipsoidIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDEllipsoidIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDEllipsoidIf_GetRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDEllipsoidIf_SetRadius(IntPtr _this, IntPtr r);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDCapsuleIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDCapsuleIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDCapsuleIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDCapsuleIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDCapsuleIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDCapsuleIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern float Spr_CDCapsuleIf_GetRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDCapsuleIf_SetRadius(IntPtr _this, float r);
	[DllImport("SprExport")]
	public static extern float Spr_CDCapsuleIf_GetLength(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDCapsuleIf_SetLength(IntPtr _this, float l);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDRoundConeIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDRoundConeIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDRoundConeIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDRoundConeIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDRoundConeIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDRoundConeIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDRoundConeIf_GetRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_CDRoundConeIf_GetLength(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDRoundConeIf_SetRadius(IntPtr _this, IntPtr r);
	[DllImport("SprExport")]
	public static extern void Spr_CDRoundConeIf_SetLength(IntPtr _this, float l);
	[DllImport("SprExport")]
	public static extern void Spr_CDRoundConeIf_SetWidth(IntPtr _this, IntPtr r);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDBoxIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDBoxIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDBoxIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDBoxIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDBoxIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDBoxIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDBoxIf_GetBoxSize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDBoxIf_GetVertices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDBoxIf_GetFace(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDBoxIf_SetBoxSize(IntPtr _this, IntPtr boxsize);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDShapePairIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDShapePairIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapePairIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapePairIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapePairIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapePairIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapePairIf_GetShape(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapePairIf_GetShapePose(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapePairIf_GetClosestPointOnWorld(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapePairIf_GetNormal(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CDSpatialHashTableIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CDSpatialHashTableIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDSpatialHashTableIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CDSpatialHashTableIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDSpatialHashTableIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDSpatialHashTableIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_CDSpatialHashTableIf_Init(IntPtr _this, float cellSize, IntPtr bounds);
	[DllImport("SprExport")]
	public static extern char Spr_CDSpatialHashTableIf_ReducedSelectPointsToAdd(IntPtr _this, IntPtr pCtr, float radius, int objInd, int pInd, int timestamp);
    }
}
