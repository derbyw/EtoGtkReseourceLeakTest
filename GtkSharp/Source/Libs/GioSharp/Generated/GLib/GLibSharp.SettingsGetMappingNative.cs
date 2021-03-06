// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLibSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate bool SettingsGetMappingNative(IntPtr value, IntPtr result, IntPtr user_data);

	internal class SettingsGetMappingInvoker {

		SettingsGetMappingNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~SettingsGetMappingInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal SettingsGetMappingInvoker (SettingsGetMappingNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal SettingsGetMappingInvoker (SettingsGetMappingNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal SettingsGetMappingInvoker (SettingsGetMappingNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal GLib.SettingsGetMapping Handler {
			get {
				return new GLib.SettingsGetMapping(InvokeNative);
			}
		}

		bool InvokeNative (GLib.Variant value, IntPtr result)
		{
			bool __result = native_cb (value == null ? IntPtr.Zero : value.Handle, result, __data);
			return __result;
		}
	}

	internal class SettingsGetMappingWrapper {

		public bool NativeCallback (IntPtr value, IntPtr result, IntPtr user_data)
		{
			try {
				bool __ret = managed (new GLib.Variant(value), result);
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

		internal SettingsGetMappingNative NativeDelegate;
		GLib.SettingsGetMapping managed;

		public SettingsGetMappingWrapper (GLib.SettingsGetMapping managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new SettingsGetMappingNative (NativeCallback);
		}

		public static GLib.SettingsGetMapping GetManagedDelegate (SettingsGetMappingNative native)
		{
			if (native == null)
				return null;
			SettingsGetMappingWrapper wrapper = (SettingsGetMappingWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
