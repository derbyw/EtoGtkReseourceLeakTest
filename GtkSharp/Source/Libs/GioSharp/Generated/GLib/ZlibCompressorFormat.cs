// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (GLib.ZlibCompressorFormatGType))]
	public enum ZlibCompressorFormat {

		Zlib,
		Gzip,
		Raw,
	}

	internal class ZlibCompressorFormatGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_zlib_compressor_format_get_type();
		static d_g_zlib_compressor_format_get_type g_zlib_compressor_format_get_type = FuncLoader.LoadFunction<d_g_zlib_compressor_format_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_zlib_compressor_format_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_zlib_compressor_format_get_type ());
			}
		}
	}
#endregion
}
