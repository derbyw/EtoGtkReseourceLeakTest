// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.SelectionModeGType))]
	public enum SelectionMode {

		None,
		Single,
		Browse,
		Multiple,
	}

	internal class SelectionModeGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_selection_mode_get_type();
		static d_gtk_selection_mode_get_type gtk_selection_mode_get_type = FuncLoader.LoadFunction<d_gtk_selection_mode_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_selection_mode_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_selection_mode_get_type ());
			}
		}
	}
#endregion
}
