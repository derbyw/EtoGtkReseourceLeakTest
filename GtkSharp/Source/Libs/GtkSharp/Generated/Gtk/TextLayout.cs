// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TextLayout : GLib.Opaque {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_text_layout_draw(IntPtr raw, IntPtr widget, IntPtr cr, IntPtr widgets);
		static d_gtk_text_layout_draw gtk_text_layout_draw = FuncLoader.LoadFunction<d_gtk_text_layout_draw>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_text_layout_draw"));

		public void Draw(Gtk.Widget widget, Cairo.Context cr, GLib.List widgets) {
			gtk_text_layout_draw(Handle, widget == null ? IntPtr.Zero : widget.Handle, cr == null ? IntPtr.Zero : cr.Handle, widgets == null ? IntPtr.Zero : widgets.Handle);
		}

		public TextLayout(IntPtr raw) : base(raw) {}


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
