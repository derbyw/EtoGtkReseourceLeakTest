// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gtk.RegionFlagsGType))]
	public enum RegionFlags {

		Even = 1 << 0,
		Odd = 1 << 1,
		First = 1 << 2,
		Last = 1 << 3,
		Only = 1 << 4,
		Sorted = 1 << 5,
	}

	internal class RegionFlagsGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_region_flags_get_type();
		static d_gtk_region_flags_get_type gtk_region_flags_get_type = FuncLoader.LoadFunction<d_gtk_region_flags_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_region_flags_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_region_flags_get_type ());
			}
		}
	}
#endregion
}
