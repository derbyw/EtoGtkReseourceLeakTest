// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gdk.AnchorHintsGType))]
	public enum AnchorHints {

		FlipX = 1 << 0,
		FlipY = 1 << 1,
		SlideX = 1 << 2,
		SlideY = 1 << 3,
		ResizeX = 1 << 4,
		ResizeY = 1 << 5,
		Flip = FlipX | FlipY,
		Slide = SlideX | SlideY,
		Resize = ResizeX | ResizeY,
	}

	internal class AnchorHintsGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_anchor_hints_get_type();
		static d_gdk_anchor_hints_get_type gdk_anchor_hints_get_type = FuncLoader.LoadFunction<d_gdk_anchor_hints_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_anchor_hints_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_anchor_hints_get_type ());
			}
		}
	}
#endregion
}