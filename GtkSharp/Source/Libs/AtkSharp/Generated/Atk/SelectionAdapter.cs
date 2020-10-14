// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class SelectionAdapter : GLib.GInterfaceAdapter, Atk.ISelection {

		[StructLayout (LayoutKind.Sequential)]
		struct AtkSelectionIface {
			public AddSelectionNativeDelegate AddSelection;
			public ClearSelectionNativeDelegate ClearSelection;
			public RefSelectionNativeDelegate RefSelection;
			public GetSelectionCountNativeDelegate GetSelectionCount;
			public IsChildSelectedNativeDelegate IsChildSelected;
			public RemoveSelectionNativeDelegate RemoveSelection;
			public SelectAllSelectionNativeDelegate SelectAllSelection;
			IntPtr SelectionChanged;
		}

		static AtkSelectionIface iface;

		static SelectionAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (SelectionAdapter));
			iface.AddSelection = new AddSelectionNativeDelegate (AddSelection_cb);
			iface.ClearSelection = new ClearSelectionNativeDelegate (ClearSelection_cb);
			iface.RefSelection = new RefSelectionNativeDelegate (RefSelection_cb);
			iface.GetSelectionCount = new GetSelectionCountNativeDelegate (GetSelectionCount_cb);
			iface.IsChildSelected = new IsChildSelectedNativeDelegate (IsChildSelected_cb);
			iface.RemoveSelection = new RemoveSelectionNativeDelegate (RemoveSelection_cb);
			iface.SelectAllSelection = new SelectAllSelectionNativeDelegate (SelectAllSelection_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool AddSelectionNativeDelegate (IntPtr inst, int i);

		static bool AddSelection_cb (IntPtr inst, int i)
		{
			try {
				ISelectionImplementor __obj = GLib.Object.GetObject (inst, false) as ISelectionImplementor;
				bool __result;
				__result = __obj.AddSelection (i);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ClearSelectionNativeDelegate (IntPtr inst);

		static bool ClearSelection_cb (IntPtr inst)
		{
			try {
				ISelectionImplementor __obj = GLib.Object.GetObject (inst, false) as ISelectionImplementor;
				bool __result;
				__result = __obj.ClearSelection ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr RefSelectionNativeDelegate (IntPtr inst, int i);

		static IntPtr RefSelection_cb (IntPtr inst, int i)
		{
			try {
				ISelectionImplementor __obj = GLib.Object.GetObject (inst, false) as ISelectionImplementor;
				Atk.Object __result;
				__result = __obj.RefSelection (i);
				return __result == null ? IntPtr.Zero : __result.OwnedHandle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetSelectionCountNativeDelegate (IntPtr inst);

		static int GetSelectionCount_cb (IntPtr inst)
		{
			try {
				ISelectionImplementor __obj = GLib.Object.GetObject (inst, false) as ISelectionImplementor;
				int __result;
				__result = __obj.SelectionCount;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool IsChildSelectedNativeDelegate (IntPtr inst, int i);

		static bool IsChildSelected_cb (IntPtr inst, int i)
		{
			try {
				ISelectionImplementor __obj = GLib.Object.GetObject (inst, false) as ISelectionImplementor;
				bool __result;
				__result = __obj.IsChildSelected (i);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool RemoveSelectionNativeDelegate (IntPtr inst, int i);

		static bool RemoveSelection_cb (IntPtr inst, int i)
		{
			try {
				ISelectionImplementor __obj = GLib.Object.GetObject (inst, false) as ISelectionImplementor;
				bool __result;
				__result = __obj.RemoveSelection (i);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SelectAllSelectionNativeDelegate (IntPtr inst);

		static bool SelectAllSelection_cb (IntPtr inst)
		{
			try {
				ISelectionImplementor __obj = GLib.Object.GetObject (inst, false) as ISelectionImplementor;
				bool __result;
				__result = __obj.SelectAllSelection ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			AtkSelectionIface native_iface = (AtkSelectionIface) Marshal.PtrToStructure (ifaceptr, typeof (AtkSelectionIface));
			native_iface.AddSelection = iface.AddSelection;
			native_iface.ClearSelection = iface.ClearSelection;
			native_iface.RefSelection = iface.RefSelection;
			native_iface.GetSelectionCount = iface.GetSelectionCount;
			native_iface.IsChildSelected = iface.IsChildSelected;
			native_iface.RemoveSelection = iface.RemoveSelection;
			native_iface.SelectAllSelection = iface.SelectAllSelection;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public SelectionAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public SelectionAdapter (ISelectionImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public SelectionAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_selection_get_type();
		static d_atk_selection_get_type atk_selection_get_type = FuncLoader.LoadFunction<d_atk_selection_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_selection_get_type"));

		private static GLib.GType _gtype = new GLib.GType (atk_selection_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static ISelection GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static ISelection GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is ISelectionImplementor)
				return new SelectionAdapter (obj as ISelectionImplementor);
			else if (obj as ISelection == null)
				return new SelectionAdapter (obj.Handle);
			else
				return obj as ISelection;
		}

		public ISelectionImplementor Implementor {
			get {
				return implementor as ISelectionImplementor;
			}
		}

		[GLib.Signal("selection_changed")]
		public event System.EventHandler SelectionChanged {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("selection_changed", value);
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("selection_changed", value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_selection_add_selection(IntPtr raw, int i);
		static d_atk_selection_add_selection atk_selection_add_selection = FuncLoader.LoadFunction<d_atk_selection_add_selection>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_selection_add_selection"));

		public bool AddSelection(int i) {
			bool raw_ret = atk_selection_add_selection(Handle, i);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_selection_clear_selection(IntPtr raw);
		static d_atk_selection_clear_selection atk_selection_clear_selection = FuncLoader.LoadFunction<d_atk_selection_clear_selection>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_selection_clear_selection"));

		public bool ClearSelection() {
			bool raw_ret = atk_selection_clear_selection(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_selection_get_selection_count(IntPtr raw);
		static d_atk_selection_get_selection_count atk_selection_get_selection_count = FuncLoader.LoadFunction<d_atk_selection_get_selection_count>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_selection_get_selection_count"));

		public int SelectionCount { 
			get {
				int raw_ret = atk_selection_get_selection_count(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_selection_is_child_selected(IntPtr raw, int i);
		static d_atk_selection_is_child_selected atk_selection_is_child_selected = FuncLoader.LoadFunction<d_atk_selection_is_child_selected>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_selection_is_child_selected"));

		public bool IsChildSelected(int i) {
			bool raw_ret = atk_selection_is_child_selected(Handle, i);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_selection_ref_selection(IntPtr raw, int i);
		static d_atk_selection_ref_selection atk_selection_ref_selection = FuncLoader.LoadFunction<d_atk_selection_ref_selection>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_selection_ref_selection"));

		public Atk.Object RefSelection(int i) {
			IntPtr raw_ret = atk_selection_ref_selection(Handle, i);
			Atk.Object ret = GLib.Object.GetObject(raw_ret, true) as Atk.Object;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_selection_remove_selection(IntPtr raw, int i);
		static d_atk_selection_remove_selection atk_selection_remove_selection = FuncLoader.LoadFunction<d_atk_selection_remove_selection>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_selection_remove_selection"));

		public bool RemoveSelection(int i) {
			bool raw_ret = atk_selection_remove_selection(Handle, i);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_selection_select_all_selection(IntPtr raw);
		static d_atk_selection_select_all_selection atk_selection_select_all_selection = FuncLoader.LoadFunction<d_atk_selection_select_all_selection>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_selection_select_all_selection"));

		public bool SelectAllSelection() {
			bool raw_ret = atk_selection_select_all_selection(Handle);
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}
