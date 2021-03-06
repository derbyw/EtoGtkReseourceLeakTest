// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate void PageSetupDoneFuncNative(IntPtr page_setup, IntPtr data);

	internal class PageSetupDoneFuncInvoker {

		PageSetupDoneFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~PageSetupDoneFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal PageSetupDoneFuncInvoker (PageSetupDoneFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal PageSetupDoneFuncInvoker (PageSetupDoneFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal PageSetupDoneFuncInvoker (PageSetupDoneFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.PageSetupDoneFunc Handler {
			get {
				return new Gtk.PageSetupDoneFunc(InvokeNative);
			}
		}

		void InvokeNative (Gtk.PageSetup page_setup)
		{
			native_cb (page_setup == null ? IntPtr.Zero : page_setup.Handle, __data);
		}
	}

	internal class PageSetupDoneFuncWrapper {

		public void NativeCallback (IntPtr page_setup, IntPtr data)
		{
			try {
				managed (GLib.Object.GetObject(page_setup) as Gtk.PageSetup);
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

		internal PageSetupDoneFuncNative NativeDelegate;
		Gtk.PageSetupDoneFunc managed;

		public PageSetupDoneFuncWrapper (Gtk.PageSetupDoneFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new PageSetupDoneFuncNative (NativeCallback);
		}

		public static Gtk.PageSetupDoneFunc GetManagedDelegate (PageSetupDoneFuncNative native)
		{
			if (native == null)
				return null;
			PageSetupDoneFuncWrapper wrapper = (PageSetupDoneFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
