// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class StackSwitcher : Gtk.Box {

		public StackSwitcher (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_stack_switcher_new();
		static d_gtk_stack_switcher_new gtk_stack_switcher_new = FuncLoader.LoadFunction<d_gtk_stack_switcher_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_stack_switcher_new"));

		public StackSwitcher () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (StackSwitcher)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			owned = true;
			Raw = gtk_stack_switcher_new();
		}

		[GLib.Property ("icon-size")]
		public int IconSize {
			get {
				GLib.Value val = GetProperty ("icon-size");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("icon-size", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_stack_switcher_get_stack(IntPtr raw);
		static d_gtk_stack_switcher_get_stack gtk_stack_switcher_get_stack = FuncLoader.LoadFunction<d_gtk_stack_switcher_get_stack>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_stack_switcher_get_stack"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_stack_switcher_set_stack(IntPtr raw, IntPtr stack);
		static d_gtk_stack_switcher_set_stack gtk_stack_switcher_set_stack = FuncLoader.LoadFunction<d_gtk_stack_switcher_set_stack>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_stack_switcher_set_stack"));

		[GLib.Property ("stack")]
		public Gtk.Stack Stack {
			get  {
				IntPtr raw_ret = gtk_stack_switcher_get_stack(Handle);
				Gtk.Stack ret = GLib.Object.GetObject(raw_ret) as Gtk.Stack;
				return ret;
			}
			set  {
				gtk_stack_switcher_set_stack(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Box.class_abi.Fields
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
		delegate IntPtr d_gtk_stack_switcher_get_type();
		static d_gtk_stack_switcher_get_type gtk_stack_switcher_get_type = FuncLoader.LoadFunction<d_gtk_stack_switcher_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_stack_switcher_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_stack_switcher_get_type();
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
