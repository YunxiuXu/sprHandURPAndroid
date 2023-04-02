using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
#pragma warning disable 0108
namespace SprCs {
    public partial class HIHapticDummyDesc : CsObject {
	public HIHapticDummyDesc() { _this = SprExport.Spr_new_HIHapticDummyDesc(); _flag = true; }
	public HIHapticDummyDesc(IntPtr ptr) : base(ptr) {}
	public HIHapticDummyDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~HIHapticDummyDesc() { if (_flag) { SprExport.Spr_delete_HIHapticDummyDesc(_this); _flag = false; } }
	public Posed pose {
	    get { return new Posed(SprExport.Spr_HIHapticDummyDesc_addr_pose(_this)); }
	    set { SprExport.Spr_HIHapticDummyDesc_set_pose(_this, value); }
	}
    }
    [System.Serializable]
    public class HIHapticDummyDescStruct : CsObject {
        public HIHapticDummyDescStruct() {
            HIHapticDummyDesc desc = new HIHapticDummyDesc();
            ApplyFrom(desc, false);
        }
	public PosedStruct pose;
// _[Find class node: 2916] HIHapticDummyDesc
	public void ApplyTo(HIHapticDummyDesc r, bool apply_to_base_class=true) {
		r.pose = pose;
	}
	public void ApplyFrom(HIHapticDummyDesc r, bool apply_to_base_class=true) {
		pose = r.pose;
	}
	public static implicit operator HIHapticDummyDesc(HIHapticDummyDescStruct m) {
	    HIHapticDummyDesc r = new HIHapticDummyDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator HIHapticDummyDescStruct(HIHapticDummyDesc r) {
	    HIHapticDummyDescStruct m = new HIHapticDummyDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class DVPortEnum : CsObject {
	public DVPortEnum() { _this = SprExport.Spr_new_DVPortEnum(); _flag = true; }
	public DVPortEnum(IntPtr ptr) : base(ptr) {}
	public DVPortEnum(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~DVPortEnum() { if (_flag) { SprExport.Spr_delete_DVPortEnum(_this); _flag = false; } }
	public enum TLevel : int {
	    LEVEL_LO = 0, LEVEL_HI = LEVEL_LO + 1
	}
	public enum TDir : int {
	    DIR_IN = 0, DIR_OUT = DIR_IN + 1
	}
    }
    public partial class DRUsb20SimpleDesc : CsObject {
	public DRUsb20SimpleDesc() { _this = SprExport.Spr_new_DRUsb20SimpleDesc(); _flag = true; }
	public DRUsb20SimpleDesc(IntPtr ptr) : base(ptr) {}
	public DRUsb20SimpleDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~DRUsb20SimpleDesc() { if (_flag) { SprExport.Spr_delete_DRUsb20SimpleDesc(_this); _flag = false; } }
	public int channel {
	    get { return SprExport.Spr_DRUsb20SimpleDesc_get_channel(_this); }
	    set { SprExport.Spr_DRUsb20SimpleDesc_set_channel(_this, value); }
	}
    }
    [System.Serializable]
    public class DRUsb20SimpleDescStruct : CsObject {
        public DRUsb20SimpleDescStruct() {
            DRUsb20SimpleDesc desc = new DRUsb20SimpleDesc();
            ApplyFrom(desc, false);
        }
	public int channel;
// _[Find class node: 2916] DRUsb20SimpleDesc
	public void ApplyTo(DRUsb20SimpleDesc r, bool apply_to_base_class=true) {
		r.channel = channel;
	}
	public void ApplyFrom(DRUsb20SimpleDesc r, bool apply_to_base_class=true) {
		channel = r.channel;
	}
	public static implicit operator DRUsb20SimpleDesc(DRUsb20SimpleDescStruct m) {
	    DRUsb20SimpleDesc r = new DRUsb20SimpleDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator DRUsb20SimpleDescStruct(DRUsb20SimpleDesc r) {
	    DRUsb20SimpleDescStruct m = new DRUsb20SimpleDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class DRUsb20Sh4Desc : DRUsb20SimpleDesc {
	public DRUsb20Sh4Desc() { _this = SprExport.Spr_new_DRUsb20Sh4Desc(); _flag = true; }
	public DRUsb20Sh4Desc(IntPtr ptr) : base(ptr) {}
	public DRUsb20Sh4Desc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~DRUsb20Sh4Desc() { if (_flag) { SprExport.Spr_delete_DRUsb20Sh4Desc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class DRUsb20Sh4DescStruct : DRUsb20SimpleDescStruct {
        public DRUsb20Sh4DescStruct() {
            DRUsb20Sh4Desc desc = new DRUsb20Sh4Desc();
            ApplyFrom(desc, true);
        }
// _[Find class node: 2916] DRUsb20Sh4Desc
	public void ApplyTo(DRUsb20Sh4Desc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyTo((DRUsb20SimpleDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(DRUsb20Sh4Desc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyFrom((DRUsb20SimpleDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator DRUsb20Sh4Desc(DRUsb20Sh4DescStruct m) {
	    DRUsb20Sh4Desc r = new DRUsb20Sh4Desc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator DRUsb20Sh4DescStruct(DRUsb20Sh4Desc r) {
	    DRUsb20Sh4DescStruct m = new DRUsb20Sh4DescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class DRCyUsb20Sh4Desc : DRUsb20Sh4Desc {
	public DRCyUsb20Sh4Desc() { _this = SprExport.Spr_new_DRCyUsb20Sh4Desc(); _flag = true; }
	public DRCyUsb20Sh4Desc(IntPtr ptr) : base(ptr) {}
	public DRCyUsb20Sh4Desc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~DRCyUsb20Sh4Desc() { if (_flag) { SprExport.Spr_delete_DRCyUsb20Sh4Desc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class DRCyUsb20Sh4DescStruct : DRUsb20Sh4DescStruct {
        public DRCyUsb20Sh4DescStruct() {
            DRCyUsb20Sh4Desc desc = new DRCyUsb20Sh4Desc();
            ApplyFrom(desc, true);
        }
// _[Find class node: 2916] DRCyUsb20Sh4Desc
	public void ApplyTo(DRCyUsb20Sh4Desc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyTo((DRUsb20Sh4Desc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(DRCyUsb20Sh4Desc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyFrom((DRUsb20Sh4Desc) r, apply_to_base_class);
		}
	}
	public static implicit operator DRCyUsb20Sh4Desc(DRCyUsb20Sh4DescStruct m) {
	    DRCyUsb20Sh4Desc r = new DRCyUsb20Sh4Desc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator DRCyUsb20Sh4DescStruct(DRCyUsb20Sh4Desc r) {
	    DRCyUsb20Sh4DescStruct m = new DRCyUsb20Sh4DescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class DVJoyStickMask : CsObject {
	public DVJoyStickMask() { _this = SprExport.Spr_new_DVJoyStickMask(); _flag = true; }
	public DVJoyStickMask(IntPtr ptr) : base(ptr) {}
	public DVJoyStickMask(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~DVJoyStickMask() { if (_flag) { SprExport.Spr_delete_DVJoyStickMask(_this); _flag = false; } }
    }
    public partial class DVJoyStickCallback : CsObject {
	public DVJoyStickCallback() { _this = SprExport.Spr_new_DVJoyStickCallback(); _flag = true; }
	public DVJoyStickCallback(IntPtr ptr) : base(ptr) {}
	public DVJoyStickCallback(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~DVJoyStickCallback() { if (_flag) { SprExport.Spr_delete_DVJoyStickCallback(_this); _flag = false; } }
	public bool OnUpdate(int buttonMask, int x, int y, int z) {
	    char ret = SprExport.Spr_DVJoyStickCallback_OnUpdate((IntPtr) _this, (int) buttonMask, (int) x, (int) y, (int) z);
	    return (ret == 0) ? false : true;
	}
    }
    public partial class DVButtonMask : CsObject {
	public DVButtonMask() { _this = SprExport.Spr_new_DVButtonMask(); _flag = true; }
	public DVButtonMask(IntPtr ptr) : base(ptr) {}
	public DVButtonMask(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~DVButtonMask() { if (_flag) { SprExport.Spr_delete_DVButtonMask(_this); _flag = false; } }
    }
    public partial class DVButtonSt : CsObject {
	public DVButtonSt() { _this = SprExport.Spr_new_DVButtonSt(); _flag = true; }
	public DVButtonSt(IntPtr ptr) : base(ptr) {}
	public DVButtonSt(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~DVButtonSt() { if (_flag) { SprExport.Spr_delete_DVButtonSt(_this); _flag = false; } }
    }
    public partial class DVKeySt : CsObject {
	public DVKeySt() { _this = SprExport.Spr_new_DVKeySt(); _flag = true; }
	public DVKeySt(IntPtr ptr) : base(ptr) {}
	public DVKeySt(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~DVKeySt() { if (_flag) { SprExport.Spr_delete_DVKeySt(_this); _flag = false; } }
    }
    public partial class DVKeyCode : CsObject {
	public DVKeyCode() { _this = SprExport.Spr_new_DVKeyCode(); _flag = true; }
	public DVKeyCode(IntPtr ptr) : base(ptr) {}
	public DVKeyCode(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~DVKeyCode() { if (_flag) { SprExport.Spr_delete_DVKeyCode(_this); _flag = false; } }
    }
    public partial class DVKeyMouseCallback : CsObject {
	public DVKeyMouseCallback() { _this = SprExport.Spr_new_DVKeyMouseCallback(); _flag = true; }
	public DVKeyMouseCallback(IntPtr ptr) : base(ptr) {}
	public DVKeyMouseCallback(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~DVKeyMouseCallback() { if (_flag) { SprExport.Spr_delete_DVKeyMouseCallback(_this); _flag = false; } }
	public bool OnMouse(int button, int state, int x, int y) {
	    char ret = SprExport.Spr_DVKeyMouseCallback_OnMouse((IntPtr) _this, (int) button, (int) state, (int) x, (int) y);
	    return (ret == 0) ? false : true;
	}
	public bool OnDoubleClick(int button, int x, int y) {
	    char ret = SprExport.Spr_DVKeyMouseCallback_OnDoubleClick((IntPtr) _this, (int) button, (int) x, (int) y);
	    return (ret == 0) ? false : true;
	}
	public bool OnMouseMove(int button, int x, int y, int zdelta) {
	    char ret = SprExport.Spr_DVKeyMouseCallback_OnMouseMove((IntPtr) _this, (int) button, (int) x, (int) y, (int) zdelta);
	    return (ret == 0) ? false : true;
	}
	public bool OnKey(int state, int key, int x, int y) {
	    char ret = SprExport.Spr_DVKeyMouseCallback_OnKey((IntPtr) _this, (int) state, (int) key, (int) x, (int) y);
	    return (ret == 0) ? false : true;
	}
    }
    public partial class DRKeyMouseWin32Desc : CsObject {
	public DRKeyMouseWin32Desc() { _this = SprExport.Spr_new_DRKeyMouseWin32Desc(); _flag = true; }
	public DRKeyMouseWin32Desc(IntPtr ptr) : base(ptr) {}
	public DRKeyMouseWin32Desc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~DRKeyMouseWin32Desc() { if (_flag) { SprExport.Spr_delete_DRKeyMouseWin32Desc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class DRKeyMouseWin32DescStruct : CsObject {
        public DRKeyMouseWin32DescStruct() {
            DRKeyMouseWin32Desc desc = new DRKeyMouseWin32Desc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] DRKeyMouseWin32Desc
	public void ApplyTo(DRKeyMouseWin32Desc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(DRKeyMouseWin32Desc r, bool apply_to_base_class=true) {
	}
	public static implicit operator DRKeyMouseWin32Desc(DRKeyMouseWin32DescStruct m) {
	    DRKeyMouseWin32Desc r = new DRKeyMouseWin32Desc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator DRKeyMouseWin32DescStruct(DRKeyMouseWin32Desc r) {
	    DRKeyMouseWin32DescStruct m = new DRKeyMouseWin32DescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class HILeapDesc : CsObject {
	public HILeapDesc() { _this = SprExport.Spr_new_HILeapDesc(); _flag = true; }
	public HILeapDesc(IntPtr ptr) : base(ptr) {}
	public HILeapDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~HILeapDesc() { if (_flag) { SprExport.Spr_delete_HILeapDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class HILeapDescStruct : CsObject {
        public HILeapDescStruct() {
            HILeapDesc desc = new HILeapDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] HILeapDesc
	public void ApplyTo(HILeapDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(HILeapDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator HILeapDesc(HILeapDescStruct m) {
	    HILeapDesc r = new HILeapDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator HILeapDescStruct(HILeapDesc r) {
	    HILeapDescStruct m = new HILeapDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class HILeapUDPDesc : CsObject {
	public HILeapUDPDesc() { _this = SprExport.Spr_new_HILeapUDPDesc(); _flag = true; }
	public HILeapUDPDesc(IntPtr ptr) : base(ptr) {}
	public HILeapUDPDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~HILeapUDPDesc() { if (_flag) { SprExport.Spr_delete_HILeapUDPDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class HILeapUDPDescStruct : CsObject {
        public HILeapUDPDescStruct() {
            HILeapUDPDesc desc = new HILeapUDPDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] HILeapUDPDesc
	public void ApplyTo(HILeapUDPDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(HILeapUDPDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator HILeapUDPDesc(HILeapUDPDescStruct m) {
	    HILeapUDPDesc r = new HILeapUDPDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator HILeapUDPDescStruct(HILeapUDPDesc r) {
	    HILeapUDPDescStruct m = new HILeapUDPDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class HINovintFalconDesc : CsObject {
	public HINovintFalconDesc() { _this = SprExport.Spr_new_HINovintFalconDesc(); _flag = true; }
	public HINovintFalconDesc(IntPtr ptr) : base(ptr) {}
	public HINovintFalconDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~HINovintFalconDesc() { if (_flag) { SprExport.Spr_delete_HINovintFalconDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class HINovintFalconDescStruct : CsObject {
        public HINovintFalconDescStruct() {
            HINovintFalconDesc desc = new HINovintFalconDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] HINovintFalconDesc
	public void ApplyTo(HINovintFalconDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(HINovintFalconDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator HINovintFalconDesc(HINovintFalconDescStruct m) {
	    HINovintFalconDesc r = new HINovintFalconDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator HINovintFalconDescStruct(HINovintFalconDesc r) {
	    HINovintFalconDescStruct m = new HINovintFalconDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class HISdkDesc : CsObject {
	public HISdkDesc() { _this = SprExport.Spr_new_HISdkDesc(); _flag = true; }
	public HISdkDesc(IntPtr ptr) : base(ptr) {}
	public HISdkDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~HISdkDesc() { if (_flag) { SprExport.Spr_delete_HISdkDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class HISdkDescStruct : CsObject {
        public HISdkDescStruct() {
            HISdkDesc desc = new HISdkDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] HISdkDesc
	public void ApplyTo(HISdkDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(HISdkDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator HISdkDesc(HISdkDescStruct m) {
	    HISdkDesc r = new HISdkDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator HISdkDescStruct(HISdkDesc r) {
	    HISdkDescStruct m = new HISdkDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class HISpaceNavigatorDesc : CsObject {
	public HISpaceNavigatorDesc() { _this = SprExport.Spr_new_HISpaceNavigatorDesc(); _flag = true; }
	public HISpaceNavigatorDesc(IntPtr ptr) : base(ptr) {}
	public HISpaceNavigatorDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~HISpaceNavigatorDesc() { if (_flag) { SprExport.Spr_delete_HISpaceNavigatorDesc(_this); _flag = false; } }
	public IntPtr hWnd {
	    get { return SprExport.Spr_HISpaceNavigatorDesc_get_hWnd(_this); }
	    set { SprExport.Spr_HISpaceNavigatorDesc_set_hWnd(_this, value); }
	}
	public float maxVelocity {
	    get { return SprExport.Spr_HISpaceNavigatorDesc_get_maxVelocity(_this); }
	    set { SprExport.Spr_HISpaceNavigatorDesc_set_maxVelocity(_this, value); }
	}
	public float maxAngularVelocity {
	    get { return SprExport.Spr_HISpaceNavigatorDesc_get_maxAngularVelocity(_this); }
	    set { SprExport.Spr_HISpaceNavigatorDesc_set_maxAngularVelocity(_this, value); }
	}
    }
    [System.Serializable]
    public class HISpaceNavigatorDescStruct : CsObject {
        public HISpaceNavigatorDescStruct() {
            HISpaceNavigatorDesc desc = new HISpaceNavigatorDesc();
            ApplyFrom(desc, false);
        }
	public IntPtr hWnd;
	public float maxVelocity;
	public float maxAngularVelocity;
// _[Find class node: 2916] HISpaceNavigatorDesc
	public void ApplyTo(HISpaceNavigatorDesc r, bool apply_to_base_class=true) {
		r.hWnd = hWnd;
		r.maxVelocity = maxVelocity;
		r.maxAngularVelocity = maxAngularVelocity;
	}
	public void ApplyFrom(HISpaceNavigatorDesc r, bool apply_to_base_class=true) {
		hWnd = r.hWnd;
		maxVelocity = r.maxVelocity;
		maxAngularVelocity = r.maxAngularVelocity;
	}
	public static implicit operator HISpaceNavigatorDesc(HISpaceNavigatorDescStruct m) {
	    HISpaceNavigatorDesc r = new HISpaceNavigatorDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator HISpaceNavigatorDescStruct(HISpaceNavigatorDesc r) {
	    HISpaceNavigatorDescStruct m = new HISpaceNavigatorDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class HISpidarMotorDesc : CsObject {
	public HISpidarMotorDesc() { _this = SprExport.Spr_new_HISpidarMotorDesc(); _flag = true; }
	public HISpidarMotorDesc(IntPtr ptr) : base(ptr) {}
	public HISpidarMotorDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~HISpidarMotorDesc() { if (_flag) { SprExport.Spr_delete_HISpidarMotorDesc(_this); _flag = false; } }
	public int ch {
	    get { return SprExport.Spr_HISpidarMotorDesc_get_ch(_this); }
	    set { SprExport.Spr_HISpidarMotorDesc_set_ch(_this, value); }
	}
	public float maxForce {
	    get { return SprExport.Spr_HISpidarMotorDesc_get_maxForce(_this); }
	    set { SprExport.Spr_HISpidarMotorDesc_set_maxForce(_this, value); }
	}
	public float minForce {
	    get { return SprExport.Spr_HISpidarMotorDesc_get_minForce(_this); }
	    set { SprExport.Spr_HISpidarMotorDesc_set_minForce(_this, value); }
	}
	public float voltPerNewton {
	    get { return SprExport.Spr_HISpidarMotorDesc_get_voltPerNewton(_this); }
	    set { SprExport.Spr_HISpidarMotorDesc_set_voltPerNewton(_this, value); }
	}
	public float currentPerVolt {
	    get { return SprExport.Spr_HISpidarMotorDesc_get_currentPerVolt(_this); }
	    set { SprExport.Spr_HISpidarMotorDesc_set_currentPerVolt(_this, value); }
	}
	public float lengthPerPulse {
	    get { return SprExport.Spr_HISpidarMotorDesc_get_lengthPerPulse(_this); }
	    set { SprExport.Spr_HISpidarMotorDesc_set_lengthPerPulse(_this, value); }
	}
	public Vec3f pos {
	    get { return new Vec3f(SprExport.Spr_HISpidarMotorDesc_addr_pos(_this)); }
	    set { SprExport.Spr_HISpidarMotorDesc_set_pos(_this, value); }
	}
	public Vec3f jointPos {
	    get { return new Vec3f(SprExport.Spr_HISpidarMotorDesc_addr_jointPos(_this)); }
	    set { SprExport.Spr_HISpidarMotorDesc_set_jointPos(_this, value); }
	}
    }
    [System.Serializable]
    public class HISpidarMotorDescStruct : CsObject {
        public HISpidarMotorDescStruct() {
            HISpidarMotorDesc desc = new HISpidarMotorDesc();
            ApplyFrom(desc, false);
        }
	public int ch;
	public float maxForce;
	public float minForce;
	public float voltPerNewton;
	public float currentPerVolt;
	public float lengthPerPulse;
	public Vec3fStruct pos;
	public Vec3fStruct jointPos;
// _[Find class node: 2916] HISpidarMotorDesc
	public void ApplyTo(HISpidarMotorDesc r, bool apply_to_base_class=true) {
		r.ch = ch;
		r.maxForce = maxForce;
		r.minForce = minForce;
		r.voltPerNewton = voltPerNewton;
		r.currentPerVolt = currentPerVolt;
		r.lengthPerPulse = lengthPerPulse;
		r.pos = pos;
		r.jointPos = jointPos;
	}
	public void ApplyFrom(HISpidarMotorDesc r, bool apply_to_base_class=true) {
		ch = r.ch;
		maxForce = r.maxForce;
		minForce = r.minForce;
		voltPerNewton = r.voltPerNewton;
		currentPerVolt = r.currentPerVolt;
		lengthPerPulse = r.lengthPerPulse;
		pos = r.pos;
		jointPos = r.jointPos;
	}
	public static implicit operator HISpidarMotorDesc(HISpidarMotorDescStruct m) {
	    HISpidarMotorDesc r = new HISpidarMotorDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator HISpidarMotorDescStruct(HISpidarMotorDesc r) {
	    HISpidarMotorDescStruct m = new HISpidarMotorDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class HISpidarDesc : CsObject {
	public HISpidarDesc() { _this = SprExport.Spr_new_HISpidarDesc(); _flag = true; }
	public HISpidarDesc(IntPtr ptr) : base(ptr) {}
	public HISpidarDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~HISpidarDesc() { if (_flag) { SprExport.Spr_delete_HISpidarDesc(_this); _flag = false; } }
	public string type {
	    get {
	        IntPtr ptr = SprExport.Spr_HISpidarDesc_get_type(_this);
	        string bstr = Marshal.PtrToStringBSTR(ptr);
	        SprExport.Spr_HISpidarDesc_FreeString_type(ptr);
	        return bstr;
	    }
	    set {
	        IntPtr pbstr = Marshal.StringToBSTR(value);
	        SprExport.Spr_HISpidarDesc_set_type(_this, pbstr);
	    }
	}
    public vectorwrapper_HISpidarMotorDesc motors {
        get { return new vectorwrapper_HISpidarMotorDesc(SprExport.Spr_HISpidarDesc_vector_get_motors(_this)); }
        set { SprExport.Spr_HISpidarDesc_vector_set_motors(_this, value._this); }
    }
	public int nButton {
	    get { return SprExport.Spr_HISpidarDesc_get_nButton(_this); }
	    set { SprExport.Spr_HISpidarDesc_set_nButton(_this, value); }
	}
    }
    [System.Serializable]
    public class HISpidarDescStruct : CsObject {
        public HISpidarDescStruct() {
            HISpidarDesc desc = new HISpidarDesc();
            ApplyFrom(desc, false);
        }
	public string type;
	public vectorwrapper_HISpidarMotorDesc motors = new vectorwrapper_HISpidarMotorDesc();
	public int nButton;
// _[Find class node: 2916] HISpidarDesc
	public void ApplyTo(HISpidarDesc r, bool apply_to_base_class=true) {
		r.type = type;
		r.motors.clear();
		int _HISpidarDesc_count_0001 = motors.size();
		for (int i = 0; i < _HISpidarDesc_count_0001; i++) {
			r.motors.push_back(motors[i]);
		}
		r.nButton = nButton;
	}
	public void ApplyFrom(HISpidarDesc r, bool apply_to_base_class=true) {
		type = r.type;
		motors.clear();
		int _HISpidarDesc_count_0001 = r.motors.size();
		for (int i = 0; i < _HISpidarDesc_count_0001; i++) {
			motors.push_back(r.motors[i]);
		}
		nButton = r.nButton;
	}
	public static implicit operator HISpidarDesc(HISpidarDescStruct m) {
	    HISpidarDesc r = new HISpidarDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator HISpidarDescStruct(HISpidarDesc r) {
	    HISpidarDescStruct m = new HISpidarDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class HISpidar4Desc : HISpidarDesc {
	public HISpidar4Desc() { _this = SprExport.Spr_new_HISpidar4Desc(); _flag = true; }
	public HISpidar4Desc(IntPtr ptr) : base(ptr) {}
	public HISpidar4Desc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public HISpidar4Desc(string type) { _this = SprExport.Spr_new_HISpidar4Desc_2(type); _flag = true; }
	public HISpidar4Desc(string type, Vec4i portNum) { _this = SprExport.Spr_new_HISpidar4Desc_3(type, portNum); _flag = true; }
	public HISpidar4Desc(int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp, float minF, float maxF) { _this = SprExport.Spr_new_HISpidar4Desc_4(nMotor, motorPos, knotPos, vpn, lpp, minF, maxF); _flag = true; }
	public HISpidar4Desc(int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp, float minF) { _this = SprExport.Spr_new_HISpidar4Desc_5(nMotor, motorPos, knotPos, vpn, lpp, minF); _flag = true; }
	public HISpidar4Desc(int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp) { _this = SprExport.Spr_new_HISpidar4Desc_6(nMotor, motorPos, knotPos, vpn, lpp); _flag = true; }
	~HISpidar4Desc() { if (_flag) { SprExport.Spr_delete_HISpidar4Desc(_this); _flag = false; } }
	public void Init(int nMotor, Vec3f motorPos, Vec3f knotPos, float vpn, float lpp, float minF, float maxF) {
	    SprExport.Spr_HISpidar4Desc_Init((IntPtr) _this, (int) nMotor, (IntPtr) motorPos, (IntPtr) knotPos, (float) vpn, (float) lpp, (float) minF, (float) maxF);
	}
	public void Init(int nMotor, Vec3f motorPos, Vec3f knotPos, float vpn, float lpp, float minF) {
	    SprExport.Spr_HISpidar4Desc_Init_1((IntPtr) _this, (int) nMotor, (IntPtr) motorPos, (IntPtr) knotPos, (float) vpn, (float) lpp, (float) minF);
	}
	public void Init(int nMotor, Vec3f motorPos, Vec3f knotPos, float vpn, float lpp) {
	    SprExport.Spr_HISpidar4Desc_Init_2((IntPtr) _this, (int) nMotor, (IntPtr) motorPos, (IntPtr) knotPos, (float) vpn, (float) lpp);
	}
	public void Init(string type) {
	    SprExport.Spr_HISpidar4Desc_Init_3((IntPtr) _this, (string) type);
	}
	public void InitSpidarG(string type) {
	    SprExport.Spr_HISpidar4Desc_InitSpidarG((IntPtr) _this, (string) type);
	}
	public void InitSpidarBig(string type) {
	    SprExport.Spr_HISpidar4Desc_InitSpidarBig((IntPtr) _this, (string) type);
	}
    }
    [System.Serializable]
    public class HISpidar4DescStruct : HISpidarDescStruct {
        public HISpidar4DescStruct() {
            HISpidar4Desc desc = new HISpidar4Desc();
            ApplyFrom(desc, true);
        }
// _[Find class node: 2916] HISpidar4Desc
	public void ApplyTo(HISpidar4Desc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyTo((HISpidarDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(HISpidar4Desc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyFrom((HISpidarDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator HISpidar4Desc(HISpidar4DescStruct m) {
	    HISpidar4Desc r = new HISpidar4Desc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator HISpidar4DescStruct(HISpidar4Desc r) {
	    HISpidar4DescStruct m = new HISpidar4DescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class HISpidar4DDesc : HISpidar4Desc {
	public HISpidar4DDesc() { _this = SprExport.Spr_new_HISpidar4DDesc(); _flag = true; }
	public HISpidar4DDesc(IntPtr ptr) : base(ptr) {}
	public HISpidar4DDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~HISpidar4DDesc() { if (_flag) { SprExport.Spr_delete_HISpidar4DDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class HISpidar4DDescStruct : HISpidar4DescStruct {
        public HISpidar4DDescStruct() {
            HISpidar4DDesc desc = new HISpidar4DDesc();
            ApplyFrom(desc, true);
        }
// _[Find class node: 2916] HISpidar4DDesc
	public void ApplyTo(HISpidar4DDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyTo((HISpidar4Desc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(HISpidar4DDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyFrom((HISpidar4Desc) r, apply_to_base_class);
		}
	}
	public static implicit operator HISpidar4DDesc(HISpidar4DDescStruct m) {
	    HISpidar4DDesc r = new HISpidar4DDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator HISpidar4DDescStruct(HISpidar4DDesc r) {
	    HISpidar4DDescStruct m = new HISpidar4DDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class HISpidarGDesc : HISpidarDesc {
	public HISpidarGDesc() { _this = SprExport.Spr_new_HISpidarGDesc(); _flag = true; }
	public HISpidarGDesc(IntPtr ptr) : base(ptr) {}
	public HISpidarGDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public HISpidarGDesc(string type) { _this = SprExport.Spr_new_HISpidarGDesc_2(type); _flag = true; }
	public HISpidarGDesc(int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp, float minF, float maxF) { _this = SprExport.Spr_new_HISpidarGDesc_3(nMotor, motorPos, knotPos, vpn, lpp, minF, maxF); _flag = true; }
	public HISpidarGDesc(int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp, float minF) { _this = SprExport.Spr_new_HISpidarGDesc_4(nMotor, motorPos, knotPos, vpn, lpp, minF); _flag = true; }
	public HISpidarGDesc(int nMotor, IntPtr motorPos, IntPtr knotPos, float vpn, float lpp) { _this = SprExport.Spr_new_HISpidarGDesc_5(nMotor, motorPos, knotPos, vpn, lpp); _flag = true; }
	~HISpidarGDesc() { if (_flag) { SprExport.Spr_delete_HISpidarGDesc(_this); _flag = false; } }
	public void Init(int nMotor, Vec3f motorPos, Vec3f knotPos, float vpn, float lpp, float minF, float maxF) {
	    SprExport.Spr_HISpidarGDesc_Init((IntPtr) _this, (int) nMotor, (IntPtr) motorPos, (IntPtr) knotPos, (float) vpn, (float) lpp, (float) minF, (float) maxF);
	}
	public void Init(int nMotor, Vec3f motorPos, Vec3f knotPos, float vpn, float lpp, float minF) {
	    SprExport.Spr_HISpidarGDesc_Init_1((IntPtr) _this, (int) nMotor, (IntPtr) motorPos, (IntPtr) knotPos, (float) vpn, (float) lpp, (float) minF);
	}
	public void Init(int nMotor, Vec3f motorPos, Vec3f knotPos, float vpn, float lpp) {
	    SprExport.Spr_HISpidarGDesc_Init_2((IntPtr) _this, (int) nMotor, (IntPtr) motorPos, (IntPtr) knotPos, (float) vpn, (float) lpp);
	}
	public void Init(string type) {
	    SprExport.Spr_HISpidarGDesc_Init_3((IntPtr) _this, (string) type);
	}
    }
    [System.Serializable]
    public class HISpidarGDescStruct : HISpidarDescStruct {
        public HISpidarGDescStruct() {
            HISpidarGDesc desc = new HISpidarGDesc();
            ApplyFrom(desc, true);
        }
// _[Find class node: 2916] HISpidarGDesc
	public void ApplyTo(HISpidarGDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyTo((HISpidarDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(HISpidarGDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyFrom((HISpidarDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator HISpidarGDesc(HISpidarGDescStruct m) {
	    HISpidarGDesc r = new HISpidarGDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator HISpidarGDescStruct(HISpidarGDesc r) {
	    HISpidarGDescStruct m = new HISpidarGDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class HITrackballDesc : CsObject {
	public HITrackballDesc() { _this = SprExport.Spr_new_HITrackballDesc(); _flag = true; }
	public HITrackballDesc(IntPtr ptr) : base(ptr) {}
	public HITrackballDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~HITrackballDesc() { if (_flag) { SprExport.Spr_delete_HITrackballDesc(_this); _flag = false; } }
	public bool trackball {
	    get {
	        byte ret = (byte) SprExport.Spr_HITrackballDesc_get_trackball(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_HITrackballDesc_set_trackball(_this, (char) val);
	    }
	}
	public Vec3f target {
	    get { return new Vec3f(SprExport.Spr_HITrackballDesc_addr_target(_this)); }
	    set { SprExport.Spr_HITrackballDesc_set_target(_this, value); }
	}
	public float longitude {
	    get { return SprExport.Spr_HITrackballDesc_get_longitude(_this); }
	    set { SprExport.Spr_HITrackballDesc_set_longitude(_this, value); }
	}
	public float latitude {
	    get { return SprExport.Spr_HITrackballDesc_get_latitude(_this); }
	    set { SprExport.Spr_HITrackballDesc_set_latitude(_this, value); }
	}
	public Vec2f lonRange {
	    get { return new Vec2f(SprExport.Spr_HITrackballDesc_addr_lonRange(_this)); }
	    set { SprExport.Spr_HITrackballDesc_set_lonRange(_this, value); }
	}
	public Vec2f latRange {
	    get { return new Vec2f(SprExport.Spr_HITrackballDesc_addr_latRange(_this)); }
	    set { SprExport.Spr_HITrackballDesc_set_latRange(_this, value); }
	}
	public float distance {
	    get { return SprExport.Spr_HITrackballDesc_get_distance(_this); }
	    set { SprExport.Spr_HITrackballDesc_set_distance(_this, value); }
	}
	public Vec2f distRange {
	    get { return new Vec2f(SprExport.Spr_HITrackballDesc_addr_distRange(_this)); }
	    set { SprExport.Spr_HITrackballDesc_set_distRange(_this, value); }
	}
	public float rotGain {
	    get { return SprExport.Spr_HITrackballDesc_get_rotGain(_this); }
	    set { SprExport.Spr_HITrackballDesc_set_rotGain(_this, value); }
	}
	public float zoomGain {
	    get { return SprExport.Spr_HITrackballDesc_get_zoomGain(_this); }
	    set { SprExport.Spr_HITrackballDesc_set_zoomGain(_this, value); }
	}
	public float trnGain {
	    get { return SprExport.Spr_HITrackballDesc_get_trnGain(_this); }
	    set { SprExport.Spr_HITrackballDesc_set_trnGain(_this, value); }
	}
	public int rotMask {
	    get { return SprExport.Spr_HITrackballDesc_get_rotMask(_this); }
	    set { SprExport.Spr_HITrackballDesc_set_rotMask(_this, value); }
	}
	public int zoomMask {
	    get { return SprExport.Spr_HITrackballDesc_get_zoomMask(_this); }
	    set { SprExport.Spr_HITrackballDesc_set_zoomMask(_this, value); }
	}
	public int trnMask {
	    get { return SprExport.Spr_HITrackballDesc_get_trnMask(_this); }
	    set { SprExport.Spr_HITrackballDesc_set_trnMask(_this, value); }
	}
    }
    [System.Serializable]
    public class HITrackballDescStruct : CsObject {
        public HITrackballDescStruct() {
            HITrackballDesc desc = new HITrackballDesc();
            ApplyFrom(desc, false);
        }
	public bool trackball;
	public Vec3fStruct target;
	public float longitude;
	public float latitude;
	public Vec2fStruct lonRange;
	public Vec2fStruct latRange;
	public float distance;
	public Vec2fStruct distRange;
	public float rotGain;
	public float zoomGain;
	public float trnGain;
	public int rotMask;
	public int zoomMask;
	public int trnMask;
// _[Find class node: 2916] HITrackballDesc
	public void ApplyTo(HITrackballDesc r, bool apply_to_base_class=true) {
		r.trackball = trackball;
		r.target = target;
		r.longitude = longitude;
		r.latitude = latitude;
		r.lonRange = lonRange;
		r.latRange = latRange;
		r.distance = distance;
		r.distRange = distRange;
		r.rotGain = rotGain;
		r.zoomGain = zoomGain;
		r.trnGain = trnGain;
		r.rotMask = rotMask;
		r.zoomMask = zoomMask;
		r.trnMask = trnMask;
	}
	public void ApplyFrom(HITrackballDesc r, bool apply_to_base_class=true) {
		trackball = r.trackball;
		target = r.target;
		longitude = r.longitude;
		latitude = r.latitude;
		lonRange = r.lonRange;
		latRange = r.latRange;
		distance = r.distance;
		distRange = r.distRange;
		rotGain = r.rotGain;
		zoomGain = r.zoomGain;
		trnGain = r.trnGain;
		rotMask = r.rotMask;
		zoomMask = r.zoomMask;
		trnMask = r.trnMask;
	}
	public static implicit operator HITrackballDesc(HITrackballDescStruct m) {
	    HITrackballDesc r = new HITrackballDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator HITrackballDescStruct(HITrackballDesc r) {
	    HITrackballDescStruct m = new HITrackballDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class HITrackballCallback : CsObject {
	public HITrackballCallback() { _this = SprExport.Spr_new_HITrackballCallback(); _flag = true; }
	public HITrackballCallback(IntPtr ptr) : base(ptr) {}
	public HITrackballCallback(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~HITrackballCallback() { if (_flag) { SprExport.Spr_delete_HITrackballCallback(_this); _flag = false; } }
	public void OnUpdatePose(HITrackballIf trackball) {
	    SprExport.Spr_HITrackballCallback_OnUpdatePose((IntPtr) _this, (IntPtr) trackball);
	}
    }
    public partial class HIXbox360ControllerDesc : CsObject {
	public HIXbox360ControllerDesc() { _this = SprExport.Spr_new_HIXbox360ControllerDesc(); _flag = true; }
	public HIXbox360ControllerDesc(IntPtr ptr) : base(ptr) {}
	public HIXbox360ControllerDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~HIXbox360ControllerDesc() { if (_flag) { SprExport.Spr_delete_HIXbox360ControllerDesc(_this); _flag = false; } }
	public float maxVelocity {
	    get { return SprExport.Spr_HIXbox360ControllerDesc_get_maxVelocity(_this); }
	    set { SprExport.Spr_HIXbox360ControllerDesc_set_maxVelocity(_this, value); }
	}
	public float maxAngularVelocity {
	    get { return SprExport.Spr_HIXbox360ControllerDesc_get_maxAngularVelocity(_this); }
	    set { SprExport.Spr_HIXbox360ControllerDesc_set_maxAngularVelocity(_this, value); }
	}
    }
    [System.Serializable]
    public class HIXbox360ControllerDescStruct : CsObject {
        public HIXbox360ControllerDescStruct() {
            HIXbox360ControllerDesc desc = new HIXbox360ControllerDesc();
            ApplyFrom(desc, false);
        }
	public float maxVelocity;
	public float maxAngularVelocity;
// _[Find class node: 2916] HIXbox360ControllerDesc
	public void ApplyTo(HIXbox360ControllerDesc r, bool apply_to_base_class=true) {
		r.maxVelocity = maxVelocity;
		r.maxAngularVelocity = maxAngularVelocity;
	}
	public void ApplyFrom(HIXbox360ControllerDesc r, bool apply_to_base_class=true) {
		maxVelocity = r.maxVelocity;
		maxAngularVelocity = r.maxAngularVelocity;
	}
	public static implicit operator HIXbox360ControllerDesc(HIXbox360ControllerDescStruct m) {
	    HIXbox360ControllerDesc r = new HIXbox360ControllerDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator HIXbox360ControllerDescStruct(HIXbox360ControllerDesc r) {
	    HIXbox360ControllerDescStruct m = new HIXbox360ControllerDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class HIBaseIf : NamedObjectIf {
	public HIBaseIf() { _this = SprExport.Spr_new_HIBaseIf(); _flag = true; }
	public HIBaseIf(IntPtr ptr) : base(ptr) {}
	public HIBaseIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HIBaseIf(CsCastObject target) {
		return (target._info.Inherit(HIBaseIf.GetIfInfoStatic()) ? new HIBaseIf(target._this, target._flag) : null);
	}
	~HIBaseIf() { if (_flag) { SprExport.Spr_delete_HIBaseIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HIBaseIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HIBaseIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HIBaseIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HIBaseIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool BeforeCalibration() {
	    char ret = SprExport.Spr_HIBaseIf_BeforeCalibration((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool Calibration() {
	    char ret = SprExport.Spr_HIBaseIf_Calibration((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool AfterCalibration() {
	    char ret = SprExport.Spr_HIBaseIf_AfterCalibration((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public void AddDeviceDependency(HIRealDeviceIf rd) {
	    SprExport.Spr_HIBaseIf_AddDeviceDependency((IntPtr) _this, (IntPtr) rd);
	}
	public void ClearDeviceDependency() {
	    SprExport.Spr_HIBaseIf_ClearDeviceDependency((IntPtr) _this);
	}
	public void Update(float dt) {
	    SprExport.Spr_HIBaseIf_Update((IntPtr) _this, (float) dt);
	}
	public bool IsGood() {
	    char ret = SprExport.Spr_HIBaseIf_IsGood((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool Init(CsObject desc) {
	    char ret = SprExport.Spr_HIBaseIf_Init((IntPtr) _this, (IntPtr) desc);
	    return (ret == 0) ? false : true;
	}
    }
    public partial class HIPoseIf : HIBaseIf {
	public HIPoseIf() { _this = SprExport.Spr_new_HIPoseIf(); _flag = true; }
	public HIPoseIf(IntPtr ptr) : base(ptr) {}
	public HIPoseIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HIPoseIf(CsCastObject target) {
		return (target._info.Inherit(HIPoseIf.GetIfInfoStatic()) ? new HIPoseIf(target._this, target._flag) : null);
	}
	~HIPoseIf() { if (_flag) { SprExport.Spr_delete_HIPoseIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HIPoseIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HIPoseIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HIPoseIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HIPoseIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public Vec3f GetPosition() {
	    IntPtr ptr = SprExport.Spr_HIPoseIf_GetPosition((IntPtr) _this);
            return new Vec3f(ptr, true);
	}
	public Quaternionf GetOrientation() {
	    IntPtr ptr = SprExport.Spr_HIPoseIf_GetOrientation((IntPtr) _this);
            return new Quaternionf(ptr, true);
	}
	public Posef GetPose() {
	    IntPtr ptr = SprExport.Spr_HIPoseIf_GetPose((IntPtr) _this);
            return new Posef(ptr, true);
	}
	public Affinef GetAffine() {
	    IntPtr ptr = SprExport.Spr_HIPoseIf_GetAffine((IntPtr) _this);
            return new Affinef(ptr, true);
	}
	public Vec3f GetVelocity() {
	    IntPtr ptr = SprExport.Spr_HIPoseIf_GetVelocity((IntPtr) _this);
            return new Vec3f(ptr, true);
	}
	public Vec3f GetAngularVelocity() {
	    IntPtr ptr = SprExport.Spr_HIPoseIf_GetAngularVelocity((IntPtr) _this);
            return new Vec3f(ptr, true);
	}
    }
    public partial class HIHapticIf : HIPoseIf {
	public HIHapticIf() { _this = SprExport.Spr_new_HIHapticIf(); _flag = true; }
	public HIHapticIf(IntPtr ptr) : base(ptr) {}
	public HIHapticIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HIHapticIf(CsCastObject target) {
		return (target._info.Inherit(HIHapticIf.GetIfInfoStatic()) ? new HIHapticIf(target._this, target._flag) : null);
	}
	~HIHapticIf() { if (_flag) { SprExport.Spr_delete_HIHapticIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HIHapticIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HIHapticIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HIHapticIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HIHapticIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public Vec3f GetTorque() {
	    IntPtr ptr = SprExport.Spr_HIHapticIf_GetTorque((IntPtr) _this);
            return new Vec3f(ptr, true);
	}
	public Vec3f GetForce() {
	    IntPtr ptr = SprExport.Spr_HIHapticIf_GetForce((IntPtr) _this);
            return new Vec3f(ptr, true);
	}
	public void SetForce(Vec3f f, Vec3f t) {
	    SprExport.Spr_HIHapticIf_SetForce((IntPtr) _this, (IntPtr) f, (IntPtr) t);
	}
	public void SetForce(Vec3f f) {
	    SprExport.Spr_HIHapticIf_SetForce_1((IntPtr) _this, (IntPtr) f);
	}
    }
    public partial class HIHapticDummyIf : HIHapticIf {
	public HIHapticDummyIf() { _this = SprExport.Spr_new_HIHapticDummyIf(); _flag = true; }
	public HIHapticDummyIf(IntPtr ptr) : base(ptr) {}
	public HIHapticDummyIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HIHapticDummyIf(CsCastObject target) {
		return (target._info.Inherit(HIHapticDummyIf.GetIfInfoStatic()) ? new HIHapticDummyIf(target._this, target._flag) : null);
	}
	~HIHapticDummyIf() { if (_flag) { SprExport.Spr_delete_HIHapticDummyIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HIHapticDummyIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HIHapticDummyIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HIHapticDummyIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HIHapticDummyIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void SetPose(Posed p) {
	    SprExport.Spr_HIHapticDummyIf_SetPose((IntPtr) _this, (IntPtr) p);
	}
	public void SetVelocity(Vec3d v) {
	    SprExport.Spr_HIHapticDummyIf_SetVelocity((IntPtr) _this, (IntPtr) v);
	}
	public void SetAngularVelocity(Vec3d v) {
	    SprExport.Spr_HIHapticDummyIf_SetAngularVelocity((IntPtr) _this, (IntPtr) v);
	}
    }
    public partial class HIDeviceIf : NamedObjectIf {
	public HIDeviceIf() { _this = SprExport.Spr_new_HIDeviceIf(); _flag = true; }
	public HIDeviceIf(IntPtr ptr) : base(ptr) {}
	public HIDeviceIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HIDeviceIf(CsCastObject target) {
		return (target._info.Inherit(HIDeviceIf.GetIfInfoStatic()) ? new HIDeviceIf(target._this, target._flag) : null);
	}
	~HIDeviceIf() { if (_flag) { SprExport.Spr_delete_HIDeviceIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HIDeviceIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HIDeviceIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HIDeviceIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HIDeviceIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
    public partial class HIRealDeviceIf : HIDeviceIf {
	public HIRealDeviceIf() { _this = SprExport.Spr_new_HIRealDeviceIf(); _flag = true; }
	public HIRealDeviceIf(IntPtr ptr) : base(ptr) {}
	public HIRealDeviceIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HIRealDeviceIf(CsCastObject target) {
		return (target._info.Inherit(HIRealDeviceIf.GetIfInfoStatic()) ? new HIRealDeviceIf(target._this, target._flag) : null);
	}
	~HIRealDeviceIf() { if (_flag) { SprExport.Spr_delete_HIRealDeviceIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HIRealDeviceIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HIRealDeviceIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HIRealDeviceIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HIRealDeviceIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool Init() {
	    char ret = SprExport.Spr_HIRealDeviceIf_Init((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool Return(HIVirtualDeviceIf dv) {
	    char ret = SprExport.Spr_HIRealDeviceIf_Return((IntPtr) _this, (IntPtr) dv);
	    return (ret == 0) ? false : true;
	}
	public void Update() {
	    SprExport.Spr_HIRealDeviceIf_Update((IntPtr) _this);
	}
    }
    public partial class HIVirtualDeviceIf : HIDeviceIf {
	public HIVirtualDeviceIf() { _this = SprExport.Spr_new_HIVirtualDeviceIf(); _flag = true; }
	public HIVirtualDeviceIf(IntPtr ptr) : base(ptr) {}
	public HIVirtualDeviceIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HIVirtualDeviceIf(CsCastObject target) {
		return (target._info.Inherit(HIVirtualDeviceIf.GetIfInfoStatic()) ? new HIVirtualDeviceIf(target._this, target._flag) : null);
	}
	~HIVirtualDeviceIf() { if (_flag) { SprExport.Spr_delete_HIVirtualDeviceIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HIVirtualDeviceIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HIVirtualDeviceIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HIVirtualDeviceIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HIVirtualDeviceIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public int GetPortNo() {
	    int result = (int) SprExport.Spr_HIVirtualDeviceIf_GetPortNo((IntPtr) _this);
	    return result;
	}
	public bool IsUsed() {
	    char ret = SprExport.Spr_HIVirtualDeviceIf_IsUsed((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public HIRealDeviceIf GetRealDevice() {
	    IntPtr ptr = SprExport.Spr_HIVirtualDeviceIf_GetRealDevice((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            HIRealDeviceIf obj = new HIRealDeviceIf(ptr);
            if (obj.GetIfInfo() == DRUsb20SimpleIf.GetIfInfoStatic()) { return new DRUsb20SimpleIf(ptr); }
            if (obj.GetIfInfo() == DRUsb20Sh4If.GetIfInfoStatic()) { return new DRUsb20Sh4If(ptr); }
            if (obj.GetIfInfo() == DRKeyMouseWin32If.GetIfInfoStatic()) { return new DRKeyMouseWin32If(ptr); }
            if (obj.GetIfInfo() == DRCyUsb20Sh4If.GetIfInfoStatic()) { return new DRCyUsb20Sh4If(ptr); }
            return obj;
	}
	public void Update() {
	    SprExport.Spr_HIVirtualDeviceIf_Update((IntPtr) _this);
	}
    }
    public partial class DVAdIf : HIVirtualDeviceIf {
	public DVAdIf() { _this = SprExport.Spr_new_DVAdIf(); _flag = true; }
	public DVAdIf(IntPtr ptr) : base(ptr) {}
	public DVAdIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator DVAdIf(CsCastObject target) {
		return (target._info.Inherit(DVAdIf.GetIfInfoStatic()) ? new DVAdIf(target._this, target._flag) : null);
	}
	~DVAdIf() { if (_flag) { SprExport.Spr_delete_DVAdIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_DVAdIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_DVAdIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_DVAdIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_DVAdIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public int Digit() {
	    int result = (int) SprExport.Spr_DVAdIf_Digit((IntPtr) _this);
	    return result;
	}
	public float Voltage() {
	    float result = (float) SprExport.Spr_DVAdIf_Voltage((IntPtr) _this);
	    return result;
	}
    }
    public partial class DVDaIf : HIVirtualDeviceIf {
	public DVDaIf() { _this = SprExport.Spr_new_DVDaIf(); _flag = true; }
	public DVDaIf(IntPtr ptr) : base(ptr) {}
	public DVDaIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator DVDaIf(CsCastObject target) {
		return (target._info.Inherit(DVDaIf.GetIfInfoStatic()) ? new DVDaIf(target._this, target._flag) : null);
	}
	~DVDaIf() { if (_flag) { SprExport.Spr_delete_DVDaIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_DVDaIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_DVDaIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_DVDaIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_DVDaIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void Digit(int d) {
	    SprExport.Spr_DVDaIf_Digit((IntPtr) _this, (int) d);
	}
	public void Voltage(float volt) {
	    SprExport.Spr_DVDaIf_Voltage((IntPtr) _this, (float) volt);
	}
    }
    public partial class DVCounterIf : HIVirtualDeviceIf {
	public DVCounterIf() { _this = SprExport.Spr_new_DVCounterIf(); _flag = true; }
	public DVCounterIf(IntPtr ptr) : base(ptr) {}
	public DVCounterIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator DVCounterIf(CsCastObject target) {
		return (target._info.Inherit(DVCounterIf.GetIfInfoStatic()) ? new DVCounterIf(target._this, target._flag) : null);
	}
	~DVCounterIf() { if (_flag) { SprExport.Spr_delete_DVCounterIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_DVCounterIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_DVCounterIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_DVCounterIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_DVCounterIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void Count(long count) {
	    SprExport.Spr_DVCounterIf_Count((IntPtr) _this, (long) count);
	}
	public long Count() {
	    long result = (long) SprExport.Spr_DVCounterIf_Count_1((IntPtr) _this);
	    return result;
	}
    }
    public partial class DVPioIf : HIVirtualDeviceIf {
	public DVPioIf() { _this = SprExport.Spr_new_DVPioIf(); _flag = true; }
	public DVPioIf(IntPtr ptr) : base(ptr) {}
	public DVPioIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator DVPioIf(CsCastObject target) {
		return (target._info.Inherit(DVPioIf.GetIfInfoStatic()) ? new DVPioIf(target._this, target._flag) : null);
	}
	~DVPioIf() { if (_flag) { SprExport.Spr_delete_DVPioIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_DVPioIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_DVPioIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_DVPioIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_DVPioIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public int Get() {
	    int result = (int) SprExport.Spr_DVPioIf_Get((IntPtr) _this);
	    return result;
	}
	public void Set(int l) {
	    SprExport.Spr_DVPioIf_Set((IntPtr) _this, (int) l);
	}
    }
    public partial class DVForceIf : HIVirtualDeviceIf {
	public DVForceIf() { _this = SprExport.Spr_new_DVForceIf(); _flag = true; }
	public DVForceIf(IntPtr ptr) : base(ptr) {}
	public DVForceIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator DVForceIf(CsCastObject target) {
		return (target._info.Inherit(DVForceIf.GetIfInfoStatic()) ? new DVForceIf(target._this, target._flag) : null);
	}
	~DVForceIf() { if (_flag) { SprExport.Spr_delete_DVForceIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_DVForceIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_DVForceIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_DVForceIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_DVForceIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public int GetDOF() {
	    int result = (int) SprExport.Spr_DVForceIf_GetDOF((IntPtr) _this);
	    return result;
	}
	public float GetForce(int ch) {
	    float result = (float) SprExport.Spr_DVForceIf_GetForce((IntPtr) _this, (int) ch);
	    return result;
	}
	public void GetForce3(Vec3f f) {
	    SprExport.Spr_DVForceIf_GetForce3((IntPtr) _this, (IntPtr) f);
	}
	public void GetForce6(Vec3f f, Vec3f t) {
	    SprExport.Spr_DVForceIf_GetForce6((IntPtr) _this, (IntPtr) f, (IntPtr) t);
	}
    }
    public partial class DRUsb20SimpleIf : HIRealDeviceIf {
	public DRUsb20SimpleIf() { _this = SprExport.Spr_new_DRUsb20SimpleIf(); _flag = true; }
	public DRUsb20SimpleIf(IntPtr ptr) : base(ptr) {}
	public DRUsb20SimpleIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator DRUsb20SimpleIf(CsCastObject target) {
		return (target._info.Inherit(DRUsb20SimpleIf.GetIfInfoStatic()) ? new DRUsb20SimpleIf(target._this, target._flag) : null);
	}
	~DRUsb20SimpleIf() { if (_flag) { SprExport.Spr_delete_DRUsb20SimpleIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_DRUsb20SimpleIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_DRUsb20SimpleIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_DRUsb20SimpleIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_DRUsb20SimpleIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
    public partial class DRUsb20Sh4If : HIRealDeviceIf {
	public DRUsb20Sh4If() { _this = SprExport.Spr_new_DRUsb20Sh4If(); _flag = true; }
	public DRUsb20Sh4If(IntPtr ptr) : base(ptr) {}
	public DRUsb20Sh4If(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator DRUsb20Sh4If(CsCastObject target) {
		return (target._info.Inherit(DRUsb20Sh4If.GetIfInfoStatic()) ? new DRUsb20Sh4If(target._this, target._flag) : null);
	}
	~DRUsb20Sh4If() { if (_flag) { SprExport.Spr_delete_DRUsb20Sh4If(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_DRUsb20Sh4If_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_DRUsb20Sh4If_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_DRUsb20Sh4If_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_DRUsb20Sh4If_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
    public partial class DRCyUsb20Sh4If : DRUsb20Sh4If {
	public DRCyUsb20Sh4If() { _this = SprExport.Spr_new_DRCyUsb20Sh4If(); _flag = true; }
	public DRCyUsb20Sh4If(IntPtr ptr) : base(ptr) {}
	public DRCyUsb20Sh4If(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator DRCyUsb20Sh4If(CsCastObject target) {
		return (target._info.Inherit(DRCyUsb20Sh4If.GetIfInfoStatic()) ? new DRCyUsb20Sh4If(target._this, target._flag) : null);
	}
	~DRCyUsb20Sh4If() { if (_flag) { SprExport.Spr_delete_DRCyUsb20Sh4If(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_DRCyUsb20Sh4If_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_DRCyUsb20Sh4If_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_DRCyUsb20Sh4If_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_DRCyUsb20Sh4If_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
    public partial class DVJoyStickIf : HIVirtualDeviceIf {
	public DVJoyStickIf() { _this = SprExport.Spr_new_DVJoyStickIf(); _flag = true; }
	public DVJoyStickIf(IntPtr ptr) : base(ptr) {}
	public DVJoyStickIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator DVJoyStickIf(CsCastObject target) {
		return (target._info.Inherit(DVJoyStickIf.GetIfInfoStatic()) ? new DVJoyStickIf(target._this, target._flag) : null);
	}
	~DVJoyStickIf() { if (_flag) { SprExport.Spr_delete_DVJoyStickIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_DVJoyStickIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_DVJoyStickIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_DVJoyStickIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_DVJoyStickIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void AddCallback(DVJoyStickCallback cb) {
	    SprExport.Spr_DVJoyStickIf_AddCallback((IntPtr) _this, (IntPtr) cb);
	}
	public void RemoveCallback(DVJoyStickCallback cb) {
	    SprExport.Spr_DVJoyStickIf_RemoveCallback((IntPtr) _this, (IntPtr) cb);
	}
	public void SetPollInterval(int ms) {
	    SprExport.Spr_DVJoyStickIf_SetPollInterval((IntPtr) _this, (int) ms);
	}
	public int GetPollInterval() {
	    int result = (int) SprExport.Spr_DVJoyStickIf_GetPollInterval((IntPtr) _this);
	    return result;
	}
    }
    public partial class DVKeyMouseIf : HIVirtualDeviceIf {
	public DVKeyMouseIf() { _this = SprExport.Spr_new_DVKeyMouseIf(); _flag = true; }
	public DVKeyMouseIf(IntPtr ptr) : base(ptr) {}
	public DVKeyMouseIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator DVKeyMouseIf(CsCastObject target) {
		return (target._info.Inherit(DVKeyMouseIf.GetIfInfoStatic()) ? new DVKeyMouseIf(target._this, target._flag) : null);
	}
	~DVKeyMouseIf() { if (_flag) { SprExport.Spr_delete_DVKeyMouseIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_DVKeyMouseIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_DVKeyMouseIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_DVKeyMouseIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_DVKeyMouseIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void AddCallback(DVKeyMouseCallback cb) {
	    SprExport.Spr_DVKeyMouseIf_AddCallback((IntPtr) _this, (IntPtr) cb);
	}
	public void RemoveCallback(DVKeyMouseCallback cb) {
	    SprExport.Spr_DVKeyMouseIf_RemoveCallback((IntPtr) _this, (IntPtr) cb);
	}
	public int GetKeyState(int key) {
	    int result = (int) SprExport.Spr_DVKeyMouseIf_GetKeyState((IntPtr) _this, (int) key);
	    return result;
	}
	public void GetMousePosition(int x, int y, int time, int count) {
	    SprExport.Spr_DVKeyMouseIf_GetMousePosition((IntPtr) _this, (int) x, (int) y, (int) time, (int) count);
	}
	public void GetMousePosition(int x, int y, int time) {
	    SprExport.Spr_DVKeyMouseIf_GetMousePosition_1((IntPtr) _this, (int) x, (int) y, (int) time);
	}
    }
    public partial class DRKeyMouseWin32If : HIRealDeviceIf {
	public DRKeyMouseWin32If() { _this = SprExport.Spr_new_DRKeyMouseWin32If(); _flag = true; }
	public DRKeyMouseWin32If(IntPtr ptr) : base(ptr) {}
	public DRKeyMouseWin32If(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator DRKeyMouseWin32If(CsCastObject target) {
		return (target._info.Inherit(DRKeyMouseWin32If.GetIfInfoStatic()) ? new DRKeyMouseWin32If(target._this, target._flag) : null);
	}
	~DRKeyMouseWin32If() { if (_flag) { SprExport.Spr_delete_DRKeyMouseWin32If(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_DRKeyMouseWin32If_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_DRKeyMouseWin32If_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_DRKeyMouseWin32If_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_DRKeyMouseWin32If_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool PreviewMessage(CsObject m) {
	    char ret = SprExport.Spr_DRKeyMouseWin32If_PreviewMessage((IntPtr) _this, (IntPtr) m);
	    return (ret == 0) ? false : true;
	}
    }
    public partial class HIBoneIf : ObjectIf {
	public HIBoneIf() { _this = SprExport.Spr_new_HIBoneIf(); _flag = true; }
	public HIBoneIf(IntPtr ptr) : base(ptr) {}
	public HIBoneIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HIBoneIf(CsCastObject target) {
		return (target._info.Inherit(HIBoneIf.GetIfInfoStatic()) ? new HIBoneIf(target._this, target._flag) : null);
	}
	~HIBoneIf() { if (_flag) { SprExport.Spr_delete_HIBoneIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HIBoneIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HIBoneIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HIBoneIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HIBoneIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public HIBoneIf GetParent() {
	    IntPtr ptr = SprExport.Spr_HIBoneIf_GetParent((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            HIBoneIf obj = new HIBoneIf(ptr);
            return obj;
	}
	public Vec3d GetPosition() {
	    IntPtr ptr = SprExport.Spr_HIBoneIf_GetPosition((IntPtr) _this);
            return new Vec3d(ptr, true);
	}
	public Vec3d GetDirection() {
	    IntPtr ptr = SprExport.Spr_HIBoneIf_GetDirection((IntPtr) _this);
            return new Vec3d(ptr, true);
	}
	public double GetLength() {
	    double result = (double) SprExport.Spr_HIBoneIf_GetLength((IntPtr) _this);
	    return result;
	}
    }
    public partial class HISkeletonIf : ObjectIf {
	public HISkeletonIf() { _this = SprExport.Spr_new_HISkeletonIf(); _flag = true; }
	public HISkeletonIf(IntPtr ptr) : base(ptr) {}
	public HISkeletonIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HISkeletonIf(CsCastObject target) {
		return (target._info.Inherit(HISkeletonIf.GetIfInfoStatic()) ? new HISkeletonIf(target._this, target._flag) : null);
	}
	~HISkeletonIf() { if (_flag) { SprExport.Spr_delete_HISkeletonIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HISkeletonIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HISkeletonIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HISkeletonIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HISkeletonIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public Posed GetPose() {
	    IntPtr ptr = SprExport.Spr_HISkeletonIf_GetPose((IntPtr) _this);
            return new Posed(ptr, true);
	}
	public int NBones() {
	    int result = (int) SprExport.Spr_HISkeletonIf_NBones((IntPtr) _this);
	    return result;
	}
	public HIBoneIf GetBone(int i) {
	    IntPtr ptr = SprExport.Spr_HISkeletonIf_GetBone((IntPtr) _this, (int) i);
            if (ptr == IntPtr.Zero) { return null; } 
            HIBoneIf obj = new HIBoneIf(ptr);
            return obj;
	}
	public HIBoneIf GetRoot() {
	    IntPtr ptr = SprExport.Spr_HISkeletonIf_GetRoot((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            HIBoneIf obj = new HIBoneIf(ptr);
            return obj;
	}
	public float GetGrabStrength() {
	    float result = (float) SprExport.Spr_HISkeletonIf_GetGrabStrength((IntPtr) _this);
	    return result;
	}
	public bool IsTracked() {
	    char ret = SprExport.Spr_HISkeletonIf_IsTracked((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
    }
    public partial class HISkeletonSensorIf : HIBaseIf {
	public HISkeletonSensorIf() { _this = SprExport.Spr_new_HISkeletonSensorIf(); _flag = true; }
	public HISkeletonSensorIf(IntPtr ptr) : base(ptr) {}
	public HISkeletonSensorIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HISkeletonSensorIf(CsCastObject target) {
		return (target._info.Inherit(HISkeletonSensorIf.GetIfInfoStatic()) ? new HISkeletonSensorIf(target._this, target._flag) : null);
	}
	~HISkeletonSensorIf() { if (_flag) { SprExport.Spr_delete_HISkeletonSensorIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HISkeletonSensorIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HISkeletonSensorIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HISkeletonSensorIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HISkeletonSensorIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public int NSkeletons() {
	    int result = (int) SprExport.Spr_HISkeletonSensorIf_NSkeletons((IntPtr) _this);
	    return result;
	}
	public HISkeletonIf GetSkeleton(int i) {
	    IntPtr ptr = SprExport.Spr_HISkeletonSensorIf_GetSkeleton((IntPtr) _this, (int) i);
            if (ptr == IntPtr.Zero) { return null; } 
            HISkeletonIf obj = new HISkeletonIf(ptr);
            return obj;
	}
	public void SetScale(double s) {
	    SprExport.Spr_HISkeletonSensorIf_SetScale((IntPtr) _this, (double) s);
	}
	public void SetCenter(Vec3d c) {
	    SprExport.Spr_HISkeletonSensorIf_SetCenter((IntPtr) _this, (IntPtr) c);
	}
	public void SetRotation(Quaterniond q) {
	    SprExport.Spr_HISkeletonSensorIf_SetRotation((IntPtr) _this, (IntPtr) q);
	}
    }
    public partial class HILeapIf : HISkeletonSensorIf {
	public HILeapIf() { _this = SprExport.Spr_new_HILeapIf(); _flag = true; }
	public HILeapIf(IntPtr ptr) : base(ptr) {}
	public HILeapIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HILeapIf(CsCastObject target) {
		return (target._info.Inherit(HILeapIf.GetIfInfoStatic()) ? new HILeapIf(target._this, target._flag) : null);
	}
	~HILeapIf() { if (_flag) { SprExport.Spr_delete_HILeapIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HILeapIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HILeapIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HILeapIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HILeapIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
    public partial class HILeapUDPIf : HISkeletonSensorIf {
	public HILeapUDPIf() { _this = SprExport.Spr_new_HILeapUDPIf(); _flag = true; }
	public HILeapUDPIf(IntPtr ptr) : base(ptr) {}
	public HILeapUDPIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HILeapUDPIf(CsCastObject target) {
		return (target._info.Inherit(HILeapUDPIf.GetIfInfoStatic()) ? new HILeapUDPIf(target._this, target._flag) : null);
	}
	~HILeapUDPIf() { if (_flag) { SprExport.Spr_delete_HILeapUDPIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HILeapUDPIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HILeapUDPIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HILeapUDPIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HILeapUDPIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool calibrate(int formerLeapID) {
	    char ret = SprExport.Spr_HILeapUDPIf_calibrate((IntPtr) _this, (int) formerLeapID);
	    return (ret == 0) ? false : true;
	}
    }
    public partial class HINovintFalconIf : HIHapticIf {
	public HINovintFalconIf() { _this = SprExport.Spr_new_HINovintFalconIf(); _flag = true; }
	public HINovintFalconIf(IntPtr ptr) : base(ptr) {}
	public HINovintFalconIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HINovintFalconIf(CsCastObject target) {
		return (target._info.Inherit(HINovintFalconIf.GetIfInfoStatic()) ? new HINovintFalconIf(target._this, target._flag) : null);
	}
	~HINovintFalconIf() { if (_flag) { SprExport.Spr_delete_HINovintFalconIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HINovintFalconIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HINovintFalconIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HINovintFalconIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HINovintFalconIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
    public partial class HISdkIf : NameManagerIf {
	public HISdkIf() { _this = SprExport.Spr_new_HISdkIf(); _flag = true; }
	public HISdkIf(IntPtr ptr) : base(ptr) {}
	public HISdkIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HISdkIf(CsCastObject target) {
		return (target._info.Inherit(HISdkIf.GetIfInfoStatic()) ? new HISdkIf(target._this, target._flag) : null);
	}
	~HISdkIf() { if (_flag) { SprExport.Spr_delete_HISdkIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HISdkIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HISdkIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HISdkIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HISdkIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool ReturnVirtualDevice(HIVirtualDeviceIf dev) {
	    char ret = SprExport.Spr_HISdkIf_ReturnVirtualDevice((IntPtr) _this, (IntPtr) dev);
	    return (ret == 0) ? false : true;
	}
	public HIRealDeviceIf AddRealDevice(IfInfo keyInfo, CsObject desc) {
	    IntPtr ptr = SprExport.Spr_HISdkIf_AddRealDevice((IntPtr) _this, (IntPtr) keyInfo, (IntPtr) desc);
            if (ptr == IntPtr.Zero) { return null; } 
            HIRealDeviceIf obj = new HIRealDeviceIf(ptr);
            if (obj.GetIfInfo() == DRUsb20SimpleIf.GetIfInfoStatic()) { return new DRUsb20SimpleIf(ptr); }
            if (obj.GetIfInfo() == DRUsb20Sh4If.GetIfInfoStatic()) { return new DRUsb20Sh4If(ptr); }
            if (obj.GetIfInfo() == DRKeyMouseWin32If.GetIfInfoStatic()) { return new DRKeyMouseWin32If(ptr); }
            if (obj.GetIfInfo() == DRCyUsb20Sh4If.GetIfInfoStatic()) { return new DRCyUsb20Sh4If(ptr); }
            return obj;
	}
	public HIRealDeviceIf AddRealDevice(IfInfo keyInfo) {
	    IntPtr ptr = SprExport.Spr_HISdkIf_AddRealDevice_1((IntPtr) _this, (IntPtr) keyInfo);
            if (ptr == IntPtr.Zero) { return null; } 
            HIRealDeviceIf obj = new HIRealDeviceIf(ptr);
            if (obj.GetIfInfo() == DRUsb20SimpleIf.GetIfInfoStatic()) { return new DRUsb20SimpleIf(ptr); }
            if (obj.GetIfInfo() == DRUsb20Sh4If.GetIfInfoStatic()) { return new DRUsb20Sh4If(ptr); }
            if (obj.GetIfInfo() == DRKeyMouseWin32If.GetIfInfoStatic()) { return new DRKeyMouseWin32If(ptr); }
            if (obj.GetIfInfo() == DRCyUsb20Sh4If.GetIfInfoStatic()) { return new DRCyUsb20Sh4If(ptr); }
            return obj;
	}
	public HIBaseIf CreateHumanInterface(IfInfo info) {
	    IntPtr ptr = SprExport.Spr_HISdkIf_CreateHumanInterface((IntPtr) _this, (IntPtr) info);
            if (ptr == IntPtr.Zero) { return null; } 
            HIBaseIf obj = new HIBaseIf(ptr);
            if (obj.GetIfInfo() == HIPoseIf.GetIfInfoStatic()) { return new HIPoseIf(ptr); }
            if (obj.GetIfInfo() == HISkeletonSensorIf.GetIfInfoStatic()) { return new HISkeletonSensorIf(ptr); }
            if (obj.GetIfInfo() == HISpidarMotorIf.GetIfInfoStatic()) { return new HISpidarMotorIf(ptr); }
            if (obj.GetIfInfo() == HIHapticIf.GetIfInfoStatic()) { return new HIHapticIf(ptr); }
            if (obj.GetIfInfo() == HISpaceNavigatorIf.GetIfInfoStatic()) { return new HISpaceNavigatorIf(ptr); }
            if (obj.GetIfInfo() == HITrackballIf.GetIfInfoStatic()) { return new HITrackballIf(ptr); }
            if (obj.GetIfInfo() == HILeapIf.GetIfInfoStatic()) { return new HILeapIf(ptr); }
            if (obj.GetIfInfo() == HILeapUDPIf.GetIfInfoStatic()) { return new HILeapUDPIf(ptr); }
            if (obj.GetIfInfo() == HIHapticDummyIf.GetIfInfoStatic()) { return new HIHapticDummyIf(ptr); }
            if (obj.GetIfInfo() == HINovintFalconIf.GetIfInfoStatic()) { return new HINovintFalconIf(ptr); }
            if (obj.GetIfInfo() == HISpidarIf.GetIfInfoStatic()) { return new HISpidarIf(ptr); }
            if (obj.GetIfInfo() == HIXbox360ControllerIf.GetIfInfoStatic()) { return new HIXbox360ControllerIf(ptr); }
            if (obj.GetIfInfo() == HISpidar4If.GetIfInfoStatic()) { return new HISpidar4If(ptr); }
            if (obj.GetIfInfo() == HISpidarGIf.GetIfInfoStatic()) { return new HISpidarGIf(ptr); }
            if (obj.GetIfInfo() == HISpidar4DIf.GetIfInfoStatic()) { return new HISpidar4DIf(ptr); }
            return obj;
	}
	public HIBaseIf CreateHumanInterface(string name) {
	    IntPtr ptr = SprExport.Spr_HISdkIf_CreateHumanInterface_1((IntPtr) _this, (string) name);
            if (ptr == IntPtr.Zero) { return null; } 
            HIBaseIf obj = new HIBaseIf(ptr);
            if (obj.GetIfInfo() == HIPoseIf.GetIfInfoStatic()) { return new HIPoseIf(ptr); }
            if (obj.GetIfInfo() == HISkeletonSensorIf.GetIfInfoStatic()) { return new HISkeletonSensorIf(ptr); }
            if (obj.GetIfInfo() == HISpidarMotorIf.GetIfInfoStatic()) { return new HISpidarMotorIf(ptr); }
            if (obj.GetIfInfo() == HIHapticIf.GetIfInfoStatic()) { return new HIHapticIf(ptr); }
            if (obj.GetIfInfo() == HISpaceNavigatorIf.GetIfInfoStatic()) { return new HISpaceNavigatorIf(ptr); }
            if (obj.GetIfInfo() == HITrackballIf.GetIfInfoStatic()) { return new HITrackballIf(ptr); }
            if (obj.GetIfInfo() == HILeapIf.GetIfInfoStatic()) { return new HILeapIf(ptr); }
            if (obj.GetIfInfo() == HILeapUDPIf.GetIfInfoStatic()) { return new HILeapUDPIf(ptr); }
            if (obj.GetIfInfo() == HIHapticDummyIf.GetIfInfoStatic()) { return new HIHapticDummyIf(ptr); }
            if (obj.GetIfInfo() == HINovintFalconIf.GetIfInfoStatic()) { return new HINovintFalconIf(ptr); }
            if (obj.GetIfInfo() == HISpidarIf.GetIfInfoStatic()) { return new HISpidarIf(ptr); }
            if (obj.GetIfInfo() == HIXbox360ControllerIf.GetIfInfoStatic()) { return new HIXbox360ControllerIf(ptr); }
            if (obj.GetIfInfo() == HISpidar4If.GetIfInfoStatic()) { return new HISpidar4If(ptr); }
            if (obj.GetIfInfo() == HISpidarGIf.GetIfInfoStatic()) { return new HISpidarGIf(ptr); }
            if (obj.GetIfInfo() == HISpidar4DIf.GetIfInfoStatic()) { return new HISpidar4DIf(ptr); }
            return obj;
	}
	public static HISdkIf CreateSdk() {
	    IntPtr ptr = SprExport.Spr_HISdkIf_CreateSdk();
            if (ptr == IntPtr.Zero) { return null; } 
            HISdkIf obj = new HISdkIf(ptr);
            return obj;
	}
	public static void RegisterSdk() {
	    SprExport.Spr_HISdkIf_RegisterSdk();
	}
    }
    public partial class HISpaceNavigatorIf : HIPoseIf {
	public HISpaceNavigatorIf() { _this = SprExport.Spr_new_HISpaceNavigatorIf(); _flag = true; }
	public HISpaceNavigatorIf(IntPtr ptr) : base(ptr) {}
	public HISpaceNavigatorIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HISpaceNavigatorIf(CsCastObject target) {
		return (target._info.Inherit(HISpaceNavigatorIf.GetIfInfoStatic()) ? new HISpaceNavigatorIf(target._this, target._flag) : null);
	}
	~HISpaceNavigatorIf() { if (_flag) { SprExport.Spr_delete_HISpaceNavigatorIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HISpaceNavigatorIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HISpaceNavigatorIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HISpaceNavigatorIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HISpaceNavigatorIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool SetPose(Posef pose) {
	    char ret = SprExport.Spr_HISpaceNavigatorIf_SetPose((IntPtr) _this, (IntPtr) pose);
	    return (ret == 0) ? false : true;
	}
	public void SetMaxVelocity(float mV) {
	    SprExport.Spr_HISpaceNavigatorIf_SetMaxVelocity((IntPtr) _this, (float) mV);
	}
	public void SetMaxAngularVelocity(float mAV) {
	    SprExport.Spr_HISpaceNavigatorIf_SetMaxAngularVelocity((IntPtr) _this, (float) mAV);
	}
	public bool PreviewMessage(CsObject m) {
	    char ret = SprExport.Spr_HISpaceNavigatorIf_PreviewMessage((IntPtr) _this, (IntPtr) m);
	    return (ret == 0) ? false : true;
	}
	public void SetViewMatrix(Affinef view) {
	    SprExport.Spr_HISpaceNavigatorIf_SetViewMatrix((IntPtr) _this, (IntPtr) view);
	}
	public void SetPersMatrix(Affinef pers) {
	    SprExport.Spr_HISpaceNavigatorIf_SetPersMatrix((IntPtr) _this, (IntPtr) pers);
	}
    }
    public partial class HISpidarMotorIf : HIBaseIf {
	public HISpidarMotorIf() { _this = SprExport.Spr_new_HISpidarMotorIf(); _flag = true; }
	public HISpidarMotorIf(IntPtr ptr) : base(ptr) {}
	public HISpidarMotorIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HISpidarMotorIf(CsCastObject target) {
		return (target._info.Inherit(HISpidarMotorIf.GetIfInfoStatic()) ? new HISpidarMotorIf(target._this, target._flag) : null);
	}
	~HISpidarMotorIf() { if (_flag) { SprExport.Spr_delete_HISpidarMotorIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HISpidarMotorIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HISpidarMotorIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HISpidarMotorIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HISpidarMotorIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void SetForce(float f) {
	    SprExport.Spr_HISpidarMotorIf_SetForce((IntPtr) _this, (float) f);
	}
	public float GetForce() {
	    float result = (float) SprExport.Spr_HISpidarMotorIf_GetForce((IntPtr) _this);
	    return result;
	}
	public void SetLimitMinForce(float f) {
	    SprExport.Spr_HISpidarMotorIf_SetLimitMinForce((IntPtr) _this, (float) f);
	}
	public void SetLimitMaxForce(float f) {
	    SprExport.Spr_HISpidarMotorIf_SetLimitMaxForce((IntPtr) _this, (float) f);
	}
	public Vec2f GetLimitForce() {
	    IntPtr ptr = SprExport.Spr_HISpidarMotorIf_GetLimitForce((IntPtr) _this);
            return new Vec2f(ptr, true);
	}
	public float GetCurrent() {
	    float result = (float) SprExport.Spr_HISpidarMotorIf_GetCurrent((IntPtr) _this);
	    return result;
	}
	public void SetLength(float l) {
	    SprExport.Spr_HISpidarMotorIf_SetLength((IntPtr) _this, (float) l);
	}
	public float GetLength() {
	    float result = (float) SprExport.Spr_HISpidarMotorIf_GetLength((IntPtr) _this);
	    return result;
	}
	public float GetVelocity() {
	    float result = (float) SprExport.Spr_HISpidarMotorIf_GetVelocity((IntPtr) _this);
	    return result;
	}
	public void GetCalibrationData(float dt) {
	    SprExport.Spr_HISpidarMotorIf_GetCalibrationData((IntPtr) _this, (float) dt);
	}
	public void Calibrate(bool bUpdate) {
	    SprExport.Spr_HISpidarMotorIf_Calibrate((IntPtr) _this, (bool) bUpdate);
	}
	public void GetVdd() {
	    SprExport.Spr_HISpidarMotorIf_GetVdd((IntPtr) _this);
	}
	public int GetCount() {
	    int result = (int) SprExport.Spr_HISpidarMotorIf_GetCount((IntPtr) _this);
	    return result;
	}
    }
    public partial class HISpidarIf : HIHapticIf {
	public HISpidarIf() { _this = SprExport.Spr_new_HISpidarIf(); _flag = true; }
	public HISpidarIf(IntPtr ptr) : base(ptr) {}
	public HISpidarIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HISpidarIf(CsCastObject target) {
		return (target._info.Inherit(HISpidarIf.GetIfInfoStatic()) ? new HISpidarIf(target._this, target._flag) : null);
	}
	~HISpidarIf() { if (_flag) { SprExport.Spr_delete_HISpidarIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HISpidarIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HISpidarIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HISpidarIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HISpidarIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public string GetSpidarType() {
	    IntPtr ptr = SprExport.Spr_HISpidarIf_GetSpidarType((IntPtr) _this);
	    return Marshal.PtrToStringAnsi(ptr);
	}
	public void SetLimitMinForce(float f) {
	    SprExport.Spr_HISpidarIf_SetLimitMinForce((IntPtr) _this, (float) f);
	}
	public void SetLimitMaxForce(float f) {
	    SprExport.Spr_HISpidarIf_SetLimitMaxForce((IntPtr) _this, (float) f);
	}
	public HISpidarMotorIf GetMotor(ulong i) {
	    IntPtr ptr = SprExport.Spr_HISpidarIf_GetMotor((IntPtr) _this, (ulong) i);
            if (ptr == IntPtr.Zero) { return null; } 
            HISpidarMotorIf obj = new HISpidarMotorIf(ptr);
            return obj;
	}
	public ulong NMotor() {
	    ulong result = (ulong) SprExport.Spr_HISpidarIf_NMotor((IntPtr) _this);
	    return result;
	}
    }
    public partial class HISpidar4If : HISpidarIf {
	public HISpidar4If() { _this = SprExport.Spr_new_HISpidar4If(); _flag = true; }
	public HISpidar4If(IntPtr ptr) : base(ptr) {}
	public HISpidar4If(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HISpidar4If(CsCastObject target) {
		return (target._info.Inherit(HISpidar4If.GetIfInfoStatic()) ? new HISpidar4If(target._this, target._flag) : null);
	}
	~HISpidar4If() { if (_flag) { SprExport.Spr_delete_HISpidar4If(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HISpidar4If_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HISpidar4If_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HISpidar4If_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HISpidar4If_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public HISpidarMotorIf GetMotor(ulong i) {
	    IntPtr ptr = SprExport.Spr_HISpidar4If_GetMotor((IntPtr) _this, (ulong) i);
            if (ptr == IntPtr.Zero) { return null; } 
            HISpidarMotorIf obj = new HISpidarMotorIf(ptr);
            return obj;
	}
	public ulong NMotor() {
	    ulong result = (ulong) SprExport.Spr_HISpidar4If_NMotor((IntPtr) _this);
	    return result;
	}
    }
    public partial class HISpidar4DIf : HISpidar4If {
	public HISpidar4DIf() { _this = SprExport.Spr_new_HISpidar4DIf(); _flag = true; }
	public HISpidar4DIf(IntPtr ptr) : base(ptr) {}
	public HISpidar4DIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HISpidar4DIf(CsCastObject target) {
		return (target._info.Inherit(HISpidar4DIf.GetIfInfoStatic()) ? new HISpidar4DIf(target._this, target._flag) : null);
	}
	~HISpidar4DIf() { if (_flag) { SprExport.Spr_delete_HISpidar4DIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HISpidar4DIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HISpidar4DIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HISpidar4DIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HISpidar4DIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
    public partial class HISpidarGIf : HISpidarIf {
	public HISpidarGIf() { _this = SprExport.Spr_new_HISpidarGIf(); _flag = true; }
	public HISpidarGIf(IntPtr ptr) : base(ptr) {}
	public HISpidarGIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HISpidarGIf(CsCastObject target) {
		return (target._info.Inherit(HISpidarGIf.GetIfInfoStatic()) ? new HISpidarGIf(target._this, target._flag) : null);
	}
	~HISpidarGIf() { if (_flag) { SprExport.Spr_delete_HISpidarGIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HISpidarGIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HISpidarGIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HISpidarGIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HISpidarGIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public Vec3f GetTorque() {
	    IntPtr ptr = SprExport.Spr_HISpidarGIf_GetTorque((IntPtr) _this);
            return new Vec3f(ptr, true);
	}
	public Vec3f GetForce() {
	    IntPtr ptr = SprExport.Spr_HISpidarGIf_GetForce((IntPtr) _this);
            return new Vec3f(ptr, true);
	}
	public void SetForce(Vec3f f, Vec3f t) {
	    SprExport.Spr_HISpidarGIf_SetForce((IntPtr) _this, (IntPtr) f, (IntPtr) t);
	}
	public HISpidarMotorIf GetMotor(ulong i) {
	    IntPtr ptr = SprExport.Spr_HISpidarGIf_GetMotor((IntPtr) _this, (ulong) i);
            if (ptr == IntPtr.Zero) { return null; } 
            HISpidarMotorIf obj = new HISpidarMotorIf(ptr);
            return obj;
	}
	public ulong NMotor() {
	    ulong result = (ulong) SprExport.Spr_HISpidarGIf_NMotor((IntPtr) _this);
	    return result;
	}
	public int GetButton(ulong i) {
	    int result = (int) SprExport.Spr_HISpidarGIf_GetButton((IntPtr) _this, (ulong) i);
	    return result;
	}
	public ulong NButton() {
	    ulong result = (ulong) SprExport.Spr_HISpidarGIf_NButton((IntPtr) _this);
	    return result;
	}
	public void SetWeight(float s, float t, float r) {
	    SprExport.Spr_HISpidarGIf_SetWeight((IntPtr) _this, (float) s, (float) t, (float) r);
	}
	public void SetWeight(float s, float t) {
	    SprExport.Spr_HISpidarGIf_SetWeight_1((IntPtr) _this, (float) s, (float) t);
	}
	public void SetWeight(float s) {
	    SprExport.Spr_HISpidarGIf_SetWeight_2((IntPtr) _this, (float) s);
	}
	public void SetWeight() {
	    SprExport.Spr_HISpidarGIf_SetWeight_3((IntPtr) _this);
	}
    }
    public partial class HITrackballIf : HIPoseIf {
	public HITrackballIf() { _this = SprExport.Spr_new_HITrackballIf(); _flag = true; }
	public HITrackballIf(IntPtr ptr) : base(ptr) {}
	public HITrackballIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HITrackballIf(CsCastObject target) {
		return (target._info.Inherit(HITrackballIf.GetIfInfoStatic()) ? new HITrackballIf(target._this, target._flag) : null);
	}
	~HITrackballIf() { if (_flag) { SprExport.Spr_delete_HITrackballIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HITrackballIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HITrackballIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HITrackballIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HITrackballIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void SetMode(bool mode) {
	    SprExport.Spr_HITrackballIf_SetMode((IntPtr) _this, (bool) mode);
	}
	public bool GetMode() {
	    char ret = SprExport.Spr_HITrackballIf_GetMode((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public void SetTarget(Vec3f t) {
	    SprExport.Spr_HITrackballIf_SetTarget((IntPtr) _this, (IntPtr) t);
	}
	public Vec3f GetTarget() {
	    IntPtr ptr = SprExport.Spr_HITrackballIf_GetTarget((IntPtr) _this);
            return new Vec3f(ptr, true);
	}
	public void SetAngle(float lon, float lat) {
	    SprExport.Spr_HITrackballIf_SetAngle((IntPtr) _this, (float) lon, (float) lat);
	}
	public void GetAngle(float lon, float lat) {
	    SprExport.Spr_HITrackballIf_GetAngle((IntPtr) _this, (float) lon, (float) lat);
	}
	public void SetDistance(float dist) {
	    SprExport.Spr_HITrackballIf_SetDistance((IntPtr) _this, (float) dist);
	}
	public float GetDistance() {
	    float result = (float) SprExport.Spr_HITrackballIf_GetDistance((IntPtr) _this);
	    return result;
	}
	public void SetLongitudeRange(float rmin, float rmax) {
	    SprExport.Spr_HITrackballIf_SetLongitudeRange((IntPtr) _this, (float) rmin, (float) rmax);
	}
	public void GetLongitudeRange(float rmin, float rmax) {
	    SprExport.Spr_HITrackballIf_GetLongitudeRange((IntPtr) _this, (float) rmin, (float) rmax);
	}
	public void SetLatitudeRange(float rmin, float rmax) {
	    SprExport.Spr_HITrackballIf_SetLatitudeRange((IntPtr) _this, (float) rmin, (float) rmax);
	}
	public void GetLatitudeRange(float rmin, float rmax) {
	    SprExport.Spr_HITrackballIf_GetLatitudeRange((IntPtr) _this, (float) rmin, (float) rmax);
	}
	public void SetDistanceRange(float rmin, float rmax) {
	    SprExport.Spr_HITrackballIf_SetDistanceRange((IntPtr) _this, (float) rmin, (float) rmax);
	}
	public void GetDistanceRange(float rmin, float rmax) {
	    SprExport.Spr_HITrackballIf_GetDistanceRange((IntPtr) _this, (float) rmin, (float) rmax);
	}
	public void SetRotGain(float g) {
	    SprExport.Spr_HITrackballIf_SetRotGain((IntPtr) _this, (float) g);
	}
	public float GetRotGain() {
	    float result = (float) SprExport.Spr_HITrackballIf_GetRotGain((IntPtr) _this);
	    return result;
	}
	public void SetZoomGain(float g) {
	    SprExport.Spr_HITrackballIf_SetZoomGain((IntPtr) _this, (float) g);
	}
	public float GetZoomGain() {
	    float result = (float) SprExport.Spr_HITrackballIf_GetZoomGain((IntPtr) _this);
	    return result;
	}
	public void SetTrnGain(float g) {
	    SprExport.Spr_HITrackballIf_SetTrnGain((IntPtr) _this, (float) g);
	}
	public float GetTrnGain() {
	    float result = (float) SprExport.Spr_HITrackballIf_GetTrnGain((IntPtr) _this);
	    return result;
	}
	public void Fit(GRCameraDesc cam, float radius) {
	    SprExport.Spr_HITrackballIf_Fit((IntPtr) _this, (IntPtr) cam, (float) radius);
	}
	public void SetPosition(Vec3f pos) {
	    SprExport.Spr_HITrackballIf_SetPosition((IntPtr) _this, (IntPtr) pos);
	}
	public void SetOrientation(Quaternionf ori) {
	    SprExport.Spr_HITrackballIf_SetOrientation((IntPtr) _this, (IntPtr) ori);
	}
	public void Enable(bool on) {
	    SprExport.Spr_HITrackballIf_Enable((IntPtr) _this, (bool) on);
	}
	public void Enable() {
	    SprExport.Spr_HITrackballIf_Enable_1((IntPtr) _this);
	}
	public void SetRotMask(int mask) {
	    SprExport.Spr_HITrackballIf_SetRotMask((IntPtr) _this, (int) mask);
	}
	public void SetZoomMask(int mask) {
	    SprExport.Spr_HITrackballIf_SetZoomMask((IntPtr) _this, (int) mask);
	}
	public void SetTrnMask(int mask) {
	    SprExport.Spr_HITrackballIf_SetTrnMask((IntPtr) _this, (int) mask);
	}
	public DVKeyMouseIf GetKeyMouse() {
	    IntPtr ptr = SprExport.Spr_HITrackballIf_GetKeyMouse((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            DVKeyMouseIf obj = new DVKeyMouseIf(ptr);
            return obj;
	}
	public void SetKeyMouse(DVKeyMouseIf dv) {
	    SprExport.Spr_HITrackballIf_SetKeyMouse((IntPtr) _this, (IntPtr) dv);
	}
	public void SetCallback(HITrackballCallback callback) {
	    SprExport.Spr_HITrackballIf_SetCallback((IntPtr) _this, (IntPtr) callback);
	}
	public void UpdateView() {
	    SprExport.Spr_HITrackballIf_UpdateView((IntPtr) _this);
	}
    }
    public partial class HIXbox360ControllerIf : HIHapticIf {
	public HIXbox360ControllerIf() { _this = SprExport.Spr_new_HIXbox360ControllerIf(); _flag = true; }
	public HIXbox360ControllerIf(IntPtr ptr) : base(ptr) {}
	public HIXbox360ControllerIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator HIXbox360ControllerIf(CsCastObject target) {
		return (target._info.Inherit(HIXbox360ControllerIf.GetIfInfoStatic()) ? new HIXbox360ControllerIf(target._this, target._flag) : null);
	}
	~HIXbox360ControllerIf() { if (_flag) { SprExport.Spr_delete_HIXbox360ControllerIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_HIXbox360ControllerIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_HIXbox360ControllerIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_HIXbox360ControllerIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_HIXbox360ControllerIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool Init() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_Init((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public void SetMaxVelocity(float v) {
	    SprExport.Spr_HIXbox360ControllerIf_SetMaxVelocity((IntPtr) _this, (float) v);
	}
	public void SetMaxAngularVelocity(float v) {
	    SprExport.Spr_HIXbox360ControllerIf_SetMaxAngularVelocity((IntPtr) _this, (float) v);
	}
	public void SetVibration(Vec2f lr) {
	    SprExport.Spr_HIXbox360ControllerIf_SetVibration((IntPtr) _this, (IntPtr) lr);
	}
	public bool UP() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_UP((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool DOWN() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_DOWN((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool LEFT() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_LEFT((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool RIGHT() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_RIGHT((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool START() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_START((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool BACK() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_BACK((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool LTHUMB() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_LTHUMB((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool RTHUMB() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_RTHUMB((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool LSHOULDER() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_LSHOULDER((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool RSHOULDER() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_RSHOULDER((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool A() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_A((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool B() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_B((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool X() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_X((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool Y() {
	    char ret = SprExport.Spr_HIXbox360ControllerIf_Y((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
    }
	public partial class IfInfoToCsType {
		public static Dictionary<IntPtr, Type> mapHumanInterface = new Dictionary<IntPtr, Type>() {
			{HIBaseIf.GetIfInfoStatic(), typeof(HIBaseIf)},
			{HIPoseIf.GetIfInfoStatic(), typeof(HIPoseIf)},
			{HIHapticIf.GetIfInfoStatic(), typeof(HIHapticIf)},
			{HIHapticDummyIf.GetIfInfoStatic(), typeof(HIHapticDummyIf)},
			{HIDeviceIf.GetIfInfoStatic(), typeof(HIDeviceIf)},
			{HIRealDeviceIf.GetIfInfoStatic(), typeof(HIRealDeviceIf)},
			{HIVirtualDeviceIf.GetIfInfoStatic(), typeof(HIVirtualDeviceIf)},
			{DVAdIf.GetIfInfoStatic(), typeof(DVAdIf)},
			{DVDaIf.GetIfInfoStatic(), typeof(DVDaIf)},
			{DVCounterIf.GetIfInfoStatic(), typeof(DVCounterIf)},
			{DVPioIf.GetIfInfoStatic(), typeof(DVPioIf)},
			{DVForceIf.GetIfInfoStatic(), typeof(DVForceIf)},
			{DRUsb20SimpleIf.GetIfInfoStatic(), typeof(DRUsb20SimpleIf)},
			{DRUsb20Sh4If.GetIfInfoStatic(), typeof(DRUsb20Sh4If)},
			{DRCyUsb20Sh4If.GetIfInfoStatic(), typeof(DRCyUsb20Sh4If)},
			{DVJoyStickIf.GetIfInfoStatic(), typeof(DVJoyStickIf)},
			{DVKeyMouseIf.GetIfInfoStatic(), typeof(DVKeyMouseIf)},
			{DRKeyMouseWin32If.GetIfInfoStatic(), typeof(DRKeyMouseWin32If)},
			{HIBoneIf.GetIfInfoStatic(), typeof(HIBoneIf)},
			{HISkeletonIf.GetIfInfoStatic(), typeof(HISkeletonIf)},
			{HISkeletonSensorIf.GetIfInfoStatic(), typeof(HISkeletonSensorIf)},
			{HILeapIf.GetIfInfoStatic(), typeof(HILeapIf)},
			{HILeapUDPIf.GetIfInfoStatic(), typeof(HILeapUDPIf)},
			{HINovintFalconIf.GetIfInfoStatic(), typeof(HINovintFalconIf)},
			{HISdkIf.GetIfInfoStatic(), typeof(HISdkIf)},
			{HISpaceNavigatorIf.GetIfInfoStatic(), typeof(HISpaceNavigatorIf)},
			{HISpidarMotorIf.GetIfInfoStatic(), typeof(HISpidarMotorIf)},
			{HISpidarIf.GetIfInfoStatic(), typeof(HISpidarIf)},
			{HISpidar4If.GetIfInfoStatic(), typeof(HISpidar4If)},
			{HISpidar4DIf.GetIfInfoStatic(), typeof(HISpidar4DIf)},
			{HISpidarGIf.GetIfInfoStatic(), typeof(HISpidarGIf)},
			{HITrackballIf.GetIfInfoStatic(), typeof(HITrackballIf)},
			{HIXbox360ControllerIf.GetIfInfoStatic(), typeof(HIXbox360ControllerIf)},
		};
	}
}
