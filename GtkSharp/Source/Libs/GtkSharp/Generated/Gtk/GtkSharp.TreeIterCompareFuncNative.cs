// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate int TreeIterCompareFuncNative(IntPtr model, IntPtr a, IntPtr b, IntPtr user_data);

	internal class TreeIterCompareFuncInvoker {

		TreeIterCompareFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~TreeIterCompareFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal TreeIterCompareFuncInvoker (TreeIterCompareFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal TreeIterCompareFuncInvoker (TreeIterCompareFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal TreeIterCompareFuncInvoker (TreeIterCompareFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.TreeIterCompareFunc Handler {
			get {
				return new Gtk.TreeIterCompareFunc(InvokeNative);
			}
		}

		int InvokeNative (Gtk.ITreeModel model, Gtk.TreeIter a, Gtk.TreeIter b)
		{
			IntPtr native_a = GLib.Marshaller.StructureToPtrAlloc (a);
			IntPtr native_b = GLib.Marshaller.StructureToPtrAlloc (b);
			int __result = native_cb (model == null ? IntPtr.Zero : ((model is GLib.Object) ? (model as GLib.Object).Handle : (model as Gtk.TreeModelAdapter).Handle), native_a, native_b, __data);
			Marshal.FreeHGlobal (native_a);
			Marshal.FreeHGlobal (native_b);
			return __result;
		}
	}

	internal class TreeIterCompareFuncWrapper {

		public int NativeCallback (IntPtr model, IntPtr a, IntPtr b, IntPtr user_data)
		{
			try {
				int __ret = managed (Gtk.TreeModelAdapter.GetObject (model, false), Gtk.TreeIter.New (a), Gtk.TreeIter.New (b));
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

		internal TreeIterCompareFuncNative NativeDelegate;
		Gtk.TreeIterCompareFunc managed;

		public TreeIterCompareFuncWrapper (Gtk.TreeIterCompareFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new TreeIterCompareFuncNative (NativeCallback);
		}

		public static Gtk.TreeIterCompareFunc GetManagedDelegate (TreeIterCompareFuncNative native)
		{
			if (native == null)
				return null;
			TreeIterCompareFuncWrapper wrapper = (TreeIterCompareFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}