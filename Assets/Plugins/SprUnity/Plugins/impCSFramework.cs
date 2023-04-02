using System;
using System.Runtime.InteropServices;
namespace SprCs {
    public partial class SprExport {
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWAppBase();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWAppBase(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWAppBase_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWAppBase_UserFunc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWAppBase_TimerFunc(IntPtr _this, int id);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWAppBase_GetSdk(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWAppBase_CreateSdk(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWAppBase_GetTimer(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern int Spr_FWAppBase_NTimers(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWApp();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWApp(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_Init_1(IntPtr _this, int argc);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_InitInNewThread(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_EndThread(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_Display(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_DisableIdleFunc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_EnableIdleFunc(IntPtr _this, bool on);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_EnableIdleFunc_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_StartMainLoop(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_EndMainLoop(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_IdleFunc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_TimerFunc(IntPtr _this, int id);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_Reshape(IntPtr _this, int w, int h);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_Keyboard(IntPtr _this, int key, int x, int y);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_MouseButton(IntPtr _this, int button, int state, int x, int y);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_MouseMove(IntPtr _this, int x, int y);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_Joystick(IntPtr _this, uint buttonMask, int x, int y, int z);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_AtExit(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_FWApp_OnMouse(IntPtr _this, int button, int state, int x, int y);
	[DllImport("SprExport")]
	public static extern char Spr_FWApp_OnMouseMove(IntPtr _this, int button, int x, int y, int zdelta);
	[DllImport("SprExport")]
	public static extern char Spr_FWApp_OnDoubleClick(IntPtr _this, int button, int x, int y);
	[DllImport("SprExport")]
	public static extern char Spr_FWApp_OnKey(IntPtr _this, int state, int key, int x, int y);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_OnControlUpdate(IntPtr _this, IntPtr ctrl);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWApp_GetApp();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWApp_CreateWin(IntPtr _this, IntPtr desc, IntPtr parent);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWApp_CreateWin_1(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWApp_CreateWin_2(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_FWApp_NWin(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWApp_GetWinFromId(IntPtr _this, int wid);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWApp_GetWin(IntPtr _this, int index);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWApp_GetCurrentWin(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_DestroyWin(IntPtr _this, IntPtr win);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_SetCurrentWin(IntPtr _this, IntPtr win);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_PostRedisplay(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_FWApp_GetModifier(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_SetGRHandler(IntPtr _this, int type);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWApp_GRInit(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWApp_GRInit_1(IntPtr _this, int argc, IntPtr argv);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWApp_GRInit_2(IntPtr _this, int argc);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_GetDisplayLock(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_ReleaseDisplayLock(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_InitWindow(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_Clear(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWApp_Reset(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWHapticApp();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWHapticApp(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWHapticApp_TimerFunc(IntPtr _this, int id);
	[DllImport("SprExport")]
	public static extern void Spr_FWHapticApp_CreateTimers(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWHapticApp_StartTimers(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWHapticApp_SetPHScene(IntPtr _this, IntPtr phScene);
	[DllImport("SprExport")]
	public static extern int Spr_FWHapticApp_GetCount(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWEditor();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWEditor(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWEditor_SetObject(IntPtr _this, IntPtr obj, bool clearHist);
	[DllImport("SprExport")]
	public static extern void Spr_FWEditor_SetObject_1(IntPtr _this, IntPtr obj);
	[DllImport("SprExport")]
	public static extern void Spr_FWEditor_Update(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWValidator();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWValidator(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWEditorOverlay();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWEditorOverlay(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_FWEditorOverlay_Key(IntPtr _this, int key);
	[DllImport("SprExport")]
	public static extern void Spr_FWEditorOverlay_Draw(IntPtr _this, IntPtr render);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWObjectDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWObjectDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_FWObjectDesc_get_bAbsolute(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectDesc_set_bAbsolute(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern int Spr_FWObjectDesc_get_syncSource(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectDesc_set_syncSource(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWOpObjDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWOpObjDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern float Spr_FWOpObjDesc_get_fwPSize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOpObjDesc_set_fwPSize(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWFemMeshDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWFemMeshDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern uint Spr_FWFemMeshDesc_get_kogePics(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshDesc_set_kogePics(IntPtr _this, uint value);
	[DllImport("SprExport")]
	public static extern uint Spr_FWFemMeshDesc_get_thermoPics(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshDesc_set_thermoPics(IntPtr _this, uint value);
	[DllImport("SprExport")]
	public static extern uint Spr_FWFemMeshDesc_get_waterPics(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshDesc_set_waterPics(IntPtr _this, uint value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWFemMeshDesc_get_meshRoughness(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshDesc_set_meshRoughness(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshDesc_FreeString_meshRoughness(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshDesc_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWFemMeshNewDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWFemMeshNewDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern uint Spr_FWFemMeshNewDesc_get_kogetex(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshNewDesc_set_kogetex(IntPtr _this, uint value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWFemMeshNewDesc_get_meshRoughness(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshNewDesc_set_meshRoughness(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshNewDesc_FreeString_meshRoughness(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern char Spr_FWFemMeshNewDesc_get_spheric(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshNewDesc_set_spheric(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern uint Spr_FWFemMeshNewDesc_get_texture_mode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshNewDesc_set_texture_mode(IntPtr _this, uint value);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshNewDesc_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWSceneDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWSceneDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWSdkDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWSdkDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWSkeletonSensorDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWSkeletonSensorDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_FWSkeletonSensorDesc_get_bCreatePHSkeleton(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSkeletonSensorDesc_set_bCreatePHSkeleton(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_FWSkeletonSensorDesc_get_bCreatePHSolid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSkeletonSensorDesc_set_bCreatePHSolid(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_FWSkeletonSensorDesc_get_bCreateCDShape(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSkeletonSensorDesc_set_bCreateCDShape(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_FWSkeletonSensorDesc_get_bCreatePHJoint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSkeletonSensorDesc_set_bCreatePHJoint(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_FWSkeletonSensorDesc_get_bCreatePHSpring(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSkeletonSensorDesc_set_bCreatePHSpring(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSkeletonSensorDesc_addr_radius(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSkeletonSensorDesc_set_radius(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWWinBaseDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWWinBaseDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_FWWinBaseDesc_get_width(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinBaseDesc_set_width(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_FWWinBaseDesc_get_height(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinBaseDesc_set_height(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_FWWinBaseDesc_get_left(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinBaseDesc_set_left(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_FWWinBaseDesc_get_top(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinBaseDesc_set_top(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinBaseDesc_get_title(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinBaseDesc_set_title(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinBaseDesc_FreeString_title(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWControlDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWControlDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWControlDesc_get_label(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWControlDesc_set_label(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_FWControlDesc_FreeString_label(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern int Spr_FWControlDesc_get_align(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWControlDesc_set_align(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_FWControlDesc_get_style(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWControlDesc_set_style(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWPanelDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWPanelDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_FWPanelDesc_get_open(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWPanelDesc_set_open(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWButtonDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWButtonDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_FWButtonDesc_get_style(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWButtonDesc_set_style(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern char Spr_FWButtonDesc_get_checked(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWButtonDesc_set_checked(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWStaticTextDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWStaticTextDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWTextBoxDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWTextBoxDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWTextBoxDesc_get_text(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWTextBoxDesc_set_text(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_FWTextBoxDesc_FreeString_text(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern int Spr_FWTextBoxDesc_get_intMin(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWTextBoxDesc_set_intMin(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern int Spr_FWTextBoxDesc_get_intMax(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWTextBoxDesc_set_intMax(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern float Spr_FWTextBoxDesc_get_floatMin(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWTextBoxDesc_set_floatMin(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern float Spr_FWTextBoxDesc_get_floatMax(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWTextBoxDesc_set_floatMax(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern char Spr_FWTextBoxDesc_get_spinner(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWTextBoxDesc_set_spinner(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWListBoxDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWListBoxDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWRotationControlDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWRotationControlDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWRotationControlDesc_addr_rot(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWRotationControlDesc_set_rot(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_FWRotationControlDesc_get_damping(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWRotationControlDesc_set_damping(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWTranslationControlDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWTranslationControlDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWTranslationControlDesc_addr_pos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWTranslationControlDesc_set_pos(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern float Spr_FWTranslationControlDesc_get_speed(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWTranslationControlDesc_set_speed(IntPtr _this, float value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWDialogDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWDialogDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_FWDialogDesc_get_dock(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWDialogDesc_set_dock(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern int Spr_FWDialogDesc_get_dockPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWDialogDesc_set_dockPos(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWWinDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWWinDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_FWWinDesc_get_debugMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinDesc_set_debugMode(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_FWWinDesc_get_fullscreen(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinDesc_set_fullscreen(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_FWWinDesc_get_useKeyMouse(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinDesc_set_useKeyMouse(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern char Spr_FWWinDesc_get_useJoyStick(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinDesc_set_useJoyStick(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern int Spr_FWWinDesc_get_joyStickPollInterval(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinDesc_set_joyStickPollInterval(IntPtr _this, int value);
	[DllImport("SprExport")]
	public static extern char Spr_FWWinDesc_get_useTrackball(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinDesc_set_useTrackball(IntPtr _this, char value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWGroundConstraint();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWGroundConstraint_10(double w, IntPtr n);
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWGroundConstraint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWGroundConstraint_addr_cNormal(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWGroundConstraint_set_cNormal(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWGroundConstraint_get_cSolid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWGroundConstraint_set_cSolid(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWGroundConstraint_addr_initialPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWGroundConstraint_set_initialPose(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern double Spr_FWGroundConstraint_get_cWeight(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWGroundConstraint_set_cWeight(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWGroundConstraint_addr_contactForce(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWGroundConstraint_set_contactForce(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWGroundConstraint_addr_contactPoint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWGroundConstraint_set_contactPoint(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern double Spr_FWGroundConstraint_CalcEvalFunc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWGroundConstraint_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWUngroundedConstraint();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWUngroundedConstraint_9(double w, IntPtr a, IntPtr n);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWUngroundedConstraint_10(double w, IntPtr a);
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWUngroundedConstraint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWUngroundedConstraint_addr_cAxis(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWUngroundedConstraint_set_cAxis(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWUngroundedConstraint_addr_normal(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWUngroundedConstraint_set_normal(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWUngroundedConstraint_get_cSolid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWUngroundedConstraint_set_cSolid(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWUngroundedConstraint_addr_initialPose(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWUngroundedConstraint_set_initialPose(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern double Spr_FWUngroundedConstraint_get_cWeight(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWUngroundedConstraint_set_cWeight(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_FWUngroundedConstraint_CalcEvalFunc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWUngroundedConstraint_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_JointPos();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_JointPos_4(IntPtr q);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_JointPos_5(double a);
	[DllImport("SprExport")]
	public static extern void Spr_delete_JointPos(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_JointPos_addr_ori(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_JointPos_set_ori(IntPtr _this, IntPtr _ptr);
	[DllImport("SprExport")]
	public static extern double Spr_JointPos_get_angle(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_JointPos_set_angle(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWObjectiveValues();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWObjectiveValues(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_FWObjectiveValues_get_errorvalue(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectiveValues_set_errorvalue(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_FWObjectiveValues_get_torquevalue(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectiveValues_set_torquevalue(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_FWObjectiveValues_get_stabilityvalue(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectiveValues_set_stabilityvalue(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_FWObjectiveValues_get_groundvalue(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectiveValues_set_groundvalue(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_FWObjectiveValues_get_ungroundedvalue(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectiveValues_set_ungroundedvalue(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_FWObjectiveValues_get_centervalue(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectiveValues_set_centervalue(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_FWObjectiveValues_get_initialorivalue(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectiveValues_set_initialorivalue(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWOptimizerDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWOptimizerDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_FWOptimizerDesc_get_ixstart(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOptimizerDesc_set_ixstart(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_FWOptimizerDesc_get_istddev(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOptimizerDesc_set_istddev(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_FWOptimizerDesc_get_iTolFun(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOptimizerDesc_set_iTolFun(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_FWOptimizerDesc_get_ilambda(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOptimizerDesc_set_ilambda(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern double Spr_FWOptimizerDesc_get_iMaxIter(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOptimizerDesc_set_iMaxIter(IntPtr _this, double value);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWStaticTorqueOptimizerDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWStaticTorqueOptimizerDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWObjectIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWObjectIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWObjectIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWObjectIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWObjectIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWObjectIf_GetPHSolid(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectIf_SetPHSolid(IntPtr _this, IntPtr s);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWObjectIf_GetGRFrame(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectIf_SetGRFrame(IntPtr _this, IntPtr f);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWObjectIf_GetPHJoint(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectIf_SetPHJoint(IntPtr _this, IntPtr j);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWObjectIf_GetChildFrame(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectIf_SetChildFrame(IntPtr _this, IntPtr f);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectIf_SetSyncSource(IntPtr _this, int syncSrc);
	[DllImport("SprExport")]
	public static extern int Spr_FWObjectIf_GetSyncSource(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectIf_EnableAbsolute(IntPtr _this, bool bAbs);
	[DllImport("SprExport")]
	public static extern char Spr_FWObjectIf_IsAbsolute(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectIf_GenerateCDMesh(IntPtr _this, IntPtr frame, IntPtr mat);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectIf_GenerateCDMesh_1(IntPtr _this, IntPtr frame);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectIf_GenerateCDMesh_2(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWObjectIf_Sync(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWOpObjIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWOpObjIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOpObjIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOpObjIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOpObjIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOpObjIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_FWOpObjIf_Blend(IntPtr _this);
	[DllImport("SprExport")]
	public static extern ulong Spr_FWOpObjIf_NChildObject(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOpObjIf_GetChildObject(IntPtr _this, ulong pos);
	[DllImport("SprExport")]
	public static extern char Spr_FWOpObjIf_AddChildObject(IntPtr _this, IntPtr o);
	[DllImport("SprExport")]
	public static extern void Spr_FWOpObjIf_CreateOpObjWithRadius(IntPtr _this, float r);
	[DllImport("SprExport")]
	public static extern void Spr_FWOpObjIf_CreateOpObj(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOpObjIf_GetOpObj(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOpObjIf_GetGRMesh(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWFemMeshIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWFemMeshIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWFemMeshIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWFemMeshIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWFemMeshIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWFemMeshIf_GetPHMesh(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshIf_DrawIHBorderXZPlane(IntPtr _this, bool sw);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshIf_DrawFaceEdge(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshIf_SetTexmode(IntPtr _this, uint mode);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWFemMeshNewIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWFemMeshNewIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWFemMeshNewIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshNewIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWFemMeshNewIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWFemMeshNewIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWFemMeshNewIf_GetPHFemMesh(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshNewIf_SetTexmode(IntPtr _this, uint mode);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshNewIf_EnableDrawEdgeCW(IntPtr _this, bool flag);
	[DllImport("SprExport")]
	public static extern void Spr_FWFemMeshNewIf_Settexmode1Map(IntPtr _this, float temp);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWHapticPointerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWHapticPointerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWHapticPointerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWHapticPointerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWHapticPointerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWHapticPointerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_FWHapticPointerIf_SetPHHapticPointer(IntPtr _this, IntPtr hpGlobal);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWHapticPointerIf_GetPHHapticPointer(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWHapticPointerIf_SetHumanInterface(IntPtr _this, IntPtr hi);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWHapticPointerIf_GetHumanInterface(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWSceneIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWSceneIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_GetSdk(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_GetPHScene(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetPHScene(IntPtr _this, IntPtr s);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_GetGRScene(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetGRScene(IntPtr _this, IntPtr s);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_CreateFWObject(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_FWSceneIf_NObject(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_GetObject(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_GetObjects(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_Sync(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_Step(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_Draw(IntPtr _this, IntPtr grRender, bool debug);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_Draw_1(IntPtr _this, IntPtr grRender);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_DrawPHScene(IntPtr _this, IntPtr render);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_DrawSolid(IntPtr _this, IntPtr render, IntPtr solid, bool solid_or_wire);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_DrawShape(IntPtr _this, IntPtr render, IntPtr shape, bool solid);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_DrawConstraint(IntPtr _this, IntPtr render, IntPtr con);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_DrawContact(IntPtr _this, IntPtr render, IntPtr con);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_DrawIK(IntPtr _this, IntPtr render, IntPtr ikEngine);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_DrawLimit(IntPtr _this, IntPtr render, IntPtr con);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_DrawHaptic(IntPtr _this, IntPtr render, IntPtr hapticEngine);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetRenderMode(IntPtr _this, bool solid, bool wire);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetRenderMode_1(IntPtr _this, bool solid);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetRenderMode_2(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRender(IntPtr _this, IntPtr obj, bool enable);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRender_1(IntPtr _this, IntPtr obj);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetSolidMaterial(IntPtr _this, int mat, IntPtr solid);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetSolidMaterial_1(IntPtr _this, int mat);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetSolidMaterial_2(IntPtr _this, int mat, float alha, IntPtr solid);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetSolidMaterial_3(IntPtr _this, int mat, float alha);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetWireMaterial(IntPtr _this, int mat, IntPtr solid);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetWireMaterial_1(IntPtr _this, int mat);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetWireMaterial_2(IntPtr _this, int mat, float alha, IntPtr solid);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetWireMaterial_3(IntPtr _this, int mat, float alha);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderAxis(IntPtr _this, bool world, bool solid, bool con);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderAxis_1(IntPtr _this, bool world, bool solid);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderAxis_2(IntPtr _this, bool world);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderAxis_3(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetAxisMaterial(IntPtr _this, int matX, int matY, int matZ);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetAxisScale(IntPtr _this, float scaleWorld, float scaleSolid, float scaleCon);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetAxisStyle(IntPtr _this, int style);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderForce(IntPtr _this, bool solid, bool constraint);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderForce_1(IntPtr _this, bool solid);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderForce_2(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetForceMaterial(IntPtr _this, int matForce, int matMoment);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetForceScale(IntPtr _this, float scaleForce, float scaleMoment);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderPHScene(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderPHScene_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderGRScene(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderGRScene_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderContact(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderContact_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetContactMaterial(IntPtr _this, int mat);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderBBox(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderBBox_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetLocalBBoxMaterial(IntPtr _this, int mat);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetWorldBBoxMaterial(IntPtr _this, int mat);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderGrid(IntPtr _this, bool x, bool y, bool z);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderGrid_1(IntPtr _this, bool x, bool y);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderGrid_2(IntPtr _this, bool x);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderGrid_3(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetGridOption(IntPtr _this, sbyte axis, float offset, float size, int slice);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetGridMaterial(IntPtr _this, int matX, int matY, int matZ);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderIK(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderIK_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetIKMaterial(IntPtr _this, int mat);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_SetIKScale(IntPtr _this, float scale);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderLimit(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderLimit_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderHaptic(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderHaptic_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderFem(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderFem_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderSkeletonSensor(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderSkeletonSensor_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderOp(IntPtr _this, bool enable);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_EnableRenderOp_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_CreateHapticPointer(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_UpdateHapticPointers(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_CreateSkeletonSensor(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_CreateSkeletonSensor_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_UpdateSkeletonSensors(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_FWSceneIf_NHapticPointers(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_GetHapticPointer(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_CreateOpHapticHandler(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSceneIf_GetOpHapticHandler(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSceneIf_UpdateOpHapticHandler(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWSdkIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWSdkIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSdkIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSdkIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSdkIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSdkIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSdkIf_CreateSdk();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSdkIf_CreateScene(IntPtr _this, IntPtr phdesc, IntPtr grdesc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSdkIf_CreateScene_1(IntPtr _this, IntPtr phdesc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSdkIf_CreateScene_2(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_FWSdkIf_NScene(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSdkIf_GetScene(IntPtr _this, int index);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSdkIf_GetScene_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSdkIf_MergeScene(IntPtr _this, IntPtr scene0, IntPtr scene1);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSdkIf_GetPHSdk(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSdkIf_GetGRSdk(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSdkIf_GetFISdk(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSdkIf_GetHISdk(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_FWSdkIf_GetDebugMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSdkIf_SetDebugMode(IntPtr _this, bool debug);
	[DllImport("SprExport")]
	public static extern void Spr_FWSdkIf_SetDebugMode_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSdkIf_Step(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSdkIf_Draw(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSdkIf_GetRender(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSdkIf_RegisterSdk();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWSkeletonSensorIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWSkeletonSensorIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSkeletonSensorIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSkeletonSensorIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSkeletonSensorIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSkeletonSensorIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_FWSkeletonSensorIf_Update(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWSkeletonSensorIf_SetRadius(IntPtr _this, IntPtr r);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSkeletonSensorIf_GetSensor(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_FWSkeletonSensorIf_NSkeleton(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWSkeletonSensorIf_GetSkeleton(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWWinBaseIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWWinBaseIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinBaseIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinBaseIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinBaseIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinBaseIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern int Spr_FWWinBaseIf_GetID(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinBaseIf_GetPosition(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinBaseIf_SetPosition(IntPtr _this, int left, int top);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinBaseIf_GetSize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinBaseIf_SetSize(IntPtr _this, int width, int height);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinBaseIf_GetTitle(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinBaseIf_FreeString_GetTitle(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinBaseIf_SetTitle(IntPtr _this, IntPtr title);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWControlIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWControlIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWControlIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWControlIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWControlIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWControlIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWControlIf_GetLabel(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWControlIf_FreeString_GetLabel(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern void Spr_FWControlIf_SetLabel(IntPtr _this, IntPtr l);
	[DllImport("SprExport")]
	public static extern void Spr_FWControlIf_SetAlign(IntPtr _this, int align);
	[DllImport("SprExport")]
	public static extern int Spr_FWControlIf_GetStyle(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWControlIf_SetStyle(IntPtr _this, int style);
	[DllImport("SprExport")]
	public static extern int Spr_FWControlIf_GetInt(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWControlIf_SetInt(IntPtr _this, int val);
	[DllImport("SprExport")]
	public static extern float Spr_FWControlIf_GetFloat(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWControlIf_SetFloat(IntPtr _this, float val);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWPanelIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWPanelIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWPanelIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWPanelIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWPanelIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWPanelIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWButtonIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWButtonIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWButtonIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWButtonIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWButtonIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWButtonIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_FWButtonIf_SetChecked(IntPtr _this, bool on);
	[DllImport("SprExport")]
	public static extern void Spr_FWButtonIf_SetChecked_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_FWButtonIf_IsChecked(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWStaticTextIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWStaticTextIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWStaticTextIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTextIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWStaticTextIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWStaticTextIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWTextBoxIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWTextBoxIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWTextBoxIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWTextBoxIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWTextBoxIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWTextBoxIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_FWTextBoxIf_SetIntRange(IntPtr _this, int rmin, int rmax);
	[DllImport("SprExport")]
	public static extern void Spr_FWTextBoxIf_GetIntRange(IntPtr _this, int rmin, int rmax);
	[DllImport("SprExport")]
	public static extern void Spr_FWTextBoxIf_SetFloatRange(IntPtr _this, float rmin, float rmax);
	[DllImport("SprExport")]
	public static extern void Spr_FWTextBoxIf_GetFloatRange(IntPtr _this, float rmin, float rmax);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWTextBoxIf_GetString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWTextBoxIf_SetString(IntPtr _this, string str);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWListBoxIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWListBoxIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWListBoxIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWListBoxIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWListBoxIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWListBoxIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_FWListBoxIf_AddItem(IntPtr _this, IntPtr label);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWRotationControlIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWRotationControlIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWRotationControlIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWRotationControlIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWRotationControlIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWRotationControlIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWRotationControlIf_GetRotation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWRotationControlIf_SetRotation(IntPtr _this, IntPtr rot);
	[DllImport("SprExport")]
	public static extern float Spr_FWRotationControlIf_GetDamping(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWRotationControlIf_SetDamping(IntPtr _this, float d);
	[DllImport("SprExport")]
	public static extern void Spr_FWRotationControlIf_Reset(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWTranslationControlIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWTranslationControlIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWTranslationControlIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWTranslationControlIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWTranslationControlIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWTranslationControlIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWTranslationControlIf_GetTranslation(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWTranslationControlIf_SetTranslation(IntPtr _this, IntPtr p);
	[DllImport("SprExport")]
	public static extern float Spr_FWTranslationControlIf_GetSpeed(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWTranslationControlIf_SetSpeed(IntPtr _this, float sp);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWDialogIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWDialogIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWDialogIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreatePushButton(IntPtr _this, IntPtr label, IntPtr parent);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreatePushButton_1(IntPtr _this, IntPtr label);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateCheckButton(IntPtr _this, IntPtr label, bool checked_, IntPtr parent);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateCheckButton_1(IntPtr _this, IntPtr label, bool checked_);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateCheckButton_2(IntPtr _this, IntPtr label);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateRadioButton(IntPtr _this, IntPtr label, IntPtr parent);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateRadioButton_1(IntPtr _this, IntPtr label);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateStaticText(IntPtr _this, IntPtr text, IntPtr parent);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateStaticText_1(IntPtr _this, IntPtr text);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateTextBox(IntPtr _this, IntPtr label, IntPtr text, int style, IntPtr parent);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateTextBox_1(IntPtr _this, IntPtr label, IntPtr text, int style);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateTextBox_2(IntPtr _this, IntPtr label, IntPtr text);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateTextBox_3(IntPtr _this, IntPtr label);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreatePanel(IntPtr _this, IntPtr label, int style, IntPtr parent);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreatePanel_1(IntPtr _this, IntPtr label, int style);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreatePanel_2(IntPtr _this, IntPtr label);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateRadioGroup(IntPtr _this, IntPtr parent);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateRadioGroup_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateRotationControl(IntPtr _this, IntPtr label, IntPtr parent);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateRotationControl_1(IntPtr _this, IntPtr label);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateTranslationControl(IntPtr _this, IntPtr label, int style, IntPtr parent);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateTranslationControl_1(IntPtr _this, IntPtr label, int style);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateTranslationControl_2(IntPtr _this, IntPtr label);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateListBox(IntPtr _this, IntPtr label, IntPtr parent);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWDialogIf_CreateListBox_1(IntPtr _this, IntPtr label);
	[DllImport("SprExport")]
	public static extern void Spr_FWDialogIf_CreateColumn(IntPtr _this, bool sep, IntPtr parent);
	[DllImport("SprExport")]
	public static extern void Spr_FWDialogIf_CreateColumn_1(IntPtr _this, bool sep);
	[DllImport("SprExport")]
	public static extern void Spr_FWDialogIf_CreateColumn_2(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWDialogIf_CreateSeparator(IntPtr _this, IntPtr parent);
	[DllImport("SprExport")]
	public static extern void Spr_FWDialogIf_CreateSeparator_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWWinIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWWinIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_FWWinIf_SetFullScreen(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_FWWinIf_GetFullScreen(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinIf_GetRender(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinIf_SetRender(IntPtr _this, IntPtr data);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinIf_GetScene(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinIf_SetScene(IntPtr _this, IntPtr s);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinIf_GetKeyMouse(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinIf_SetKeyMouse(IntPtr _this, IntPtr dv);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinIf_GetJoyStick(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinIf_SetJoyStick(IntPtr _this, IntPtr dv);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinIf_GetTrackball(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinIf_SetTrackball(IntPtr _this, IntPtr dv);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinIf_SetDebugMode(IntPtr _this, bool ph_or_gr);
	[DllImport("SprExport")]
	public static extern char Spr_FWWinIf_GetDebugMode(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinIf_Display(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinIf_CreateDialog(IntPtr _this, IntPtr desc);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWWinIf_CreateDialog_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWWinIf_CalcViewport(IntPtr _this, int left, int top, int width, int height);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWOptimizerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWOptimizerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOptimizerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOptimizerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOptimizerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOptimizerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_FWOptimizerIf_CopyScene(IntPtr _this, IntPtr phSceneInput);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOptimizerIf_GetScene(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOptimizerIf_Init(IntPtr _this, int dimension);
	[DllImport("SprExport")]
	public static extern void Spr_FWOptimizerIf_Start(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOptimizerIf_Abort(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_FWOptimizerIf_IsRunning(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOptimizerIf_Optimize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOptimizerIf_Iterate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_FWOptimizerIf_ApplyPop(IntPtr _this, IntPtr phScene, double x, int n);
	[DllImport("SprExport")]
	public static extern double Spr_FWOptimizerIf_Objective(IntPtr _this, double x, int n);
	[DllImport("SprExport")]
	public static extern int Spr_FWOptimizerIf_NResults(IntPtr _this);
	[DllImport("SprExport")]
	public static extern double Spr_FWOptimizerIf_GetResult(IntPtr _this, int i);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOptimizerIf_GetResults(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOptimizerIf_GetProvisionalResults(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOptimizerIf_SetESParameters(IntPtr _this, double xs, double st, double tf, double la, double mi);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWStaticTorqueOptimizerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWStaticTorqueOptimizerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWStaticTorqueOptimizerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWStaticTorqueOptimizerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWStaticTorqueOptimizerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_Init(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_Iterate(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_ApplyResult(IntPtr _this, IntPtr phScene);
	[DllImport("SprExport")]
	public static extern double Spr_FWStaticTorqueOptimizerIf_ApplyPop(IntPtr _this, IntPtr phScene, double x, int n);
	[DllImport("SprExport")]
	public static extern double Spr_FWStaticTorqueOptimizerIf_Objective(IntPtr _this, double x, int n);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_SetScene(IntPtr _this, IntPtr phSceneInput);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_Optimize(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_FWStaticTorqueOptimizerIf_TestForTermination(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_TakeFinalValue(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_SetErrorWeight(IntPtr _this, double v);
	[DllImport("SprExport")]
	public static extern double Spr_FWStaticTorqueOptimizerIf_GetErrorWeight(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_SetStabilityWeight(IntPtr _this, double v);
	[DllImport("SprExport")]
	public static extern double Spr_FWStaticTorqueOptimizerIf_GetStabilityWeight(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_SetTorqueWeight(IntPtr _this, double v);
	[DllImport("SprExport")]
	public static extern double Spr_FWStaticTorqueOptimizerIf_GetTorqueWeight(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_SetConstWeight(IntPtr _this, double v);
	[DllImport("SprExport")]
	public static extern double Spr_FWStaticTorqueOptimizerIf_GetConstWeight(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_SetGravcenterWeight(IntPtr _this, double v);
	[DllImport("SprExport")]
	public static extern double Spr_FWStaticTorqueOptimizerIf_GetGravcenterWeight(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_SetDifferentialWeight(IntPtr _this, double v);
	[DllImport("SprExport")]
	public static extern double Spr_FWStaticTorqueOptimizerIf_GetDifferentialWeight(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_AddPositionConst(IntPtr _this, IntPtr f);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWStaticTorqueOptimizerIf_GetGroundConst(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_ClearGroundConst(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_AddPositionConst_1(IntPtr _this, IntPtr f);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWStaticTorqueOptimizerIf_GetUngroundConst(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_ClearUngroundedConst(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_SetJointWeight(IntPtr _this, IntPtr jo, double w);
	[DllImport("SprExport")]
	public static extern void Spr_FWStaticTorqueOptimizerIf_SetESParameters(IntPtr _this, double xs, double st, double tf, double la, double mi);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWStaticTorqueOptimizerIf_GetObjectiveValues(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWStaticTorqueOptimizerIf_GetCenterOfGravity(IntPtr _this);
	[DllImport("SprExport")]
	public static extern int Spr_FWStaticTorqueOptimizerIf_NSupportPolygonVertices(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWStaticTorqueOptimizerIf_GetSupportPolygonVerticesN(IntPtr _this, int n);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FWOpHapticHandlerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FWOpHapticHandlerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOpHapticHandlerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOpHapticHandlerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOpHapticHandlerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOpHapticHandlerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_FWOpHapticHandlerIf_SetHapticflag(IntPtr _this, bool flag);
	[DllImport("SprExport")]
	public static extern char Spr_FWOpHapticHandlerIf_IsHapticEnabled(IntPtr _this);
	[DllImport("SprExport")]
	public static extern char Spr_FWOpHapticHandlerIf_doCalibration(IntPtr _this, float dt);
	[DllImport("SprExport")]
	public static extern void Spr_FWOpHapticHandlerIf_SetHumanInterface(IntPtr _this, IntPtr hi);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FWOpHapticHandlerIf_GetHumanInterface(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FWOpHapticHandlerIf_SetHapticTimeInterval(IntPtr _this, float dt);
	[DllImport("SprExport")]
	public static extern float Spr_FWOpHapticHandlerIf_GetHapticTimeInterval(IntPtr _this);
    }
}
