// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.DragCancelReasonGType))]
	public enum DragCancelReason {

		NoTarget,
		UserCancelled,
		Error,
	}

	internal class DragCancelReasonGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_drag_cancel_reason_get_type();
		static d_gdk_drag_cancel_reason_get_type gdk_drag_cancel_reason_get_type = FuncLoader.LoadFunction<d_gdk_drag_cancel_reason_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_drag_cancel_reason_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_drag_cancel_reason_get_type ());
			}
		}
	}
#endregion
}
