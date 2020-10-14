// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate void TreeModelFilterModifyFuncNative(IntPtr model, IntPtr iter, IntPtr value, int column, IntPtr data);

	internal class TreeModelFilterModifyFuncInvoker {

		TreeModelFilterModifyFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~TreeModelFilterModifyFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal TreeModelFilterModifyFuncInvoker (TreeModelFilterModifyFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal TreeModelFilterModifyFuncInvoker (TreeModelFilterModifyFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal TreeModelFilterModifyFuncInvoker (TreeModelFilterModifyFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.TreeModelFilterModifyFunc Handler {
			get {
				return new Gtk.TreeModelFilterModifyFunc(InvokeNative);
			}
		}

		void InvokeNative (Gtk.ITreeModel model, Gtk.TreeIter iter, ref GLib.Value value, int column)
		{
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			native_cb (model == null ? IntPtr.Zero : ((model is GLib.Object) ? (model as GLib.Object).Handle : (model as Gtk.TreeModelAdapter).Handle), native_iter, native_value, column, __data);
			Marshal.FreeHGlobal (native_iter);
			value = (GLib.Value) Marshal.PtrToStructure (native_value, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_value);
		}
	}

	internal class TreeModelFilterModifyFuncWrapper {

		public void NativeCallback (IntPtr model, IntPtr iter, IntPtr value, int column, IntPtr data)
		{
			try {
				GLib.Value myvalue = (GLib.Value) Marshal.PtrToStructure (value, typeof (GLib.Value));

				managed (Gtk.TreeModelAdapter.GetObject (model, false), Gtk.TreeIter.New (iter), ref myvalue, column);
				if (value != IntPtr.Zero) System.Runtime.InteropServices.Marshal.StructureToPtr (myvalue, value, false);

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

		internal TreeModelFilterModifyFuncNative NativeDelegate;
		Gtk.TreeModelFilterModifyFunc managed;

		public TreeModelFilterModifyFuncWrapper (Gtk.TreeModelFilterModifyFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new TreeModelFilterModifyFuncNative (NativeCallback);
		}

		public static Gtk.TreeModelFilterModifyFunc GetManagedDelegate (TreeModelFilterModifyFuncNative native)
		{
			if (native == null)
				return null;
			TreeModelFilterModifyFuncWrapper wrapper = (TreeModelFilterModifyFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
