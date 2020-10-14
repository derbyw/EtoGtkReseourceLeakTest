// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class StyleProperties : GLib.Object, Gtk.IStyleProvider {

		public StyleProperties (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_properties_new();
		static d_gtk_style_properties_new gtk_style_properties_new = FuncLoader.LoadFunction<d_gtk_style_properties_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_properties_new"));

		public StyleProperties () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (StyleProperties)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			owned = true;
			Raw = gtk_style_properties_new();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, GLib.Object.class_abi.Fields
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
		delegate void d_gtk_style_properties_clear(IntPtr raw);
		static d_gtk_style_properties_clear gtk_style_properties_clear = FuncLoader.LoadFunction<d_gtk_style_properties_clear>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_properties_clear"));

		[Obsolete]
		public void Clear() {
			gtk_style_properties_clear(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_style_properties_get_property(IntPtr raw, IntPtr property, int state, IntPtr value);
		static d_gtk_style_properties_get_property gtk_style_properties_get_property = FuncLoader.LoadFunction<d_gtk_style_properties_get_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_properties_get_property"));

		[Obsolete]
		public bool GetProperty(string property, Gtk.StateFlags state, GLib.Value value) {
			IntPtr native_property = GLib.Marshaller.StringToPtrGStrdup (property);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			bool raw_ret = gtk_style_properties_get_property(Handle, native_property, (int) state, native_value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_property);
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_properties_get_type();
		static d_gtk_style_properties_get_type gtk_style_properties_get_type = FuncLoader.LoadFunction<d_gtk_style_properties_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_properties_get_type"));

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_style_properties_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_properties_get_valist(IntPtr raw, int state, IntPtr args);
		static d_gtk_style_properties_get_valist gtk_style_properties_get_valist = FuncLoader.LoadFunction<d_gtk_style_properties_get_valist>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_properties_get_valist"));

		[Obsolete]
		public void GetValist(Gtk.StateFlags state, IntPtr args) {
			gtk_style_properties_get_valist(Handle, (int) state, args);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_properties_lookup_color(IntPtr raw, IntPtr name);
		static d_gtk_style_properties_lookup_color gtk_style_properties_lookup_color = FuncLoader.LoadFunction<d_gtk_style_properties_lookup_color>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_properties_lookup_color"));

		[Obsolete]
		public Gtk.SymbolicColor LookupColor(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gtk_style_properties_lookup_color(Handle, native_name);
			Gtk.SymbolicColor ret = raw_ret == IntPtr.Zero ? null : (Gtk.SymbolicColor) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.SymbolicColor), false);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_style_properties_lookup_property(IntPtr property_name, GtkSharp.StylePropertyParserNative parse_func, IntPtr pspec);
		static d_gtk_style_properties_lookup_property gtk_style_properties_lookup_property = FuncLoader.LoadFunction<d_gtk_style_properties_lookup_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_properties_lookup_property"));

		[Obsolete]
		public static bool LookupProperty(string property_name, Gtk.StylePropertyParser parse_func, IntPtr pspec) {
			IntPtr native_property_name = GLib.Marshaller.StringToPtrGStrdup (property_name);
			GtkSharp.StylePropertyParserWrapper parse_func_wrapper = new GtkSharp.StylePropertyParserWrapper (parse_func);
			bool raw_ret = gtk_style_properties_lookup_property(native_property_name, parse_func_wrapper.NativeDelegate, pspec);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_property_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_properties_map_color(IntPtr raw, IntPtr name, IntPtr color);
		static d_gtk_style_properties_map_color gtk_style_properties_map_color = FuncLoader.LoadFunction<d_gtk_style_properties_map_color>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_properties_map_color"));

		[Obsolete]
		public void MapColor(string name, Gtk.SymbolicColor color) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gtk_style_properties_map_color(Handle, native_name, color == null ? IntPtr.Zero : color.Handle);
			GLib.Marshaller.Free (native_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_properties_merge(IntPtr raw, IntPtr props_to_merge, bool replace);
		static d_gtk_style_properties_merge gtk_style_properties_merge = FuncLoader.LoadFunction<d_gtk_style_properties_merge>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_properties_merge"));

		[Obsolete]
		public void Merge(Gtk.StyleProperties props_to_merge, bool replace) {
			gtk_style_properties_merge(Handle, props_to_merge == null ? IntPtr.Zero : props_to_merge.Handle, replace);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_properties_register_property(GtkSharp.StylePropertyParserNative parse_func, IntPtr pspec);
		static d_gtk_style_properties_register_property gtk_style_properties_register_property = FuncLoader.LoadFunction<d_gtk_style_properties_register_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_properties_register_property"));

		[Obsolete]
		public static void RegisterProperty(Gtk.StylePropertyParser parse_func, IntPtr pspec) {
			GtkSharp.StylePropertyParserWrapper parse_func_wrapper = new GtkSharp.StylePropertyParserWrapper (parse_func);
			gtk_style_properties_register_property(parse_func_wrapper.NativeDelegate, pspec);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_properties_set_property(IntPtr raw, IntPtr property, int state, IntPtr value);
		static d_gtk_style_properties_set_property gtk_style_properties_set_property = FuncLoader.LoadFunction<d_gtk_style_properties_set_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_properties_set_property"));

		[Obsolete]
		public void SetProperty(string property, Gtk.StateFlags state, GLib.Value value) {
			IntPtr native_property = GLib.Marshaller.StringToPtrGStrdup (property);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gtk_style_properties_set_property(Handle, native_property, (int) state, native_value);
			GLib.Marshaller.Free (native_property);
			Marshal.FreeHGlobal (native_value);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_properties_set_valist(IntPtr raw, int state, IntPtr args);
		static d_gtk_style_properties_set_valist gtk_style_properties_set_valist = FuncLoader.LoadFunction<d_gtk_style_properties_set_valist>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_properties_set_valist"));

		[Obsolete]
		public void SetValist(Gtk.StateFlags state, IntPtr args) {
			gtk_style_properties_set_valist(Handle, (int) state, args);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_properties_unset_property(IntPtr raw, IntPtr property, int state);
		static d_gtk_style_properties_unset_property gtk_style_properties_unset_property = FuncLoader.LoadFunction<d_gtk_style_properties_unset_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_properties_unset_property"));

		[Obsolete]
		public void UnsetProperty(string property, Gtk.StateFlags state) {
			IntPtr native_property = GLib.Marshaller.StringToPtrGStrdup (property);
			gtk_style_properties_unset_property(Handle, native_property, (int) state);
			GLib.Marshaller.Free (native_property);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_style_provider_get_style_property(IntPtr raw, IntPtr path, int state, IntPtr pspec, IntPtr value);
		static d_gtk_style_provider_get_style_property gtk_style_provider_get_style_property = FuncLoader.LoadFunction<d_gtk_style_provider_get_style_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_provider_get_style_property"));

		public bool GetStyleProperty(Gtk.WidgetPath path, Gtk.StateFlags state, IntPtr pspec, GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			bool raw_ret = gtk_style_provider_get_style_property(Handle, path == null ? IntPtr.Zero : path.Handle, (int) state, pspec, native_value);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
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
