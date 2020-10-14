// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate int AssistantPageFuncNative(int current_page, IntPtr data);

	internal class AssistantPageFuncInvoker {

		AssistantPageFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~AssistantPageFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal AssistantPageFuncInvoker (AssistantPageFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal AssistantPageFuncInvoker (AssistantPageFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal AssistantPageFuncInvoker (AssistantPageFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.AssistantPageFunc Handler {
			get {
				return new Gtk.AssistantPageFunc(InvokeNative);
			}
		}

		int InvokeNative (int current_page)
		{
			int __result = native_cb (current_page, __data);
			return __result;
		}
	}

	internal class AssistantPageFuncWrapper {

		public int NativeCallback (int current_page, IntPtr data)
		{
			try {
				int __ret = managed (current_page);
				if (release_on_call)
					gch.Free ();
				return __ret;
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

		internal AssistantPageFuncNative NativeDelegate;
		Gtk.AssistantPageFunc managed;

		public AssistantPageFuncWrapper (Gtk.AssistantPageFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new AssistantPageFuncNative (NativeCallback);
		}

		public static Gtk.AssistantPageFunc GetManagedDelegate (AssistantPageFuncNative native)
		{
			if (native == null)
				return null;
			AssistantPageFuncWrapper wrapper = (AssistantPageFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
