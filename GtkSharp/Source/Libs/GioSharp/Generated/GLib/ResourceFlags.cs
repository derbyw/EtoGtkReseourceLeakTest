// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GLib.ResourceFlagsGType))]
	public enum ResourceFlags {

		None,
		Compressed = 1 << 0,
	}

	internal class ResourceFlagsGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_resource_flags_get_type();
		static d_g_resource_flags_get_type g_resource_flags_get_type = FuncLoader.LoadFunction<d_g_resource_flags_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_resource_flags_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_resource_flags_get_type ());
			}
		}
	}
#endregion
}
