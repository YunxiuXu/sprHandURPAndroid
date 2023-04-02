using System;
using System.Runtime.InteropServices;
namespace SprCs {
    public partial class SprExport {
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHConstraintEngineDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHConstraintEngineDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHConstraintEngineDesc_get_method(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_method(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHConstraintEngineDesc_get_numIter(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_numIter(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHConstraintEngineDesc_get_numIterCorrection(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_numIterCorrection(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHConstraintEngineDesc_get_numIterContactCorrection(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_numIterContactCorrection(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineDesc_get_velCorrectionRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_velCorrectionRate(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineDesc_get_posCorrectionRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_posCorrectionRate(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineDesc_get_contactCorrectionRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_contactCorrectionRate(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineDesc_get_shrinkRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_shrinkRate(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineDesc_get_shrinkRateCorrection(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_shrinkRateCorrection(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineDesc_get_freezeThreshold(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_freezeThreshold(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineDesc_get_accelSOR(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_accelSOR(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineDesc_get_dfEps(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_dfEps(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineDesc_get_regularization(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_regularization(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern char Spr_PHConstraintEngineDesc_get_bSaveConstraints(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_bSaveConstraints(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHConstraintEngineDesc_get_bUpdateAllState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_bUpdateAllState(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHConstraintEngineDesc_get_bUseContactSurface(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_bUseContactSurface(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHConstraintEngineDesc_get_bReport(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineDesc_set_bReport(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHIKEngineDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHIKEngineDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern ulong Spr_PHIKEngineDesc_get_numIter(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineDesc_set_numIter(IntPtr _this, ulong value);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEngineDesc_get_maxVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineDesc_set_maxVel(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEngineDesc_get_maxAngVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineDesc_set_maxAngVel(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEngineDesc_get_maxActVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineDesc_set_maxActVel(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEngineDesc_get_regularizeParam(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineDesc_set_regularizeParam(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEngineDesc_get_regularizeParam2(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineDesc_set_regularizeParam2(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern int Spr_PHIKEngineDesc_get_regularizeMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineDesc_set_regularizeMode(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHIKEngineDesc_get_iterGaussSeidel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineDesc_set_iterGaussSeidel(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHIKEngineDesc_get_solverMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineDesc_set_solverMode(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemMeshState();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemMeshState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemMeshDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemMeshDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshDesc_vector_get_vertices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshDesc_vector_set_vertices(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshDesc_vector_addr_tets(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshDesc_vector_set_tets(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshDesc_vector_addr_faces(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshDesc_vector_set_faces(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshDesc_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemMeshThermoDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemMeshThermoDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshThermoDesc_get_rho(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoDesc_set_rho(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshThermoDesc_get_thConduct(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoDesc_set_thConduct(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshThermoDesc_get_thConduct_x(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoDesc_set_thConduct_x(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshThermoDesc_get_thConduct_y(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoDesc_set_thConduct_y(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshThermoDesc_get_thConduct_z(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoDesc_set_thConduct_z(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshThermoDesc_get_heatTrans(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoDesc_set_heatTrans(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshThermoDesc_get_specificHeat(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoDesc_set_specificHeat(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshThermoDesc_get_radiantHeat(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoDesc_set_radiantHeat(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshThermoDesc_get_initial_temp(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoDesc_set_initial_temp(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoDesc_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemMeshNewState();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemMeshNewState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemMeshNewDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemMeshNewDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewDesc_vector_get_vertices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshNewDesc_vector_set_vertices(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewDesc_vector_addr_tets(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshNewDesc_vector_set_tets(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewDesc_vector_addr_faces(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshNewDesc_vector_set_faces(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemMeshNewDesc_get_spheric(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshNewDesc_set_spheric(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemBaseDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemBaseDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemVibrationDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemVibrationDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemVibrationDesc_get_young(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationDesc_set_young(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemVibrationDesc_get_poisson(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationDesc_set_poisson(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemVibrationDesc_get_density(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationDesc_set_density(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemVibrationDesc_get_alpha(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationDesc_set_alpha(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemVibrationDesc_get_beta(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationDesc_set_beta(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemVibrationDesc_vector_addr_fixedVertices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationDesc_vector_set_fixedVertices(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemThermoDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemThermoDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoDesc_get_rho(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoDesc_set_rho(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoDesc_get_heatTrans(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoDesc_set_heatTrans(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoDesc_get_specificHeat(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoDesc_set_specificHeat(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoDesc_get_radiantHeat(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoDesc_set_radiantHeat(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoDesc_get_initial_temp(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoDesc_set_initial_temp(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoDesc_get_weekPow_full(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoDesc_set_weekPow_full(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoDesc_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemPorousWOMoveDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemPorousWOMoveDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_wDiffAir(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_wDiffAir(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_K(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_K(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_kc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_kc(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_kp(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_kp(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_alpha(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_alpha(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_gamma(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_gamma(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_rhoWater(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_rhoWater(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_rhoOil(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_rhoOil(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_rhowInit(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_rhowInit(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_rhooInit(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_rhooInit(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_evapoRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_evapoRate(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_denatTemp(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_denatTemp(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_boundWaterRatio(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_boundWaterRatio(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_equilWaterCont(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_equilWaterCont(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_limitWaterCont(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_limitWaterCont(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_boundaryThick(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_boundaryThick(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_initMassAll(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_initMassAll(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_initWaterRatio(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_initWaterRatio(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_initOilRatio(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_initOilRatio(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveDesc_get_shrinkageRatio(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_shrinkageRatio(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemPorousWOMoveDesc_addr_top(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_top(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemPorousWOMoveDesc_addr_center(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_center(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemPorousWOMoveDesc_addr_bottom(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_set_bottom(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveDesc_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFrameDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFrameDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFrameDesc_addr_pose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFrameDesc_set_pose(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSolidState();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSolidState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidState_addr_velocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidState_set_velocity(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidState_addr_angVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidState_set_angVelocity(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidState_addr_pose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidState_set_pose(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSolidDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSolidDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHSolidDesc_get_mass(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidDesc_set_mass(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidDesc_addr_inertia(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidDesc_set_inertia(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidDesc_addr_center(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidDesc_set_center(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern char Spr_PHSolidDesc_get_dynamical(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidDesc_set_dynamical(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHSolidDesc_get_stationary(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidDesc_set_stationary(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidDesc_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHCollisionListener();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHCollisionListener(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHCollisionListener_OnDetect(IntPtr _this, IntPtr sop, IntPtr shp, uint ct, double dt);
	[DllImport("SprExport")]
	public static extern void Spr_PHCollisionListener_OnContDetect(IntPtr _this, IntPtr sop, IntPtr shp, uint ct, double dt);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHHapticPointerDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHHapticPointerDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHHapticPointerDesc_get_renderMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerDesc_set_renderMode(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHHapticEngineDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHHapticEngineDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHIKEndEffectorState();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHIKEndEffectorState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorState_addr_solidTempPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorState_set_solidTempPose(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHIKEndEffectorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHIKEndEffectorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHIKEndEffectorDesc_get_bEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_bEnabled(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHIKEndEffectorDesc_get_bPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_bPosition(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHIKEndEffectorDesc_get_bOrientation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_bOrientation(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern int Spr_PHIKEndEffectorDesc_get_oriCtlMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_oriCtlMode(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern char Spr_PHIKEndEffectorDesc_get_bForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_bForce(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHIKEndEffectorDesc_get_bTorque(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_bTorque(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEndEffectorDesc_get_positionPriority(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_positionPriority(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEndEffectorDesc_get_orientationPriority(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_orientationPriority(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEndEffectorDesc_get_forcePriority(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_forcePriority(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEndEffectorDesc_get_torquePriority(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_torquePriority(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorDesc_addr_targetPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_targetPosition(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorDesc_addr_targetVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_targetVelocity(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorDesc_addr_targetLocalPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_targetLocalPosition(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorDesc_addr_targetLocalDirection(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_targetLocalDirection(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorDesc_addr_targetOrientation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_targetOrientation(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorDesc_addr_targetDirection(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_targetDirection(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorDesc_addr_targetLookat(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_targetLookat(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorDesc_addr_targetAngVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_targetAngVel(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorDesc_addr_targetForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_targetForce(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorDesc_addr_targetForceWorkingPoint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_targetForceWorkingPoint(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorDesc_addr_targetTorque(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorDesc_set_targetTorque(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHIKActuatorState();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHIKActuatorState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKActuatorState_addr_solidTempPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorState_set_solidTempPose(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKActuatorState_addr_jointTempOri(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorState_set_jointTempOri(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKActuatorState_addr_jointTempOriIntp(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorState_set_jointTempOriIntp(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKActuatorState_get_jointTempAngle(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorState_set_jointTempAngle(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKActuatorState_get_jointTempAngleIntp(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorState_set_jointTempAngleIntp(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKActuatorState_addr_solidPullbackPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorState_set_solidPullbackPose(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKActuatorState_addr_jointTempPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorState_set_jointTempPose(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHIKActuatorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHIKActuatorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHIKActuatorDesc_get_bEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorDesc_set_bEnabled(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern float Spr_PHIKActuatorDesc_get_bias(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorDesc_set_bias(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKActuatorDesc_get_pullbackRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorDesc_set_pullbackRate(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHIKBallActuatorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHIKBallActuatorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKBallActuatorDesc_addr_pullbackTarget(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKBallActuatorDesc_set_pullbackTarget(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHIKHingeActuatorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHIKHingeActuatorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKHingeActuatorDesc_get_pullbackTarget(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKHingeActuatorDesc_set_pullbackTarget(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHIKSpringActuatorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHIKSpringActuatorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKSpringActuatorDesc_addr_pullbackTarget(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKSpringActuatorDesc_set_pullbackTarget(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHConstraintDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHConstraintDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHConstraintDesc_get_bEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintDesc_set_bEnabled(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintDesc_addr_poseSocket(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintDesc_set_poseSocket(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintDesc_addr_posePlug(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintDesc_set_posePlug(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHJointDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHJointDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHJointDesc_get_fMax(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHJointDesc_set_fMax(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PH1DJointDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PH1DJointDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PH1DJointDesc_get_cyclic(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointDesc_set_cyclic(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointDesc_get_spring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointDesc_set_spring(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointDesc_get_damper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointDesc_set_damper(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointDesc_get_secondDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointDesc_set_secondDamper(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointDesc_get_targetPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointDesc_set_targetPosition(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointDesc_get_targetVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointDesc_set_targetVelocity(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointDesc_get_offsetForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointDesc_set_offsetForce(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointDesc_get_yieldStress(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointDesc_set_yieldStress(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointDesc_get_hardnessRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointDesc_set_hardnessRate(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointDesc_get_secondMoment(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointDesc_set_secondMoment(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHHingeJointDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHHingeJointDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSliderJointDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSliderJointDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHSliderJointDesc_get_bConstraintY(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSliderJointDesc_set_bConstraintY(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHSliderJointDesc_get_bConstraintRollX(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSliderJointDesc_set_bConstraintRollX(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHSliderJointDesc_get_bConstraintRollZ(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSliderJointDesc_set_bConstraintRollZ(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPathPoint();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPathPoint_4(double _s, IntPtr _pose);
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPathPoint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHPathPoint_get_s(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHPathPoint_set_s(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPathPoint_addr_pose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHPathPoint_set_pose(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPathDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPathDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPathDesc_vector_get_points(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHPathDesc_vector_set_points(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern char Spr_PHPathDesc_get_bLoop(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHPathDesc_set_bLoop(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPathJointDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPathJointDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHGenericJointCallback();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHGenericJointCallback(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHGenericJointCallback_SetParam(IntPtr _this, IntPtr jnt, IntPtr name, double value);
	[DllImport("SprExport")]
	public static extern char Spr_PHGenericJointCallback_IsCyclic(IntPtr _this, IntPtr jnt);
	[DllImport("SprExport")]
	public static extern void Spr_PHGenericJointCallback_GetMovableAxes(IntPtr _this, IntPtr jnt, int n, int indices);
	[DllImport("SprExport")]
	public static extern void Spr_PHGenericJointCallback_CompBias(IntPtr _this, IntPtr jnt, IntPtr dbv, IntPtr dbw, IntPtr prel, IntPtr qrel, IntPtr vrel, IntPtr wrel);
	[DllImport("SprExport")]
	public static extern void Spr_PHGenericJointCallback_CompError(IntPtr _this, IntPtr jnt, IntPtr Bv, IntPtr Bw, IntPtr prel, IntPtr qrel);
	[DllImport("SprExport")]
	public static extern void Spr_PHGenericJointCallback_UpdateJointState(IntPtr _this, IntPtr jnt, double pos, double vel, IntPtr prel, IntPtr qrel, IntPtr vrel, IntPtr wrel);
	[DllImport("SprExport")]
	public static extern void Spr_PHGenericJointCallback_CompJointJacobian(IntPtr _this, IntPtr jnt, IntPtr Jv, IntPtr Jw, double pos);
	[DllImport("SprExport")]
	public static extern void Spr_PHGenericJointCallback_CompJointCoriolisAccel(IntPtr _this, IntPtr jnt, IntPtr cv, IntPtr cw, double pos, double vel);
	[DllImport("SprExport")]
	public static extern void Spr_PHGenericJointCallback_CompRelativePosition(IntPtr _this, IntPtr jnt, IntPtr prel, IntPtr qrel, double pos);
	[DllImport("SprExport")]
	public static extern void Spr_PHGenericJointCallback_CompRelativeVelocity(IntPtr _this, IntPtr jnt, IntPtr vrel, IntPtr wrel, double pos, double vel);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHGenericJointDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHGenericJointDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHBallJointDesc_get_spring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointDesc_set_spring(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHBallJointDesc_get_damper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointDesc_set_damper(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointDesc_addr_secondDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointDesc_set_secondDamper(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointDesc_addr_targetPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointDesc_set_targetPosition(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointDesc_addr_targetVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointDesc_set_targetVelocity(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointDesc_addr_offsetForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointDesc_set_offsetForce(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern double Spr_PHBallJointDesc_get_yieldStress(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointDesc_set_yieldStress(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHBallJointDesc_get_hardnessRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointDesc_set_hardnessRate(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointDesc_addr_secondMoment(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointDesc_set_secondMoment(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFixJointDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFixJointDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSpringDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSpringDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringDesc_addr_targetPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringDesc_set_targetPosition(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringDesc_addr_targetOrientation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringDesc_set_targetOrientation(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringDesc_addr_spring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringDesc_set_spring(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringDesc_addr_damper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringDesc_set_damper(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringDesc_addr_secondDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringDesc_set_secondDamper(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern double Spr_PHSpringDesc_get_springOri(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringDesc_set_springOri(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSpringDesc_get_damperOri(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringDesc_set_damperOri(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSpringDesc_get_secondDamperOri(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringDesc_set_secondDamperOri(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSpringDesc_get_yieldStress(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringDesc_set_yieldStress(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSpringDesc_get_hardnessRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringDesc_set_hardnessRate(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringDesc_addr_secondMoment(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringDesc_set_secondMoment(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringDesc_addr_targetVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringDesc_set_targetVelocity(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringDesc_addr_offsetForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringDesc_set_offsetForce(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHMateDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHMateDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPointToPointMateDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPointToPointMateDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPointToLineMateDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPointToLineMateDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPointToPlaneMateDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPointToPlaneMateDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPointToPlaneMateDesc_addr_range(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHPointToPlaneMateDesc_set_range(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHLineToLineMateDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHLineToLineMateDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPlaneToPlaneMateDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPlaneToPlaneMateDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHTreeNodeDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHTreeNodeDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHTreeNodeDesc_get_bEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHTreeNodeDesc_set_bEnabled(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHRootNodeDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHRootNodeDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHTreeNode1DDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHTreeNode1DDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHHingeJointNodeDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHHingeJointNodeDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSliderJointNodeDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSliderJointNodeDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPathJointNodeDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPathJointNodeDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHGenericJointNodeDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHGenericJointNodeDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointNodeDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointNodeDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFixJointNodeDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFixJointNodeDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHGearDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHGearDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHGearDesc_get_bEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHGearDesc_set_bEnabled(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern double Spr_PHGearDesc_get_ratio(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHGearDesc_set_ratio(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHGearDesc_get_offset(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHGearDesc_set_offset(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern int Spr_PHGearDesc_get_mode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHGearDesc_set_mode(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PH1DJointLimitDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PH1DJointLimitDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PH1DJointLimitDesc_get_bEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointLimitDesc_set_bEnabled(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointLimitDesc_get_spring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointLimitDesc_set_spring(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointLimitDesc_get_damper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointLimitDesc_set_damper(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointLimitDesc_addr_range(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointLimitDesc_set_range(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointLimitDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointLimitDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHBallJointLimitDesc_get_bEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointLimitDesc_set_bEnabled(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern double Spr_PHBallJointLimitDesc_get_spring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointLimitDesc_set_spring(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHBallJointLimitDesc_get_damper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointLimitDesc_set_damper(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointLimitDesc_addr_limitDir(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointLimitDesc_set_limitDir(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointConeLimitDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointConeLimitDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointConeLimitDesc_addr_limitSwing(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointConeLimitDesc_set_limitSwing(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointConeLimitDesc_addr_limitSwingDir(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointConeLimitDesc_set_limitSwingDir(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointConeLimitDesc_addr_limitTwist(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointConeLimitDesc_set_limitTwist(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSplineLimitNode();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSplineLimitNode_8(double s, double sd, double ds, double dsd, double tmn, double tmx);
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSplineLimitNode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHSplineLimitNode_get_swing(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSplineLimitNode_set_swing(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSplineLimitNode_get_swingDir(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSplineLimitNode_set_swingDir(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSplineLimitNode_get_dSwing(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSplineLimitNode_set_dSwing(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSplineLimitNode_get_dSwingDir(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSplineLimitNode_set_dSwingDir(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSplineLimitNode_get_twistMin(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSplineLimitNode_set_twistMin(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSplineLimitNode_get_twistMax(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSplineLimitNode_set_twistMax(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointSplineLimitDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointSplineLimitDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointSplineLimitDesc_vector_get_nodes(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointSplineLimitDesc_vector_set_nodes(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointSplineLimitDesc_addr_poleTwist(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointSplineLimitDesc_set_poleTwist(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointIndependentLimitDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointIndependentLimitDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIndependentLimitDesc_addr_limitX(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIndependentLimitDesc_set_limitX(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIndependentLimitDesc_addr_limitY(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIndependentLimitDesc_set_limitY(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIndependentLimitDesc_addr_limitZ(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIndependentLimitDesc_set_limitZ(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PH1DJointMotorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PH1DJointMotorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PH1DJointNonLinearMotorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PH1DJointNonLinearMotorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHHuman1DJointResistanceDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHHuman1DJointResistanceDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHuman1DJointResistanceDesc_addr_coefficient(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHuman1DJointResistanceDesc_set_coefficient(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointMotorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointMotorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointNonLinearMotorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointNonLinearMotorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHHumanBallJointResistanceDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHHumanBallJointResistanceDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHumanBallJointResistanceDesc_addr_xCoefficient(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHumanBallJointResistanceDesc_set_xCoefficient(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHumanBallJointResistanceDesc_addr_yCoefficient(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHumanBallJointResistanceDesc_set_yCoefficient(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHumanBallJointResistanceDesc_addr_zCoefficient(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHumanBallJointResistanceDesc_set_zCoefficient(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSpringMotorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSpringMotorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHInactiveSolids();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHInactiveSolids(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpObjState();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpObjState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpObjState_addr_velocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjState_set_velocity(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpObjState_addr_angVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjState_set_angVelocity(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpObjState_addr_pose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjState_set_pose(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpHapticRendererDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpHapticRendererDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpHapticRendererDesc_get_extForceSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_extForceSpring(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpHapticRendererDesc_get_outForceSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_outForceSpring(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpHapticRendererDesc_get_constraintSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_constraintSpring(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpHapticRendererDesc_get_timeStep(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_timeStep(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpHapticRendererDesc_get_forceOnRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_forceOnRadius(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticRendererDesc_get_useConstrainForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_useConstrainForce(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticRendererDesc_get_useProxyfixSubitr(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_useProxyfixSubitr(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticRendererDesc_get_useIncreaseMeshMove(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_useIncreaseMeshMove(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticRendererDesc_get_sqrtAlphaForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_sqrtAlphaForce(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticRendererDesc_get_hitWall(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_hitWall(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticRendererDesc_get_useDualTranFix(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_useDualTranFix(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticRendererDesc_get_rigid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_rigid(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticRendererDesc_get_proxyItrtNum(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_proxyItrtNum(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticRendererDesc_get_proxyItrtMaxNum(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_proxyItrtMaxNum(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticRendererDesc_get_currDtType(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_currDtType(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticRendererDesc_get_objNum(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_objNum(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticRendererDesc_get_noCtcItrNum(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_noCtcItrNum(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticRendererDesc_addr_proxyFixPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererDesc_set_proxyFixPos(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpObjDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpObjDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHOpObjDesc_get_mass(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_mass(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpObjDesc_addr_inertia(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_inertia(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpObjDesc_addr_center(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_center(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpObjDesc_get_dynamical(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_dynamical(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpObjDesc_get_objTargetVts(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_objTargetVts(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpObjDesc_array_addr_objTargetVtsArr(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_array_set_objTargetVtsArr(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpObjDesc_get_objTargetVtsNum(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_objTargetVtsNum(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpObjDesc_get_assPsNum(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_assPsNum(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpObjDesc_get_assGrpNum(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_assGrpNum(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpObjDesc_get_objGrouplinkCount(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_objGrouplinkCount(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpObjDesc_get_objId(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_objId(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpObjDesc_get_objUseDistCstr(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_objUseDistCstr(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpObjDesc_get_objNoMeshObj(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_objNoMeshObj(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpObjDesc_get_isRigid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_isRigid(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpObjDesc_get_objType(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_objType(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpObjDesc_get_objAverRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_objAverRadius(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpObjDesc_get_objMaxRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_objMaxRadius(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpObjDesc_get_objitrTime(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_objitrTime(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpObjDesc_get_updateNormals(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_set_updateNormals(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjDesc_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpParticleDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpParticleDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpParticleDesc_get_pNvertex(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pNvertex(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpParticleDesc_get_pMyGroupInd(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pMyGroupInd(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpParticleDesc_get_pPId(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pPId(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpParticleDesc_get_pObjId(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pObjId(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpParticleDesc_get_pParaAlpha(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pParaAlpha(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpParticleDesc_get_hitedByMouse(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_hitedByMouse(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpParticleDesc_get_pSingleVMass(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pSingleVMass(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpParticleDesc_get_pTotalMass(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pTotalMass(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpParticleDesc_get_pRadii(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pRadii(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpParticleDesc_get_pDynamicRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pDynamicRadius(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pMainRadiusVec(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pMainRadiusVec(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pSecRadiusVec(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pSecRadiusVec(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pThrRadiusVec(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pThrRadiusVec(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpParticleDesc_get_pMainRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pMainRadius(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpParticleDesc_get_pSecRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pSecRadius(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpParticleDesc_get_pThrRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pThrRadius(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pCurrCtr(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pCurrCtr(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pOrigCtr(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pOrigCtr(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pNewCtr(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pNewCtr(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pVelocity(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpParticleDesc_get_isColliedbySphash(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_isColliedbySphash(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpParticleDesc_get_isColliedbyColliCube(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_isColliedbyColliCube(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpParticleDesc_get_isFixedbyMouse(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_isFixedbyMouse(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpParticleDesc_get_isFixed(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_isFixed(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpParticleDesc_get_isColliedSphashSolved(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_isColliedSphashSolved(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpParticleDesc_get_isColliedSphashSolvedReady(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_isColliedSphashSolvedReady(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pExternalForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pExternalForce(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pExternalTorque(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pExternalTorque(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pExternalDisplacement(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pExternalDisplacement(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_vector_addr_pFaceInd(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_vector_set_pFaceInd(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pMomentR(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pMomentR(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pSmR(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pSmR(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pMomentInertia(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pMomentInertia(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pInverseOfMomentInertia(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pInverseOfMomentInertia(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_ellipRotMatrix(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_ellipRotMatrix(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_ellipOrigOrint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_ellipOrigOrint(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pWvel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pWvel(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pPreEllipA(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pPreEllipA(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pCurrOrint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pCurrOrint(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pOrigOrint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pOrigOrint(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleDesc_addr_pNewOrint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleDesc_set_pNewOrint(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpGroupDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpGroupDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpGroupDesc_get_gMyIndex(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpGroupDesc_set_gMyIndex(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpGroupDesc_addr_gAgroup(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpGroupDesc_set_gAgroup(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpGroupDesc_addr_gEigen(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpGroupDesc_set_gEigen(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpGroupDesc_get_gtotalMass(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpGroupDesc_set_gtotalMass(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpGroupDesc_addr_gOrigCenter(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpGroupDesc_set_gOrigCenter(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpGroupDesc_addr_gCurrCenter(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpGroupDesc_set_gCurrCenter(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpGroupDesc_get_gNptcl(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpGroupDesc_set_gNptcl(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpHapticControllerDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpHapticControllerDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpHapticControllerDesc_get_posScale(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_posScale(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpHapticControllerDesc_get_rotScale(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_rotScale(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpHapticControllerDesc_get_forceScale(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_forceScale(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerDesc_addr_userPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_userPos(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerDesc_addr_userPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_userPose(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerDesc_addr_hcCurrPPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_hcCurrPPos(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerDesc_addr_hcCurrUPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_hcCurrUPos(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerDesc_addr_hcLastUPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_hcLastUPos(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerDesc_addr_hcFixsubGoal(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_hcFixsubGoal(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpHapticControllerDesc_get_c_obstRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_c_obstRadius(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticControllerDesc_get_hpObjIndex(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_hpObjIndex(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticControllerDesc_get_hcType(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_hcType(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticControllerDesc_get_logForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_logForce(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticControllerDesc_get_hcReady(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_hcReady(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticControllerDesc_get_IsSetForceReady(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_IsSetForceReady(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticControllerDesc_get_fileindex(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_fileindex(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerDesc_addr_lastHpRateF(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_lastHpRateF(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticControllerDesc_get_hcCollied(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_hcCollied(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticControllerDesc_get_constrainCount(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_constrainCount(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticControllerDesc_get_constrainCountHc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_constrainCountHc(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerDesc_addr_couterPlaneN(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_couterPlaneN(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpHapticControllerDesc_get_hcElmDtcRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_hcElmDtcRadius(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticControllerDesc_get_collectCount(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_collectCount(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticControllerDesc_get_collectItrtor(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_collectItrtor(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticControllerDesc_get_hcProxyOn(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_hcProxyOn(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticControllerDesc_get_suspObjid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_suspObjid(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpHapticControllerDesc_get_proxyRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_proxyRadius(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpHapticControllerDesc_get_surrCnstrs(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerDesc_set_surrCnstrs(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpAnimationDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpAnimationDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpAnimationDesc_get_timestep(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpAnimationDesc_set_timestep(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpSpHashColliAgentDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpSpHashColliAgentDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpSpHashColliAgentDesc_get_useDirColli(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpSpHashColliAgentDesc_set_useDirColli(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpSpHashColliAgentDesc_get_collisionCstrStiffness(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpSpHashColliAgentDesc_set_collisionCstrStiffness(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHRaycastHit();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHRaycastHit(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRaycastHit_get_solid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHRaycastHit_set_solid(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRaycastHit_get_shape(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHRaycastHit_set_shape(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRaycastHit_addr_point(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHRaycastHit_set_point(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_PHRaycastHit_get_distance(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHRaycastHit_set_distance(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHRayDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHRayDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRayDesc_addr_origin(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHRayDesc_set_origin(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRayDesc_addr_direction(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHRayDesc_set_direction(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSceneState();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSceneState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneState_get_timeStep(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneState_set_timeStep(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneState_get_haptictimeStep(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneState_set_haptictimeStep(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern uint Spr_PHSceneState_get_count(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneState_set_count(IntPtr _this, uint value);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneState_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSceneDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSceneDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneDesc_addr_gravity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_gravity(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneDesc_get_airResistanceRateForVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_airResistanceRateForVelocity(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneDesc_get_airResistanceRateForAngularVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_airResistanceRateForAngularVelocity(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneDesc_get_contactTolerance(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_contactTolerance(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneDesc_get_impactThreshold(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_impactThreshold(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneDesc_get_frictionThreshold(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_frictionThreshold(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneDesc_get_maxDeltaPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_maxDeltaPosition(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneDesc_get_maxDeltaOrientation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_maxDeltaOrientation(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneDesc_get_maxVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_maxVelocity(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneDesc_get_maxAngularVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_maxAngularVelocity(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneDesc_get_maxForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_maxForce(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneDesc_get_maxMoment(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_maxMoment(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneDesc_get_numIteration(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_numIteration(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneDesc_get_method(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_method(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern char Spr_PHSceneDesc_get_bContactDetectionEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_bContactDetectionEnabled(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_PHSceneDesc_get_bCCDEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_bCCDEnabled(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneDesc_get_broadPhaseMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_broadPhaseMode(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneDesc_get_blendMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_set_blendMode(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneDesc_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSdkDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSdkDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBoneDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBoneDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSkeletonDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSkeletonDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHEngineIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHEngineIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHEngineIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHEngineIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHEngineIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHEngineIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_PHEngineIf_GetPriority(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHEngineIf_Step(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHEngineIf_Enable(IntPtr _this, bool on);
	[DllImport("SprExport")]
	public static extern void Spr_PHEngineIf_Enable_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHEngineIf_IsEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHEngineIf_GetScene(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHConstraintEngineIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHConstraintEngineIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintEngineIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintEngineIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintEngineIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintEngineIf_GetContactPoints(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineIf_SetVelCorrectionRate(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineIf_GetVelCorrectionRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineIf_SetPosCorrectionRate(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineIf_GetPosCorrectionRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineIf_SetContactCorrectionRate(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineIf_GetContactCorrectionRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineIf_SetBSaveConstraints(IntPtr _this, bool value);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineIf_SetUpdateAllSolidState(IntPtr _this, bool flag);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineIf_SetUseContactSurface(IntPtr _this, bool flag);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineIf_SetShrinkRate(IntPtr _this, double data);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineIf_GetShrinkRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineIf_SetShrinkRateCorrection(IntPtr _this, double data);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineIf_GetShrinkRateCorrection(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineIf_SetRegularization(IntPtr _this, double reg);
	[DllImport("SprExport")]
	public static extern double Spr_PHConstraintEngineIf_GetRegularization(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintEngineIf_EnableRenderContact(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHGravityEngineIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHGravityEngineIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHGravityEngineIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHGravityEngineIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHGravityEngineIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHGravityEngineIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPenaltyEngineIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPenaltyEngineIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPenaltyEngineIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHPenaltyEngineIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPenaltyEngineIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPenaltyEngineIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHIKEngineIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHIKEngineIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEngineIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineIf_SetMaxVelocity(IntPtr _this, double maxVel);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEngineIf_GetMaxVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineIf_SetMaxAngularVelocity(IntPtr _this, double maxAV);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEngineIf_GetMaxAngularVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineIf_SetMaxActuatorVelocity(IntPtr _this, double maxAV);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEngineIf_GetMaxActuatorVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineIf_SetRegularizeParam(IntPtr _this, double epsilon);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEngineIf_GetRegularizeParam(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineIf_SetIterCutOffAngVel(IntPtr _this, double epsilon);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEngineIf_GetIterCutOffAngVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineIf_SetIntpRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHIKEngineIf_GetIntpRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineIf_ApplyExactState(IntPtr _this, bool reverse);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineIf_ApplyExactState_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineIf_SetNumIter(IntPtr _this, int numIter);
	[DllImport("SprExport")]
	public static extern int Spr_PHIKEngineIf_GetNumIter(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEngineIf_FK(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEngineIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEngineIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemEngineIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemEngineIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemEngineIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemEngineIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemEngineIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemEngineIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHFemEngineIf_SetTimeStep(IntPtr _this, double dt);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemEngineIf_GetTimeStep(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemEngineIf_SetVibrationTransfer(IntPtr _this, bool bEnable);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemEngineIf_SetThermalTransfer(IntPtr _this, bool bEnable);
	[DllImport("SprExport")]
	public static extern int Spr_PHFemEngineIf_NMeshNew(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemEngineIf_GetMeshNew(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemEngineIf_AddMeshPair(IntPtr _this, IntPtr m0, IntPtr m1);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemEngineIf_RemoveMeshPair(IntPtr _this, IntPtr m0, IntPtr m1);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemEngineIf_ThermalTransfer(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemEngineIf_setheatTransferRatio(IntPtr _this, double setheatTransferRatio);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemEngineIf_FEMSolidMatchRefresh(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemEngineIf_InitContacts(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemEngineIf_ClearContactVectors(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHFemEngineIf_NMesh(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemEngineIf_GetMesh(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpEngineIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpEngineIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpEngineIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpEngineIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpEngineIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpEngineIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHOpEngineIf_SetTimeStep(IntPtr _this, double dt);
	[DllImport("SprExport")]
	public static extern double Spr_PHOpEngineIf_GetTimeStep(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpEngineIf_SetGravity(IntPtr _this, bool gflag);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpEngineIf_InitialHapticRenderer(IntPtr _this, int objId);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpEngineIf_GetOpObj(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpEngineIf_StepWithBlend(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpEngineIf_AddOpObj(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpEngineIf_SetHapticSolveEnable(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpEngineIf_IsHapticSolve(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpEngineIf_SetProxyCorrectionEnable(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpEngineIf_IsProxyCorrection(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpEngineIf_SetUpdateNormal(IntPtr _this, bool flag);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpEngineIf_IsUpdateNormal(IntPtr _this, int obji);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpEngineIf_SetUseHaptic(IntPtr _this, bool hapticUsage);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpEngineIf_GetUseHaptic(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpEngineIf_GetOpObjIf(IntPtr _this, int obji);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpEngineIf_GetOpObjNum(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpEngineIf_GetOpAnimator(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpEngineIf_GetOpHapticController(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpEngineIf_GetOpHapticRenderer(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpEngineIf_SetIterationCount(IntPtr _this, int count);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpEngineIf_GetIterationCount(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpEngineIf_SetAnimationFlag(IntPtr _this, bool flag);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpEngineIf_GetAnimationFlag(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpEngineIf_SetDrawPtclR(IntPtr _this, float r);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpEngineIf_GetDrawPtclR(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpEngineIf_InitialNoMeshHapticRenderer(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemMeshIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemMeshIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemMeshThermoIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemMeshThermoIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshThermoIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshThermoIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshThermoIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_PHFemMeshThermoIf_GetSurfaceVertex(IntPtr _this, int id);
	[DllImport("SprExport")]
	public static extern int Spr_PHFemMeshThermoIf_NSurfaceVertices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetVertexTc(IntPtr _this, int id, double temp);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetVertexTc_1(IntPtr _this, int id, double temp, double heatTrans);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshThermoIf_GetPose(IntPtr _this, int id);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshThermoIf_GetSufVtxPose(IntPtr _this, uint id);
	[DllImport("SprExport")]
	public static extern uint Spr_PHFemMeshThermoIf_GetStepCount(IntPtr _this);
	[DllImport("SprExport")]
	public static extern uint Spr_PHFemMeshThermoIf_GetStepCountCyc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshThermoIf_GetVertexTemp(IntPtr _this, uint id);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshThermoIf_GetSufVertexTemp(IntPtr _this, uint id);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetVertexTemp(IntPtr _this, uint id, double temp);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetVerticesTempAll(IntPtr _this, double temp);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_AddvecFAll(IntPtr _this, uint id, double dqdt);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetvecFAll(IntPtr _this, uint id, double dqdt);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetRhoSpheat(IntPtr _this, double rho, double Cp);
	[DllImport("SprExport")]
	public static extern uint Spr_PHFemMeshThermoIf_GetNFace(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshThermoIf_GetFaceEdgeVtx(IntPtr _this, uint id);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshThermoIf_GetFaceEdgeVtx_1(IntPtr _this, uint id, uint vtx);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshThermoIf_GetIHbandDrawVtx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_CalcIHdqdt_atleast(IntPtr _this, double r, double R, double dqdtAll, uint num);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_UpdateIHheatband(IntPtr _this, double xS, double xE, uint heatingMODE);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_UpdateIHheat(IntPtr _this, uint heating);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_UpdateVecF(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_UpdateVecF_frypan(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_DecrMoist(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_DecrMoist_velo(IntPtr _this, double vel);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_DecrMoist_vel(IntPtr _this, double dt);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_InitAllVertexTemp(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetInitThermoConductionParam(IntPtr _this, double thConduct, double rho, double specificHeat, double heatTrans);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetParamAndReCreateMatrix(IntPtr _this, double thConduct0, double roh0, double specificHeat0);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshThermoIf_GetArbitraryPointTemp(IntPtr _this, IntPtr temppos);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshThermoIf_GetVtxTempInTets(IntPtr _this, IntPtr temppos);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_InitVecFAlls(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshThermoIf_Get_thConduct(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemMeshThermoIf_SetConcentricHeatMap(IntPtr _this, IntPtr r, IntPtr temp, IntPtr origin);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetThermalEmissivityToVerticesAll(IntPtr _this, double thermalEmissivity, double thermalEmissivity_const);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetOuterTemp(IntPtr _this, double temp);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetThermalRadiation(IntPtr _this, double ems, double ems_const);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetGaussCalcParam(IntPtr _this, uint cyc, double epsilon);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_InitTcAll(IntPtr _this, double temp);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_InitToutAll(IntPtr _this, double temp);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetWeekPow(IntPtr _this, double weekPow_);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetIHParamWEEK(IntPtr _this, double inr_, double outR_, double weekPow_);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetHeatTransRatioToAllVertex(IntPtr _this, double heatTransR_);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_AfterSetDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_SetStopTimespan(IntPtr _this, double timespan);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_UpdateMatk_RadiantHeatToAir(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_ActivateVtxbeRadiantHeat(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_OutputMatKall(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshThermoIf_IfRadiantHeatTrans(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemMeshNewIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemMeshNewIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshNewIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshNewIf_SetPHSolid(IntPtr _this, IntPtr s);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewIf_GetPHSolid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewIf_GetPHFemVibration(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewIf_GetPHFemThermo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewIf_GetPHFemPorousWOMove(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHFemMeshNewIf_NVertices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHFemMeshNewIf_NFaces(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHFemMeshNewIf_NTets(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshNewIf_SetVertexUpdateFlags(IntPtr _this, bool flg);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshNewIf_SetVertexUpateFlag(IntPtr _this, int vid, bool flg);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemMeshNewIf_CompTetVolume(IntPtr _this, int tetID, bool bDeform);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemMeshNewIf_AddVertexDisplacementW(IntPtr _this, int vtxId, IntPtr disW);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemMeshNewIf_AddVertexDisplacementL(IntPtr _this, int vtxId, IntPtr disL);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemMeshNewIf_SetVertexPositionW(IntPtr _this, int vtxId, IntPtr posW);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemMeshNewIf_SetVertexPositionL(IntPtr _this, int vtxId, IntPtr posL);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemMeshNewIf_SetVertexVelocityL(IntPtr _this, int vtxId, IntPtr posL);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewIf_GetVertexVelocityL(IntPtr _this, int vtxId);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewIf_GetVertexPositionL(IntPtr _this, int vtxId);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewIf_GetVertexDisplacementL(IntPtr _this, int vtxId);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewIf_GetVertexInitalPositionL(IntPtr _this, int vtxId);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemMeshNewIf_SetVelocity(IntPtr _this, IntPtr v);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewIf_GetTetVertexIds(IntPtr _this, int t);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewIf_GetFaceVertexIds(IntPtr _this, int f);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemMeshNewIf_GetFaceNormal(IntPtr _this, int f);
	[DllImport("SprExport")]
	public static extern int Spr_PHFemMeshNewIf_GetSurfaceVertex(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern int Spr_PHFemMeshNewIf_NSurfaceVertices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHFemMeshNewIf_NSurfaceFace(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemMeshNewIf_CompTetShapeFunctionValue(IntPtr _this, int tetId, IntPtr posL, IntPtr value, bool bDeform);
	[DllImport("SprExport")]
	public static extern int Spr_PHFemMeshNewIf_FindTetFromFace(IntPtr _this, int faceId);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemBaseIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemBaseIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemBaseIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemBaseIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemBaseIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemBaseIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemBaseIf_GetPHFemMesh(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemVibrationIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemVibrationIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemVibrationIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemVibrationIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemVibrationIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationIf_SetTimeStep(IntPtr _this, double dt);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemVibrationIf_GetTimeStep(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationIf_SetYoungModulus(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemVibrationIf_GetYoungModulus(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationIf_SetPoissonsRatio(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemVibrationIf_GetPoissonsRatio(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationIf_SetDensity(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemVibrationIf_GetDensity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationIf_SetAlpha(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemVibrationIf_GetAlpha(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationIf_SetBeta(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemVibrationIf_GetBeta(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationIf_SetBoundary(IntPtr _this, int vtxIds);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationIf_ClearBoundary(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemVibrationIf_GetBoundary(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationIf_SetAnalysisMode(IntPtr _this, int mode);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationIf_SetIntegrationMode(IntPtr _this, int mode);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemVibrationIf_AddBoundaryCondition(IntPtr _this, int vtxId, IntPtr dof);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationIf_DeleteBoundaryCondition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemVibrationIf_FindNeighborTetrahedron(IntPtr _this, IntPtr posW, int tetId, IntPtr cpW, bool bDeform);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemVibrationIf_SetDamping(IntPtr _this, int tetId, IntPtr posW, double damp_ratio);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemVibrationIf_AddForce(IntPtr _this, int tetId, IntPtr posW, IntPtr fW);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemVibrationIf_GetDisplacement(IntPtr _this, int tetId, IntPtr posW, IntPtr disp, bool bDeform);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemVibrationIf_GetVelocity(IntPtr _this, int tetId, IntPtr posW, IntPtr vel, bool bDeform);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemVibrationIf_GetPosition(IntPtr _this, int tetId, IntPtr posW, IntPtr pos, bool bDeform);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationIf_SetbRecomp(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemVibrationIf_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemThermoIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemThermoIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemThermoIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemThermoIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemThermoIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_PHFemThermoIf_GetSurfaceVertex(IntPtr _this, int id);
	[DllImport("SprExport")]
	public static extern int Spr_PHFemThermoIf_NSurfaceVertices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetVertexTc(IntPtr _this, int id, double temp);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetVertexTc_1(IntPtr _this, int id, double temp, double heatTrans);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemThermoIf_GetPose(IntPtr _this, int id);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemThermoIf_GetSufVtxPose(IntPtr _this, uint id);
	[DllImport("SprExport")]
	public static extern uint Spr_PHFemThermoIf_GetStepCount(IntPtr _this);
	[DllImport("SprExport")]
	public static extern uint Spr_PHFemThermoIf_GetStepCountCyc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoIf_GetVertexTemp(IntPtr _this, uint id);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoIf_GetSufVertexTemp(IntPtr _this, uint id);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetVertexTemp(IntPtr _this, uint id, double temp);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetVerticesTempAll(IntPtr _this, double temp);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_AddvecFAll(IntPtr _this, uint id, double dqdt);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetvecFAll(IntPtr _this, uint id, double dqdt);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetRhoSpheat(IntPtr _this, double rho, double Cp);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemThermoIf_GetIHbandDrawVtx(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_CalcIHdqdt_atleast(IntPtr _this, double r, double R, double dqdtAll, uint num);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_UpdateIHheatband(IntPtr _this, double xS, double xE, uint heatingMODE);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_UpdateIHheat(IntPtr _this, uint heating);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_UpdateVecF(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_UpdateVecF_frypan(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_DecrMoist(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_DecrMoist_velo(IntPtr _this, double vel);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_DecrMoist_vel(IntPtr _this, double dt);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_InitAllVertexTemp(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetInitThermoConductionParam(IntPtr _this, double thConduct, double rho, double specificHeat, double heatTrans);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetParamAndReCreateMatrix(IntPtr _this, double thConduct0, double roh0, double specificHeat0);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoIf_GetArbitraryPointTemp(IntPtr _this, IntPtr temppos);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoIf_GetVtxTempInTets(IntPtr _this, IntPtr temppos);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_InitVecFAlls(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoIf_Get_thConduct(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemThermoIf_SetConcentricHeatMap(IntPtr _this, IntPtr r, IntPtr temp, IntPtr origin);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetThermalEmissivityToVerticesAll(IntPtr _this, double thermalEmissivity, double thermalEmissivity_const);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetOuterTemp(IntPtr _this, double temp);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetThermalRadiation(IntPtr _this, double ems, double ems_const);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetGaussCalcParam(IntPtr _this, uint cyc, double epsilon);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_InitTcAll(IntPtr _this, double temp);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_InitToutAll(IntPtr _this, double temp);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetWeekPow(IntPtr _this, double weekPow_);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetIHParamWEEK(IntPtr _this, double inr_, double outR_, double weekPow_);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetHeatTransRatioToAllVertex(IntPtr _this, double heatTransR_);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_AfterSetDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetStopTimespan(IntPtr _this, double timespan);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_UpdateMatk_RadiantHeatToAir(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_ReCreateMatrix(IntPtr _this, double thConduct0);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_ActivateVtxbeRadiantHeat(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_OutputMatKall(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_IfRadiantHeatTrans(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_IfRadiantHeatTransSteak(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_PHFemThermoIf_calcGvtx(IntPtr _this, IntPtr fwfood, int pv, uint texture_mode);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetTimeStep(IntPtr _this, double dt);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemThermoIf_GetVertexNormal(IntPtr _this, uint vtxid);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetVertexHeatTransRatio(IntPtr _this, uint vtxid, double heattransRatio);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetVertexBeRadiantHeat(IntPtr _this, uint vtxid, bool flag);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoIf_GetVertexArea(IntPtr _this, uint vtxid);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetVertexToofar(IntPtr _this, uint vtxid, bool tooFar);
	[DllImport("SprExport")]
	public static extern char Spr_PHFemThermoIf_GetVertexToofar(IntPtr _this, uint vtxid);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetVertexBeCondVtxs(IntPtr _this, uint vtxid, bool becondVtxs);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_CreateVecFAll(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_CalcFaceNormalAll(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_CalcVertexNormalAll(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_InitFaceNormalAll(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_InitVertexNormalAll(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_RevVertexNormalAll(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetWeekPowFULL(IntPtr _this, double weekPow_full);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetweekPow_FULL(IntPtr _this, double setweekPow_FULL);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_setIhRatio(IntPtr _this, double a);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_Setems(IntPtr _this, double setems);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_Setems_steak(IntPtr _this, double setems_steak);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetthConduct(IntPtr _this, double thConduct);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoIf_GetWeekPowFULL(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemThermoIf_GetVertexPose(IntPtr _this, uint vtxid);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_OutTetVolumeAll(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHFemThermoIf_GetTetsV(IntPtr _this, uint tetid, uint vtxid);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_VecFNegativeCheck(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoIf_GetVecFElem(IntPtr _this, uint vtxid);
	[DllImport("SprExport")]
	public static extern int Spr_PHFemThermoIf_GetTetVNums(IntPtr _this, uint id, uint num);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemThermoIf_GetInitialTemp(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_UpdateVertexTempAll(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemThermoIf_SetThermoCameraScale(IntPtr _this, double minTemp, double maxTemp);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFemPorousWOMoveIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFemPorousWOMoveIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemPorousWOMoveIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemPorousWOMoveIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFemPorousWOMoveIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveIf_SetTimeStep(IntPtr _this, double dt);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveIf_GetTimeStep(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveIf_UpdateVertexRhoWAll(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveIf_UpdateVertexRhoOAll(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveIf_SetVertexMw(IntPtr _this, uint vtxid, double mw);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveIf_SetVertexMo(IntPtr _this, uint vtxid, double mo);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveIf_GetVertexMw(IntPtr _this, uint vtxid);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveIf_GetVertexMo(IntPtr _this, uint vtxid);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveIf_GetVtxWaterInTets(IntPtr _this, IntPtr temppos);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveIf_GetVtxOilInTets(IntPtr _this, IntPtr temppos);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveIf_GetVertexRhoW(IntPtr _this, uint vtxid);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveIf_GetVertexRhoO(IntPtr _this, uint vtxid);
	[DllImport("SprExport")]
	public static extern float Spr_PHFemPorousWOMoveIf_calcGvtx(IntPtr _this, IntPtr fwfood, int pv, uint texture_mode);
	[DllImport("SprExport")]
	public static extern void Spr_PHFemPorousWOMoveIf_setGravity(IntPtr _this, IntPtr g);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveIf_decideWetValue(IntPtr _this, uint faceid);
	[DllImport("SprExport")]
	public static extern double Spr_PHFemPorousWOMoveIf_GetVtxSaturation(IntPtr _this, uint vtxid);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFrameIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFrameIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFrameIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFrameIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFrameIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFrameIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFrameIf_GetPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFrameIf_SetPose(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFrameIf_GetShape(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBodyIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBodyIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBodyIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBodyIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBodyIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBodyIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBodyIf_GetPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBodyIf_GetVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBodyIf_GetAngularVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBodyIf_GetCenterOfMass(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBodyIf_GetFramePosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBodyIf_GetCenterPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHBodyIf_IsDynamical(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHBodyIf_IsFrozen(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBodyIf_AddShape(IntPtr _this, IntPtr shape);
	[DllImport("SprExport")]
	public static extern void Spr_PHBodyIf_AddShapes(IntPtr _this, IntPtr shBegin, IntPtr shEnd);
	[DllImport("SprExport")]
	public static extern void Spr_PHBodyIf_RemoveShape(IntPtr _this, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHBodyIf_RemoveShapes(IntPtr _this, int idxBegin, int idxEnd);
	[DllImport("SprExport")]
	public static extern void Spr_PHBodyIf_RemoveShape_1(IntPtr _this, IntPtr shape);
	[DllImport("SprExport")]
	public static extern int Spr_PHBodyIf_NShape(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBodyIf_GetShape(IntPtr _this, int index);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBodyIf_GetShapePose(IntPtr _this, int index);
	[DllImport("SprExport")]
	public static extern void Spr_PHBodyIf_SetShapePose(IntPtr _this, int index, IntPtr pose);
	[DllImport("SprExport")]
	public static extern void Spr_PHBodyIf_ClearShape(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBodyIf_GetBBox(IntPtr _this, IntPtr bbmin, IntPtr bbmax, bool world);
	[DllImport("SprExport")]
	public static extern char Spr_PHBodyIf_InvalidateBbox(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSolidIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSolidIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_AddForce(IntPtr _this, IntPtr f);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_AddTorque(IntPtr _this, IntPtr t);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_AddForce_1(IntPtr _this, IntPtr f, IntPtr r);
	[DllImport("SprExport")]
	public static extern double Spr_PHSolidIf_GetMass(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHSolidIf_GetMassInv(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_SetMass(IntPtr _this, double m);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_SetCenterOfMass(IntPtr _this, IntPtr center);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidIf_GetInertia(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidIf_GetInertiaInv(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_SetInertia(IntPtr _this, IntPtr I);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_CompInertia(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_SetFramePosition(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_SetCenterPosition(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidIf_GetDeltaPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidIf_GetDeltaPosition_1(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidIf_GetOrientation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_SetOrientation(IntPtr _this, IntPtr q);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_SetPose(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_SetVelocity(IntPtr _this, IntPtr v);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_SetAngularVelocity(IntPtr _this, IntPtr av);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidIf_GetForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidIf_GetTorque(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_SetGravity(IntPtr _this, bool bOn);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_SetDynamical(IntPtr _this, bool bOn);
	[DllImport("SprExport")]
	public static extern char Spr_PHSolidIf_IsDynamical(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidIf_SetStationary(IntPtr _this, bool bOn);
	[DllImport("SprExport")]
	public static extern char Spr_PHSolidIf_IsStationary(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidIf_GetTreeNode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHShapePairForLCPIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHShapePairForLCPIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHShapePairForLCPIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHShapePairForLCPIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHShapePairForLCPIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHShapePairForLCPIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_PHShapePairForLCPIf_NSectionVertexes(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHShapePairForLCPIf_GetSectionVertex(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern double Spr_PHShapePairForLCPIf_GetContactDimension(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHShapePairForLCPIf_GetNormalVector(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHShapePairForLCPIf_GetClosestPoints(IntPtr _this, IntPtr pa, IntPtr pb);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHShapePairForLCPIf_GetShape(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSolidPairIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSolidPairIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidPairIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairIf_GetSolid(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern int Spr_PHSolidPairIf_NListener(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairIf_GetListener(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidPairIf_RemoveListener(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidPairIf_AddListener(IntPtr _this, IntPtr l, int pos);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidPairIf_AddListener_1(IntPtr _this, IntPtr l);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSolidPairForLCPIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSolidPairForLCPIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairForLCPIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidPairForLCPIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairForLCPIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairForLCPIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_PHSolidPairForLCPIf_IsContactEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidPairForLCPIf_EnableContact(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern int Spr_PHSolidPairForLCPIf_GetContactState(IntPtr _this, int i, int j);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairForLCPIf_GetCommonPoint(IntPtr _this, int i, int j);
	[DllImport("SprExport")]
	public static extern uint Spr_PHSolidPairForLCPIf_GetLastContactCount(IntPtr _this, int i, int j);
	[DllImport("SprExport")]
	public static extern double Spr_PHSolidPairForLCPIf_GetContactDepth(IntPtr _this, int i, int j);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairForLCPIf_GetShapePair(IntPtr _this, int i, int j);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHHapticPointerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHHapticPointerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticPointerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticPointerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticPointerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_SetHapticRenderMode(IntPtr _this, int m);
	[DllImport("SprExport")]
	public static extern int Spr_PHHapticPointerIf_GetHapticRenderMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_EnableRotation(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern char Spr_PHHapticPointerIf_IsRotation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_EnableForce(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern char Spr_PHHapticPointerIf_IsForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_EnableFriction(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern char Spr_PHHapticPointerIf_IsFriction(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_EnableTimeVaryFriction(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern char Spr_PHHapticPointerIf_IsTimeVaryFriction(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_EnableVibration(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern char Spr_PHHapticPointerIf_IsVibration(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_EnableMultiPoints(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern char Spr_PHHapticPointerIf_IsMultiPoints(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_EnableMultiProxy(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern char Spr_PHHapticPointerIf_IsMultiProxy(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_EnableSimulation(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern char Spr_PHHapticPointerIf_IsSimulation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_SetFrictionSpring(IntPtr _this, float s);
	[DllImport("SprExport")]
	public static extern float Spr_PHHapticPointerIf_GetFrictionSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_SetFrictionDamper(IntPtr _this, float s);
	[DllImport("SprExport")]
	public static extern float Spr_PHHapticPointerIf_GetFrictionDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_SetReflexSpring(IntPtr _this, float s);
	[DllImport("SprExport")]
	public static extern float Spr_PHHapticPointerIf_GetReflexSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_SetReflexDamper(IntPtr _this, float d);
	[DllImport("SprExport")]
	public static extern float Spr_PHHapticPointerIf_GetReflexDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_SetRotationReflexSpring(IntPtr _this, float s);
	[DllImport("SprExport")]
	public static extern float Spr_PHHapticPointerIf_GetRotationReflexSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_SetRotationReflexDamper(IntPtr _this, float d);
	[DllImport("SprExport")]
	public static extern float Spr_PHHapticPointerIf_GetRotationReflexDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_SetLocalRange(IntPtr _this, float r);
	[DllImport("SprExport")]
	public static extern float Spr_PHHapticPointerIf_GetLocalRange(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_SetPosScale(IntPtr _this, double scale);
	[DllImport("SprExport")]
	public static extern double Spr_PHHapticPointerIf_GetPosScale(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_SetRotationalWeight(IntPtr _this, double w);
	[DllImport("SprExport")]
	public static extern double Spr_PHHapticPointerIf_GetRotationalWeight(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_SetDefaultPose(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticPointerIf_GetDefaultPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHHapticPointerIf_NNeighborSolids(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHHapticPointerIf_GetNeighborSolidId(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticPointerIf_GetNeighborSolid(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern float Spr_PHHapticPointerIf_GetContactForce(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticPointerIf_GetHapticForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticPointerIf_GetProxyVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_SetProxyN(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern int Spr_PHHapticPointerIf_GetProxyN(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHHapticPointerIf_GetTotalSlipState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHHapticPointerIf_GetSlipState(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_SetProxyVelocity(IntPtr _this, IntPtr spv);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_AddHapticForce(IntPtr _this, IntPtr f);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_ClearHapticForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticPointerIf_UpdateHumanInterface(IntPtr _this, IntPtr pose, IntPtr vel);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHShapePairForHapticIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHShapePairForHapticIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHShapePairForHapticIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHShapePairForHapticIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHShapePairForHapticIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHShapePairForHapticIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_PHShapePairForHapticIf_NIrs(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHShapePairForHapticIf_NIrsNormal(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHShapePairForHapticIf_GetIrForce(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern double Spr_PHShapePairForHapticIf_GetMu(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHShapePairForHapticIf_GetFrame(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_PHShapePairForHapticIf_UpdateCache(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHShapePairForHapticIf_GetMus(IntPtr _this, int id);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSolidPairForHapticIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSolidPairForHapticIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairForHapticIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidPairForHapticIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairForHapticIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairForHapticIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairForHapticIf_GetShapePair(IntPtr _this, int i, int j);
	[DllImport("SprExport")]
	public static extern int Spr_PHSolidPairForHapticIf_GetFrictionState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern uint Spr_PHSolidPairForHapticIf_GetContactCount(IntPtr _this);
	[DllImport("SprExport")]
	public static extern uint Spr_PHSolidPairForHapticIf_GetFrictionCount(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidPairForHapticIf_InitFrictionState(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidPairForHapticIf_InitFrictionCount(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidPairForHapticIf_InitContactCount(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern void Spr_PHSolidPairForHapticIf_InitSlipState(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern int Spr_PHSolidPairForHapticIf_GetSlipState(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairForHapticIf_GetForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSolidPairForHapticIf_GetTorque(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHSolidPairForHapticIf_GetFrictionStates(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHHapticEngineIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHHapticEngineIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticEngineIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticEngineIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticEngineIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticEngineIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticEngineIf_SetHapticStepMode(IntPtr _this, int mode);
	[DllImport("SprExport")]
	public static extern int Spr_PHHapticEngineIf_GetHapticStepMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHHapticEngineIf_NSolids(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHHapticEngineIf_NPointers(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticEngineIf_GetPointer(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticEngineIf_GetSolidPair(IntPtr _this, int i, int j);
	[DllImport("SprExport")]
	public static extern int Spr_PHHapticEngineIf_NSolidsInHaptic(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHHapticEngineIf_NPointersInHaptic(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticEngineIf_GetPointerInHaptic(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticEngineIf_GetSolidPairInHaptic(IntPtr _this, int i, int j);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticEngineIf_StepPhysicsSimulation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHapticEngineIf_ReleaseState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHapticEngineIf_Callback(IntPtr _this, IntPtr arg);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHIKEndEffectorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHIKEndEffectorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetSolid(IntPtr _this, IntPtr solid);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetSolid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetParentActuator(IntPtr _this, IntPtr ika);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetParentActuator(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_Enable(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern char Spr_PHIKEndEffectorIf_IsEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetTargetLocalPosition(IntPtr _this, IntPtr localPosition);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetTargetLocalPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetTargetLocalDirection(IntPtr _this, IntPtr localDirection);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetTargetLocalDirection(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_EnablePositionControl(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern char Spr_PHIKEndEffectorIf_IsPositionControlEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetPositionPriority(IntPtr _this, double priority);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEndEffectorIf_GetPositionPriority(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetTargetPosition(IntPtr _this, IntPtr position);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetTargetPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_EnableOrientationControl(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern char Spr_PHIKEndEffectorIf_IsOrientationControlEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetOrientationPriority(IntPtr _this, double priority);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKEndEffectorIf_GetOrientationPriority(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetOriCtlMode(IntPtr _this, int mode);
	[DllImport("SprExport")]
	public static extern int Spr_PHIKEndEffectorIf_GetOriCtlMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetTargetOrientation(IntPtr _this, IntPtr orientation);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetTargetOrientation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetTargetDirection(IntPtr _this, IntPtr direction);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetTargetDirection(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetTargetLookat(IntPtr _this, IntPtr lookat);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetTargetLookat(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetTargetVelocity(IntPtr _this, IntPtr velocity);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetTargetVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetTargetAngularVelocity(IntPtr _this, IntPtr angVel);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetTargetAngularVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_EnableForceControl(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetTargetForce(IntPtr _this, IntPtr force, IntPtr workingPoint);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetTargetForce_1(IntPtr _this, IntPtr force);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetTargetForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetTargetForceWorkingPoint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_EnableTorqueControl(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_SetTargetTorque(IntPtr _this, IntPtr torque);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetTargetTorque(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKEndEffectorIf_GetSolidTempPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKEndEffectorIf_ApplyExactState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHIKActuatorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHIKActuatorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKActuatorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKActuatorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKActuatorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorIf_PrepareSolve(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorIf_ProceedSolve(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorIf_Move(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorIf_ApplyExactState(IntPtr _this, bool reverse);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorIf_ApplyExactState_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorIf_SetBias(IntPtr _this, float bias);
	[DllImport("SprExport")]
	public static extern float Spr_PHIKActuatorIf_GetBias(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorIf_SetPullbackRate(IntPtr _this, double pullbackRate);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKActuatorIf_GetPullbackRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKActuatorIf_Enable(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern char Spr_PHIKActuatorIf_IsEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHIKActuatorIf_NAncestors(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKActuatorIf_GetAncestor(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKActuatorIf_GetParent(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHIKActuatorIf_NChildActuators(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKActuatorIf_GetChildActuator(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKActuatorIf_GetChildEndEffector(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKActuatorIf_GetSolidTempPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKActuatorIf_GetSolidPullbackPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHIKBallActuatorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHIKBallActuatorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKBallActuatorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKBallActuatorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKBallActuatorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKBallActuatorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHIKBallActuatorIf_SetJoint(IntPtr _this, IntPtr joint);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKBallActuatorIf_GetJoint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKBallActuatorIf_SetJointTempOri(IntPtr _this, IntPtr ori);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKBallActuatorIf_SetPullbackTarget(IntPtr _this, IntPtr ori);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKBallActuatorIf_GetJointTempOri(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKBallActuatorIf_GetPullbackTarget(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHIKHingeActuatorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHIKHingeActuatorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKHingeActuatorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKHingeActuatorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKHingeActuatorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKHingeActuatorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHIKHingeActuatorIf_SetJoint(IntPtr _this, IntPtr joint);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKHingeActuatorIf_GetJoint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKHingeActuatorIf_SetJointTempAngle(IntPtr _this, double angle);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKHingeActuatorIf_SetPullbackTarget(IntPtr _this, double angle);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKHingeActuatorIf_GetJointTempAngle(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHIKHingeActuatorIf_GetPullbackTarget(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHIKSpringActuatorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHIKSpringActuatorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKSpringActuatorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKSpringActuatorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKSpringActuatorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKSpringActuatorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHIKSpringActuatorIf_SetJoint(IntPtr _this, IntPtr joint);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKSpringActuatorIf_GetJoint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKSpringActuatorIf_SetJointTempPose(IntPtr _this, IntPtr pose);
	[DllImport("SprExport")]
	public static extern void Spr_PHIKSpringActuatorIf_SetPullbackTarget(IntPtr _this, IntPtr pose);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKSpringActuatorIf_GetJointTempPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHIKSpringActuatorIf_GetPullbackTarget(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHConstraintIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHConstraintIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintIf_GetSocketSolid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintIf_GetPlugSolid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintIf_GetScene(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintIf_Enable(IntPtr _this, bool bEnable);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintIf_Enable_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHConstraintIf_IsEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHConstraintIf_IsArticulated(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintIf_GetSocketPose(IntPtr _this, IntPtr pose);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintIf_SetSocketPose(IntPtr _this, IntPtr pose);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintIf_GetPlugPose(IntPtr _this, IntPtr pose);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintIf_SetPlugPose(IntPtr _this, IntPtr pose);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintIf_GetRelativePose(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintIf_GetRelativePoseR(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintIf_GetRelativePoseQ(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintIf_GetAbsolutePoseQ(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintIf_GetRelativeVelocity(IntPtr _this, IntPtr v, IntPtr w);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintIf_GetConstraintForce(IntPtr _this, IntPtr f, IntPtr t);
	[DllImport("SprExport")]
	public static extern char Spr_PHConstraintIf_IsYielded(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHConstraintsIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHConstraintsIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintsIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHConstraintsIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintsIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintsIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintsIf_FindBySolidPair(IntPtr _this, IntPtr lhs, IntPtr rhs);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHConstraintsIf_GetTotalForce(IntPtr _this, IntPtr lhs, IntPtr rhs);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHContactPointIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHContactPointIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHContactPointIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHContactPointIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHContactPointIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHContactPointIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHContactPointIf_GetPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHContactPointIf_IsStaticFriction(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHJointIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHJointIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHJointIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHJointIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHJointIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHJointIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHJointIf_SetMaxForce(IntPtr _this, double max);
	[DllImport("SprExport")]
	public static extern double Spr_PHJointIf_GetMaxForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PH1DJointIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PH1DJointIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointIf_CreateLimit(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointIf_CreateLimit_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointIf_CreateMotor(IntPtr _this, IntPtr ii, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointIf_CreateMotor_1(IntPtr _this, IntPtr ii);
	[DllImport("SprExport")]
	public static extern char Spr_PH1DJointIf_AddMotor(IntPtr _this, IntPtr m);
	[DllImport("SprExport")]
	public static extern char Spr_PH1DJointIf_RemoveMotor(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern char Spr_PH1DJointIf_IsCyclic(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointIf_SetCyclic(IntPtr _this, bool on);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PH1DJointIf_HasLimit(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointIf_GetLimit(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointIf_SetSpring(IntPtr _this, double spring);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointIf_SetDamper(IntPtr _this, double damper);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetSecondDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointIf_SetSecondDamper(IntPtr _this, double input);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointIf_SetTargetPosition(IntPtr _this, double targetPosition);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetTargetPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointIf_SetTargetVelocity(IntPtr _this, double v);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetTargetVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointIf_SetOffsetForce(IntPtr _this, double dat);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetOffsetForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointIf_SetOffsetForceN(IntPtr _this, int n, double dat);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetOffsetForceN(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetYieldStress(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointIf_SetYieldStress(IntPtr _this, double yS);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetHardnessRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointIf_SetHardnessRate(IntPtr _this, double hR);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointIf_SetSecondMoment(IntPtr _this, double sM);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetSecondMoment(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PH1DJointIf_NMotors(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointIf_GetMotors(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetMotorForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetMotorForceN(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointIf_GetLimitForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHHingeJointIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHHingeJointIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHingeJointIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHingeJointIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHingeJointIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHingeJointIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSliderJointIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSliderJointIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSliderJointIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSliderJointIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSliderJointIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSliderJointIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPathIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPathIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPathIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHPathIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPathIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPathIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHPathIf_AddPoint(IntPtr _this, double s, IntPtr pose);
	[DllImport("SprExport")]
	public static extern void Spr_PHPathIf_SetLoop(IntPtr _this, bool bOnOff);
	[DllImport("SprExport")]
	public static extern void Spr_PHPathIf_SetLoop_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHPathIf_IsLoop(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPathJointIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPathJointIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPathJointIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHPathJointIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPathJointIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPathJointIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHPathJointIf_SetPosition(IntPtr _this, double q);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHGenericJointIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHGenericJointIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHGenericJointIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHGenericJointIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHGenericJointIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHGenericJointIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHGenericJointIf_SetCallback(IntPtr _this, IntPtr cb);
	[DllImport("SprExport")]
	public static extern void Spr_PHGenericJointIf_SetParam(IntPtr _this, IntPtr name, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_CreateLimit(IntPtr _this, IntPtr ii, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_CreateLimit_1(IntPtr _this, IntPtr ii);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_CreateMotor(IntPtr _this, IntPtr ii, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_CreateMotor_1(IntPtr _this, IntPtr ii);
	[DllImport("SprExport")]
	public static extern char Spr_PHBallJointIf_AddMotor(IntPtr _this, IntPtr m);
	[DllImport("SprExport")]
	public static extern char Spr_PHBallJointIf_RemoveMotor(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetAngle(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHBallJointIf_HasLimit(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetLimit(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIf_SetSpring(IntPtr _this, double spring);
	[DllImport("SprExport")]
	public static extern double Spr_PHBallJointIf_GetSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIf_SetDamper(IntPtr _this, double damper);
	[DllImport("SprExport")]
	public static extern double Spr_PHBallJointIf_GetDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetSecondDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIf_SetSecondDamper(IntPtr _this, IntPtr damper2);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIf_SetTargetPosition(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetTargetPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIf_SetTargetVelocity(IntPtr _this, IntPtr q);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetTargetVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIf_SetOffsetForce(IntPtr _this, IntPtr ofst);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetOffsetForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIf_SetOffsetForceN(IntPtr _this, int n, IntPtr ofst);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetOffsetForceN(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIf_SetYieldStress(IntPtr _this, double yS);
	[DllImport("SprExport")]
	public static extern double Spr_PHBallJointIf_GetYieldStress(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIf_SetHardnessRate(IntPtr _this, double hR);
	[DllImport("SprExport")]
	public static extern double Spr_PHBallJointIf_GetHardnessRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIf_SetSecondMoment(IntPtr _this, IntPtr m);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetSecondMoment(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHBallJointIf_NMotors(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetMotors(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetMotorForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetMotorForceN(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIf_GetLimitForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFixJointIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFixJointIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFixJointIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFixJointIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFixJointIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFixJointIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSpringIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSpringIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringIf_SetTargetPosition(IntPtr _this, IntPtr targetPosition);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringIf_GetTargetPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringIf_SetTargetOrientation(IntPtr _this, IntPtr targetOrientation);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringIf_GetTargetOrientation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringIf_SetSpring(IntPtr _this, IntPtr spring);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringIf_GetSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringIf_SetDamper(IntPtr _this, IntPtr damper);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringIf_GetDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringIf_SetSecondDamper(IntPtr _this, IntPtr secondDamper);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringIf_GetSecondDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringIf_SetSpringOri(IntPtr _this, double spring);
	[DllImport("SprExport")]
	public static extern double Spr_PHSpringIf_GetSpringOri(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringIf_SetDamperOri(IntPtr _this, double damper);
	[DllImport("SprExport")]
	public static extern double Spr_PHSpringIf_GetDamperOri(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringIf_SetSecondDamperOri(IntPtr _this, double secondDamperOri);
	[DllImport("SprExport")]
	public static extern double Spr_PHSpringIf_GetSecondDamperOri(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringIf_SetYieldStress(IntPtr _this, double yieldStress);
	[DllImport("SprExport")]
	public static extern double Spr_PHSpringIf_GetYieldStress(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringIf_SetHardnessRate(IntPtr _this, double hardnessRate);
	[DllImport("SprExport")]
	public static extern double Spr_PHSpringIf_GetHardnessRate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringIf_SetSecondMoment(IntPtr _this, IntPtr secondMoment);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringIf_GetSecondMoment(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringIf_GetMotorForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringIf_SetOffsetForce(IntPtr _this, IntPtr offsetForce);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringIf_SetTargetVelocity(IntPtr _this, IntPtr targetVelocity);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringIf_GetTargetVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHMateIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHMateIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMateIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHMateIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMateIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHMateIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPointToPointMateIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPointToPointMateIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPointToPointMateIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHPointToPointMateIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPointToPointMateIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPointToPointMateIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPointToLineMateIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPointToLineMateIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPointToLineMateIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHPointToLineMateIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPointToLineMateIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPointToLineMateIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPointToPlaneMateIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPointToPlaneMateIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPointToPlaneMateIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHPointToPlaneMateIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPointToPlaneMateIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPointToPlaneMateIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHPointToPlaneMateIf_SetRange(IntPtr _this, IntPtr range);
	[DllImport("SprExport")]
	public static extern void Spr_PHPointToPlaneMateIf_GetRange(IntPtr _this, IntPtr range);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHLineToLineMateIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHLineToLineMateIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHLineToLineMateIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHLineToLineMateIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHLineToLineMateIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHLineToLineMateIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPlaneToPlaneMateIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPlaneToPlaneMateIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPlaneToPlaneMateIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHPlaneToPlaneMateIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPlaneToPlaneMateIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPlaneToPlaneMateIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHTreeNodeIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHTreeNodeIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHTreeNodeIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHTreeNodeIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHTreeNodeIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHTreeNodeIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHTreeNodeIf_Enable(IntPtr _this, bool bEnable);
	[DllImport("SprExport")]
	public static extern void Spr_PHTreeNodeIf_Enable_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHTreeNodeIf_IsEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHTreeNodeIf_NChildren(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHTreeNodeIf_GetParentNode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHTreeNodeIf_GetChildNode(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHTreeNodeIf_GetRootNode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHTreeNodeIf_GetSolid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHRootNodeIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHRootNodeIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRootNodeIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHRootNodeIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRootNodeIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRootNodeIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHTreeNode1DIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHTreeNode1DIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHTreeNode1DIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHTreeNode1DIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHTreeNode1DIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHTreeNode1DIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHHingeJointNodeIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHHingeJointNodeIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHingeJointNodeIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHingeJointNodeIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHingeJointNodeIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHingeJointNodeIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSliderJointNodeIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSliderJointNodeIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSliderJointNodeIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSliderJointNodeIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSliderJointNodeIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSliderJointNodeIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHPathJointNodeIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHPathJointNodeIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPathJointNodeIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHPathJointNodeIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPathJointNodeIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHPathJointNodeIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHGenericJointNodeIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHGenericJointNodeIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHGenericJointNodeIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHGenericJointNodeIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHGenericJointNodeIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHGenericJointNodeIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointNodeIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointNodeIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointNodeIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointNodeIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointNodeIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointNodeIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHFixJointNodeIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHFixJointNodeIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFixJointNodeIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHFixJointNodeIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFixJointNodeIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHFixJointNodeIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHGearIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHGearIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHGearIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHGearIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHGearIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHGearIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHGearIf_Enable(IntPtr _this, bool bEnable);
	[DllImport("SprExport")]
	public static extern void Spr_PHGearIf_Enable_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHGearIf_IsEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHGearIf_SetRatio(IntPtr _this, double ratio);
	[DllImport("SprExport")]
	public static extern double Spr_PHGearIf_GetRatio(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHGearIf_SetOffset(IntPtr _this, double offset);
	[DllImport("SprExport")]
	public static extern double Spr_PHGearIf_GetOffset(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHGearIf_SetMode(IntPtr _this, int mode);
	[DllImport("SprExport")]
	public static extern int Spr_PHGearIf_GetMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PH1DJointLimitIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PH1DJointLimitIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointLimitIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointLimitIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointLimitIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointLimitIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointLimitIf_SetRange(IntPtr _this, IntPtr range);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointLimitIf_GetRange(IntPtr _this, IntPtr range);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointLimitIf_SetSpring(IntPtr _this, double spring);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointLimitIf_GetSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointLimitIf_SetDamper(IntPtr _this, double damper);
	[DllImport("SprExport")]
	public static extern double Spr_PH1DJointLimitIf_GetDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PH1DJointLimitIf_IsOnLimit(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointLimitIf_Enable(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern char Spr_PH1DJointLimitIf_IsEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointLimitIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointLimitIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointLimitIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointLimitIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointLimitIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointLimitIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointLimitIf_SetSpring(IntPtr _this, double rSpring);
	[DllImport("SprExport")]
	public static extern double Spr_PHBallJointLimitIf_GetSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointLimitIf_SetDamper(IntPtr _this, double rDamper);
	[DllImport("SprExport")]
	public static extern double Spr_PHBallJointLimitIf_GetDamper(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointLimitIf_SetLimitDir(IntPtr _this, IntPtr limDir);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointLimitIf_GetLimitDir(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHBallJointLimitIf_IsOnLimit(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointLimitIf_Enable(IntPtr _this, bool b);
	[DllImport("SprExport")]
	public static extern char Spr_PHBallJointLimitIf_IsEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointConeLimitIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointConeLimitIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointConeLimitIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointConeLimitIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointConeLimitIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointConeLimitIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointConeLimitIf_SetSwingRange(IntPtr _this, IntPtr range);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointConeLimitIf_GetSwingRange(IntPtr _this, IntPtr range);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointConeLimitIf_SetSwingDirRange(IntPtr _this, IntPtr range);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointConeLimitIf_GetSwingDirRange(IntPtr _this, IntPtr range);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointConeLimitIf_SetTwistRange(IntPtr _this, IntPtr range);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointConeLimitIf_GetTwistRange(IntPtr _this, IntPtr range);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointSplineLimitIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointSplineLimitIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointSplineLimitIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointSplineLimitIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointSplineLimitIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointSplineLimitIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointSplineLimitIf_AddNode(IntPtr _this, IntPtr node);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointSplineLimitIf_AddNode_1(IntPtr _this, double S, double SD, double dS, double dSD, double tMin, double tMax);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointSplineLimitIf_AddNode_2(IntPtr _this, IntPtr node, int pos);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointSplineLimitIf_AddNode_3(IntPtr _this, double S, double SD, double dS, double dSD, double tMin, double tMax, int pos);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointSplineLimitIf_SetPoleTwistRange(IntPtr _this, IntPtr range);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointSplineLimitIf_GetPoleTwistRange(IntPtr _this, IntPtr range);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointIndependentLimitIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointIndependentLimitIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIndependentLimitIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIndependentLimitIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIndependentLimitIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointIndependentLimitIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_PHBallJointIndependentLimitIf_IsOnLimit(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHBallJointIndependentLimitIf_AxesEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIndependentLimitIf_SetLimitRangeN(IntPtr _this, int n, IntPtr range);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointIndependentLimitIf_GetLimitRangeN(IntPtr _this, int n, IntPtr range);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PH1DJointMotorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PH1DJointMotorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointMotorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointMotorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointMotorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointMotorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PH1DJointNonLinearMotorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PH1DJointNonLinearMotorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointNonLinearMotorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointNonLinearMotorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointNonLinearMotorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PH1DJointNonLinearMotorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointNonLinearMotorIf_SetSpring(IntPtr _this, int m, IntPtr param);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointNonLinearMotorIf_SetDamper(IntPtr _this, int m, IntPtr param);
	[DllImport("SprExport")]
	public static extern void Spr_PH1DJointNonLinearMotorIf_SetSpringDamper(IntPtr _this, int smode, int dmode, IntPtr sparam, IntPtr dparam);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHHuman1DJointResistanceIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHHuman1DJointResistanceIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHuman1DJointResistanceIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHuman1DJointResistanceIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHuman1DJointResistanceIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHuman1DJointResistanceIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern double Spr_PHHuman1DJointResistanceIf_GetCurrentResistance(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointMotorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointMotorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointMotorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointMotorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointMotorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointMotorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBallJointNonLinearMotorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBallJointNonLinearMotorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointNonLinearMotorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointNonLinearMotorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointNonLinearMotorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBallJointNonLinearMotorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHBallJointNonLinearMotorIf_SetFuncFromDatabaseN(IntPtr _this, int n, int i, int j, IntPtr sparam, IntPtr dparam);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHHumanBallJointResistanceIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHHumanBallJointResistanceIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHumanBallJointResistanceIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHHumanBallJointResistanceIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHumanBallJointResistanceIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHumanBallJointResistanceIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHHumanBallJointResistanceIf_GetCurrentResistance(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSpringMotorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSpringMotorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringMotorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSpringMotorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringMotorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSpringMotorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpObjIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpObjIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpObjIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpObjIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpObjIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_PHOpObjIf_initialPHOpObj(IntPtr _this, IntPtr vts, int vtsNum, float pSize);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_SetGravity(IntPtr _this, bool bOn);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_SimpleSimulationStep(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_AddVertextoLocalBuffer(IntPtr _this, IntPtr v);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpObjIf_InitialObjUsingLocalBuffer(IntPtr _this, float pSize);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_positionPredict(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_groupStep(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_integrationStep(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_ReducedPositionProject(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_positionProject(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_SetDefaultLinkNum(IntPtr _this, int linkNum);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_BuildBlendWeight(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_buildGroupCenter(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpObjIf_GetVertexNum(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpObjIf_GetVertex(IntPtr _this, int vi);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpObjIf_GetOpParticle(IntPtr _this, int pi);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpObjIf_GetOpGroup(IntPtr _this, int gi);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpObjIf_GetobjVtoPmap(IntPtr _this, int vi);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpObjIf_GetVtxBlendWeight(IntPtr _this, int Vtxi, int Grpi);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_SetVelocityDamping(IntPtr _this, float vd);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpObjIf_GetVelocityDamping(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpObjIf_GetBoundLength(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_SetBound(IntPtr _this, float b);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_SetTimeStep(IntPtr _this, float t);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpObjIf_GetTimeStep(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpObjIf_GetObjBeta(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_SetObjBeta(IntPtr _this, float beta);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_SetObjAlpha(IntPtr _this, float alpha);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpObjIf_GetObjAlpha(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpObjIf_GetObjDstConstraint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_SetObjDstConstraint(IntPtr _this, bool d);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_SetObjItrTime(IntPtr _this, int itrT);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpObjIf_GetObjItrTime(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpObjIf_StoreOrigPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpParticleIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpParticleIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpParticleIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_PHOpParticleIf_GetOpPtclVtxId(IntPtr _this, int vi);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpParticleIf_GetinGrpListNum(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpParticleIf_GetinGrpList(IntPtr _this, int gi);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpParticleIf_GetVtxDisWeight(IntPtr _this, int vi);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpParticleIf_GetParticleDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpGroupIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpGroupIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpGroupIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpGroupIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpGroupIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpGroupIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_PHOpGroupIf_GetGrpInPtclNum(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHOpGroupIf_GetGrpInPtcl(IntPtr _this, int gi);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpGroupIf_GetGroupDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpHapticControllerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpHapticControllerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerIf_SetHCForceReady(IntPtr _this, bool flag);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticControllerIf_GetHCForceReady(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticControllerIf_CheckProxyState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerIf_AddColliedPtcl(IntPtr _this, int pIndex, int objindex, IntPtr ctcPos);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticControllerIf_BeginLogForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerIf_EndLogForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerIf_setC_ObstacleRadius(IntPtr _this, float r);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerIf_GetUserPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerIf_GetHCPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerIf_SetHCPosition(IntPtr _this, IntPtr pos);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticControllerIf_SetHCPose(IntPtr _this, IntPtr pose);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerIf_GetHCPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpHapticControllerIf_GetC_ObstacleRadius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticControllerIf_GetCurrentOutputForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpHapticRendererIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpHapticRendererIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticRendererIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticRendererIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpHapticRendererIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHOpHapticRendererIf_SetRigid(IntPtr _this, bool set);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpHapticRendererIf_IsRigid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpAnimationIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpAnimationIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpAnimationIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpAnimationIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpAnimationIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpAnimationIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHOpAnimationIf_AddAnimationP(IntPtr _this, int objIndex, int pIndex, IntPtr start, IntPtr end, float totalTime);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpAnimationIf_AddAnimationP_1(IntPtr _this, int objIndex, int pIndex, IntPtr force, float totalTime);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpAnimationIf_AnimationStep(IntPtr _this, IntPtr opEngine);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpAnimationIf_AnimationIntergration(IntPtr _this, IntPtr opEngine);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHOpSpHashColliAgentIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHOpSpHashColliAgentIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpSpHashColliAgentIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpSpHashColliAgentIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpSpHashColliAgentIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHOpSpHashColliAgentIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHOpSpHashColliAgentIf_SetCollisionCstrStiffness(IntPtr _this, float alpha);
	[DllImport("SprExport")]
	public static extern float Spr_PHOpSpHashColliAgentIf_GetCollisionCstrStiffness(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpSpHashColliAgentIf_EnableCollisionDetection(IntPtr _this, bool able);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpSpHashColliAgentIf_EnableCollisionDetection_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpSpHashColliAgentIf_Initial(IntPtr _this, float cellSize, IntPtr bounds);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpSpHashColliAgentIf_OpCollisionProcedure(IntPtr _this, int myTimeStamp);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpSpHashColliAgentIf_OpCollisionProcedure_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpSpHashColliAgentIf_OpDirCollision(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpSpHashColliAgentIf_AddContactPlane(IntPtr _this, IntPtr planeP, IntPtr planeN);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpSpHashColliAgentIf_IsCollisionEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpSpHashColliAgentIf_SetIsDirCollision(IntPtr _this, bool flag);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpSpHashColliAgentIf_GetIsDirCollision(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHOpSpHashColliAgentIf_SetDebugMode(IntPtr _this, bool flag);
	[DllImport("SprExport")]
	public static extern char Spr_PHOpSpHashColliAgentIf_GetDebugMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHRayIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHRayIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRayIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHRayIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRayIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRayIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRayIf_GetOrigin(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHRayIf_SetOrigin(IntPtr _this, IntPtr ori);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRayIf_GetDirection(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHRayIf_SetDirection(IntPtr _this, IntPtr dir);
	[DllImport("SprExport")]
	public static extern void Spr_PHRayIf_Apply(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHRayIf_NHits(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRayIf_GetHits(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRayIf_GetNearest(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHRayIf_GetDynamicalNearest(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSceneIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSceneIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetSdk(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateSolid(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateSolid_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_NSolids(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetSolid(IntPtr _this, int idx);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_GetSolidIndex(IntPtr _this, IntPtr s);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetSolids(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_NSolidPairs(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetSolidPair(IntPtr _this, int i, int j);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetSolidPair_1(IntPtr _this, IntPtr lhs, IntPtr rhs, bool bSwap);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetContactMode(IntPtr _this, IntPtr lhs, IntPtr rhs, int mode);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetContactMode_1(IntPtr _this, IntPtr lhs, IntPtr rhs);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetContactMode_2(IntPtr _this, IntPtr group, ulong length, int mode);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetContactMode_3(IntPtr _this, IntPtr group, ulong length);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetContactMode_4(IntPtr _this, IntPtr solid, int mode);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetContactMode_5(IntPtr _this, IntPtr solid);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetContactMode_6(IntPtr _this, int mode);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetContactMode_7(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateJoint(IntPtr _this, IntPtr lhs, IntPtr rhs, IntPtr ii, IntPtr desc);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_NJoints(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetJoint(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_NContacts(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetContact(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_NFemMeshes(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetFemMesh(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_NFemMeshesNew(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetFemMeshNew(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateRootNode(IntPtr _this, IntPtr root, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateRootNode_1(IntPtr _this, IntPtr root);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_NRootNodes(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetRootNode(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateTreeNode(IntPtr _this, IntPtr parent, IntPtr child, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateTreeNode_1(IntPtr _this, IntPtr parent, IntPtr child);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateTreeNodes(IntPtr _this, IntPtr solid);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateGear(IntPtr _this, IntPtr lhs, IntPtr rhs, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateGear_1(IntPtr _this, IntPtr lhs, IntPtr rhs);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_NGears(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetGear(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreatePath(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreatePath_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_NPaths(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetPath(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateRay(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateRay_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_NRays(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetRay(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern char Spr_PHSceneIf_SetPosesOfJointedSolids(IntPtr _this, IntPtr base_);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateIKActuator(IntPtr _this, IntPtr ii, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateIKActuator_1(IntPtr _this, IntPtr ii);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_NIKActuators(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetIKActuator(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateIKEndEffector(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateIKEndEffector_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_NIKEndEffectors(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetIKEndEffector(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_NSkeletons(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetSkeleton(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateSkeleton(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateSkeleton_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneIf_GetTimeStep(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneIf_GetTimeStepInv(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetTimeStep(IntPtr _this, double dt);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneIf_GetHapticTimeStep(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetHapticTimeStep(IntPtr _this, double dt);
	[DllImport("SprExport")]
	public static extern uint Spr_PHSceneIf_GetCount(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetCount(IntPtr _this, uint count);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetGravity(IntPtr _this, IntPtr accel);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetGravity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetAirResistanceRateForVelocity(IntPtr _this, double rate);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetAirResistanceRateForAngularVelocity(IntPtr _this, double rate);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneIf_GetAirResistanceRateForVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneIf_GetAirResistanceRateForAngularVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetContactTolerance(IntPtr _this, double tol);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneIf_GetContactTolerance(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetImpactThreshold(IntPtr _this, double vth);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneIf_GetImpactThreshold(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetFrictionThreshold(IntPtr _this, double vth);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneIf_GetFrictionThreshold(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetMaxVelocity(IntPtr _this, double vmax);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneIf_GetMaxVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetMaxAngularVelocity(IntPtr _this, double wmax);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneIf_GetMaxAngularVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetMaxForce(IntPtr _this, double fmax);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneIf_GetMaxForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetMaxMoment(IntPtr _this, double tmax);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneIf_GetMaxMoment(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetMaxDeltaPosition(IntPtr _this, double dpmax);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneIf_GetMaxDeltaPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetMaxDeltaOrientation(IntPtr _this, double dqmax);
	[DllImport("SprExport")]
	public static extern double Spr_PHSceneIf_GetMaxDeltaOrientation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_GetLCPSolver(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetLCPSolver(IntPtr _this, int method);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_GetNumIteration(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetNumIteration(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetStateMode(IntPtr _this, bool bConstraints);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_EnableContactDetection(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern char Spr_PHSceneIf_IsContactDetectionEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_EnableCCD(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern char Spr_PHSceneIf_IsCCDEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetBroadPhaseMode(IntPtr _this, int mode);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_GetBroadPhaseMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetContactDetectionRange(IntPtr _this, IntPtr center, IntPtr extent, int nx, int ny, int nz);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_SetMaterialBlending(IntPtr _this, int mode);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_GetMaterialBlending(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_Step(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_ClearForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_GenerateForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_Integrate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_IntegratePart1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_IntegratePart2(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_Clear(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHSceneIf_NEngines(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetEngine(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetConstraintEngine(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetGravityEngine(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetPenaltyEngine(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetIKEngine(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetFemEngine(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetHapticEngine(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetOpEngine(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_GetOpColliAgent(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSceneIf_CreateHapticPointer(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_StepHapticLoop(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSceneIf_StepHapticSync(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSdkIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSdkIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSdkIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSdkIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSdkIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSdkIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSdkIf_CreateScene(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSdkIf_CreateScene_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_PHSdkIf_NScene(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSdkIf_GetScene(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_PHSdkIf_MergeScene(IntPtr _this, IntPtr scene0, IntPtr scene1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSdkIf_CreateShape(IntPtr _this, IntPtr ii, IntPtr desc);
	[DllImport("SprExport")]
	public static extern int Spr_PHSdkIf_NShape(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSdkIf_GetShape(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSdkIf_CreateSdk(IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSdkIf_CreateSdk_1();
	[DllImport("SprExport")]
	public static extern void Spr_PHSdkIf_RegisterSdk();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHBoneIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHBoneIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBoneIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBoneIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBoneIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBoneIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_PHBoneIf_SetSolid(IntPtr _this, IntPtr solid);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBoneIf_GetSolid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBoneIf_SetProxySolid(IntPtr _this, IntPtr solid);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBoneIf_GetProxySolid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBoneIf_SetJoint(IntPtr _this, IntPtr joint);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBoneIf_GetJoint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBoneIf_SetParent(IntPtr _this, IntPtr parent);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHBoneIf_GetParent(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHBoneIf_SetLength(IntPtr _this, double length);
	[DllImport("SprExport")]
	public static extern void Spr_PHBoneIf_SetDirection(IntPtr _this, IntPtr dir);
	[DllImport("SprExport")]
	public static extern void Spr_PHBoneIf_SetPosition(IntPtr _this, IntPtr pos);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_PHSkeletonIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_PHSkeletonIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSkeletonIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_PHSkeletonIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSkeletonIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSkeletonIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_PHSkeletonIf_NBones(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSkeletonIf_GetBone(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSkeletonIf_CreateBone(IntPtr _this, IntPtr parent, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_PHSkeletonIf_CreateBone_1(IntPtr _this, IntPtr parent);
	[DllImport("SprExport")]
	public static extern float Spr_PHSkeletonIf_GetGrabStrength(IntPtr _this);
    }
}
