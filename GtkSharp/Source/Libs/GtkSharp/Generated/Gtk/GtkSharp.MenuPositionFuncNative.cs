// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate void MenuPositionFuncNative(IntPtr menu, out int x, out int y, out bool push_in, IntPtr user_data);

	internal class MenuPositionFuncInvoker {

		MenuPositionFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~MenuPositionFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal MenuPositionFuncInvoker (MenuPositionFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal MenuPositionFuncInvoker (MenuPositionFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal MenuPositionFuncInvoker (MenuPositionFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.MenuPositionFunc Handler {
			get {
				return new Gtk.MenuPositionFunc(InvokeNative);
			}
		}

		void InvokeNative (Gtk.Menu menu, out int x, out int y, out bool push_in)
		{
			native_cb (menu == null ? IntPtr.Zero : menu.Handle, out x, out y, out push_in, __data);
		}
	}

	internal class MenuPositionFuncWrapper {

		public void NativeCallback (IntPtr menu, out int x, out int y, out bool push_in, IntPtr user_data)
		{
			try {
				managed (GLib.Object.GetObject(menu) as Gtk.Menu, out x, out y, out push_in);
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal MenuPositionFuncNative NativeDelegate;
		Gtk.MenuPositionFunc managed;

		public MenuPositionFuncWrapper (Gtk.MenuPositionFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new MenuPositionFuncNative (NativeCallback);
		}

		public static Gtk.MenuPositionFunc GetManagedDelegate (MenuPositionFuncNative native)
		{
			if (native == null)
				return null;
			MenuPositionFuncWrapper wrapper = (MenuPositionFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
