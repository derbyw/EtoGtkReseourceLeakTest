// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (GLib.ResolverRecordTypeGType))]
	public enum ResolverRecordType {

		Srv = 1,
		Mx,
		Txt,
		Soa,
		Ns,
	}

	internal class ResolverRecordTypeGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_resolver_record_type_get_type();
		static d_g_resolver_record_type_get_type g_resolver_record_type_get_type = FuncLoader.LoadFunction<d_g_resolver_record_type_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_resolver_record_type_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_resolver_record_type_get_type ());
			}
		}
	}
#endregion
}