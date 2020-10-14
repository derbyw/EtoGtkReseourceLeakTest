// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Toolbar : Gtk.Container, Gtk.IToolShell, Gtk.IOrientable {

		public Toolbar (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_toolbar_new();
		static d_gtk_toolbar_new gtk_toolbar_new = FuncLoader.LoadFunction<d_gtk_toolbar_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_new"));

		public Toolbar () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Toolbar)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			owned = true;
			Raw = gtk_toolbar_new();
		}

		[GLib.Property ("toolbar-style")]
		public Gtk.ToolbarStyle ToolbarStyle {
			get {
				GLib.Value val = GetProperty ("toolbar-style");
				Gtk.ToolbarStyle ret = (Gtk.ToolbarStyle) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("toolbar-style", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_toolbar_get_show_arrow(IntPtr raw);
		static d_gtk_toolbar_get_show_arrow gtk_toolbar_get_show_arrow = FuncLoader.LoadFunction<d_gtk_toolbar_get_show_arrow>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_get_show_arrow"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_toolbar_set_show_arrow(IntPtr raw, bool show_arrow);
		static d_gtk_toolbar_set_show_arrow gtk_toolbar_set_show_arrow = FuncLoader.LoadFunction<d_gtk_toolbar_set_show_arrow>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_set_show_arrow"));

		[GLib.Property ("show-arrow")]
		public bool ShowArrow {
			get  {
				bool raw_ret = gtk_toolbar_get_show_arrow(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_toolbar_set_show_arrow(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_toolbar_get_icon_size(IntPtr raw);
		static d_gtk_toolbar_get_icon_size gtk_toolbar_get_icon_size = FuncLoader.LoadFunction<d_gtk_toolbar_get_icon_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_get_icon_size"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_toolbar_set_icon_size(IntPtr raw, int icon_size);
		static d_gtk_toolbar_set_icon_size gtk_toolbar_set_icon_size = FuncLoader.LoadFunction<d_gtk_toolbar_set_icon_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_set_icon_size"));

		[GLib.Property ("icon-size")]
		public Gtk.IconSize IconSize {
			get  {
				int raw_ret = gtk_toolbar_get_icon_size(Handle);
				Gtk.IconSize ret = (Gtk.IconSize) raw_ret;
				return ret;
			}
			set  {
				gtk_toolbar_set_icon_size(Handle, (int) value);
			}
		}

		[GLib.Property ("icon-size-set")]
		public bool IconSizeSet {
			get {
				GLib.Value val = GetProperty ("icon-size-set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("icon-size-set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("space-size")]
		public int SpaceSize {
			get {
				GLib.Value val = GetProperty ("space-size");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("internal-padding")]
		public int InternalPadding {
			get {
				GLib.Value val = GetProperty ("internal-padding");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("max-child-expand")]
		public int MaxChildExpand {
			get {
				GLib.Value val = GetProperty ("max-child-expand");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("button-relief")]
		public Gtk.ReliefStyle ButtonRelief {
			get {
				GLib.Value val = GetProperty ("button-relief");
				Gtk.ReliefStyle ret = (Gtk.ReliefStyle) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("shadow-type")]
		public Gtk.ShadowType ShadowType {
			get {
				GLib.Value val = GetProperty ("shadow-type");
				Gtk.ShadowType ret = (Gtk.ShadowType) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		public class ToolbarChild : Gtk.Container.ContainerChild {
			protected internal ToolbarChild (Gtk.Container parent, Gtk.Widget child) : base (parent, child) {}

			[Gtk.ChildProperty ("expand")]
			public new bool Expand {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "expand");
					bool ret = (bool) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "expand", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("homogeneous")]
			public bool Homogeneous {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "homogeneous");
					bool ret = (bool) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "homogeneous", val);
					val.Dispose ();
				}
			}

		}

		public override Gtk.Container.ContainerChild this [Gtk.Widget child] {
			get {
				return new ToolbarChild (this, child);
			}
		}

		[GLib.Signal("style-changed")]
		public event Gtk.StyleChangedHandler StyleChanged {
			add {
				this.AddSignalHandler ("style-changed", value, typeof (Gtk.StyleChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("style-changed", value);
			}
		}

		[GLib.Signal("popup-context-menu")]
		public event Gtk.PopupContextMenuHandler PopupContextMenu {
			add {
				this.AddSignalHandler ("popup-context-menu", value, typeof (Gtk.PopupContextMenuArgs));
			}
			remove {
				this.RemoveSignalHandler ("popup-context-menu", value);
			}
		}

		[GLib.Signal("focus-home-or-end")]
		public event Gtk.FocusHomeOrEndHandler FocusHomeOrEnd {
			add {
				this.AddSignalHandler ("focus-home-or-end", value, typeof (Gtk.FocusHomeOrEndArgs));
			}
			remove {
				this.RemoveSignalHandler ("focus-home-or-end", value);
			}
		}

		[GLib.Signal("orientation-changed")]
		public event Gtk.OrientationChangedHandler OrientationChanged {
			add {
				this.AddSignalHandler ("orientation-changed", value, typeof (Gtk.OrientationChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("orientation-changed", value);
			}
		}

		static FocusHomeOrEndNativeDelegate FocusHomeOrEnd_cb_delegate;
		static FocusHomeOrEndNativeDelegate FocusHomeOrEndVMCallback {
			get {
				if (FocusHomeOrEnd_cb_delegate == null)
					FocusHomeOrEnd_cb_delegate = new FocusHomeOrEndNativeDelegate (FocusHomeOrEnd_cb);
				return FocusHomeOrEnd_cb_delegate;
			}
		}

		static void OverrideFocusHomeOrEnd (GLib.GType gtype)
		{
			OverrideFocusHomeOrEnd (gtype, FocusHomeOrEndVMCallback);
		}

		static void OverrideFocusHomeOrEnd (GLib.GType gtype, FocusHomeOrEndNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "focus-home-or-end", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool FocusHomeOrEndNativeDelegate (IntPtr inst, bool p0);

		static bool FocusHomeOrEnd_cb (IntPtr inst, bool p0)
		{
			try {
				Toolbar __obj = GLib.Object.GetObject (inst, false) as Toolbar;
				bool __result;
				__result = __obj.OnFocusHomeOrEnd (p0);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Toolbar), ConnectionMethod="OverrideFocusHomeOrEnd")]
		protected virtual bool OnFocusHomeOrEnd (bool p0)
		{
			return InternalFocusHomeOrEnd (p0);
		}

		private bool InternalFocusHomeOrEnd (bool p0)
		{
			GLib.Value ret = new GLib.Value (GLib.GType.Boolean);
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (p0);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
			bool result = (bool) ret;
			ret.Dispose ();
			return result;
		}

		static OrientationChangedNativeDelegate OrientationChanged_cb_delegate;
		static OrientationChangedNativeDelegate OrientationChangedVMCallback {
			get {
				if (OrientationChanged_cb_delegate == null)
					OrientationChanged_cb_delegate = new OrientationChangedNativeDelegate (OrientationChanged_cb);
				return OrientationChanged_cb_delegate;
			}
		}

		static void OverrideOrientationChanged (GLib.GType gtype)
		{
			OverrideOrientationChanged (gtype, OrientationChangedVMCallback);
		}

		static void OverrideOrientationChanged (GLib.GType gtype, OrientationChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("orientation_changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void OrientationChangedNativeDelegate (IntPtr inst, int orientation);

		static void OrientationChanged_cb (IntPtr inst, int orientation)
		{
			try {
				Toolbar __obj = GLib.Object.GetObject (inst, false) as Toolbar;
				__obj.OnOrientationChanged ((Gtk.Orientation) orientation);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Toolbar), ConnectionMethod="OverrideOrientationChanged")]
		protected virtual void OnOrientationChanged (Gtk.Orientation orientation)
		{
			InternalOrientationChanged (orientation);
		}

		private void InternalOrientationChanged (Gtk.Orientation orientation)
		{
			OrientationChangedNativeDelegate unmanaged = class_abi.BaseOverride<OrientationChangedNativeDelegate>(this.LookupGType(), "orientation_changed");
			if (unmanaged == null) return;

			unmanaged (this.Handle, (int) orientation);
		}

		static StyleChangedNativeDelegate StyleChanged_cb_delegate;
		static StyleChangedNativeDelegate StyleChangedVMCallback {
			get {
				if (StyleChanged_cb_delegate == null)
					StyleChanged_cb_delegate = new StyleChangedNativeDelegate (StyleChanged_cb);
				return StyleChanged_cb_delegate;
			}
		}

		static void OverrideStyleChanged (GLib.GType gtype)
		{
			OverrideStyleChanged (gtype, StyleChangedVMCallback);
		}

		static void OverrideStyleChanged (GLib.GType gtype, StyleChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("style_changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void StyleChangedNativeDelegate (IntPtr inst, int style);

		static void StyleChanged_cb (IntPtr inst, int style)
		{
			try {
				Toolbar __obj = GLib.Object.GetObject (inst, false) as Toolbar;
				__obj.OnStyleChanged ((Gtk.ToolbarStyle) style);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Toolbar), ConnectionMethod="OverrideStyleChanged")]
		protected virtual void OnStyleChanged (Gtk.ToolbarStyle style)
		{
			InternalStyleChanged (style);
		}

		private void InternalStyleChanged (Gtk.ToolbarStyle style)
		{
			StyleChangedNativeDelegate unmanaged = class_abi.BaseOverride<StyleChangedNativeDelegate>(this.LookupGType(), "style_changed");
			if (unmanaged == null) return;

			unmanaged (this.Handle, (int) style);
		}

		static PopupContextMenuNativeDelegate PopupContextMenu_cb_delegate;
		static PopupContextMenuNativeDelegate PopupContextMenuVMCallback {
			get {
				if (PopupContextMenu_cb_delegate == null)
					PopupContextMenu_cb_delegate = new PopupContextMenuNativeDelegate (PopupContextMenu_cb);
				return PopupContextMenu_cb_delegate;
			}
		}

		static void OverridePopupContextMenu (GLib.GType gtype)
		{
			OverridePopupContextMenu (gtype, PopupContextMenuVMCallback);
		}

		static void OverridePopupContextMenu (GLib.GType gtype, PopupContextMenuNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("popup_context_menu"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool PopupContextMenuNativeDelegate (IntPtr inst, int x, int y, int button_number);

		static bool PopupContextMenu_cb (IntPtr inst, int x, int y, int button_number)
		{
			try {
				Toolbar __obj = GLib.Object.GetObject (inst, false) as Toolbar;
				bool __result;
				__result = __obj.OnPopupContextMenu (x, y, button_number);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Toolbar), ConnectionMethod="OverridePopupContextMenu")]
		protected virtual bool OnPopupContextMenu (int x, int y, int button_number)
		{
			return InternalPopupContextMenu (x, y, button_number);
		}

		private bool InternalPopupContextMenu (int x, int y, int button_number)
		{
			PopupContextMenuNativeDelegate unmanaged = class_abi.BaseOverride<PopupContextMenuNativeDelegate>(this.LookupGType(), "popup_context_menu");
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, x, y, button_number);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("orientation_changed"
							, Gtk.Container.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // orientation_changed
							, null
							, "style_changed"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("style_changed"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // style_changed
							, "orientation_changed"
							, "popup_context_menu"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("popup_context_menu"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // popup_context_menu
							, "style_changed"
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "popup_context_menu"
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_toolbar_get_drop_index(IntPtr raw, int x, int y);
		static d_gtk_toolbar_get_drop_index gtk_toolbar_get_drop_index = FuncLoader.LoadFunction<d_gtk_toolbar_get_drop_index>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_get_drop_index"));

		public int GetDropIndex(int x, int y) {
			int raw_ret = gtk_toolbar_get_drop_index(Handle, x, y);
			int ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_toolbar_get_item_index(IntPtr raw, IntPtr item);
		static d_gtk_toolbar_get_item_index gtk_toolbar_get_item_index = FuncLoader.LoadFunction<d_gtk_toolbar_get_item_index>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_get_item_index"));

		public int GetItemIndex(Gtk.ToolItem item) {
			int raw_ret = gtk_toolbar_get_item_index(Handle, item == null ? IntPtr.Zero : item.Handle);
			int ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_toolbar_get_n_items(IntPtr raw);
		static d_gtk_toolbar_get_n_items gtk_toolbar_get_n_items = FuncLoader.LoadFunction<d_gtk_toolbar_get_n_items>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_get_n_items"));

		public int NItems { 
			get {
				int raw_ret = gtk_toolbar_get_n_items(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_toolbar_get_nth_item(IntPtr raw, int n);
		static d_gtk_toolbar_get_nth_item gtk_toolbar_get_nth_item = FuncLoader.LoadFunction<d_gtk_toolbar_get_nth_item>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_get_nth_item"));

		public Gtk.ToolItem GetNthItem(int n) {
			IntPtr raw_ret = gtk_toolbar_get_nth_item(Handle, n);
			Gtk.ToolItem ret = GLib.Object.GetObject(raw_ret) as Gtk.ToolItem;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_toolbar_get_relief_style(IntPtr raw);
		static d_gtk_toolbar_get_relief_style gtk_toolbar_get_relief_style = FuncLoader.LoadFunction<d_gtk_toolbar_get_relief_style>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_get_relief_style"));

		public Gtk.ReliefStyle ReliefStyle { 
			get {
				int raw_ret = gtk_toolbar_get_relief_style(Handle);
				Gtk.ReliefStyle ret = (Gtk.ReliefStyle) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_toolbar_get_style(IntPtr raw);
		static d_gtk_toolbar_get_style gtk_toolbar_get_style = FuncLoader.LoadFunction<d_gtk_toolbar_get_style>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_get_style"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_toolbar_set_style(IntPtr raw, int style);
		static d_gtk_toolbar_set_style gtk_toolbar_set_style = FuncLoader.LoadFunction<d_gtk_toolbar_set_style>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_set_style"));

		public new Gtk.ToolbarStyle Style { 
			get {
				int raw_ret = gtk_toolbar_get_style(Handle);
				Gtk.ToolbarStyle ret = (Gtk.ToolbarStyle) raw_ret;
				return ret;
			}
			set {
				gtk_toolbar_set_style(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_toolbar_get_type();
		static d_gtk_toolbar_get_type gtk_toolbar_get_type = FuncLoader.LoadFunction<d_gtk_toolbar_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_toolbar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_toolbar_insert(IntPtr raw, IntPtr item, int pos);
		static d_gtk_toolbar_insert gtk_toolbar_insert = FuncLoader.LoadFunction<d_gtk_toolbar_insert>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_insert"));

		public void Insert(Gtk.ToolItem item, int pos) {
			gtk_toolbar_insert(Handle, item == null ? IntPtr.Zero : item.Handle, pos);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_toolbar_set_drop_highlight_item(IntPtr raw, IntPtr tool_item, int index_);
		static d_gtk_toolbar_set_drop_highlight_item gtk_toolbar_set_drop_highlight_item = FuncLoader.LoadFunction<d_gtk_toolbar_set_drop_highlight_item>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_set_drop_highlight_item"));

		public void SetDropHighlightItem(Gtk.ToolItem tool_item, int index_) {
			gtk_toolbar_set_drop_highlight_item(Handle, tool_item == null ? IntPtr.Zero : tool_item.Handle, index_);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_toolbar_unset_icon_size(IntPtr raw);
		static d_gtk_toolbar_unset_icon_size gtk_toolbar_unset_icon_size = FuncLoader.LoadFunction<d_gtk_toolbar_unset_icon_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_unset_icon_size"));

		public void UnsetIconSize() {
			gtk_toolbar_unset_icon_size(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_toolbar_unset_style(IntPtr raw);
		static d_gtk_toolbar_unset_style gtk_toolbar_unset_style = FuncLoader.LoadFunction<d_gtk_toolbar_unset_style>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toolbar_unset_style"));

		public void UnsetStyle() {
			gtk_toolbar_unset_style(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tool_shell_get_ellipsize_mode(IntPtr raw);
		static d_gtk_tool_shell_get_ellipsize_mode gtk_tool_shell_get_ellipsize_mode = FuncLoader.LoadFunction<d_gtk_tool_shell_get_ellipsize_mode>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tool_shell_get_ellipsize_mode"));

		public Pango.EllipsizeMode EllipsizeMode { 
			get {
				int raw_ret = gtk_tool_shell_get_ellipsize_mode(Handle);
				Pango.EllipsizeMode ret = (Pango.EllipsizeMode) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tool_shell_get_icon_size(IntPtr raw);
		static d_gtk_tool_shell_get_icon_size gtk_tool_shell_get_icon_size = FuncLoader.LoadFunction<d_gtk_tool_shell_get_icon_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tool_shell_get_icon_size"));

		Gtk.IconSize Gtk.IToolShell.IconSize { 
			get {
				int raw_ret = gtk_tool_shell_get_icon_size(Handle);
				Gtk.IconSize ret = (Gtk.IconSize) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tool_shell_get_orientation(IntPtr raw);
		static d_gtk_tool_shell_get_orientation gtk_tool_shell_get_orientation = FuncLoader.LoadFunction<d_gtk_tool_shell_get_orientation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tool_shell_get_orientation"));

		Gtk.Orientation Gtk.IToolShell.Orientation { 
			get {
				int raw_ret = gtk_tool_shell_get_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tool_shell_get_relief_style(IntPtr raw);
		static d_gtk_tool_shell_get_relief_style gtk_tool_shell_get_relief_style = FuncLoader.LoadFunction<d_gtk_tool_shell_get_relief_style>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tool_shell_get_relief_style"));

		Gtk.ReliefStyle Gtk.IToolShell.ReliefStyle { 
			get {
				int raw_ret = gtk_tool_shell_get_relief_style(Handle);
				Gtk.ReliefStyle ret = (Gtk.ReliefStyle) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tool_shell_get_style(IntPtr raw);
		static d_gtk_tool_shell_get_style gtk_tool_shell_get_style = FuncLoader.LoadFunction<d_gtk_tool_shell_get_style>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tool_shell_get_style"));

		Gtk.ToolbarStyle Gtk.IToolShell.Style { 
			get {
				int raw_ret = gtk_tool_shell_get_style(Handle);
				Gtk.ToolbarStyle ret = (Gtk.ToolbarStyle) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate float d_gtk_tool_shell_get_text_alignment(IntPtr raw);
		static d_gtk_tool_shell_get_text_alignment gtk_tool_shell_get_text_alignment = FuncLoader.LoadFunction<d_gtk_tool_shell_get_text_alignment>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tool_shell_get_text_alignment"));

		public float TextAlignment { 
			get {
				float raw_ret = gtk_tool_shell_get_text_alignment(Handle);
				float ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tool_shell_get_text_orientation(IntPtr raw);
		static d_gtk_tool_shell_get_text_orientation gtk_tool_shell_get_text_orientation = FuncLoader.LoadFunction<d_gtk_tool_shell_get_text_orientation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tool_shell_get_text_orientation"));

		public Gtk.Orientation TextOrientation { 
			get {
				int raw_ret = gtk_tool_shell_get_text_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tool_shell_get_text_size_group(IntPtr raw);
		static d_gtk_tool_shell_get_text_size_group gtk_tool_shell_get_text_size_group = FuncLoader.LoadFunction<d_gtk_tool_shell_get_text_size_group>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tool_shell_get_text_size_group"));

		public Gtk.SizeGroup TextSizeGroup { 
			get {
				IntPtr raw_ret = gtk_tool_shell_get_text_size_group(Handle);
				Gtk.SizeGroup ret = GLib.Object.GetObject(raw_ret) as Gtk.SizeGroup;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tool_shell_rebuild_menu(IntPtr raw);
		static d_gtk_tool_shell_rebuild_menu gtk_tool_shell_rebuild_menu = FuncLoader.LoadFunction<d_gtk_tool_shell_rebuild_menu>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tool_shell_rebuild_menu"));

		public void RebuildMenu() {
			gtk_tool_shell_rebuild_menu(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_orientable_get_orientation(IntPtr raw);
		static d_gtk_orientable_get_orientation gtk_orientable_get_orientation = FuncLoader.LoadFunction<d_gtk_orientable_get_orientation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_orientable_get_orientation"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_orientable_set_orientation(IntPtr raw, int orientation);
		static d_gtk_orientable_set_orientation gtk_orientable_set_orientation = FuncLoader.LoadFunction<d_gtk_orientable_set_orientation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_orientable_set_orientation"));

		[GLib.Property ("orientation")]
		public Gtk.Orientation Orientation {
			get  {
				int raw_ret = gtk_orientable_get_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
			set  {
				gtk_orientable_set_orientation(Handle, (int) value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Container.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
