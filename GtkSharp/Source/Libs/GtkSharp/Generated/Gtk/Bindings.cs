// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Bindings {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_bindings_activate_event(IntPtr objekt, IntPtr evnt);
		static d_gtk_bindings_activate_event gtk_bindings_activate_event = FuncLoader.LoadFunction<d_gtk_bindings_activate_event>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_bindings_activate_event"));

		public static bool ActivateEvent(GLib.Object objekt, Gdk.EventKey evnt) {
			bool raw_ret = gtk_bindings_activate_event(objekt == null ? IntPtr.Zero : objekt.Handle, evnt == null ? IntPtr.Zero : evnt.Handle);
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}
