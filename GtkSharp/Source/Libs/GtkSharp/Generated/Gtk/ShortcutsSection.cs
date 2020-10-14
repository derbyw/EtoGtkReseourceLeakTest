// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class ShortcutsSection : Gtk.Box {

		public ShortcutsSection (IntPtr raw) : base(raw) {}

		protected ShortcutsSection() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("section-name")]
		public string SectionName {
			get {
				GLib.Value val = GetProperty ("section-name");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("section-name", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("view-name")]
		public string ViewName {
			get {
				GLib.Value val = GetProperty ("view-name");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("view-name", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("title")]
		public string Title {
			get {
				GLib.Value val = GetProperty ("title");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("title", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("max-height")]
		public uint MaxHeight {
			get {
				GLib.Value val = GetProperty ("max-height");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("max-height", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("change-current-page")]
		public event Gtk.ChangeCurrentPageHandler ChangeCurrentPage {
			add {
				this.AddSignalHandler ("change-current-page", value, typeof (Gtk.ChangeCurrentPageArgs));
			}
			remove {
				this.RemoveSignalHandler ("change-current-page", value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_shortcuts_section_get_type();
		static d_gtk_shortcuts_section_get_type gtk_shortcuts_section_get_type = FuncLoader.LoadFunction<d_gtk_shortcuts_section_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_shortcuts_section_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_shortcuts_section_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
