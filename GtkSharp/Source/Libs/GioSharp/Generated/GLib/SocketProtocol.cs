// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (GLib.SocketProtocolGType))]
	public enum SocketProtocol {

		Unknown = -1,
		Default,
		Tcp = 6,
		Udp = 17,
		Sctp = 132,
	}

	internal class SocketProtocolGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_socket_protocol_get_type();
		static d_g_socket_protocol_get_type g_socket_protocol_get_type = FuncLoader.LoadFunction<d_g_socket_protocol_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_socket_protocol_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_socket_protocol_get_type ());
			}
		}
	}
#endregion
}
