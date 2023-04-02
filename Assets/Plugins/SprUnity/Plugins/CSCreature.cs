using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
#pragma warning disable 0108
namespace SprCs {
    public partial class CRBodyDesc : CsObject {
	public CRBodyDesc() { _this = SprExport.Spr_new_CRBodyDesc(); _flag = true; }
	public CRBodyDesc(IntPtr ptr) : base(ptr) {}
	public CRBodyDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~CRBodyDesc() { if (_flag) { SprExport.Spr_delete_CRBodyDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class CRBodyDescStruct : CsObject {
        public CRBodyDescStruct() {
            CRBodyDesc desc = new CRBodyDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] CRBodyDesc
	public void ApplyTo(CRBodyDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(CRBodyDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator CRBodyDesc(CRBodyDescStruct m) {
	    CRBodyDesc r = new CRBodyDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator CRBodyDescStruct(CRBodyDesc r) {
	    CRBodyDescStruct m = new CRBodyDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class CRBoneDesc : CsObject {
	public CRBoneDesc() { _this = SprExport.Spr_new_CRBoneDesc(); _flag = true; }
	public CRBoneDesc(IntPtr ptr) : base(ptr) {}
	public CRBoneDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~CRBoneDesc() { if (_flag) { SprExport.Spr_delete_CRBoneDesc(_this); _flag = false; } }
	public string label {
	    get {
	        IntPtr ptr = SprExport.Spr_CRBoneDesc_get_label(_this);
	        string bstr = Marshal.PtrToStringBSTR(ptr);
	        SprExport.Spr_CRBoneDesc_FreeString_label(ptr);
	        return bstr;
	    }
	    set {
	        IntPtr pbstr = Marshal.StringToBSTR(value);
	        SprExport.Spr_CRBoneDesc_set_label(_this, pbstr);
	    }
	}
    }
    [System.Serializable]
    public class CRBoneDescStruct : CsObject {
        public CRBoneDescStruct() {
            CRBoneDesc desc = new CRBoneDesc();
            ApplyFrom(desc, false);
        }
	public string label;
// _[Find class node: 2916] CRBoneDesc
	public void ApplyTo(CRBoneDesc r, bool apply_to_base_class=true) {
		r.label = label;
	}
	public void ApplyFrom(CRBoneDesc r, bool apply_to_base_class=true) {
		label = r.label;
	}
	public static implicit operator CRBoneDesc(CRBoneDescStruct m) {
	    CRBoneDesc r = new CRBoneDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator CRBoneDescStruct(CRBoneDesc r) {
	    CRBoneDescStruct m = new CRBoneDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class CREngineDesc : CsObject {
	public CREngineDesc() { _this = SprExport.Spr_new_CREngineDesc(); _flag = true; }
	public CREngineDesc(IntPtr ptr) : base(ptr) {}
	public CREngineDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~CREngineDesc() { if (_flag) { SprExport.Spr_delete_CREngineDesc(_this); _flag = false; } }
	public enum CREnginePriority : int {
	    CREP_SENSOR, CREP_DECISION, CREP_CONTROLLER
	}
    }
    [System.Serializable]
    public class CREngineDescStruct : CsObject {
        public CREngineDescStruct() {
            CREngineDesc desc = new CREngineDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] CREngineDesc
	public void ApplyTo(CREngineDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(CREngineDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator CREngineDesc(CREngineDescStruct m) {
	    CREngineDesc r = new CREngineDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator CREngineDescStruct(CREngineDesc r) {
	    CREngineDescStruct m = new CREngineDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class CRControllerDesc : CREngineDesc {
	public CRControllerDesc() { _this = SprExport.Spr_new_CRControllerDesc(); _flag = true; }
	public CRControllerDesc(IntPtr ptr) : base(ptr) {}
	public CRControllerDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~CRControllerDesc() { if (_flag) { SprExport.Spr_delete_CRControllerDesc(_this); _flag = false; } }
	public enum CRControllerStatus : int {
	    CS_WAITING, CS_WORKING = CS_WAITING + 1, CS_DONE = CS_WORKING + 1, CS_FAILED = CS_DONE + 1
	}
    }
    [System.Serializable]
    public class CRControllerDescStruct : CREngineDescStruct {
        public CRControllerDescStruct() {
            CRControllerDesc desc = new CRControllerDesc();
            ApplyFrom(desc, true);
        }
// _[Find class node: 2916] CRControllerDesc
	public void ApplyTo(CRControllerDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyTo((CREngineDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(CRControllerDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyFrom((CREngineDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator CRControllerDesc(CRControllerDescStruct m) {
	    CRControllerDesc r = new CRControllerDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator CRControllerDescStruct(CRControllerDesc r) {
	    CRControllerDescStruct m = new CRControllerDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class CRGazeControllerDesc : CsObject {
	public CRGazeControllerDesc() { _this = SprExport.Spr_new_CRGazeControllerDesc(); _flag = true; }
	public CRGazeControllerDesc(IntPtr ptr) : base(ptr) {}
	public CRGazeControllerDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~CRGazeControllerDesc() { if (_flag) { SprExport.Spr_delete_CRGazeControllerDesc(_this); _flag = false; } }
	public Vec3d front {
	    get { return new Vec3d(SprExport.Spr_CRGazeControllerDesc_addr_front(_this)); }
	    set { SprExport.Spr_CRGazeControllerDesc_set_front(_this, value); }
	}
	public Vec3d up {
	    get { return new Vec3d(SprExport.Spr_CRGazeControllerDesc_addr_up(_this)); }
	    set { SprExport.Spr_CRGazeControllerDesc_set_up(_this, value); }
	}
    }
    [System.Serializable]
    public class CRGazeControllerDescStruct : CsObject {
        public CRGazeControllerDescStruct() {
            CRGazeControllerDesc desc = new CRGazeControllerDesc();
            ApplyFrom(desc, false);
        }
	public Vec3dStruct front;
	public Vec3dStruct up;
// _[Find class node: 2916] CRGazeControllerDesc
	public void ApplyTo(CRGazeControllerDesc r, bool apply_to_base_class=true) {
		r.front = front;
		r.up = up;
	}
	public void ApplyFrom(CRGazeControllerDesc r, bool apply_to_base_class=true) {
		front = r.front;
		up = r.up;
	}
	public static implicit operator CRGazeControllerDesc(CRGazeControllerDescStruct m) {
	    CRGazeControllerDesc r = new CRGazeControllerDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator CRGazeControllerDescStruct(CRGazeControllerDesc r) {
	    CRGazeControllerDescStruct m = new CRGazeControllerDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class CRGrabControllerDesc : CRControllerDesc {
	public CRGrabControllerDesc() { _this = SprExport.Spr_new_CRGrabControllerDesc(); _flag = true; }
	public CRGrabControllerDesc(IntPtr ptr) : base(ptr) {}
	public CRGrabControllerDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~CRGrabControllerDesc() { if (_flag) { SprExport.Spr_delete_CRGrabControllerDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class CRGrabControllerDescStruct : CRControllerDescStruct {
        public CRGrabControllerDescStruct() {
            CRGrabControllerDesc desc = new CRGrabControllerDesc();
            ApplyFrom(desc, true);
        }
// _[Find class node: 2916] CRGrabControllerDesc
	public void ApplyTo(CRGrabControllerDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyTo((CRControllerDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(CRGrabControllerDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyFrom((CRControllerDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator CRGrabControllerDesc(CRGrabControllerDescStruct m) {
	    CRGrabControllerDesc r = new CRGrabControllerDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator CRGrabControllerDescStruct(CRGrabControllerDesc r) {
	    CRGrabControllerDescStruct m = new CRGrabControllerDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class CRCreatureDesc : CsObject {
	public CRCreatureDesc() { _this = SprExport.Spr_new_CRCreatureDesc(); _flag = true; }
	public CRCreatureDesc(IntPtr ptr) : base(ptr) {}
	public CRCreatureDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~CRCreatureDesc() { if (_flag) { SprExport.Spr_delete_CRCreatureDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class CRCreatureDescStruct : CsObject {
        public CRCreatureDescStruct() {
            CRCreatureDesc desc = new CRCreatureDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] CRCreatureDesc
	public void ApplyTo(CRCreatureDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(CRCreatureDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator CRCreatureDesc(CRCreatureDescStruct m) {
	    CRCreatureDesc r = new CRCreatureDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator CRCreatureDescStruct(CRCreatureDesc r) {
	    CRCreatureDescStruct m = new CRCreatureDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class CRReachControllerState : CsObject {
	public CRReachControllerState() { _this = SprExport.Spr_new_CRReachControllerState(); _flag = true; }
	public CRReachControllerState(IntPtr ptr) : base(ptr) {}
	public CRReachControllerState(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~CRReachControllerState() { if (_flag) { SprExport.Spr_delete_CRReachControllerState(_this); _flag = false; } }
	public float time {
	    get { return SprExport.Spr_CRReachControllerState_get_time(_this); }
	    set { SprExport.Spr_CRReachControllerState_set_time(_this, value); }
	}
	public float reachTime {
	    get { return SprExport.Spr_CRReachControllerState_get_reachTime(_this); }
	    set { SprExport.Spr_CRReachControllerState_set_reachTime(_this, value); }
	}
	public float viaTime {
	    get { return SprExport.Spr_CRReachControllerState_get_viaTime(_this); }
	    set { SprExport.Spr_CRReachControllerState_set_viaTime(_this, value); }
	}
	public float oricontTimeRatio {
	    get { return SprExport.Spr_CRReachControllerState_get_oricontTimeRatio(_this); }
	    set { SprExport.Spr_CRReachControllerState_set_oricontTimeRatio(_this, value); }
	}
	public Vec3d initPos {
	    get { return new Vec3d(SprExport.Spr_CRReachControllerState_addr_initPos(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_initPos(_this, value); }
	}
	public Vec3d initVel {
	    get { return new Vec3d(SprExport.Spr_CRReachControllerState_addr_initVel(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_initVel(_this, value); }
	}
	public Vec3d initAVel {
	    get { return new Vec3d(SprExport.Spr_CRReachControllerState_addr_initAVel(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_initAVel(_this, value); }
	}
	public Quaterniond initOri {
	    get { return new Quaterniond(SprExport.Spr_CRReachControllerState_addr_initOri(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_initOri(_this, value); }
	}
	public Vec3d viaPos {
	    get { return new Vec3d(SprExport.Spr_CRReachControllerState_addr_viaPos(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_viaPos(_this, value); }
	}
	public Quaterniond viaOri {
	    get { return new Quaterniond(SprExport.Spr_CRReachControllerState_addr_viaOri(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_viaOri(_this, value); }
	}
	public Vec3d targPos {
	    get { return new Vec3d(SprExport.Spr_CRReachControllerState_addr_targPos(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_targPos(_this, value); }
	}
	public Vec3d targVel {
	    get { return new Vec3d(SprExport.Spr_CRReachControllerState_addr_targVel(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_targVel(_this, value); }
	}
	public Vec3d targAVel {
	    get { return new Vec3d(SprExport.Spr_CRReachControllerState_addr_targAVel(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_targAVel(_this, value); }
	}
	public Quaterniond targOri {
	    get { return new Quaterniond(SprExport.Spr_CRReachControllerState_addr_targOri(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_targOri(_this, value); }
	}
	public Vec3d currPos {
	    get { return new Vec3d(SprExport.Spr_CRReachControllerState_addr_currPos(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_currPos(_this, value); }
	}
	public Vec3d currVel {
	    get { return new Vec3d(SprExport.Spr_CRReachControllerState_addr_currVel(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_currVel(_this, value); }
	}
	public Vec3d currAVel {
	    get { return new Vec3d(SprExport.Spr_CRReachControllerState_addr_currAVel(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_currAVel(_this, value); }
	}
	public Quaterniond currOri {
	    get { return new Quaterniond(SprExport.Spr_CRReachControllerState_addr_currOri(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_currOri(_this, value); }
	}
	public Vec3d finalPos {
	    get { return new Vec3d(SprExport.Spr_CRReachControllerState_addr_finalPos(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_finalPos(_this, value); }
	}
	public Vec3d finalVel {
	    get { return new Vec3d(SprExport.Spr_CRReachControllerState_addr_finalVel(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_finalVel(_this, value); }
	}
	public Vec3d finalAVel {
	    get { return new Vec3d(SprExport.Spr_CRReachControllerState_addr_finalAVel(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_finalAVel(_this, value); }
	}
	public Quaterniond finalOri {
	    get { return new Quaterniond(SprExport.Spr_CRReachControllerState_addr_finalOri(_this)); }
	    set { SprExport.Spr_CRReachControllerState_set_finalOri(_this, value); }
	}
    }
    [System.Serializable]
    public class CRReachControllerStateStruct : CsObject {
        public CRReachControllerStateStruct() {
            CRReachControllerState desc = new CRReachControllerState();
            ApplyFrom(desc, false);
        }
	public float time;
	public float reachTime;
	public float viaTime;
	public float oricontTimeRatio;
	public Vec3dStruct initPos;
	public Vec3dStruct initVel;
	public Vec3dStruct initAVel;
	public QuaterniondStruct initOri;
	public Vec3dStruct viaPos;
	public QuaterniondStruct viaOri;
	public Vec3dStruct targPos;
	public Vec3dStruct targVel;
	public Vec3dStruct targAVel;
	public QuaterniondStruct targOri;
	public Vec3dStruct currPos;
	public Vec3dStruct currVel;
	public Vec3dStruct currAVel;
	public QuaterniondStruct currOri;
	public Vec3dStruct finalPos;
	public Vec3dStruct finalVel;
	public Vec3dStruct finalAVel;
	public QuaterniondStruct finalOri;
// _[Find class node: 2916] CRReachControllerState
	public void ApplyTo(CRReachControllerState r, bool apply_to_base_class=true) {
		r.time = time;
		r.reachTime = reachTime;
		r.viaTime = viaTime;
		r.oricontTimeRatio = oricontTimeRatio;
		r.initPos = initPos;
		r.initVel = initVel;
		r.initAVel = initAVel;
		r.initOri = initOri;
		r.viaPos = viaPos;
		r.viaOri = viaOri;
		r.targPos = targPos;
		r.targVel = targVel;
		r.targAVel = targAVel;
		r.targOri = targOri;
		r.currPos = currPos;
		r.currVel = currVel;
		r.currAVel = currAVel;
		r.currOri = currOri;
		r.finalPos = finalPos;
		r.finalVel = finalVel;
		r.finalAVel = finalAVel;
		r.finalOri = finalOri;
	}
	public void ApplyFrom(CRReachControllerState r, bool apply_to_base_class=true) {
		time = r.time;
		reachTime = r.reachTime;
		viaTime = r.viaTime;
		oricontTimeRatio = r.oricontTimeRatio;
		initPos = r.initPos;
		initVel = r.initVel;
		initAVel = r.initAVel;
		initOri = r.initOri;
		viaPos = r.viaPos;
		viaOri = r.viaOri;
		targPos = r.targPos;
		targVel = r.targVel;
		targAVel = r.targAVel;
		targOri = r.targOri;
		currPos = r.currPos;
		currVel = r.currVel;
		currAVel = r.currAVel;
		currOri = r.currOri;
		finalPos = r.finalPos;
		finalVel = r.finalVel;
		finalAVel = r.finalAVel;
		finalOri = r.finalOri;
	}
	public static implicit operator CRReachControllerState(CRReachControllerStateStruct m) {
	    CRReachControllerState r = new CRReachControllerState();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator CRReachControllerStateStruct(CRReachControllerState r) {
	    CRReachControllerStateStruct m = new CRReachControllerStateStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class CRReachControllerDesc : CRControllerDesc {
	public CRReachControllerDesc() { _this = SprExport.Spr_new_CRReachControllerDesc(); _flag = true; }
	public CRReachControllerDesc(IntPtr ptr) : base(ptr) {}
	public CRReachControllerDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~CRReachControllerDesc() { if (_flag) { SprExport.Spr_delete_CRReachControllerDesc(_this); _flag = false; } }
	public double margin {
	    get { return SprExport.Spr_CRReachControllerDesc_get_margin(_this); }
	    set { SprExport.Spr_CRReachControllerDesc_set_margin(_this, value); }
	}
	public double innerMargin {
	    get { return SprExport.Spr_CRReachControllerDesc_get_innerMargin(_this); }
	    set { SprExport.Spr_CRReachControllerDesc_set_innerMargin(_this, value); }
	}
	public double averageSpeed {
	    get { return SprExport.Spr_CRReachControllerDesc_get_averageSpeed(_this); }
	    set { SprExport.Spr_CRReachControllerDesc_set_averageSpeed(_this, value); }
	}
	public double waitVel {
	    get { return SprExport.Spr_CRReachControllerDesc_get_waitVel(_this); }
	    set { SprExport.Spr_CRReachControllerDesc_set_waitVel(_this, value); }
	}
	public double restartVel {
	    get { return SprExport.Spr_CRReachControllerDesc_get_restartVel(_this); }
	    set { SprExport.Spr_CRReachControllerDesc_set_restartVel(_this, value); }
	}
    }
    [System.Serializable]
    public class CRReachControllerDescStruct : CRReachControllerStateStruct {
        public CRReachControllerDescStruct() {
            CRReachControllerDesc desc = new CRReachControllerDesc();
            ApplyFrom(desc, false);
        }
	public double margin;
	public double innerMargin;
	public double averageSpeed;
	public double waitVel;
	public double restartVel;
// _[Find class node: 2916] CRReachControllerDesc
	public void ApplyTo(CRReachControllerDesc r, bool apply_to_base_class=true) {
		r.margin = margin;
		r.innerMargin = innerMargin;
		r.averageSpeed = averageSpeed;
		r.waitVel = waitVel;
		r.restartVel = restartVel;
	}
	public void ApplyFrom(CRReachControllerDesc r, bool apply_to_base_class=true) {
		margin = r.margin;
		innerMargin = r.innerMargin;
		averageSpeed = r.averageSpeed;
		waitVel = r.waitVel;
		restartVel = r.restartVel;
	}
	public static implicit operator CRReachControllerDesc(CRReachControllerDescStruct m) {
	    CRReachControllerDesc r = new CRReachControllerDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator CRReachControllerDescStruct(CRReachControllerDesc r) {
	    CRReachControllerDescStruct m = new CRReachControllerDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class CRSdkDesc : CsObject {
	public CRSdkDesc() { _this = SprExport.Spr_new_CRSdkDesc(); _flag = true; }
	public CRSdkDesc(IntPtr ptr) : base(ptr) {}
	public CRSdkDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~CRSdkDesc() { if (_flag) { SprExport.Spr_delete_CRSdkDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class CRSdkDescStruct : CsObject {
        public CRSdkDescStruct() {
            CRSdkDesc desc = new CRSdkDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] CRSdkDesc
	public void ApplyTo(CRSdkDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(CRSdkDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator CRSdkDesc(CRSdkDescStruct m) {
	    CRSdkDesc r = new CRSdkDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator CRSdkDescStruct(CRSdkDesc r) {
	    CRSdkDescStruct m = new CRSdkDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class CRContactInfo : CsObject {
	public CRContactInfo() { _this = SprExport.Spr_new_CRContactInfo(); _flag = true; }
	public CRContactInfo(IntPtr ptr) : base(ptr) {}
	public CRContactInfo(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~CRContactInfo() { if (_flag) { SprExport.Spr_delete_CRContactInfo(_this); _flag = false; } }
	public double dimension {
	    get { return SprExport.Spr_CRContactInfo_get_dimension(_this); }
	    set { SprExport.Spr_CRContactInfo_set_dimension(_this, value); }
	}
	public Vec3d normal {
	    get { return new Vec3d(SprExport.Spr_CRContactInfo_addr_normal(_this)); }
	    set { SprExport.Spr_CRContactInfo_set_normal(_this, value); }
	}
	public double pressure {
	    get { return SprExport.Spr_CRContactInfo_get_pressure(_this); }
	    set { SprExport.Spr_CRContactInfo_set_pressure(_this, value); }
	}
	public Vec3d pos {
	    get { return new Vec3d(SprExport.Spr_CRContactInfo_addr_pos(_this)); }
	    set { SprExport.Spr_CRContactInfo_set_pos(_this, value); }
	}
	public PHSolidIf soMe {
	    get { return new PHSolidIf(SprExport.Spr_CRContactInfo_get_soMe(_this)); }
	    set { SprExport.Spr_CRContactInfo_set_soMe(_this, value); }
	}
	public PHSolidIf soOther {
	    get { return new PHSolidIf(SprExport.Spr_CRContactInfo_get_soOther(_this)); }
	    set { SprExport.Spr_CRContactInfo_set_soOther(_this, value); }
	}
	public Vec3d force {
	    get { return new Vec3d(SprExport.Spr_CRContactInfo_addr_force(_this)); }
	    set { SprExport.Spr_CRContactInfo_set_force(_this, value); }
	}
    }
    public partial class CRTouchSensorDesc : CREngineDesc {
	public CRTouchSensorDesc() { _this = SprExport.Spr_new_CRTouchSensorDesc(); _flag = true; }
	public CRTouchSensorDesc(IntPtr ptr) : base(ptr) {}
	public CRTouchSensorDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~CRTouchSensorDesc() { if (_flag) { SprExport.Spr_delete_CRTouchSensorDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class CRTouchSensorDescStruct : CREngineDescStruct {
        public CRTouchSensorDescStruct() {
            CRTouchSensorDesc desc = new CRTouchSensorDesc();
            ApplyFrom(desc, true);
        }
// _[Find class node: 2916] CRTouchSensorDesc
	public void ApplyTo(CRTouchSensorDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyTo((CREngineDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(CRTouchSensorDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyFrom((CREngineDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator CRTouchSensorDesc(CRTouchSensorDescStruct m) {
	    CRTouchSensorDesc r = new CRTouchSensorDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator CRTouchSensorDescStruct(CRTouchSensorDesc r) {
	    CRTouchSensorDescStruct m = new CRTouchSensorDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class CRVisualInfo : CsObject {
	public CRVisualInfo() { _this = SprExport.Spr_new_CRVisualInfo(); _flag = true; }
	public CRVisualInfo(IntPtr ptr) : base(ptr) {}
	public CRVisualInfo(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~CRVisualInfo() { if (_flag) { SprExport.Spr_delete_CRVisualInfo(_this); _flag = false; } }
	public Vec3d posWorld {
	    get { return new Vec3d(SprExport.Spr_CRVisualInfo_addr_posWorld(_this)); }
	    set { SprExport.Spr_CRVisualInfo_set_posWorld(_this, value); }
	}
	public Vec3d posLocal {
	    get { return new Vec3d(SprExport.Spr_CRVisualInfo_addr_posLocal(_this)); }
	    set { SprExport.Spr_CRVisualInfo_set_posLocal(_this, value); }
	}
	public Vec3d velWorld {
	    get { return new Vec3d(SprExport.Spr_CRVisualInfo_addr_velWorld(_this)); }
	    set { SprExport.Spr_CRVisualInfo_set_velWorld(_this, value); }
	}
	public Vec3d velLocal {
	    get { return new Vec3d(SprExport.Spr_CRVisualInfo_addr_velLocal(_this)); }
	    set { SprExport.Spr_CRVisualInfo_set_velLocal(_this, value); }
	}
	public double angle {
	    get { return SprExport.Spr_CRVisualInfo_get_angle(_this); }
	    set { SprExport.Spr_CRVisualInfo_set_angle(_this, value); }
	}
	public PHSolidIf solid {
	    get { return new PHSolidIf(SprExport.Spr_CRVisualInfo_get_solid(_this)); }
	    set { SprExport.Spr_CRVisualInfo_set_solid(_this, value); }
	}
	public PHSolidIf solidSensor {
	    get { return new PHSolidIf(SprExport.Spr_CRVisualInfo_get_solidSensor(_this)); }
	    set { SprExport.Spr_CRVisualInfo_set_solidSensor(_this, value); }
	}
	public Posed sensorPose {
	    get { return new Posed(SprExport.Spr_CRVisualInfo_addr_sensorPose(_this)); }
	    set { SprExport.Spr_CRVisualInfo_set_sensorPose(_this, value); }
	}
	public bool bMyBody {
	    get {
	        byte ret = (byte) SprExport.Spr_CRVisualInfo_get_bMyBody(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_CRVisualInfo_set_bMyBody(_this, (char) val);
	    }
	}
	public bool bCenter {
	    get {
	        byte ret = (byte) SprExport.Spr_CRVisualInfo_get_bCenter(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_CRVisualInfo_set_bCenter(_this, (char) val);
	    }
	}
    }
    public partial class CRVisualSensorDesc : CREngineDesc {
	public CRVisualSensorDesc() { _this = SprExport.Spr_new_CRVisualSensorDesc(); _flag = true; }
	public CRVisualSensorDesc(IntPtr ptr) : base(ptr) {}
	public CRVisualSensorDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~CRVisualSensorDesc() { if (_flag) { SprExport.Spr_delete_CRVisualSensorDesc(_this); _flag = false; } }
	public Vec2d range {
	    get { return new Vec2d(SprExport.Spr_CRVisualSensorDesc_addr_range(_this)); }
	    set { SprExport.Spr_CRVisualSensorDesc_set_range(_this, value); }
	}
	public Vec2d centerRange {
	    get { return new Vec2d(SprExport.Spr_CRVisualSensorDesc_addr_centerRange(_this)); }
	    set { SprExport.Spr_CRVisualSensorDesc_set_centerRange(_this, value); }
	}
	public Posed pose {
	    get { return new Posed(SprExport.Spr_CRVisualSensorDesc_addr_pose(_this)); }
	    set { SprExport.Spr_CRVisualSensorDesc_set_pose(_this, value); }
	}
	public float limitDistance {
	    get { return SprExport.Spr_CRVisualSensorDesc_get_limitDistance(_this); }
	    set { SprExport.Spr_CRVisualSensorDesc_set_limitDistance(_this, value); }
	}
    }
    [System.Serializable]
    public class CRVisualSensorDescStruct : CREngineDescStruct {
        public CRVisualSensorDescStruct() {
            CRVisualSensorDesc desc = new CRVisualSensorDesc();
            ApplyFrom(desc, true);
        }
	public Vec2dStruct range;
	public Vec2dStruct centerRange;
	public PosedStruct pose;
	public float limitDistance;
// _[Find class node: 2916] CRVisualSensorDesc
	public void ApplyTo(CRVisualSensorDesc r, bool apply_to_base_class=true) {
		r.range = range;
		r.centerRange = centerRange;
		r.pose = pose;
		r.limitDistance = limitDistance;
		if (apply_to_base_class) {
		    base.ApplyTo((CREngineDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(CRVisualSensorDesc r, bool apply_to_base_class=true) {
		range = r.range;
		centerRange = r.centerRange;
		pose = r.pose;
		limitDistance = r.limitDistance;
		if (apply_to_base_class) {
		    base.ApplyFrom((CREngineDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator CRVisualSensorDesc(CRVisualSensorDescStruct m) {
	    CRVisualSensorDesc r = new CRVisualSensorDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator CRVisualSensorDescStruct(CRVisualSensorDesc r) {
	    CRVisualSensorDescStruct m = new CRVisualSensorDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class CRBodyIf : SceneObjectIf {
	public CRBodyIf() { _this = SprExport.Spr_new_CRBodyIf(); _flag = true; }
	public CRBodyIf(IntPtr ptr) : base(ptr) {}
	public CRBodyIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator CRBodyIf(CsCastObject target) {
		return (target._info.Inherit(CRBodyIf.GetIfInfoStatic()) ? new CRBodyIf(target._this, target._flag) : null);
	}
	~CRBodyIf() { if (_flag) { SprExport.Spr_delete_CRBodyIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_CRBodyIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_CRBodyIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_CRBodyIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_CRBodyIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public CRBoneIf FindByIKActuator(PHIKActuatorIf actuator) {
	    IntPtr ptr = SprExport.Spr_CRBodyIf_FindByIKActuator((IntPtr) _this, (IntPtr) actuator);
            if (ptr == IntPtr.Zero) { return null; } 
            CRBoneIf obj = new CRBoneIf(ptr);
            return obj;
	}
	public CRBoneIf FindByLabel(string label) {
            IntPtr remote1 = Marshal.StringToBSTR(label);
	    IntPtr ptr = SprExport.Spr_CRBodyIf_FindByLabel((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            CRBoneIf obj = new CRBoneIf(ptr);
            return obj;
	}
	public int NBones() {
	    int result = (int) SprExport.Spr_CRBodyIf_NBones((IntPtr) _this);
	    return result;
	}
	public CRBoneIf GetBone(int i) {
	    IntPtr ptr = SprExport.Spr_CRBodyIf_GetBone((IntPtr) _this, (int) i);
            if (ptr == IntPtr.Zero) { return null; } 
            CRBoneIf obj = new CRBoneIf(ptr);
            return obj;
	}
	public Vec3d GetCenterOfMass() {
	    IntPtr ptr = SprExport.Spr_CRBodyIf_GetCenterOfMass((IntPtr) _this);
            return new Vec3d(ptr, true);
	}
	public double GetSumOfMass() {
	    double result = (double) SprExport.Spr_CRBodyIf_GetSumOfMass((IntPtr) _this);
	    return result;
	}
	public void Step() {
	    SprExport.Spr_CRBodyIf_Step((IntPtr) _this);
	}
    }
    public partial class CRBoneIf : SceneObjectIf {
	public CRBoneIf() { _this = SprExport.Spr_new_CRBoneIf(); _flag = true; }
	public CRBoneIf(IntPtr ptr) : base(ptr) {}
	public CRBoneIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator CRBoneIf(CsCastObject target) {
		return (target._info.Inherit(CRBoneIf.GetIfInfoStatic()) ? new CRBoneIf(target._this, target._flag) : null);
	}
	~CRBoneIf() { if (_flag) { SprExport.Spr_delete_CRBoneIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_CRBoneIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_CRBoneIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_CRBoneIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_CRBoneIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public string GetLabel() {
	    IntPtr ptr = SprExport.Spr_CRBoneIf_GetLabel((IntPtr) _this);
	    return Marshal.PtrToStringAnsi(ptr);
	}
	public void SetLabel(string str) {
	    SprExport.Spr_CRBoneIf_SetLabel((IntPtr) _this, (string) str);
	}
	public PHSolidIf GetPHSolid() {
	    IntPtr ptr = SprExport.Spr_CRBoneIf_GetPHSolid((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHSolidIf obj = new PHSolidIf(ptr);
            return obj;
	}
	public void SetPHSolid(PHSolidIf so) {
	    SprExport.Spr_CRBoneIf_SetPHSolid((IntPtr) _this, (IntPtr) so);
	}
	public PHIKEndEffectorIf GetIKEndEffector() {
	    IntPtr ptr = SprExport.Spr_CRBoneIf_GetIKEndEffector((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHIKEndEffectorIf obj = new PHIKEndEffectorIf(ptr);
            return obj;
	}
	public void SetIKEndEffector(PHIKEndEffectorIf ikEE) {
	    SprExport.Spr_CRBoneIf_SetIKEndEffector((IntPtr) _this, (IntPtr) ikEE);
	}
	public PHJointIf GetPHJoint() {
	    IntPtr ptr = SprExport.Spr_CRBoneIf_GetPHJoint((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHJointIf obj = new PHJointIf(ptr);
            return obj;
	}
	public void SetPHJoint(PHJointIf jo) {
	    SprExport.Spr_CRBoneIf_SetPHJoint((IntPtr) _this, (IntPtr) jo);
	}
	public PHIKActuatorIf GetIKActuator() {
	    IntPtr ptr = SprExport.Spr_CRBoneIf_GetIKActuator((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHIKActuatorIf obj = new PHIKActuatorIf(ptr);
            return obj;
	}
	public void SetIKActuator(PHIKActuatorIf ikAct) {
	    SprExport.Spr_CRBoneIf_SetIKActuator((IntPtr) _this, (IntPtr) ikAct);
	}
	public void SetParentBone(CRBoneIf parent) {
	    SprExport.Spr_CRBoneIf_SetParentBone((IntPtr) _this, (IntPtr) parent);
	}
	public CRBoneIf GetParentBone() {
	    IntPtr ptr = SprExport.Spr_CRBoneIf_GetParentBone((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            CRBoneIf obj = new CRBoneIf(ptr);
            return obj;
	}
	public int NChildBones() {
	    int result = (int) SprExport.Spr_CRBoneIf_NChildBones((IntPtr) _this);
	    return result;
	}
	public CRBoneIf GetChildBone(int number) {
	    IntPtr ptr = SprExport.Spr_CRBoneIf_GetChildBone((IntPtr) _this, (int) number);
            if (ptr == IntPtr.Zero) { return null; } 
            CRBoneIf obj = new CRBoneIf(ptr);
            return obj;
	}
	public void AddChildBone(CRBoneIf child) {
	    SprExport.Spr_CRBoneIf_AddChildBone((IntPtr) _this, (IntPtr) child);
	}
	public void ReadInitialSpringDamperFromJoint() {
	    SprExport.Spr_CRBoneIf_ReadInitialSpringDamperFromJoint((IntPtr) _this);
	}
    }
    public partial class CREngineIf : SceneObjectIf {
	public CREngineIf() { _this = SprExport.Spr_new_CREngineIf(); _flag = true; }
	public CREngineIf(IntPtr ptr) : base(ptr) {}
	public CREngineIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator CREngineIf(CsCastObject target) {
		return (target._info.Inherit(CREngineIf.GetIfInfoStatic()) ? new CREngineIf(target._this, target._flag) : null);
	}
	~CREngineIf() { if (_flag) { SprExport.Spr_delete_CREngineIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_CREngineIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_CREngineIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_CREngineIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_CREngineIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public int GetPriority() {
	    int result = (int) SprExport.Spr_CREngineIf_GetPriority((IntPtr) _this);
	    return result;
	}
	public void Init() {
	    SprExport.Spr_CREngineIf_Init((IntPtr) _this);
	}
	public void Step() {
	    SprExport.Spr_CREngineIf_Step((IntPtr) _this);
	}
	public void Enable(bool enable) {
	    SprExport.Spr_CREngineIf_Enable((IntPtr) _this, (bool) enable);
	}
	public bool IsEnabled() {
	    char ret = SprExport.Spr_CREngineIf_IsEnabled((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
    }
    public partial class CRControllerIf : CREngineIf {
	public CRControllerIf() { _this = SprExport.Spr_new_CRControllerIf(); _flag = true; }
	public CRControllerIf(IntPtr ptr) : base(ptr) {}
	public CRControllerIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator CRControllerIf(CsCastObject target) {
		return (target._info.Inherit(CRControllerIf.GetIfInfoStatic()) ? new CRControllerIf(target._this, target._flag) : null);
	}
	~CRControllerIf() { if (_flag) { SprExport.Spr_delete_CRControllerIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_CRControllerIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_CRControllerIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_CRControllerIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_CRControllerIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void Reset() {
	    SprExport.Spr_CRControllerIf_Reset((IntPtr) _this);
	}
	public int GetStatus() {
	    int result = (int) SprExport.Spr_CRControllerIf_GetStatus((IntPtr) _this);
	    return result;
	}
    }
    public partial class CRGazeControllerIf : CRControllerIf {
	public CRGazeControllerIf() { _this = SprExport.Spr_new_CRGazeControllerIf(); _flag = true; }
	public CRGazeControllerIf(IntPtr ptr) : base(ptr) {}
	public CRGazeControllerIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator CRGazeControllerIf(CsCastObject target) {
		return (target._info.Inherit(CRGazeControllerIf.GetIfInfoStatic()) ? new CRGazeControllerIf(target._this, target._flag) : null);
	}
	~CRGazeControllerIf() { if (_flag) { SprExport.Spr_delete_CRGazeControllerIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_CRGazeControllerIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_CRGazeControllerIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_CRGazeControllerIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_CRGazeControllerIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void SetTargetPosition(Vec3d pos) {
	    SprExport.Spr_CRGazeControllerIf_SetTargetPosition((IntPtr) _this, (IntPtr) pos);
	}
	public Vec3d GetTargetPosition() {
	    IntPtr ptr = SprExport.Spr_CRGazeControllerIf_GetTargetPosition((IntPtr) _this);
            return new Vec3d(ptr, true);
	}
	public void SetHeadBone(CRBoneIf head) {
	    SprExport.Spr_CRGazeControllerIf_SetHeadBone((IntPtr) _this, (IntPtr) head);
	}
    }
    public partial class CRGrabControllerIf : CRControllerIf {
	public CRGrabControllerIf() { _this = SprExport.Spr_new_CRGrabControllerIf(); _flag = true; }
	public CRGrabControllerIf(IntPtr ptr) : base(ptr) {}
	public CRGrabControllerIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator CRGrabControllerIf(CsCastObject target) {
		return (target._info.Inherit(CRGrabControllerIf.GetIfInfoStatic()) ? new CRGrabControllerIf(target._this, target._flag) : null);
	}
	~CRGrabControllerIf() { if (_flag) { SprExport.Spr_delete_CRGrabControllerIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_CRGrabControllerIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_CRGrabControllerIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_CRGrabControllerIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_CRGrabControllerIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void SetTargetSolid(PHSolidIf targetSolid) {
	    SprExport.Spr_CRGrabControllerIf_SetTargetSolid((IntPtr) _this, (IntPtr) targetSolid);
	}
	public PHSolidIf GetGrabbingSolid() {
	    IntPtr ptr = SprExport.Spr_CRGrabControllerIf_GetGrabbingSolid((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHSolidIf obj = new PHSolidIf(ptr);
            return obj;
	}
	public PHSolidIf GetSolid() {
	    IntPtr ptr = SprExport.Spr_CRGrabControllerIf_GetSolid((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHSolidIf obj = new PHSolidIf(ptr);
            return obj;
	}
	public void SetSolid(CRBoneIf so) {
	    SprExport.Spr_CRGrabControllerIf_SetSolid((IntPtr) _this, (IntPtr) so);
	}
    }
    public partial class CRCreatureIf : SceneIf {
	public CRCreatureIf() { _this = SprExport.Spr_new_CRCreatureIf(); _flag = true; }
	public CRCreatureIf(IntPtr ptr) : base(ptr) {}
	public CRCreatureIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator CRCreatureIf(CsCastObject target) {
		return (target._info.Inherit(CRCreatureIf.GetIfInfoStatic()) ? new CRCreatureIf(target._this, target._flag) : null);
	}
	~CRCreatureIf() { if (_flag) { SprExport.Spr_delete_CRCreatureIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_CRCreatureIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_CRCreatureIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_CRCreatureIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_CRCreatureIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void Step() {
	    SprExport.Spr_CRCreatureIf_Step((IntPtr) _this);
	}
	public CRBodyIf CreateBody(IfInfo ii, CRBodyDesc desc) {
	    IntPtr ptr = SprExport.Spr_CRCreatureIf_CreateBody((IntPtr) _this, (IntPtr) ii, (IntPtr) desc);
            if (ptr == IntPtr.Zero) { return null; } 
            CRBodyIf obj = new CRBodyIf(ptr);
            return obj;
	}
	public CRBodyIf GetBody(int i) {
	    IntPtr ptr = SprExport.Spr_CRCreatureIf_GetBody((IntPtr) _this, (int) i);
            if (ptr == IntPtr.Zero) { return null; } 
            CRBodyIf obj = new CRBodyIf(ptr);
            return obj;
	}
	public int NBodies() {
	    int result = (int) SprExport.Spr_CRCreatureIf_NBodies((IntPtr) _this);
	    return result;
	}
	public CREngineIf CreateEngine(IfInfo ii, CREngineDesc desc) {
	    IntPtr ptr = SprExport.Spr_CRCreatureIf_CreateEngine((IntPtr) _this, (IntPtr) ii, (IntPtr) desc);
            if (ptr == IntPtr.Zero) { return null; } 
            CREngineIf obj = new CREngineIf(ptr);
            if (obj.GetIfInfo() == CRControllerIf.GetIfInfoStatic()) { return new CRControllerIf(ptr); }
            if (obj.GetIfInfo() == CRTouchSensorIf.GetIfInfoStatic()) { return new CRTouchSensorIf(ptr); }
            if (obj.GetIfInfo() == CRVisualSensorIf.GetIfInfoStatic()) { return new CRVisualSensorIf(ptr); }
            if (obj.GetIfInfo() == CRGazeControllerIf.GetIfInfoStatic()) { return new CRGazeControllerIf(ptr); }
            if (obj.GetIfInfo() == CRGrabControllerIf.GetIfInfoStatic()) { return new CRGrabControllerIf(ptr); }
            if (obj.GetIfInfo() == CRReachControllerIf.GetIfInfoStatic()) { return new CRReachControllerIf(ptr); }
            return obj;
	}
	public CREngineIf GetEngine(int i) {
	    IntPtr ptr = SprExport.Spr_CRCreatureIf_GetEngine((IntPtr) _this, (int) i);
            if (ptr == IntPtr.Zero) { return null; } 
            CREngineIf obj = new CREngineIf(ptr);
            if (obj.GetIfInfo() == CRControllerIf.GetIfInfoStatic()) { return new CRControllerIf(ptr); }
            if (obj.GetIfInfo() == CRTouchSensorIf.GetIfInfoStatic()) { return new CRTouchSensorIf(ptr); }
            if (obj.GetIfInfo() == CRVisualSensorIf.GetIfInfoStatic()) { return new CRVisualSensorIf(ptr); }
            if (obj.GetIfInfo() == CRGazeControllerIf.GetIfInfoStatic()) { return new CRGazeControllerIf(ptr); }
            if (obj.GetIfInfo() == CRGrabControllerIf.GetIfInfoStatic()) { return new CRGrabControllerIf(ptr); }
            if (obj.GetIfInfo() == CRReachControllerIf.GetIfInfoStatic()) { return new CRReachControllerIf(ptr); }
            return obj;
	}
	public int NEngines() {
	    int result = (int) SprExport.Spr_CRCreatureIf_NEngines((IntPtr) _this);
	    return result;
	}
	public PHSceneIf GetPHScene() {
	    IntPtr ptr = SprExport.Spr_CRCreatureIf_GetPHScene((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHSceneIf obj = new PHSceneIf(ptr);
            return obj;
	}
    }
    public partial class CRReachControllerIf : CRControllerIf {
	public CRReachControllerIf() { _this = SprExport.Spr_new_CRReachControllerIf(); _flag = true; }
	public CRReachControllerIf(IntPtr ptr) : base(ptr) {}
	public CRReachControllerIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator CRReachControllerIf(CsCastObject target) {
		return (target._info.Inherit(CRReachControllerIf.GetIfInfoStatic()) ? new CRReachControllerIf(target._this, target._flag) : null);
	}
	~CRReachControllerIf() { if (_flag) { SprExport.Spr_delete_CRReachControllerIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_CRReachControllerIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_CRReachControllerIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_CRReachControllerIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_CRReachControllerIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void SetIKEndEffector(PHIKEndEffectorIf ikEff, int n) {
	    SprExport.Spr_CRReachControllerIf_SetIKEndEffector((IntPtr) _this, (IntPtr) ikEff, (int) n);
	}
	public void SetIKEndEffector(PHIKEndEffectorIf ikEff) {
	    SprExport.Spr_CRReachControllerIf_SetIKEndEffector_1((IntPtr) _this, (IntPtr) ikEff);
	}
	public PHIKEndEffectorIf GetIKEndEffector(int n) {
	    IntPtr ptr = SprExport.Spr_CRReachControllerIf_GetIKEndEffector((IntPtr) _this, (int) n);
            if (ptr == IntPtr.Zero) { return null; } 
            PHIKEndEffectorIf obj = new PHIKEndEffectorIf(ptr);
            return obj;
	}
	public PHIKEndEffectorIf GetIKEndEffector() {
	    IntPtr ptr = SprExport.Spr_CRReachControllerIf_GetIKEndEffector_1((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHIKEndEffectorIf obj = new PHIKEndEffectorIf(ptr);
            return obj;
	}
	public void SetFinalPos(Vec3d pos) {
	    SprExport.Spr_CRReachControllerIf_SetFinalPos((IntPtr) _this, (IntPtr) pos);
	}
	public void SetFinalVel(Vec3d vel) {
	    SprExport.Spr_CRReachControllerIf_SetFinalVel((IntPtr) _this, (IntPtr) vel);
	}
	public void SetViaTime(float time) {
	    SprExport.Spr_CRReachControllerIf_SetViaTime((IntPtr) _this, (float) time);
	}
	public void SetViaPos(Vec3d pos) {
	    SprExport.Spr_CRReachControllerIf_SetViaPos((IntPtr) _this, (IntPtr) pos);
	}
	public void EnableLookatMode(bool bEnable) {
	    SprExport.Spr_CRReachControllerIf_EnableLookatMode((IntPtr) _this, (bool) bEnable);
	}
	public bool IsLookatMode() {
	    char ret = SprExport.Spr_CRReachControllerIf_IsLookatMode((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public void SetNumUseHands(int n) {
	    SprExport.Spr_CRReachControllerIf_SetNumUseHands((IntPtr) _this, (int) n);
	}
	public int GetNumUseHands() {
	    int result = (int) SprExport.Spr_CRReachControllerIf_GetNumUseHands((IntPtr) _this);
	    return result;
	}
	public void SetBaseJoint(int n, PHJointIf jo) {
	    SprExport.Spr_CRReachControllerIf_SetBaseJoint((IntPtr) _this, (int) n, (IntPtr) jo);
	}
	public void SetAverageSpeed(double speed) {
	    SprExport.Spr_CRReachControllerIf_SetAverageSpeed((IntPtr) _this, (double) speed);
	}
	public double GetAverageSpeed() {
	    double result = (double) SprExport.Spr_CRReachControllerIf_GetAverageSpeed((IntPtr) _this);
	    return result;
	}
	public void SetMargin(double margin) {
	    SprExport.Spr_CRReachControllerIf_SetMargin((IntPtr) _this, (double) margin);
	}
	public void SetInnerMargin(double margin) {
	    SprExport.Spr_CRReachControllerIf_SetInnerMargin((IntPtr) _this, (double) margin);
	}
	public void SetWaitVel(double vel) {
	    SprExport.Spr_CRReachControllerIf_SetWaitVel((IntPtr) _this, (double) vel);
	}
	public void SetRestartVel(double vel) {
	    SprExport.Spr_CRReachControllerIf_SetRestartVel((IntPtr) _this, (double) vel);
	}
	public Vec6d GetTrajectory(float s) {
	    IntPtr ptr = SprExport.Spr_CRReachControllerIf_GetTrajectory((IntPtr) _this, (float) s);
            return new Vec6d(ptr, true);
	}
	public float GetReachTime() {
	    float result = (float) SprExport.Spr_CRReachControllerIf_GetReachTime((IntPtr) _this);
	    return result;
	}
	public float GetTime() {
	    float result = (float) SprExport.Spr_CRReachControllerIf_GetTime((IntPtr) _this);
	    return result;
	}
	public void Draw() {
	    SprExport.Spr_CRReachControllerIf_Draw((IntPtr) _this);
	}
	public void SetOriControlCompleteTimeRatio(float oriTime) {
	    SprExport.Spr_CRReachControllerIf_SetOriControlCompleteTimeRatio((IntPtr) _this, (float) oriTime);
	}
    }
    public partial class CRSdkIf : SdkIf {
	public CRSdkIf() { _this = SprExport.Spr_new_CRSdkIf(); _flag = true; }
	public CRSdkIf(IntPtr ptr) : base(ptr) {}
	public CRSdkIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator CRSdkIf(CsCastObject target) {
		return (target._info.Inherit(CRSdkIf.GetIfInfoStatic()) ? new CRSdkIf(target._this, target._flag) : null);
	}
	~CRSdkIf() { if (_flag) { SprExport.Spr_delete_CRSdkIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_CRSdkIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_CRSdkIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_CRSdkIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_CRSdkIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public static CRSdkIf CreateSdk() {
	    IntPtr ptr = SprExport.Spr_CRSdkIf_CreateSdk();
            if (ptr == IntPtr.Zero) { return null; } 
            CRSdkIf obj = new CRSdkIf(ptr);
            return obj;
	}
	public static CRSdkIf GetSdk() {
	    IntPtr ptr = SprExport.Spr_CRSdkIf_GetSdk();
            if (ptr == IntPtr.Zero) { return null; } 
            CRSdkIf obj = new CRSdkIf(ptr);
            return obj;
	}
	public CRCreatureIf CreateCreature(IfInfo ii, CRCreatureDesc desc) {
	    IntPtr ptr = SprExport.Spr_CRSdkIf_CreateCreature((IntPtr) _this, (IntPtr) ii, (IntPtr) desc);
            if (ptr == IntPtr.Zero) { return null; } 
            CRCreatureIf obj = new CRCreatureIf(ptr);
            return obj;
	}
	public int NCreatures() {
	    int result = (int) SprExport.Spr_CRSdkIf_NCreatures((IntPtr) _this);
	    return result;
	}
	public CRCreatureIf GetCreature(int index) {
	    IntPtr ptr = SprExport.Spr_CRSdkIf_GetCreature((IntPtr) _this, (int) index);
            if (ptr == IntPtr.Zero) { return null; } 
            CRCreatureIf obj = new CRCreatureIf(ptr);
            return obj;
	}
	public void Step() {
	    SprExport.Spr_CRSdkIf_Step((IntPtr) _this);
	}
	public static void RegisterSdk() {
	    SprExport.Spr_CRSdkIf_RegisterSdk();
	}
    }
    public partial class CRTouchSensorIf : CREngineIf {
	public CRTouchSensorIf() { _this = SprExport.Spr_new_CRTouchSensorIf(); _flag = true; }
	public CRTouchSensorIf(IntPtr ptr) : base(ptr) {}
	public CRTouchSensorIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator CRTouchSensorIf(CsCastObject target) {
		return (target._info.Inherit(CRTouchSensorIf.GetIfInfoStatic()) ? new CRTouchSensorIf(target._this, target._flag) : null);
	}
	~CRTouchSensorIf() { if (_flag) { SprExport.Spr_delete_CRTouchSensorIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_CRTouchSensorIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_CRTouchSensorIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_CRTouchSensorIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_CRTouchSensorIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public int NContacts() {
	    int result = (int) SprExport.Spr_CRTouchSensorIf_NContacts((IntPtr) _this);
	    return result;
	}
	public CRContactInfo GetContact(int n) {
	    IntPtr ptr = SprExport.Spr_CRTouchSensorIf_GetContact((IntPtr) _this, (int) n);
            return new CRContactInfo(ptr, true);
	}
	public void Update() {
	    SprExport.Spr_CRTouchSensorIf_Update((IntPtr) _this);
	}
    }
    public partial class CRVisualSensorIf : CREngineIf {
	public CRVisualSensorIf() { _this = SprExport.Spr_new_CRVisualSensorIf(); _flag = true; }
	public CRVisualSensorIf(IntPtr ptr) : base(ptr) {}
	public CRVisualSensorIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator CRVisualSensorIf(CsCastObject target) {
		return (target._info.Inherit(CRVisualSensorIf.GetIfInfoStatic()) ? new CRVisualSensorIf(target._this, target._flag) : null);
	}
	~CRVisualSensorIf() { if (_flag) { SprExport.Spr_delete_CRVisualSensorIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_CRVisualSensorIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_CRVisualSensorIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_CRVisualSensorIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_CRVisualSensorIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public int NVisibles() {
	    int result = (int) SprExport.Spr_CRVisualSensorIf_NVisibles((IntPtr) _this);
	    return result;
	}
	public CRVisualInfo GetVisible(int n) {
	    IntPtr ptr = SprExport.Spr_CRVisualSensorIf_GetVisible((IntPtr) _this, (int) n);
            return new CRVisualInfo(ptr, true);
	}
	public void Update() {
	    SprExport.Spr_CRVisualSensorIf_Update((IntPtr) _this);
	}
	public void SetRange(Vec2d range) {
	    SprExport.Spr_CRVisualSensorIf_SetRange((IntPtr) _this, (IntPtr) range);
	}
	public void SetCenterRange(Vec2d range) {
	    SprExport.Spr_CRVisualSensorIf_SetCenterRange((IntPtr) _this, (IntPtr) range);
	}
	public void SetPose(Posed pose) {
	    SprExport.Spr_CRVisualSensorIf_SetPose((IntPtr) _this, (IntPtr) pose);
	}
	public void SetSolid(PHSolidIf solid) {
	    SprExport.Spr_CRVisualSensorIf_SetSolid((IntPtr) _this, (IntPtr) solid);
	}
	public Vec2d GetRange() {
	    IntPtr ptr = SprExport.Spr_CRVisualSensorIf_GetRange((IntPtr) _this);
            return new Vec2d(ptr, true);
	}
	public Vec2d GetCenterRange() {
	    IntPtr ptr = SprExport.Spr_CRVisualSensorIf_GetCenterRange((IntPtr) _this);
            return new Vec2d(ptr, true);
	}
	public Posed GetPose() {
	    IntPtr ptr = SprExport.Spr_CRVisualSensorIf_GetPose((IntPtr) _this);
            return new Posed(ptr, true);
	}
	public PHSolidIf GetSolid() {
	    IntPtr ptr = SprExport.Spr_CRVisualSensorIf_GetSolid((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            PHSolidIf obj = new PHSolidIf(ptr);
            return obj;
	}
    }
	public partial class IfInfoToCsType {
		public static Dictionary<IntPtr, Type> mapCreature = new Dictionary<IntPtr, Type>() {
			{CRBodyIf.GetIfInfoStatic(), typeof(CRBodyIf)},
			{CRBoneIf.GetIfInfoStatic(), typeof(CRBoneIf)},
			{CREngineIf.GetIfInfoStatic(), typeof(CREngineIf)},
			{CRControllerIf.GetIfInfoStatic(), typeof(CRControllerIf)},
			{CRGazeControllerIf.GetIfInfoStatic(), typeof(CRGazeControllerIf)},
			{CRGrabControllerIf.GetIfInfoStatic(), typeof(CRGrabControllerIf)},
			{CRCreatureIf.GetIfInfoStatic(), typeof(CRCreatureIf)},
			{CRReachControllerIf.GetIfInfoStatic(), typeof(CRReachControllerIf)},
			{CRSdkIf.GetIfInfoStatic(), typeof(CRSdkIf)},
			{CRTouchSensorIf.GetIfInfoStatic(), typeof(CRTouchSensorIf)},
			{CRVisualSensorIf.GetIfInfoStatic(), typeof(CRVisualSensorIf)},
		};
	}
}
