// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class AppChooserButton : Gtk.ComboBox, Gtk.IAppChooser {

		public AppChooserButton (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_app_chooser_button_new(IntPtr content_type);
		static d_gtk_app_chooser_button_new gtk_app_chooser_button_new = FuncLoader.LoadFunction<d_gtk_app_chooser_button_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_app_chooser_button_new"));

		public AppChooserButton (string content_type) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (AppChooserButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_content_type = GLib.Marshaller.StringToPtrGStrdup (content_type);
			owned = true;
			Raw = gtk_app_chooser_button_new(native_content_type);
			GLib.Marshaller.Free (native_content_type);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_app_chooser_button_get_show_dialog_item(IntPtr raw);
		static d_gtk_app_chooser_button_get_show_dialog_item gtk_app_chooser_button_get_show_dialog_item = FuncLoader.LoadFunction<d_gtk_app_chooser_button_get_show_dialog_item>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_app_chooser_button_get_show_dialog_item"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_app_chooser_button_set_show_dialog_item(IntPtr raw, bool setting);
		static d_gtk_app_chooser_button_set_show_dialog_item gtk_app_chooser_button_set_show_dialog_item = FuncLoader.LoadFunction<d_gtk_app_chooser_button_set_show_dialog_item>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_app_chooser_button_set_show_dialog_item"));

		[GLib.Property ("show-dialog-item")]
		public bool ShowDialogItem {
			get  {
				bool raw_ret = gtk_app_chooser_button_get_show_dialog_item(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_app_chooser_button_set_show_dialog_item(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_app_chooser_button_get_show_default_item(IntPtr raw);
		static d_gtk_app_chooser_button_get_show_default_item gtk_app_chooser_button_get_show_default_item = FuncLoader.LoadFunction<d_gtk_app_chooser_button_get_show_default_item>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_app_chooser_button_get_show_default_item"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_app_chooser_button_set_show_default_item(IntPtr raw, bool setting);
		static d_gtk_app_chooser_button_set_show_default_item gtk_app_chooser_button_set_show_default_item = FuncLoader.LoadFunction<d_gtk_app_chooser_button_set_show_default_item>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_app_chooser_button_set_show_default_item"));

		[GLib.Property ("show-default-item")]
		public bool ShowDefaultItem {
			get  {
				bool raw_ret = gtk_app_chooser_button_get_show_default_item(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_app_chooser_button_set_show_default_item(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_app_chooser_button_get_heading(IntPtr raw);
		static d_gtk_app_chooser_button_get_heading gtk_app_chooser_button_get_heading = FuncLoader.LoadFunction<d_gtk_app_chooser_button_get_heading>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_app_chooser_button_get_heading"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_app_chooser_button_set_heading(IntPtr raw, IntPtr heading);
		static d_gtk_app_chooser_button_set_heading gtk_app_chooser_button_set_heading = FuncLoader.LoadFunction<d_gtk_app_chooser_button_set_heading>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_app_chooser_button_set_heading"));

		[GLib.Property ("heading")]
		public string Heading {
			get  {
				IntPtr raw_ret = gtk_app_chooser_button_get_heading(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_app_chooser_button_set_heading(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[GLib.Signal("custom-item-activated")]
		public event Gtk.CustomItemActivatedHandler CustomItemActivated {
			add {
				this.AddSignalHandler ("custom-item-activated", value, typeof (Gtk.CustomItemActivatedArgs));
			}
			remove {
				this.RemoveSignalHandler ("custom-item-activated", value);
			}
		}

		static CustomItemActivatedNativeDelegate CustomItemActivated_cb_delegate;
		static CustomItemActivatedNativeDelegate CustomItemActivatedVMCallback {
			get {
				if (CustomItemActivated_cb_delegate == null)
					CustomItemActivated_cb_delegate = new CustomItemActivatedNativeDelegate (CustomItemActivated_cb);
				return CustomItemActivated_cb_delegate;
			}
		}

		static void OverrideCustomItemActivated (GLib.GType gtype)
		{
			OverrideCustomItemActivated (gtype, CustomItemActivatedVMCallback);
		}

		static void OverrideCustomItemActivated (GLib.GType gtype, CustomItemActivatedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("custom_item_activated"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CustomItemActivatedNativeDelegate (IntPtr inst, IntPtr item_name);

		static void CustomItemActivated_cb (IntPtr inst, IntPtr item_name)
		{
			try {
				AppChooserButton __obj = GLib.Object.GetObject (inst, false) as AppChooserButton;
				__obj.OnCustomItemActivated (GLib.Marshaller.Utf8PtrToString (item_name));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.AppChooserButton), ConnectionMethod="OverrideCustomItemActivated")]
		protected virtual void OnCustomItemActivated (string item_name)
		{
			InternalCustomItemActivated (item_name);
		}

		private void InternalCustomItemActivated (string item_name)
		{
			CustomItemActivatedNativeDelegate unmanaged = class_abi.BaseOverride<CustomItemActivatedNativeDelegate>(this.LookupGType(), "custom_item_activated");
			if (unmanaged == null) return;

			IntPtr native_item_name = GLib.Marshaller.StringToPtrGStrdup (item_name);
			unmanaged (this.Handle, native_item_name);
			GLib.Marshaller.Free (native_item_name);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("custom_item_activated"
							, Gtk.ComboBox.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // custom_item_activated
							, null
							, "padding"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("padding"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 16 // padding
							, "custom_item_activated"
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
		delegate void d_gtk_app_chooser_button_append_custom_item(IntPtr raw, IntPtr name, IntPtr label, IntPtr icon);
		static d_gtk_app_chooser_button_append_custom_item gtk_app_chooser_button_append_custom_item = FuncLoader.LoadFunction<d_gtk_app_chooser_button_append_custom_item>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_app_chooser_button_append_custom_item"));

		public void AppendCustomItem(string name, string label, GLib.IIcon icon) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			gtk_app_chooser_button_append_custom_item(Handle, native_name, native_label, icon == null ? IntPtr.Zero : ((icon is GLib.Object) ? (icon as GLib.Object).Handle : (icon as GLib.IconAdapter).Handle));
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_label);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_app_chooser_button_append_separator(IntPtr raw);
		static d_gtk_app_chooser_button_append_separator gtk_app_chooser_button_append_separator = FuncLoader.LoadFunction<d_gtk_app_chooser_button_append_separator>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_app_chooser_button_append_separator"));

		public void AppendSeparator() {
			gtk_app_chooser_button_append_separator(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_app_chooser_button_get_type();
		static d_gtk_app_chooser_button_get_type gtk_app_chooser_button_get_type = FuncLoader.LoadFunction<d_gtk_app_chooser_button_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_app_chooser_button_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_app_chooser_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_app_chooser_button_set_active_custom_item(IntPtr raw, IntPtr name);
		static d_gtk_app_chooser_button_set_active_custom_item gtk_app_chooser_button_set_active_custom_item = FuncLoader.LoadFunction<d_gtk_app_chooser_button_set_active_custom_item>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_app_chooser_button_set_active_custom_item"));

		public string ActiveCustomItem { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_app_chooser_button_set_active_custom_item(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_app_chooser_get_app_info(IntPtr raw);
		static d_gtk_app_chooser_get_app_info gtk_app_chooser_get_app_info = FuncLoader.LoadFunction<d_gtk_app_chooser_get_app_info>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_app_chooser_get_app_info"));

		public GLib.IAppInfo AppInfo { 
			get {
				IntPtr raw_ret = gtk_app_chooser_get_app_info(Handle);
				GLib.IAppInfo ret = GLib.AppInfoAdapter.GetObject (raw_ret, false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_app_chooser_get_content_type(IntPtr raw);
		static d_gtk_app_chooser_get_content_type gtk_app_chooser_get_content_type = FuncLoader.LoadFunction<d_gtk_app_chooser_get_content_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_app_chooser_get_content_type"));

		public string ContentType { 
			get {
				IntPtr raw_ret = gtk_app_chooser_get_content_type(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_app_chooser_refresh(IntPtr raw);
		static d_gtk_app_chooser_refresh gtk_app_chooser_refresh = FuncLoader.LoadFunction<d_gtk_app_chooser_refresh>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_app_chooser_refresh"));

		public void Refresh() {
			gtk_app_chooser_refresh(Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.ComboBox.abi_info.Fields
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
