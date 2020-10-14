// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Socket : Gtk.Container {

		public Socket (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_socket_new();
		static d_gtk_socket_new gtk_socket_new = FuncLoader.LoadFunction<d_gtk_socket_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_socket_new"));

		public Socket () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Socket)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			owned = true;
			Raw = gtk_socket_new();
		}

		[GLib.Signal("plug-added")]
		public event System.EventHandler PlugAdded {
			add {
				this.AddSignalHandler ("plug-added", value);
			}
			remove {
				this.RemoveSignalHandler ("plug-added", value);
			}
		}

		[GLib.Signal("plug-removed")]
		public event Gtk.PlugRemovedHandler PlugRemoved {
			add {
				this.AddSignalHandler ("plug-removed", value, typeof (Gtk.PlugRemovedArgs));
			}
			remove {
				this.RemoveSignalHandler ("plug-removed", value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_socket_add_id(IntPtr raw, UIntPtr window);
		static d_gtk_socket_add_id gtk_socket_add_id = FuncLoader.LoadFunction<d_gtk_socket_add_id>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_socket_add_id"));

		public void AddId(ulong window) {
			gtk_socket_add_id(Handle, new UIntPtr (window));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate UIntPtr d_gtk_socket_get_id(IntPtr raw);
		static d_gtk_socket_get_id gtk_socket_get_id = FuncLoader.LoadFunction<d_gtk_socket_get_id>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_socket_get_id"));

		public ulong Id { 
			get {
				UIntPtr raw_ret = gtk_socket_get_id(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_socket_get_plug_window(IntPtr raw);
		static d_gtk_socket_get_plug_window gtk_socket_get_plug_window = FuncLoader.LoadFunction<d_gtk_socket_get_plug_window>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_socket_get_plug_window"));

		public Gdk.Window PlugWindow { 
			get {
				IntPtr raw_ret = gtk_socket_get_plug_window(Handle);
				Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_socket_get_type();
		static d_gtk_socket_get_type gtk_socket_get_type = FuncLoader.LoadFunction<d_gtk_socket_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_socket_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_socket_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
