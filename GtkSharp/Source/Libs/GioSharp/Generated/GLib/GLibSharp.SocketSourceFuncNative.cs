// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLibSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate bool SocketSourceFuncNative(IntPtr socket, int condition, IntPtr user_data);

	internal class SocketSourceFuncInvoker {

		SocketSourceFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~SocketSourceFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal SocketSourceFuncInvoker (SocketSourceFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal SocketSourceFuncInvoker (SocketSourceFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal SocketSourceFuncInvoker (SocketSourceFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal GLib.SocketSourceFunc Handler {
			get {
				return new GLib.SocketSourceFunc(InvokeNative);
			}
		}

		bool InvokeNative (GLib.Socket socket, GLib.IOCondition condition)
		{
			bool __result = native_cb (socket == null ? IntPtr.Zero : socket.Handle, (int) condition, __data);
			return __result;
		}
	}

	internal class SocketSourceFuncWrapper {

		public bool NativeCallback (IntPtr socket, int condition, IntPtr user_data)
		{
			try {
				bool __ret = managed (socket == IntPtr.Zero ? null : (GLib.Socket) GLib.Opaque.GetOpaque (socket, typeof (GLib.Socket), false), (GLib.IOCondition) condition);
				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
				return false;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal SocketSourceFuncNative NativeDelegate;
		GLib.SocketSourceFunc managed;

		public SocketSourceFuncWrapper (GLib.SocketSourceFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new SocketSourceFuncNative (NativeCallback);
		}

		public static GLib.SocketSourceFunc GetManagedDelegate (SocketSourceFuncNative native)
		{
			if (native == null)
				return null;
			SocketSourceFuncWrapper wrapper = (SocketSourceFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
