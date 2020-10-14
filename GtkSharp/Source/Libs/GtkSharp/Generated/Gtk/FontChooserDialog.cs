// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class FontChooserDialog : Gtk.Dialog, Gtk.IFontChooser {

		public FontChooserDialog (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_chooser_dialog_new(IntPtr title, IntPtr parent);
		static d_gtk_font_chooser_dialog_new gtk_font_chooser_dialog_new = FuncLoader.LoadFunction<d_gtk_font_chooser_dialog_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_dialog_new"));

		public FontChooserDialog (string title, Gtk.Window parent) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FontChooserDialog)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("title");
				vals.Add (new GLib.Value (title));
				if (parent != null) {
					names.Add ("parent");
					vals.Add (new GLib.Value (parent));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_title = GLib.Marshaller.StringToPtrGStrdup (title);
			owned = true;
			Raw = gtk_font_chooser_dialog_new(native_title, parent == null ? IntPtr.Zero : parent.Handle);
			GLib.Marshaller.Free (native_title);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Dialog.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, null
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
		delegate IntPtr d_gtk_font_chooser_dialog_get_type();
		static d_gtk_font_chooser_dialog_get_type gtk_font_chooser_dialog_get_type = FuncLoader.LoadFunction<d_gtk_font_chooser_dialog_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_dialog_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_font_chooser_dialog_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_chooser_get_font_face(IntPtr raw);
		static d_gtk_font_chooser_get_font_face gtk_font_chooser_get_font_face = FuncLoader.LoadFunction<d_gtk_font_chooser_get_font_face>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_get_font_face"));

		public Pango.FontFace FontFace { 
			get {
				IntPtr raw_ret = gtk_font_chooser_get_font_face(Handle);
				Pango.FontFace ret = GLib.Object.GetObject(raw_ret) as Pango.FontFace;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_chooser_get_font_family(IntPtr raw);
		static d_gtk_font_chooser_get_font_family gtk_font_chooser_get_font_family = FuncLoader.LoadFunction<d_gtk_font_chooser_get_font_family>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_get_font_family"));

		public Pango.FontFamily FontFamily { 
			get {
				IntPtr raw_ret = gtk_font_chooser_get_font_family(Handle);
				Pango.FontFamily ret = GLib.Object.GetObject(raw_ret) as Pango.FontFamily;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_chooser_get_font_map(IntPtr raw);
		static d_gtk_font_chooser_get_font_map gtk_font_chooser_get_font_map = FuncLoader.LoadFunction<d_gtk_font_chooser_get_font_map>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_get_font_map"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_font_chooser_set_font_map(IntPtr raw, IntPtr fontmap);
		static d_gtk_font_chooser_set_font_map gtk_font_chooser_set_font_map = FuncLoader.LoadFunction<d_gtk_font_chooser_set_font_map>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_set_font_map"));

		public new Pango.FontMap FontMap { 
			get {
				IntPtr raw_ret = gtk_font_chooser_get_font_map(Handle);
				Pango.FontMap ret = GLib.Object.GetObject(raw_ret) as Pango.FontMap;
				return ret;
			}
			set {
				gtk_font_chooser_set_font_map(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_font_chooser_get_font_size(IntPtr raw);
		static d_gtk_font_chooser_get_font_size gtk_font_chooser_get_font_size = FuncLoader.LoadFunction<d_gtk_font_chooser_get_font_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_get_font_size"));

		public int FontSize { 
			get {
				int raw_ret = gtk_font_chooser_get_font_size(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_font_chooser_set_filter_func(IntPtr raw, GtkSharp.FontFilterFuncNative filter, IntPtr user_data, GLib.DestroyNotify destroy);
		static d_gtk_font_chooser_set_filter_func gtk_font_chooser_set_filter_func = FuncLoader.LoadFunction<d_gtk_font_chooser_set_filter_func>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_set_filter_func"));

		public Gtk.FontFilterFunc FilterFunc { 
			set {
				GtkSharp.FontFilterFuncWrapper value_wrapper = new GtkSharp.FontFilterFuncWrapper (value);
				IntPtr user_data;
				GLib.DestroyNotify destroy;
				if (value == null) {
					user_data = IntPtr.Zero;
					destroy = null;
				} else {
					user_data = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_font_chooser_set_filter_func(Handle, value_wrapper.NativeDelegate, user_data, destroy);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_chooser_get_font(IntPtr raw);
		static d_gtk_font_chooser_get_font gtk_font_chooser_get_font = FuncLoader.LoadFunction<d_gtk_font_chooser_get_font>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_get_font"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_font_chooser_set_font(IntPtr raw, IntPtr fontname);
		static d_gtk_font_chooser_set_font gtk_font_chooser_set_font = FuncLoader.LoadFunction<d_gtk_font_chooser_set_font>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_set_font"));

		[GLib.Property ("font")]
		public string Font {
			get  {
				IntPtr raw_ret = gtk_font_chooser_get_font(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_font_chooser_set_font(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_chooser_get_font_desc(IntPtr raw);
		static d_gtk_font_chooser_get_font_desc gtk_font_chooser_get_font_desc = FuncLoader.LoadFunction<d_gtk_font_chooser_get_font_desc>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_get_font_desc"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_font_chooser_set_font_desc(IntPtr raw, IntPtr font_desc);
		static d_gtk_font_chooser_set_font_desc gtk_font_chooser_set_font_desc = FuncLoader.LoadFunction<d_gtk_font_chooser_set_font_desc>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_set_font_desc"));

		[GLib.Property ("font-desc")]
		public Pango.FontDescription FontDesc {
			get  {
				IntPtr raw_ret = gtk_font_chooser_get_font_desc(Handle);
				Pango.FontDescription ret = raw_ret == IntPtr.Zero ? null : (Pango.FontDescription) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.FontDescription), false);
				return ret;
			}
			set  {
				gtk_font_chooser_set_font_desc(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_chooser_get_preview_text(IntPtr raw);
		static d_gtk_font_chooser_get_preview_text gtk_font_chooser_get_preview_text = FuncLoader.LoadFunction<d_gtk_font_chooser_get_preview_text>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_get_preview_text"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_font_chooser_set_preview_text(IntPtr raw, IntPtr text);
		static d_gtk_font_chooser_set_preview_text gtk_font_chooser_set_preview_text = FuncLoader.LoadFunction<d_gtk_font_chooser_set_preview_text>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_set_preview_text"));

		[GLib.Property ("preview-text")]
		public string PreviewText {
			get  {
				IntPtr raw_ret = gtk_font_chooser_get_preview_text(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_font_chooser_set_preview_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_font_chooser_get_show_preview_entry(IntPtr raw);
		static d_gtk_font_chooser_get_show_preview_entry gtk_font_chooser_get_show_preview_entry = FuncLoader.LoadFunction<d_gtk_font_chooser_get_show_preview_entry>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_get_show_preview_entry"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_font_chooser_set_show_preview_entry(IntPtr raw, bool show_preview_entry);
		static d_gtk_font_chooser_set_show_preview_entry gtk_font_chooser_set_show_preview_entry = FuncLoader.LoadFunction<d_gtk_font_chooser_set_show_preview_entry>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_chooser_set_show_preview_entry"));

		[GLib.Property ("show-preview-entry")]
		public bool ShowPreviewEntry {
			get  {
				bool raw_ret = gtk_font_chooser_get_show_preview_entry(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_font_chooser_set_show_preview_entry(Handle, value);
			}
		}

		[GLib.Signal("font-activated")]
		public event Gtk.FontActivatedHandler FontActivated {
			add {
				this.AddSignalHandler ("font-activated", value, typeof (Gtk.FontActivatedArgs));
			}
			remove {
				this.RemoveSignalHandler ("font-activated", value);
			}
		}

		static FontActivatedNativeDelegate FontActivated_cb_delegate;
		static FontActivatedNativeDelegate FontActivatedVMCallback {
			get {
				if (FontActivated_cb_delegate == null)
					FontActivated_cb_delegate = new FontActivatedNativeDelegate (FontActivated_cb);
				return FontActivated_cb_delegate;
			}
		}

		static void OverrideFontActivated (GLib.GType gtype)
		{
			OverrideFontActivated (gtype, FontActivatedVMCallback);
		}

		static void OverrideFontActivated (GLib.GType gtype, FontActivatedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "font-activated", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FontActivatedNativeDelegate (IntPtr inst, IntPtr fontname);

		static void FontActivated_cb (IntPtr inst, IntPtr fontname)
		{
			try {
				Gtk.FontChooserDialog __obj = GLib.Object.GetObject (inst, false) as Gtk.FontChooserDialog;
				__obj.OnFontActivated (GLib.Marshaller.Utf8PtrToString (fontname));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.FontChooserDialog), ConnectionMethod="OverrideFontActivated")]
		protected virtual void OnFontActivated (string fontname)
		{
			InternalFontActivated (fontname);
		}

		private void InternalFontActivated (string fontname)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (fontname);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Dialog.abi_info.Fields
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
