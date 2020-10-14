// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Accelerator {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_accelerator_get_default_mod_mask();
		static d_gtk_accelerator_get_default_mod_mask gtk_accelerator_get_default_mod_mask = FuncLoader.LoadFunction<d_gtk_accelerator_get_default_mod_mask>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_accelerator_get_default_mod_mask"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_accelerator_set_default_mod_mask(int default_mod_mask);
		static d_gtk_accelerator_set_default_mod_mask gtk_accelerator_set_default_mod_mask = FuncLoader.LoadFunction<d_gtk_accelerator_set_default_mod_mask>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_accelerator_set_default_mod_mask"));

		public static Gdk.ModifierType DefaultModMask { 
			get {
				int raw_ret = gtk_accelerator_get_default_mod_mask();
				Gdk.ModifierType ret = (Gdk.ModifierType) raw_ret;
				return ret;
			}
			set {
				gtk_accelerator_set_default_mod_mask((int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_accelerator_get_label(uint accelerator_key, int accelerator_mods);
		static d_gtk_accelerator_get_label gtk_accelerator_get_label = FuncLoader.LoadFunction<d_gtk_accelerator_get_label>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_accelerator_get_label"));

		public static string GetLabel(uint accelerator_key, Gdk.ModifierType accelerator_mods) {
			IntPtr raw_ret = gtk_accelerator_get_label(accelerator_key, (int) accelerator_mods);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_accelerator_get_label_with_keycode(IntPtr display, uint accelerator_key, uint keycode, int accelerator_mods);
		static d_gtk_accelerator_get_label_with_keycode gtk_accelerator_get_label_with_keycode = FuncLoader.LoadFunction<d_gtk_accelerator_get_label_with_keycode>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_accelerator_get_label_with_keycode"));

		public static string GetLabelWithKeycode(Gdk.Display display, uint accelerator_key, uint keycode, Gdk.ModifierType accelerator_mods) {
			IntPtr raw_ret = gtk_accelerator_get_label_with_keycode(display == null ? IntPtr.Zero : display.Handle, accelerator_key, keycode, (int) accelerator_mods);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_accelerator_name(uint accelerator_key, int accelerator_mods);
		static d_gtk_accelerator_name gtk_accelerator_name = FuncLoader.LoadFunction<d_gtk_accelerator_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_accelerator_name"));

		public static string Name(uint accelerator_key, Gdk.ModifierType accelerator_mods) {
			IntPtr raw_ret = gtk_accelerator_name(accelerator_key, (int) accelerator_mods);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_accelerator_name_with_keycode(IntPtr display, uint accelerator_key, uint keycode, int accelerator_mods);
		static d_gtk_accelerator_name_with_keycode gtk_accelerator_name_with_keycode = FuncLoader.LoadFunction<d_gtk_accelerator_name_with_keycode>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_accelerator_name_with_keycode"));

		public static string NameWithKeycode(Gdk.Display display, uint accelerator_key, uint keycode, Gdk.ModifierType accelerator_mods) {
			IntPtr raw_ret = gtk_accelerator_name_with_keycode(display == null ? IntPtr.Zero : display.Handle, accelerator_key, keycode, (int) accelerator_mods);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_accelerator_parse(IntPtr accelerator, out uint accelerator_key, out int accelerator_mods);
		static d_gtk_accelerator_parse gtk_accelerator_parse = FuncLoader.LoadFunction<d_gtk_accelerator_parse>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_accelerator_parse"));

		public static void Parse(string accelerator, out uint accelerator_key, out Gdk.ModifierType accelerator_mods) {
			IntPtr native_accelerator = GLib.Marshaller.StringToPtrGStrdup (accelerator);
			int native_accelerator_mods;
			gtk_accelerator_parse(native_accelerator, out accelerator_key, out native_accelerator_mods);
			GLib.Marshaller.Free (native_accelerator);
			accelerator_mods = (Gdk.ModifierType) native_accelerator_mods;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_accelerator_parse_with_keycode(IntPtr accelerator, out uint accelerator_key, out uint accelerator_codes, out int accelerator_mods);
		static d_gtk_accelerator_parse_with_keycode gtk_accelerator_parse_with_keycode = FuncLoader.LoadFunction<d_gtk_accelerator_parse_with_keycode>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_accelerator_parse_with_keycode"));

		public static void ParseWithKeycode(string accelerator, out uint accelerator_key, out uint accelerator_codes, out Gdk.ModifierType accelerator_mods) {
			IntPtr native_accelerator = GLib.Marshaller.StringToPtrGStrdup (accelerator);
			int native_accelerator_mods;
			gtk_accelerator_parse_with_keycode(native_accelerator, out accelerator_key, out accelerator_codes, out native_accelerator_mods);
			GLib.Marshaller.Free (native_accelerator);
			accelerator_mods = (Gdk.ModifierType) native_accelerator_mods;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_accelerator_valid(uint keyval, int modifiers);
		static d_gtk_accelerator_valid gtk_accelerator_valid = FuncLoader.LoadFunction<d_gtk_accelerator_valid>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_accelerator_valid"));

		public static bool Valid(uint keyval, Gdk.ModifierType modifiers) {
			bool raw_ret = gtk_accelerator_valid(keyval, (int) modifiers);
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}