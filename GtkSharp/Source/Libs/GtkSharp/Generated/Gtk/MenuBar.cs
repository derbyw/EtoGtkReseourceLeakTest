// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class MenuBar : Gtk.MenuShell {

		public MenuBar (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_bar_new();
		static d_gtk_menu_bar_new gtk_menu_bar_new = FuncLoader.LoadFunction<d_gtk_menu_bar_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_bar_new"));

		public MenuBar () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuBar)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			owned = true;
			Raw = gtk_menu_bar_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_bar_new_from_model(IntPtr model);
		static d_gtk_menu_bar_new_from_model gtk_menu_bar_new_from_model = FuncLoader.LoadFunction<d_gtk_menu_bar_new_from_model>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_bar_new_from_model"));

		public MenuBar (GLib.MenuModel model) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuBar)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			owned = true;
			Raw = gtk_menu_bar_new_from_model(model == null ? IntPtr.Zero : model.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_menu_bar_get_pack_direction(IntPtr raw);
		static d_gtk_menu_bar_get_pack_direction gtk_menu_bar_get_pack_direction = FuncLoader.LoadFunction<d_gtk_menu_bar_get_pack_direction>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_bar_get_pack_direction"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_bar_set_pack_direction(IntPtr raw, int pack_dir);
		static d_gtk_menu_bar_set_pack_direction gtk_menu_bar_set_pack_direction = FuncLoader.LoadFunction<d_gtk_menu_bar_set_pack_direction>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_bar_set_pack_direction"));

		[GLib.Property ("pack-direction")]
		public Gtk.PackDirection PackDirection {
			get  {
				int raw_ret = gtk_menu_bar_get_pack_direction(Handle);
				Gtk.PackDirection ret = (Gtk.PackDirection) raw_ret;
				return ret;
			}
			set  {
				gtk_menu_bar_set_pack_direction(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_menu_bar_get_child_pack_direction(IntPtr raw);
		static d_gtk_menu_bar_get_child_pack_direction gtk_menu_bar_get_child_pack_direction = FuncLoader.LoadFunction<d_gtk_menu_bar_get_child_pack_direction>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_bar_get_child_pack_direction"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_bar_set_child_pack_direction(IntPtr raw, int child_pack_dir);
		static d_gtk_menu_bar_set_child_pack_direction gtk_menu_bar_set_child_pack_direction = FuncLoader.LoadFunction<d_gtk_menu_bar_set_child_pack_direction>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_bar_set_child_pack_direction"));

		[GLib.Property ("child-pack-direction")]
		public Gtk.PackDirection ChildPackDirection {
			get  {
				int raw_ret = gtk_menu_bar_get_child_pack_direction(Handle);
				Gtk.PackDirection ret = (Gtk.PackDirection) raw_ret;
				return ret;
			}
			set  {
				gtk_menu_bar_set_child_pack_direction(Handle, (int) value);
			}
		}

		[GLib.Property ("shadow-type")]
		public Gtk.ShadowType ShadowType {
			get {
				GLib.Value val = GetProperty ("shadow-type");
				Gtk.ShadowType ret = (Gtk.ShadowType) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("internal-padding")]
		public int InternalPadding {
			get {
				GLib.Value val = GetProperty ("internal-padding");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.MenuShell.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, null
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_bar_get_type();
		static d_gtk_menu_bar_get_type gtk_menu_bar_get_type = FuncLoader.LoadFunction<d_gtk_menu_bar_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_bar_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_menu_bar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.MenuShell.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
