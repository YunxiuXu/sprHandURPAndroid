using System;
using System.Runtime.InteropServices;
namespace SprCs {
    public partial class SprExport {
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HIHapticDummyDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HIHapticDummyDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIHapticDummyDesc_addr_pose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIHapticDummyDesc_set_pose(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVPortEnum();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVPortEnum(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DRUsb20SimpleDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DRUsb20SimpleDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_DRUsb20SimpleDesc_get_channel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_DRUsb20SimpleDesc_set_channel(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DRUsb20Sh4Desc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DRUsb20Sh4Desc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DRCyUsb20Sh4Desc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DRCyUsb20Sh4Desc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVJoyStickMask();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVJoyStickMask(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVJoyStickCallback();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVJoyStickCallback(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_DVJoyStickCallback_OnUpdate(IntPtr _this, int buttonMask, int x, int y, int z);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVButtonMask();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVButtonMask(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVButtonSt();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVButtonSt(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVKeySt();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVKeySt(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVKeyCode();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVKeyCode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVKeyMouseCallback();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVKeyMouseCallback(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_DVKeyMouseCallback_OnMouse(IntPtr _this, int button, int state, int x, int y);
	[DllImport("SprExport")]
	public static extern char Spr_DVKeyMouseCallback_OnDoubleClick(IntPtr _this, int button, int x, int y);
	[DllImport("SprExport")]
	public static extern char Spr_DVKeyMouseCallback_OnMouseMove(IntPtr _this, int button, int x, int y, int zdelta);
	[DllImport("SprExport")]
	public static extern char Spr_DVKeyMouseCallback_OnKey(IntPtr _this, int state, int key, int x, int y);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DRKeyMouseWin32Desc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DRKeyMouseWin32Desc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HILeapDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HILeapDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HILeapUDPDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HILeapUDPDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HINovintFalconDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HINovintFalconDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISdkDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISdkDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpaceNavigatorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISpaceNavigatorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpaceNavigatorDesc_get_hWnd(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpaceNavigatorDesc_set_hWnd(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern float Spr_HISpaceNavigatorDesc_get_maxVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpaceNavigatorDesc_set_maxVelocity(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_HISpaceNavigatorDesc_get_maxAngularVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpaceNavigatorDesc_set_maxAngularVelocity(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidarMotorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISpidarMotorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_HISpidarMotorDesc_get_ch(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorDesc_set_ch(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern float Spr_HISpidarMotorDesc_get_maxForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorDesc_set_maxForce(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_HISpidarMotorDesc_get_minForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorDesc_set_minForce(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_HISpidarMotorDesc_get_voltPerNewton(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorDesc_set_voltPerNewton(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_HISpidarMotorDesc_get_currentPerVolt(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorDesc_set_currentPerVolt(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_HISpidarMotorDesc_get_lengthPerPulse(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorDesc_set_lengthPerPulse(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarMotorDesc_addr_pos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorDesc_set_pos(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarMotorDesc_addr_jointPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorDesc_set_jointPos(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidarDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISpidarDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarDesc_get_type(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarDesc_set_type(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarDesc_FreeString_type(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarDesc_vector_get_motors(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarDesc_vector_set_motors(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern int Spr_HISpidarDesc_get_nButton(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarDesc_set_nButton(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidar4Desc();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidar4Desc_2(string type);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidar4Desc_3(string type, IntPtr portNum);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidar4Desc_4(int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp, float minF, float maxF);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidar4Desc_5(int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp, float minF);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidar4Desc_6(int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp);
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISpidar4Desc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidar4Desc_Init(IntPtr _this, int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp, float minF, float maxF);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidar4Desc_Init_1(IntPtr _this, int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp, float minF);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidar4Desc_Init_2(IntPtr _this, int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidar4Desc_Init_3(IntPtr _this, string type);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidar4Desc_InitSpidarG(IntPtr _this, string type);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidar4Desc_InitSpidarBig(IntPtr _this, string type);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidar4DDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISpidar4DDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidarGDesc();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidarGDesc_2(string type);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidarGDesc_3(int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp, float minF, float maxF);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidarGDesc_4(int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp, float minF);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidarGDesc_5(int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp);
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISpidarGDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarGDesc_Init(IntPtr _this, int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp, float minF, float maxF);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarGDesc_Init_1(IntPtr _this, int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp, float minF);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarGDesc_Init_2(IntPtr _this, int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarGDesc_Init_3(IntPtr _this, string type);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HITrackballDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HITrackballDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HITrackballDesc_get_trackball(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_set_trackball(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HITrackballDesc_addr_target(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_set_target(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_HITrackballDesc_get_longitude(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_set_longitude(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_HITrackballDesc_get_latitude(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_set_latitude(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HITrackballDesc_addr_lonRange(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_set_lonRange(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HITrackballDesc_addr_latRange(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_set_latRange(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_HITrackballDesc_get_distance(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_set_distance(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HITrackballDesc_addr_distRange(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_set_distRange(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_HITrackballDesc_get_rotGain(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_set_rotGain(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_HITrackballDesc_get_zoomGain(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_set_zoomGain(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_HITrackballDesc_get_trnGain(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_set_trnGain(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern int Spr_HITrackballDesc_get_rotMask(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_set_rotMask(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_HITrackballDesc_get_zoomMask(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_set_zoomMask(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_HITrackballDesc_get_trnMask(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballDesc_set_trnMask(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HITrackballCallback();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HITrackballCallback(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballCallback_OnUpdatePose(IntPtr _this, IntPtr trackball);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HIXbox360ControllerDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HIXbox360ControllerDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_HIXbox360ControllerDesc_get_maxVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIXbox360ControllerDesc_set_maxVelocity(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_HIXbox360ControllerDesc_get_maxAngularVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIXbox360ControllerDesc_set_maxAngularVelocity(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HIBaseIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HIBaseIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIBaseIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIBaseIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIBaseIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIBaseIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_HIBaseIf_BeforeCalibration(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIBaseIf_Calibration(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIBaseIf_AfterCalibration(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIBaseIf_AddDeviceDependency(IntPtr _this, IntPtr rd);
	[DllImport("SprExport")]
	public static extern void Spr_HIBaseIf_ClearDeviceDependency(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIBaseIf_Update(IntPtr _this, float dt);
	[DllImport("SprExport")]
	public static extern char Spr_HIBaseIf_IsGood(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIBaseIf_Init(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HIPoseIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HIPoseIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIPoseIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIPoseIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIPoseIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIPoseIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIPoseIf_GetPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIPoseIf_GetOrientation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIPoseIf_GetPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIPoseIf_GetAffine(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIPoseIf_GetVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIPoseIf_GetAngularVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HIHapticIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HIHapticIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIHapticIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIHapticIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIHapticIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIHapticIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIHapticIf_GetTorque(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIHapticIf_GetForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIHapticIf_SetForce(IntPtr _this, IntPtr f, IntPtr t);
	[DllImport("SprExport")]
	public static extern void Spr_HIHapticIf_SetForce_1(IntPtr _this, IntPtr f);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HIHapticDummyIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HIHapticDummyIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIHapticDummyIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIHapticDummyIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIHapticDummyIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIHapticDummyIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_HIHapticDummyIf_SetPose(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern void Spr_HIHapticDummyIf_SetVelocity(IntPtr _this, IntPtr v);
	[DllImport("SprExport")]
	public static extern void Spr_HIHapticDummyIf_SetAngularVelocity(IntPtr _this, IntPtr v);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HIDeviceIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HIDeviceIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIDeviceIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIDeviceIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIDeviceIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIDeviceIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HIRealDeviceIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HIRealDeviceIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIRealDeviceIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIRealDeviceIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIRealDeviceIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIRealDeviceIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_HIRealDeviceIf_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIRealDeviceIf_Return(IntPtr _this, IntPtr dv);
	[DllImport("SprExport")]
	public static extern void Spr_HIRealDeviceIf_Update(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HIVirtualDeviceIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HIVirtualDeviceIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIVirtualDeviceIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIVirtualDeviceIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIVirtualDeviceIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIVirtualDeviceIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_HIVirtualDeviceIf_GetPortNo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIVirtualDeviceIf_IsUsed(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIVirtualDeviceIf_GetRealDevice(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIVirtualDeviceIf_Update(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVAdIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVAdIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVAdIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_DVAdIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVAdIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVAdIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_DVAdIf_Digit(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_DVAdIf_Voltage(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVDaIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVDaIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVDaIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_DVDaIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVDaIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVDaIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_DVDaIf_Digit(IntPtr _this, int d);
	[DllImport("SprExport")]
	public static extern void Spr_DVDaIf_Voltage(IntPtr _this, float volt);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVCounterIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVCounterIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVCounterIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_DVCounterIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVCounterIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVCounterIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_DVCounterIf_Count(IntPtr _this, long count);
	[DllImport("SprExport")]
	public static extern long Spr_DVCounterIf_Count_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVPioIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVPioIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVPioIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_DVPioIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVPioIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVPioIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_DVPioIf_Get(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_DVPioIf_Set(IntPtr _this, int l);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVForceIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVForceIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVForceIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_DVForceIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVForceIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVForceIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_DVForceIf_GetDOF(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_DVForceIf_GetForce(IntPtr _this, int ch);
	[DllImport("SprExport")]
	public static extern void Spr_DVForceIf_GetForce3(IntPtr _this, IntPtr f);
	[DllImport("SprExport")]
	public static extern void Spr_DVForceIf_GetForce6(IntPtr _this, IntPtr f, IntPtr t);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DRUsb20SimpleIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DRUsb20SimpleIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DRUsb20SimpleIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_DRUsb20SimpleIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DRUsb20SimpleIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DRUsb20SimpleIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DRUsb20Sh4If();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DRUsb20Sh4If(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DRUsb20Sh4If_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_DRUsb20Sh4If_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DRUsb20Sh4If_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DRUsb20Sh4If_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DRCyUsb20Sh4If();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DRCyUsb20Sh4If(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DRCyUsb20Sh4If_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_DRCyUsb20Sh4If_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DRCyUsb20Sh4If_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DRCyUsb20Sh4If_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVJoyStickIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVJoyStickIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVJoyStickIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_DVJoyStickIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVJoyStickIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVJoyStickIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_DVJoyStickIf_AddCallback(IntPtr _this, IntPtr cb);
	[DllImport("SprExport")]
	public static extern void Spr_DVJoyStickIf_RemoveCallback(IntPtr _this, IntPtr cb);
	[DllImport("SprExport")]
	public static extern void Spr_DVJoyStickIf_SetPollInterval(IntPtr _this, int ms);
	[DllImport("SprExport")]
	public static extern int Spr_DVJoyStickIf_GetPollInterval(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DVKeyMouseIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DVKeyMouseIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVKeyMouseIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_DVKeyMouseIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVKeyMouseIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DVKeyMouseIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_DVKeyMouseIf_AddCallback(IntPtr _this, IntPtr cb);
	[DllImport("SprExport")]
	public static extern void Spr_DVKeyMouseIf_RemoveCallback(IntPtr _this, IntPtr cb);
	[DllImport("SprExport")]
	public static extern int Spr_DVKeyMouseIf_GetKeyState(IntPtr _this, int key);
	[DllImport("SprExport")]
	public static extern void Spr_DVKeyMouseIf_GetMousePosition(IntPtr _this, int x, int y, int time, int count);
	[DllImport("SprExport")]
	public static extern void Spr_DVKeyMouseIf_GetMousePosition_1(IntPtr _this, int x, int y, int time);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_DRKeyMouseWin32If();
	[DllImport("SprExport")]
	public static extern void Spr_delete_DRKeyMouseWin32If(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DRKeyMouseWin32If_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_DRKeyMouseWin32If_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DRKeyMouseWin32If_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_DRKeyMouseWin32If_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_DRKeyMouseWin32If_PreviewMessage(IntPtr _this, IntPtr m);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HIBoneIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HIBoneIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIBoneIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIBoneIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIBoneIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIBoneIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIBoneIf_GetParent(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIBoneIf_GetPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIBoneIf_GetDirection(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_HIBoneIf_GetLength(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISkeletonIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISkeletonIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISkeletonIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISkeletonIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISkeletonIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISkeletonIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISkeletonIf_GetPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_HISkeletonIf_NBones(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISkeletonIf_GetBone(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISkeletonIf_GetRoot(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_HISkeletonIf_GetGrabStrength(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HISkeletonIf_IsTracked(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISkeletonSensorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISkeletonSensorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISkeletonSensorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISkeletonSensorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISkeletonSensorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISkeletonSensorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_HISkeletonSensorIf_NSkeletons(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISkeletonSensorIf_GetSkeleton(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern void Spr_HISkeletonSensorIf_SetScale(IntPtr _this, double s);
	[DllImport("SprExport")]
	public static extern void Spr_HISkeletonSensorIf_SetCenter(IntPtr _this, IntPtr c);
	[DllImport("SprExport")]
	public static extern void Spr_HISkeletonSensorIf_SetRotation(IntPtr _this, IntPtr q);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HILeapIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HILeapIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HILeapIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HILeapIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HILeapIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HILeapIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HILeapUDPIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HILeapUDPIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HILeapUDPIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HILeapUDPIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HILeapUDPIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HILeapUDPIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_HILeapUDPIf_calibrate(IntPtr _this, int formerLeapID);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HINovintFalconIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HINovintFalconIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HINovintFalconIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HINovintFalconIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HINovintFalconIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HINovintFalconIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISdkIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISdkIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISdkIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISdkIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISdkIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISdkIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_HISdkIf_ReturnVirtualDevice(IntPtr _this, IntPtr dev);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISdkIf_AddRealDevice(IntPtr _this, IntPtr keyInfo, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISdkIf_AddRealDevice_1(IntPtr _this, IntPtr keyInfo);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISdkIf_CreateHumanInterface(IntPtr _this, IntPtr info);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISdkIf_CreateHumanInterface_1(IntPtr _this, string name);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISdkIf_CreateSdk();
	[DllImport("SprExport")]
	public static extern void Spr_HISdkIf_RegisterSdk();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpaceNavigatorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISpaceNavigatorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpaceNavigatorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpaceNavigatorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpaceNavigatorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpaceNavigatorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_HISpaceNavigatorIf_SetPose(IntPtr _this, IntPtr pose);
	[DllImport("SprExport")]
	public static extern void Spr_HISpaceNavigatorIf_SetMaxVelocity(IntPtr _this, float mV);
	[DllImport("SprExport")]
	public static extern void Spr_HISpaceNavigatorIf_SetMaxAngularVelocity(IntPtr _this, float mAV);
	[DllImport("SprExport")]
	public static extern char Spr_HISpaceNavigatorIf_PreviewMessage(IntPtr _this, IntPtr m);
	[DllImport("SprExport")]
	public static extern void Spr_HISpaceNavigatorIf_SetViewMatrix(IntPtr _this, IntPtr view);
	[DllImport("SprExport")]
	public static extern void Spr_HISpaceNavigatorIf_SetPersMatrix(IntPtr _this, IntPtr pers);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidarMotorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISpidarMotorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarMotorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarMotorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarMotorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorIf_SetForce(IntPtr _this, float f);
	[DllImport("SprExport")]
	public static extern float Spr_HISpidarMotorIf_GetForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorIf_SetLimitMinForce(IntPtr _this, float f);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorIf_SetLimitMaxForce(IntPtr _this, float f);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarMotorIf_GetLimitForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_HISpidarMotorIf_GetCurrent(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorIf_SetLength(IntPtr _this, float l);
	[DllImport("SprExport")]
	public static extern float Spr_HISpidarMotorIf_GetLength(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_HISpidarMotorIf_GetVelocity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorIf_GetCalibrationData(IntPtr _this, float dt);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorIf_Calibrate(IntPtr _this, bool bUpdate);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarMotorIf_GetVdd(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_HISpidarMotorIf_GetCount(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidarIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISpidarIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarIf_GetSpidarType(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarIf_SetLimitMinForce(IntPtr _this, float f);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarIf_SetLimitMaxForce(IntPtr _this, float f);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarIf_GetMotor(IntPtr _this, ulong i);
	[DllImport("SprExport")]
	public static extern ulong Spr_HISpidarIf_NMotor(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidar4If();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISpidar4If(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidar4If_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidar4If_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidar4If_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidar4If_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidar4If_GetMotor(IntPtr _this, ulong i);
	[DllImport("SprExport")]
	public static extern ulong Spr_HISpidar4If_NMotor(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidar4DIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISpidar4DIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidar4DIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidar4DIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidar4DIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidar4DIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HISpidarGIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HISpidarGIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarGIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarGIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarGIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarGIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarGIf_GetTorque(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarGIf_GetForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarGIf_SetForce(IntPtr _this, IntPtr f, IntPtr t);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HISpidarGIf_GetMotor(IntPtr _this, ulong i);
	[DllImport("SprExport")]
	public static extern ulong Spr_HISpidarGIf_NMotor(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_HISpidarGIf_GetButton(IntPtr _this, ulong i);
	[DllImport("SprExport")]
	public static extern ulong Spr_HISpidarGIf_NButton(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarGIf_SetWeight(IntPtr _this, float s, float t, float r);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarGIf_SetWeight_1(IntPtr _this, float s, float t);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarGIf_SetWeight_2(IntPtr _this, float s);
	[DllImport("SprExport")]
	public static extern void Spr_HISpidarGIf_SetWeight_3(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HITrackballIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HITrackballIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HITrackballIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HITrackballIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HITrackballIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetMode(IntPtr _this, bool mode);
	[DllImport("SprExport")]
	public static extern char Spr_HITrackballIf_GetMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetTarget(IntPtr _this, IntPtr t);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HITrackballIf_GetTarget(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetAngle(IntPtr _this, float lon, float lat);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_GetAngle(IntPtr _this, float lon, float lat);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetDistance(IntPtr _this, float dist);
	[DllImport("SprExport")]
	public static extern float Spr_HITrackballIf_GetDistance(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetLongitudeRange(IntPtr _this, float rmin, float rmax);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_GetLongitudeRange(IntPtr _this, float rmin, float rmax);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetLatitudeRange(IntPtr _this, float rmin, float rmax);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_GetLatitudeRange(IntPtr _this, float rmin, float rmax);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetDistanceRange(IntPtr _this, float rmin, float rmax);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_GetDistanceRange(IntPtr _this, float rmin, float rmax);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetRotGain(IntPtr _this, float g);
	[DllImport("SprExport")]
	public static extern float Spr_HITrackballIf_GetRotGain(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetZoomGain(IntPtr _this, float g);
	[DllImport("SprExport")]
	public static extern float Spr_HITrackballIf_GetZoomGain(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetTrnGain(IntPtr _this, float g);
	[DllImport("SprExport")]
	public static extern float Spr_HITrackballIf_GetTrnGain(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_Fit(IntPtr _this, IntPtr cam, float radius);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetPosition(IntPtr _this, IntPtr pos);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetOrientation(IntPtr _this, IntPtr ori);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_Enable(IntPtr _this, bool on);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_Enable_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetRotMask(IntPtr _this, int mask);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetZoomMask(IntPtr _this, int mask);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetTrnMask(IntPtr _this, int mask);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HITrackballIf_GetKeyMouse(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetKeyMouse(IntPtr _this, IntPtr dv);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_SetCallback(IntPtr _this, IntPtr callback);
	[DllImport("SprExport")]
	public static extern void Spr_HITrackballIf_UpdateView(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_HIXbox360ControllerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_HIXbox360ControllerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIXbox360ControllerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIXbox360ControllerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIXbox360ControllerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_HIXbox360ControllerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_HIXbox360ControllerIf_SetMaxVelocity(IntPtr _this, float v);
	[DllImport("SprExport")]
	public static extern void Spr_HIXbox360ControllerIf_SetMaxAngularVelocity(IntPtr _this, float v);
	[DllImport("SprExport")]
	public static extern void Spr_HIXbox360ControllerIf_SetVibration(IntPtr _this, IntPtr lr);
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_UP(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_DOWN(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_LEFT(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_RIGHT(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_START(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_BACK(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_LTHUMB(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_RTHUMB(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_LSHOULDER(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_RSHOULDER(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_A(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_B(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_X(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_HIXbox360ControllerIf_Y(IntPtr _this);
    }
}
