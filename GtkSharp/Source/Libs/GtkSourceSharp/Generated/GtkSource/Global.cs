// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Global {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_tag_new(IntPtr name);
		static d_gtk_source_tag_new gtk_source_tag_new = FuncLoader.LoadFunction<d_gtk_source_tag_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_tag_new"));

		public static Gtk.TextTag TagNew(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gtk_source_tag_new(native_name);
			Gtk.TextTag ret = GLib.Object.GetObject(raw_ret) as Gtk.TextTag;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

#endregion
	}
}
