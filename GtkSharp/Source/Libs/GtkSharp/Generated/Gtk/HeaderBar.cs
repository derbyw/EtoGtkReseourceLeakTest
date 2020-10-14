// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class HeaderBar : Gtk.Container {

		public HeaderBar (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_header_bar_new();
		static d_gtk_header_bar_new gtk_header_bar_new = FuncLoader.LoadFunction<d_gtk_header_bar_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_new"));

		public HeaderBar () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (HeaderBar)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			owned = true;
			Raw = gtk_header_bar_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_header_bar_get_title(IntPtr raw);
		static d_gtk_header_bar_get_title gtk_header_bar_get_title = FuncLoader.LoadFunction<d_gtk_header_bar_get_title>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_get_title"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_header_bar_set_title(IntPtr raw, IntPtr title);
		static d_gtk_header_bar_set_title gtk_header_bar_set_title = FuncLoader.LoadFunction<d_gtk_header_bar_set_title>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_set_title"));

		[GLib.Property ("title")]
		public string Title {
			get  {
				IntPtr raw_ret = gtk_header_bar_get_title(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_header_bar_set_title(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_header_bar_get_subtitle(IntPtr raw);
		static d_gtk_header_bar_get_subtitle gtk_header_bar_get_subtitle = FuncLoader.LoadFunction<d_gtk_header_bar_get_subtitle>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_get_subtitle"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_header_bar_set_subtitle(IntPtr raw, IntPtr subtitle);
		static d_gtk_header_bar_set_subtitle gtk_header_bar_set_subtitle = FuncLoader.LoadFunction<d_gtk_header_bar_set_subtitle>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_set_subtitle"));

		[GLib.Property ("subtitle")]
		public string Subtitle {
			get  {
				IntPtr raw_ret = gtk_header_bar_get_subtitle(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_header_bar_set_subtitle(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_header_bar_get_custom_title(IntPtr raw);
		static d_gtk_header_bar_get_custom_title gtk_header_bar_get_custom_title = FuncLoader.LoadFunction<d_gtk_header_bar_get_custom_title>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_get_custom_title"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_header_bar_set_custom_title(IntPtr raw, IntPtr title_widget);
		static d_gtk_header_bar_set_custom_title gtk_header_bar_set_custom_title = FuncLoader.LoadFunction<d_gtk_header_bar_set_custom_title>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_set_custom_title"));

		[GLib.Property ("custom-title")]
		public Gtk.Widget CustomTitle {
			get  {
				IntPtr raw_ret = gtk_header_bar_get_custom_title(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_header_bar_set_custom_title(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Property ("spacing")]
		public int Spacing {
			get {
				GLib.Value val = GetProperty ("spacing");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("spacing", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_header_bar_get_show_close_button(IntPtr raw);
		static d_gtk_header_bar_get_show_close_button gtk_header_bar_get_show_close_button = FuncLoader.LoadFunction<d_gtk_header_bar_get_show_close_button>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_get_show_close_button"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_header_bar_set_show_close_button(IntPtr raw, bool setting);
		static d_gtk_header_bar_set_show_close_button gtk_header_bar_set_show_close_button = FuncLoader.LoadFunction<d_gtk_header_bar_set_show_close_button>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_set_show_close_button"));

		[GLib.Property ("show-close-button")]
		public bool ShowCloseButton {
			get  {
				bool raw_ret = gtk_header_bar_get_show_close_button(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_header_bar_set_show_close_button(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_header_bar_get_decoration_layout(IntPtr raw);
		static d_gtk_header_bar_get_decoration_layout gtk_header_bar_get_decoration_layout = FuncLoader.LoadFunction<d_gtk_header_bar_get_decoration_layout>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_get_decoration_layout"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_header_bar_set_decoration_layout(IntPtr raw, IntPtr layout);
		static d_gtk_header_bar_set_decoration_layout gtk_header_bar_set_decoration_layout = FuncLoader.LoadFunction<d_gtk_header_bar_set_decoration_layout>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_set_decoration_layout"));

		[GLib.Property ("decoration-layout")]
		public string DecorationLayout {
			get  {
				IntPtr raw_ret = gtk_header_bar_get_decoration_layout(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_header_bar_set_decoration_layout(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[GLib.Property ("decoration-layout-set")]
		public bool DecorationLayoutSet {
			get {
				GLib.Value val = GetProperty ("decoration-layout-set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("decoration-layout-set", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_header_bar_get_has_subtitle(IntPtr raw);
		static d_gtk_header_bar_get_has_subtitle gtk_header_bar_get_has_subtitle = FuncLoader.LoadFunction<d_gtk_header_bar_get_has_subtitle>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_get_has_subtitle"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_header_bar_set_has_subtitle(IntPtr raw, bool setting);
		static d_gtk_header_bar_set_has_subtitle gtk_header_bar_set_has_subtitle = FuncLoader.LoadFunction<d_gtk_header_bar_set_has_subtitle>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_set_has_subtitle"));

		[GLib.Property ("has-subtitle")]
		public bool HasSubtitle {
			get  {
				bool raw_ret = gtk_header_bar_get_has_subtitle(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_header_bar_set_has_subtitle(Handle, value);
			}
		}

		public class HeaderBarChild : Gtk.Container.ContainerChild {
			protected internal HeaderBarChild (Gtk.Container parent, Gtk.Widget child) : base (parent, child) {}

			[Gtk.ChildProperty ("pack-type")]
			public Gtk.PackType PackType {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "pack-type");
					Gtk.PackType ret = (Gtk.PackType) (Enum) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value((Enum) value);
					parent.ChildSetProperty(child, "pack-type", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("position")]
			public int Position {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "position");
					int ret = (int) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "position", val);
					val.Dispose ();
				}
			}

		}

		public override Gtk.Container.ContainerChild this [Gtk.Widget child] {
			get {
				return new HeaderBarChild (this, child);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Container.class_abi.Fields
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
		delegate IntPtr d_gtk_header_bar_get_type();
		static d_gtk_header_bar_get_type gtk_header_bar_get_type = FuncLoader.LoadFunction<d_gtk_header_bar_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_header_bar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_header_bar_pack_end(IntPtr raw, IntPtr child);
		static d_gtk_header_bar_pack_end gtk_header_bar_pack_end = FuncLoader.LoadFunction<d_gtk_header_bar_pack_end>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_pack_end"));

		public void PackEnd(Gtk.Widget child) {
			gtk_header_bar_pack_end(Handle, child == null ? IntPtr.Zero : child.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_header_bar_pack_start(IntPtr raw, IntPtr child);
		static d_gtk_header_bar_pack_start gtk_header_bar_pack_start = FuncLoader.LoadFunction<d_gtk_header_bar_pack_start>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_header_bar_pack_start"));

		public void PackStart(Gtk.Widget child) {
			gtk_header_bar_pack_start(Handle, child == null ? IntPtr.Zero : child.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gtk.Container.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}