// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GLib.AskPasswordFlagsGType))]
	public enum AskPasswordFlags {

		NeedPassword = 1 << 0,
		NeedUsername = 1 << 1,
		NeedDomain = 1 << 2,
		SavingSupported = 1 << 3,
		AnonymousSupported = 1 << 4,
	}

	internal class AskPasswordFlagsGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_ask_password_flags_get_type();
		static d_g_ask_password_flags_get_type g_ask_password_flags_get_type = FuncLoader.LoadFunction<d_g_ask_password_flags_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_ask_password_flags_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_ask_password_flags_get_type ());
			}
		}
	}
#endregion
}
