// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class EventHelper {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_event_copy(IntPtr evnt);
		static d_gdk_event_copy gdk_event_copy = FuncLoader.LoadFunction<d_gdk_event_copy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_copy"));

		public static Gdk.Event Copy(Gdk.Event evnt) {
			IntPtr raw_ret = gdk_event_copy(evnt == null ? IntPtr.Zero : evnt.Handle);
			Gdk.Event ret = Gdk.Event.GetEvent (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_event_free(IntPtr evnt);
		static d_gdk_event_free gdk_event_free = FuncLoader.LoadFunction<d_gdk_event_free>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_free"));

		public static void Free(Gdk.Event evnt) {
			gdk_event_free(evnt == null ? IntPtr.Zero : evnt.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_event_get();
		static d_gdk_event_get gdk_event_get = FuncLoader.LoadFunction<d_gdk_event_get>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get"));

		public static Gdk.Event Get() {
			IntPtr raw_ret = gdk_event_get();
			Gdk.Event ret = Gdk.Event.GetEvent (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_event_get_axis(IntPtr evnt, int axis_use, out double value);
		static d_gdk_event_get_axis gdk_event_get_axis = FuncLoader.LoadFunction<d_gdk_event_get_axis>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_axis"));

		public static bool GetAxis(Gdk.Event evnt, Gdk.AxisUse axis_use, out double value) {
			bool raw_ret = gdk_event_get_axis(evnt == null ? IntPtr.Zero : evnt.Handle, (int) axis_use, out value);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_event_get_button(IntPtr evnt, out uint button);
		static d_gdk_event_get_button gdk_event_get_button = FuncLoader.LoadFunction<d_gdk_event_get_button>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_button"));

		public static bool GetButton(Gdk.Event evnt, out uint button) {
			bool raw_ret = gdk_event_get_button(evnt == null ? IntPtr.Zero : evnt.Handle, out button);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_event_get_click_count(IntPtr evnt, out uint click_count);
		static d_gdk_event_get_click_count gdk_event_get_click_count = FuncLoader.LoadFunction<d_gdk_event_get_click_count>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_click_count"));

		public static bool GetClickCount(Gdk.Event evnt, out uint click_count) {
			bool raw_ret = gdk_event_get_click_count(evnt == null ? IntPtr.Zero : evnt.Handle, out click_count);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_event_get_coords(IntPtr evnt, out double x_win, out double y_win);
		static d_gdk_event_get_coords gdk_event_get_coords = FuncLoader.LoadFunction<d_gdk_event_get_coords>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_coords"));

		public static bool GetCoords(Gdk.Event evnt, out double x_win, out double y_win) {
			bool raw_ret = gdk_event_get_coords(evnt == null ? IntPtr.Zero : evnt.Handle, out x_win, out y_win);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_event_get_device(IntPtr evnt);
		static d_gdk_event_get_device gdk_event_get_device = FuncLoader.LoadFunction<d_gdk_event_get_device>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_device"));

		public static Gdk.Device GetDevice(Gdk.Event evnt) {
			IntPtr raw_ret = gdk_event_get_device(evnt == null ? IntPtr.Zero : evnt.Handle);
			Gdk.Device ret = GLib.Object.GetObject(raw_ret) as Gdk.Device;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_event_get_device_tool(IntPtr evnt);
		static d_gdk_event_get_device_tool gdk_event_get_device_tool = FuncLoader.LoadFunction<d_gdk_event_get_device_tool>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_device_tool"));

		public static Gdk.DeviceTool GetDeviceTool(Gdk.Event evnt) {
			IntPtr raw_ret = gdk_event_get_device_tool(evnt == null ? IntPtr.Zero : evnt.Handle);
			Gdk.DeviceTool ret = GLib.Object.GetObject(raw_ret) as Gdk.DeviceTool;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_event_get_event_sequence(IntPtr evnt);
		static d_gdk_event_get_event_sequence gdk_event_get_event_sequence = FuncLoader.LoadFunction<d_gdk_event_get_event_sequence>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_event_sequence"));

		public static Gdk.EventSequence GetEventSequence(Gdk.Event evnt) {
			IntPtr raw_ret = gdk_event_get_event_sequence(evnt == null ? IntPtr.Zero : evnt.Handle);
			Gdk.EventSequence ret = raw_ret == IntPtr.Zero ? null : (Gdk.EventSequence) GLib.Opaque.GetOpaque (raw_ret, typeof (Gdk.EventSequence), false);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gdk_event_get_event_type(IntPtr evnt);
		static d_gdk_event_get_event_type gdk_event_get_event_type = FuncLoader.LoadFunction<d_gdk_event_get_event_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_event_type"));

		public static Gdk.EventType GetEventType(Gdk.Event evnt) {
			int raw_ret = gdk_event_get_event_type(evnt == null ? IntPtr.Zero : evnt.Handle);
			Gdk.EventType ret = (Gdk.EventType) raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_event_get_keycode(IntPtr evnt, out ushort keycode);
		static d_gdk_event_get_keycode gdk_event_get_keycode = FuncLoader.LoadFunction<d_gdk_event_get_keycode>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_keycode"));

		public static bool GetKeycode(Gdk.Event evnt, out ushort keycode) {
			bool raw_ret = gdk_event_get_keycode(evnt == null ? IntPtr.Zero : evnt.Handle, out keycode);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_event_get_keyval(IntPtr evnt, out uint keyval);
		static d_gdk_event_get_keyval gdk_event_get_keyval = FuncLoader.LoadFunction<d_gdk_event_get_keyval>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_keyval"));

		public static bool GetKeyval(Gdk.Event evnt, out uint keyval) {
			bool raw_ret = gdk_event_get_keyval(evnt == null ? IntPtr.Zero : evnt.Handle, out keyval);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_event_get_pointer_emulated(IntPtr evnt);
		static d_gdk_event_get_pointer_emulated gdk_event_get_pointer_emulated = FuncLoader.LoadFunction<d_gdk_event_get_pointer_emulated>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_pointer_emulated"));

		public static bool GetPointerEmulated(Gdk.Event evnt) {
			bool raw_ret = gdk_event_get_pointer_emulated(evnt == null ? IntPtr.Zero : evnt.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_event_get_root_coords(IntPtr evnt, out double x_root, out double y_root);
		static d_gdk_event_get_root_coords gdk_event_get_root_coords = FuncLoader.LoadFunction<d_gdk_event_get_root_coords>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_root_coords"));

		public static bool GetRootCoords(Gdk.Event evnt, out double x_root, out double y_root) {
			bool raw_ret = gdk_event_get_root_coords(evnt == null ? IntPtr.Zero : evnt.Handle, out x_root, out y_root);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gdk_event_get_scancode(IntPtr evnt);
		static d_gdk_event_get_scancode gdk_event_get_scancode = FuncLoader.LoadFunction<d_gdk_event_get_scancode>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_scancode"));

		public static int GetScancode(Gdk.Event evnt) {
			int raw_ret = gdk_event_get_scancode(evnt == null ? IntPtr.Zero : evnt.Handle);
			int ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_event_get_screen(IntPtr evnt);
		static d_gdk_event_get_screen gdk_event_get_screen = FuncLoader.LoadFunction<d_gdk_event_get_screen>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_screen"));

		public static Gdk.Screen GetScreen(Gdk.Event evnt) {
			IntPtr raw_ret = gdk_event_get_screen(evnt == null ? IntPtr.Zero : evnt.Handle);
			Gdk.Screen ret = GLib.Object.GetObject(raw_ret) as Gdk.Screen;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_event_get_scroll_deltas(IntPtr evnt, out double delta_x, out double delta_y);
		static d_gdk_event_get_scroll_deltas gdk_event_get_scroll_deltas = FuncLoader.LoadFunction<d_gdk_event_get_scroll_deltas>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_scroll_deltas"));

		public static bool GetScrollDeltas(Gdk.Event evnt, out double delta_x, out double delta_y) {
			bool raw_ret = gdk_event_get_scroll_deltas(evnt == null ? IntPtr.Zero : evnt.Handle, out delta_x, out delta_y);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_event_get_scroll_direction(IntPtr evnt, out int direction);
		static d_gdk_event_get_scroll_direction gdk_event_get_scroll_direction = FuncLoader.LoadFunction<d_gdk_event_get_scroll_direction>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_scroll_direction"));

		public static bool GetScrollDirection(Gdk.Event evnt, out Gdk.ScrollDirection direction) {
			int native_direction;
			bool raw_ret = gdk_event_get_scroll_direction(evnt == null ? IntPtr.Zero : evnt.Handle, out native_direction);
			bool ret = raw_ret;
			direction = (Gdk.ScrollDirection) native_direction;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_event_get_seat(IntPtr evnt);
		static d_gdk_event_get_seat gdk_event_get_seat = FuncLoader.LoadFunction<d_gdk_event_get_seat>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_seat"));

		public static Gdk.Seat GetSeat(Gdk.Event evnt) {
			IntPtr raw_ret = gdk_event_get_seat(evnt == null ? IntPtr.Zero : evnt.Handle);
			Gdk.Seat ret = GLib.Object.GetObject(raw_ret) as Gdk.Seat;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_event_get_source_device(IntPtr evnt);
		static d_gdk_event_get_source_device gdk_event_get_source_device = FuncLoader.LoadFunction<d_gdk_event_get_source_device>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_source_device"));

		public static Gdk.Device GetSourceDevice(Gdk.Event evnt) {
			IntPtr raw_ret = gdk_event_get_source_device(evnt == null ? IntPtr.Zero : evnt.Handle);
			Gdk.Device ret = GLib.Object.GetObject(raw_ret) as Gdk.Device;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_event_get_state(IntPtr evnt, out int state);
		static d_gdk_event_get_state gdk_event_get_state = FuncLoader.LoadFunction<d_gdk_event_get_state>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_state"));

		public static bool GetState(Gdk.Event evnt, out Gdk.ModifierType state) {
			int native_state;
			bool raw_ret = gdk_event_get_state(evnt == null ? IntPtr.Zero : evnt.Handle, out native_state);
			bool ret = raw_ret;
			state = (Gdk.ModifierType) native_state;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gdk_event_get_time(IntPtr evnt);
		static d_gdk_event_get_time gdk_event_get_time = FuncLoader.LoadFunction<d_gdk_event_get_time>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_time"));

		public static uint GetTime(Gdk.Event evnt) {
			uint raw_ret = gdk_event_get_time(evnt == null ? IntPtr.Zero : evnt.Handle);
			uint ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_event_get_type();
		static d_gdk_event_get_type gdk_event_get_type = FuncLoader.LoadFunction<d_gdk_event_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_type"));

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_event_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_event_get_window(IntPtr evnt);
		static d_gdk_event_get_window gdk_event_get_window = FuncLoader.LoadFunction<d_gdk_event_get_window>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_get_window"));

		public static Gdk.Window GetWindow(Gdk.Event evnt) {
			IntPtr raw_ret = gdk_event_get_window(evnt == null ? IntPtr.Zero : evnt.Handle);
			Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_event_is_scroll_stop_event(IntPtr evnt);
		static d_gdk_event_is_scroll_stop_event gdk_event_is_scroll_stop_event = FuncLoader.LoadFunction<d_gdk_event_is_scroll_stop_event>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_is_scroll_stop_event"));

		public static bool IsScrollStopEvent(Gdk.Event evnt) {
			bool raw_ret = gdk_event_is_scroll_stop_event(evnt == null ? IntPtr.Zero : evnt.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_event_new(int type);
		static d_gdk_event_new gdk_event_new = FuncLoader.LoadFunction<d_gdk_event_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_new"));

		public static Gdk.Event New(Gdk.EventType type) {
			IntPtr raw_ret = gdk_event_new((int) type);
			Gdk.Event ret = Gdk.Event.GetEvent (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_event_peek();
		static d_gdk_event_peek gdk_event_peek = FuncLoader.LoadFunction<d_gdk_event_peek>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_peek"));

		public static Gdk.Event Peek() {
			IntPtr raw_ret = gdk_event_peek();
			Gdk.Event ret = Gdk.Event.GetEvent (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_event_put(IntPtr evnt);
		static d_gdk_event_put gdk_event_put = FuncLoader.LoadFunction<d_gdk_event_put>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_put"));

		public static void Put(Gdk.Event evnt) {
			gdk_event_put(evnt == null ? IntPtr.Zero : evnt.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_event_request_motions(IntPtr evnt);
		static d_gdk_event_request_motions gdk_event_request_motions = FuncLoader.LoadFunction<d_gdk_event_request_motions>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_request_motions"));

		public static void RequestMotions(Gdk.EventMotion evnt) {
			gdk_event_request_motions(evnt == null ? IntPtr.Zero : evnt.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_event_set_device(IntPtr evnt, IntPtr device);
		static d_gdk_event_set_device gdk_event_set_device = FuncLoader.LoadFunction<d_gdk_event_set_device>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_set_device"));

		public static void SetDevice(Gdk.Event evnt, Gdk.Device device) {
			gdk_event_set_device(evnt == null ? IntPtr.Zero : evnt.Handle, device == null ? IntPtr.Zero : device.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_event_set_device_tool(IntPtr evnt, IntPtr tool);
		static d_gdk_event_set_device_tool gdk_event_set_device_tool = FuncLoader.LoadFunction<d_gdk_event_set_device_tool>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_set_device_tool"));

		public static void SetDeviceTool(Gdk.Event evnt, Gdk.DeviceTool tool) {
			gdk_event_set_device_tool(evnt == null ? IntPtr.Zero : evnt.Handle, tool == null ? IntPtr.Zero : tool.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_event_set_screen(IntPtr evnt, IntPtr screen);
		static d_gdk_event_set_screen gdk_event_set_screen = FuncLoader.LoadFunction<d_gdk_event_set_screen>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_set_screen"));

		public static void SetScreen(Gdk.Event evnt, Gdk.Screen screen) {
			gdk_event_set_screen(evnt == null ? IntPtr.Zero : evnt.Handle, screen == null ? IntPtr.Zero : screen.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_event_set_source_device(IntPtr evnt, IntPtr device);
		static d_gdk_event_set_source_device gdk_event_set_source_device = FuncLoader.LoadFunction<d_gdk_event_set_source_device>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_set_source_device"));

		public static void SetSourceDevice(Gdk.Event evnt, Gdk.Device device) {
			gdk_event_set_source_device(evnt == null ? IntPtr.Zero : evnt.Handle, device == null ? IntPtr.Zero : device.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_event_triggers_context_menu(IntPtr evnt);
		static d_gdk_event_triggers_context_menu gdk_event_triggers_context_menu = FuncLoader.LoadFunction<d_gdk_event_triggers_context_menu>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_event_triggers_context_menu"));

		public static bool TriggersContextMenu(Gdk.Event evnt) {
			bool raw_ret = gdk_event_triggers_context_menu(evnt == null ? IntPtr.Zero : evnt.Handle);
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}
