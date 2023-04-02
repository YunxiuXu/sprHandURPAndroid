using System;
using System.Runtime.InteropServices;

public partial class SprExport {
	[DllImport("SprExport")]
	public static extern IntPtr Spr_SEH_Exception_what();
	[DllImport("SprExport")]
	public static extern int Spr_SEH_Exception_translated();

	[DllImport("SprExport")]
	public static extern void Spr_register_exception_raiser(System.Delegate func);
	[DllImport("SprExport")]
	public static extern void Spr_set_se_translator();
}
