// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FontMetrics : GLib.Opaque {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_pango_font_metrics_get_approximate_char_width(IntPtr raw);
		static d_pango_font_metrics_get_approximate_char_width pango_font_metrics_get_approximate_char_width = FuncLoader.LoadFunction<d_pango_font_metrics_get_approximate_char_width>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_metrics_get_approximate_char_width"));

		public int ApproximateCharWidth { 
			get {
				int raw_ret = pango_font_metrics_get_approximate_char_width(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_pango_font_metrics_get_approximate_digit_width(IntPtr raw);
		static d_pango_font_metrics_get_approximate_digit_width pango_font_metrics_get_approximate_digit_width = FuncLoader.LoadFunction<d_pango_font_metrics_get_approximate_digit_width>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_metrics_get_approximate_digit_width"));

		public int ApproximateDigitWidth { 
			get {
				int raw_ret = pango_font_metrics_get_approximate_digit_width(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_pango_font_metrics_get_ascent(IntPtr raw);
		static d_pango_font_metrics_get_ascent pango_font_metrics_get_ascent = FuncLoader.LoadFunction<d_pango_font_metrics_get_ascent>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_metrics_get_ascent"));

		public int Ascent { 
			get {
				int raw_ret = pango_font_metrics_get_ascent(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_pango_font_metrics_get_descent(IntPtr raw);
		static d_pango_font_metrics_get_descent pango_font_metrics_get_descent = FuncLoader.LoadFunction<d_pango_font_metrics_get_descent>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_metrics_get_descent"));

		public int Descent { 
			get {
				int raw_ret = pango_font_metrics_get_descent(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_pango_font_metrics_get_strikethrough_position(IntPtr raw);
		static d_pango_font_metrics_get_strikethrough_position pango_font_metrics_get_strikethrough_position = FuncLoader.LoadFunction<d_pango_font_metrics_get_strikethrough_position>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_metrics_get_strikethrough_position"));

		public int StrikethroughPosition { 
			get {
				int raw_ret = pango_font_metrics_get_strikethrough_position(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_pango_font_metrics_get_strikethrough_thickness(IntPtr raw);
		static d_pango_font_metrics_get_strikethrough_thickness pango_font_metrics_get_strikethrough_thickness = FuncLoader.LoadFunction<d_pango_font_metrics_get_strikethrough_thickness>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_metrics_get_strikethrough_thickness"));

		public int StrikethroughThickness { 
			get {
				int raw_ret = pango_font_metrics_get_strikethrough_thickness(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_font_metrics_get_type();
		static d_pango_font_metrics_get_type pango_font_metrics_get_type = FuncLoader.LoadFunction<d_pango_font_metrics_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_metrics_get_type"));

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_font_metrics_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_pango_font_metrics_get_underline_position(IntPtr raw);
		static d_pango_font_metrics_get_underline_position pango_font_metrics_get_underline_position = FuncLoader.LoadFunction<d_pango_font_metrics_get_underline_position>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_metrics_get_underline_position"));

		public int UnderlinePosition { 
			get {
				int raw_ret = pango_font_metrics_get_underline_position(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_pango_font_metrics_get_underline_thickness(IntPtr raw);
		static d_pango_font_metrics_get_underline_thickness pango_font_metrics_get_underline_thickness = FuncLoader.LoadFunction<d_pango_font_metrics_get_underline_thickness>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_metrics_get_underline_thickness"));

		public int UnderlineThickness { 
			get {
				int raw_ret = pango_font_metrics_get_underline_thickness(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		public FontMetrics(IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_font_metrics_ref(IntPtr raw);
		static d_pango_font_metrics_ref pango_font_metrics_ref = FuncLoader.LoadFunction<d_pango_font_metrics_ref>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_metrics_ref"));

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				pango_font_metrics_ref (raw);
				Owned = true;
			}
		}

		[Obsolete("Pango.FontMetrics is now refcounted automatically")]
		public FontMetrics Ref () { return this; }

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_font_metrics_unref(IntPtr raw);
		static d_pango_font_metrics_unref pango_font_metrics_unref = FuncLoader.LoadFunction<d_pango_font_metrics_unref>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_metrics_unref"));

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				pango_font_metrics_unref (raw);
				Owned = false;
			}
		}

		[Obsolete("Pango.FontMetrics is now refcounted automatically")]
		public void Unref () {}

		class FinalizerInfo {
			IntPtr handle;
			public uint timeoutHandlerId;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				pango_font_metrics_unref (handle);
				GLib.Timeout.Remove(timeoutHandlerId);
				return false;
			}
		}

		~FontMetrics ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			info.timeoutHandlerId = GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
