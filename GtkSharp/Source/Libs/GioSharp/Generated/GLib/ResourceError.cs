// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (GLib.ResourceErrorGType))]
	public enum ResourceError {

		NotFound,
		Internal,
	}

	internal class ResourceErrorGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_resource_error_get_type();
		static d_g_resource_error_get_type g_resource_error_get_type = FuncLoader.LoadFunction<d_g_resource_error_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_resource_error_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_resource_error_get_type ());
			}
		}
	}
#endregion
}
