// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.RecentChooserErrorGType))]
	public enum RecentChooserError {

		NotFound,
		InvalidUri,
	}

	internal class RecentChooserErrorGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_recent_chooser_error_get_type();
		static d_gtk_recent_chooser_error_get_type gtk_recent_chooser_error_get_type = FuncLoader.LoadFunction<d_gtk_recent_chooser_error_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_error_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_recent_chooser_error_get_type ());
			}
		}
	}
#endregion
}
