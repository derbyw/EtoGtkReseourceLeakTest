// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.RecentSortTypeGType))]
	public enum RecentSortType {

		None,
		Mru,
		Lru,
		Custom,
	}

	internal class RecentSortTypeGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_recent_sort_type_get_type();
		static d_gtk_recent_sort_type_get_type gtk_recent_sort_type_get_type = FuncLoader.LoadFunction<d_gtk_recent_sort_type_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_sort_type_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_recent_sort_type_get_type ());
			}
		}
	}
#endregion
}
