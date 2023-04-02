using System;
using System.Runtime.InteropServices;
namespace SprCs {
    public partial class SprExport {
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRBodyDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRBodyDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRBoneDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRBoneDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBoneDesc_get_label(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRBoneDesc_set_label(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_CRBoneDesc_FreeString_label(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CREngineDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CREngineDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRControllerDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRControllerDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRGazeControllerDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRGazeControllerDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRGazeControllerDesc_addr_front(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRGazeControllerDesc_set_front(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRGazeControllerDesc_addr_up(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRGazeControllerDesc_set_up(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRGrabControllerDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRGrabControllerDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRCreatureDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRCreatureDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRReachControllerState();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRReachControllerState(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_CRReachControllerState_get_time(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_time(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_CRReachControllerState_get_reachTime(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_reachTime(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_CRReachControllerState_get_viaTime(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_viaTime(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_CRReachControllerState_get_oricontTimeRatio(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_oricontTimeRatio(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_initPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_initPos(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_initVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_initVel(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_initAVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_initAVel(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_initOri(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_initOri(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_viaPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_viaPos(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_viaOri(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_viaOri(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_targPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_targPos(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_targVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_targVel(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_targAVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_targAVel(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_targOri(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_targOri(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_currPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_currPos(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_currVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_currVel(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_currAVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_currAVel(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_currOri(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_currOri(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_finalPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_finalPos(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_finalVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_finalVel(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_finalAVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_finalAVel(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerState_addr_finalOri(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerState_set_finalOri(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRReachControllerDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRReachControllerDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_CRReachControllerDesc_get_margin(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerDesc_set_margin(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_CRReachControllerDesc_get_innerMargin(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerDesc_set_innerMargin(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_CRReachControllerDesc_get_averageSpeed(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerDesc_set_averageSpeed(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_CRReachControllerDesc_get_waitVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerDesc_set_waitVel(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_CRReachControllerDesc_get_restartVel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerDesc_set_restartVel(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRSdkDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRSdkDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRContactInfo();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRContactInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_CRContactInfo_get_dimension(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRContactInfo_set_dimension(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRContactInfo_addr_normal(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRContactInfo_set_normal(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern double Spr_CRContactInfo_get_pressure(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRContactInfo_set_pressure(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRContactInfo_addr_pos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRContactInfo_set_pos(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRContactInfo_get_soMe(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRContactInfo_set_soMe(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRContactInfo_get_soOther(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRContactInfo_set_soOther(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRContactInfo_addr_force(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRContactInfo_set_force(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRTouchSensorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRTouchSensorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRVisualInfo();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRVisualInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualInfo_addr_posWorld(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualInfo_set_posWorld(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualInfo_addr_posLocal(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualInfo_set_posLocal(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualInfo_addr_velWorld(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualInfo_set_velWorld(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualInfo_addr_velLocal(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualInfo_set_velLocal(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern double Spr_CRVisualInfo_get_angle(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualInfo_set_angle(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualInfo_get_solid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualInfo_set_solid(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualInfo_get_solidSensor(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualInfo_set_solidSensor(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualInfo_addr_sensorPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualInfo_set_sensorPose(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern char Spr_CRVisualInfo_get_bMyBody(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualInfo_set_bMyBody(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_CRVisualInfo_get_bCenter(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualInfo_set_bCenter(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRVisualSensorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRVisualSensorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualSensorDesc_addr_range(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualSensorDesc_set_range(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualSensorDesc_addr_centerRange(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualSensorDesc_set_centerRange(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualSensorDesc_addr_pose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualSensorDesc_set_pose(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_CRVisualSensorDesc_get_limitDistance(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualSensorDesc_set_limitDistance(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRBodyIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRBodyIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBodyIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRBodyIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBodyIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBodyIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBodyIf_FindByIKActuator(IntPtr _this, IntPtr actuator);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBodyIf_FindByLabel(IntPtr _this, IntPtr label);
	[DllImport("SprExport")]
	public static extern int Spr_CRBodyIf_NBones(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBodyIf_GetBone(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBodyIf_GetCenterOfMass(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_CRBodyIf_GetSumOfMass(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRBodyIf_Step(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRBoneIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRBoneIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBoneIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRBoneIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBoneIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBoneIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBoneIf_GetLabel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRBoneIf_SetLabel(IntPtr _this, string str);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBoneIf_GetPHSolid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRBoneIf_SetPHSolid(IntPtr _this, IntPtr so);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBoneIf_GetIKEndEffector(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRBoneIf_SetIKEndEffector(IntPtr _this, IntPtr ikEE);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBoneIf_GetPHJoint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRBoneIf_SetPHJoint(IntPtr _this, IntPtr jo);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBoneIf_GetIKActuator(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRBoneIf_SetIKActuator(IntPtr _this, IntPtr ikAct);
	[DllImport("SprExport")]
	public static extern void Spr_CRBoneIf_SetParentBone(IntPtr _this, IntPtr parent);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBoneIf_GetParentBone(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_CRBoneIf_NChildBones(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRBoneIf_GetChildBone(IntPtr _this, int number);
	[DllImport("SprExport")]
	public static extern void Spr_CRBoneIf_AddChildBone(IntPtr _this, IntPtr child);
	[DllImport("SprExport")]
	public static extern void Spr_CRBoneIf_ReadInitialSpringDamperFromJoint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CREngineIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CREngineIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CREngineIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CREngineIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CREngineIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CREngineIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_CREngineIf_GetPriority(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CREngineIf_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CREngineIf_Step(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CREngineIf_Enable(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern char Spr_CREngineIf_IsEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRControllerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRControllerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRControllerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRControllerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRControllerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRControllerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_CRControllerIf_Reset(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_CRControllerIf_GetStatus(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRGazeControllerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRGazeControllerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRGazeControllerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRGazeControllerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRGazeControllerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRGazeControllerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_CRGazeControllerIf_SetTargetPosition(IntPtr _this, IntPtr pos);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRGazeControllerIf_GetTargetPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRGazeControllerIf_SetHeadBone(IntPtr _this, IntPtr head);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRGrabControllerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRGrabControllerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRGrabControllerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRGrabControllerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRGrabControllerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRGrabControllerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_CRGrabControllerIf_SetTargetSolid(IntPtr _this, IntPtr targetSolid);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRGrabControllerIf_GetGrabbingSolid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRGrabControllerIf_GetSolid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRGrabControllerIf_SetSolid(IntPtr _this, IntPtr so);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRCreatureIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRCreatureIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRCreatureIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRCreatureIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRCreatureIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRCreatureIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_CRCreatureIf_Step(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRCreatureIf_CreateBody(IntPtr _this, IntPtr ii, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRCreatureIf_GetBody(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern int Spr_CRCreatureIf_NBodies(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRCreatureIf_CreateEngine(IntPtr _this, IntPtr ii, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRCreatureIf_GetEngine(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern int Spr_CRCreatureIf_NEngines(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRCreatureIf_GetPHScene(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRReachControllerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRReachControllerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_SetIKEndEffector(IntPtr _this, IntPtr ikEff, int n);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_SetIKEndEffector_1(IntPtr _this, IntPtr ikEff);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerIf_GetIKEndEffector(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerIf_GetIKEndEffector_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_SetFinalPos(IntPtr _this, IntPtr pos);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_SetFinalVel(IntPtr _this, IntPtr vel);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_SetViaTime(IntPtr _this, float time);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_SetViaPos(IntPtr _this, IntPtr pos);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_EnableLookatMode(IntPtr _this, bool bEnable);
	[DllImport("SprExport")]
	public static extern char Spr_CRReachControllerIf_IsLookatMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_SetNumUseHands(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern int Spr_CRReachControllerIf_GetNumUseHands(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_SetBaseJoint(IntPtr _this, int n, IntPtr jo);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_SetAverageSpeed(IntPtr _this, double speed);
	[DllImport("SprExport")]
	public static extern double Spr_CRReachControllerIf_GetAverageSpeed(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_SetMargin(IntPtr _this, double margin);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_SetInnerMargin(IntPtr _this, double margin);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_SetWaitVel(IntPtr _this, double vel);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_SetRestartVel(IntPtr _this, double vel);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRReachControllerIf_GetTrajectory(IntPtr _this, float s);
	[DllImport("SprExport")]
	public static extern float Spr_CRReachControllerIf_GetReachTime(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_CRReachControllerIf_GetTime(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_Draw(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRReachControllerIf_SetOriControlCompleteTimeRatio(IntPtr _this, float oriTime);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRSdkIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRSdkIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRSdkIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRSdkIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRSdkIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRSdkIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRSdkIf_CreateSdk();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRSdkIf_GetSdk();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRSdkIf_CreateCreature(IntPtr _this, IntPtr ii, IntPtr desc);
	[DllImport("SprExport")]
	public static extern int Spr_CRSdkIf_NCreatures(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRSdkIf_GetCreature(IntPtr _this, int index);
	[DllImport("SprExport")]
	public static extern void Spr_CRSdkIf_Step(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRSdkIf_RegisterSdk();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRTouchSensorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRTouchSensorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRTouchSensorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRTouchSensorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRTouchSensorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRTouchSensorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_CRTouchSensorIf_NContacts(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRTouchSensorIf_GetContact(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern void Spr_CRTouchSensorIf_Update(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_CRVisualSensorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_CRVisualSensorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualSensorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualSensorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualSensorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualSensorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_CRVisualSensorIf_NVisibles(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualSensorIf_GetVisible(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualSensorIf_Update(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualSensorIf_SetRange(IntPtr _this, IntPtr range);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualSensorIf_SetCenterRange(IntPtr _this, IntPtr range);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualSensorIf_SetPose(IntPtr _this, IntPtr pose);
	[DllImport("SprExport")]
	public static extern void Spr_CRVisualSensorIf_SetSolid(IntPtr _this, IntPtr solid);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualSensorIf_GetRange(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualSensorIf_GetCenterRange(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualSensorIf_GetPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_CRVisualSensorIf_GetSolid(IntPtr _this);
    }
}
