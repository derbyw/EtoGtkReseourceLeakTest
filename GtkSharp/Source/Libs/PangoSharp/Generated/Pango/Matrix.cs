// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Matrix : IEquatable<Matrix> {

		public double Xx;
		public double Xy;
		public double Yx;
		public double Yy;
		public double X0;
		public double Y0;

		public static Pango.Matrix Zero = new Pango.Matrix ();

		public static Pango.Matrix New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Pango.Matrix.Zero;
			return (Pango.Matrix) Marshal.PtrToStructure (raw, typeof (Pango.Matrix));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_matrix_concat(IntPtr raw, IntPtr new_matrix);
		static d_pango_matrix_concat pango_matrix_concat = FuncLoader.LoadFunction<d_pango_matrix_concat>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_matrix_concat"));

		public void Concat(Pango.Matrix new_matrix) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_new_matrix = GLib.Marshaller.StructureToPtrAlloc (new_matrix);
			pango_matrix_concat(this_as_native, native_new_matrix);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_new_matrix);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double d_pango_matrix_get_font_scale_factor(IntPtr raw);
		static d_pango_matrix_get_font_scale_factor pango_matrix_get_font_scale_factor = FuncLoader.LoadFunction<d_pango_matrix_get_font_scale_factor>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_matrix_get_font_scale_factor"));

		public double FontScaleFactor { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				double raw_ret = pango_matrix_get_font_scale_factor(this_as_native);
				double ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_matrix_get_font_scale_factors(IntPtr raw, out double xscale, out double yscale);
		static d_pango_matrix_get_font_scale_factors pango_matrix_get_font_scale_factors = FuncLoader.LoadFunction<d_pango_matrix_get_font_scale_factors>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_matrix_get_font_scale_factors"));

		public void GetFontScaleFactors(out double xscale, out double yscale) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			pango_matrix_get_font_scale_factors(this_as_native, out xscale, out yscale);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_matrix_get_type();
		static d_pango_matrix_get_type pango_matrix_get_type = FuncLoader.LoadFunction<d_pango_matrix_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_matrix_get_type"));

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_matrix_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_matrix_rotate(IntPtr raw, double degrees);
		static d_pango_matrix_rotate pango_matrix_rotate = FuncLoader.LoadFunction<d_pango_matrix_rotate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_matrix_rotate"));

		public void Rotate(double degrees) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			pango_matrix_rotate(this_as_native, degrees);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_matrix_scale(IntPtr raw, double scale_x, double scale_y);
		static d_pango_matrix_scale pango_matrix_scale = FuncLoader.LoadFunction<d_pango_matrix_scale>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_matrix_scale"));

		public void Scale(double scale_x, double scale_y) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			pango_matrix_scale(this_as_native, scale_x, scale_y);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_matrix_transform_distance(IntPtr raw, ref double dx, ref double dy);
		static d_pango_matrix_transform_distance pango_matrix_transform_distance = FuncLoader.LoadFunction<d_pango_matrix_transform_distance>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_matrix_transform_distance"));

		public void TransformDistance(ref double dx, ref double dy) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			pango_matrix_transform_distance(this_as_native, ref dx, ref dy);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_matrix_transform_pixel_rectangle(IntPtr raw, IntPtr rect);
		static d_pango_matrix_transform_pixel_rectangle pango_matrix_transform_pixel_rectangle = FuncLoader.LoadFunction<d_pango_matrix_transform_pixel_rectangle>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_matrix_transform_pixel_rectangle"));

		public void TransformPixelRectangle(ref Pango.Rectangle rect) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_rect = GLib.Marshaller.StructureToPtrAlloc (rect);
			pango_matrix_transform_pixel_rectangle(this_as_native, native_rect);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			rect = Pango.Rectangle.New (native_rect);
			Marshal.FreeHGlobal (native_rect);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_matrix_transform_point(IntPtr raw, ref double x, ref double y);
		static d_pango_matrix_transform_point pango_matrix_transform_point = FuncLoader.LoadFunction<d_pango_matrix_transform_point>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_matrix_transform_point"));

		public void TransformPoint(ref double x, ref double y) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			pango_matrix_transform_point(this_as_native, ref x, ref y);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_matrix_transform_rectangle(IntPtr raw, IntPtr rect);
		static d_pango_matrix_transform_rectangle pango_matrix_transform_rectangle = FuncLoader.LoadFunction<d_pango_matrix_transform_rectangle>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_matrix_transform_rectangle"));

		public void TransformRectangle(ref Pango.Rectangle rect) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_rect = GLib.Marshaller.StructureToPtrAlloc (rect);
			pango_matrix_transform_rectangle(this_as_native, native_rect);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			rect = Pango.Rectangle.New (native_rect);
			Marshal.FreeHGlobal (native_rect);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_matrix_translate(IntPtr raw, double tx, double ty);
		static d_pango_matrix_translate pango_matrix_translate = FuncLoader.LoadFunction<d_pango_matrix_translate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_matrix_translate"));

		public void Translate(double tx, double ty) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			pango_matrix_translate(this_as_native, tx, ty);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		static void ReadNative (IntPtr native, ref Pango.Matrix target)
		{
			target = New (native);
		}

		public bool Equals (Matrix other)
		{
			return true && Xx.Equals (other.Xx) && Xy.Equals (other.Xy) && Yx.Equals (other.Yx) && Yy.Equals (other.Yy) && X0.Equals (other.X0) && Y0.Equals (other.Y0);
		}

		public override bool Equals (object other)
		{
			return other is Matrix && Equals ((Matrix) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Xx.GetHashCode () ^ Xy.GetHashCode () ^ Yx.GetHashCode () ^ Yy.GetHashCode () ^ X0.GetHashCode () ^ Y0.GetHashCode ();
		}

		public static explicit operator GLib.Value (Pango.Matrix boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Pango.Matrix.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Pango.Matrix (GLib.Value val)
		{
			return (Pango.Matrix) val.Val;
		}

		[Obsolete("This is a no-op")]
		public Pango.Matrix Copy() {
			return this;
		}
#endregion
	}
}
