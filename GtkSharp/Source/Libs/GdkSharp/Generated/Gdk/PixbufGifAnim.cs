// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class PixbufGifAnim : Gdk.PixbufAnimation {

		public PixbufGifAnim (IntPtr raw) : base(raw) {}

		protected PixbufGifAnim() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_pixbuf_gif_anim_frame_composite(IntPtr raw, IntPtr frame);
		static d_gdk_pixbuf_gif_anim_frame_composite gdk_pixbuf_gif_anim_frame_composite = FuncLoader.LoadFunction<d_gdk_pixbuf_gif_anim_frame_composite>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_gif_anim_frame_composite"));

		public void FrameComposite(Gdk.PixbufFrame frame) {
			IntPtr native_frame = GLib.Marshaller.StructureToPtrAlloc (frame);
			gdk_pixbuf_gif_anim_frame_composite(Handle, native_frame);
			Marshal.FreeHGlobal (native_frame);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_pixbuf_gif_anim_get_type();
		static d_gdk_pixbuf_gif_anim_get_type gdk_pixbuf_gif_anim_get_type = FuncLoader.LoadFunction<d_gdk_pixbuf_gif_anim_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GdkPixbuf), "gdk_pixbuf_gif_anim_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_pixbuf_gif_anim_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
