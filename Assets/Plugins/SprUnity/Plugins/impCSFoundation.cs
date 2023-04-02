using System;
using System.Runtime.InteropServices;
namespace SprCs {
    public partial class SprExport {
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_ObjectIfs();
	[DllImport("SprExport")]
	public static extern void Spr_delete_ObjectIfs(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_ObjectIfs_Push(IntPtr _this, IntPtr obj);
	[DllImport("SprExport")]
	public static extern void Spr_ObjectIfs_Pop(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ObjectIfs_Top(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTAccessBase_Create(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_UTAccessBase_Delete(IntPtr _this, IntPtr ptr_);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTAccessBase_VectorPush(IntPtr _this, IntPtr v);
	[DllImport("SprExport")]
	public static extern void Spr_UTAccessBase_VectorPop(IntPtr _this, IntPtr v);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTAccessBase_VectorAt(IntPtr _this, IntPtr v, int pos);
	[DllImport("SprExport")]
	public static extern ulong Spr_UTAccessBase_VectorSize(IntPtr _this, IntPtr v);
	[DllImport("SprExport")]
	public static extern ulong Spr_UTAccessBase_SizeOfVector(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec2f();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec2f_3(float x, float y);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Vec2f(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_neg_vv_Vec2f(IntPtr ptr1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_vvv_Vec2f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_vvv_Vec2f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vfv_Vec2f(float a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vvf_Vec2f(IntPtr ptr1, float b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_div_vvf_Vec2f(IntPtr ptr1, float b);
	[DllImport("SprExport")]
	public static extern float Spr_binary_operator_sprod_fvv_Vec2f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern float Spr_binary_operator_vprod1_fvv_Vec2f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern float Spr_binary_operator_vprod2_fvv_Vec2f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_eq_bvv_Vec2f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_ne_bvv_Vec2f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern float Spr_unary_operator_index_fi_get_Vec2f(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_unary_operator_index_fi_set_Vec2f(IntPtr _this, int i, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Vec2f_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec2f_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern float Spr_Vec2f_get_x(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec2f_set_x(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec2f_get_y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec2f_set_y(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec2f_square(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Vec2f_norm(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec2f_unitize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec2d();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec2d_3(double x, double y);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Vec2d(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_neg_vv_Vec2d(IntPtr ptr1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_vvv_Vec2d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_vvv_Vec2d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vdv_Vec2d(double a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vvd_Vec2d(IntPtr ptr1, double b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_div_vvd_Vec2d(IntPtr ptr1, double b);
	[DllImport("SprExport")]
	public static extern double Spr_binary_operator_sprod_dvv_Vec2d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern double Spr_binary_operator_vprod1_dvv_Vec2d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern double Spr_binary_operator_vprod2_dvv_Vec2d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_eq_bvv_Vec2d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_ne_bvv_Vec2d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern double Spr_unary_operator_index_di_get_Vec2d(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_unary_operator_index_di_set_Vec2d(IntPtr _this, int i, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Vec2d_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec2d_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern double Spr_Vec2d_get_x(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec2d_set_x(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec2d_get_y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec2d_set_y(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec2d_square(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Vec2d_norm(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec2d_unitize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec3f();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec3f_4(float x, float y, float z);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Vec3f(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_neg_vv_Vec3f(IntPtr ptr1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_vvv_Vec3f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_vvv_Vec3f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vfv_Vec3f(float a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vvf_Vec3f(IntPtr ptr1, float b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_div_vvf_Vec3f(IntPtr ptr1, float b);
	[DllImport("SprExport")]
	public static extern float Spr_binary_operator_sprod_fvv_Vec3f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_vprod1_vvv_Vec3f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_vprod2_vvv_Vec3f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_eq_bvv_Vec3f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_ne_bvv_Vec3f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern float Spr_unary_operator_index_fi_get_Vec3f(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_unary_operator_index_fi_set_Vec3f(IntPtr _this, int i, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Vec3f_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3f_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern float Spr_Vec3f_get_x(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3f_set_x(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec3f_get_y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3f_set_y(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec3f_get_z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3f_set_z(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec3f_square(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Vec3f_norm(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3f_unitize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec3d();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec3d_4(double x, double y, double z);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Vec3d(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_neg_vv_Vec3d(IntPtr ptr1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_vvv_Vec3d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_vvv_Vec3d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vdv_Vec3d(double a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vvd_Vec3d(IntPtr ptr1, double b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_div_vvd_Vec3d(IntPtr ptr1, double b);
	[DllImport("SprExport")]
	public static extern double Spr_binary_operator_sprod_dvv_Vec3d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_vprod1_vvv_Vec3d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_vprod2_vvv_Vec3d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_eq_bvv_Vec3d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_ne_bvv_Vec3d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern double Spr_unary_operator_index_di_get_Vec3d(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_unary_operator_index_di_set_Vec3d(IntPtr _this, int i, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Vec3d_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3d_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern double Spr_Vec3d_get_x(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3d_set_x(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec3d_get_y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3d_set_y(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec3d_get_z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3d_set_z(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec3d_square(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Vec3d_norm(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3d_unitize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec4f();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec4f_5(float x, float y, float z, float w);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Vec4f(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_neg_vv_Vec4f(IntPtr ptr1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_vvv_Vec4f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_vvv_Vec4f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vfv_Vec4f(float a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vvf_Vec4f(IntPtr ptr1, float b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_div_vvf_Vec4f(IntPtr ptr1, float b);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_eq_bvv_Vec4f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_ne_bvv_Vec4f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern float Spr_unary_operator_index_fi_get_Vec4f(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_unary_operator_index_fi_set_Vec4f(IntPtr _this, int i, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Vec4f_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4f_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern float Spr_Vec4f_get_x(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4f_set_x(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec4f_get_y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4f_set_y(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec4f_get_z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4f_set_z(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec4f_get_w(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4f_set_w(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec4f_square(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Vec4f_norm(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4f_unitize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec4d();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec4d_5(double x, double y, double z, double w);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Vec4d(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_neg_vv_Vec4d(IntPtr ptr1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_vvv_Vec4d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_vvv_Vec4d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vdv_Vec4d(double a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vvd_Vec4d(IntPtr ptr1, double b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_div_vvd_Vec4d(IntPtr ptr1, double b);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_eq_bvv_Vec4d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_ne_bvv_Vec4d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern double Spr_unary_operator_index_di_get_Vec4d(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_unary_operator_index_di_set_Vec4d(IntPtr _this, int i, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Vec4d_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4d_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern double Spr_Vec4d_get_x(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4d_set_x(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec4d_get_y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4d_set_y(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec4d_get_z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4d_set_z(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec4d_get_w(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4d_set_w(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec4d_square(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Vec4d_norm(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4d_unitize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Quaternionf();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Quaternionf_5(float w, float x, float y, float z);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Quaternionf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_qqq_Quaternionf(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_qqq_Quaternionf(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_qfq_Quaternionf(float a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_qqf_Quaternionf(IntPtr ptr1, float b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_div_qqf_Quaternionf(IntPtr ptr1, float b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sprod_vqv_Quaternionf(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sprod_qqq_Quaternionf(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sprod_mqm_Quaternionf(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaternionf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Quaternionf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern float Spr_Quaternionf_get_x(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Quaternionf_set_x(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Quaternionf_get_y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Quaternionf_set_y(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Quaternionf_get_z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Quaternionf_set_z(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Quaternionf_get_w(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Quaternionf_set_w(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Quaternionf_W(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Quaternionf_X(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Quaternionf_Y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Quaternionf_Z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaternionf_V(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaternionf_RotationHalf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaternionf_Rotation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaternionf_Axis(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Quaternionf_Theta(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaternionf_Rot(float angle, IntPtr axis);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaternionf_Rot_1(float angle, sbyte axis);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaternionf_Rot_2(IntPtr rot);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaternionf_Inv(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Quaternionf_Conjugate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaternionf_Conjugated(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Quaternionf_RotationArc(IntPtr _this, IntPtr lhs, IntPtr rhs);
	[DllImport("SprExport")]
	public static extern void Spr_Quaternionf_Euler(IntPtr _this, float heading, float attitude, float bank);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Quaterniond();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Quaterniond_5(double w, double x, double y, double z);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Quaterniond(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_qqq_Quaterniond(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_qqq_Quaterniond(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_qdq_Quaterniond(double a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_qqd_Quaterniond(IntPtr ptr1, double b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_div_qqd_Quaterniond(IntPtr ptr1, double b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sprod_vqv_Quaterniond(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sprod_qqq_Quaterniond(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sprod_mqm_Quaterniond(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaterniond_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Quaterniond_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern double Spr_Quaterniond_get_x(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Quaterniond_set_x(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Quaterniond_get_y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Quaterniond_set_y(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Quaterniond_get_z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Quaterniond_set_z(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Quaterniond_get_w(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Quaterniond_set_w(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Quaterniond_W(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Quaterniond_X(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Quaterniond_Y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Quaterniond_Z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaterniond_V(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaterniond_RotationHalf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaterniond_Rotation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaterniond_Axis(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Quaterniond_Theta(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaterniond_Rot(double angle, IntPtr axis);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaterniond_Rot_1(double angle, sbyte axis);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaterniond_Rot_2(IntPtr rot);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaterniond_Inv(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Quaterniond_Conjugate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Quaterniond_Conjugated(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Quaterniond_RotationArc(IntPtr _this, IntPtr lhs, IntPtr rhs);
	[DllImport("SprExport")]
	public static extern void Spr_Quaterniond_Euler(IntPtr _this, double heading, double attitude, double bank);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Posef();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Posef_8(IntPtr p, IntPtr q);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Posef_9(float w, float x, float y, float z, float px, float py, float pz);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Posef(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sprod_vpv_Posef(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sprod_ppp_Posef(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posef_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posef_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_get_w(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posef_set_w(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_get_x(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posef_set_x(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_get_y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posef_set_y(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_get_z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posef_set_z(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_get_px(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posef_set_px(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_get_py(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posef_set_py(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_get_pz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posef_set_pz(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posef_Pos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posef_Ori(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_W(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_X(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_Y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_Z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_Px(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_Py(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_Pz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_PosX(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_PosY(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_PosZ(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_OriX(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_OriY(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_OriZ(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Posef_OriW(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posef_Inv(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posef_Unit();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posef_Trn(float px, float py, float pz);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posef_Trn_1(IntPtr v);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posef_Rot(float wi, float xi, float yi, float zi);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posef_Rot_1(float angle, IntPtr axis);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posef_Rot_2(float angle, sbyte axis);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posef_Rot_3(IntPtr rot);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posef_Rot_4(IntPtr q);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Posed();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Posed_8(IntPtr p, IntPtr q);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Posed_9(double w, double x, double y, double z, double px, double py, double pz);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Posed(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sprod_vpv_Posed(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sprod_ppp_Posed(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posed_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posed_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_get_w(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posed_set_w(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_get_x(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posed_set_x(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_get_y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posed_set_y(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_get_z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posed_set_z(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_get_px(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posed_set_px(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_get_py(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posed_set_py(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_get_pz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Posed_set_pz(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posed_Pos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posed_Ori(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_W(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_X(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_Y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_Z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_Px(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_Py(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_Pz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_PosX(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_PosY(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_PosZ(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_OriX(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_OriY(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_OriZ(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Posed_OriW(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posed_Inv(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posed_Unit();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posed_Trn(double px, double py, double pz);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posed_Trn_1(IntPtr v);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posed_Rot(double wi, double xi, double yi, double zi);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posed_Rot_1(double angle, IntPtr axis);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posed_Rot_2(double angle, sbyte axis);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posed_Rot_3(IntPtr rot);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Posed_Rot_4(IntPtr q);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec2i();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec2i_3(int x, int y);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Vec2i(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_neg_vv_Vec2i(IntPtr ptr1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_vvv_Vec2i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_vvv_Vec2i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_viv_Vec2i(int a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vvi_Vec2i(IntPtr ptr1, int b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_div_vvi_Vec2i(IntPtr ptr1, int b);
	[DllImport("SprExport")]
	public static extern int Spr_binary_operator_sprod_ivv_Vec2i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern int Spr_binary_operator_vprod1_ivv_Vec2i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern int Spr_binary_operator_vprod2_ivv_Vec2i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_eq_bvv_Vec2i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_ne_bvv_Vec2i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern int Spr_unary_operator_index_ii_get_Vec2i(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_unary_operator_index_ii_set_Vec2i(IntPtr _this, int i, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Vec2i_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec2i_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern int Spr_Vec2i_get_x(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec2i_set_x(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_Vec2i_get_y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec2i_set_y(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_Vec2i_square(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_Vec2i_norm(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec2i_unitize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec3i();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec3i_4(int x, int y, int z);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Vec3i(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_neg_vv_Vec3i(IntPtr ptr1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_vvv_Vec3i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_vvv_Vec3i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_viv_Vec3i(int a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vvi_Vec3i(IntPtr ptr1, int b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_div_vvi_Vec3i(IntPtr ptr1, int b);
	[DllImport("SprExport")]
	public static extern int Spr_binary_operator_sprod_ivv_Vec3i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_vprod1_vvv_Vec3i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_vprod2_vvv_Vec3i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_eq_bvv_Vec3i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_ne_bvv_Vec3i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern int Spr_unary_operator_index_ii_get_Vec3i(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_unary_operator_index_ii_set_Vec3i(IntPtr _this, int i, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Vec3i_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3i_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern int Spr_Vec3i_get_x(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3i_set_x(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_Vec3i_get_y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3i_set_y(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_Vec3i_get_z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3i_set_z(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_Vec3i_square(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_Vec3i_norm(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec3i_unitize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec4i();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec4i_5(int x, int y, int z, int w);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Vec4i(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_neg_vv_Vec4i(IntPtr ptr1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_vvv_Vec4i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_vvv_Vec4i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_viv_Vec4i(int a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vvi_Vec4i(IntPtr ptr1, int b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_div_vvi_Vec4i(IntPtr ptr1, int b);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_eq_bvv_Vec4i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_ne_bvv_Vec4i(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern int Spr_unary_operator_index_ii_get_Vec4i(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_unary_operator_index_ii_set_Vec4i(IntPtr _this, int i, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Vec4i_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4i_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern int Spr_Vec4i_get_x(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4i_set_x(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_Vec4i_get_y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4i_set_y(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_Vec4i_get_z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4i_set_z(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_Vec4i_get_w(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4i_set_w(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_Vec4i_square(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_Vec4i_norm(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec4i_unitize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec6f();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec6f_7(float vx, float vy, float vz, float wx, float wy, float wz);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Vec6f(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_neg_vv_Vec6f(IntPtr ptr1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_vvv_Vec6f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_vvv_Vec6f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vfv_Vec6f(float a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vvf_Vec6f(IntPtr ptr1, float b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_div_vvf_Vec6f(IntPtr ptr1, float b);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_eq_bvv_Vec6f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_ne_bvv_Vec6f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern float Spr_unary_operator_index_fi_get_Vec6f(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_unary_operator_index_fi_set_Vec6f(IntPtr _this, int i, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Vec6f_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6f_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern float Spr_Vec6f_get_vx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6f_set_vx(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec6f_get_vy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6f_set_vy(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec6f_get_vz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6f_set_vz(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec6f_get_wx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6f_set_wx(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec6f_get_wy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6f_set_wy(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec6f_get_wz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6f_set_wz(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Vec6f_square(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_Vec6f_norm(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6f_unitize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec6d();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Vec6d_7(double vx, double vy, double vz, double wx, double wy, double wz);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Vec6d(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_neg_vv_Vec6d(IntPtr ptr1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_vvv_Vec6d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_vvv_Vec6d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vdv_Vec6d(double a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_vvd_Vec6d(IntPtr ptr1, double b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_div_vvd_Vec6d(IntPtr ptr1, double b);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_eq_bvv_Vec6d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern char Spr_binary_operator_ne_bvv_Vec6d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern double Spr_unary_operator_index_di_get_Vec6d(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_unary_operator_index_di_set_Vec6d(IntPtr _this, int i, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Vec6d_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6d_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern double Spr_Vec6d_get_vx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6d_set_vx(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec6d_get_vy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6d_set_vy(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec6d_get_vz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6d_set_vz(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec6d_get_wx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6d_set_wx(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec6d_get_wy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6d_set_wy(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec6d_get_wz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6d_set_wz(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Vec6d_square(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_Vec6d_norm(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Vec6d_unitize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Curve3f();
	[DllImport("SprExport")]
	public static extern void Spr_delete_Curve3f(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Matrix3f();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Matrix3f_10(IntPtr ex, IntPtr ey, IntPtr ez);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Matrix3f_11(float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Matrix3f(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_neg_mm_Matrix3f(IntPtr ptr1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_mmm_Matrix3f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_mmm_Matrix3f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_mfm_Matrix3f(float a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_mmf_Matrix3f(IntPtr ptr1, float b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sprod_vmv_Matrix3f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sprod_vvm_Matrix3f(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_index_vi_get_Matrix3f(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_unary_operator_index_vi_set_Matrix3f(IntPtr _this, int i, IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Matrix3f_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3f_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern float Spr_Matrix3f_get_xx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3f_set_xx(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Matrix3f_get_xy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3f_set_xy(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Matrix3f_get_xz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3f_set_xz(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Matrix3f_get_yx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3f_set_yx(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Matrix3f_get_yy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3f_set_yy(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Matrix3f_get_yz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3f_set_yz(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Matrix3f_get_zx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3f_set_zx(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Matrix3f_get_zy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3f_set_zy(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Matrix3f_get_zz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3f_set_zz(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern ulong Spr_Matrix3f_height(IntPtr _this);
	[DllImport("SprExport")]
	public static extern ulong Spr_Matrix3f_width(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3f_resize(IntPtr _this, ulong h, ulong w);
	[DllImport("SprExport")]
	public static extern ulong Spr_Matrix3f_stride(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3f_clear(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Matrix3d();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Matrix3d_10(IntPtr ex, IntPtr ey, IntPtr ez);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Matrix3d_11(double m11, double m12, double m13, double m21, double m22, double m23, double m31, double m32, double m33);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Matrix3d(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_neg_mm_Matrix3d(IntPtr ptr1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_add_mmm_Matrix3d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sub_mmm_Matrix3d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_mdm_Matrix3d(double a, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_mul_mmd_Matrix3d(IntPtr ptr1, double b);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sprod_vmv_Matrix3d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_binary_operator_sprod_vvm_Matrix3d(IntPtr ptr1, IntPtr ptr2);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_unary_operator_index_vi_get_Matrix3d(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_unary_operator_index_vi_set_Matrix3d(IntPtr _this, int i, IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Matrix3d_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3d_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern double Spr_Matrix3d_get_xx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3d_set_xx(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Matrix3d_get_xy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3d_set_xy(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Matrix3d_get_xz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3d_set_xz(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Matrix3d_get_yx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3d_set_yx(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Matrix3d_get_yy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3d_set_yy(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Matrix3d_get_yz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3d_set_yz(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Matrix3d_get_zx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3d_set_zx(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Matrix3d_get_zy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3d_set_zy(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Matrix3d_get_zz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3d_set_zz(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern ulong Spr_Matrix3d_height(IntPtr _this);
	[DllImport("SprExport")]
	public static extern ulong Spr_Matrix3d_width(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3d_resize(IntPtr _this, ulong h, ulong w);
	[DllImport("SprExport")]
	public static extern ulong Spr_Matrix3d_stride(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Matrix3d_clear(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Affinef();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Affinef_17(IntPtr a);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Affinef(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Affinef_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_xx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_xx(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_xy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_xy(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_xz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_xz(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_xw(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_xw(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_yx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_yx(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_yy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_yy(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_yz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_yz(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_yw(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_yw(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_zx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_zx(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_zy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_zy(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_zz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_zz(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_zw(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_zw(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_px(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_px(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_py(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_py(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_pz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_pz(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_Affinef_get_pw(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affinef_set_pw(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Affined();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_Affined_17(IntPtr a);
	[DllImport("SprExport")]
	public static extern void Spr_delete_Affined(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_Affined_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_xx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_xx(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_xy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_xy(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_xz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_xz(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_xw(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_xw(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_yx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_yx(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_yy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_yy(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_yz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_yz(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_yw(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_yw(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_zx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_zx(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_zy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_zy(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_zz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_zz(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_zw(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_zw(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_px(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_px(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_py(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_py(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_pz(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_pz(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_Affined_get_pw(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_Affined_set_pw(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_SpatialVector();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_SpatialVector_2(IntPtr _v, IntPtr _w);
	[DllImport("SprExport")]
	public static extern void Spr_delete_SpatialVector(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_SpatialVector_v(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_SpatialVector_w(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_ObjectIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_ObjectIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ObjectIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_ObjectIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ObjectIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ObjectIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_ObjectIf_AddRef(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_ObjectIf_RefCount(IntPtr _this);
	[DllImport("SprExport")]
	public static extern ulong Spr_ObjectIf_NChildObject(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ObjectIf_GetChildObject(IntPtr _this, ulong pos);
	[DllImport("SprExport")]
	public static extern char Spr_ObjectIf_AddChildObject(IntPtr _this, IntPtr o);
	[DllImport("SprExport")]
	public static extern char Spr_ObjectIf_DelChildObject(IntPtr _this, IntPtr o);
	[DllImport("SprExport")]
	public static extern void Spr_ObjectIf_Clear(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ObjectIf_CreateObject(IntPtr _this, IntPtr info, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ObjectIf_GetDescAddress(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_ObjectIf_GetDesc(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern void Spr_ObjectIf_SetDesc(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern ulong Spr_ObjectIf_GetDescSize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ObjectIf_GetStateAddress(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_ObjectIf_GetState(IntPtr _this, IntPtr state);
	[DllImport("SprExport")]
	public static extern void Spr_ObjectIf_SetState(IntPtr _this, IntPtr state);
	[DllImport("SprExport")]
	public static extern char Spr_ObjectIf_WriteState(IntPtr _this, IntPtr fileName);
	[DllImport("SprExport")]
	public static extern char Spr_ObjectIf_ReadState(IntPtr _this, IntPtr fileName);
	[DllImport("SprExport")]
	public static extern ulong Spr_ObjectIf_GetStateSize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_ObjectIf_ConstructState(IntPtr _this, IntPtr m);
	[DllImport("SprExport")]
	public static extern void Spr_ObjectIf_DestructState(IntPtr _this, IntPtr m);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_NamedObjectIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_NamedObjectIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_NamedObjectIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_NamedObjectIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_NamedObjectIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_NamedObjectIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_NamedObjectIf_GetName(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_NamedObjectIf_SetName(IntPtr _this, string n);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_NamedObjectIf_GetNameManager(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_SceneObjectIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_SceneObjectIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_SceneObjectIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_SceneObjectIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_SceneObjectIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_SceneObjectIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_SceneObjectIf_GetScene(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_SceneObjectIf_CloneObject(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_ObjectStatesIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_ObjectStatesIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ObjectStatesIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_ObjectStatesIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ObjectStatesIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ObjectStatesIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_ObjectStatesIf_AllocateState(IntPtr _this, IntPtr o);
	[DllImport("SprExport")]
	public static extern void Spr_ObjectStatesIf_ReleaseState(IntPtr _this, IntPtr o);
	[DllImport("SprExport")]
	public static extern ulong Spr_ObjectStatesIf_CalcStateSize(IntPtr _this, IntPtr o);
	[DllImport("SprExport")]
	public static extern void Spr_ObjectStatesIf_SaveState(IntPtr _this, IntPtr o);
	[DllImport("SprExport")]
	public static extern void Spr_ObjectStatesIf_LoadState(IntPtr _this, IntPtr o);
	[DllImport("SprExport")]
	public static extern void Spr_ObjectStatesIf_SingleSave(IntPtr _this, IntPtr o);
	[DllImport("SprExport")]
	public static extern void Spr_ObjectStatesIf_SingleLoad(IntPtr _this, IntPtr o);
	[DllImport("SprExport")]
	public static extern char Spr_ObjectStatesIf_IsAllocated(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ObjectStatesIf_Create();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_UTTypeDescIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_UTTypeDescIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_FindTypeDesc(string typeName, string moduleName);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_Create(IntPtr tn, int sz);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_Create_1(IntPtr tn);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_SetSize(IntPtr _this, ulong sz);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_SetAccess(IntPtr _this, IntPtr a);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_SetOffset(IntPtr _this, int field, int offset);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_SetIfInfo(IntPtr _this, IntPtr info);
	[DllImport("SprExport")]
	public static extern int Spr_UTTypeDescIf_AddField(IntPtr _this, IntPtr pre, IntPtr ty, IntPtr n, IntPtr post);
	[DllImport("SprExport")]
	public static extern int Spr_UTTypeDescIf_AddBase(IntPtr _this, IntPtr tn);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_AddEnumConst(IntPtr _this, int field, IntPtr name, int val);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_GetTypeName(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_FreeString_GetTypeName(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_SetTypeName(IntPtr _this, string s);
	[DllImport("SprExport")]
	public static extern ulong Spr_UTTypeDescIf_GetSize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_UTTypeDescIf_IsPrimitive(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_UTTypeDescIf_IsSimple(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_UTTypeDescIf_NFields(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_UTTypeDescIf_GetFieldLength(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern int Spr_UTTypeDescIf_GetFieldVectorSize(IntPtr _this, int i, IntPtr base_);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_GetFieldLengthName(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern int Spr_UTTypeDescIf_GetFieldVarType(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern char Spr_UTTypeDescIf_GetFieldIsReference(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_GetFieldName(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_GetFieldAddress(IntPtr _this, int i, IntPtr base_, int pos);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_GetFieldAddressEx(IntPtr _this, int i, IntPtr base_, int pos);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_ReadToString(IntPtr _this, int i, IntPtr base_, int pos);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_FreeString_ReadToString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_WriteFromString(IntPtr _this, IntPtr from, int i, IntPtr base_, int pos);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_GetIfInfoOfType(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_UTTypeDescIf_IsBool(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_UTTypeDescIf_IsNumber(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_UTTypeDescIf_IsString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_UTTypeDescIf_ReadBool(IntPtr _this, IntPtr ptr_);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_WriteBool(IntPtr _this, bool val, IntPtr ptr_);
	[DllImport("SprExport")]
	public static extern double Spr_UTTypeDescIf_ReadNumber(IntPtr _this, IntPtr ptr_);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_WriteNumber(IntPtr _this, double val, IntPtr ptr_);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_ReadString(IntPtr _this, IntPtr ptr_);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_FreeString_ReadString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_WriteString(IntPtr _this, string val, IntPtr ptr_);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_Create_2(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_Delete(IntPtr _this, IntPtr ptr_);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_VectorPush(IntPtr _this, IntPtr v);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescIf_VectorPop(IntPtr _this, IntPtr v);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescIf_VectorAt(IntPtr _this, IntPtr v, int pos);
	[DllImport("SprExport")]
	public static extern ulong Spr_UTTypeDescIf_VectorSize(IntPtr _this, IntPtr v);
	[DllImport("SprExport")]
	public static extern ulong Spr_UTTypeDescIf_SizeOfVector(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_UTTypeDescDbIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_UTTypeDescDbIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescDbIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescDbIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescDbIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescDbIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescDbIf_GetDb(IntPtr n);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescDbIf_RegisterDesc(IntPtr _this, IntPtr n);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescDbIf_RegisterAlias(IntPtr _this, string src, string dest);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescDbIf_SetPrefix(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescDbIf_Find(IntPtr _this, IntPtr tn);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescDbIf_Link(IntPtr _this, IntPtr db);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescDbIf_Link_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescDbIf_LinkAll(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_UTTypeDescDbIf_LinkCheck(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTypeDescDbIf_GetGroup(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescDbIf_FreeString_GetGroup(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern void Spr_UTTypeDescDbIf_Clear(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_NameManagerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_NameManagerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_NameManagerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_NameManagerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_NameManagerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_NameManagerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_NameManagerIf_FindObject_2(IntPtr _this, IntPtr name, IntPtr cls);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_NameManagerIf_FindObject_3(IntPtr _this, IntPtr name);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_SceneIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_SceneIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_SceneIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_SceneIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_SceneIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_SceneIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_SdkIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_SdkIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_SdkIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_SdkIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_SdkIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_SdkIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_UTTimerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_UTTimerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTimerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_UTTimerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTimerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTimerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTimerIf_TimerFunc(IntPtr _this, int id);
	[DllImport("SprExport")]
	public static extern uint Spr_UTTimerIf_NTimers();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTimerIf_Get(uint id);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTimerIf_Create();
	[DllImport("SprExport")]
	public static extern uint Spr_UTTimerIf_GetID(IntPtr _this);
	[DllImport("SprExport")]
	public static extern uint Spr_UTTimerIf_GetResolution(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_UTTimerIf_SetResolution(IntPtr _this, uint r);
	[DllImport("SprExport")]
	public static extern uint Spr_UTTimerIf_GetInterval(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_UTTimerIf_SetInterval(IntPtr _this, uint i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_UTTimerIf_GetCallbackArg(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_UTTimerIf_GetMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_UTTimerIf_SetMode(IntPtr _this, int m);
	[DllImport("SprExport")]
	public static extern char Spr_UTTimerIf_IsStarted(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_UTTimerIf_IsRunning(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_UTTimerIf_Start(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_UTTimerIf_Stop(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_UTTimerIf_Call(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_IfInfo_Inherit(IntPtr _this, IntPtr info);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_IfInfo_ClassName(IntPtr _this);
    }
}
