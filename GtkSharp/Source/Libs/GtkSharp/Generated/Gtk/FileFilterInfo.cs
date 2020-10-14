// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FileFilterInfo : IEquatable<FileFilterInfo> {

		public Gtk.FileFilterFlags Contains;
		public string Filename;
		public string Uri;
		public string DisplayName;
		public string MimeType;

		public static Gtk.FileFilterInfo Zero = new Gtk.FileFilterInfo ();

		public static Gtk.FileFilterInfo New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gtk.FileFilterInfo.Zero;
			return (Gtk.FileFilterInfo) Marshal.PtrToStructure (raw, typeof (Gtk.FileFilterInfo));
		}

		public bool Equals (FileFilterInfo other)
		{
			return true && Contains.Equals (other.Contains) && Filename.Equals (other.Filename) && Uri.Equals (other.Uri) && DisplayName.Equals (other.DisplayName) && MimeType.Equals (other.MimeType);
		}

		public override bool Equals (object other)
		{
			return other is FileFilterInfo && Equals ((FileFilterInfo) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Contains.GetHashCode () ^ Filename.GetHashCode () ^ Uri.GetHashCode () ^ DisplayName.GetHashCode () ^ MimeType.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
