// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Language : GLib.Object {

		public Language (IntPtr raw) : base(raw) {}

		protected Language() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_language_get_id(IntPtr raw);
		static d_gtk_source_language_get_id gtk_source_language_get_id = FuncLoader.LoadFunction<d_gtk_source_language_get_id>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_language_get_id"));

		[GLib.Property ("id")]
		public string Id {
			get  {
				IntPtr raw_ret = gtk_source_language_get_id(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_language_get_name(IntPtr raw);
		static d_gtk_source_language_get_name gtk_source_language_get_name = FuncLoader.LoadFunction<d_gtk_source_language_get_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_language_get_name"));

		[GLib.Property ("name")]
		public string Name {
			get  {
				IntPtr raw_ret = gtk_source_language_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_language_get_section(IntPtr raw);
		static d_gtk_source_language_get_section gtk_source_language_get_section = FuncLoader.LoadFunction<d_gtk_source_language_get_section>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_language_get_section"));

		[GLib.Property ("section")]
		public string Section {
			get  {
				IntPtr raw_ret = gtk_source_language_get_section(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_source_language_get_hidden(IntPtr raw);
		static d_gtk_source_language_get_hidden gtk_source_language_get_hidden = FuncLoader.LoadFunction<d_gtk_source_language_get_hidden>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_language_get_hidden"));

		[GLib.Property ("hidden")]
		public bool Hidden {
			get  {
				bool raw_ret = gtk_source_language_get_hidden(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("padding"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 10 // padding
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
		delegate IntPtr d_gtk_source_language_get_globs(IntPtr raw);
		static d_gtk_source_language_get_globs gtk_source_language_get_globs = FuncLoader.LoadFunction<d_gtk_source_language_get_globs>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_language_get_globs"));

		public string Globs { 
			get {
				IntPtr raw_ret = gtk_source_language_get_globs(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_language_get_metadata(IntPtr raw, IntPtr name);
		static d_gtk_source_language_get_metadata gtk_source_language_get_metadata = FuncLoader.LoadFunction<d_gtk_source_language_get_metadata>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_language_get_metadata"));

		public string GetMetadata(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gtk_source_language_get_metadata(Handle, native_name);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_language_get_mime_types(IntPtr raw);
		static d_gtk_source_language_get_mime_types gtk_source_language_get_mime_types = FuncLoader.LoadFunction<d_gtk_source_language_get_mime_types>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_language_get_mime_types"));

		public string MimeTypes { 
			get {
				IntPtr raw_ret = gtk_source_language_get_mime_types(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_language_get_style_fallback(IntPtr raw, IntPtr style_id);
		static d_gtk_source_language_get_style_fallback gtk_source_language_get_style_fallback = FuncLoader.LoadFunction<d_gtk_source_language_get_style_fallback>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_language_get_style_fallback"));

		public string GetStyleFallback(string style_id) {
			IntPtr native_style_id = GLib.Marshaller.StringToPtrGStrdup (style_id);
			IntPtr raw_ret = gtk_source_language_get_style_fallback(Handle, native_style_id);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_style_id);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_language_get_style_ids(IntPtr raw);
		static d_gtk_source_language_get_style_ids gtk_source_language_get_style_ids = FuncLoader.LoadFunction<d_gtk_source_language_get_style_ids>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_language_get_style_ids"));

		public string StyleIds { 
			get {
				IntPtr raw_ret = gtk_source_language_get_style_ids(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_language_get_style_name(IntPtr raw, IntPtr style_id);
		static d_gtk_source_language_get_style_name gtk_source_language_get_style_name = FuncLoader.LoadFunction<d_gtk_source_language_get_style_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_language_get_style_name"));

		public string GetStyleName(string style_id) {
			IntPtr native_style_id = GLib.Marshaller.StringToPtrGStrdup (style_id);
			IntPtr raw_ret = gtk_source_language_get_style_name(Handle, native_style_id);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_style_id);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_language_get_type();
		static d_gtk_source_language_get_type gtk_source_language_get_type = FuncLoader.LoadFunction<d_gtk_source_language_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_language_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_source_language_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static Language ()
		{
			GtkSharp.GtkSourceSharp.ObjectManager.Initialize ();
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