// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.VisibilityStateGType))]
	public enum VisibilityState {

		Unobscured,
		Partial,
		FullyObscured,
	}

	internal class VisibilityStateGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_visibility_state_get_type();
		static d_gdk_visibility_state_get_type gdk_visibility_state_get_type = FuncLoader.LoadFunction<d_gdk_visibility_state_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visibility_state_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_visibility_state_get_type ());
			}
		}
	}
#endregion
}
