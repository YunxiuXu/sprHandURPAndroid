using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
#pragma warning disable 0108
namespace SprCs {
    public partial class FIFileSprDesc : CsObject {
	public FIFileSprDesc() { _this = SprExport.Spr_new_FIFileSprDesc(); _flag = true; }
	public FIFileSprDesc(IntPtr ptr) : base(ptr) {}
	public FIFileSprDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FIFileSprDesc() { if (_flag) { SprExport.Spr_delete_FIFileSprDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class FIFileSprDescStruct : CsObject {
        public FIFileSprDescStruct() {
            FIFileSprDesc desc = new FIFileSprDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] FIFileSprDesc
	public void ApplyTo(FIFileSprDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(FIFileSprDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator FIFileSprDesc(FIFileSprDescStruct m) {
	    FIFileSprDesc r = new FIFileSprDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FIFileSprDescStruct(FIFileSprDesc r) {
	    FIFileSprDescStruct m = new FIFileSprDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FIFileXDesc : CsObject {
	public FIFileXDesc() { _this = SprExport.Spr_new_FIFileXDesc(); _flag = true; }
	public FIFileXDesc(IntPtr ptr) : base(ptr) {}
	public FIFileXDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FIFileXDesc() { if (_flag) { SprExport.Spr_delete_FIFileXDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class FIFileXDescStruct : CsObject {
        public FIFileXDescStruct() {
            FIFileXDesc desc = new FIFileXDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] FIFileXDesc
	public void ApplyTo(FIFileXDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(FIFileXDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator FIFileXDesc(FIFileXDescStruct m) {
	    FIFileXDesc r = new FIFileXDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FIFileXDescStruct(FIFileXDesc r) {
	    FIFileXDescStruct m = new FIFileXDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FIFileVRMLDesc : CsObject {
	public FIFileVRMLDesc() { _this = SprExport.Spr_new_FIFileVRMLDesc(); _flag = true; }
	public FIFileVRMLDesc(IntPtr ptr) : base(ptr) {}
	public FIFileVRMLDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FIFileVRMLDesc() { if (_flag) { SprExport.Spr_delete_FIFileVRMLDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class FIFileVRMLDescStruct : CsObject {
        public FIFileVRMLDescStruct() {
            FIFileVRMLDesc desc = new FIFileVRMLDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] FIFileVRMLDesc
	public void ApplyTo(FIFileVRMLDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(FIFileVRMLDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator FIFileVRMLDesc(FIFileVRMLDescStruct m) {
	    FIFileVRMLDesc r = new FIFileVRMLDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FIFileVRMLDescStruct(FIFileVRMLDesc r) {
	    FIFileVRMLDescStruct m = new FIFileVRMLDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FIFileCOLLADADesc : CsObject {
	public FIFileCOLLADADesc() { _this = SprExport.Spr_new_FIFileCOLLADADesc(); _flag = true; }
	public FIFileCOLLADADesc(IntPtr ptr) : base(ptr) {}
	public FIFileCOLLADADesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FIFileCOLLADADesc() { if (_flag) { SprExport.Spr_delete_FIFileCOLLADADesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class FIFileCOLLADADescStruct : CsObject {
        public FIFileCOLLADADescStruct() {
            FIFileCOLLADADesc desc = new FIFileCOLLADADesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] FIFileCOLLADADesc
	public void ApplyTo(FIFileCOLLADADesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(FIFileCOLLADADesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator FIFileCOLLADADesc(FIFileCOLLADADescStruct m) {
	    FIFileCOLLADADesc r = new FIFileCOLLADADesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FIFileCOLLADADescStruct(FIFileCOLLADADesc r) {
	    FIFileCOLLADADescStruct m = new FIFileCOLLADADescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FIFileBinaryDesc : CsObject {
	public FIFileBinaryDesc() { _this = SprExport.Spr_new_FIFileBinaryDesc(); _flag = true; }
	public FIFileBinaryDesc(IntPtr ptr) : base(ptr) {}
	public FIFileBinaryDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~FIFileBinaryDesc() { if (_flag) { SprExport.Spr_delete_FIFileBinaryDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class FIFileBinaryDescStruct : CsObject {
        public FIFileBinaryDescStruct() {
            FIFileBinaryDesc desc = new FIFileBinaryDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] FIFileBinaryDesc
	public void ApplyTo(FIFileBinaryDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(FIFileBinaryDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator FIFileBinaryDesc(FIFileBinaryDescStruct m) {
	    FIFileBinaryDesc r = new FIFileBinaryDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator FIFileBinaryDescStruct(FIFileBinaryDesc r) {
	    FIFileBinaryDescStruct m = new FIFileBinaryDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class ImportDesc : CsObject {
	public ImportDesc() { _this = SprExport.Spr_new_ImportDesc(); _flag = true; }
	public ImportDesc(IntPtr ptr) : base(ptr) {}
	public ImportDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~ImportDesc() { if (_flag) { SprExport.Spr_delete_ImportDesc(_this); _flag = false; } }
	public string path {
	    get {
	        IntPtr ptr = SprExport.Spr_ImportDesc_get_path(_this);
	        string bstr = Marshal.PtrToStringBSTR(ptr);
	        SprExport.Spr_ImportDesc_FreeString_path(ptr);
	        return bstr;
	    }
	    set {
	        IntPtr pbstr = Marshal.StringToBSTR(value);
	        SprExport.Spr_ImportDesc_set_path(_this, pbstr);
	    }
	}
    }
    [System.Serializable]
    public class ImportDescStruct : CsObject {
        public ImportDescStruct() {
            ImportDesc desc = new ImportDesc();
            ApplyFrom(desc, false);
        }
	public string path;
// _[Find class node: 2916] ImportDesc
	public void ApplyTo(ImportDesc r, bool apply_to_base_class=true) {
		r.path = path;
	}
	public void ApplyFrom(ImportDesc r, bool apply_to_base_class=true) {
		path = r.path;
	}
	public static implicit operator ImportDesc(ImportDescStruct m) {
	    ImportDesc r = new ImportDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator ImportDescStruct(ImportDesc r) {
	    ImportDescStruct m = new ImportDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class FIFileIf : ObjectIf {
	public FIFileIf() { _this = SprExport.Spr_new_FIFileIf(); _flag = true; }
	public FIFileIf(IntPtr ptr) : base(ptr) {}
	public FIFileIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FIFileIf(CsCastObject target) {
		return (target._info.Inherit(FIFileIf.GetIfInfoStatic()) ? new FIFileIf(target._this, target._flag) : null);
	}
	~FIFileIf() { if (_flag) { SprExport.Spr_delete_FIFileIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FIFileIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FIFileIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FIFileIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FIFileIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool Load(ObjectIfs objs, string fn) {
	    char ret = SprExport.Spr_FIFileIf_Load((IntPtr) _this, (IntPtr) objs, (string) fn);
	    return (ret == 0) ? false : true;
	}
	public bool Save(ObjectIfs objs, string fn) {
	    char ret = SprExport.Spr_FIFileIf_Save((IntPtr) _this, (IntPtr) objs, (string) fn);
	    return (ret == 0) ? false : true;
	}
	public void SetImport(ImportIf import) {
	    SprExport.Spr_FIFileIf_SetImport((IntPtr) _this, (IntPtr) import);
	}
	public ImportIf GetImport() {
	    IntPtr ptr = SprExport.Spr_FIFileIf_GetImport((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            ImportIf obj = new ImportIf(ptr);
            return obj;
	}
	public void SetDSTR(bool f) {
	    SprExport.Spr_FIFileIf_SetDSTR((IntPtr) _this, (bool) f);
	}
    }
    public partial class FIFileSprIf : FIFileIf {
	public FIFileSprIf() { _this = SprExport.Spr_new_FIFileSprIf(); _flag = true; }
	public FIFileSprIf(IntPtr ptr) : base(ptr) {}
	public FIFileSprIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FIFileSprIf(CsCastObject target) {
		return (target._info.Inherit(FIFileSprIf.GetIfInfoStatic()) ? new FIFileSprIf(target._this, target._flag) : null);
	}
	~FIFileSprIf() { if (_flag) { SprExport.Spr_delete_FIFileSprIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FIFileSprIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FIFileSprIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FIFileSprIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FIFileSprIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool Load(ObjectIfs objs, string fn) {
	    char ret = SprExport.Spr_FIFileSprIf_Load((IntPtr) _this, (IntPtr) objs, (string) fn);
	    return (ret == 0) ? false : true;
	}
	public bool Save(ObjectIfs objs, string fn) {
	    char ret = SprExport.Spr_FIFileSprIf_Save((IntPtr) _this, (IntPtr) objs, (string) fn);
	    return (ret == 0) ? false : true;
	}
    }
    public partial class FIFileXIf : FIFileIf {
	public FIFileXIf() { _this = SprExport.Spr_new_FIFileXIf(); _flag = true; }
	public FIFileXIf(IntPtr ptr) : base(ptr) {}
	public FIFileXIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FIFileXIf(CsCastObject target) {
		return (target._info.Inherit(FIFileXIf.GetIfInfoStatic()) ? new FIFileXIf(target._this, target._flag) : null);
	}
	~FIFileXIf() { if (_flag) { SprExport.Spr_delete_FIFileXIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FIFileXIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FIFileXIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FIFileXIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FIFileXIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool Load(ObjectIfs objs, string fn) {
	    char ret = SprExport.Spr_FIFileXIf_Load((IntPtr) _this, (IntPtr) objs, (string) fn);
	    return (ret == 0) ? false : true;
	}
	public bool Save(ObjectIfs objs, string fn) {
	    char ret = SprExport.Spr_FIFileXIf_Save((IntPtr) _this, (IntPtr) objs, (string) fn);
	    return (ret == 0) ? false : true;
	}
    }
    public partial class FIFileVRMLIf : FIFileIf {
	public FIFileVRMLIf() { _this = SprExport.Spr_new_FIFileVRMLIf(); _flag = true; }
	public FIFileVRMLIf(IntPtr ptr) : base(ptr) {}
	public FIFileVRMLIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FIFileVRMLIf(CsCastObject target) {
		return (target._info.Inherit(FIFileVRMLIf.GetIfInfoStatic()) ? new FIFileVRMLIf(target._this, target._flag) : null);
	}
	~FIFileVRMLIf() { if (_flag) { SprExport.Spr_delete_FIFileVRMLIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FIFileVRMLIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FIFileVRMLIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FIFileVRMLIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FIFileVRMLIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool Load(ObjectIfs objs, string fn) {
	    char ret = SprExport.Spr_FIFileVRMLIf_Load((IntPtr) _this, (IntPtr) objs, (string) fn);
	    return (ret == 0) ? false : true;
	}
	public bool Save(ObjectIfs objs, string fn) {
	    char ret = SprExport.Spr_FIFileVRMLIf_Save((IntPtr) _this, (IntPtr) objs, (string) fn);
	    return (ret == 0) ? false : true;
	}
    }
    public partial class FIFileCOLLADAIf : FIFileIf {
	public FIFileCOLLADAIf() { _this = SprExport.Spr_new_FIFileCOLLADAIf(); _flag = true; }
	public FIFileCOLLADAIf(IntPtr ptr) : base(ptr) {}
	public FIFileCOLLADAIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FIFileCOLLADAIf(CsCastObject target) {
		return (target._info.Inherit(FIFileCOLLADAIf.GetIfInfoStatic()) ? new FIFileCOLLADAIf(target._this, target._flag) : null);
	}
	~FIFileCOLLADAIf() { if (_flag) { SprExport.Spr_delete_FIFileCOLLADAIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FIFileCOLLADAIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FIFileCOLLADAIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FIFileCOLLADAIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FIFileCOLLADAIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool Load(ObjectIfs objs, string fn) {
	    char ret = SprExport.Spr_FIFileCOLLADAIf_Load((IntPtr) _this, (IntPtr) objs, (string) fn);
	    return (ret == 0) ? false : true;
	}
	public bool Save(ObjectIfs objs, string fn) {
	    char ret = SprExport.Spr_FIFileCOLLADAIf_Save((IntPtr) _this, (IntPtr) objs, (string) fn);
	    return (ret == 0) ? false : true;
	}
    }
    public partial class FIFileBinaryIf : FIFileIf {
	public FIFileBinaryIf() { _this = SprExport.Spr_new_FIFileBinaryIf(); _flag = true; }
	public FIFileBinaryIf(IntPtr ptr) : base(ptr) {}
	public FIFileBinaryIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FIFileBinaryIf(CsCastObject target) {
		return (target._info.Inherit(FIFileBinaryIf.GetIfInfoStatic()) ? new FIFileBinaryIf(target._this, target._flag) : null);
	}
	~FIFileBinaryIf() { if (_flag) { SprExport.Spr_delete_FIFileBinaryIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FIFileBinaryIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FIFileBinaryIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FIFileBinaryIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FIFileBinaryIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool Load(ObjectIfs objs, string fn) {
	    char ret = SprExport.Spr_FIFileBinaryIf_Load((IntPtr) _this, (IntPtr) objs, (string) fn);
	    return (ret == 0) ? false : true;
	}
	public bool Save(ObjectIfs objs, string fn) {
	    char ret = SprExport.Spr_FIFileBinaryIf_Save((IntPtr) _this, (IntPtr) objs, (string) fn);
	    return (ret == 0) ? false : true;
	}
    }
    public partial class ImportIf : ObjectIf {
	public ImportIf() { _this = SprExport.Spr_new_ImportIf(); _flag = true; }
	public ImportIf(IntPtr ptr) : base(ptr) {}
	public ImportIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator ImportIf(CsCastObject target) {
		return (target._info.Inherit(ImportIf.GetIfInfoStatic()) ? new ImportIf(target._this, target._flag) : null);
	}
	~ImportIf() { if (_flag) { SprExport.Spr_delete_ImportIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_ImportIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_ImportIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_ImportIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_ImportIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void SetLoadOnly(bool on) {
	    SprExport.Spr_ImportIf_SetLoadOnly((IntPtr) _this, (bool) on);
	}
	public void SetLoadOnly() {
	    SprExport.Spr_ImportIf_SetLoadOnly_1((IntPtr) _this);
	}
    }
    public partial class FISdkIf : SdkIf {
	public FISdkIf() { _this = SprExport.Spr_new_FISdkIf(); _flag = true; }
	public FISdkIf(IntPtr ptr) : base(ptr) {}
	public FISdkIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FISdkIf(CsCastObject target) {
		return (target._info.Inherit(FISdkIf.GetIfInfoStatic()) ? new FISdkIf(target._this, target._flag) : null);
	}
	~FISdkIf() { if (_flag) { SprExport.Spr_delete_FISdkIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FISdkIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FISdkIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FISdkIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FISdkIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public FIFileXIf CreateFileX() {
	    IntPtr ptr = SprExport.Spr_FISdkIf_CreateFileX((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FIFileXIf obj = new FIFileXIf(ptr);
            return obj;
	}
	public FIFileSprIf CreateFileSpr() {
	    IntPtr ptr = SprExport.Spr_FISdkIf_CreateFileSpr((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FIFileSprIf obj = new FIFileSprIf(ptr);
            return obj;
	}
	public FIFileVRMLIf CreateFileVRML() {
	    IntPtr ptr = SprExport.Spr_FISdkIf_CreateFileVRML((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FIFileVRMLIf obj = new FIFileVRMLIf(ptr);
            return obj;
	}
	public FIFileCOLLADAIf CreateFileCOLLADA() {
	    IntPtr ptr = SprExport.Spr_FISdkIf_CreateFileCOLLADA((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FIFileCOLLADAIf obj = new FIFileCOLLADAIf(ptr);
            return obj;
	}
	public FIFileBinaryIf CreateFileBinary() {
	    IntPtr ptr = SprExport.Spr_FISdkIf_CreateFileBinary((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            FIFileBinaryIf obj = new FIFileBinaryIf(ptr);
            return obj;
	}
	public FIFileIf CreateFileFromExt(string filename) {
            IntPtr remote1 = Marshal.StringToBSTR(filename);
	    IntPtr ptr = SprExport.Spr_FISdkIf_CreateFileFromExt((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
            if (ptr == IntPtr.Zero) { return null; } 
            FIFileIf obj = new FIFileIf(ptr);
            if (obj.GetIfInfo() == FIFileSprIf.GetIfInfoStatic()) { return new FIFileSprIf(ptr); }
            if (obj.GetIfInfo() == FIFileXIf.GetIfInfoStatic()) { return new FIFileXIf(ptr); }
            if (obj.GetIfInfo() == FIFileVRMLIf.GetIfInfoStatic()) { return new FIFileVRMLIf(ptr); }
            if (obj.GetIfInfo() == FIFileCOLLADAIf.GetIfInfoStatic()) { return new FIFileCOLLADAIf(ptr); }
            if (obj.GetIfInfo() == FIFileBinaryIf.GetIfInfoStatic()) { return new FIFileBinaryIf(ptr); }
            return obj;
	}
	public ImportIf CreateImport() {
	    IntPtr ptr = SprExport.Spr_FISdkIf_CreateImport((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            ImportIf obj = new ImportIf(ptr);
            return obj;
	}
	public ImportIf CreateImport(ImportIf parent, string path, ObjectIf owner, ObjectIfs children) {
            IntPtr remote2 = Marshal.StringToBSTR(path);
	    IntPtr ptr = SprExport.Spr_FISdkIf_CreateImport_1((IntPtr) _this, (IntPtr) parent, (IntPtr) remote2, (IntPtr) owner, (IntPtr) children);
            Marshal.FreeBSTR(remote2);
            if (ptr == IntPtr.Zero) { return null; } 
            ImportIf obj = new ImportIf(ptr);
            return obj;
	}
	public bool DelChildObject(ObjectIf o) {
	    char ret = SprExport.Spr_FISdkIf_DelChildObject((IntPtr) _this, (IntPtr) o);
	    return (ret == 0) ? false : true;
	}
	public void Clear() {
	    SprExport.Spr_FISdkIf_Clear((IntPtr) _this);
	}
	public static void RegisterSdk() {
	    SprExport.Spr_FISdkIf_RegisterSdk();
	}
    }
    public partial class FIOpStateHandlerIf : ObjectIf {
	public FIOpStateHandlerIf() { _this = SprExport.Spr_new_FIOpStateHandlerIf(); _flag = true; }
	public FIOpStateHandlerIf(IntPtr ptr) : base(ptr) {}
	public FIOpStateHandlerIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator FIOpStateHandlerIf(CsCastObject target) {
		return (target._info.Inherit(FIOpStateHandlerIf.GetIfInfoStatic()) ? new FIOpStateHandlerIf(target._this, target._flag) : null);
	}
	~FIOpStateHandlerIf() { if (_flag) { SprExport.Spr_delete_FIOpStateHandlerIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_FIOpStateHandlerIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_FIOpStateHandlerIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_FIOpStateHandlerIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_FIOpStateHandlerIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void saveToFile(ObjectIf objif, string filename, float fileVersion) {
	    SprExport.Spr_FIOpStateHandlerIf_saveToFile((IntPtr) _this, (IntPtr) objif, (string) filename, (float) fileVersion);
	}
	public void loadFromFile(ObjectIf objif, string filename, bool checkName, float fileVersion) {
	    SprExport.Spr_FIOpStateHandlerIf_loadFromFile((IntPtr) _this, (IntPtr) objif, (string) filename, (bool) checkName, (float) fileVersion);
	}
    }
	public partial class IfInfoToCsType {
		public static Dictionary<IntPtr, Type> mapFileIO = new Dictionary<IntPtr, Type>() {
			{FIFileIf.GetIfInfoStatic(), typeof(FIFileIf)},
			{FIFileSprIf.GetIfInfoStatic(), typeof(FIFileSprIf)},
			{FIFileXIf.GetIfInfoStatic(), typeof(FIFileXIf)},
			{FIFileVRMLIf.GetIfInfoStatic(), typeof(FIFileVRMLIf)},
			{FIFileCOLLADAIf.GetIfInfoStatic(), typeof(FIFileCOLLADAIf)},
			{FIFileBinaryIf.GetIfInfoStatic(), typeof(FIFileBinaryIf)},
			{ImportIf.GetIfInfoStatic(), typeof(ImportIf)},
			{FISdkIf.GetIfInfoStatic(), typeof(FISdkIf)},
			{FIOpStateHandlerIf.GetIfInfoStatic(), typeof(FIOpStateHandlerIf)},
		};
	}
}
