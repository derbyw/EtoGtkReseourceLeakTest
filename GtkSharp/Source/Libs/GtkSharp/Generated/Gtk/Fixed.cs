// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Fixed : Gtk.Container {

		public Fixed (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_fixed_new();
		static d_gtk_fixed_new gtk_fixed_new = FuncLoader.LoadFunction<d_gtk_fixed_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_fixed_new"));

		public Fixed () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Fixed)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			owned = true;
			Raw = gtk_fixed_new();
		}

		public class FixedChild : Gtk.Container.ContainerChild {
			protected internal FixedChild (Gtk.Container parent, Gtk.Widget child) : base (parent, child) {}

			[Gtk.ChildProperty ("x")]
			public int X {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "x");
					int ret = (int) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "x", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("y")]
			public int Y {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "y");
					int ret = (int) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "y", val);
					val.Dispose ();
				}
			}

		}

		public override Gtk.Container.ContainerChild this [Gtk.Widget child] {
			get {
				return new FixedChild (this, child);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Container.class_abi.Fields
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
		delegate IntPtr d_gtk_fixed_get_type();
		static d_gtk_fixed_get_type gtk_fixed_get_type = FuncLoader.LoadFunction<d_gtk_fixed_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_fixed_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_fixed_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_fixed_move(IntPtr raw, IntPtr widget, int x, int y);
		static d_gtk_fixed_move gtk_fixed_move = FuncLoader.LoadFunction<d_gtk_fixed_move>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_fixed_move"));

		public void Move(Gtk.Widget widget, int x, int y) {
			gtk_fixed_move(Handle, widget == null ? IntPtr.Zero : widget.Handle, x, y);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_fixed_put(IntPtr raw, IntPtr widget, int x, int y);
		static d_gtk_fixed_put gtk_fixed_put = FuncLoader.LoadFunction<d_gtk_fixed_put>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_fixed_put"));

		public void Put(Gtk.Widget widget, int x, int y) {
			gtk_fixed_put(Handle, widget == null ? IntPtr.Zero : widget.Handle, x, y);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Container.abi_info.Fields
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
