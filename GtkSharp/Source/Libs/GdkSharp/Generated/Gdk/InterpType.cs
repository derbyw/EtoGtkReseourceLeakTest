// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.InterpTypeGType))]
	public enum InterpType {

		Nearest,
		Tiles,
		Bilinear,
		Hyper,
	}

	internal class InterpTypeGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_interp_type_get_type();
		static d_gdk_interp_type_get_type gdk_interp_type_get_type = FuncLoader.LoadFunction<d_gdk_interp_type_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_interp_type_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_interp_type_get_type ());
			}
		}
	}
#endregion
}
