// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.StackTransitionTypeGType))]
	public enum StackTransitionType {

		None,
		Crossfade,
		SlideRight,
		SlideLeft,
		SlideUp,
		SlideDown,
		SlideLeftRight,
		SlideUpDown,
		OverUp,
		OverDown,
		OverLeft,
		OverRight,
		UnderUp,
		UnderDown,
		UnderLeft,
		UnderRight,
		OverUpDown,
		OverDownUp,
		OverLeftRight,
		OverRightLeft,
	}

	internal class StackTransitionTypeGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_stack_transition_type_get_type();
		static d_gtk_stack_transition_type_get_type gtk_stack_transition_type_get_type = FuncLoader.LoadFunction<d_gtk_stack_transition_type_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_stack_transition_type_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_stack_transition_type_get_type ());
			}
		}
	}
#endregion
}
