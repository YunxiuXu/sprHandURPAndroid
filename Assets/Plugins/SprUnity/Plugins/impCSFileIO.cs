using System;
using System.Runtime.InteropServices;
namespace SprCs {
    public partial class SprExport {
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FIFileSprDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FIFileSprDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FIFileXDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FIFileXDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FIFileVRMLDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FIFileVRMLDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FIFileCOLLADADesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FIFileCOLLADADesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FIFileBinaryDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FIFileBinaryDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_ImportDesc();
	[DllImport("SprExport")]
	public static extern void Spr_delete_ImportDesc(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ImportDesc_get_path(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_ImportDesc_set_path(IntPtr _this, IntPtr value);
	[DllImport("SprExport")]
	public static extern void Spr_ImportDesc_FreeString_path(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FIFileIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FIFileIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FIFileIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_FIFileIf_Load(IntPtr _this, IntPtr objs, string fn);
	[DllImport("SprExport")]
	public static extern char Spr_FIFileIf_Save(IntPtr _this, IntPtr objs, string fn);
	[DllImport("SprExport")]
	public static extern void Spr_FIFileIf_SetImport(IntPtr _this, IntPtr import);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileIf_GetImport(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FIFileIf_SetDSTR(IntPtr _this, bool f);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FIFileSprIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FIFileSprIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileSprIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FIFileSprIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileSprIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileSprIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_FIFileSprIf_Load(IntPtr _this, IntPtr objs, string fn);
	[DllImport("SprExport")]
	public static extern char Spr_FIFileSprIf_Save(IntPtr _this, IntPtr objs, string fn);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FIFileXIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FIFileXIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileXIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FIFileXIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileXIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileXIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_FIFileXIf_Load(IntPtr _this, IntPtr objs, string fn);
	[DllImport("SprExport")]
	public static extern char Spr_FIFileXIf_Save(IntPtr _this, IntPtr objs, string fn);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FIFileVRMLIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FIFileVRMLIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileVRMLIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FIFileVRMLIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileVRMLIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileVRMLIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_FIFileVRMLIf_Load(IntPtr _this, IntPtr objs, string fn);
	[DllImport("SprExport")]
	public static extern char Spr_FIFileVRMLIf_Save(IntPtr _this, IntPtr objs, string fn);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FIFileCOLLADAIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FIFileCOLLADAIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileCOLLADAIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FIFileCOLLADAIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileCOLLADAIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileCOLLADAIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_FIFileCOLLADAIf_Load(IntPtr _this, IntPtr objs, string fn);
	[DllImport("SprExport")]
	public static extern char Spr_FIFileCOLLADAIf_Save(IntPtr _this, IntPtr objs, string fn);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FIFileBinaryIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FIFileBinaryIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileBinaryIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FIFileBinaryIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileBinaryIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIFileBinaryIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern char Spr_FIFileBinaryIf_Load(IntPtr _this, IntPtr objs, string fn);
	[DllImport("SprExport")]
	public static extern char Spr_FIFileBinaryIf_Save(IntPtr _this, IntPtr objs, string fn);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_ImportIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_ImportIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ImportIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_ImportIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ImportIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_ImportIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_ImportIf_SetLoadOnly(IntPtr _this, bool on);
	[DllImport("SprExport")]
	public static extern void Spr_ImportIf_SetLoadOnly_1(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FISdkIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FISdkIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FISdkIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FISdkIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FISdkIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FISdkIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FISdkIf_CreateFileX(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FISdkIf_CreateFileSpr(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FISdkIf_CreateFileVRML(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FISdkIf_CreateFileCOLLADA(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FISdkIf_CreateFileBinary(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FISdkIf_CreateFileFromExt(IntPtr _this, IntPtr filename);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FISdkIf_CreateImport(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FISdkIf_CreateImport_1(IntPtr _this, IntPtr parent, IntPtr path, IntPtr owner, IntPtr children);
	[DllImport("SprExport")]
	public static extern char Spr_FISdkIf_DelChildObject(IntPtr _this, IntPtr o);
	[DllImport("SprExport")]
	public static extern void Spr_FISdkIf_Clear(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FISdkIf_RegisterSdk();
	[DllImport("SprExport")]
	public static extern IntPtr Spr_new_FIOpStateHandlerIf();
	[DllImport("SprExport")]
	public static extern void Spr_delete_FIOpStateHandlerIf(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIOpStateHandlerIf_ToString(IntPtr _this);
	[DllImport("SprExport")]
	public static extern void Spr_FIOpStateHandlerIf_FreeString(IntPtr ptr);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIOpStateHandlerIf_GetIfInfo(IntPtr _this);
	[DllImport("SprExport")]
	public static extern IntPtr Spr_FIOpStateHandlerIf_GetIfInfoStatic();
	[DllImport("SprExport")]
	public static extern void Spr_FIOpStateHandlerIf_saveToFile(IntPtr _this, IntPtr objif, string filename, float fileVersion);
	[DllImport("SprExport")]
	public static extern void Spr_FIOpStateHandlerIf_loadFromFile(IntPtr _this, IntPtr objif, string filename, bool checkName, float fileVersion);
    }
}
