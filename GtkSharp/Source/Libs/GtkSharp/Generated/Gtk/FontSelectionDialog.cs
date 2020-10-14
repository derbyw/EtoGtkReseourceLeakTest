// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class FontSelectionDialog : Gtk.Dialog {

		public FontSelectionDialog (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_dialog_new(IntPtr title);
		static d_gtk_font_selection_dialog_new gtk_font_selection_dialog_new = FuncLoader.LoadFunction<d_gtk_font_selection_dialog_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_dialog_new"));

		public FontSelectionDialog (string title) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FontSelectionDialog)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("title");
				vals.Add (new GLib.Value (title));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_title = GLib.Marshaller.StringToPtrGStrdup (title);
			owned = true;
			Raw = gtk_font_selection_dialog_new(native_title);
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
		delegate IntPtr d_gtk_font_selection_dialog_get_cancel_button(IntPtr raw);
		static d_gtk_font_selection_dialog_get_cancel_button gtk_font_selection_dialog_get_cancel_button = FuncLoader.LoadFunction<d_gtk_font_selection_dialog_get_cancel_button>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_dialog_get_cancel_button"));

		[Obsolete]
		public Gtk.Button CancelButton { 
			get {
				IntPtr raw_ret = gtk_font_selection_dialog_get_cancel_button(Handle);
				Gtk.Button ret = GLib.Object.GetObject(raw_ret) as Gtk.Button;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_dialog_get_font_name(IntPtr raw);
		static d_gtk_font_selection_dialog_get_font_name gtk_font_selection_dialog_get_font_name = FuncLoader.LoadFunction<d_gtk_font_selection_dialog_get_font_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_dialog_get_font_name"));

		[Obsolete]
		public string FontName { 
			get {
				IntPtr raw_ret = gtk_font_selection_dialog_get_font_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_dialog_get_font_selection(IntPtr raw);
		static d_gtk_font_selection_dialog_get_font_selection gtk_font_selection_dialog_get_font_selection = FuncLoader.LoadFunction<d_gtk_font_selection_dialog_get_font_selection>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_dialog_get_font_selection"));

		[Obsolete]
		public Gtk.Widget FontSelection { 
			get {
				IntPtr raw_ret = gtk_font_selection_dialog_get_font_selection(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_dialog_get_ok_button(IntPtr raw);
		static d_gtk_font_selection_dialog_get_ok_button gtk_font_selection_dialog_get_ok_button = FuncLoader.LoadFunction<d_gtk_font_selection_dialog_get_ok_button>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_dialog_get_ok_button"));

		[Obsolete]
		public Gtk.Button OkButton { 
			get {
				IntPtr raw_ret = gtk_font_selection_dialog_get_ok_button(Handle);
				Gtk.Button ret = GLib.Object.GetObject(raw_ret) as Gtk.Button;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_dialog_get_preview_text(IntPtr raw);
		static d_gtk_font_selection_dialog_get_preview_text gtk_font_selection_dialog_get_preview_text = FuncLoader.LoadFunction<d_gtk_font_selection_dialog_get_preview_text>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_dialog_get_preview_text"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_font_selection_dialog_set_preview_text(IntPtr raw, IntPtr text);
		static d_gtk_font_selection_dialog_set_preview_text gtk_font_selection_dialog_set_preview_text = FuncLoader.LoadFunction<d_gtk_font_selection_dialog_set_preview_text>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_dialog_set_preview_text"));

		[Obsolete]
		public string PreviewText { 
			get {
				IntPtr raw_ret = gtk_font_selection_dialog_get_preview_text(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_font_selection_dialog_set_preview_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_dialog_get_type();
		static d_gtk_font_selection_dialog_get_type gtk_font_selection_dialog_get_type = FuncLoader.LoadFunction<d_gtk_font_selection_dialog_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_dialog_get_type"));

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_font_selection_dialog_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_font_selection_dialog_set_font_name(IntPtr raw, IntPtr fontname);
		static d_gtk_font_selection_dialog_set_font_name gtk_font_selection_dialog_set_font_name = FuncLoader.LoadFunction<d_gtk_font_selection_dialog_set_font_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_dialog_set_font_name"));

		[Obsolete]
		public bool SetFontName(string fontname) {
			IntPtr native_fontname = GLib.Marshaller.StringToPtrGStrdup (fontname);
			bool raw_ret = gtk_font_selection_dialog_set_font_name(Handle, native_fontname);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fontname);
			return ret;
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
