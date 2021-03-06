// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Selection {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_selection_convert(IntPtr requestor, IntPtr selection, IntPtr target, uint time_);
		static d_gdk_selection_convert gdk_selection_convert = FuncLoader.LoadFunction<d_gdk_selection_convert>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_selection_convert"));

		public static void Convert(Gdk.Window requestor, Gdk.Atom selection, Gdk.Atom target, uint time_) {
			gdk_selection_convert(requestor == null ? IntPtr.Zero : requestor.Handle, selection == null ? IntPtr.Zero : selection.Handle, target == null ? IntPtr.Zero : target.Handle, time_);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_selection_owner_get(IntPtr selection);
		static d_gdk_selection_owner_get gdk_selection_owner_get = FuncLoader.LoadFunction<d_gdk_selection_owner_get>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_selection_owner_get"));

		public static Gdk.Window OwnerGet(Gdk.Atom selection) {
			IntPtr raw_ret = gdk_selection_owner_get(selection == null ? IntPtr.Zero : selection.Handle);
			Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_selection_owner_get_for_display(IntPtr display, IntPtr selection);
		static d_gdk_selection_owner_get_for_display gdk_selection_owner_get_for_display = FuncLoader.LoadFunction<d_gdk_selection_owner_get_for_display>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_selection_owner_get_for_display"));

		public static Gdk.Window OwnerGetForDisplay(Gdk.Display display, Gdk.Atom selection) {
			IntPtr raw_ret = gdk_selection_owner_get_for_display(display == null ? IntPtr.Zero : display.Handle, selection == null ? IntPtr.Zero : selection.Handle);
			Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_selection_owner_set(IntPtr owner, IntPtr selection, uint time_, bool send_event);
		static d_gdk_selection_owner_set gdk_selection_owner_set = FuncLoader.LoadFunction<d_gdk_selection_owner_set>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_selection_owner_set"));

		public static bool OwnerSet(Gdk.Window owner, Gdk.Atom selection, uint time_, bool send_event) {
			bool raw_ret = gdk_selection_owner_set(owner == null ? IntPtr.Zero : owner.Handle, selection == null ? IntPtr.Zero : selection.Handle, time_, send_event);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_selection_owner_set_for_display(IntPtr display, IntPtr owner, IntPtr selection, uint time_, bool send_event);
		static d_gdk_selection_owner_set_for_display gdk_selection_owner_set_for_display = FuncLoader.LoadFunction<d_gdk_selection_owner_set_for_display>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_selection_owner_set_for_display"));

		public static bool OwnerSetForDisplay(Gdk.Display display, Gdk.Window owner, Gdk.Atom selection, uint time_, bool send_event) {
			bool raw_ret = gdk_selection_owner_set_for_display(display == null ? IntPtr.Zero : display.Handle, owner == null ? IntPtr.Zero : owner.Handle, selection == null ? IntPtr.Zero : selection.Handle, time_, send_event);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_selection_send_notify(IntPtr requestor, IntPtr selection, IntPtr target, IntPtr property, uint time_);
		static d_gdk_selection_send_notify gdk_selection_send_notify = FuncLoader.LoadFunction<d_gdk_selection_send_notify>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_selection_send_notify"));

		public static void SendNotify(Gdk.Window requestor, Gdk.Atom selection, Gdk.Atom target, Gdk.Atom property, uint time_) {
			gdk_selection_send_notify(requestor == null ? IntPtr.Zero : requestor.Handle, selection == null ? IntPtr.Zero : selection.Handle, target == null ? IntPtr.Zero : target.Handle, property == null ? IntPtr.Zero : property.Handle, time_);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_selection_send_notify_for_display(IntPtr display, IntPtr requestor, IntPtr selection, IntPtr target, IntPtr property, uint time_);
		static d_gdk_selection_send_notify_for_display gdk_selection_send_notify_for_display = FuncLoader.LoadFunction<d_gdk_selection_send_notify_for_display>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_selection_send_notify_for_display"));

		public static void SendNotifyForDisplay(Gdk.Display display, Gdk.Window requestor, Gdk.Atom selection, Gdk.Atom target, Gdk.Atom property, uint time_) {
			gdk_selection_send_notify_for_display(display == null ? IntPtr.Zero : display.Handle, requestor == null ? IntPtr.Zero : requestor.Handle, selection == null ? IntPtr.Zero : selection.Handle, target == null ? IntPtr.Zero : target.Handle, property == null ? IntPtr.Zero : property.Handle, time_);
		}

#endregion
	}
}
