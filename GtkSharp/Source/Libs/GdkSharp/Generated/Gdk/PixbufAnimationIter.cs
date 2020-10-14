// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class PixbufAnimationIter : GLib.Object {

		public PixbufAnimationIter (IntPtr raw) : base(raw) {}

		protected PixbufAnimationIter() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_pixbuf_animation_iter_advance(IntPtr raw, IntPtr current_time);
		static d_gdk_pixbuf_animation_iter_advance gdk_pixbuf_animation_iter_advance = FuncLoader.LoadFunction<d_gdk_pixbuf_animation_iter_advance>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_animation_iter_advance"));

		public bool Advance(IntPtr current_time) {
			bool raw_ret = gdk_pixbuf_animation_iter_advance(Handle, current_time);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gdk_pixbuf_animation_iter_get_delay_time(IntPtr raw);
		static d_gdk_pixbuf_animation_iter_get_delay_time gdk_pixbuf_animation_iter_get_delay_time = FuncLoader.LoadFunction<d_gdk_pixbuf_animation_iter_get_delay_time>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_animation_iter_get_delay_time"));

		public int DelayTime { 
			get {
				int raw_ret = gdk_pixbuf_animation_iter_get_delay_time(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_pixbuf_animation_iter_get_pixbuf(IntPtr raw);
		static d_gdk_pixbuf_animation_iter_get_pixbuf gdk_pixbuf_animation_iter_get_pixbuf = FuncLoader.LoadFunction<d_gdk_pixbuf_animation_iter_get_pixbuf>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_animation_iter_get_pixbuf"));

		public Gdk.Pixbuf Pixbuf { 
			get {
				IntPtr raw_ret = gdk_pixbuf_animation_iter_get_pixbuf(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_pixbuf_animation_iter_get_type();
		static d_gdk_pixbuf_animation_iter_get_type gdk_pixbuf_animation_iter_get_type = FuncLoader.LoadFunction<d_gdk_pixbuf_animation_iter_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_animation_iter_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_pixbuf_animation_iter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_pixbuf_animation_iter_on_currently_loading_frame(IntPtr raw);
		static d_gdk_pixbuf_animation_iter_on_currently_loading_frame gdk_pixbuf_animation_iter_on_currently_loading_frame = FuncLoader.LoadFunction<d_gdk_pixbuf_animation_iter_on_currently_loading_frame>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_animation_iter_on_currently_loading_frame"));

		public bool OnCurrentlyLoadingFrame() {
			bool raw_ret = gdk_pixbuf_animation_iter_on_currently_loading_frame(Handle);
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}