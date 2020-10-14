// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class ListBoxRow : Gtk.Bin {

		public ListBoxRow (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_list_box_row_new();
		static d_gtk_list_box_row_new gtk_list_box_row_new = FuncLoader.LoadFunction<d_gtk_list_box_row_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_list_box_row_new"));

		public ListBoxRow () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ListBoxRow)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			owned = true;
			Raw = gtk_list_box_row_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_list_box_row_get_activatable(IntPtr raw);
		static d_gtk_list_box_row_get_activatable gtk_list_box_row_get_activatable = FuncLoader.LoadFunction<d_gtk_list_box_row_get_activatable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_list_box_row_get_activatable"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_list_box_row_set_activatable(IntPtr raw, bool activatable);
		static d_gtk_list_box_row_set_activatable gtk_list_box_row_set_activatable = FuncLoader.LoadFunction<d_gtk_list_box_row_set_activatable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_list_box_row_set_activatable"));

		[GLib.Property ("activatable")]
		public bool Activatable {
			get  {
				bool raw_ret = gtk_list_box_row_get_activatable(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_list_box_row_set_activatable(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_list_box_row_get_selectable(IntPtr raw);
		static d_gtk_list_box_row_get_selectable gtk_list_box_row_get_selectable = FuncLoader.LoadFunction<d_gtk_list_box_row_get_selectable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_list_box_row_get_selectable"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_list_box_row_set_selectable(IntPtr raw, bool selectable);
		static d_gtk_list_box_row_set_selectable gtk_list_box_row_set_selectable = FuncLoader.LoadFunction<d_gtk_list_box_row_set_selectable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_list_box_row_set_selectable"));

		[GLib.Property ("selectable")]
		public bool Selectable {
			get  {
				bool raw_ret = gtk_list_box_row_get_selectable(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_list_box_row_set_selectable(Handle, value);
			}
		}

		[GLib.Signal("activate")]
		public event System.EventHandler Activate {
			add {
				this.AddSignalHandler ("activate", value);
			}
			remove {
				this.RemoveSignalHandler ("activate", value);
			}
		}

		static ActivateNativeDelegate Activate_cb_delegate;
		static ActivateNativeDelegate ActivateVMCallback {
			get {
				if (Activate_cb_delegate == null)
					Activate_cb_delegate = new ActivateNativeDelegate (Activate_cb);
				return Activate_cb_delegate;
			}
		}

		static void OverrideActivate (GLib.GType gtype)
		{
			OverrideActivate (gtype, ActivateVMCallback);
		}

		static void OverrideActivate (GLib.GType gtype, ActivateNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("activate"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActivateNativeDelegate (IntPtr inst);

		static void Activate_cb (IntPtr inst)
		{
			try {
				ListBoxRow __obj = GLib.Object.GetObject (inst, false) as ListBoxRow;
				__obj.OnActivate ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ListBoxRow), ConnectionMethod="OverrideActivate")]
		protected virtual void OnActivate ()
		{
			InternalActivate ();
		}

		private void InternalActivate ()
		{
			ActivateNativeDelegate unmanaged = class_abi.BaseOverride<ActivateNativeDelegate>(this.LookupGType(), "activate");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("activate"
							, Gtk.Bin.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // activate
							, null
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "activate"
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
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
		delegate void d_gtk_list_box_row_changed(IntPtr raw);
		static d_gtk_list_box_row_changed gtk_list_box_row_changed = FuncLoader.LoadFunction<d_gtk_list_box_row_changed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_list_box_row_changed"));

		public void Changed() {
			gtk_list_box_row_changed(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_list_box_row_get_header(IntPtr raw);
		static d_gtk_list_box_row_get_header gtk_list_box_row_get_header = FuncLoader.LoadFunction<d_gtk_list_box_row_get_header>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_list_box_row_get_header"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_list_box_row_set_header(IntPtr raw, IntPtr header);
		static d_gtk_list_box_row_set_header gtk_list_box_row_set_header = FuncLoader.LoadFunction<d_gtk_list_box_row_set_header>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_list_box_row_set_header"));

		public Gtk.Widget Header { 
			get {
				IntPtr raw_ret = gtk_list_box_row_get_header(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set {
				gtk_list_box_row_set_header(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_list_box_row_get_index(IntPtr raw);
		static d_gtk_list_box_row_get_index gtk_list_box_row_get_index = FuncLoader.LoadFunction<d_gtk_list_box_row_get_index>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_list_box_row_get_index"));

		public int Index { 
			get {
				int raw_ret = gtk_list_box_row_get_index(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_list_box_row_get_type();
		static d_gtk_list_box_row_get_type gtk_list_box_row_get_type = FuncLoader.LoadFunction<d_gtk_list_box_row_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_list_box_row_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_list_box_row_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_list_box_row_is_selected(IntPtr raw);
		static d_gtk_list_box_row_is_selected gtk_list_box_row_is_selected = FuncLoader.LoadFunction<d_gtk_list_box_row_is_selected>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_list_box_row_is_selected"));

		public bool IsSelected { 
			get {
				bool raw_ret = gtk_list_box_row_is_selected(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gtk.Bin.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
