// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate void TextTagTableForeachNative(IntPtr tag, IntPtr data);

	internal class TextTagTableForeachInvoker {

		TextTagTableForeachNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~TextTagTableForeachInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal TextTagTableForeachInvoker (TextTagTableForeachNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal TextTagTableForeachInvoker (TextTagTableForeachNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal TextTagTableForeachInvoker (TextTagTableForeachNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.TextTagTableForeach Handler {
			get {
				return new Gtk.TextTagTableForeach(InvokeNative);
			}
		}

		void InvokeNative (Gtk.TextTag tag)
		{
			native_cb (tag == null ? IntPtr.Zero : tag.Handle, __data);
		}
	}

	internal class TextTagTableForeachWrapper {

		public void NativeCallback (IntPtr tag, IntPtr data)
		{
			try {
				managed (GLib.Object.GetObject(tag) as Gtk.TextTag);
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

		internal TextTagTableForeachNative NativeDelegate;
		Gtk.TextTagTableForeach managed;

		public TextTagTableForeachWrapper (Gtk.TextTagTableForeach managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new TextTagTableForeachNative (NativeCallback);
		}

		public static Gtk.TextTagTableForeach GetManagedDelegate (TextTagTableForeachNative native)
		{
			if (native == null)
				return null;
			TextTagTableForeachWrapper wrapper = (TextTagTableForeachWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
