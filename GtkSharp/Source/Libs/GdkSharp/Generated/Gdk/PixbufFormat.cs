// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class PixbufFormat : GLib.Opaque {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_pixbuf_format_copy(IntPtr raw);
		static d_gdk_pixbuf_format_copy gdk_pixbuf_format_copy = FuncLoader.LoadFunction<d_gdk_pixbuf_format_copy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_format_copy"));

		public Gdk.PixbufFormat Copy() {
			IntPtr raw_ret = gdk_pixbuf_format_copy(Handle);
			Gdk.PixbufFormat ret = raw_ret == IntPtr.Zero ? null : (Gdk.PixbufFormat) GLib.Opaque.GetOpaque (raw_ret, typeof (Gdk.PixbufFormat), true);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_pixbuf_format_get_description(IntPtr raw);
		static d_gdk_pixbuf_format_get_description gdk_pixbuf_format_get_description = FuncLoader.LoadFunction<d_gdk_pixbuf_format_get_description>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_format_get_description"));

		public string Description { 
			get {
				IntPtr raw_ret = gdk_pixbuf_format_get_description(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_pixbuf_format_get_extensions(IntPtr raw);
		static d_gdk_pixbuf_format_get_extensions gdk_pixbuf_format_get_extensions = FuncLoader.LoadFunction<d_gdk_pixbuf_format_get_extensions>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_format_get_extensions"));

		public string[] Extensions { 
			get {
				IntPtr raw_ret = gdk_pixbuf_format_get_extensions(Handle);
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_pixbuf_format_get_license(IntPtr raw);
		static d_gdk_pixbuf_format_get_license gdk_pixbuf_format_get_license = FuncLoader.LoadFunction<d_gdk_pixbuf_format_get_license>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_format_get_license"));

		public string License { 
			get {
				IntPtr raw_ret = gdk_pixbuf_format_get_license(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_pixbuf_format_get_mime_types(IntPtr raw);
		static d_gdk_pixbuf_format_get_mime_types gdk_pixbuf_format_get_mime_types = FuncLoader.LoadFunction<d_gdk_pixbuf_format_get_mime_types>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_format_get_mime_types"));

		public string[] MimeTypes { 
			get {
				IntPtr raw_ret = gdk_pixbuf_format_get_mime_types(Handle);
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_pixbuf_format_get_name(IntPtr raw);
		static d_gdk_pixbuf_format_get_name gdk_pixbuf_format_get_name = FuncLoader.LoadFunction<d_gdk_pixbuf_format_get_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_format_get_name"));

		public string Name { 
			get {
				IntPtr raw_ret = gdk_pixbuf_format_get_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_pixbuf_format_get_type();
		static d_gdk_pixbuf_format_get_type gdk_pixbuf_format_get_type = FuncLoader.LoadFunction<d_gdk_pixbuf_format_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_format_get_type"));

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_pixbuf_format_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_pixbuf_format_is_disabled(IntPtr raw);
		static d_gdk_pixbuf_format_is_disabled gdk_pixbuf_format_is_disabled = FuncLoader.LoadFunction<d_gdk_pixbuf_format_is_disabled>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_format_is_disabled"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_pixbuf_format_set_disabled(IntPtr raw, bool disabled);
		static d_gdk_pixbuf_format_set_disabled gdk_pixbuf_format_set_disabled = FuncLoader.LoadFunction<d_gdk_pixbuf_format_set_disabled>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_format_set_disabled"));

		public bool Disabled { 
			get {
				bool raw_ret = gdk_pixbuf_format_is_disabled(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gdk_pixbuf_format_set_disabled(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_pixbuf_format_is_save_option_supported(IntPtr raw, IntPtr option_key);
		static d_gdk_pixbuf_format_is_save_option_supported gdk_pixbuf_format_is_save_option_supported = FuncLoader.LoadFunction<d_gdk_pixbuf_format_is_save_option_supported>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_format_is_save_option_supported"));

		public bool IsSaveOptionSupported(string option_key) {
			IntPtr native_option_key = GLib.Marshaller.StringToPtrGStrdup (option_key);
			bool raw_ret = gdk_pixbuf_format_is_save_option_supported(Handle, native_option_key);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_option_key);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_pixbuf_format_is_scalable(IntPtr raw);
		static d_gdk_pixbuf_format_is_scalable gdk_pixbuf_format_is_scalable = FuncLoader.LoadFunction<d_gdk_pixbuf_format_is_scalable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_format_is_scalable"));

		public bool IsScalable { 
			get {
				bool raw_ret = gdk_pixbuf_format_is_scalable(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_pixbuf_format_is_writable(IntPtr raw);
		static d_gdk_pixbuf_format_is_writable gdk_pixbuf_format_is_writable = FuncLoader.LoadFunction<d_gdk_pixbuf_format_is_writable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_format_is_writable"));

		public bool IsWritable { 
			get {
				bool raw_ret = gdk_pixbuf_format_is_writable(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		public PixbufFormat(IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_pixbuf_format_free(IntPtr raw);
		static d_gdk_pixbuf_format_free gdk_pixbuf_format_free = FuncLoader.LoadFunction<d_gdk_pixbuf_format_free>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_format_free"));

		protected override void Free (IntPtr raw)
		{
			gdk_pixbuf_format_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;
			public uint timeoutHandlerId;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gdk_pixbuf_format_free (handle);
				GLib.Timeout.Remove(timeoutHandlerId);
				return false;
			}
		}

		~PixbufFormat ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			info.timeoutHandlerId = GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}