// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Drag {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_drag_begin(IntPtr widget, IntPtr targets, int actions, int button, IntPtr evnt);
		static d_gtk_drag_begin gtk_drag_begin = FuncLoader.LoadFunction<d_gtk_drag_begin>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_begin"));

		[Obsolete]
		public static Gdk.DragContext Begin(Gtk.Widget widget, Gtk.TargetList targets, Gdk.DragAction actions, int button, Gdk.Event evnt) {
			IntPtr raw_ret = gtk_drag_begin(widget == null ? IntPtr.Zero : widget.Handle, targets == null ? IntPtr.Zero : targets.Handle, (int) actions, button, evnt == null ? IntPtr.Zero : evnt.Handle);
			Gdk.DragContext ret = GLib.Object.GetObject(raw_ret) as Gdk.DragContext;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_drag_begin_with_coordinates(IntPtr widget, IntPtr targets, int actions, int button, IntPtr evnt, int x, int y);
		static d_gtk_drag_begin_with_coordinates gtk_drag_begin_with_coordinates = FuncLoader.LoadFunction<d_gtk_drag_begin_with_coordinates>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_begin_with_coordinates"));

		public static Gdk.DragContext BeginWithCoordinates(Gtk.Widget widget, Gtk.TargetList targets, Gdk.DragAction actions, int button, Gdk.Event evnt, int x, int y) {
			IntPtr raw_ret = gtk_drag_begin_with_coordinates(widget == null ? IntPtr.Zero : widget.Handle, targets == null ? IntPtr.Zero : targets.Handle, (int) actions, button, evnt == null ? IntPtr.Zero : evnt.Handle, x, y);
			Gdk.DragContext ret = GLib.Object.GetObject(raw_ret) as Gdk.DragContext;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_cancel(IntPtr context);
		static d_gtk_drag_cancel gtk_drag_cancel = FuncLoader.LoadFunction<d_gtk_drag_cancel>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_cancel"));

		public static void Cancel(Gdk.DragContext context) {
			gtk_drag_cancel(context == null ? IntPtr.Zero : context.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_drag_check_threshold(IntPtr widget, int start_x, int start_y, int current_x, int current_y);
		static d_gtk_drag_check_threshold gtk_drag_check_threshold = FuncLoader.LoadFunction<d_gtk_drag_check_threshold>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_check_threshold"));

		public static bool CheckThreshold(Gtk.Widget widget, int start_x, int start_y, int current_x, int current_y) {
			bool raw_ret = gtk_drag_check_threshold(widget == null ? IntPtr.Zero : widget.Handle, start_x, start_y, current_x, current_y);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_dest_add_image_targets(IntPtr widget);
		static d_gtk_drag_dest_add_image_targets gtk_drag_dest_add_image_targets = FuncLoader.LoadFunction<d_gtk_drag_dest_add_image_targets>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_dest_add_image_targets"));

		public static void DestAddImageTargets(Gtk.Widget widget) {
			gtk_drag_dest_add_image_targets(widget == null ? IntPtr.Zero : widget.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_dest_add_text_targets(IntPtr widget);
		static d_gtk_drag_dest_add_text_targets gtk_drag_dest_add_text_targets = FuncLoader.LoadFunction<d_gtk_drag_dest_add_text_targets>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_dest_add_text_targets"));

		public static void DestAddTextTargets(Gtk.Widget widget) {
			gtk_drag_dest_add_text_targets(widget == null ? IntPtr.Zero : widget.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_dest_add_uri_targets(IntPtr widget);
		static d_gtk_drag_dest_add_uri_targets gtk_drag_dest_add_uri_targets = FuncLoader.LoadFunction<d_gtk_drag_dest_add_uri_targets>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_dest_add_uri_targets"));

		public static void DestAddUriTargets(Gtk.Widget widget) {
			gtk_drag_dest_add_uri_targets(widget == null ? IntPtr.Zero : widget.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_drag_dest_find_target(IntPtr widget, IntPtr context, IntPtr target_list);
		static d_gtk_drag_dest_find_target gtk_drag_dest_find_target = FuncLoader.LoadFunction<d_gtk_drag_dest_find_target>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_dest_find_target"));

		public static Gdk.Atom DestFindTarget(Gtk.Widget widget, Gdk.DragContext context, Gtk.TargetList target_list) {
			IntPtr raw_ret = gtk_drag_dest_find_target(widget == null ? IntPtr.Zero : widget.Handle, context == null ? IntPtr.Zero : context.Handle, target_list == null ? IntPtr.Zero : target_list.Handle);
			Gdk.Atom ret = raw_ret == IntPtr.Zero ? null : (Gdk.Atom) GLib.Opaque.GetOpaque (raw_ret, typeof (Gdk.Atom), false);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_drag_dest_get_target_list(IntPtr widget);
		static d_gtk_drag_dest_get_target_list gtk_drag_dest_get_target_list = FuncLoader.LoadFunction<d_gtk_drag_dest_get_target_list>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_dest_get_target_list"));

		public static Gtk.TargetList DestGetTargetList(Gtk.Widget widget) {
			IntPtr raw_ret = gtk_drag_dest_get_target_list(widget == null ? IntPtr.Zero : widget.Handle);
			Gtk.TargetList ret = raw_ret == IntPtr.Zero ? null : (Gtk.TargetList) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.TargetList), false);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_drag_dest_get_track_motion(IntPtr widget);
		static d_gtk_drag_dest_get_track_motion gtk_drag_dest_get_track_motion = FuncLoader.LoadFunction<d_gtk_drag_dest_get_track_motion>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_dest_get_track_motion"));

		public static bool DestGetTrackMotion(Gtk.Widget widget) {
			bool raw_ret = gtk_drag_dest_get_track_motion(widget == null ? IntPtr.Zero : widget.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_dest_set(IntPtr widget, int flags, Gtk.TargetEntry[] targets, int n_targets, int actions);
		static d_gtk_drag_dest_set gtk_drag_dest_set = FuncLoader.LoadFunction<d_gtk_drag_dest_set>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_dest_set"));

		public static void DestSet(Gtk.Widget widget, Gtk.DestDefaults flags, Gtk.TargetEntry[] targets, Gdk.DragAction actions) {
			gtk_drag_dest_set(widget == null ? IntPtr.Zero : widget.Handle, (int) flags, targets, (targets == null ? 0 : targets.Length), (int) actions);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_dest_set_proxy(IntPtr widget, IntPtr proxy_window, int protocol, bool use_coordinates);
		static d_gtk_drag_dest_set_proxy gtk_drag_dest_set_proxy = FuncLoader.LoadFunction<d_gtk_drag_dest_set_proxy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_dest_set_proxy"));

		[Obsolete]
		public static void DestSetProxy(Gtk.Widget widget, Gdk.Window proxy_window, Gdk.DragProtocol protocol, bool use_coordinates) {
			gtk_drag_dest_set_proxy(widget == null ? IntPtr.Zero : widget.Handle, proxy_window == null ? IntPtr.Zero : proxy_window.Handle, (int) protocol, use_coordinates);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_dest_set_target_list(IntPtr widget, IntPtr target_list);
		static d_gtk_drag_dest_set_target_list gtk_drag_dest_set_target_list = FuncLoader.LoadFunction<d_gtk_drag_dest_set_target_list>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_dest_set_target_list"));

		public static void DestSetTargetList(Gtk.Widget widget, Gtk.TargetList target_list) {
			gtk_drag_dest_set_target_list(widget == null ? IntPtr.Zero : widget.Handle, target_list == null ? IntPtr.Zero : target_list.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_dest_set_track_motion(IntPtr widget, bool track_motion);
		static d_gtk_drag_dest_set_track_motion gtk_drag_dest_set_track_motion = FuncLoader.LoadFunction<d_gtk_drag_dest_set_track_motion>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_dest_set_track_motion"));

		public static void DestSetTrackMotion(Gtk.Widget widget, bool track_motion) {
			gtk_drag_dest_set_track_motion(widget == null ? IntPtr.Zero : widget.Handle, track_motion);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_dest_unset(IntPtr widget);
		static d_gtk_drag_dest_unset gtk_drag_dest_unset = FuncLoader.LoadFunction<d_gtk_drag_dest_unset>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_dest_unset"));

		public static void DestUnset(Gtk.Widget widget) {
			gtk_drag_dest_unset(widget == null ? IntPtr.Zero : widget.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_finish(IntPtr context, bool success, bool del, uint time_);
		static d_gtk_drag_finish gtk_drag_finish = FuncLoader.LoadFunction<d_gtk_drag_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_finish"));

		public static void Finish(Gdk.DragContext context, bool success, bool del, uint time_) {
			gtk_drag_finish(context == null ? IntPtr.Zero : context.Handle, success, del, time_);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_get_data(IntPtr widget, IntPtr context, IntPtr target, uint time_);
		static d_gtk_drag_get_data gtk_drag_get_data = FuncLoader.LoadFunction<d_gtk_drag_get_data>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_get_data"));

		public static void GetData(Gtk.Widget widget, Gdk.DragContext context, Gdk.Atom target, uint time_) {
			gtk_drag_get_data(widget == null ? IntPtr.Zero : widget.Handle, context == null ? IntPtr.Zero : context.Handle, target == null ? IntPtr.Zero : target.Handle, time_);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_drag_get_source_widget(IntPtr context);
		static d_gtk_drag_get_source_widget gtk_drag_get_source_widget = FuncLoader.LoadFunction<d_gtk_drag_get_source_widget>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_get_source_widget"));

		public static Gtk.Widget GetSourceWidget(Gdk.DragContext context) {
			IntPtr raw_ret = gtk_drag_get_source_widget(context == null ? IntPtr.Zero : context.Handle);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_highlight(IntPtr widget);
		static d_gtk_drag_highlight gtk_drag_highlight = FuncLoader.LoadFunction<d_gtk_drag_highlight>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_highlight"));

		public static void Highlight(Gtk.Widget widget) {
			gtk_drag_highlight(widget == null ? IntPtr.Zero : widget.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_set_icon_gicon(IntPtr context, IntPtr icon, int hot_x, int hot_y);
		static d_gtk_drag_set_icon_gicon gtk_drag_set_icon_gicon = FuncLoader.LoadFunction<d_gtk_drag_set_icon_gicon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_set_icon_gicon"));

		public static void SetIconGicon(Gdk.DragContext context, GLib.IIcon icon, int hot_x, int hot_y) {
			gtk_drag_set_icon_gicon(context == null ? IntPtr.Zero : context.Handle, icon == null ? IntPtr.Zero : ((icon is GLib.Object) ? (icon as GLib.Object).Handle : (icon as GLib.IconAdapter).Handle), hot_x, hot_y);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_set_icon_name(IntPtr context, IntPtr icon_name, int hot_x, int hot_y);
		static d_gtk_drag_set_icon_name gtk_drag_set_icon_name = FuncLoader.LoadFunction<d_gtk_drag_set_icon_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_set_icon_name"));

		public static void SetIconName(Gdk.DragContext context, string icon_name, int hot_x, int hot_y) {
			IntPtr native_icon_name = GLib.Marshaller.StringToPtrGStrdup (icon_name);
			gtk_drag_set_icon_name(context == null ? IntPtr.Zero : context.Handle, native_icon_name, hot_x, hot_y);
			GLib.Marshaller.Free (native_icon_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_set_icon_pixbuf(IntPtr context, IntPtr pixbuf, int hot_x, int hot_y);
		static d_gtk_drag_set_icon_pixbuf gtk_drag_set_icon_pixbuf = FuncLoader.LoadFunction<d_gtk_drag_set_icon_pixbuf>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_set_icon_pixbuf"));

		public static void SetIconPixbuf(Gdk.DragContext context, Gdk.Pixbuf pixbuf, int hot_x, int hot_y) {
			gtk_drag_set_icon_pixbuf(context == null ? IntPtr.Zero : context.Handle, pixbuf == null ? IntPtr.Zero : pixbuf.Handle, hot_x, hot_y);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_set_icon_stock(IntPtr context, IntPtr stock_id, int hot_x, int hot_y);
		static d_gtk_drag_set_icon_stock gtk_drag_set_icon_stock = FuncLoader.LoadFunction<d_gtk_drag_set_icon_stock>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_set_icon_stock"));

		[Obsolete]
		public static void SetIconStock(Gdk.DragContext context, string stock_id, int hot_x, int hot_y) {
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			gtk_drag_set_icon_stock(context == null ? IntPtr.Zero : context.Handle, native_stock_id, hot_x, hot_y);
			GLib.Marshaller.Free (native_stock_id);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_set_icon_surface(IntPtr context, IntPtr surface);
		static d_gtk_drag_set_icon_surface gtk_drag_set_icon_surface = FuncLoader.LoadFunction<d_gtk_drag_set_icon_surface>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_set_icon_surface"));

		public static void SetIconSurface(Gdk.DragContext context, Cairo.Surface surface) {
			gtk_drag_set_icon_surface(context == null ? IntPtr.Zero : context.Handle, surface.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_set_icon_widget(IntPtr context, IntPtr widget, int hot_x, int hot_y);
		static d_gtk_drag_set_icon_widget gtk_drag_set_icon_widget = FuncLoader.LoadFunction<d_gtk_drag_set_icon_widget>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_set_icon_widget"));

		public static void SetIconWidget(Gdk.DragContext context, Gtk.Widget widget, int hot_x, int hot_y) {
			gtk_drag_set_icon_widget(context == null ? IntPtr.Zero : context.Handle, widget == null ? IntPtr.Zero : widget.Handle, hot_x, hot_y);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_source_add_image_targets(IntPtr widget);
		static d_gtk_drag_source_add_image_targets gtk_drag_source_add_image_targets = FuncLoader.LoadFunction<d_gtk_drag_source_add_image_targets>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_source_add_image_targets"));

		public static void SourceAddImageTargets(Gtk.Widget widget) {
			gtk_drag_source_add_image_targets(widget == null ? IntPtr.Zero : widget.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_source_add_text_targets(IntPtr widget);
		static d_gtk_drag_source_add_text_targets gtk_drag_source_add_text_targets = FuncLoader.LoadFunction<d_gtk_drag_source_add_text_targets>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_source_add_text_targets"));

		public static void SourceAddTextTargets(Gtk.Widget widget) {
			gtk_drag_source_add_text_targets(widget == null ? IntPtr.Zero : widget.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_source_add_uri_targets(IntPtr widget);
		static d_gtk_drag_source_add_uri_targets gtk_drag_source_add_uri_targets = FuncLoader.LoadFunction<d_gtk_drag_source_add_uri_targets>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_source_add_uri_targets"));

		public static void SourceAddUriTargets(Gtk.Widget widget) {
			gtk_drag_source_add_uri_targets(widget == null ? IntPtr.Zero : widget.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_drag_source_get_target_list(IntPtr widget);
		static d_gtk_drag_source_get_target_list gtk_drag_source_get_target_list = FuncLoader.LoadFunction<d_gtk_drag_source_get_target_list>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_source_get_target_list"));

		public static Gtk.TargetList SourceGetTargetList(Gtk.Widget widget) {
			IntPtr raw_ret = gtk_drag_source_get_target_list(widget == null ? IntPtr.Zero : widget.Handle);
			Gtk.TargetList ret = raw_ret == IntPtr.Zero ? null : (Gtk.TargetList) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.TargetList), false);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_source_set(IntPtr widget, int start_button_mask, Gtk.TargetEntry[] targets, int n_targets, int actions);
		static d_gtk_drag_source_set gtk_drag_source_set = FuncLoader.LoadFunction<d_gtk_drag_source_set>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_source_set"));

		public static void SourceSet(Gtk.Widget widget, Gdk.ModifierType start_button_mask, Gtk.TargetEntry[] targets, Gdk.DragAction actions) {
			gtk_drag_source_set(widget == null ? IntPtr.Zero : widget.Handle, (int) start_button_mask, targets, (targets == null ? 0 : targets.Length), (int) actions);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_source_set_icon_gicon(IntPtr widget, IntPtr icon);
		static d_gtk_drag_source_set_icon_gicon gtk_drag_source_set_icon_gicon = FuncLoader.LoadFunction<d_gtk_drag_source_set_icon_gicon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_source_set_icon_gicon"));

		public static void SourceSetIconGicon(Gtk.Widget widget, GLib.IIcon icon) {
			gtk_drag_source_set_icon_gicon(widget == null ? IntPtr.Zero : widget.Handle, icon == null ? IntPtr.Zero : ((icon is GLib.Object) ? (icon as GLib.Object).Handle : (icon as GLib.IconAdapter).Handle));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_source_set_icon_name(IntPtr widget, IntPtr icon_name);
		static d_gtk_drag_source_set_icon_name gtk_drag_source_set_icon_name = FuncLoader.LoadFunction<d_gtk_drag_source_set_icon_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_source_set_icon_name"));

		public static void SourceSetIconName(Gtk.Widget widget, string icon_name) {
			IntPtr native_icon_name = GLib.Marshaller.StringToPtrGStrdup (icon_name);
			gtk_drag_source_set_icon_name(widget == null ? IntPtr.Zero : widget.Handle, native_icon_name);
			GLib.Marshaller.Free (native_icon_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_source_set_icon_pixbuf(IntPtr widget, IntPtr pixbuf);
		static d_gtk_drag_source_set_icon_pixbuf gtk_drag_source_set_icon_pixbuf = FuncLoader.LoadFunction<d_gtk_drag_source_set_icon_pixbuf>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_source_set_icon_pixbuf"));

		public static void SourceSetIconPixbuf(Gtk.Widget widget, Gdk.Pixbuf pixbuf) {
			gtk_drag_source_set_icon_pixbuf(widget == null ? IntPtr.Zero : widget.Handle, pixbuf == null ? IntPtr.Zero : pixbuf.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_source_set_icon_stock(IntPtr widget, IntPtr stock_id);
		static d_gtk_drag_source_set_icon_stock gtk_drag_source_set_icon_stock = FuncLoader.LoadFunction<d_gtk_drag_source_set_icon_stock>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_source_set_icon_stock"));

		[Obsolete]
		public static void SourceSetIconStock(Gtk.Widget widget, string stock_id) {
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			gtk_drag_source_set_icon_stock(widget == null ? IntPtr.Zero : widget.Handle, native_stock_id);
			GLib.Marshaller.Free (native_stock_id);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_source_set_target_list(IntPtr widget, IntPtr target_list);
		static d_gtk_drag_source_set_target_list gtk_drag_source_set_target_list = FuncLoader.LoadFunction<d_gtk_drag_source_set_target_list>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_source_set_target_list"));

		public static void SourceSetTargetList(Gtk.Widget widget, Gtk.TargetList target_list) {
			gtk_drag_source_set_target_list(widget == null ? IntPtr.Zero : widget.Handle, target_list == null ? IntPtr.Zero : target_list.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_source_unset(IntPtr widget);
		static d_gtk_drag_source_unset gtk_drag_source_unset = FuncLoader.LoadFunction<d_gtk_drag_source_unset>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_source_unset"));

		public static void SourceUnset(Gtk.Widget widget) {
			gtk_drag_source_unset(widget == null ? IntPtr.Zero : widget.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_drag_unhighlight(IntPtr widget);
		static d_gtk_drag_unhighlight gtk_drag_unhighlight = FuncLoader.LoadFunction<d_gtk_drag_unhighlight>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_drag_unhighlight"));

		public static void Unhighlight(Gtk.Widget widget) {
			gtk_drag_unhighlight(widget == null ? IntPtr.Zero : widget.Handle);
		}

#endregion
	}
}
