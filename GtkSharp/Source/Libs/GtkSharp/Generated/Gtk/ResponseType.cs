// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.ResponseTypeGType))]
	public enum ResponseType {

		None = -1,
		Reject = -2,
		Accept = -3,
		DeleteEvent = -4,
		Ok = -5,
		Cancel = -6,
		Close = -7,
		Yes = -8,
		No = -9,
		Apply = -10,
		Help = -11,
	}

	internal class ResponseTypeGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_response_type_get_type();
		static d_gtk_response_type_get_type gtk_response_type_get_type = FuncLoader.LoadFunction<d_gtk_response_type_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_response_type_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_response_type_get_type ());
			}
		}
	}
#endregion
}
