// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Target {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_target_table_free(IntPtr targets, int n_targets);
		static d_gtk_target_table_free gtk_target_table_free = FuncLoader.LoadFunction<d_gtk_target_table_free>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_target_table_free"));

		public static void TableFree(Gtk.TargetEntry targets, int n_targets) {
			IntPtr native_targets = GLib.Marshaller.StructureToPtrAlloc (targets);
			gtk_target_table_free(native_targets, n_targets);
			Marshal.FreeHGlobal (native_targets);
		}

#endregion
	}
}
