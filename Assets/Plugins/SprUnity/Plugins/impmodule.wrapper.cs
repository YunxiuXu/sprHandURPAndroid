using System;
using System.Runtime.InteropServices;
namespace SprCs {
    public partial class SprExport {
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_new_GRMeshFace(int _size);
	[DllImport("SprExport")]
	public static extern void Spr_array_delete_GRMeshFace(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_get_GRMeshFace(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_array_set_GRMeshFace(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_new_PHOpGroupDesc(int _size);
	[DllImport("SprExport")]
	public static extern void Spr_array_delete_PHOpGroupDesc(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_get_PHOpGroupDesc(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_array_set_PHOpGroupDesc(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_new_PHOpObjDesc(int _size);
	[DllImport("SprExport")]
	public static extern void Spr_array_delete_PHOpObjDesc(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_get_PHOpObjDesc(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_array_set_PHOpObjDesc(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_new_PHOpParticleDesc(int _size);
	[DllImport("SprExport")]
	public static extern void Spr_array_delete_PHOpParticleDesc(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_get_PHOpParticleDesc(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_array_set_PHOpParticleDesc(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_new_PHRaycastHit(int _size);
	[DllImport("SprExport")]
	public static extern void Spr_array_delete_PHRaycastHit(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_get_PHRaycastHit(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_array_set_PHRaycastHit(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_new_Vec2f(int _size);
	[DllImport("SprExport")]
	public static extern void Spr_array_delete_Vec2f(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_get_Vec2f(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_array_set_Vec2f(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_new_Vec3f(int _size);
	[DllImport("SprExport")]
	public static extern void Spr_array_delete_Vec3f(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_get_Vec3f(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_array_set_Vec3f(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_new_Vec4f(int _size);
	[DllImport("SprExport")]
	public static extern void Spr_array_delete_Vec4f(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_array_get_Vec4f(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_array_set_Vec4f(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRFrameDesc_struct_get_Affinef(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_GRFrameDesc_struct_set_Affinef(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRaycastHit_struct_get_CDShapeIf_p(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHRaycastHit_struct_set_CDShapeIf_p(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRVertexArray_struct_get_GRVertexElement(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_GRVertexArray_struct_set_GRVertexElement(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidDesc_struct_get_Matrix3d(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidDesc_struct_set_Matrix3d(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_struct_get_Matrix3f(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_struct_set_Matrix3f(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern int Spr_PHHapticPointerDesc_struct_get_PHHapticPointerDesc_HapticRenderMode(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerDesc_struct_set_PHHapticPointerDesc_HapticRenderMode(IntPtr _ptr, int index, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CDShapeDesc_struct_get_PHMaterial(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_CDShapeDesc_struct_set_PHMaterial(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticControllerDesc_struct_get_PHOpHapticControllerDesc_HapticDOFType(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_struct_set_PHOpHapticControllerDesc_HapticDOFType(IntPtr _ptr, int index, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRaycastHit_struct_get_PHSolidIf_p(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHRaycastHit_struct_set_PHSolidIf_p(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFrameDesc_struct_get_Posed(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHFrameDesc_struct_set_Posed(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerDesc_struct_get_Posef(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_struct_set_Posef(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorDesc_struct_get_Quaterniond(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_struct_set_Quaterniond(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_struct_get_Quaternionf(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_struct_set_Quaternionf(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPointToPlaneMateDesc_struct_get_Vec2d(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHPointToPlaneMateDesc_struct_set_Vec2d(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HITrackballDesc_struct_get_Vec2f(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_struct_set_Vec2f(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemPorousWOMoveDesc_struct_get_Vec3d(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_struct_set_Vec3d(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticRendererDesc_struct_get_Vec3f(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_struct_set_Vec3f(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpObjDesc_struct_get_Vec3f_p(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_struct_set_Vec3f_p(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWUngroundedConstraint_struct_get_Vec3i(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_FWUngroundedConstraint_struct_set_Vec3i(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHuman1DJointResistanceDesc_struct_get_Vec4d(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHHuman1DJointResistanceDesc_struct_set_Vec4d(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_GRLightDesc_struct_get_Vec4f(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_GRLightDesc_struct_set_Vec4f(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringDesc_struct_get_Vec6d(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringDesc_struct_set_Vec6d(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_new_GRAnimationKey();
	[DllImport("SprExport")]
	public static extern void Spr_vector_delete_GRAnimationKey(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_get_GRAnimationKey(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_vector_set_GRAnimationKey(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern int Spr_vector_size_GRAnimationKey(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern void Spr_vector_push_back_GRAnimationKey(IntPtr _ptr, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_vector_clear_GRAnimationKey(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_new_GRKey();
	[DllImport("SprExport")]
	public static extern void Spr_vector_delete_GRKey(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_get_GRKey(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_vector_set_GRKey(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern int Spr_vector_size_GRKey(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern void Spr_vector_push_back_GRKey(IntPtr _ptr, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_vector_clear_GRKey(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_new_GRMeshFace();
	[DllImport("SprExport")]
	public static extern void Spr_vector_delete_GRMeshFace(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_get_GRMeshFace(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_vector_set_GRMeshFace(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern int Spr_vector_size_GRMeshFace(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern void Spr_vector_push_back_GRMeshFace(IntPtr _ptr, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_vector_clear_GRMeshFace(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_new_HISpidarMotorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_vector_delete_HISpidarMotorDesc(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_get_HISpidarMotorDesc(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_vector_set_HISpidarMotorDesc(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern int Spr_vector_size_HISpidarMotorDesc(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern void Spr_vector_push_back_HISpidarMotorDesc(IntPtr _ptr, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_vector_clear_HISpidarMotorDesc(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_new_PHPathPoint();
	[DllImport("SprExport")]
	public static extern void Spr_vector_delete_PHPathPoint(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_get_PHPathPoint(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_vector_set_PHPathPoint(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern int Spr_vector_size_PHPathPoint(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern void Spr_vector_push_back_PHPathPoint(IntPtr _ptr, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_vector_clear_PHPathPoint(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_new_PHSplineLimitNode();
	[DllImport("SprExport")]
	public static extern void Spr_vector_delete_PHSplineLimitNode(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_get_PHSplineLimitNode(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_vector_set_PHSplineLimitNode(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern int Spr_vector_size_PHSplineLimitNode(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern void Spr_vector_push_back_PHSplineLimitNode(IntPtr _ptr, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_vector_clear_PHSplineLimitNode(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_new_Vec2f();
	[DllImport("SprExport")]
	public static extern void Spr_vector_delete_Vec2f(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_get_Vec2f(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_vector_set_Vec2f(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern int Spr_vector_size_Vec2f(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern void Spr_vector_push_back_Vec2f(IntPtr _ptr, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_vector_clear_Vec2f(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_new_Vec3d();
	[DllImport("SprExport")]
	public static extern void Spr_vector_delete_Vec3d(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_get_Vec3d(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_vector_set_Vec3d(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern int Spr_vector_size_Vec3d(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern void Spr_vector_push_back_Vec3d(IntPtr _ptr, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_vector_clear_Vec3d(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_new_Vec3f();
	[DllImport("SprExport")]
	public static extern void Spr_vector_delete_Vec3f(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_get_Vec3f(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_vector_set_Vec3f(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern int Spr_vector_size_Vec3f(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern void Spr_vector_push_back_Vec3f(IntPtr _ptr, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_vector_clear_Vec3f(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_new_Vec4f();
	[DllImport("SprExport")]
	public static extern void Spr_vector_delete_Vec4f(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_vector_get_Vec4f(IntPtr _ptr, int index);
	[DllImport("SprExport")]
	public static extern void Spr_vector_set_Vec4f(IntPtr _ptr, int index, IntPtr value);
	[DllImport("SprExport")]
	public static extern int Spr_vector_size_Vec4f(IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern void Spr_vector_push_back_Vec4f(IntPtr _ptr, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_vector_clear_Vec4f(IntPtr _ptr);
   } 
} 
