// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.AxisUseGType))]
	public enum AxisUse {

		Ignore,
		X,
		Y,
		Pressure,
		Xtilt,
		Ytilt,
		Wheel,
		Distance,
		Rotation,
		Slider,
		Last,
	}

	internal class AxisUseGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_axis_use_get_type();
		static d_gdk_axis_use_get_type gdk_axis_use_get_type = FuncLoader.LoadFunction<d_gdk_axis_use_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_axis_use_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_axis_use_get_type ());
			}
		}
	}
#endregion
}
