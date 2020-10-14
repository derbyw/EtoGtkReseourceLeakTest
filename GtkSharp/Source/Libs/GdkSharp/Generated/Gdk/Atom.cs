// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Atom : GLib.Opaque {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_atom_intern(IntPtr atom_name, bool only_if_exists);
		static d_gdk_atom_intern gdk_atom_intern = FuncLoader.LoadFunction<d_gdk_atom_intern>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_atom_intern"));

		public static Gdk.Atom Intern(string atom_name, bool only_if_exists) {
			IntPtr native_atom_name = GLib.Marshaller.StringToPtrGStrdup (atom_name);
			IntPtr raw_ret = gdk_atom_intern(native_atom_name, only_if_exists);
			Gdk.Atom ret = raw_ret == IntPtr.Zero ? null : (Gdk.Atom) GLib.Opaque.GetOpaque (raw_ret, typeof (Gdk.Atom), false);
			GLib.Marshaller.Free (native_atom_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_atom_name(IntPtr raw);
		static d_gdk_atom_name gdk_atom_name = FuncLoader.LoadFunction<d_gdk_atom_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_atom_name"));

		public string Name { 
			get {
				IntPtr raw_ret = gdk_atom_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		public Atom(IntPtr raw) : base(raw) {}


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
