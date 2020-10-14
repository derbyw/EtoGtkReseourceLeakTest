// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class HBox : Gtk.Box {

		public HBox (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_hbox_new(bool homogeneous, int spacing);
		static d_gtk_hbox_new gtk_hbox_new = FuncLoader.LoadFunction<d_gtk_hbox_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_hbox_new"));

		public HBox (bool homogeneous, int spacing) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (HBox)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("homogeneous");
				vals.Add (new GLib.Value (homogeneous));
				names.Add ("spacing");
				vals.Add (new GLib.Value (spacing));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			owned = true;
			Raw = gtk_hbox_new(homogeneous, spacing);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (Gtk.Box.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_hbox_get_type();
		static d_gtk_hbox_get_type gtk_hbox_get_type = FuncLoader.LoadFunction<d_gtk_hbox_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_hbox_get_type"));

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_hbox_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gtk.Box.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
