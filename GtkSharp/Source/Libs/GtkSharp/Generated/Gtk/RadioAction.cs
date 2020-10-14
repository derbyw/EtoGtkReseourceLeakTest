// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class RadioAction : Gtk.ToggleAction {

		public RadioAction (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_radio_action_new(IntPtr name, IntPtr label, IntPtr tooltip, IntPtr stock_id, int value);
		static d_gtk_radio_action_new gtk_radio_action_new = FuncLoader.LoadFunction<d_gtk_radio_action_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_radio_action_new"));

		public RadioAction (string name, string label, string tooltip, string stock_id, int value) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RadioAction)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("name");
				vals.Add (new GLib.Value (name));
				names.Add ("label");
				vals.Add (new GLib.Value (label));
				names.Add ("tooltip");
				vals.Add (new GLib.Value (tooltip));
				names.Add ("stock_id");
				vals.Add (new GLib.Value (stock_id));
				names.Add ("value");
				vals.Add (new GLib.Value (value));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			IntPtr native_tooltip = GLib.Marshaller.StringToPtrGStrdup (tooltip);
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			owned = true;
			Raw = gtk_radio_action_new(native_name, native_label, native_tooltip, native_stock_id, value);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_label);
			GLib.Marshaller.Free (native_tooltip);
			GLib.Marshaller.Free (native_stock_id);
		}

		[GLib.Property ("value")]
		public int Value {
			get {
				GLib.Value val = GetProperty ("value");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("value", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_radio_action_get_current_value(IntPtr raw);
		static d_gtk_radio_action_get_current_value gtk_radio_action_get_current_value = FuncLoader.LoadFunction<d_gtk_radio_action_get_current_value>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_radio_action_get_current_value"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_radio_action_set_current_value(IntPtr raw, int current_value);
		static d_gtk_radio_action_set_current_value gtk_radio_action_set_current_value = FuncLoader.LoadFunction<d_gtk_radio_action_set_current_value>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_radio_action_set_current_value"));

		[Obsolete]
		[GLib.Property ("current-value")]
		public int CurrentValue {
			get  {
				int raw_ret = gtk_radio_action_get_current_value(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_radio_action_set_current_value(Handle, value);
			}
		}

		[GLib.Signal("changed")]
		public event Gtk.ChangedHandler Changed {
			add {
				this.AddSignalHandler ("changed", value, typeof (Gtk.ChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("changed", value);
			}
		}

		static ChangedNativeDelegate Changed_cb_delegate;
		static ChangedNativeDelegate ChangedVMCallback {
			get {
				if (Changed_cb_delegate == null)
					Changed_cb_delegate = new ChangedNativeDelegate (Changed_cb);
				return Changed_cb_delegate;
			}
		}

		static void OverrideChanged (GLib.GType gtype)
		{
			OverrideChanged (gtype, ChangedVMCallback);
		}

		static void OverrideChanged (GLib.GType gtype, ChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedNativeDelegate (IntPtr inst, IntPtr current);

		static void Changed_cb (IntPtr inst, IntPtr current)
		{
			try {
				RadioAction __obj = GLib.Object.GetObject (inst, false) as RadioAction;
				__obj.OnChanged (GLib.Object.GetObject(current) as Gtk.RadioAction);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.RadioAction), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged (Gtk.RadioAction current)
		{
			InternalChanged (current);
		}

		private void InternalChanged (Gtk.RadioAction current)
		{
			ChangedNativeDelegate unmanaged = class_abi.BaseOverride<ChangedNativeDelegate>(this.LookupGType(), "changed");
			if (unmanaged == null) return;

			unmanaged (this.Handle, current == null ? IntPtr.Zero : current.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("changed"
							, Gtk.ToggleAction.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // changed
							, null
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "changed"
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
		delegate IntPtr d_gtk_radio_action_get_type();
		static d_gtk_radio_action_get_type gtk_radio_action_get_type = FuncLoader.LoadFunction<d_gtk_radio_action_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_radio_action_get_type"));

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_radio_action_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_radio_action_join_group(IntPtr raw, IntPtr group_source);
		static d_gtk_radio_action_join_group gtk_radio_action_join_group = FuncLoader.LoadFunction<d_gtk_radio_action_join_group>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_radio_action_join_group"));

		[Obsolete]
		public void JoinGroup(Gtk.RadioAction group_source) {
			gtk_radio_action_join_group(Handle, group_source == null ? IntPtr.Zero : group_source.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("private_data"
							, Gtk.ToggleAction.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // private_data
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
