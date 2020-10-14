// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Visual : GLib.Object {

		public Visual (IntPtr raw) : base(raw) {}

		protected Visual() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
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
		delegate IntPtr d_gdk_visual_get_best();
		static d_gdk_visual_get_best gdk_visual_get_best = FuncLoader.LoadFunction<d_gdk_visual_get_best>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_best"));

		[Obsolete]
		public static Gdk.Visual Best { 
			get {
				IntPtr raw_ret = gdk_visual_get_best();
				Gdk.Visual ret = GLib.Object.GetObject(raw_ret) as Gdk.Visual;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gdk_visual_get_best_depth();
		static d_gdk_visual_get_best_depth gdk_visual_get_best_depth = FuncLoader.LoadFunction<d_gdk_visual_get_best_depth>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_best_depth"));

		[Obsolete]
		public static int BestDepth { 
			get {
				int raw_ret = gdk_visual_get_best_depth();
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gdk_visual_get_best_type();
		static d_gdk_visual_get_best_type gdk_visual_get_best_type = FuncLoader.LoadFunction<d_gdk_visual_get_best_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_best_type"));

		[Obsolete]
		public static Gdk.VisualType BestType { 
			get {
				int raw_ret = gdk_visual_get_best_type();
				Gdk.VisualType ret = (Gdk.VisualType) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_visual_get_best_with_both(int depth, int visual_type);
		static d_gdk_visual_get_best_with_both gdk_visual_get_best_with_both = FuncLoader.LoadFunction<d_gdk_visual_get_best_with_both>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_best_with_both"));

		[Obsolete]
		public static Gdk.Visual GetBestWithBoth(int depth, Gdk.VisualType visual_type) {
			IntPtr raw_ret = gdk_visual_get_best_with_both(depth, (int) visual_type);
			Gdk.Visual ret = GLib.Object.GetObject(raw_ret) as Gdk.Visual;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_visual_get_best_with_depth(int depth);
		static d_gdk_visual_get_best_with_depth gdk_visual_get_best_with_depth = FuncLoader.LoadFunction<d_gdk_visual_get_best_with_depth>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_best_with_depth"));

		[Obsolete]
		public static Gdk.Visual GetBestWithDepth(int depth) {
			IntPtr raw_ret = gdk_visual_get_best_with_depth(depth);
			Gdk.Visual ret = GLib.Object.GetObject(raw_ret) as Gdk.Visual;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_visual_get_best_with_type(int visual_type);
		static d_gdk_visual_get_best_with_type gdk_visual_get_best_with_type = FuncLoader.LoadFunction<d_gdk_visual_get_best_with_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_best_with_type"));

		[Obsolete]
		public static Gdk.Visual GetBestWithType(Gdk.VisualType visual_type) {
			IntPtr raw_ret = gdk_visual_get_best_with_type((int) visual_type);
			Gdk.Visual ret = GLib.Object.GetObject(raw_ret) as Gdk.Visual;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gdk_visual_get_bits_per_rgb(IntPtr raw);
		static d_gdk_visual_get_bits_per_rgb gdk_visual_get_bits_per_rgb = FuncLoader.LoadFunction<d_gdk_visual_get_bits_per_rgb>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_bits_per_rgb"));

		[Obsolete]
		public int BitsPerRgb { 
			get {
				int raw_ret = gdk_visual_get_bits_per_rgb(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_visual_get_blue_pixel_details(IntPtr raw, out uint mask, out int shift, out int precision);
		static d_gdk_visual_get_blue_pixel_details gdk_visual_get_blue_pixel_details = FuncLoader.LoadFunction<d_gdk_visual_get_blue_pixel_details>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_blue_pixel_details"));

		public void GetBluePixelDetails(out uint mask, out int shift, out int precision) {
			gdk_visual_get_blue_pixel_details(Handle, out mask, out shift, out precision);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gdk_visual_get_byte_order(IntPtr raw);
		static d_gdk_visual_get_byte_order gdk_visual_get_byte_order = FuncLoader.LoadFunction<d_gdk_visual_get_byte_order>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_byte_order"));

		[Obsolete]
		public Gdk.ByteOrder ByteOrder { 
			get {
				int raw_ret = gdk_visual_get_byte_order(Handle);
				Gdk.ByteOrder ret = (Gdk.ByteOrder) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gdk_visual_get_colormap_size(IntPtr raw);
		static d_gdk_visual_get_colormap_size gdk_visual_get_colormap_size = FuncLoader.LoadFunction<d_gdk_visual_get_colormap_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_colormap_size"));

		[Obsolete]
		public int ColormapSize { 
			get {
				int raw_ret = gdk_visual_get_colormap_size(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gdk_visual_get_depth(IntPtr raw);
		static d_gdk_visual_get_depth gdk_visual_get_depth = FuncLoader.LoadFunction<d_gdk_visual_get_depth>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_depth"));

		public int Depth { 
			get {
				int raw_ret = gdk_visual_get_depth(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_visual_get_green_pixel_details(IntPtr raw, out uint mask, out int shift, out int precision);
		static d_gdk_visual_get_green_pixel_details gdk_visual_get_green_pixel_details = FuncLoader.LoadFunction<d_gdk_visual_get_green_pixel_details>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_green_pixel_details"));

		public void GetGreenPixelDetails(out uint mask, out int shift, out int precision) {
			gdk_visual_get_green_pixel_details(Handle, out mask, out shift, out precision);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_visual_get_red_pixel_details(IntPtr raw, out uint mask, out int shift, out int precision);
		static d_gdk_visual_get_red_pixel_details gdk_visual_get_red_pixel_details = FuncLoader.LoadFunction<d_gdk_visual_get_red_pixel_details>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_red_pixel_details"));

		public void GetRedPixelDetails(out uint mask, out int shift, out int precision) {
			gdk_visual_get_red_pixel_details(Handle, out mask, out shift, out precision);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_visual_get_screen(IntPtr raw);
		static d_gdk_visual_get_screen gdk_visual_get_screen = FuncLoader.LoadFunction<d_gdk_visual_get_screen>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_screen"));

		public Gdk.Screen Screen { 
			get {
				IntPtr raw_ret = gdk_visual_get_screen(Handle);
				Gdk.Screen ret = GLib.Object.GetObject(raw_ret) as Gdk.Screen;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_visual_get_system();
		static d_gdk_visual_get_system gdk_visual_get_system = FuncLoader.LoadFunction<d_gdk_visual_get_system>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_system"));

		[Obsolete]
		public static Gdk.Visual System { 
			get {
				IntPtr raw_ret = gdk_visual_get_system();
				Gdk.Visual ret = GLib.Object.GetObject(raw_ret) as Gdk.Visual;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_visual_get_type();
		static d_gdk_visual_get_type gdk_visual_get_type = FuncLoader.LoadFunction<d_gdk_visual_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_visual_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gdk_visual_get_visual_type(IntPtr raw);
		static d_gdk_visual_get_visual_type gdk_visual_get_visual_type = FuncLoader.LoadFunction<d_gdk_visual_get_visual_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_visual_get_visual_type"));

		public Gdk.VisualType VisualType { 
			get {
				int raw_ret = gdk_visual_get_visual_type(Handle);
				Gdk.VisualType ret = (Gdk.VisualType) raw_ret;
				return ret;
			}
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
