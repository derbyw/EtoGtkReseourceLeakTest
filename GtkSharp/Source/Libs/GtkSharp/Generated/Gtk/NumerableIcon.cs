// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class NumerableIcon : GLib.EmblemedIcon {

		public NumerableIcon (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_numerable_icon_new(IntPtr base_icon);
		static d_gtk_numerable_icon_new gtk_numerable_icon_new = FuncLoader.LoadFunction<d_gtk_numerable_icon_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_numerable_icon_new"));

		public NumerableIcon (GLib.IIcon base_icon) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (NumerableIcon)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			owned = true;
			Raw = gtk_numerable_icon_new(base_icon == null ? IntPtr.Zero : ((base_icon is GLib.Object) ? (base_icon as GLib.Object).Handle : (base_icon as GLib.IconAdapter).Handle));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_numerable_icon_new_with_style_context(IntPtr base_icon, IntPtr context);
		static d_gtk_numerable_icon_new_with_style_context gtk_numerable_icon_new_with_style_context = FuncLoader.LoadFunction<d_gtk_numerable_icon_new_with_style_context>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_numerable_icon_new_with_style_context"));

		public NumerableIcon (GLib.IIcon base_icon, Gtk.StyleContext context) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (NumerableIcon)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			owned = true;
			Raw = gtk_numerable_icon_new_with_style_context(base_icon == null ? IntPtr.Zero : ((base_icon is GLib.Object) ? (base_icon as GLib.Object).Handle : (base_icon as GLib.IconAdapter).Handle), context == null ? IntPtr.Zero : context.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_numerable_icon_get_count(IntPtr raw);
		static d_gtk_numerable_icon_get_count gtk_numerable_icon_get_count = FuncLoader.LoadFunction<d_gtk_numerable_icon_get_count>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_numerable_icon_get_count"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_numerable_icon_set_count(IntPtr raw, int count);
		static d_gtk_numerable_icon_set_count gtk_numerable_icon_set_count = FuncLoader.LoadFunction<d_gtk_numerable_icon_set_count>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_numerable_icon_set_count"));

		[Obsolete]
		[GLib.Property ("count")]
		public int Count {
			get  {
				int raw_ret = gtk_numerable_icon_get_count(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_numerable_icon_set_count(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_numerable_icon_get_label(IntPtr raw);
		static d_gtk_numerable_icon_get_label gtk_numerable_icon_get_label = FuncLoader.LoadFunction<d_gtk_numerable_icon_get_label>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_numerable_icon_get_label"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_numerable_icon_set_label(IntPtr raw, IntPtr label);
		static d_gtk_numerable_icon_set_label gtk_numerable_icon_set_label = FuncLoader.LoadFunction<d_gtk_numerable_icon_set_label>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_numerable_icon_set_label"));

		[Obsolete]
		[GLib.Property ("label")]
		public string Label {
			get  {
				IntPtr raw_ret = gtk_numerable_icon_get_label(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_numerable_icon_set_label(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_numerable_icon_get_style_context(IntPtr raw);
		static d_gtk_numerable_icon_get_style_context gtk_numerable_icon_get_style_context = FuncLoader.LoadFunction<d_gtk_numerable_icon_get_style_context>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_numerable_icon_get_style_context"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_numerable_icon_set_style_context(IntPtr raw, IntPtr style);
		static d_gtk_numerable_icon_set_style_context gtk_numerable_icon_set_style_context = FuncLoader.LoadFunction<d_gtk_numerable_icon_set_style_context>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_numerable_icon_set_style_context"));

		[Obsolete]
		[GLib.Property ("style-context")]
		public Gtk.StyleContext StyleContext {
			get  {
				IntPtr raw_ret = gtk_numerable_icon_get_style_context(Handle);
				Gtk.StyleContext ret = GLib.Object.GetObject(raw_ret) as Gtk.StyleContext;
				return ret;
			}
			set  {
				gtk_numerable_icon_set_style_context(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Property ("background-icon")]
		public GLib.IIcon BackgroundIcon {
			get {
				GLib.Value val = GetProperty ("background-icon");
				GLib.IIcon ret = GLib.IconAdapter.GetObject ((GLib.Object) val);
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("background-icon", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_numerable_icon_get_background_icon_name(IntPtr raw);
		static d_gtk_numerable_icon_get_background_icon_name gtk_numerable_icon_get_background_icon_name = FuncLoader.LoadFunction<d_gtk_numerable_icon_get_background_icon_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_numerable_icon_get_background_icon_name"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_numerable_icon_set_background_icon_name(IntPtr raw, IntPtr icon_name);
		static d_gtk_numerable_icon_set_background_icon_name gtk_numerable_icon_set_background_icon_name = FuncLoader.LoadFunction<d_gtk_numerable_icon_set_background_icon_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_numerable_icon_set_background_icon_name"));

		[Obsolete]
		[GLib.Property ("background-icon-name")]
		public string BackgroundIconName {
			get  {
				IntPtr raw_ret = gtk_numerable_icon_get_background_icon_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_numerable_icon_set_background_icon_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("padding"
							, GLib.EmblemedIcon.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 16 // padding
							, null
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
		delegate IntPtr d_gtk_numerable_icon_get_background_gicon(IntPtr raw);
		static d_gtk_numerable_icon_get_background_gicon gtk_numerable_icon_get_background_gicon = FuncLoader.LoadFunction<d_gtk_numerable_icon_get_background_gicon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_numerable_icon_get_background_gicon"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_numerable_icon_set_background_gicon(IntPtr raw, IntPtr icon);
		static d_gtk_numerable_icon_set_background_gicon gtk_numerable_icon_set_background_gicon = FuncLoader.LoadFunction<d_gtk_numerable_icon_set_background_gicon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_numerable_icon_set_background_gicon"));

		[Obsolete]
		public GLib.IIcon BackgroundGicon { 
			get {
				IntPtr raw_ret = gtk_numerable_icon_get_background_gicon(Handle);
				GLib.IIcon ret = GLib.IconAdapter.GetObject (raw_ret, false);
				return ret;
			}
			set {
				gtk_numerable_icon_set_background_gicon(Handle, value == null ? IntPtr.Zero : ((value is GLib.Object) ? (value as GLib.Object).Handle : (value as GLib.IconAdapter).Handle));
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_numerable_icon_get_type();
		static d_gtk_numerable_icon_get_type gtk_numerable_icon_get_type = FuncLoader.LoadFunction<d_gtk_numerable_icon_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_numerable_icon_get_type"));

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_numerable_icon_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.EmblemedIcon.abi_info.Fields
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
