// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gdk.FrameClockPhaseGType))]
	public enum FrameClockPhase {

		None,
		FlushEvents = 1 << 0,
		BeforePaint = 1 << 1,
		Update = 1 << 2,
		Layout = 1 << 3,
		Paint = 1 << 4,
		ResumeEvents = 1 << 5,
		AfterPaint = 1 << 6,
	}

	internal class FrameClockPhaseGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_frame_clock_phase_get_type();
		static d_gdk_frame_clock_phase_get_type gdk_frame_clock_phase_get_type = FuncLoader.LoadFunction<d_gdk_frame_clock_phase_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_frame_clock_phase_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_frame_clock_phase_get_type ());
			}
		}
	}
#endregion
}