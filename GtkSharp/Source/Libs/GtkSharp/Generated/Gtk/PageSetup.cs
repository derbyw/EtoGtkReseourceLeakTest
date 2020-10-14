// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class PageSetup : GLib.Object {

		public PageSetup (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_page_setup_new();
		static d_gtk_page_setup_new gtk_page_setup_new = FuncLoader.LoadFunction<d_gtk_page_setup_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_new"));

		public PageSetup () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PageSetup)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			owned = true;
			Raw = gtk_page_setup_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_page_setup_new_from_file(IntPtr file_name, out IntPtr error);
		static d_gtk_page_setup_new_from_file gtk_page_setup_new_from_file = FuncLoader.LoadFunction<d_gtk_page_setup_new_from_file>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_new_from_file"));

		public unsafe PageSetup (string file_name) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PageSetup)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_file_name = GLib.Marshaller.StringToFilenamePtr (file_name);
			IntPtr error = IntPtr.Zero;
			owned = true;
			Raw = gtk_page_setup_new_from_file(native_file_name, out error);
			GLib.Marshaller.Free (native_file_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_page_setup_new_from_gvariant(IntPtr variant);
		static d_gtk_page_setup_new_from_gvariant gtk_page_setup_new_from_gvariant = FuncLoader.LoadFunction<d_gtk_page_setup_new_from_gvariant>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_new_from_gvariant"));

		public PageSetup (GLib.Variant variant) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PageSetup)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			owned = true;
			Raw = gtk_page_setup_new_from_gvariant(variant == null ? IntPtr.Zero : variant.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_page_setup_new_from_key_file(IntPtr key_file, IntPtr group_name, out IntPtr error);
		static d_gtk_page_setup_new_from_key_file gtk_page_setup_new_from_key_file = FuncLoader.LoadFunction<d_gtk_page_setup_new_from_key_file>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_new_from_key_file"));

		public unsafe PageSetup (GLib.KeyFile key_file, string group_name) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PageSetup)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr error = IntPtr.Zero;
			owned = true;
			Raw = gtk_page_setup_new_from_key_file(key_file == null ? IntPtr.Zero : key_file.Handle, native_group_name, out error);
			GLib.Marshaller.Free (native_group_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (GLib.Object.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_page_setup_copy(IntPtr raw);
		static d_gtk_page_setup_copy gtk_page_setup_copy = FuncLoader.LoadFunction<d_gtk_page_setup_copy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_copy"));

		public Gtk.PageSetup Copy() {
			IntPtr raw_ret = gtk_page_setup_copy(Handle);
			Gtk.PageSetup ret = GLib.Object.GetObject(raw_ret, true) as Gtk.PageSetup;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double d_gtk_page_setup_get_bottom_margin(IntPtr raw, int unit);
		static d_gtk_page_setup_get_bottom_margin gtk_page_setup_get_bottom_margin = FuncLoader.LoadFunction<d_gtk_page_setup_get_bottom_margin>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_get_bottom_margin"));

		public double GetBottomMargin(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_bottom_margin(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double d_gtk_page_setup_get_left_margin(IntPtr raw, int unit);
		static d_gtk_page_setup_get_left_margin gtk_page_setup_get_left_margin = FuncLoader.LoadFunction<d_gtk_page_setup_get_left_margin>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_get_left_margin"));

		public double GetLeftMargin(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_left_margin(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_page_setup_get_orientation(IntPtr raw);
		static d_gtk_page_setup_get_orientation gtk_page_setup_get_orientation = FuncLoader.LoadFunction<d_gtk_page_setup_get_orientation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_get_orientation"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_page_setup_set_orientation(IntPtr raw, int orientation);
		static d_gtk_page_setup_set_orientation gtk_page_setup_set_orientation = FuncLoader.LoadFunction<d_gtk_page_setup_set_orientation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_set_orientation"));

		public Gtk.PageOrientation Orientation { 
			get {
				int raw_ret = gtk_page_setup_get_orientation(Handle);
				Gtk.PageOrientation ret = (Gtk.PageOrientation) raw_ret;
				return ret;
			}
			set {
				gtk_page_setup_set_orientation(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double d_gtk_page_setup_get_page_height(IntPtr raw, int unit);
		static d_gtk_page_setup_get_page_height gtk_page_setup_get_page_height = FuncLoader.LoadFunction<d_gtk_page_setup_get_page_height>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_get_page_height"));

		public double GetPageHeight(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_page_height(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double d_gtk_page_setup_get_page_width(IntPtr raw, int unit);
		static d_gtk_page_setup_get_page_width gtk_page_setup_get_page_width = FuncLoader.LoadFunction<d_gtk_page_setup_get_page_width>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_get_page_width"));

		public double GetPageWidth(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_page_width(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double d_gtk_page_setup_get_paper_height(IntPtr raw, int unit);
		static d_gtk_page_setup_get_paper_height gtk_page_setup_get_paper_height = FuncLoader.LoadFunction<d_gtk_page_setup_get_paper_height>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_get_paper_height"));

		public double GetPaperHeight(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_paper_height(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_page_setup_get_paper_size(IntPtr raw);
		static d_gtk_page_setup_get_paper_size gtk_page_setup_get_paper_size = FuncLoader.LoadFunction<d_gtk_page_setup_get_paper_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_get_paper_size"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_page_setup_set_paper_size(IntPtr raw, IntPtr size);
		static d_gtk_page_setup_set_paper_size gtk_page_setup_set_paper_size = FuncLoader.LoadFunction<d_gtk_page_setup_set_paper_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_set_paper_size"));

		public Gtk.PaperSize PaperSize { 
			get {
				IntPtr raw_ret = gtk_page_setup_get_paper_size(Handle);
				Gtk.PaperSize ret = raw_ret == IntPtr.Zero ? null : (Gtk.PaperSize) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.PaperSize), false);
				return ret;
			}
			set {
				gtk_page_setup_set_paper_size(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double d_gtk_page_setup_get_paper_width(IntPtr raw, int unit);
		static d_gtk_page_setup_get_paper_width gtk_page_setup_get_paper_width = FuncLoader.LoadFunction<d_gtk_page_setup_get_paper_width>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_get_paper_width"));

		public double GetPaperWidth(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_paper_width(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double d_gtk_page_setup_get_right_margin(IntPtr raw, int unit);
		static d_gtk_page_setup_get_right_margin gtk_page_setup_get_right_margin = FuncLoader.LoadFunction<d_gtk_page_setup_get_right_margin>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_get_right_margin"));

		public double GetRightMargin(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_right_margin(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double d_gtk_page_setup_get_top_margin(IntPtr raw, int unit);
		static d_gtk_page_setup_get_top_margin gtk_page_setup_get_top_margin = FuncLoader.LoadFunction<d_gtk_page_setup_get_top_margin>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_get_top_margin"));

		public double GetTopMargin(Gtk.Unit unit) {
			double raw_ret = gtk_page_setup_get_top_margin(Handle, (int) unit);
			double ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_page_setup_get_type();
		static d_gtk_page_setup_get_type gtk_page_setup_get_type = FuncLoader.LoadFunction<d_gtk_page_setup_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_page_setup_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_page_setup_load_file(IntPtr raw, IntPtr file_name, out IntPtr error);
		static d_gtk_page_setup_load_file gtk_page_setup_load_file = FuncLoader.LoadFunction<d_gtk_page_setup_load_file>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_load_file"));

		public unsafe bool LoadFile(string file_name) {
			IntPtr native_file_name = GLib.Marshaller.StringToPtrGStrdup (file_name);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_page_setup_load_file(Handle, native_file_name, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_file_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_page_setup_load_key_file(IntPtr raw, IntPtr key_file, IntPtr group_name, out IntPtr error);
		static d_gtk_page_setup_load_key_file gtk_page_setup_load_key_file = FuncLoader.LoadFunction<d_gtk_page_setup_load_key_file>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_load_key_file"));

		public unsafe bool LoadKeyFile(GLib.KeyFile key_file, string group_name) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_page_setup_load_key_file(Handle, key_file == null ? IntPtr.Zero : key_file.Handle, native_group_name, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_group_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_page_setup_set_bottom_margin(IntPtr raw, double margin, int unit);
		static d_gtk_page_setup_set_bottom_margin gtk_page_setup_set_bottom_margin = FuncLoader.LoadFunction<d_gtk_page_setup_set_bottom_margin>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_set_bottom_margin"));

		public void SetBottomMargin(double margin, Gtk.Unit unit) {
			gtk_page_setup_set_bottom_margin(Handle, margin, (int) unit);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_page_setup_set_left_margin(IntPtr raw, double margin, int unit);
		static d_gtk_page_setup_set_left_margin gtk_page_setup_set_left_margin = FuncLoader.LoadFunction<d_gtk_page_setup_set_left_margin>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_set_left_margin"));

		public void SetLeftMargin(double margin, Gtk.Unit unit) {
			gtk_page_setup_set_left_margin(Handle, margin, (int) unit);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_page_setup_set_paper_size_and_default_margins(IntPtr raw, IntPtr size);
		static d_gtk_page_setup_set_paper_size_and_default_margins gtk_page_setup_set_paper_size_and_default_margins = FuncLoader.LoadFunction<d_gtk_page_setup_set_paper_size_and_default_margins>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_set_paper_size_and_default_margins"));

		public Gtk.PaperSize PaperSizeAndDefaultMargins { 
			set {
				gtk_page_setup_set_paper_size_and_default_margins(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_page_setup_set_right_margin(IntPtr raw, double margin, int unit);
		static d_gtk_page_setup_set_right_margin gtk_page_setup_set_right_margin = FuncLoader.LoadFunction<d_gtk_page_setup_set_right_margin>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_set_right_margin"));

		public void SetRightMargin(double margin, Gtk.Unit unit) {
			gtk_page_setup_set_right_margin(Handle, margin, (int) unit);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_page_setup_set_top_margin(IntPtr raw, double margin, int unit);
		static d_gtk_page_setup_set_top_margin gtk_page_setup_set_top_margin = FuncLoader.LoadFunction<d_gtk_page_setup_set_top_margin>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_set_top_margin"));

		public void SetTopMargin(double margin, Gtk.Unit unit) {
			gtk_page_setup_set_top_margin(Handle, margin, (int) unit);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_page_setup_to_file(IntPtr raw, IntPtr file_name, out IntPtr error);
		static d_gtk_page_setup_to_file gtk_page_setup_to_file = FuncLoader.LoadFunction<d_gtk_page_setup_to_file>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_to_file"));

		public unsafe bool ToFile(string file_name) {
			IntPtr native_file_name = GLib.Marshaller.StringToFilenamePtr (file_name);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_page_setup_to_file(Handle, native_file_name, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_file_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_page_setup_to_gvariant(IntPtr raw);
		static d_gtk_page_setup_to_gvariant gtk_page_setup_to_gvariant = FuncLoader.LoadFunction<d_gtk_page_setup_to_gvariant>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_to_gvariant"));

		public GLib.Variant ToGvariant() {
			IntPtr raw_ret = gtk_page_setup_to_gvariant(Handle);
			GLib.Variant ret = new GLib.Variant(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_page_setup_to_key_file(IntPtr raw, IntPtr key_file, IntPtr group_name);
		static d_gtk_page_setup_to_key_file gtk_page_setup_to_key_file = FuncLoader.LoadFunction<d_gtk_page_setup_to_key_file>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_page_setup_to_key_file"));

		public void ToKeyFile(GLib.KeyFile key_file, string group_name) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			gtk_page_setup_to_key_file(Handle, key_file == null ? IntPtr.Zero : key_file.Handle, native_group_name);
			GLib.Marshaller.Free (native_group_name);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (GLib.Object.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
