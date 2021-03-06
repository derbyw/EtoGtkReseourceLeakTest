// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate void ClipboardURIReceivedFuncNative(IntPtr clipboard, IntPtr uris, IntPtr data);

	internal class ClipboardURIReceivedFuncInvoker {

		ClipboardURIReceivedFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~ClipboardURIReceivedFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal ClipboardURIReceivedFuncInvoker (ClipboardURIReceivedFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal ClipboardURIReceivedFuncInvoker (ClipboardURIReceivedFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal ClipboardURIReceivedFuncInvoker (ClipboardURIReceivedFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.ClipboardURIReceivedFunc Handler {
			get {
				return new Gtk.ClipboardURIReceivedFunc(InvokeNative);
			}
		}

		void InvokeNative (Gtk.Clipboard clipboard, string uris)
		{
			native_cb (clipboard == null ? IntPtr.Zero : clipboard.Handle, GLib.Marshaller.StringToPtrGStrdup(uris), __data);
		}
	}

	internal class ClipboardURIReceivedFuncWrapper {

		public void NativeCallback (IntPtr clipboard, IntPtr uris, IntPtr data)
		{
			try {
				managed (GLib.Object.GetObject(clipboard) as Gtk.Clipboard, GLib.Marshaller.PtrToStringGFree(uris));
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

		internal ClipboardURIReceivedFuncNative NativeDelegate;
		Gtk.ClipboardURIReceivedFunc managed;

		public ClipboardURIReceivedFuncWrapper (Gtk.ClipboardURIReceivedFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new ClipboardURIReceivedFuncNative (NativeCallback);
		}

		public static Gtk.ClipboardURIReceivedFunc GetManagedDelegate (ClipboardURIReceivedFuncNative native)
		{
			if (native == null)
				return null;
			ClipboardURIReceivedFuncWrapper wrapper = (ClipboardURIReceivedFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
