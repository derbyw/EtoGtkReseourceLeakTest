// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Keyval {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_keyval_convert_case(uint symbol, out uint lower, out uint upper);
		static d_gdk_keyval_convert_case gdk_keyval_convert_case = FuncLoader.LoadFunction<d_gdk_keyval_convert_case>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_keyval_convert_case"));

		public static void ConvertCase(uint symbol, out uint lower, out uint upper) {
			gdk_keyval_convert_case(symbol, out lower, out upper);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gdk_keyval_from_name(IntPtr keyval_name);
		static d_gdk_keyval_from_name gdk_keyval_from_name = FuncLoader.LoadFunction<d_gdk_keyval_from_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_keyval_from_name"));

		public static uint FromName(string keyval_name) {
			IntPtr native_keyval_name = GLib.Marshaller.StringToPtrGStrdup (keyval_name);
			uint raw_ret = gdk_keyval_from_name(native_keyval_name);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_keyval_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_keyval_is_lower(uint keyval);
		static d_gdk_keyval_is_lower gdk_keyval_is_lower = FuncLoader.LoadFunction<d_gdk_keyval_is_lower>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_keyval_is_lower"));

		public static bool IsLower(uint keyval) {
			bool raw_ret = gdk_keyval_is_lower(keyval);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_keyval_is_upper(uint keyval);
		static d_gdk_keyval_is_upper gdk_keyval_is_upper = FuncLoader.LoadFunction<d_gdk_keyval_is_upper>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_keyval_is_upper"));

		public static bool IsUpper(uint keyval) {
			bool raw_ret = gdk_keyval_is_upper(keyval);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_keyval_name(uint keyval);
		static d_gdk_keyval_name gdk_keyval_name = FuncLoader.LoadFunction<d_gdk_keyval_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_keyval_name"));

		public static string Name(uint keyval) {
			IntPtr raw_ret = gdk_keyval_name(keyval);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gdk_keyval_to_lower(uint keyval);
		static d_gdk_keyval_to_lower gdk_keyval_to_lower = FuncLoader.LoadFunction<d_gdk_keyval_to_lower>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_keyval_to_lower"));

		public static uint ToLower(uint keyval) {
			uint raw_ret = gdk_keyval_to_lower(keyval);
			uint ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gdk_keyval_to_unicode(uint keyval);
		static d_gdk_keyval_to_unicode gdk_keyval_to_unicode = FuncLoader.LoadFunction<d_gdk_keyval_to_unicode>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_keyval_to_unicode"));

		public static uint ToUnicode(uint keyval) {
			uint raw_ret = gdk_keyval_to_unicode(keyval);
			uint ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gdk_keyval_to_upper(uint keyval);
		static d_gdk_keyval_to_upper gdk_keyval_to_upper = FuncLoader.LoadFunction<d_gdk_keyval_to_upper>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_keyval_to_upper"));

		public static uint ToUpper(uint keyval) {
			uint raw_ret = gdk_keyval_to_upper(keyval);
			uint ret = raw_ret;
			return ret;
		}

#endregion
	}
}
