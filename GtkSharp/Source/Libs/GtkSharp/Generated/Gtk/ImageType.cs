// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.ImageTypeGType))]
	public enum ImageType {

		Empty,
		Pixbuf,
		Stock,
		IconSet,
		Animation,
		IconName,
		Gicon,
		Surface,
	}

	internal class ImageTypeGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_image_type_get_type();
		static d_gtk_image_type_get_type gtk_image_type_get_type = FuncLoader.LoadFunction<d_gtk_image_type_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_image_type_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_image_type_get_type ());
			}
		}
	}
#endregion
}
