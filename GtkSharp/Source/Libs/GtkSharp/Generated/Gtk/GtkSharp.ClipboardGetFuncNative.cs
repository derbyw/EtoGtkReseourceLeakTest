// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate void ClipboardGetFuncNative(IntPtr clipboard, IntPtr selection_data, uint info, IntPtr user_data_or_owner);

	internal class ClipboardGetFuncInvoker {

		ClipboardGetFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~ClipboardGetFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal ClipboardGetFuncInvoker (ClipboardGetFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal ClipboardGetFuncInvoker (ClipboardGetFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal ClipboardGetFuncInvoker (ClipboardGetFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.ClipboardGetFunc Handler {
			get {
				return new Gtk.ClipboardGetFunc(InvokeNative);
			}
		}

		void InvokeNative (Gtk.Clipboard clipboard, Gtk.SelectionData selection_data, uint info)
		{
			native_cb (clipboard == null ? IntPtr.Zero : clipboard.Handle, selection_data == null ? IntPtr.Zero : selection_data.Handle, info, __data);
		}
	}

	internal class ClipboardGetFuncWrapper {

		public void NativeCallback (IntPtr clipboard, IntPtr selection_data, uint info, IntPtr user_data_or_owner)
		{
			try {
				managed (GLib.Object.GetObject(clipboard) as Gtk.Clipboard, selection_data == IntPtr.Zero ? null : (Gtk.SelectionData) GLib.Opaque.GetOpaque (selection_data, typeof (Gtk.SelectionData), false), info);
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal ClipboardGetFuncNative NativeDelegate;
		Gtk.ClipboardGetFunc managed;

		public ClipboardGetFuncWrapper (Gtk.ClipboardGetFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new ClipboardGetFuncNative (NativeCallback);
		}

		public static Gtk.ClipboardGetFunc GetManagedDelegate (ClipboardGetFuncNative native)
		{
			if (native == null)
				return null;
			ClipboardGetFuncWrapper wrapper = (ClipboardGetFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
