// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace AtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate void EventListenerNative(IntPtr obj);

	internal class EventListenerInvoker {

		EventListenerNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~EventListenerInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal EventListenerInvoker (EventListenerNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal EventListenerInvoker (EventListenerNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal EventListenerInvoker (EventListenerNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Atk.EventListener Handler {
			get {
				return new Atk.EventListener(InvokeNative);
			}
		}

		void InvokeNative (Atk.Object obj)
		{
			native_cb (obj == null ? IntPtr.Zero : obj.Handle);
		}
	}

	internal class EventListenerWrapper {

		public void NativeCallback (IntPtr obj)
		{
			try {
				managed (GLib.Object.GetObject(obj) as Atk.Object);
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

		internal EventListenerNative NativeDelegate;
		Atk.EventListener managed;

		public EventListenerWrapper (Atk.EventListener managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new EventListenerNative (NativeCallback);
		}

		public static Atk.EventListener GetManagedDelegate (EventListenerNative native)
		{
			if (native == null)
				return null;
			EventListenerWrapper wrapper = (EventListenerWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
