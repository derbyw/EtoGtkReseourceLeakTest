// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gtk.ApplicationInhibitFlagsGType))]
	public enum ApplicationInhibitFlags {

		Logout = 1 << 0,
		Switch = 1 << 1,
		Suspend = 1 << 2,
		Idle = 1 << 3,
	}

	internal class ApplicationInhibitFlagsGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_application_inhibit_flags_get_type();
		static d_gtk_application_inhibit_flags_get_type gtk_application_inhibit_flags_get_type = FuncLoader.LoadFunction<d_gtk_application_inhibit_flags_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_inhibit_flags_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_application_inhibit_flags_get_type ());
			}
		}
	}
#endregion
}
