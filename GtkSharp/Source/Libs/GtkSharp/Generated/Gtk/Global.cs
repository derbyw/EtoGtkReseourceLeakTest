// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Global {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_alternative_dialog_button_order(IntPtr screen);
		static d_gtk_alternative_dialog_button_order gtk_alternative_dialog_button_order = FuncLoader.LoadFunction<d_gtk_alternative_dialog_button_order>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_alternative_dialog_button_order"));

		[Obsolete]
		public static bool AlternativeDialogButtonOrder(Gdk.Screen screen) {
			bool raw_ret = gtk_alternative_dialog_button_order(screen == null ? IntPtr.Zero : screen.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_check_version(uint required_major, uint required_minor, uint required_micro);
		static d_gtk_check_version gtk_check_version = FuncLoader.LoadFunction<d_gtk_check_version>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_check_version"));

		public static string CheckVersion(uint required_major, uint required_minor, uint required_micro) {
			IntPtr raw_ret = gtk_check_version(required_major, required_minor, required_micro);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_disable_setlocale();
		static d_gtk_disable_setlocale gtk_disable_setlocale = FuncLoader.LoadFunction<d_gtk_disable_setlocale>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_disable_setlocale"));

		public static void DisableSetlocale() {
			gtk_disable_setlocale();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_distribute_natural_allocation(int extra_space, uint n_requested_sizes, IntPtr sizes);
		static d_gtk_distribute_natural_allocation gtk_distribute_natural_allocation = FuncLoader.LoadFunction<d_gtk_distribute_natural_allocation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_distribute_natural_allocation"));

		public static int DistributeNaturalAllocation(int extra_space, uint n_requested_sizes, Gtk.RequestedSize sizes) {
			IntPtr native_sizes = GLib.Marshaller.StructureToPtrAlloc (sizes);
			int raw_ret = gtk_distribute_natural_allocation(extra_space, n_requested_sizes, native_sizes);
			int ret = raw_ret;
			Marshal.FreeHGlobal (native_sizes);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_draw_insertion_cursor(IntPtr widget, IntPtr cr, IntPtr location, bool is_primary, int direction, bool draw_arrow);
		static d_gtk_draw_insertion_cursor gtk_draw_insertion_cursor = FuncLoader.LoadFunction<d_gtk_draw_insertion_cursor>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_draw_insertion_cursor"));

		[Obsolete]
		public static void DrawInsertionCursor(Gtk.Widget widget, Cairo.Context cr, Gdk.Rectangle location, bool is_primary, Gtk.TextDirection direction, bool draw_arrow) {
			IntPtr native_location = GLib.Marshaller.StructureToPtrAlloc (location);
			gtk_draw_insertion_cursor(widget == null ? IntPtr.Zero : widget.Handle, cr == null ? IntPtr.Zero : cr.Handle, native_location, is_primary, (int) direction, draw_arrow);
			Marshal.FreeHGlobal (native_location);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_events_pending();
		static d_gtk_events_pending gtk_events_pending = FuncLoader.LoadFunction<d_gtk_events_pending>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_events_pending"));

		public static bool EventsPending { 
			get {
				bool raw_ret = gtk_events_pending();
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gtk_get_binary_age();
		static d_gtk_get_binary_age gtk_get_binary_age = FuncLoader.LoadFunction<d_gtk_get_binary_age>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_get_binary_age"));

		public static uint BinaryAge { 
			get {
				uint raw_ret = gtk_get_binary_age();
				uint ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_get_current_event();
		static d_gtk_get_current_event gtk_get_current_event = FuncLoader.LoadFunction<d_gtk_get_current_event>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_get_current_event"));

		public static Gdk.Event CurrentEvent { 
			get {
				IntPtr raw_ret = gtk_get_current_event();
				Gdk.Event ret = Gdk.Event.GetEvent (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_get_current_event_device();
		static d_gtk_get_current_event_device gtk_get_current_event_device = FuncLoader.LoadFunction<d_gtk_get_current_event_device>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_get_current_event_device"));

		public static Gdk.Device CurrentEventDevice { 
			get {
				IntPtr raw_ret = gtk_get_current_event_device();
				Gdk.Device ret = GLib.Object.GetObject(raw_ret) as Gdk.Device;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_get_current_event_state(out int state);
		static d_gtk_get_current_event_state gtk_get_current_event_state = FuncLoader.LoadFunction<d_gtk_get_current_event_state>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_get_current_event_state"));

		public static bool GetCurrentEventState(out Gdk.ModifierType state) {
			int native_state;
			bool raw_ret = gtk_get_current_event_state(out native_state);
			bool ret = raw_ret;
			state = (Gdk.ModifierType) native_state;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gtk_get_current_event_time();
		static d_gtk_get_current_event_time gtk_get_current_event_time = FuncLoader.LoadFunction<d_gtk_get_current_event_time>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_get_current_event_time"));

		public static uint CurrentEventTime { 
			get {
				uint raw_ret = gtk_get_current_event_time();
				uint ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gtk_get_debug_flags();
		static d_gtk_get_debug_flags gtk_get_debug_flags = FuncLoader.LoadFunction<d_gtk_get_debug_flags>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_get_debug_flags"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_set_debug_flags(uint flags);
		static d_gtk_set_debug_flags gtk_set_debug_flags = FuncLoader.LoadFunction<d_gtk_set_debug_flags>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_set_debug_flags"));

		public static uint DebugFlags { 
			get {
				uint raw_ret = gtk_get_debug_flags();
				uint ret = raw_ret;
				return ret;
			}
			set {
				gtk_set_debug_flags(value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_get_default_language();
		static d_gtk_get_default_language gtk_get_default_language = FuncLoader.LoadFunction<d_gtk_get_default_language>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_get_default_language"));

		public static Pango.Language DefaultLanguage { 
			get {
				IntPtr raw_ret = gtk_get_default_language();
				Pango.Language ret = raw_ret == IntPtr.Zero ? null : (Pango.Language) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.Language), false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_get_event_widget(IntPtr evnt);
		static d_gtk_get_event_widget gtk_get_event_widget = FuncLoader.LoadFunction<d_gtk_get_event_widget>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_get_event_widget"));

		public static Gtk.Widget GetEventWidget(Gdk.Event evnt) {
			IntPtr raw_ret = gtk_get_event_widget(evnt == null ? IntPtr.Zero : evnt.Handle);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gtk_get_interface_age();
		static d_gtk_get_interface_age gtk_get_interface_age = FuncLoader.LoadFunction<d_gtk_get_interface_age>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_get_interface_age"));

		public static uint InterfaceAge { 
			get {
				uint raw_ret = gtk_get_interface_age();
				uint ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_get_locale_direction();
		static d_gtk_get_locale_direction gtk_get_locale_direction = FuncLoader.LoadFunction<d_gtk_get_locale_direction>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_get_locale_direction"));

		public static Gtk.TextDirection LocaleDirection { 
			get {
				int raw_ret = gtk_get_locale_direction();
				Gtk.TextDirection ret = (Gtk.TextDirection) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gtk_get_major_version();
		static d_gtk_get_major_version gtk_get_major_version = FuncLoader.LoadFunction<d_gtk_get_major_version>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_get_major_version"));

		public static uint MajorVersion { 
			get {
				uint raw_ret = gtk_get_major_version();
				uint ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gtk_get_micro_version();
		static d_gtk_get_micro_version gtk_get_micro_version = FuncLoader.LoadFunction<d_gtk_get_micro_version>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_get_micro_version"));

		public static uint MicroVersion { 
			get {
				uint raw_ret = gtk_get_micro_version();
				uint ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gtk_get_minor_version();
		static d_gtk_get_minor_version gtk_get_minor_version = FuncLoader.LoadFunction<d_gtk_get_minor_version>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_get_minor_version"));

		public static uint MinorVersion { 
			get {
				uint raw_ret = gtk_get_minor_version();
				uint ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_normalise_detailed_action_name(IntPtr detailed_action_name);
		static d_gtk_normalise_detailed_action_name gtk_normalise_detailed_action_name = FuncLoader.LoadFunction<d_gtk_normalise_detailed_action_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_normalise_detailed_action_name"));

		public static string NormaliseDetailedActionName(string detailed_action_name) {
			IntPtr native_detailed_action_name = GLib.Marshaller.StringToPtrGStrdup (detailed_action_name);
			IntPtr raw_ret = gtk_normalise_detailed_action_name(native_detailed_action_name);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_detailed_action_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_parse_args(out int argc, IntPtr argv);
		static d_gtk_parse_args gtk_parse_args = FuncLoader.LoadFunction<d_gtk_parse_args>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_parse_args"));

		public static bool ParseArgs(out int argc, string argv) {
			bool raw_ret = gtk_parse_args(out argc, GLib.Marshaller.StringToPtrGStrdup(argv));
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_propagate_event(IntPtr widget, IntPtr evnt);
		static d_gtk_propagate_event gtk_propagate_event = FuncLoader.LoadFunction<d_gtk_propagate_event>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_propagate_event"));

		public static void PropagateEvent(Gtk.Widget widget, Gdk.Event evnt) {
			gtk_propagate_event(widget == null ? IntPtr.Zero : widget.Handle, evnt == null ? IntPtr.Zero : evnt.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_rgb_to_hsv(double r, double g, double b, out double h, out double s, out double v);
		static d_gtk_rgb_to_hsv gtk_rgb_to_hsv = FuncLoader.LoadFunction<d_gtk_rgb_to_hsv>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_rgb_to_hsv"));

		public static void RgbToHsv(double r, double g, double b, out double h, out double s, out double v) {
			gtk_rgb_to_hsv(r, g, b, out h, out s, out v);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_show_uri(IntPtr screen, IntPtr uri, uint timestamp, out IntPtr error);
		static d_gtk_show_uri gtk_show_uri = FuncLoader.LoadFunction<d_gtk_show_uri>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_show_uri"));

		public static unsafe bool ShowUri(Gdk.Screen screen, string uri, uint timestamp) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_show_uri(screen == null ? IntPtr.Zero : screen.Handle, native_uri, timestamp, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_show_uri_on_window(IntPtr parent, IntPtr uri, uint timestamp, out IntPtr error);
		static d_gtk_show_uri_on_window gtk_show_uri_on_window = FuncLoader.LoadFunction<d_gtk_show_uri_on_window>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_show_uri_on_window"));

		public static unsafe bool ShowUriOnWindow(Gtk.Window parent, string uri, uint timestamp) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_show_uri_on_window(parent == null ? IntPtr.Zero : parent.Handle, native_uri, timestamp, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_bindings_activate(IntPtr objekt, uint keyval, int modifiers);
		static d_gtk_bindings_activate gtk_bindings_activate = FuncLoader.LoadFunction<d_gtk_bindings_activate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_bindings_activate"));

		public static bool BindingsActivate(GLib.Object objekt, uint keyval, Gdk.ModifierType modifiers) {
			bool raw_ret = gtk_bindings_activate(objekt == null ? IntPtr.Zero : objekt.Handle, keyval, (int) modifiers);
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}