// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class ToggleButton : Gtk.Button {

		public ToggleButton (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_toggle_button_new();
		static d_gtk_toggle_button_new gtk_toggle_button_new = FuncLoader.LoadFunction<d_gtk_toggle_button_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_button_new"));

		public ToggleButton () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ToggleButton)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			owned = true;
			Raw = gtk_toggle_button_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_toggle_button_new_with_label(IntPtr label);
		static d_gtk_toggle_button_new_with_label gtk_toggle_button_new_with_label = FuncLoader.LoadFunction<d_gtk_toggle_button_new_with_label>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_button_new_with_label"));

		public static new ToggleButton NewWithLabel(string label)
		{
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			ToggleButton result = new ToggleButton (gtk_toggle_button_new_with_label(native_label));
			GLib.Marshaller.Free (native_label);
			return result;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_toggle_button_new_with_mnemonic(IntPtr label);
		static d_gtk_toggle_button_new_with_mnemonic gtk_toggle_button_new_with_mnemonic = FuncLoader.LoadFunction<d_gtk_toggle_button_new_with_mnemonic>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_button_new_with_mnemonic"));

		public ToggleButton (string label) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ToggleButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("label");
				vals.Add (new GLib.Value (label));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			owned = true;
			Raw = gtk_toggle_button_new_with_mnemonic(native_label);
			GLib.Marshaller.Free (native_label);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_toggle_button_get_active(IntPtr raw);
		static d_gtk_toggle_button_get_active gtk_toggle_button_get_active = FuncLoader.LoadFunction<d_gtk_toggle_button_get_active>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_button_get_active"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_toggle_button_set_active(IntPtr raw, bool is_active);
		static d_gtk_toggle_button_set_active gtk_toggle_button_set_active = FuncLoader.LoadFunction<d_gtk_toggle_button_set_active>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_button_set_active"));

		[GLib.Property ("active")]
		public bool Active {
			get  {
				bool raw_ret = gtk_toggle_button_get_active(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_toggle_button_set_active(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_toggle_button_get_inconsistent(IntPtr raw);
		static d_gtk_toggle_button_get_inconsistent gtk_toggle_button_get_inconsistent = FuncLoader.LoadFunction<d_gtk_toggle_button_get_inconsistent>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_button_get_inconsistent"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_toggle_button_set_inconsistent(IntPtr raw, bool setting);
		static d_gtk_toggle_button_set_inconsistent gtk_toggle_button_set_inconsistent = FuncLoader.LoadFunction<d_gtk_toggle_button_set_inconsistent>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_button_set_inconsistent"));

		[GLib.Property ("inconsistent")]
		public bool Inconsistent {
			get  {
				bool raw_ret = gtk_toggle_button_get_inconsistent(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_toggle_button_set_inconsistent(Handle, value);
			}
		}

		[GLib.Property ("draw-indicator")]
		public bool DrawIndicator {
			get {
				GLib.Value val = GetProperty ("draw-indicator");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("draw-indicator", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("toggled")]
		public event System.EventHandler Toggled {
			add {
				this.AddSignalHandler ("toggled", value);
			}
			remove {
				this.RemoveSignalHandler ("toggled", value);
			}
		}

		static ToggledNativeDelegate Toggled_cb_delegate;
		static ToggledNativeDelegate ToggledVMCallback {
			get {
				if (Toggled_cb_delegate == null)
					Toggled_cb_delegate = new ToggledNativeDelegate (Toggled_cb);
				return Toggled_cb_delegate;
			}
		}

		static void OverrideToggled (GLib.GType gtype)
		{
			OverrideToggled (gtype, ToggledVMCallback);
		}

		static void OverrideToggled (GLib.GType gtype, ToggledNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("toggled"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ToggledNativeDelegate (IntPtr inst);

		static void Toggled_cb (IntPtr inst)
		{
			try {
				ToggleButton __obj = GLib.Object.GetObject (inst, false) as ToggleButton;
				__obj.OnToggled ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ToggleButton), ConnectionMethod="OverrideToggled")]
		protected virtual void OnToggled ()
		{
			InternalToggled ();
		}

		private void InternalToggled ()
		{
			ToggledNativeDelegate unmanaged = class_abi.BaseOverride<ToggledNativeDelegate>(this.LookupGType(), "toggled");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("toggled"
							, Gtk.Button.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // toggled
							, null
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "toggled"
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
		delegate bool d_gtk_toggle_button_get_mode(IntPtr raw);
		static d_gtk_toggle_button_get_mode gtk_toggle_button_get_mode = FuncLoader.LoadFunction<d_gtk_toggle_button_get_mode>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_button_get_mode"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_toggle_button_set_mode(IntPtr raw, bool draw_indicator);
		static d_gtk_toggle_button_set_mode gtk_toggle_button_set_mode = FuncLoader.LoadFunction<d_gtk_toggle_button_set_mode>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_button_set_mode"));

		public bool Mode { 
			get {
				bool raw_ret = gtk_toggle_button_get_mode(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_toggle_button_set_mode(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_toggle_button_get_type();
		static d_gtk_toggle_button_get_type gtk_toggle_button_get_type = FuncLoader.LoadFunction<d_gtk_toggle_button_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_button_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_toggle_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_toggle_button_toggled(IntPtr raw);
		static d_gtk_toggle_button_toggled gtk_toggle_button_toggled = FuncLoader.LoadFunction<d_gtk_toggle_button_toggled>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_button_toggled"));

		public void Toggle() {
			gtk_toggle_button_toggled(Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Button.abi_info.Fields
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
