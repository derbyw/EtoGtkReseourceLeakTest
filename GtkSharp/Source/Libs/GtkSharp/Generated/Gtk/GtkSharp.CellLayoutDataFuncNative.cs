// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate void CellLayoutDataFuncNative(IntPtr cell_layout, IntPtr cell, IntPtr tree_model, IntPtr iter, IntPtr data);

	internal class CellLayoutDataFuncInvoker {

		CellLayoutDataFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~CellLayoutDataFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal CellLayoutDataFuncInvoker (CellLayoutDataFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal CellLayoutDataFuncInvoker (CellLayoutDataFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal CellLayoutDataFuncInvoker (CellLayoutDataFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.CellLayoutDataFunc Handler {
			get {
				return new Gtk.CellLayoutDataFunc(InvokeNative);
			}
		}

		void InvokeNative (Gtk.ICellLayout cell_layout, Gtk.CellRenderer cell, Gtk.ITreeModel tree_model, Gtk.TreeIter iter)
		{
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			native_cb (cell_layout == null ? IntPtr.Zero : ((cell_layout is GLib.Object) ? (cell_layout as GLib.Object).Handle : (cell_layout as Gtk.CellLayoutAdapter).Handle), cell == null ? IntPtr.Zero : cell.Handle, tree_model == null ? IntPtr.Zero : ((tree_model is GLib.Object) ? (tree_model as GLib.Object).Handle : (tree_model as Gtk.TreeModelAdapter).Handle), native_iter, __data);
			Marshal.FreeHGlobal (native_iter);
		}
	}

	internal class CellLayoutDataFuncWrapper {

		public void NativeCallback (IntPtr cell_layout, IntPtr cell, IntPtr tree_model, IntPtr iter, IntPtr data)
		{
			try {
				managed (Gtk.CellLayoutAdapter.GetObject (cell_layout, false), GLib.Object.GetObject(cell) as Gtk.CellRenderer, Gtk.TreeModelAdapter.GetObject (tree_model, false), Gtk.TreeIter.New (iter));
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

		internal CellLayoutDataFuncNative NativeDelegate;
		Gtk.CellLayoutDataFunc managed;

		public CellLayoutDataFuncWrapper (Gtk.CellLayoutDataFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new CellLayoutDataFuncNative (NativeCallback);
		}

		public static Gtk.CellLayoutDataFunc GetManagedDelegate (CellLayoutDataFuncNative native)
		{
			if (native == null)
				return null;
			CellLayoutDataFuncWrapper wrapper = (CellLayoutDataFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}