// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate void IconViewForeachFuncNative(IntPtr icon_view, IntPtr path, IntPtr data);

	internal class IconViewForeachFuncInvoker {

		IconViewForeachFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~IconViewForeachFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal IconViewForeachFuncInvoker (IconViewForeachFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal IconViewForeachFuncInvoker (IconViewForeachFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal IconViewForeachFuncInvoker (IconViewForeachFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.IconViewForeachFunc Handler {
			get {
				return new Gtk.IconViewForeachFunc(InvokeNative);
			}
		}

		void InvokeNative (Gtk.IconView icon_view, Gtk.TreePath path)
		{
			native_cb (icon_view == null ? IntPtr.Zero : icon_view.Handle, path == null ? IntPtr.Zero : path.Handle, __data);
		}
	}

	internal class IconViewForeachFuncWrapper {

		public void NativeCallback (IntPtr icon_view, IntPtr path, IntPtr data)
		{
			try {
				managed (GLib.Object.GetObject(icon_view) as Gtk.IconView, path == IntPtr.Zero ? null : (Gtk.TreePath) GLib.Opaque.GetOpaque (path, typeof (Gtk.TreePath), false));
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

		internal IconViewForeachFuncNative NativeDelegate;
		Gtk.IconViewForeachFunc managed;

		public IconViewForeachFuncWrapper (Gtk.IconViewForeachFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new IconViewForeachFuncNative (NativeCallback);
		}

		public static Gtk.IconViewForeachFunc GetManagedDelegate (IconViewForeachFuncNative native)
		{
			if (native == null)
				return null;
			IconViewForeachFuncWrapper wrapper = (IconViewForeachFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
