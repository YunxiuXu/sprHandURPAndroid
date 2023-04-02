using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
#pragma warning disable 0108
namespace SprCs {
    public partial class FWAppBase : DVKeyMouseCallback {
	public FWAppBase() { _this = SprExport.Spr_new_FWAppBase(); _flag = true; }
	public FWAppBase(IntPtr ptr) : base(ptr) {}
	public FWAppBase(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWAppBase() { if (_flag) { SprExport.Spr_delete_FWAppBase(_this); _flag = false; } }
	public void Init() {
	    SprExport.Spr_FWAppBase_Init((IntPtr) _this);
	}
	public void UserFunc() {
	    SprExport.Spr_FWAppBase_UserFunc((IntPtr) _this);
	}
	public void TimerFunc(int id) {
	    SprExport.Spr_FWAppBase_TimerFunc((IntPtr) _this, (int) id);
	}
	public FWSdkIf GetSdk() {
	    IntPtr ptr = SprExport.Spr_FWAppBase_GetSdk((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWSdkIf obj = new FWSdkIf(ptr);
            return obj;
	}
	public void CreateSdk() {
	    SprExport.Spr_FWAppBase_CreateSdk((IntPtr) _this);
	}
	public UTTimerIf GetTimer(int i) {
	    IntPtr ptr = SprExport.Spr_FWAppBase_GetTimer((IntPtr) _this, (int) i);
            if (ptr == IntPtr.Zero) { return null; } 
            UTTimerIf obj = new UTTimerIf(ptr);
            return obj;
	}
	public int NTimers() {
	    int result = (int) SprExport.Spr_FWAppBase_NTimers((IntPtr) _this);
	    return result;
	}
    }
    public partial class FWApp : FWAppBase {
	public FWApp() { _this = SprExport.Spr_new_FWApp(); _flag = true; }
	public FWApp(IntPtr ptr) : base(ptr) {}
	public FWApp(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWApp() { if (_flag) { SprExport.Spr_delete_FWApp(_this); _flag = false; } }
	public void Init() {
	    SprExport.Spr_FWApp_Init((IntPtr) _this);
	}
	public void Init(int argc) {
	    SprExport.Spr_FWApp_Init_1((IntPtr) _this, (int) argc);
	}
	public void InitInNewThread() {
	    SprExport.Spr_FWApp_InitInNewThread((IntPtr) _this);
	}
	public void EndThread() {
	    SprExport.Spr_FWApp_EndThread((IntPtr) _this);
	}
	public void Display() {
	    SprExport.Spr_FWApp_Display((IntPtr) _this);
	}
	public void DisableIdleFunc() {
	    SprExport.Spr_FWApp_DisableIdleFunc((IntPtr) _this);
	}
	public void EnableIdleFunc(bool on) {
	    SprExport.Spr_FWApp_EnableIdleFunc((IntPtr) _this, (bool) on);
	}
	public void EnableIdleFunc() {
	    SprExport.Spr_FWApp_EnableIdleFunc_1((IntPtr) _this);
	}
	public void StartMainLoop() {
	    SprExport.Spr_FWApp_StartMainLoop((IntPtr) _this);
	}
	public void EndMainLoop() {
	    SprExport.Spr_FWApp_EndMainLoop((IntPtr) _this);
	}
	public void IdleFunc() {
	    SprExport.Spr_FWApp_IdleFunc((IntPtr) _this);
	}
	public void TimerFunc(int id) {
	    SprExport.Spr_FWApp_TimerFunc((IntPtr) _this, (int) id);
	}
	public void Reshape(int w, int h) {
	    SprExport.Spr_FWApp_Reshape((IntPtr) _this, (int) w, (int) h);
	}
	public void Keyboard(int key, int x, int y) {
	    SprExport.Spr_FWApp_Keyboard((IntPtr) _this, (int) key, (int) x, (int) y);
	}
	public void MouseButton(int button, int state, int x, int y) {
	    SprExport.Spr_FWApp_MouseButton((IntPtr) _this, (int) button, (int) state, (int) x, (int) y);
	}
	public void MouseMove(int x, int y) {
	    SprExport.Spr_FWApp_MouseMove((IntPtr) _this, (int) x, (int) y);
	}
	public void Joystick(uint buttonMask, int x, int y, int z) {
	    SprExport.Spr_FWApp_Joystick((IntPtr) _this, (uint) buttonMask, (int) x, (int) y, (int) z);
	}
	public void AtExit() {
	    SprExport.Spr_FWApp_AtExit((IntPtr) _this);
	}
	public bool OnMouse(int button, int state, int x, int y) {
	    char ret = SprExport.Spr_FWApp_OnMouse((IntPtr) _this, (int) button, (int) state, (int) x, (int) y);
	    return (ret == 0) ? false : true;
	}
	public bool OnMouseMove(int button, int x, int y, int zdelta) {
	    char ret = SprExport.Spr_FWApp_OnMouseMove((IntPtr) _this, (int) button, (int) x, (int) y, (int) zdelta);
	    return (ret == 0) ? false : true;
	}
	public bool OnDoubleClick(int button, int x, int y) {
	    char ret = SprExport.Spr_FWApp_OnDoubleClick((IntPtr) _this, (int) button, (int) x, (int) y);
	    return (ret == 0) ? false : true;
	}
	public bool OnKey(int state, int key, int x, int y) {
	    char ret = SprExport.Spr_FWApp_OnKey((IntPtr) _this, (int) state, (int) key, (int) x, (int) y);
	    return (ret == 0) ? false : true;
	}
	public void OnControlUpdate(FWControlIf ctrl) {
	    SprExport.Spr_FWApp_OnControlUpdate((IntPtr) _this, (IntPtr) ctrl);
	}
	public static FWApp GetApp() {
	    IntPtr ptr = SprExport.Spr_FWApp_GetApp();
            return new FWApp(ptr);
	}
	public FWWinIf CreateWin(FWWinDesc desc, FWWinIf parent) {
	    IntPtr ptr = SprExport.Spr_FWApp_CreateWin((IntPtr) _this, (IntPtr) desc, (IntPtr) parent);
            if (ptr == IntPtr.Zero) { return null; } 
            FWWinIf obj = new FWWinIf(ptr);
            return obj;
	}
	public FWWinIf CreateWin(FWWinDesc desc) {
	    IntPtr ptr = SprExport.Spr_FWApp_CreateWin_1((IntPtr) _this, (IntPtr) desc);
            if (ptr == IntPtr.Zero) { return null; } 
            FWWinIf obj = new FWWinIf(ptr);
            return obj;
	}
	public FWWinIf CreateWin() {
	    IntPtr ptr = SprExport.Spr_FWApp_CreateWin_2((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWWinIf obj = new FWWinIf(ptr);
            return obj;
	}
	public int NWin() {
	    int result = (int) SprExport.Spr_FWApp_NWin((IntPtr) _this);
	    return result;
	}
	public FWWinIf GetWinFromId(int wid) {
	    IntPtr ptr = SprExport.Spr_FWApp_GetWinFromId((IntPtr) _this, (int) wid);
            if (ptr == IntPtr.Zero) { return null; } 
            FWWinIf obj = new FWWinIf(ptr);
            return obj;
	}
	public FWWinIf GetWin(int index) {
	    IntPtr ptr = SprExport.Spr_FWApp_GetWin((IntPtr) _this, (int) index);
            if (ptr == IntPtr.Zero) { return null; } 
            FWWinIf obj = new FWWinIf(ptr);
            return obj;
	}
	public FWWinIf GetCurrentWin() {
	    IntPtr ptr = SprExport.Spr_FWApp_GetCurrentWin((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWWinIf obj = new FWWinIf(ptr);
            return obj;
	}
	public void DestroyWin(FWWinIf win) {
	    SprExport.Spr_FWApp_DestroyWin((IntPtr) _this, (IntPtr) win);
	}
	public void SetCurrentWin(FWWinIf win) {
	    SprExport.Spr_FWApp_SetCurrentWin((IntPtr) _this, (IntPtr) win);
	}
	public void PostRedisplay() {
	    SprExport.Spr_FWApp_PostRedisplay((IntPtr) _this);
	}
	public int GetModifier() {
	    int result = (int) SprExport.Spr_FWApp_GetModifier((IntPtr) _this);
	    return result;
	}
	public void SetGRHandler(int type) {
	    SprExport.Spr_FWApp_SetGRHandler((IntPtr) _this, (int) type);
	}
	public GRDeviceIf GRInit() {
	    IntPtr ptr = SprExport.Spr_FWApp_GRInit((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRDeviceIf obj = new GRDeviceIf(ptr);
            return obj;
	}
	public GRDeviceIf GRInit(int argc, arraywrapper_char_p argv) {
	    IntPtr ptr = SprExport.Spr_FWApp_GRInit_1((IntPtr) _this, (int) argc, (IntPtr) argv._this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRDeviceIf obj = new GRDeviceIf(ptr);
            return obj;
	}
	public GRDeviceIf GRInit(int argc) {
	    IntPtr ptr = SprExport.Spr_FWApp_GRInit_2((IntPtr) _this, (int) argc);
            if (ptr == IntPtr.Zero) { return null; } 
            GRDeviceIf obj = new GRDeviceIf(ptr);
            return obj;
	}
	public void GetDisplayLock() {
	    SprExport.Spr_FWApp_GetDisplayLock((IntPtr) _this);
	}
	public void ReleaseDisplayLock() {
	    SprExport.Spr_FWApp_ReleaseDisplayLock((IntPtr) _this);
	}
	public void InitWindow() {
	    SprExport.Spr_FWApp_InitWindow((IntPtr) _this);
	}
	public void Clear() {
	    SprExport.Spr_FWApp_Clear((IntPtr) _this);
	}
	public void Reset() {
	    SprExport.Spr_FWApp_Reset((IntPtr) _this);
	}
    }
    public partial class FWHapticApp : FWAppBase {
	public FWHapticApp() { _this = SprExport.Spr_new_FWHapticApp(); _flag = true; }
	public FWHapticApp(IntPtr ptr) : base(ptr) {}
	public FWHapticApp(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWHapticApp() { if (_flag) { SprExport.Spr_delete_FWHapticApp(_this); _flag = false; } }
	public void TimerFunc(int id) {
	    SprExport.Spr_FWHapticApp_TimerFunc((IntPtr) _this, (int) id);
	}
	public void CreateTimers() {
	    SprExport.Spr_FWHapticApp_CreateTimers((IntPtr) _this);
	}
	public void StartTimers() {
	    SprExport.Spr_FWHapticApp_StartTimers((IntPtr) _this);
	}
	public void SetPHScene(PHSceneIf phScene) {
	    SprExport.Spr_FWHapticApp_SetPHScene((IntPtr) _this, (IntPtr) phScene);
	}
	public int GetCount() {
	    int result = (int) SprExport.Spr_FWHapticApp_GetCount((IntPtr) _this);
	    return result;
	}
    }
    public partial class FWEditor : CsObject {
	public FWEditor() { _this = SprExport.Spr_new_FWEditor(); _flag = true; }
	public FWEditor(IntPtr ptr) : base(ptr) {}
	public FWEditor(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWEditor() { if (_flag) { SprExport.Spr_delete_FWEditor(_this); _flag = false; } }
	public enum PrimitiveType : int {
	    TYPE_UNKNOWN = 0, TYPE_BOOL =  + 1, TYPE_UINT8 =  + 1, TYPE_INT8 =  + 1, TYPE_UINT16 =  + 1, TYPE_INT16 =  + 1, TYPE_UINT32 =  + 1, TYPE_INT32 =  + 1, TYPE_FLOAT =  + 1, TYPE_DOUBLE =  + 1
	}
	public void SetObject(NamedObjectIf obj, bool clearHist) {
	    SprExport.Spr_FWEditor_SetObject((IntPtr) _this, (IntPtr) obj, (bool) clearHist);
	}
	public void SetObject(NamedObjectIf obj) {
	    SprExport.Spr_FWEditor_SetObject_1((IntPtr) _this, (IntPtr) obj);
	}
	public void Update() {
	    SprExport.Spr_FWEditor_Update((IntPtr) _this);
	}
    }
    public partial class FWValidator : CsObject {
	public FWValidator() { _this = SprExport.Spr_new_FWValidator(); _flag = true; }
	public FWValidator(IntPtr ptr) : base(ptr) {}
	public FWValidator(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWValidator() { if (_flag) { SprExport.Spr_delete_FWValidator(_this); _flag = false; } }
    }
    public partial class FWEditorOverlay : FWEditor {
	public FWEditorOverlay() { _this = SprExport.Spr_new_FWEditorOverlay(); _flag = true; }
	public FWEditorOverlay(IntPtr ptr) : base(ptr) {}
	public FWEditorOverlay(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWEditorOverlay() { if (_flag) { SprExport.Spr_delete_FWEditorOverlay(_this); _flag = false; } }
	public bool Key(int key) {
	    char ret = SprExport.Spr_FWEditorOverlay_Key((IntPtr) _this, (int) key);
	    return (ret == 0) ? false : true;
	}
	public void Draw(GRRenderIf render) {
	    SprExport.Spr_FWEditorOverlay_Draw((IntPtr) _this, (IntPtr) render);
	}
    }
    public partial class FWObjectDesc : CsObject {
	public FWObjectDesc() { _this = SprExport.Spr_new_FWObjectDesc(); _flag = true; }
	public FWObjectDesc(IntPtr ptr) : base(ptr) {}
	public FWObjectDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWObjectDesc() { if (_flag) { SprExport.Spr_delete_FWObjectDesc(_this); _flag = false; } }
	public bool bAbsolute {
	    get {
	        byte ret = (byte) SprExport.Spr_FWObjectDesc_get_bAbsolute(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWObjectDesc_set_bAbsolute(_this, (char) val);
	    }
	}
	public enum FWObjectSyncSource : int {
	    PHYSICS, GRAPHICS = PHYSICS + 1
	}
	public FWObjectSyncSource syncSource {
	    get { return (FWObjectSyncSource) SprExport.Spr_FWObjectDesc_get_syncSource(_this); }
	    set { SprExport.Spr_FWObjectDesc_set_syncSource(_this, (int) value); }
	}
    }
    [System.Serializable]
    public class FWObjectDescStruct : CsObject {
        public FWObjectDescStruct() {
            FWObjectDesc desc = new FWObjectDesc();
            ApplyFrom(desc, false);
        }
	public bool bAbsolute;
// _[Find class node: 2916] FWObjectDesc
	public void ApplyTo(FWObjectDesc r, bool apply_to_base_class=true) {
		r.bAbsolute = bAbsolute;
	}
	public void ApplyFrom(FWObjectDesc r, bool apply_to_base_class=true) {
		bAbsolute = r.bAbsolute;
	}
	public static implicit operator FWObjectDesc(FWObjectDescStruct m) {
	    FWObjectDesc r = new FWObjectDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWObjectDescStruct(FWObjectDesc r) {
	    FWObjectDescStruct m = new FWObjectDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWOpObjDesc : FWObjectDesc {
	public FWOpObjDesc() { _this = SprExport.Spr_new_FWOpObjDesc(); _flag = true; }
	public FWOpObjDesc(IntPtr ptr) : base(ptr) {}
	public FWOpObjDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWOpObjDesc() { if (_flag) { SprExport.Spr_delete_FWOpObjDesc(_this); _flag = false; } }
	public float fwPSize {
	    get { return SprExport.Spr_FWOpObjDesc_get_fwPSize(_this); }
	    set { SprExport.Spr_FWOpObjDesc_set_fwPSize(_this, value); }
	}
    }
    [System.Serializable]
    public class FWOpObjDescStruct : FWObjectDescStruct {
        public FWOpObjDescStruct() {
            FWOpObjDesc desc = new FWOpObjDesc();
            ApplyFrom(desc, true);
        }
	public float fwPSize;
// _[Find class node: 2916] FWOpObjDesc
	public void ApplyTo(FWOpObjDesc r, bool apply_to_base_class=true) {
		r.fwPSize = fwPSize;
		if (apply_to_base_class) {
		    base.ApplyTo((FWObjectDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(FWOpObjDesc r, bool apply_to_base_class=true) {
		fwPSize = r.fwPSize;
		if (apply_to_base_class) {
		    base.ApplyFrom((FWObjectDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator FWOpObjDesc(FWOpObjDescStruct m) {
	    FWOpObjDesc r = new FWOpObjDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWOpObjDescStruct(FWOpObjDesc r) {
	    FWOpObjDescStruct m = new FWOpObjDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWFemMeshDesc : FWObjectDesc {
	public FWFemMeshDesc() { _this = SprExport.Spr_new_FWFemMeshDesc(); _flag = true; }
	public FWFemMeshDesc(IntPtr ptr) : base(ptr) {}
	public FWFemMeshDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWFemMeshDesc() { if (_flag) { SprExport.Spr_delete_FWFemMeshDesc(_this); _flag = false; } }
	public uint kogePics {
	    get { return SprExport.Spr_FWFemMeshDesc_get_kogePics(_this); }
	    set { SprExport.Spr_FWFemMeshDesc_set_kogePics(_this, value); }
	}
	public uint thermoPics {
	    get { return SprExport.Spr_FWFemMeshDesc_get_thermoPics(_this); }
	    set { SprExport.Spr_FWFemMeshDesc_set_thermoPics(_this, value); }
	}
	public uint waterPics {
	    get { return SprExport.Spr_FWFemMeshDesc_get_waterPics(_this); }
	    set { SprExport.Spr_FWFemMeshDesc_set_waterPics(_this, value); }
	}
	public string meshRoughness {
	    get {
	        IntPtr ptr = SprExport.Spr_FWFemMeshDesc_get_meshRoughness(_this);
	        string bstr = Marshal.PtrToStringBSTR(ptr);
	        SprExport.Spr_FWFemMeshDesc_FreeString_meshRoughness(ptr);
	        return bstr;
	    }
	    set {
	        IntPtr pbstr = Marshal.StringToBSTR(value);
	        SprExport.Spr_FWFemMeshDesc_set_meshRoughness(_this, pbstr);
	    }
	}
	public void Init() {
	    SprExport.Spr_FWFemMeshDesc_Init((IntPtr) _this);
	}
    }
    [System.Serializable]
    public class FWFemMeshDescStruct : FWObjectDescStruct {
        public FWFemMeshDescStruct() {
            FWFemMeshDesc desc = new FWFemMeshDesc();
            ApplyFrom(desc, true);
        }
	public uint kogePics;
	public uint thermoPics;
	public uint waterPics;
	public string meshRoughness;
// _[Find class node: 2916] FWFemMeshDesc
	public void ApplyTo(FWFemMeshDesc r, bool apply_to_base_class=true) {
		r.kogePics = kogePics;
		r.thermoPics = thermoPics;
		r.waterPics = waterPics;
		r.meshRoughness = meshRoughness;
		if (apply_to_base_class) {
		    base.ApplyTo((FWObjectDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(FWFemMeshDesc r, bool apply_to_base_class=true) {
		kogePics = r.kogePics;
		thermoPics = r.thermoPics;
		waterPics = r.waterPics;
		meshRoughness = r.meshRoughness;
		if (apply_to_base_class) {
		    base.ApplyFrom((FWObjectDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator FWFemMeshDesc(FWFemMeshDescStruct m) {
	    FWFemMeshDesc r = new FWFemMeshDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWFemMeshDescStruct(FWFemMeshDesc r) {
	    FWFemMeshDescStruct m = new FWFemMeshDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWFemMeshNewDesc : FWObjectDesc {
	public FWFemMeshNewDesc() { _this = SprExport.Spr_new_FWFemMeshNewDesc(); _flag = true; }
	public FWFemMeshNewDesc(IntPtr ptr) : base(ptr) {}
	public FWFemMeshNewDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWFemMeshNewDesc() { if (_flag) { SprExport.Spr_delete_FWFemMeshNewDesc(_this); _flag = false; } }
	public uint kogetex {
	    get { return SprExport.Spr_FWFemMeshNewDesc_get_kogetex(_this); }
	    set { SprExport.Spr_FWFemMeshNewDesc_set_kogetex(_this, value); }
	}
	public string meshRoughness {
	    get {
	        IntPtr ptr = SprExport.Spr_FWFemMeshNewDesc_get_meshRoughness(_this);
	        string bstr = Marshal.PtrToStringBSTR(ptr);
	        SprExport.Spr_FWFemMeshNewDesc_FreeString_meshRoughness(ptr);
	        return bstr;
	    }
	    set {
	        IntPtr pbstr = Marshal.StringToBSTR(value);
	        SprExport.Spr_FWFemMeshNewDesc_set_meshRoughness(_this, pbstr);
	    }
	}
	public bool spheric {
	    get {
	        byte ret = (byte) SprExport.Spr_FWFemMeshNewDesc_get_spheric(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWFemMeshNewDesc_set_spheric(_this, (char) val);
	    }
	}
	public uint texture_mode {
	    get { return SprExport.Spr_FWFemMeshNewDesc_get_texture_mode(_this); }
	    set { SprExport.Spr_FWFemMeshNewDesc_set_texture_mode(_this, value); }
	}
	public void Init() {
	    SprExport.Spr_FWFemMeshNewDesc_Init((IntPtr) _this);
	}
    }
    [System.Serializable]
    public class FWFemMeshNewDescStruct : FWObjectDescStruct {
        public FWFemMeshNewDescStruct() {
            FWFemMeshNewDesc desc = new FWFemMeshNewDesc();
            ApplyFrom(desc, true);
        }
	public uint kogetex;
	public string meshRoughness;
	public bool spheric;
	public uint texture_mode;
// _[Find class node: 2916] FWFemMeshNewDesc
	public void ApplyTo(FWFemMeshNewDesc r, bool apply_to_base_class=true) {
		r.kogetex = kogetex;
		r.meshRoughness = meshRoughness;
		r.spheric = spheric;
		r.texture_mode = texture_mode;
		if (apply_to_base_class) {
		    base.ApplyTo((FWObjectDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(FWFemMeshNewDesc r, bool apply_to_base_class=true) {
		kogetex = r.kogetex;
		meshRoughness = r.meshRoughness;
		spheric = r.spheric;
		texture_mode = r.texture_mode;
		if (apply_to_base_class) {
		    base.ApplyFrom((FWObjectDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator FWFemMeshNewDesc(FWFemMeshNewDescStruct m) {
	    FWFemMeshNewDesc r = new FWFemMeshNewDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWFemMeshNewDescStruct(FWFemMeshNewDesc r) {
	    FWFemMeshNewDescStruct m = new FWFemMeshNewDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWSceneDesc : CsObject {
	public FWSceneDesc() { _this = SprExport.Spr_new_FWSceneDesc(); _flag = true; }
	public FWSceneDesc(IntPtr ptr) : base(ptr) {}
	public FWSceneDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWSceneDesc() { if (_flag) { SprExport.Spr_delete_FWSceneDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class FWSceneDescStruct : CsObject {
        public FWSceneDescStruct() {
            FWSceneDesc desc = new FWSceneDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] FWSceneDesc
	public void ApplyTo(FWSceneDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(FWSceneDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator FWSceneDesc(FWSceneDescStruct m) {
	    FWSceneDesc r = new FWSceneDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWSceneDescStruct(FWSceneDesc r) {
	    FWSceneDescStruct m = new FWSceneDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWSdkDesc : CsObject {
	public FWSdkDesc() { _this = SprExport.Spr_new_FWSdkDesc(); _flag = true; }
	public FWSdkDesc(IntPtr ptr) : base(ptr) {}
	public FWSdkDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWSdkDesc() { if (_flag) { SprExport.Spr_delete_FWSdkDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class FWSdkDescStruct : CsObject {
        public FWSdkDescStruct() {
            FWSdkDesc desc = new FWSdkDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] FWSdkDesc
	public void ApplyTo(FWSdkDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(FWSdkDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator FWSdkDesc(FWSdkDescStruct m) {
	    FWSdkDesc r = new FWSdkDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWSdkDescStruct(FWSdkDesc r) {
	    FWSdkDescStruct m = new FWSdkDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWSkeletonSensorDesc : CsObject {
	public FWSkeletonSensorDesc() { _this = SprExport.Spr_new_FWSkeletonSensorDesc(); _flag = true; }
	public FWSkeletonSensorDesc(IntPtr ptr) : base(ptr) {}
	public FWSkeletonSensorDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWSkeletonSensorDesc() { if (_flag) { SprExport.Spr_delete_FWSkeletonSensorDesc(_this); _flag = false; } }
	public bool bCreatePHSkeleton {
	    get {
	        byte ret = (byte) SprExport.Spr_FWSkeletonSensorDesc_get_bCreatePHSkeleton(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWSkeletonSensorDesc_set_bCreatePHSkeleton(_this, (char) val);
	    }
	}
	public bool bCreatePHSolid {
	    get {
	        byte ret = (byte) SprExport.Spr_FWSkeletonSensorDesc_get_bCreatePHSolid(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWSkeletonSensorDesc_set_bCreatePHSolid(_this, (char) val);
	    }
	}
	public bool bCreateCDShape {
	    get {
	        byte ret = (byte) SprExport.Spr_FWSkeletonSensorDesc_get_bCreateCDShape(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWSkeletonSensorDesc_set_bCreateCDShape(_this, (char) val);
	    }
	}
	public bool bCreatePHJoint {
	    get {
	        byte ret = (byte) SprExport.Spr_FWSkeletonSensorDesc_get_bCreatePHJoint(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWSkeletonSensorDesc_set_bCreatePHJoint(_this, (char) val);
	    }
	}
	public bool bCreatePHSpring {
	    get {
	        byte ret = (byte) SprExport.Spr_FWSkeletonSensorDesc_get_bCreatePHSpring(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWSkeletonSensorDesc_set_bCreatePHSpring(_this, (char) val);
	    }
	}
	public Vec2d radius {
	    get { return new Vec2d(SprExport.Spr_FWSkeletonSensorDesc_addr_radius(_this)); }
	    set { SprExport.Spr_FWSkeletonSensorDesc_set_radius(_this, value); }
	}
    }
    [System.Serializable]
    public class FWSkeletonSensorDescStruct : CsObject {
        public FWSkeletonSensorDescStruct() {
            FWSkeletonSensorDesc desc = new FWSkeletonSensorDesc();
            ApplyFrom(desc, false);
        }
	public bool bCreatePHSkeleton;
	public bool bCreatePHSolid;
	public bool bCreateCDShape;
	public bool bCreatePHJoint;
	public bool bCreatePHSpring;
	public Vec2dStruct radius;
// _[Find class node: 2916] FWSkeletonSensorDesc
	public void ApplyTo(FWSkeletonSensorDesc r, bool apply_to_base_class=true) {
		r.bCreatePHSkeleton = bCreatePHSkeleton;
		r.bCreatePHSolid = bCreatePHSolid;
		r.bCreateCDShape = bCreateCDShape;
		r.bCreatePHJoint = bCreatePHJoint;
		r.bCreatePHSpring = bCreatePHSpring;
		r.radius = radius;
	}
	public void ApplyFrom(FWSkeletonSensorDesc r, bool apply_to_base_class=true) {
		bCreatePHSkeleton = r.bCreatePHSkeleton;
		bCreatePHSolid = r.bCreatePHSolid;
		bCreateCDShape = r.bCreateCDShape;
		bCreatePHJoint = r.bCreatePHJoint;
		bCreatePHSpring = r.bCreatePHSpring;
		radius = r.radius;
	}
	public static implicit operator FWSkeletonSensorDesc(FWSkeletonSensorDescStruct m) {
	    FWSkeletonSensorDesc r = new FWSkeletonSensorDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWSkeletonSensorDescStruct(FWSkeletonSensorDesc r) {
	    FWSkeletonSensorDescStruct m = new FWSkeletonSensorDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWWinBaseDesc : CsObject {
	public FWWinBaseDesc() { _this = SprExport.Spr_new_FWWinBaseDesc(); _flag = true; }
	public FWWinBaseDesc(IntPtr ptr) : base(ptr) {}
	public FWWinBaseDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWWinBaseDesc() { if (_flag) { SprExport.Spr_delete_FWWinBaseDesc(_this); _flag = false; } }
	public int width {
	    get { return SprExport.Spr_FWWinBaseDesc_get_width(_this); }
	    set { SprExport.Spr_FWWinBaseDesc_set_width(_this, value); }
	}
	public int height {
	    get { return SprExport.Spr_FWWinBaseDesc_get_height(_this); }
	    set { SprExport.Spr_FWWinBaseDesc_set_height(_this, value); }
	}
	public int left {
	    get { return SprExport.Spr_FWWinBaseDesc_get_left(_this); }
	    set { SprExport.Spr_FWWinBaseDesc_set_left(_this, value); }
	}
	public int top {
	    get { return SprExport.Spr_FWWinBaseDesc_get_top(_this); }
	    set { SprExport.Spr_FWWinBaseDesc_set_top(_this, value); }
	}
	public string title {
	    get {
	        IntPtr ptr = SprExport.Spr_FWWinBaseDesc_get_title(_this);
	        string bstr = Marshal.PtrToStringBSTR(ptr);
	        SprExport.Spr_FWWinBaseDesc_FreeString_title(ptr);
	        return bstr;
	    }
	    set {
	        IntPtr pbstr = Marshal.StringToBSTR(value);
	        SprExport.Spr_FWWinBaseDesc_set_title(_this, pbstr);
	    }
	}
    }
    [System.Serializable]
    public class FWWinBaseDescStruct : CsObject {
        public FWWinBaseDescStruct() {
            FWWinBaseDesc desc = new FWWinBaseDesc();
            ApplyFrom(desc, false);
        }
	public int width;
	public int height;
	public int left;
	public int top;
	public string title;
// _[Find class node: 2916] FWWinBaseDesc
	public void ApplyTo(FWWinBaseDesc r, bool apply_to_base_class=true) {
		r.width = width;
		r.height = height;
		r.left = left;
		r.top = top;
		r.title = title;
	}
	public void ApplyFrom(FWWinBaseDesc r, bool apply_to_base_class=true) {
		width = r.width;
		height = r.height;
		left = r.left;
		top = r.top;
		title = r.title;
	}
	public static implicit operator FWWinBaseDesc(FWWinBaseDescStruct m) {
	    FWWinBaseDesc r = new FWWinBaseDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWWinBaseDescStruct(FWWinBaseDesc r) {
	    FWWinBaseDescStruct m = new FWWinBaseDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWControlDesc : CsObject {
	public FWControlDesc() { _this = SprExport.Spr_new_FWControlDesc(); _flag = true; }
	public FWControlDesc(IntPtr ptr) : base(ptr) {}
	public FWControlDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWControlDesc() { if (_flag) { SprExport.Spr_delete_FWControlDesc(_this); _flag = false; } }
	public string label {
	    get {
	        IntPtr ptr = SprExport.Spr_FWControlDesc_get_label(_this);
	        string bstr = Marshal.PtrToStringBSTR(ptr);
	        SprExport.Spr_FWControlDesc_FreeString_label(ptr);
	        return bstr;
	    }
	    set {
	        IntPtr pbstr = Marshal.StringToBSTR(value);
	        SprExport.Spr_FWControlDesc_set_label(_this, pbstr);
	    }
	}
	public int align {
	    get { return SprExport.Spr_FWControlDesc_get_align(_this); }
	    set { SprExport.Spr_FWControlDesc_set_align(_this, value); }
	}
	public int style {
	    get { return SprExport.Spr_FWControlDesc_get_style(_this); }
	    set { SprExport.Spr_FWControlDesc_set_style(_this, value); }
	}
    }
    [System.Serializable]
    public class FWControlDescStruct : CsObject {
        public FWControlDescStruct() {
            FWControlDesc desc = new FWControlDesc();
            ApplyFrom(desc, false);
        }
	public string label;
	public int align;
	public int style;
// _[Find class node: 2916] FWControlDesc
	public void ApplyTo(FWControlDesc r, bool apply_to_base_class=true) {
		r.label = label;
		r.align = align;
		r.style = style;
	}
	public void ApplyFrom(FWControlDesc r, bool apply_to_base_class=true) {
		label = r.label;
		align = r.align;
		style = r.style;
	}
	public static implicit operator FWControlDesc(FWControlDescStruct m) {
	    FWControlDesc r = new FWControlDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWControlDescStruct(FWControlDesc r) {
	    FWControlDescStruct m = new FWControlDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWPanelDesc : FWControlDesc {
	public FWPanelDesc() { _this = SprExport.Spr_new_FWPanelDesc(); _flag = true; }
	public FWPanelDesc(IntPtr ptr) : base(ptr) {}
	public FWPanelDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWPanelDesc() { if (_flag) { SprExport.Spr_delete_FWPanelDesc(_this); _flag = false; } }
	public bool open {
	    get {
	        byte ret = (byte) SprExport.Spr_FWPanelDesc_get_open(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWPanelDesc_set_open(_this, (char) val);
	    }
	}
    }
    [System.Serializable]
    public class FWPanelDescStruct : FWControlDescStruct {
        public FWPanelDescStruct() {
            FWPanelDesc desc = new FWPanelDesc();
            ApplyFrom(desc, true);
        }
	public bool open;
// _[Find class node: 2916] FWPanelDesc
	public void ApplyTo(FWPanelDesc r, bool apply_to_base_class=true) {
		r.open = open;
		if (apply_to_base_class) {
		    base.ApplyTo((FWControlDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(FWPanelDesc r, bool apply_to_base_class=true) {
		open = r.open;
		if (apply_to_base_class) {
		    base.ApplyFrom((FWControlDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator FWPanelDesc(FWPanelDescStruct m) {
	    FWPanelDesc r = new FWPanelDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWPanelDescStruct(FWPanelDesc r) {
	    FWPanelDescStruct m = new FWPanelDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWButtonDesc : FWControlDesc {
	public FWButtonDesc() { _this = SprExport.Spr_new_FWButtonDesc(); _flag = true; }
	public FWButtonDesc(IntPtr ptr) : base(ptr) {}
	public FWButtonDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWButtonDesc() { if (_flag) { SprExport.Spr_delete_FWButtonDesc(_this); _flag = false; } }
	public int style {
	    get { return SprExport.Spr_FWButtonDesc_get_style(_this); }
	    set { SprExport.Spr_FWButtonDesc_set_style(_this, value); }
	}
	public bool checked_ {
	    get {
	        byte ret = (byte) SprExport.Spr_FWButtonDesc_get_checked(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWButtonDesc_set_checked(_this, (char) val);
	    }
	}
    }
    [System.Serializable]
    public class FWButtonDescStruct : FWControlDescStruct {
        public FWButtonDescStruct() {
            FWButtonDesc desc = new FWButtonDesc();
            ApplyFrom(desc, true);
        }
	public int style;
	public bool checked_;
// _[Find class node: 2916] FWButtonDesc
	public void ApplyTo(FWButtonDesc r, bool apply_to_base_class=true) {
		r.style = style;
		r.checked_ = checked_;
		if (apply_to_base_class) {
		    base.ApplyTo((FWControlDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(FWButtonDesc r, bool apply_to_base_class=true) {
		style = r.style;
		checked_ = r.checked_;
		if (apply_to_base_class) {
		    base.ApplyFrom((FWControlDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator FWButtonDesc(FWButtonDescStruct m) {
	    FWButtonDesc r = new FWButtonDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWButtonDescStruct(FWButtonDesc r) {
	    FWButtonDescStruct m = new FWButtonDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWStaticTextDesc : FWControlDesc {
	public FWStaticTextDesc() { _this = SprExport.Spr_new_FWStaticTextDesc(); _flag = true; }
	public FWStaticTextDesc(IntPtr ptr) : base(ptr) {}
	public FWStaticTextDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWStaticTextDesc() { if (_flag) { SprExport.Spr_delete_FWStaticTextDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class FWStaticTextDescStruct : FWControlDescStruct {
        public FWStaticTextDescStruct() {
            FWStaticTextDesc desc = new FWStaticTextDesc();
            ApplyFrom(desc, true);
        }
// _[Find class node: 2916] FWStaticTextDesc
	public void ApplyTo(FWStaticTextDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyTo((FWControlDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(FWStaticTextDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyFrom((FWControlDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator FWStaticTextDesc(FWStaticTextDescStruct m) {
	    FWStaticTextDesc r = new FWStaticTextDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWStaticTextDescStruct(FWStaticTextDesc r) {
	    FWStaticTextDescStruct m = new FWStaticTextDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWTextBoxDesc : FWControlDesc {
	public FWTextBoxDesc() { _this = SprExport.Spr_new_FWTextBoxDesc(); _flag = true; }
	public FWTextBoxDesc(IntPtr ptr) : base(ptr) {}
	public FWTextBoxDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWTextBoxDesc() { if (_flag) { SprExport.Spr_delete_FWTextBoxDesc(_this); _flag = false; } }
	public string text {
	    get {
	        IntPtr ptr = SprExport.Spr_FWTextBoxDesc_get_text(_this);
	        string bstr = Marshal.PtrToStringBSTR(ptr);
	        SprExport.Spr_FWTextBoxDesc_FreeString_text(ptr);
	        return bstr;
	    }
	    set {
	        IntPtr pbstr = Marshal.StringToBSTR(value);
	        SprExport.Spr_FWTextBoxDesc_set_text(_this, pbstr);
	    }
	}
	public int intMin {
	    get { return SprExport.Spr_FWTextBoxDesc_get_intMin(_this); }
	    set { SprExport.Spr_FWTextBoxDesc_set_intMin(_this, value); }
	}
	public int intMax {
	    get { return SprExport.Spr_FWTextBoxDesc_get_intMax(_this); }
	    set { SprExport.Spr_FWTextBoxDesc_set_intMax(_this, value); }
	}
	public float floatMin {
	    get { return SprExport.Spr_FWTextBoxDesc_get_floatMin(_this); }
	    set { SprExport.Spr_FWTextBoxDesc_set_floatMin(_this, value); }
	}
	public float floatMax {
	    get { return SprExport.Spr_FWTextBoxDesc_get_floatMax(_this); }
	    set { SprExport.Spr_FWTextBoxDesc_set_floatMax(_this, value); }
	}
	public bool spinner {
	    get {
	        byte ret = (byte) SprExport.Spr_FWTextBoxDesc_get_spinner(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWTextBoxDesc_set_spinner(_this, (char) val);
	    }
	}
    }
    [System.Serializable]
    public class FWTextBoxDescStruct : FWControlDescStruct {
        public FWTextBoxDescStruct() {
            FWTextBoxDesc desc = new FWTextBoxDesc();
            ApplyFrom(desc, true);
        }
	public string text;
	public int intMin;
	public int intMax;
	public float floatMin;
	public float floatMax;
	public bool spinner;
// _[Find class node: 2916] FWTextBoxDesc
	public void ApplyTo(FWTextBoxDesc r, bool apply_to_base_class=true) {
		r.text = text;
		r.intMin = intMin;
		r.intMax = intMax;
		r.floatMin = floatMin;
		r.floatMax = floatMax;
		r.spinner = spinner;
		if (apply_to_base_class) {
		    base.ApplyTo((FWControlDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(FWTextBoxDesc r, bool apply_to_base_class=true) {
		text = r.text;
		intMin = r.intMin;
		intMax = r.intMax;
		floatMin = r.floatMin;
		floatMax = r.floatMax;
		spinner = r.spinner;
		if (apply_to_base_class) {
		    base.ApplyFrom((FWControlDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator FWTextBoxDesc(FWTextBoxDescStruct m) {
	    FWTextBoxDesc r = new FWTextBoxDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWTextBoxDescStruct(FWTextBoxDesc r) {
	    FWTextBoxDescStruct m = new FWTextBoxDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWListBoxDesc : FWControlDesc {
	public FWListBoxDesc() { _this = SprExport.Spr_new_FWListBoxDesc(); _flag = true; }
	public FWListBoxDesc(IntPtr ptr) : base(ptr) {}
	public FWListBoxDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWListBoxDesc() { if (_flag) { SprExport.Spr_delete_FWListBoxDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class FWListBoxDescStruct : FWControlDescStruct {
        public FWListBoxDescStruct() {
            FWListBoxDesc desc = new FWListBoxDesc();
            ApplyFrom(desc, true);
        }
// _[Find class node: 2916] FWListBoxDesc
	public void ApplyTo(FWListBoxDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyTo((FWControlDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(FWListBoxDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyFrom((FWControlDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator FWListBoxDesc(FWListBoxDescStruct m) {
	    FWListBoxDesc r = new FWListBoxDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWListBoxDescStruct(FWListBoxDesc r) {
	    FWListBoxDescStruct m = new FWListBoxDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWRotationControlDesc : FWControlDesc {
	public FWRotationControlDesc() { _this = SprExport.Spr_new_FWRotationControlDesc(); _flag = true; }
	public FWRotationControlDesc(IntPtr ptr) : base(ptr) {}
	public FWRotationControlDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWRotationControlDesc() { if (_flag) { SprExport.Spr_delete_FWRotationControlDesc(_this); _flag = false; } }
	public Matrix3f rot {
	    get { return new Matrix3f(SprExport.Spr_FWRotationControlDesc_addr_rot(_this)); }
	    set { SprExport.Spr_FWRotationControlDesc_set_rot(_this, value); }
	}
	public float damping {
	    get { return SprExport.Spr_FWRotationControlDesc_get_damping(_this); }
	    set { SprExport.Spr_FWRotationControlDesc_set_damping(_this, value); }
	}
    }
    [System.Serializable]
    public class FWRotationControlDescStruct : FWControlDescStruct {
        public FWRotationControlDescStruct() {
            FWRotationControlDesc desc = new FWRotationControlDesc();
            ApplyFrom(desc, true);
        }
	public Matrix3fStruct rot;
	public float damping;
// _[Find class node: 2916] FWRotationControlDesc
	public void ApplyTo(FWRotationControlDesc r, bool apply_to_base_class=true) {
		r.rot = rot;
		r.damping = damping;
		if (apply_to_base_class) {
		    base.ApplyTo((FWControlDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(FWRotationControlDesc r, bool apply_to_base_class=true) {
		rot = r.rot;
		damping = r.damping;
		if (apply_to_base_class) {
		    base.ApplyFrom((FWControlDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator FWRotationControlDesc(FWRotationControlDescStruct m) {
	    FWRotationControlDesc r = new FWRotationControlDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWRotationControlDescStruct(FWRotationControlDesc r) {
	    FWRotationControlDescStruct m = new FWRotationControlDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWTranslationControlDesc : FWControlDesc {
	public FWTranslationControlDesc() { _this = SprExport.Spr_new_FWTranslationControlDesc(); _flag = true; }
	public FWTranslationControlDesc(IntPtr ptr) : base(ptr) {}
	public FWTranslationControlDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWTranslationControlDesc() { if (_flag) { SprExport.Spr_delete_FWTranslationControlDesc(_this); _flag = false; } }
	public Vec3f pos {
	    get { return new Vec3f(SprExport.Spr_FWTranslationControlDesc_addr_pos(_this)); }
	    set { SprExport.Spr_FWTranslationControlDesc_set_pos(_this, value); }
	}
	public float speed {
	    get { return SprExport.Spr_FWTranslationControlDesc_get_speed(_this); }
	    set { SprExport.Spr_FWTranslationControlDesc_set_speed(_this, value); }
	}
    }
    [System.Serializable]
    public class FWTranslationControlDescStruct : FWControlDescStruct {
        public FWTranslationControlDescStruct() {
            FWTranslationControlDesc desc = new FWTranslationControlDesc();
            ApplyFrom(desc, true);
        }
	public Vec3fStruct pos;
	public float speed;
// _[Find class node: 2916] FWTranslationControlDesc
	public void ApplyTo(FWTranslationControlDesc r, bool apply_to_base_class=true) {
		r.pos = pos;
		r.speed = speed;
		if (apply_to_base_class) {
		    base.ApplyTo((FWControlDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(FWTranslationControlDesc r, bool apply_to_base_class=true) {
		pos = r.pos;
		speed = r.speed;
		if (apply_to_base_class) {
		    base.ApplyFrom((FWControlDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator FWTranslationControlDesc(FWTranslationControlDescStruct m) {
	    FWTranslationControlDesc r = new FWTranslationControlDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWTranslationControlDescStruct(FWTranslationControlDesc r) {
	    FWTranslationControlDescStruct m = new FWTranslationControlDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWDialogDesc : FWWinBaseDesc {
	public FWDialogDesc() { _this = SprExport.Spr_new_FWDialogDesc(); _flag = true; }
	public FWDialogDesc(IntPtr ptr) : base(ptr) {}
	public FWDialogDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWDialogDesc() { if (_flag) { SprExport.Spr_delete_FWDialogDesc(_this); _flag = false; } }
	public bool dock {
	    get {
	        byte ret = (byte) SprExport.Spr_FWDialogDesc_get_dock(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWDialogDesc_set_dock(_this, (char) val);
	    }
	}
	public int dockPos {
	    get { return SprExport.Spr_FWDialogDesc_get_dockPos(_this); }
	    set { SprExport.Spr_FWDialogDesc_set_dockPos(_this, value); }
	}
    }
    [System.Serializable]
    public class FWDialogDescStruct : FWWinBaseDescStruct {
        public FWDialogDescStruct() {
            FWDialogDesc desc = new FWDialogDesc();
            ApplyFrom(desc, true);
        }
	public bool dock;
	public int dockPos;
// _[Find class node: 2916] FWDialogDesc
	public void ApplyTo(FWDialogDesc r, bool apply_to_base_class=true) {
		r.dock = dock;
		r.dockPos = dockPos;
		if (apply_to_base_class) {
		    base.ApplyTo((FWWinBaseDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(FWDialogDesc r, bool apply_to_base_class=true) {
		dock = r.dock;
		dockPos = r.dockPos;
		if (apply_to_base_class) {
		    base.ApplyFrom((FWWinBaseDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator FWDialogDesc(FWDialogDescStruct m) {
	    FWDialogDesc r = new FWDialogDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWDialogDescStruct(FWDialogDesc r) {
	    FWDialogDescStruct m = new FWDialogDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWWinDesc : FWWinBaseDesc {
	public FWWinDesc() { _this = SprExport.Spr_new_FWWinDesc(); _flag = true; }
	public FWWinDesc(IntPtr ptr) : base(ptr) {}
	public FWWinDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWWinDesc() { if (_flag) { SprExport.Spr_delete_FWWinDesc(_this); _flag = false; } }
	public bool debugMode {
	    get {
	        byte ret = (byte) SprExport.Spr_FWWinDesc_get_debugMode(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWWinDesc_set_debugMode(_this, (char) val);
	    }
	}
	public bool fullscreen {
	    get {
	        byte ret = (byte) SprExport.Spr_FWWinDesc_get_fullscreen(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWWinDesc_set_fullscreen(_this, (char) val);
	    }
	}
	public bool useKeyMouse {
	    get {
	        byte ret = (byte) SprExport.Spr_FWWinDesc_get_useKeyMouse(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWWinDesc_set_useKeyMouse(_this, (char) val);
	    }
	}
	public bool useJoyStick {
	    get {
	        byte ret = (byte) SprExport.Spr_FWWinDesc_get_useJoyStick(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWWinDesc_set_useJoyStick(_this, (char) val);
	    }
	}
	public int joyStickPollInterval {
	    get { return SprExport.Spr_FWWinDesc_get_joyStickPollInterval(_this); }
	    set { SprExport.Spr_FWWinDesc_set_joyStickPollInterval(_this, value); }
	}
	public bool useTrackball {
	    get {
	        byte ret = (byte) SprExport.Spr_FWWinDesc_get_useTrackball(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_FWWinDesc_set_useTrackball(_this, (char) val);
	    }
	}
    }
    [System.Serializable]
    public class FWWinDescStruct : FWWinBaseDescStruct {
        public FWWinDescStruct() {
            FWWinDesc desc = new FWWinDesc();
            ApplyFrom(desc, true);
        }
	public bool debugMode;
	public bool fullscreen;
	public bool useKeyMouse;
	public bool useJoyStick;
	public int joyStickPollInterval;
	public bool useTrackball;
// _[Find class node: 2916] FWWinDesc
	public void ApplyTo(FWWinDesc r, bool apply_to_base_class=true) {
		r.debugMode = debugMode;
		r.fullscreen = fullscreen;
		r.useKeyMouse = useKeyMouse;
		r.useJoyStick = useJoyStick;
		r.joyStickPollInterval = joyStickPollInterval;
		r.useTrackball = useTrackball;
		if (apply_to_base_class) {
		    base.ApplyTo((FWWinBaseDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(FWWinDesc r, bool apply_to_base_class=true) {
		debugMode = r.debugMode;
		fullscreen = r.fullscreen;
		useKeyMouse = r.useKeyMouse;
		useJoyStick = r.useJoyStick;
		joyStickPollInterval = r.joyStickPollInterval;
		useTrackball = r.useTrackball;
		if (apply_to_base_class) {
		    base.ApplyFrom((FWWinBaseDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator FWWinDesc(FWWinDescStruct m) {
	    FWWinDesc r = new FWWinDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWWinDescStruct(FWWinDesc r) {
	    FWWinDescStruct m = new FWWinDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWGroundConstraint : CsObject {
	public FWGroundConstraint() { _this = SprExport.Spr_new_FWGroundConstraint(); _flag = true; }
	public FWGroundConstraint(IntPtr ptr) : base(ptr) {}
	public FWGroundConstraint(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public FWGroundConstraint(double w, Vec3d n) { _this = SprExport.Spr_new_FWGroundConstraint_10(w, n); _flag = true; }
	~FWGroundConstraint() { if (_flag) { SprExport.Spr_delete_FWGroundConstraint(_this); _flag = false; } }
	public Vec3d cNormal {
	    get { return new Vec3d(SprExport.Spr_FWGroundConstraint_addr_cNormal(_this)); }
	    set { SprExport.Spr_FWGroundConstraint_set_cNormal(_this, value); }
	}
	public PHSolidIf cSolid {
	    get { return new PHSolidIf(SprExport.Spr_FWGroundConstraint_get_cSolid(_this)); }
	    set { SprExport.Spr_FWGroundConstraint_set_cSolid(_this, value); }
	}
	public Posed initialPose {
	    get { return new Posed(SprExport.Spr_FWGroundConstraint_addr_initialPose(_this)); }
	    set { SprExport.Spr_FWGroundConstraint_set_initialPose(_this, value); }
	}
	public double cWeight {
	    get { return SprExport.Spr_FWGroundConstraint_get_cWeight(_this); }
	    set { SprExport.Spr_FWGroundConstraint_set_cWeight(_this, value); }
	}
	public Vec3d contactForce {
	    get { return new Vec3d(SprExport.Spr_FWGroundConstraint_addr_contactForce(_this)); }
	    set { SprExport.Spr_FWGroundConstraint_set_contactForce(_this, value); }
	}
	public Vec3d contactPoint {
	    get { return new Vec3d(SprExport.Spr_FWGroundConstraint_addr_contactPoint(_this)); }
	    set { SprExport.Spr_FWGroundConstraint_set_contactPoint(_this, value); }
	}
	public double CalcEvalFunc() {
	    double result = (double) SprExport.Spr_FWGroundConstraint_CalcEvalFunc((IntPtr) _this);
	    return result;
	}
	public void Init() {
	    SprExport.Spr_FWGroundConstraint_Init((IntPtr) _this);
	}
    }
    public partial class FWUngroundedConstraint : CsObject {
	public FWUngroundedConstraint() { _this = SprExport.Spr_new_FWUngroundedConstraint(); _flag = true; }
	public FWUngroundedConstraint(IntPtr ptr) : base(ptr) {}
	public FWUngroundedConstraint(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public FWUngroundedConstraint(double w, Vec3i a, Vec3d n) { _this = SprExport.Spr_new_FWUngroundedConstraint_9(w, a, n); _flag = true; }
	public FWUngroundedConstraint(double w, Vec3i a) { _this = SprExport.Spr_new_FWUngroundedConstraint_10(w, a); _flag = true; }
	~FWUngroundedConstraint() { if (_flag) { SprExport.Spr_delete_FWUngroundedConstraint(_this); _flag = false; } }
	public Vec3i cAxis {
	    get { return new Vec3i(SprExport.Spr_FWUngroundedConstraint_addr_cAxis(_this)); }
	    set { SprExport.Spr_FWUngroundedConstraint_set_cAxis(_this, value); }
	}
	public Vec3d normal {
	    get { return new Vec3d(SprExport.Spr_FWUngroundedConstraint_addr_normal(_this)); }
	    set { SprExport.Spr_FWUngroundedConstraint_set_normal(_this, value); }
	}
	public PHSolidIf cSolid {
	    get { return new PHSolidIf(SprExport.Spr_FWUngroundedConstraint_get_cSolid(_this)); }
	    set { SprExport.Spr_FWUngroundedConstraint_set_cSolid(_this, value); }
	}
	public Posed initialPose {
	    get { return new Posed(SprExport.Spr_FWUngroundedConstraint_addr_initialPose(_this)); }
	    set { SprExport.Spr_FWUngroundedConstraint_set_initialPose(_this, value); }
	}
	public double cWeight {
	    get { return SprExport.Spr_FWUngroundedConstraint_get_cWeight(_this); }
	    set { SprExport.Spr_FWUngroundedConstraint_set_cWeight(_this, value); }
	}
	public double CalcEvalFunc() {
	    double result = (double) SprExport.Spr_FWUngroundedConstraint_CalcEvalFunc((IntPtr) _this);
	    return result;
	}
	public void Init() {
	    SprExport.Spr_FWUngroundedConstraint_Init((IntPtr) _this);
	}
    }
    public partial class JointPos : CsObject {
	public JointPos() { _this = SprExport.Spr_new_JointPos(); _flag = true; }
	public JointPos(IntPtr ptr) : base(ptr) {}
	public JointPos(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public JointPos(Quaterniond q) { _this = SprExport.Spr_new_JointPos_4(q); _flag = true; }
	public JointPos(double a) { _this = SprExport.Spr_new_JointPos_5(a); _flag = true; }
	~JointPos() { if (_flag) { SprExport.Spr_delete_JointPos(_this); _flag = false; } }
	public Quaterniond ori {
	    get { return new Quaterniond(SprExport.Spr_JointPos_addr_ori(_this)); }
	    set { SprExport.Spr_JointPos_set_ori(_this, value); }
	}
	public double angle {
	    get { return SprExport.Spr_JointPos_get_angle(_this); }
	    set { SprExport.Spr_JointPos_set_angle(_this, value); }
	}
    }
    public partial class FWObjectiveValues : CsObject {
	public FWObjectiveValues() { _this = SprExport.Spr_new_FWObjectiveValues(); _flag = true; }
	public FWObjectiveValues(IntPtr ptr) : base(ptr) {}
	public FWObjectiveValues(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWObjectiveValues() { if (_flag) { SprExport.Spr_delete_FWObjectiveValues(_this); _flag = false; } }
	public double errorvalue {
	    get { return SprExport.Spr_FWObjectiveValues_get_errorvalue(_this); }
	    set { SprExport.Spr_FWObjectiveValues_set_errorvalue(_this, value); }
	}
	public double torquevalue {
	    get { return SprExport.Spr_FWObjectiveValues_get_torquevalue(_this); }
	    set { SprExport.Spr_FWObjectiveValues_set_torquevalue(_this, value); }
	}
	public double stabilityvalue {
	    get { return SprExport.Spr_FWObjectiveValues_get_stabilityvalue(_this); }
	    set { SprExport.Spr_FWObjectiveValues_set_stabilityvalue(_this, value); }
	}
	public double groundvalue {
	    get { return SprExport.Spr_FWObjectiveValues_get_groundvalue(_this); }
	    set { SprExport.Spr_FWObjectiveValues_set_groundvalue(_this, value); }
	}
	public double ungroundedvalue {
	    get { return SprExport.Spr_FWObjectiveValues_get_ungroundedvalue(_this); }
	    set { SprExport.Spr_FWObjectiveValues_set_ungroundedvalue(_this, value); }
	}
	public double centervalue {
	    get { return SprExport.Spr_FWObjectiveValues_get_centervalue(_this); }
	    set { SprExport.Spr_FWObjectiveValues_set_centervalue(_this, value); }
	}
	public double initialorivalue {
	    get { return SprExport.Spr_FWObjectiveValues_get_initialorivalue(_this); }
	    set { SprExport.Spr_FWObjectiveValues_set_initialorivalue(_this, value); }
	}
    }
    public partial class FWOptimizerDesc : CsObject {
	public FWOptimizerDesc() { _this = SprExport.Spr_new_FWOptimizerDesc(); _flag = true; }
	public FWOptimizerDesc(IntPtr ptr) : base(ptr) {}
	public FWOptimizerDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWOptimizerDesc() { if (_flag) { SprExport.Spr_delete_FWOptimizerDesc(_this); _flag = false; } }
	public double ixstart {
	    get { return SprExport.Spr_FWOptimizerDesc_get_ixstart(_this); }
	    set { SprExport.Spr_FWOptimizerDesc_set_ixstart(_this, value); }
	}
	public double istddev {
	    get { return SprExport.Spr_FWOptimizerDesc_get_istddev(_this); }
	    set { SprExport.Spr_FWOptimizerDesc_set_istddev(_this, value); }
	}
	public double iTolFun {
	    get { return SprExport.Spr_FWOptimizerDesc_get_iTolFun(_this); }
	    set { SprExport.Spr_FWOptimizerDesc_set_iTolFun(_this, value); }
	}
	public double ilambda {
	    get { return SprExport.Spr_FWOptimizerDesc_get_ilambda(_this); }
	    set { SprExport.Spr_FWOptimizerDesc_set_ilambda(_this, value); }
	}
	public double iMaxIter {
	    get { return SprExport.Spr_FWOptimizerDesc_get_iMaxIter(_this); }
	    set { SprExport.Spr_FWOptimizerDesc_set_iMaxIter(_this, value); }
	}
    }
    [System.Serializable]
    public class FWOptimizerDescStruct : CsObject {
        public FWOptimizerDescStruct() {
            FWOptimizerDesc desc = new FWOptimizerDesc();
            ApplyFrom(desc, false);
        }
	public double ixstart;
	public double istddev;
	public double iTolFun;
	public double ilambda;
	public double iMaxIter;
// _[Find class node: 2916] FWOptimizerDesc
	public void ApplyTo(FWOptimizerDesc r, bool apply_to_base_class=true) {
		r.ixstart = ixstart;
		r.istddev = istddev;
		r.iTolFun = iTolFun;
		r.ilambda = ilambda;
		r.iMaxIter = iMaxIter;
	}
	public void ApplyFrom(FWOptimizerDesc r, bool apply_to_base_class=true) {
		ixstart = r.ixstart;
		istddev = r.istddev;
		iTolFun = r.iTolFun;
		ilambda = r.ilambda;
		iMaxIter = r.iMaxIter;
	}
	public static implicit operator FWOptimizerDesc(FWOptimizerDescStruct m) {
	    FWOptimizerDesc r = new FWOptimizerDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWOptimizerDescStruct(FWOptimizerDesc r) {
	    FWOptimizerDescStruct m = new FWOptimizerDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWStaticTorqueOptimizerDesc : FWOptimizerDesc {
	public FWStaticTorqueOptimizerDesc() { _this = SprExport.Spr_new_FWStaticTorqueOptimizerDesc(); _flag = true; }
	public FWStaticTorqueOptimizerDesc(IntPtr ptr) : base(ptr) {}
	public FWStaticTorqueOptimizerDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FWStaticTorqueOptimizerDesc() { if (_flag) { SprExport.Spr_delete_FWStaticTorqueOptimizerDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class FWStaticTorqueOptimizerDescStruct : FWOptimizerDescStruct {
        public FWStaticTorqueOptimizerDescStruct() {
            FWStaticTorqueOptimizerDesc desc = new FWStaticTorqueOptimizerDesc();
            ApplyFrom(desc, true);
        }
// _[Find class node: 2916] FWStaticTorqueOptimizerDesc
	public void ApplyTo(FWStaticTorqueOptimizerDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyTo((FWOptimizerDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(FWStaticTorqueOptimizerDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyFrom((FWOptimizerDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator FWStaticTorqueOptimizerDesc(FWStaticTorqueOptimizerDescStruct m) {
	    FWStaticTorqueOptimizerDesc r = new FWStaticTorqueOptimizerDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FWStaticTorqueOptimizerDescStruct(FWStaticTorqueOptimizerDesc r) {
	    FWStaticTorqueOptimizerDescStruct m = new FWStaticTorqueOptimizerDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FWObjectIf : SceneObjectIf {
	public FWObjectIf() { _this = SprExport.Spr_new_FWObjectIf(); _flag = true; }
	public FWObjectIf(IntPtr ptr) : base(ptr) {}
	public FWObjectIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWObjectIf(CsCastObject target) {
		return (target._info.Inherit(FWObjectIf.GetIfInfoStatic()) ? new FWObjectIf(target._this, target._flag) : null);
	}
	~FWObjectIf() { if (_flag) { SprExport.Spr_delete_FWObjectIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWObjectIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWObjectIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWObjectIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWObjectIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public PHSolidIf GetPHSolid() {
	    IntPtr ptr = SprExport.Spr_FWObjectIf_GetPHSolid((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHSolidIf obj = new PHSolidIf(ptr);
            return obj;
	}
	public void SetPHSolid(PHSolidIf s) {
	    SprExport.Spr_FWObjectIf_SetPHSolid((IntPtr) _this, (IntPtr) s);
	}
	public GRFrameIf GetGRFrame() {
	    IntPtr ptr = SprExport.Spr_FWObjectIf_GetGRFrame((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRFrameIf obj = new GRFrameIf(ptr);
            return obj;
	}
	public void SetGRFrame(GRFrameIf f) {
	    SprExport.Spr_FWObjectIf_SetGRFrame((IntPtr) _this, (IntPtr) f);
	}
	public PHJointIf GetPHJoint() {
	    IntPtr ptr = SprExport.Spr_FWObjectIf_GetPHJoint((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHJointIf obj = new PHJointIf(ptr);
            return obj;
	}
	public void SetPHJoint(PHJointIf j) {
	    SprExport.Spr_FWObjectIf_SetPHJoint((IntPtr) _this, (IntPtr) j);
	}
	public GRFrameIf GetChildFrame() {
	    IntPtr ptr = SprExport.Spr_FWObjectIf_GetChildFrame((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRFrameIf obj = new GRFrameIf(ptr);
            return obj;
	}
	public void SetChildFrame(GRFrameIf f) {
	    SprExport.Spr_FWObjectIf_SetChildFrame((IntPtr) _this, (IntPtr) f);
	}
	public void SetSyncSource(FWObjectDesc.FWObjectSyncSource syncSrc) {
	    SprExport.Spr_FWObjectIf_SetSyncSource((IntPtr) _this, (int) syncSrc);
	}
	public FWObjectDesc.FWObjectSyncSource GetSyncSource() {
	    int result = SprExport.Spr_FWObjectIf_GetSyncSource((IntPtr) _this);
            return (FWObjectDesc.FWObjectSyncSource) result;
	}
	public void EnableAbsolute(bool bAbs) {
	    SprExport.Spr_FWObjectIf_EnableAbsolute((IntPtr) _this, (bool) bAbs);
	}
	public bool IsAbsolute() {
	    char ret = SprExport.Spr_FWObjectIf_IsAbsolute((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public void GenerateCDMesh(GRFrameIf frame, PHMaterial mat) {
	    SprExport.Spr_FWObjectIf_GenerateCDMesh((IntPtr) _this, (IntPtr) frame, (IntPtr) mat);
	}
	public void GenerateCDMesh(GRFrameIf frame) {
	    SprExport.Spr_FWObjectIf_GenerateCDMesh_1((IntPtr) _this, (IntPtr) frame);
	}
	public void GenerateCDMesh() {
	    SprExport.Spr_FWObjectIf_GenerateCDMesh_2((IntPtr) _this);
	}
	public void Sync() {
	    SprExport.Spr_FWObjectIf_Sync((IntPtr) _this);
	}
    }
    public partial class FWOpObjIf : FWObjectIf {
	public FWOpObjIf() { _this = SprExport.Spr_new_FWOpObjIf(); _flag = true; }
	public FWOpObjIf(IntPtr ptr) : base(ptr) {}
	public FWOpObjIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWOpObjIf(CsCastObject target) {
		return (target._info.Inherit(FWOpObjIf.GetIfInfoStatic()) ? new FWOpObjIf(target._this, target._flag) : null);
	}
	~FWOpObjIf() { if (_flag) { SprExport.Spr_delete_FWOpObjIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWOpObjIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWOpObjIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWOpObjIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWOpObjIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void Blend() {
	    SprExport.Spr_FWOpObjIf_Blend((IntPtr) _this);
	}
	public ulong NChildObject() {
	    ulong result = (ulong) SprExport.Spr_FWOpObjIf_NChildObject((IntPtr) _this);
	    return result;
	}
	public ObjectIf GetChildObject(ulong pos) {
	    IntPtr ptr = SprExport.Spr_FWOpObjIf_GetChildObject((IntPtr) _this, (ulong) pos);
            if (ptr == IntPtr.Zero) { return null; } 
            ObjectIf obj = new ObjectIf(ptr);
            if (obj.GetIfInfo() == FWWinBaseIf.GetIfInfoStatic()) { return new FWWinBaseIf(ptr); }
            if (obj.GetIfInfo() == FWOptimizerIf.GetIfInfoStatic()) { return new FWOptimizerIf(ptr); }
            if (obj.GetIfInfo() == FWControlIf.GetIfInfoStatic()) { return new FWControlIf(ptr); }
            if (obj.GetIfInfo() == FWDialogIf.GetIfInfoStatic()) { return new FWDialogIf(ptr); }
            if (obj.GetIfInfo() == FWWinIf.GetIfInfoStatic()) { return new FWWinIf(ptr); }
            if (obj.GetIfInfo() == FWPanelIf.GetIfInfoStatic()) { return new FWPanelIf(ptr); }
            if (obj.GetIfInfo() == FWButtonIf.GetIfInfoStatic()) { return new FWButtonIf(ptr); }
            if (obj.GetIfInfo() == FWStaticTextIf.GetIfInfoStatic()) { return new FWStaticTextIf(ptr); }
            if (obj.GetIfInfo() == FWTextBoxIf.GetIfInfoStatic()) { return new FWTextBoxIf(ptr); }
            if (obj.GetIfInfo() == FWListBoxIf.GetIfInfoStatic()) { return new FWListBoxIf(ptr); }
            if (obj.GetIfInfo() == FWRotationControlIf.GetIfInfoStatic()) { return new FWRotationControlIf(ptr); }
            if (obj.GetIfInfo() == FWTranslationControlIf.GetIfInfoStatic()) { return new FWTranslationControlIf(ptr); }
            if (obj.GetIfInfo() == FWStaticTorqueOptimizerIf.GetIfInfoStatic()) { return new FWStaticTorqueOptimizerIf(ptr); }
            return obj;
	}
	public bool AddChildObject(ObjectIf o) {
	    char ret = SprExport.Spr_FWOpObjIf_AddChildObject((IntPtr) _this, (IntPtr) o);
	    return (ret == 0) ? false : true;
	}
	public void CreateOpObjWithRadius(float r) {
	    SprExport.Spr_FWOpObjIf_CreateOpObjWithRadius((IntPtr) _this, (float) r);
	}
	public void CreateOpObj() {
	    SprExport.Spr_FWOpObjIf_CreateOpObj((IntPtr) _this);
	}
	public ObjectIf GetOpObj() {
	    IntPtr ptr = SprExport.Spr_FWOpObjIf_GetOpObj((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            ObjectIf obj = new ObjectIf(ptr);
            if (obj.GetIfInfo() == FWWinBaseIf.GetIfInfoStatic()) { return new FWWinBaseIf(ptr); }
            if (obj.GetIfInfo() == FWOptimizerIf.GetIfInfoStatic()) { return new FWOptimizerIf(ptr); }
            if (obj.GetIfInfo() == FWControlIf.GetIfInfoStatic()) { return new FWControlIf(ptr); }
            if (obj.GetIfInfo() == FWDialogIf.GetIfInfoStatic()) { return new FWDialogIf(ptr); }
            if (obj.GetIfInfo() == FWWinIf.GetIfInfoStatic()) { return new FWWinIf(ptr); }
            if (obj.GetIfInfo() == FWPanelIf.GetIfInfoStatic()) { return new FWPanelIf(ptr); }
            if (obj.GetIfInfo() == FWButtonIf.GetIfInfoStatic()) { return new FWButtonIf(ptr); }
            if (obj.GetIfInfo() == FWStaticTextIf.GetIfInfoStatic()) { return new FWStaticTextIf(ptr); }
            if (obj.GetIfInfo() == FWTextBoxIf.GetIfInfoStatic()) { return new FWTextBoxIf(ptr); }
            if (obj.GetIfInfo() == FWListBoxIf.GetIfInfoStatic()) { return new FWListBoxIf(ptr); }
            if (obj.GetIfInfo() == FWRotationControlIf.GetIfInfoStatic()) { return new FWRotationControlIf(ptr); }
            if (obj.GetIfInfo() == FWTranslationControlIf.GetIfInfoStatic()) { return new FWTranslationControlIf(ptr); }
            if (obj.GetIfInfo() == FWStaticTorqueOptimizerIf.GetIfInfoStatic()) { return new FWStaticTorqueOptimizerIf(ptr); }
            return obj;
	}
	public ObjectIf GetGRMesh() {
	    IntPtr ptr = SprExport.Spr_FWOpObjIf_GetGRMesh((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            ObjectIf obj = new ObjectIf(ptr);
            if (obj.GetIfInfo() == FWWinBaseIf.GetIfInfoStatic()) { return new FWWinBaseIf(ptr); }
            if (obj.GetIfInfo() == FWOptimizerIf.GetIfInfoStatic()) { return new FWOptimizerIf(ptr); }
            if (obj.GetIfInfo() == FWControlIf.GetIfInfoStatic()) { return new FWControlIf(ptr); }
            if (obj.GetIfInfo() == FWDialogIf.GetIfInfoStatic()) { return new FWDialogIf(ptr); }
            if (obj.GetIfInfo() == FWWinIf.GetIfInfoStatic()) { return new FWWinIf(ptr); }
            if (obj.GetIfInfo() == FWPanelIf.GetIfInfoStatic()) { return new FWPanelIf(ptr); }
            if (obj.GetIfInfo() == FWButtonIf.GetIfInfoStatic()) { return new FWButtonIf(ptr); }
            if (obj.GetIfInfo() == FWStaticTextIf.GetIfInfoStatic()) { return new FWStaticTextIf(ptr); }
            if (obj.GetIfInfo() == FWTextBoxIf.GetIfInfoStatic()) { return new FWTextBoxIf(ptr); }
            if (obj.GetIfInfo() == FWListBoxIf.GetIfInfoStatic()) { return new FWListBoxIf(ptr); }
            if (obj.GetIfInfo() == FWRotationControlIf.GetIfInfoStatic()) { return new FWRotationControlIf(ptr); }
            if (obj.GetIfInfo() == FWTranslationControlIf.GetIfInfoStatic()) { return new FWTranslationControlIf(ptr); }
            if (obj.GetIfInfo() == FWStaticTorqueOptimizerIf.GetIfInfoStatic()) { return new FWStaticTorqueOptimizerIf(ptr); }
            return obj;
	}
    }
    public partial class FWFemMeshIf : FWObjectIf {
	public FWFemMeshIf() { _this = SprExport.Spr_new_FWFemMeshIf(); _flag = true; }
	public FWFemMeshIf(IntPtr ptr) : base(ptr) {}
	public FWFemMeshIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWFemMeshIf(CsCastObject target) {
		return (target._info.Inherit(FWFemMeshIf.GetIfInfoStatic()) ? new FWFemMeshIf(target._this, target._flag) : null);
	}
	~FWFemMeshIf() { if (_flag) { SprExport.Spr_delete_FWFemMeshIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWFemMeshIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWFemMeshIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWFemMeshIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWFemMeshIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public PHFemMeshIf GetPHMesh() {
	    IntPtr ptr = SprExport.Spr_FWFemMeshIf_GetPHMesh((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHFemMeshIf obj = new PHFemMeshIf(ptr);
            return obj;
	}
	public void DrawIHBorderXZPlane(bool sw) {
	    SprExport.Spr_FWFemMeshIf_DrawIHBorderXZPlane((IntPtr) _this, (bool) sw);
	}
	public void DrawFaceEdge() {
	    SprExport.Spr_FWFemMeshIf_DrawFaceEdge((IntPtr) _this);
	}
	public void SetTexmode(uint mode) {
	    SprExport.Spr_FWFemMeshIf_SetTexmode((IntPtr) _this, (uint) mode);
	}
    }
    public partial class FWFemMeshNewIf : FWObjectIf {
	public FWFemMeshNewIf() { _this = SprExport.Spr_new_FWFemMeshNewIf(); _flag = true; }
	public FWFemMeshNewIf(IntPtr ptr) : base(ptr) {}
	public FWFemMeshNewIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWFemMeshNewIf(CsCastObject target) {
		return (target._info.Inherit(FWFemMeshNewIf.GetIfInfoStatic()) ? new FWFemMeshNewIf(target._this, target._flag) : null);
	}
	~FWFemMeshNewIf() { if (_flag) { SprExport.Spr_delete_FWFemMeshNewIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWFemMeshNewIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWFemMeshNewIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWFemMeshNewIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWFemMeshNewIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public PHFemMeshNewIf GetPHFemMesh() {
	    IntPtr ptr = SprExport.Spr_FWFemMeshNewIf_GetPHFemMesh((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHFemMeshNewIf obj = new PHFemMeshNewIf(ptr);
            return obj;
	}
	public void SetTexmode(uint mode) {
	    SprExport.Spr_FWFemMeshNewIf_SetTexmode((IntPtr) _this, (uint) mode);
	}
	public void EnableDrawEdgeCW(bool flag) {
	    SprExport.Spr_FWFemMeshNewIf_EnableDrawEdgeCW((IntPtr) _this, (bool) flag);
	}
	public void Settexmode1Map(float temp) {
	    SprExport.Spr_FWFemMeshNewIf_Settexmode1Map((IntPtr) _this, (float) temp);
	}
    }
    public partial class FWHapticPointerIf : SceneObjectIf {
	public FWHapticPointerIf() { _this = SprExport.Spr_new_FWHapticPointerIf(); _flag = true; }
	public FWHapticPointerIf(IntPtr ptr) : base(ptr) {}
	public FWHapticPointerIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWHapticPointerIf(CsCastObject target) {
		return (target._info.Inherit(FWHapticPointerIf.GetIfInfoStatic()) ? new FWHapticPointerIf(target._this, target._flag) : null);
	}
	~FWHapticPointerIf() { if (_flag) { SprExport.Spr_delete_FWHapticPointerIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWHapticPointerIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWHapticPointerIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWHapticPointerIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWHapticPointerIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void SetPHHapticPointer(PHHapticPointerIf hpGlobal) {
	    SprExport.Spr_FWHapticPointerIf_SetPHHapticPointer((IntPtr) _this, (IntPtr) hpGlobal);
	}
	public PHHapticPointerIf GetPHHapticPointer() {
	    IntPtr ptr = SprExport.Spr_FWHapticPointerIf_GetPHHapticPointer((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHHapticPointerIf obj = new PHHapticPointerIf(ptr);
            return obj;
	}
	public void SetHumanInterface(HIBaseIf hi) {
	    SprExport.Spr_FWHapticPointerIf_SetHumanInterface((IntPtr) _this, (IntPtr) hi);
	}
	public HIBaseIf GetHumanInterface() {
	    IntPtr ptr = SprExport.Spr_FWHapticPointerIf_GetHumanInterface((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            HIBaseIf obj = new HIBaseIf(ptr);
            return obj;
	}
    }
    public partial class FWSceneIf : SceneIf {
	public FWSceneIf() { _this = SprExport.Spr_new_FWSceneIf(); _flag = true; }
	public FWSceneIf(IntPtr ptr) : base(ptr) {}
	public FWSceneIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWSceneIf(CsCastObject target) {
		return (target._info.Inherit(FWSceneIf.GetIfInfoStatic()) ? new FWSceneIf(target._this, target._flag) : null);
	}
	~FWSceneIf() { if (_flag) { SprExport.Spr_delete_FWSceneIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWSceneIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWSceneIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWSceneIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWSceneIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public FWSdkIf GetSdk() {
	    IntPtr ptr = SprExport.Spr_FWSceneIf_GetSdk((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWSdkIf obj = new FWSdkIf(ptr);
            return obj;
	}
	public PHSceneIf GetPHScene() {
	    IntPtr ptr = SprExport.Spr_FWSceneIf_GetPHScene((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHSceneIf obj = new PHSceneIf(ptr);
            return obj;
	}
	public void SetPHScene(PHSceneIf s) {
	    SprExport.Spr_FWSceneIf_SetPHScene((IntPtr) _this, (IntPtr) s);
	}
	public GRSceneIf GetGRScene() {
	    IntPtr ptr = SprExport.Spr_FWSceneIf_GetGRScene((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRSceneIf obj = new GRSceneIf(ptr);
            return obj;
	}
	public void SetGRScene(GRSceneIf s) {
	    SprExport.Spr_FWSceneIf_SetGRScene((IntPtr) _this, (IntPtr) s);
	}
	public FWObjectIf CreateFWObject() {
	    IntPtr ptr = SprExport.Spr_FWSceneIf_CreateFWObject((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWObjectIf obj = new FWObjectIf(ptr);
            if (obj.GetIfInfo() == FWOpObjIf.GetIfInfoStatic()) { return new FWOpObjIf(ptr); }
            if (obj.GetIfInfo() == FWFemMeshIf.GetIfInfoStatic()) { return new FWFemMeshIf(ptr); }
            if (obj.GetIfInfo() == FWFemMeshNewIf.GetIfInfoStatic()) { return new FWFemMeshNewIf(ptr); }
            return obj;
	}
	public int NObject() {
	    int result = (int) SprExport.Spr_FWSceneIf_NObject((IntPtr) _this);
	    return result;
	}
	public FWObjectIf GetObject(int i) {
	    IntPtr ptr = SprExport.Spr_FWSceneIf_GetObject((IntPtr) _this, (int) i);
            if (ptr == IntPtr.Zero) { return null; } 
            FWObjectIf obj = new FWObjectIf(ptr);
            if (obj.GetIfInfo() == FWOpObjIf.GetIfInfoStatic()) { return new FWOpObjIf(ptr); }
            if (obj.GetIfInfo() == FWFemMeshIf.GetIfInfoStatic()) { return new FWFemMeshIf(ptr); }
            if (obj.GetIfInfo() == FWFemMeshNewIf.GetIfInfoStatic()) { return new FWFemMeshNewIf(ptr); }
            return obj;
	}
	public FWObjectIf GetObjects() {
	    IntPtr ptr = SprExport.Spr_FWSceneIf_GetObjects((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWObjectIf obj = new FWObjectIf(ptr);
            if (obj.GetIfInfo() == FWOpObjIf.GetIfInfoStatic()) { return new FWOpObjIf(ptr); }
            if (obj.GetIfInfo() == FWFemMeshIf.GetIfInfoStatic()) { return new FWFemMeshIf(ptr); }
            if (obj.GetIfInfo() == FWFemMeshNewIf.GetIfInfoStatic()) { return new FWFemMeshNewIf(ptr); }
            return obj;
	}
	public void Sync() {
	    SprExport.Spr_FWSceneIf_Sync((IntPtr) _this);
	}
	public void Step() {
	    SprExport.Spr_FWSceneIf_Step((IntPtr) _this);
	}
	public void Draw(GRRenderIf grRender, bool debug) {
	    SprExport.Spr_FWSceneIf_Draw((IntPtr) _this, (IntPtr) grRender, (bool) debug);
	}
	public void Draw(GRRenderIf grRender) {
	    SprExport.Spr_FWSceneIf_Draw_1((IntPtr) _this, (IntPtr) grRender);
	}
	public void DrawPHScene(GRRenderIf render) {
	    SprExport.Spr_FWSceneIf_DrawPHScene((IntPtr) _this, (IntPtr) render);
	}
	public void DrawSolid(GRRenderIf render, PHSolidIf solid, bool solid_or_wire) {
	    SprExport.Spr_FWSceneIf_DrawSolid((IntPtr) _this, (IntPtr) render, (IntPtr) solid, (bool) solid_or_wire);
	}
	public void DrawShape(GRRenderIf render, CDShapeIf shape, bool solid) {
	    SprExport.Spr_FWSceneIf_DrawShape((IntPtr) _this, (IntPtr) render, (IntPtr) shape, (bool) solid);
	}
	public void DrawConstraint(GRRenderIf render, PHConstraintIf con) {
	    SprExport.Spr_FWSceneIf_DrawConstraint((IntPtr) _this, (IntPtr) render, (IntPtr) con);
	}
	public void DrawContact(GRRenderIf render, PHContactPointIf con) {
	    SprExport.Spr_FWSceneIf_DrawContact((IntPtr) _this, (IntPtr) render, (IntPtr) con);
	}
	public void DrawIK(GRRenderIf render, PHIKEngineIf ikEngine) {
	    SprExport.Spr_FWSceneIf_DrawIK((IntPtr) _this, (IntPtr) render, (IntPtr) ikEngine);
	}
	public void DrawLimit(GRRenderIf render, PHConstraintIf con) {
	    SprExport.Spr_FWSceneIf_DrawLimit((IntPtr) _this, (IntPtr) render, (IntPtr) con);
	}
	public void DrawHaptic(GRRenderIf render, PHHapticEngineIf hapticEngine) {
	    SprExport.Spr_FWSceneIf_DrawHaptic((IntPtr) _this, (IntPtr) render, (IntPtr) hapticEngine);
	}
	public void SetRenderMode(bool solid, bool wire) {
	    SprExport.Spr_FWSceneIf_SetRenderMode((IntPtr) _this, (bool) solid, (bool) wire);
	}
	public void SetRenderMode(bool solid) {
	    SprExport.Spr_FWSceneIf_SetRenderMode_1((IntPtr) _this, (bool) solid);
	}
	public void SetRenderMode() {
	    SprExport.Spr_FWSceneIf_SetRenderMode_2((IntPtr) _this);
	}
	public void EnableRender(ObjectIf obj, bool enable) {
	    SprExport.Spr_FWSceneIf_EnableRender((IntPtr) _this, (IntPtr) obj, (bool) enable);
	}
	public void EnableRender(ObjectIf obj) {
	    SprExport.Spr_FWSceneIf_EnableRender_1((IntPtr) _this, (IntPtr) obj);
	}
	public void SetSolidMaterial(int mat, PHSolidIf solid) {
	    SprExport.Spr_FWSceneIf_SetSolidMaterial((IntPtr) _this, (int) mat, (IntPtr) solid);
	}
	public void SetSolidMaterial(int mat) {
	    SprExport.Spr_FWSceneIf_SetSolidMaterial_1((IntPtr) _this, (int) mat);
	}
	public void SetSolidMaterial(int mat, float alha, PHSolidIf solid) {
	    SprExport.Spr_FWSceneIf_SetSolidMaterial_2((IntPtr) _this, (int) mat, (float) alha, (IntPtr) solid);
	}
	public void SetSolidMaterial(int mat, float alha) {
	    SprExport.Spr_FWSceneIf_SetSolidMaterial_3((IntPtr) _this, (int) mat, (float) alha);
	}
	public void SetWireMaterial(int mat, PHSolidIf solid) {
	    SprExport.Spr_FWSceneIf_SetWireMaterial((IntPtr) _this, (int) mat, (IntPtr) solid);
	}
	public void SetWireMaterial(int mat) {
	    SprExport.Spr_FWSceneIf_SetWireMaterial_1((IntPtr) _this, (int) mat);
	}
	public void SetWireMaterial(int mat, float alha, PHSolidIf solid) {
	    SprExport.Spr_FWSceneIf_SetWireMaterial_2((IntPtr) _this, (int) mat, (float) alha, (IntPtr) solid);
	}
	public void SetWireMaterial(int mat, float alha) {
	    SprExport.Spr_FWSceneIf_SetWireMaterial_3((IntPtr) _this, (int) mat, (float) alha);
	}
	public void EnableRenderAxis(bool world, bool solid, bool con) {
	    SprExport.Spr_FWSceneIf_EnableRenderAxis((IntPtr) _this, (bool) world, (bool) solid, (bool) con);
	}
	public void EnableRenderAxis(bool world, bool solid) {
	    SprExport.Spr_FWSceneIf_EnableRenderAxis_1((IntPtr) _this, (bool) world, (bool) solid);
	}
	public void EnableRenderAxis(bool world) {
	    SprExport.Spr_FWSceneIf_EnableRenderAxis_2((IntPtr) _this, (bool) world);
	}
	public void EnableRenderAxis() {
	    SprExport.Spr_FWSceneIf_EnableRenderAxis_3((IntPtr) _this);
	}
	public void SetAxisMaterial(int matX, int matY, int matZ) {
	    SprExport.Spr_FWSceneIf_SetAxisMaterial((IntPtr) _this, (int) matX, (int) matY, (int) matZ);
	}
	public void SetAxisScale(float scaleWorld, float scaleSolid, float scaleCon) {
	    SprExport.Spr_FWSceneIf_SetAxisScale((IntPtr) _this, (float) scaleWorld, (float) scaleSolid, (float) scaleCon);
	}
	public void SetAxisStyle(int style) {
	    SprExport.Spr_FWSceneIf_SetAxisStyle((IntPtr) _this, (int) style);
	}
	public void EnableRenderForce(bool solid, bool constraint) {
	    SprExport.Spr_FWSceneIf_EnableRenderForce((IntPtr) _this, (bool) solid, (bool) constraint);
	}
	public void EnableRenderForce(bool solid) {
	    SprExport.Spr_FWSceneIf_EnableRenderForce_1((IntPtr) _this, (bool) solid);
	}
	public void EnableRenderForce() {
	    SprExport.Spr_FWSceneIf_EnableRenderForce_2((IntPtr) _this);
	}
	public void SetForceMaterial(int matForce, int matMoment) {
	    SprExport.Spr_FWSceneIf_SetForceMaterial((IntPtr) _this, (int) matForce, (int) matMoment);
	}
	public void SetForceScale(float scaleForce, float scaleMoment) {
	    SprExport.Spr_FWSceneIf_SetForceScale((IntPtr) _this, (float) scaleForce, (float) scaleMoment);
	}
	public void EnableRenderPHScene(bool enable) {
	    SprExport.Spr_FWSceneIf_EnableRenderPHScene((IntPtr) _this, (bool) enable);
	}
	public void EnableRenderPHScene() {
	    SprExport.Spr_FWSceneIf_EnableRenderPHScene_1((IntPtr) _this);
	}
	public void EnableRenderGRScene(bool enable) {
	    SprExport.Spr_FWSceneIf_EnableRenderGRScene((IntPtr) _this, (bool) enable);
	}
	public void EnableRenderGRScene() {
	    SprExport.Spr_FWSceneIf_EnableRenderGRScene_1((IntPtr) _this);
	}
	public void EnableRenderContact(bool enable) {
	    SprExport.Spr_FWSceneIf_EnableRenderContact((IntPtr) _this, (bool) enable);
	}
	public void EnableRenderContact() {
	    SprExport.Spr_FWSceneIf_EnableRenderContact_1((IntPtr) _this);
	}
	public void SetContactMaterial(int mat) {
	    SprExport.Spr_FWSceneIf_SetContactMaterial((IntPtr) _this, (int) mat);
	}
	public void EnableRenderBBox(bool enable) {
	    SprExport.Spr_FWSceneIf_EnableRenderBBox((IntPtr) _this, (bool) enable);
	}
	public void EnableRenderBBox() {
	    SprExport.Spr_FWSceneIf_EnableRenderBBox_1((IntPtr) _this);
	}
	public void SetLocalBBoxMaterial(int mat) {
	    SprExport.Spr_FWSceneIf_SetLocalBBoxMaterial((IntPtr) _this, (int) mat);
	}
	public void SetWorldBBoxMaterial(int mat) {
	    SprExport.Spr_FWSceneIf_SetWorldBBoxMaterial((IntPtr) _this, (int) mat);
	}
	public void EnableRenderGrid(bool x, bool y, bool z) {
	    SprExport.Spr_FWSceneIf_EnableRenderGrid((IntPtr) _this, (bool) x, (bool) y, (bool) z);
	}
	public void EnableRenderGrid(bool x, bool y) {
	    SprExport.Spr_FWSceneIf_EnableRenderGrid_1((IntPtr) _this, (bool) x, (bool) y);
	}
	public void EnableRenderGrid(bool x) {
	    SprExport.Spr_FWSceneIf_EnableRenderGrid_2((IntPtr) _this, (bool) x);
	}
	public void EnableRenderGrid() {
	    SprExport.Spr_FWSceneIf_EnableRenderGrid_3((IntPtr) _this);
	}
	public void SetGridOption(sbyte axis, float offset, float size, int slice) {
	    SprExport.Spr_FWSceneIf_SetGridOption((IntPtr) _this, (sbyte) axis, (float) offset, (float) size, (int) slice);
	}
	public void SetGridMaterial(int matX, int matY, int matZ) {
	    SprExport.Spr_FWSceneIf_SetGridMaterial((IntPtr) _this, (int) matX, (int) matY, (int) matZ);
	}
	public void EnableRenderIK(bool enable) {
	    SprExport.Spr_FWSceneIf_EnableRenderIK((IntPtr) _this, (bool) enable);
	}
	public void EnableRenderIK() {
	    SprExport.Spr_FWSceneIf_EnableRenderIK_1((IntPtr) _this);
	}
	public void SetIKMaterial(int mat) {
	    SprExport.Spr_FWSceneIf_SetIKMaterial((IntPtr) _this, (int) mat);
	}
	public void SetIKScale(float scale) {
	    SprExport.Spr_FWSceneIf_SetIKScale((IntPtr) _this, (float) scale);
	}
	public void EnableRenderLimit(bool enable) {
	    SprExport.Spr_FWSceneIf_EnableRenderLimit((IntPtr) _this, (bool) enable);
	}
	public void EnableRenderLimit() {
	    SprExport.Spr_FWSceneIf_EnableRenderLimit_1((IntPtr) _this);
	}
	public void EnableRenderHaptic(bool enable) {
	    SprExport.Spr_FWSceneIf_EnableRenderHaptic((IntPtr) _this, (bool) enable);
	}
	public void EnableRenderHaptic() {
	    SprExport.Spr_FWSceneIf_EnableRenderHaptic_1((IntPtr) _this);
	}
	public void EnableRenderFem(bool enable) {
	    SprExport.Spr_FWSceneIf_EnableRenderFem((IntPtr) _this, (bool) enable);
	}
	public void EnableRenderFem() {
	    SprExport.Spr_FWSceneIf_EnableRenderFem_1((IntPtr) _this);
	}
	public void EnableRenderSkeletonSensor(bool enable) {
	    SprExport.Spr_FWSceneIf_EnableRenderSkeletonSensor((IntPtr) _this, (bool) enable);
	}
	public void EnableRenderSkeletonSensor() {
	    SprExport.Spr_FWSceneIf_EnableRenderSkeletonSensor_1((IntPtr) _this);
	}
	public void EnableRenderOp(bool enable) {
	    SprExport.Spr_FWSceneIf_EnableRenderOp((IntPtr) _this, (bool) enable);
	}
	public void EnableRenderOp() {
	    SprExport.Spr_FWSceneIf_EnableRenderOp_1((IntPtr) _this);
	}
	public FWHapticPointerIf CreateHapticPointer() {
	    IntPtr ptr = SprExport.Spr_FWSceneIf_CreateHapticPointer((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWHapticPointerIf obj = new FWHapticPointerIf(ptr);
            return obj;
	}
	public void UpdateHapticPointers() {
	    SprExport.Spr_FWSceneIf_UpdateHapticPointers((IntPtr) _this);
	}
	public FWSkeletonSensorIf CreateSkeletonSensor(FWSkeletonSensorDesc desc) {
	    IntPtr ptr = SprExport.Spr_FWSceneIf_CreateSkeletonSensor((IntPtr) _this, (IntPtr) desc);
            if (ptr == IntPtr.Zero) { return null; } 
            FWSkeletonSensorIf obj = new FWSkeletonSensorIf(ptr);
            return obj;
	}
	public FWSkeletonSensorIf CreateSkeletonSensor() {
	    IntPtr ptr = SprExport.Spr_FWSceneIf_CreateSkeletonSensor_1((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWSkeletonSensorIf obj = new FWSkeletonSensorIf(ptr);
            return obj;
	}
	public void UpdateSkeletonSensors() {
	    SprExport.Spr_FWSceneIf_UpdateSkeletonSensors((IntPtr) _this);
	}
	public int NHapticPointers() {
	    int result = (int) SprExport.Spr_FWSceneIf_NHapticPointers((IntPtr) _this);
	    return result;
	}
	public FWHapticPointerIf GetHapticPointer(int i) {
	    IntPtr ptr = SprExport.Spr_FWSceneIf_GetHapticPointer((IntPtr) _this, (int) i);
            if (ptr == IntPtr.Zero) { return null; } 
            FWHapticPointerIf obj = new FWHapticPointerIf(ptr);
            return obj;
	}
	public FWOpHapticHandlerIf CreateOpHapticHandler() {
	    IntPtr ptr = SprExport.Spr_FWSceneIf_CreateOpHapticHandler((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWOpHapticHandlerIf obj = new FWOpHapticHandlerIf(ptr);
            return obj;
	}
	public FWOpHapticHandlerIf GetOpHapticHandler() {
	    IntPtr ptr = SprExport.Spr_FWSceneIf_GetOpHapticHandler((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWOpHapticHandlerIf obj = new FWOpHapticHandlerIf(ptr);
            return obj;
	}
	public void UpdateOpHapticHandler() {
	    SprExport.Spr_FWSceneIf_UpdateOpHapticHandler((IntPtr) _this);
	}
	public enum AxisStyle : int {
	    AXIS_LINES = 0, AXIS_ARROWS = AXIS_LINES + 1
	}
    }
    public partial class FWSdkIf : SdkIf {
	public FWSdkIf() { _this = SprExport.Spr_new_FWSdkIf(); _flag = true; }
	public FWSdkIf(IntPtr ptr) : base(ptr) {}
	public FWSdkIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWSdkIf(CsCastObject target) {
		return (target._info.Inherit(FWSdkIf.GetIfInfoStatic()) ? new FWSdkIf(target._this, target._flag) : null);
	}
	~FWSdkIf() { if (_flag) { SprExport.Spr_delete_FWSdkIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWSdkIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWSdkIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWSdkIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWSdkIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public static FWSdkIf CreateSdk() {
	    IntPtr ptr = SprExport.Spr_FWSdkIf_CreateSdk();
            if (ptr == IntPtr.Zero) { return null; } 
            FWSdkIf obj = new FWSdkIf(ptr);
            return obj;
	}
	public FWSceneIf CreateScene(PHSceneDesc phdesc, GRSceneDesc grdesc) {
	    IntPtr ptr = SprExport.Spr_FWSdkIf_CreateScene((IntPtr) _this, (IntPtr) phdesc, (IntPtr) grdesc);
            if (ptr == IntPtr.Zero) { return null; } 
            FWSceneIf obj = new FWSceneIf(ptr);
            return obj;
	}
	public FWSceneIf CreateScene(PHSceneDesc phdesc) {
	    IntPtr ptr = SprExport.Spr_FWSdkIf_CreateScene_1((IntPtr) _this, (IntPtr) phdesc);
            if (ptr == IntPtr.Zero) { return null; } 
            FWSceneIf obj = new FWSceneIf(ptr);
            return obj;
	}
	public FWSceneIf CreateScene() {
	    IntPtr ptr = SprExport.Spr_FWSdkIf_CreateScene_2((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWSceneIf obj = new FWSceneIf(ptr);
            return obj;
	}
	public int NScene() {
	    int result = (int) SprExport.Spr_FWSdkIf_NScene((IntPtr) _this);
	    return result;
	}
	public FWSceneIf GetScene(int index) {
	    IntPtr ptr = SprExport.Spr_FWSdkIf_GetScene((IntPtr) _this, (int) index);
            if (ptr == IntPtr.Zero) { return null; } 
            FWSceneIf obj = new FWSceneIf(ptr);
            return obj;
	}
	public FWSceneIf GetScene() {
	    IntPtr ptr = SprExport.Spr_FWSdkIf_GetScene_1((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWSceneIf obj = new FWSceneIf(ptr);
            return obj;
	}
	public void MergeScene(FWSceneIf scene0, FWSceneIf scene1) {
	    SprExport.Spr_FWSdkIf_MergeScene((IntPtr) _this, (IntPtr) scene0, (IntPtr) scene1);
	}
	public PHSdkIf GetPHSdk() {
	    IntPtr ptr = SprExport.Spr_FWSdkIf_GetPHSdk((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHSdkIf obj = new PHSdkIf(ptr);
            return obj;
	}
	public GRSdkIf GetGRSdk() {
	    IntPtr ptr = SprExport.Spr_FWSdkIf_GetGRSdk((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRSdkIf obj = new GRSdkIf(ptr);
            return obj;
	}
	public FISdkIf GetFISdk() {
	    IntPtr ptr = SprExport.Spr_FWSdkIf_GetFISdk((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FISdkIf obj = new FISdkIf(ptr);
            return obj;
	}
	public HISdkIf GetHISdk() {
	    IntPtr ptr = SprExport.Spr_FWSdkIf_GetHISdk((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            HISdkIf obj = new HISdkIf(ptr);
            return obj;
	}
	public bool GetDebugMode() {
	    char ret = SprExport.Spr_FWSdkIf_GetDebugMode((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public void SetDebugMode(bool debug) {
	    SprExport.Spr_FWSdkIf_SetDebugMode((IntPtr) _this, (bool) debug);
	}
	public void SetDebugMode() {
	    SprExport.Spr_FWSdkIf_SetDebugMode_1((IntPtr) _this);
	}
	public void Step() {
	    SprExport.Spr_FWSdkIf_Step((IntPtr) _this);
	}
	public void Draw() {
	    SprExport.Spr_FWSdkIf_Draw((IntPtr) _this);
	}
	public GRRenderIf GetRender() {
	    IntPtr ptr = SprExport.Spr_FWSdkIf_GetRender((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRRenderIf obj = new GRRenderIf(ptr);
            return obj;
	}
	public static void RegisterSdk() {
	    SprExport.Spr_FWSdkIf_RegisterSdk();
	}
    }
    public partial class FWSkeletonSensorIf : SceneObjectIf {
	public FWSkeletonSensorIf() { _this = SprExport.Spr_new_FWSkeletonSensorIf(); _flag = true; }
	public FWSkeletonSensorIf(IntPtr ptr) : base(ptr) {}
	public FWSkeletonSensorIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWSkeletonSensorIf(CsCastObject target) {
		return (target._info.Inherit(FWSkeletonSensorIf.GetIfInfoStatic()) ? new FWSkeletonSensorIf(target._this, target._flag) : null);
	}
	~FWSkeletonSensorIf() { if (_flag) { SprExport.Spr_delete_FWSkeletonSensorIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWSkeletonSensorIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWSkeletonSensorIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWSkeletonSensorIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWSkeletonSensorIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void Update() {
	    SprExport.Spr_FWSkeletonSensorIf_Update((IntPtr) _this);
	}
	public void SetRadius(Vec2d r) {
	    SprExport.Spr_FWSkeletonSensorIf_SetRadius((IntPtr) _this, (IntPtr) r);
	}
	public HISkeletonSensorIf GetSensor() {
	    IntPtr ptr = SprExport.Spr_FWSkeletonSensorIf_GetSensor((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            HISkeletonSensorIf obj = new HISkeletonSensorIf(ptr);
            return obj;
	}
	public int NSkeleton() {
	    int result = (int) SprExport.Spr_FWSkeletonSensorIf_NSkeleton((IntPtr) _this);
	    return result;
	}
	public PHSkeletonIf GetSkeleton(int i) {
	    IntPtr ptr = SprExport.Spr_FWSkeletonSensorIf_GetSkeleton((IntPtr) _this, (int) i);
            if (ptr == IntPtr.Zero) { return null; } 
            PHSkeletonIf obj = new PHSkeletonIf(ptr);
            return obj;
	}
    }
    public partial class FWWinBaseIf : ObjectIf {
	public FWWinBaseIf() { _this = SprExport.Spr_new_FWWinBaseIf(); _flag = true; }
	public FWWinBaseIf(IntPtr ptr) : base(ptr) {}
	public FWWinBaseIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWWinBaseIf(CsCastObject target) {
		return (target._info.Inherit(FWWinBaseIf.GetIfInfoStatic()) ? new FWWinBaseIf(target._this, target._flag) : null);
	}
	~FWWinBaseIf() { if (_flag) { SprExport.Spr_delete_FWWinBaseIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWWinBaseIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWWinBaseIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWWinBaseIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWWinBaseIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public int GetID() {
	    int result = (int) SprExport.Spr_FWWinBaseIf_GetID((IntPtr) _this);
	    return result;
	}
	public Vec2i GetPosition() {
	    IntPtr ptr = SprExport.Spr_FWWinBaseIf_GetPosition((IntPtr) _this);
            return new Vec2i(ptr, true);
	}
	public void SetPosition(int left, int top) {
	    SprExport.Spr_FWWinBaseIf_SetPosition((IntPtr) _this, (int) left, (int) top);
	}
	public Vec2i GetSize() {
	    IntPtr ptr = SprExport.Spr_FWWinBaseIf_GetSize((IntPtr) _this);
            return new Vec2i(ptr, true);
	}
	public void SetSize(int width, int height) {
	    SprExport.Spr_FWWinBaseIf_SetSize((IntPtr) _this, (int) width, (int) height);
	}
	public string GetTitle() {
	    IntPtr ptr = SprExport.Spr_FWWinBaseIf_GetTitle((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            if (bstr.Substring(bstr.Length - 1, 1) == "\0") {
                    bstr = bstr.Substring(0, bstr.Length - 1);
            }
            SprExport.Spr_FWWinBaseIf_FreeString_GetTitle(ptr);
            return bstr;
	}
	public void SetTitle(string title) {
            IntPtr remote1 = Marshal.StringToBSTR(title);
	    SprExport.Spr_FWWinBaseIf_SetTitle((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
	}
    }
    public partial class FWControlIf : FWWinBaseIf {
	public FWControlIf() { _this = SprExport.Spr_new_FWControlIf(); _flag = true; }
	public FWControlIf(IntPtr ptr) : base(ptr) {}
	public FWControlIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWControlIf(CsCastObject target) {
		return (target._info.Inherit(FWControlIf.GetIfInfoStatic()) ? new FWControlIf(target._this, target._flag) : null);
	}
	~FWControlIf() { if (_flag) { SprExport.Spr_delete_FWControlIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWControlIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWControlIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWControlIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWControlIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public string GetLabel() {
	    IntPtr ptr = SprExport.Spr_FWControlIf_GetLabel((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            if (bstr.Substring(bstr.Length - 1, 1) == "\0") {
                    bstr = bstr.Substring(0, bstr.Length - 1);
            }
            SprExport.Spr_FWControlIf_FreeString_GetLabel(ptr);
            return bstr;
	}
	public void SetLabel(string l) {
            IntPtr remote1 = Marshal.StringToBSTR(l);
	    SprExport.Spr_FWControlIf_SetLabel((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
	}
	public void SetAlign(int align) {
	    SprExport.Spr_FWControlIf_SetAlign((IntPtr) _this, (int) align);
	}
	public int GetStyle() {
	    int result = (int) SprExport.Spr_FWControlIf_GetStyle((IntPtr) _this);
	    return result;
	}
	public void SetStyle(int style) {
	    SprExport.Spr_FWControlIf_SetStyle((IntPtr) _this, (int) style);
	}
	public int GetInt() {
	    int result = (int) SprExport.Spr_FWControlIf_GetInt((IntPtr) _this);
	    return result;
	}
	public void SetInt(int val) {
	    SprExport.Spr_FWControlIf_SetInt((IntPtr) _this, (int) val);
	}
	public float GetFloat() {
	    float result = (float) SprExport.Spr_FWControlIf_GetFloat((IntPtr) _this);
	    return result;
	}
	public void SetFloat(float val) {
	    SprExport.Spr_FWControlIf_SetFloat((IntPtr) _this, (float) val);
	}
    }
    public partial class FWPanelIf : FWControlIf {
	public FWPanelIf() { _this = SprExport.Spr_new_FWPanelIf(); _flag = true; }
	public FWPanelIf(IntPtr ptr) : base(ptr) {}
	public FWPanelIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWPanelIf(CsCastObject target) {
		return (target._info.Inherit(FWPanelIf.GetIfInfoStatic()) ? new FWPanelIf(target._this, target._flag) : null);
	}
	~FWPanelIf() { if (_flag) { SprExport.Spr_delete_FWPanelIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWPanelIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWPanelIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWPanelIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWPanelIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
    public partial class FWButtonIf : FWControlIf {
	public FWButtonIf() { _this = SprExport.Spr_new_FWButtonIf(); _flag = true; }
	public FWButtonIf(IntPtr ptr) : base(ptr) {}
	public FWButtonIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWButtonIf(CsCastObject target) {
		return (target._info.Inherit(FWButtonIf.GetIfInfoStatic()) ? new FWButtonIf(target._this, target._flag) : null);
	}
	~FWButtonIf() { if (_flag) { SprExport.Spr_delete_FWButtonIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWButtonIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWButtonIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWButtonIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWButtonIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void SetChecked(bool on) {
	    SprExport.Spr_FWButtonIf_SetChecked((IntPtr) _this, (bool) on);
	}
	public void SetChecked() {
	    SprExport.Spr_FWButtonIf_SetChecked_1((IntPtr) _this);
	}
	public bool IsChecked() {
	    char ret = SprExport.Spr_FWButtonIf_IsChecked((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
    }
    public partial class FWStaticTextIf : FWControlIf {
	public FWStaticTextIf() { _this = SprExport.Spr_new_FWStaticTextIf(); _flag = true; }
	public FWStaticTextIf(IntPtr ptr) : base(ptr) {}
	public FWStaticTextIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWStaticTextIf(CsCastObject target) {
		return (target._info.Inherit(FWStaticTextIf.GetIfInfoStatic()) ? new FWStaticTextIf(target._this, target._flag) : null);
	}
	~FWStaticTextIf() { if (_flag) { SprExport.Spr_delete_FWStaticTextIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWStaticTextIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWStaticTextIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWStaticTextIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWStaticTextIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
    public partial class FWTextBoxIf : FWControlIf {
	public FWTextBoxIf() { _this = SprExport.Spr_new_FWTextBoxIf(); _flag = true; }
	public FWTextBoxIf(IntPtr ptr) : base(ptr) {}
	public FWTextBoxIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWTextBoxIf(CsCastObject target) {
		return (target._info.Inherit(FWTextBoxIf.GetIfInfoStatic()) ? new FWTextBoxIf(target._this, target._flag) : null);
	}
	~FWTextBoxIf() { if (_flag) { SprExport.Spr_delete_FWTextBoxIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWTextBoxIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWTextBoxIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWTextBoxIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWTextBoxIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void SetIntRange(int rmin, int rmax) {
	    SprExport.Spr_FWTextBoxIf_SetIntRange((IntPtr) _this, (int) rmin, (int) rmax);
	}
	public void GetIntRange(int rmin, int rmax) {
	    SprExport.Spr_FWTextBoxIf_GetIntRange((IntPtr) _this, (int) rmin, (int) rmax);
	}
	public void SetFloatRange(float rmin, float rmax) {
	    SprExport.Spr_FWTextBoxIf_SetFloatRange((IntPtr) _this, (float) rmin, (float) rmax);
	}
	public void GetFloatRange(float rmin, float rmax) {
	    SprExport.Spr_FWTextBoxIf_GetFloatRange((IntPtr) _this, (float) rmin, (float) rmax);
	}
	public string GetString() {
	    IntPtr ptr = SprExport.Spr_FWTextBoxIf_GetString((IntPtr) _this);
	    return Marshal.PtrToStringAnsi(ptr);
	}
	public void SetString(string str) {
	    SprExport.Spr_FWTextBoxIf_SetString((IntPtr) _this, (string) str);
	}
    }
    public partial class FWListBoxIf : FWControlIf {
	public FWListBoxIf() { _this = SprExport.Spr_new_FWListBoxIf(); _flag = true; }
	public FWListBoxIf(IntPtr ptr) : base(ptr) {}
	public FWListBoxIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWListBoxIf(CsCastObject target) {
		return (target._info.Inherit(FWListBoxIf.GetIfInfoStatic()) ? new FWListBoxIf(target._this, target._flag) : null);
	}
	~FWListBoxIf() { if (_flag) { SprExport.Spr_delete_FWListBoxIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWListBoxIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWListBoxIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWListBoxIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWListBoxIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void AddItem(string label) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    SprExport.Spr_FWListBoxIf_AddItem((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
	}
    }
    public partial class FWRotationControlIf : FWControlIf {
	public FWRotationControlIf() { _this = SprExport.Spr_new_FWRotationControlIf(); _flag = true; }
	public FWRotationControlIf(IntPtr ptr) : base(ptr) {}
	public FWRotationControlIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWRotationControlIf(CsCastObject target) {
		return (target._info.Inherit(FWRotationControlIf.GetIfInfoStatic()) ? new FWRotationControlIf(target._this, target._flag) : null);
	}
	~FWRotationControlIf() { if (_flag) { SprExport.Spr_delete_FWRotationControlIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWRotationControlIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWRotationControlIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWRotationControlIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWRotationControlIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public Matrix3f GetRotation() {
	    IntPtr ptr = SprExport.Spr_FWRotationControlIf_GetRotation((IntPtr) _this);
            return new Matrix3f(ptr, true);
	}
	public void SetRotation(Matrix3f rot) {
	    SprExport.Spr_FWRotationControlIf_SetRotation((IntPtr) _this, (IntPtr) rot);
	}
	public float GetDamping() {
	    float result = (float) SprExport.Spr_FWRotationControlIf_GetDamping((IntPtr) _this);
	    return result;
	}
	public void SetDamping(float d) {
	    SprExport.Spr_FWRotationControlIf_SetDamping((IntPtr) _this, (float) d);
	}
	public void Reset() {
	    SprExport.Spr_FWRotationControlIf_Reset((IntPtr) _this);
	}
    }
    public partial class FWTranslationControlIf : FWControlIf {
	public FWTranslationControlIf() { _this = SprExport.Spr_new_FWTranslationControlIf(); _flag = true; }
	public FWTranslationControlIf(IntPtr ptr) : base(ptr) {}
	public FWTranslationControlIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWTranslationControlIf(CsCastObject target) {
		return (target._info.Inherit(FWTranslationControlIf.GetIfInfoStatic()) ? new FWTranslationControlIf(target._this, target._flag) : null);
	}
	~FWTranslationControlIf() { if (_flag) { SprExport.Spr_delete_FWTranslationControlIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWTranslationControlIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWTranslationControlIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWTranslationControlIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWTranslationControlIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public Vec3f GetTranslation() {
	    IntPtr ptr = SprExport.Spr_FWTranslationControlIf_GetTranslation((IntPtr) _this);
            return new Vec3f(ptr, true);
	}
	public void SetTranslation(Vec3f p) {
	    SprExport.Spr_FWTranslationControlIf_SetTranslation((IntPtr) _this, (IntPtr) p);
	}
	public float GetSpeed() {
	    float result = (float) SprExport.Spr_FWTranslationControlIf_GetSpeed((IntPtr) _this);
	    return result;
	}
	public void SetSpeed(float sp) {
	    SprExport.Spr_FWTranslationControlIf_SetSpeed((IntPtr) _this, (float) sp);
	}
    }
    public partial class FWDialogIf : FWWinBaseIf {
	public FWDialogIf() { _this = SprExport.Spr_new_FWDialogIf(); _flag = true; }
	public FWDialogIf(IntPtr ptr) : base(ptr) {}
	public FWDialogIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWDialogIf(CsCastObject target) {
		return (target._info.Inherit(FWDialogIf.GetIfInfoStatic()) ? new FWDialogIf(target._this, target._flag) : null);
	}
	~FWDialogIf() { if (_flag) { SprExport.Spr_delete_FWDialogIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWDialogIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWDialogIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWDialogIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWDialogIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public FWButtonIf CreatePushButton(string label, FWPanelIf parent) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreatePushButton((IntPtr) _this, (IntPtr) remote1, (IntPtr) parent);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWButtonIf obj = new FWButtonIf(ptr);
            return obj;
	}
	public FWButtonIf CreatePushButton(string label) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreatePushButton_1((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWButtonIf obj = new FWButtonIf(ptr);
            return obj;
	}
	public FWButtonIf CreateCheckButton(string label, bool checked_, FWPanelIf parent) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateCheckButton((IntPtr) _this, (IntPtr) remote1, (bool) checked_, (IntPtr) parent);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWButtonIf obj = new FWButtonIf(ptr);
            return obj;
	}
	public FWButtonIf CreateCheckButton(string label, bool checked_) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateCheckButton_1((IntPtr) _this, (IntPtr) remote1, (bool) checked_);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWButtonIf obj = new FWButtonIf(ptr);
            return obj;
	}
	public FWButtonIf CreateCheckButton(string label) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateCheckButton_2((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWButtonIf obj = new FWButtonIf(ptr);
            return obj;
	}
	public FWButtonIf CreateRadioButton(string label, FWPanelIf parent) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateRadioButton((IntPtr) _this, (IntPtr) remote1, (IntPtr) parent);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWButtonIf obj = new FWButtonIf(ptr);
            return obj;
	}
	public FWButtonIf CreateRadioButton(string label) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateRadioButton_1((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWButtonIf obj = new FWButtonIf(ptr);
            return obj;
	}
	public FWStaticTextIf CreateStaticText(string text, FWPanelIf parent) {
            IntPtr remote1 = Marshal.StringToBSTR(text);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateStaticText((IntPtr) _this, (IntPtr) remote1, (IntPtr) parent);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWStaticTextIf obj = new FWStaticTextIf(ptr);
            return obj;
	}
	public FWStaticTextIf CreateStaticText(string text) {
            IntPtr remote1 = Marshal.StringToBSTR(text);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateStaticText_1((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWStaticTextIf obj = new FWStaticTextIf(ptr);
            return obj;
	}
	public FWTextBoxIf CreateTextBox(string label, string text, int style, FWPanelIf parent) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
            IntPtr remote2 = Marshal.StringToBSTR(text);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateTextBox((IntPtr) _this, (IntPtr) remote1, (IntPtr) remote2, (int) style, (IntPtr) parent);
            Marshal.FreeBSTR(remote1);
            Marshal.FreeBSTR(remote2);
            if (ptr == IntPtr.Zero) { return null; } 
            FWTextBoxIf obj = new FWTextBoxIf(ptr);
            return obj;
	}
	public FWTextBoxIf CreateTextBox(string label, string text, int style) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
            IntPtr remote2 = Marshal.StringToBSTR(text);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateTextBox_1((IntPtr) _this, (IntPtr) remote1, (IntPtr) remote2, (int) style);
            Marshal.FreeBSTR(remote1);
            Marshal.FreeBSTR(remote2);
            if (ptr == IntPtr.Zero) { return null; } 
            FWTextBoxIf obj = new FWTextBoxIf(ptr);
            return obj;
	}
	public FWTextBoxIf CreateTextBox(string label, string text) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
            IntPtr remote2 = Marshal.StringToBSTR(text);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateTextBox_2((IntPtr) _this, (IntPtr) remote1, (IntPtr) remote2);
            Marshal.FreeBSTR(remote1);
            Marshal.FreeBSTR(remote2);
            if (ptr == IntPtr.Zero) { return null; } 
            FWTextBoxIf obj = new FWTextBoxIf(ptr);
            return obj;
	}
	public FWTextBoxIf CreateTextBox(string label) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateTextBox_3((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWTextBoxIf obj = new FWTextBoxIf(ptr);
            return obj;
	}
	public FWPanelIf CreatePanel(string label, int style, FWPanelIf parent) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreatePanel((IntPtr) _this, (IntPtr) remote1, (int) style, (IntPtr) parent);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWPanelIf obj = new FWPanelIf(ptr);
            return obj;
	}
	public FWPanelIf CreatePanel(string label, int style) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreatePanel_1((IntPtr) _this, (IntPtr) remote1, (int) style);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWPanelIf obj = new FWPanelIf(ptr);
            return obj;
	}
	public FWPanelIf CreatePanel(string label) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreatePanel_2((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWPanelIf obj = new FWPanelIf(ptr);
            return obj;
	}
	public FWPanelIf CreateRadioGroup(FWPanelIf parent) {
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateRadioGroup((IntPtr) _this, (IntPtr) parent);
            if (ptr == IntPtr.Zero) { return null; } 
            FWPanelIf obj = new FWPanelIf(ptr);
            return obj;
	}
	public FWPanelIf CreateRadioGroup() {
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateRadioGroup_1((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWPanelIf obj = new FWPanelIf(ptr);
            return obj;
	}
	public FWRotationControlIf CreateRotationControl(string label, FWPanelIf parent) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateRotationControl((IntPtr) _this, (IntPtr) remote1, (IntPtr) parent);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWRotationControlIf obj = new FWRotationControlIf(ptr);
            return obj;
	}
	public FWRotationControlIf CreateRotationControl(string label) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateRotationControl_1((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWRotationControlIf obj = new FWRotationControlIf(ptr);
            return obj;
	}
	public FWTranslationControlIf CreateTranslationControl(string label, int style, FWPanelIf parent) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateTranslationControl((IntPtr) _this, (IntPtr) remote1, (int) style, (IntPtr) parent);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWTranslationControlIf obj = new FWTranslationControlIf(ptr);
            return obj;
	}
	public FWTranslationControlIf CreateTranslationControl(string label, int style) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateTranslationControl_1((IntPtr) _this, (IntPtr) remote1, (int) style);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWTranslationControlIf obj = new FWTranslationControlIf(ptr);
            return obj;
	}
	public FWTranslationControlIf CreateTranslationControl(string label) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateTranslationControl_2((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWTranslationControlIf obj = new FWTranslationControlIf(ptr);
            return obj;
	}
	public FWListBoxIf CreateListBox(string label, FWPanelIf parent) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateListBox((IntPtr) _this, (IntPtr) remote1, (IntPtr) parent);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWListBoxIf obj = new FWListBoxIf(ptr);
            return obj;
	}
	public FWListBoxIf CreateListBox(string label) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_FWDialogIf_CreateListBox_1((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FWListBoxIf obj = new FWListBoxIf(ptr);
            return obj;
	}
	public void CreateColumn(bool sep, FWPanelIf parent) {
	    SprExport.Spr_FWDialogIf_CreateColumn((IntPtr) _this, (bool) sep, (IntPtr) parent);
	}
	public void CreateColumn(bool sep) {
	    SprExport.Spr_FWDialogIf_CreateColumn_1((IntPtr) _this, (bool) sep);
	}
	public void CreateColumn() {
	    SprExport.Spr_FWDialogIf_CreateColumn_2((IntPtr) _this);
	}
	public void CreateSeparator(FWPanelIf parent) {
	    SprExport.Spr_FWDialogIf_CreateSeparator((IntPtr) _this, (IntPtr) parent);
	}
	public void CreateSeparator() {
	    SprExport.Spr_FWDialogIf_CreateSeparator_1((IntPtr) _this);
	}
    }
    public partial class FWWinIf : FWWinBaseIf {
	public FWWinIf() { _this = SprExport.Spr_new_FWWinIf(); _flag = true; }
	public FWWinIf(IntPtr ptr) : base(ptr) {}
	public FWWinIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWWinIf(CsCastObject target) {
		return (target._info.Inherit(FWWinIf.GetIfInfoStatic()) ? new FWWinIf(target._this, target._flag) : null);
	}
	~FWWinIf() { if (_flag) { SprExport.Spr_delete_FWWinIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWWinIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWWinIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWWinIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWWinIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void SetFullScreen() {
	    SprExport.Spr_FWWinIf_SetFullScreen((IntPtr) _this);
	}
	public bool GetFullScreen() {
	    char ret = SprExport.Spr_FWWinIf_GetFullScreen((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public GRRenderIf GetRender() {
	    IntPtr ptr = SprExport.Spr_FWWinIf_GetRender((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRRenderIf obj = new GRRenderIf(ptr);
            return obj;
	}
	public void SetRender(GRRenderIf data) {
	    SprExport.Spr_FWWinIf_SetRender((IntPtr) _this, (IntPtr) data);
	}
	public FWSceneIf GetScene() {
	    IntPtr ptr = SprExport.Spr_FWWinIf_GetScene((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWSceneIf obj = new FWSceneIf(ptr);
            return obj;
	}
	public void SetScene(FWSceneIf s) {
	    SprExport.Spr_FWWinIf_SetScene((IntPtr) _this, (IntPtr) s);
	}
	public DVKeyMouseIf GetKeyMouse() {
	    IntPtr ptr = SprExport.Spr_FWWinIf_GetKeyMouse((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            DVKeyMouseIf obj = new DVKeyMouseIf(ptr);
            return obj;
	}
	public void SetKeyMouse(DVKeyMouseIf dv) {
	    SprExport.Spr_FWWinIf_SetKeyMouse((IntPtr) _this, (IntPtr) dv);
	}
	public DVJoyStickIf GetJoyStick() {
	    IntPtr ptr = SprExport.Spr_FWWinIf_GetJoyStick((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            DVJoyStickIf obj = new DVJoyStickIf(ptr);
            return obj;
	}
	public void SetJoyStick(DVJoyStickIf dv) {
	    SprExport.Spr_FWWinIf_SetJoyStick((IntPtr) _this, (IntPtr) dv);
	}
	public HITrackballIf GetTrackball() {
	    IntPtr ptr = SprExport.Spr_FWWinIf_GetTrackball((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            HITrackballIf obj = new HITrackballIf(ptr);
            return obj;
	}
	public void SetTrackball(HITrackballIf dv) {
	    SprExport.Spr_FWWinIf_SetTrackball((IntPtr) _this, (IntPtr) dv);
	}
	public void SetDebugMode(bool ph_or_gr) {
	    SprExport.Spr_FWWinIf_SetDebugMode((IntPtr) _this, (bool) ph_or_gr);
	}
	public bool GetDebugMode() {
	    char ret = SprExport.Spr_FWWinIf_GetDebugMode((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public void Display() {
	    SprExport.Spr_FWWinIf_Display((IntPtr) _this);
	}
	public FWDialogIf CreateDialog(FWDialogDesc desc) {
	    IntPtr ptr = SprExport.Spr_FWWinIf_CreateDialog((IntPtr) _this, (IntPtr) desc);
            if (ptr == IntPtr.Zero) { return null; } 
            FWDialogIf obj = new FWDialogIf(ptr);
            return obj;
	}
	public FWDialogIf CreateDialog() {
	    IntPtr ptr = SprExport.Spr_FWWinIf_CreateDialog_1((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FWDialogIf obj = new FWDialogIf(ptr);
            return obj;
	}
	public void CalcViewport(int left, int top, int width, int height) {
	    SprExport.Spr_FWWinIf_CalcViewport((IntPtr) _this, (int) left, (int) top, (int) width, (int) height);
	}
    }
    public partial class FWOptimizerIf : ObjectIf {
	public FWOptimizerIf() { _this = SprExport.Spr_new_FWOptimizerIf(); _flag = true; }
	public FWOptimizerIf(IntPtr ptr) : base(ptr) {}
	public FWOptimizerIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWOptimizerIf(CsCastObject target) {
		return (target._info.Inherit(FWOptimizerIf.GetIfInfoStatic()) ? new FWOptimizerIf(target._this, target._flag) : null);
	}
	~FWOptimizerIf() { if (_flag) { SprExport.Spr_delete_FWOptimizerIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWOptimizerIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWOptimizerIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWOptimizerIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWOptimizerIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void CopyScene(PHSceneIf phSceneInput) {
	    SprExport.Spr_FWOptimizerIf_CopyScene((IntPtr) _this, (IntPtr) phSceneInput);
	}
	public PHSceneIf GetScene() {
	    IntPtr ptr = SprExport.Spr_FWOptimizerIf_GetScene((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHSceneIf obj = new PHSceneIf(ptr);
            return obj;
	}
	public void Init(int dimension) {
	    SprExport.Spr_FWOptimizerIf_Init((IntPtr) _this, (int) dimension);
	}
	public void Start() {
	    SprExport.Spr_FWOptimizerIf_Start((IntPtr) _this);
	}
	public void Abort() {
	    SprExport.Spr_FWOptimizerIf_Abort((IntPtr) _this);
	}
	public bool IsRunning() {
	    char ret = SprExport.Spr_FWOptimizerIf_IsRunning((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public void Optimize() {
	    SprExport.Spr_FWOptimizerIf_Optimize((IntPtr) _this);
	}
	public void Iterate() {
	    SprExport.Spr_FWOptimizerIf_Iterate((IntPtr) _this);
	}
	public double ApplyPop(PHSceneIf phScene, double x, int n) {
	    double result = (double) SprExport.Spr_FWOptimizerIf_ApplyPop((IntPtr) _this, (IntPtr) phScene, (double) x, (int) n);
	    return result;
	}
	public double Objective(double x, int n) {
	    double result = (double) SprExport.Spr_FWOptimizerIf_Objective((IntPtr) _this, (double) x, (int) n);
	    return result;
	}
	public int NResults() {
	    int result = (int) SprExport.Spr_FWOptimizerIf_NResults((IntPtr) _this);
	    return result;
	}
	public double GetResult(int i) {
	    double result = (double) SprExport.Spr_FWOptimizerIf_GetResult((IntPtr) _this, (int) i);
	    return result;
	}
	public double[] GetResults() {
	    IntPtr ptr = SprExport.Spr_FWOptimizerIf_GetResults((IntPtr) _this);
            int size = 1;   // no way to know array size!
            return new arraywrapper_double(ptr, size);
	}
	public double[] GetProvisionalResults() {
	    IntPtr ptr = SprExport.Spr_FWOptimizerIf_GetProvisionalResults((IntPtr) _this);
            int size = 1;   // no way to know array size!
            return new arraywrapper_double(ptr, size);
	}
	public void SetESParameters(double xs, double st, double tf, double la, double mi) {
	    SprExport.Spr_FWOptimizerIf_SetESParameters((IntPtr) _this, (double) xs, (double) st, (double) tf, (double) la, (double) mi);
	}
    }
    public partial class FWStaticTorqueOptimizerIf : FWOptimizerIf {
	public FWStaticTorqueOptimizerIf() { _this = SprExport.Spr_new_FWStaticTorqueOptimizerIf(); _flag = true; }
	public FWStaticTorqueOptimizerIf(IntPtr ptr) : base(ptr) {}
	public FWStaticTorqueOptimizerIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWStaticTorqueOptimizerIf(CsCastObject target) {
		return (target._info.Inherit(FWStaticTorqueOptimizerIf.GetIfInfoStatic()) ? new FWStaticTorqueOptimizerIf(target._this, target._flag) : null);
	}
	~FWStaticTorqueOptimizerIf() { if (_flag) { SprExport.Spr_delete_FWStaticTorqueOptimizerIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWStaticTorqueOptimizerIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWStaticTorqueOptimizerIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWStaticTorqueOptimizerIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWStaticTorqueOptimizerIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void Init() {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_Init((IntPtr) _this);
	}
	public void Iterate() {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_Iterate((IntPtr) _this);
	}
	public void ApplyResult(PHSceneIf phScene) {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_ApplyResult((IntPtr) _this, (IntPtr) phScene);
	}
	public double ApplyPop(PHSceneIf phScene, double x, int n) {
	    double result = (double) SprExport.Spr_FWStaticTorqueOptimizerIf_ApplyPop((IntPtr) _this, (IntPtr) phScene, (double) x, (int) n);
	    return result;
	}
	public double Objective(double x, int n) {
	    double result = (double) SprExport.Spr_FWStaticTorqueOptimizerIf_Objective((IntPtr) _this, (double) x, (int) n);
	    return result;
	}
	public void SetScene(PHSceneIf phSceneInput) {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_SetScene((IntPtr) _this, (IntPtr) phSceneInput);
	}
	public void Optimize() {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_Optimize((IntPtr) _this);
	}
	public bool TestForTermination() {
	    char ret = SprExport.Spr_FWStaticTorqueOptimizerIf_TestForTermination((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public void TakeFinalValue() {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_TakeFinalValue((IntPtr) _this);
	}
	public void SetErrorWeight(double v) {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_SetErrorWeight((IntPtr) _this, (double) v);
	}
	public double GetErrorWeight() {
	    double result = (double) SprExport.Spr_FWStaticTorqueOptimizerIf_GetErrorWeight((IntPtr) _this);
	    return result;
	}
	public void SetStabilityWeight(double v) {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_SetStabilityWeight((IntPtr) _this, (double) v);
	}
	public double GetStabilityWeight() {
	    double result = (double) SprExport.Spr_FWStaticTorqueOptimizerIf_GetStabilityWeight((IntPtr) _this);
	    return result;
	}
	public void SetTorqueWeight(double v) {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_SetTorqueWeight((IntPtr) _this, (double) v);
	}
	public double GetTorqueWeight() {
	    double result = (double) SprExport.Spr_FWStaticTorqueOptimizerIf_GetTorqueWeight((IntPtr) _this);
	    return result;
	}
	public void SetConstWeight(double v) {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_SetConstWeight((IntPtr) _this, (double) v);
	}
	public double GetConstWeight() {
	    double result = (double) SprExport.Spr_FWStaticTorqueOptimizerIf_GetConstWeight((IntPtr) _this);
	    return result;
	}
	public void SetGravcenterWeight(double v) {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_SetGravcenterWeight((IntPtr) _this, (double) v);
	}
	public double GetGravcenterWeight() {
	    double result = (double) SprExport.Spr_FWStaticTorqueOptimizerIf_GetGravcenterWeight((IntPtr) _this);
	    return result;
	}
	public void SetDifferentialWeight(double v) {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_SetDifferentialWeight((IntPtr) _this, (double) v);
	}
	public double GetDifferentialWeight() {
	    double result = (double) SprExport.Spr_FWStaticTorqueOptimizerIf_GetDifferentialWeight((IntPtr) _this);
	    return result;
	}
	public void AddPositionConst(FWGroundConstraint f) {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_AddPositionConst((IntPtr) _this, (IntPtr) f);
	}
	public FWGroundConstraint GetGroundConst(int n) {
	    IntPtr ptr = SprExport.Spr_FWStaticTorqueOptimizerIf_GetGroundConst((IntPtr) _this, (int) n);
            return new FWGroundConstraint(ptr, true);
	}
	public void ClearGroundConst() {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_ClearGroundConst((IntPtr) _this);
	}
	public void AddPositionConst(FWUngroundedConstraint f) {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_AddPositionConst_1((IntPtr) _this, (IntPtr) f);
	}
	public FWUngroundedConstraint GetUngroundConst(int n) {
	    IntPtr ptr = SprExport.Spr_FWStaticTorqueOptimizerIf_GetUngroundConst((IntPtr) _this, (int) n);
            return new FWUngroundedConstraint(ptr, true);
	}
	public void ClearUngroundedConst() {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_ClearUngroundedConst((IntPtr) _this);
	}
	public void SetJointWeight(PHJointIf jo, double w) {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_SetJointWeight((IntPtr) _this, (IntPtr) jo, (double) w);
	}
	public void SetESParameters(double xs, double st, double tf, double la, double mi) {
	    SprExport.Spr_FWStaticTorqueOptimizerIf_SetESParameters((IntPtr) _this, (double) xs, (double) st, (double) tf, (double) la, (double) mi);
	}
	public FWObjectiveValues GetObjectiveValues() {
	    IntPtr ptr = SprExport.Spr_FWStaticTorqueOptimizerIf_GetObjectiveValues((IntPtr) _this);
            return new FWObjectiveValues(ptr, true);
	}
	public Vec3f GetCenterOfGravity() {
	    IntPtr ptr = SprExport.Spr_FWStaticTorqueOptimizerIf_GetCenterOfGravity((IntPtr) _this);
            return new Vec3f(ptr, true);
	}
	public int NSupportPolygonVertices() {
	    int result = (int) SprExport.Spr_FWStaticTorqueOptimizerIf_NSupportPolygonVertices((IntPtr) _this);
	    return result;
	}
	public Vec3f GetSupportPolygonVerticesN(int n) {
	    IntPtr ptr = SprExport.Spr_FWStaticTorqueOptimizerIf_GetSupportPolygonVerticesN((IntPtr) _this, (int) n);
            return new Vec3f(ptr, true);
	}
    }
    public partial class FWOpHapticHandlerIf : SceneObjectIf {
	public FWOpHapticHandlerIf() { _this = SprExport.Spr_new_FWOpHapticHandlerIf(); _flag = true; }
	public FWOpHapticHandlerIf(IntPtr ptr) : base(ptr) {}
	public FWOpHapticHandlerIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FWOpHapticHandlerIf(CsCastObject target) {
		return (target._info.Inherit(FWOpHapticHandlerIf.GetIfInfoStatic()) ? new FWOpHapticHandlerIf(target._this, target._flag) : null);
	}
	~FWOpHapticHandlerIf() { if (_flag) { SprExport.Spr_delete_FWOpHapticHandlerIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FWOpHapticHandlerIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FWOpHapticHandlerIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FWOpHapticHandlerIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FWOpHapticHandlerIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void SetHapticflag(bool flag) {
	    SprExport.Spr_FWOpHapticHandlerIf_SetHapticflag((IntPtr) _this, (bool) flag);
	}
	public bool IsHapticEnabled() {
	    char ret = SprExport.Spr_FWOpHapticHandlerIf_IsHapticEnabled((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool doCalibration(float dt) {
	    char ret = SprExport.Spr_FWOpHapticHandlerIf_doCalibration((IntPtr) _this, (float) dt);
	    return (ret == 0) ? false : true;
	}
	public void SetHumanInterface(HIBaseIf hi) {
	    SprExport.Spr_FWOpHapticHandlerIf_SetHumanInterface((IntPtr) _this, (IntPtr) hi);
	}
	public HIBaseIf GetHumanInterface() {
	    IntPtr ptr = SprExport.Spr_FWOpHapticHandlerIf_GetHumanInterface((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            HIBaseIf obj = new HIBaseIf(ptr);
            return obj;
	}
	public void SetHapticTimeInterval(float dt) {
	    SprExport.Spr_FWOpHapticHandlerIf_SetHapticTimeInterval((IntPtr) _this, (float) dt);
	}
	public float GetHapticTimeInterval() {
	    float result = (float) SprExport.Spr_FWOpHapticHandlerIf_GetHapticTimeInterval((IntPtr) _this);
	    return result;
	}
    }
	public partial class IfInfoToCsType {
		public static Dictionary<IntPtr, Type> mapFramework = new Dictionary<IntPtr, Type>() {
			{FWObjectIf.GetIfInfoStatic(), typeof(FWObjectIf)},
			{FWOpObjIf.GetIfInfoStatic(), typeof(FWOpObjIf)},
			{FWFemMeshIf.GetIfInfoStatic(), typeof(FWFemMeshIf)},
			{FWFemMeshNewIf.GetIfInfoStatic(), typeof(FWFemMeshNewIf)},
			{FWHapticPointerIf.GetIfInfoStatic(), typeof(FWHapticPointerIf)},
			{FWSceneIf.GetIfInfoStatic(), typeof(FWSceneIf)},
			{FWSdkIf.GetIfInfoStatic(), typeof(FWSdkIf)},
			{FWSkeletonSensorIf.GetIfInfoStatic(), typeof(FWSkeletonSensorIf)},
			{FWWinBaseIf.GetIfInfoStatic(), typeof(FWWinBaseIf)},
			{FWControlIf.GetIfInfoStatic(), typeof(FWControlIf)},
			{FWPanelIf.GetIfInfoStatic(), typeof(FWPanelIf)},
			{FWButtonIf.GetIfInfoStatic(), typeof(FWButtonIf)},
			{FWStaticTextIf.GetIfInfoStatic(), typeof(FWStaticTextIf)},
			{FWTextBoxIf.GetIfInfoStatic(), typeof(FWTextBoxIf)},
			{FWListBoxIf.GetIfInfoStatic(), typeof(FWListBoxIf)},
			{FWRotationControlIf.GetIfInfoStatic(), typeof(FWRotationControlIf)},
			{FWTranslationControlIf.GetIfInfoStatic(), typeof(FWTranslationControlIf)},
			{FWDialogIf.GetIfInfoStatic(), typeof(FWDialogIf)},
			{FWWinIf.GetIfInfoStatic(), typeof(FWWinIf)},
			{FWOptimizerIf.GetIfInfoStatic(), typeof(FWOptimizerIf)},
			{FWStaticTorqueOptimizerIf.GetIfInfoStatic(), typeof(FWStaticTorqueOptimizerIf)},
			{FWOpHapticHandlerIf.GetIfInfoStatic(), typeof(FWOpHapticHandlerIf)},
		};
	}
}
