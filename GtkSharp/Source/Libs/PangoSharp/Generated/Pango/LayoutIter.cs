// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class LayoutIter : GLib.Opaque {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_pango_layout_iter_at_last_line(IntPtr raw);
		static d_pango_layout_iter_at_last_line pango_layout_iter_at_last_line = FuncLoader.LoadFunction<d_pango_layout_iter_at_last_line>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_at_last_line"));

		public bool AtLastLine() {
			bool raw_ret = pango_layout_iter_at_last_line(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_layout_iter_copy(IntPtr raw);
		static d_pango_layout_iter_copy pango_layout_iter_copy = FuncLoader.LoadFunction<d_pango_layout_iter_copy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_copy"));

		public Pango.LayoutIter Copy() {
			IntPtr raw_ret = pango_layout_iter_copy(Handle);
			Pango.LayoutIter ret = raw_ret == IntPtr.Zero ? null : (Pango.LayoutIter) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.LayoutIter), true);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_pango_layout_iter_get_baseline(IntPtr raw);
		static d_pango_layout_iter_get_baseline pango_layout_iter_get_baseline = FuncLoader.LoadFunction<d_pango_layout_iter_get_baseline>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_get_baseline"));

		public int Baseline { 
			get {
				int raw_ret = pango_layout_iter_get_baseline(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_layout_iter_get_char_extents(IntPtr raw, IntPtr logical_rect);
		static d_pango_layout_iter_get_char_extents pango_layout_iter_get_char_extents = FuncLoader.LoadFunction<d_pango_layout_iter_get_char_extents>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_get_char_extents"));

		public Pango.Rectangle CharExtents { 
			get {
				Pango.Rectangle logical_rect;
				IntPtr native_logical_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
				pango_layout_iter_get_char_extents(Handle, native_logical_rect);
				logical_rect = Pango.Rectangle.New (native_logical_rect);
				Marshal.FreeHGlobal (native_logical_rect);
				return logical_rect;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_layout_iter_get_cluster_extents(IntPtr raw, IntPtr ink_rect, IntPtr logical_rect);
		static d_pango_layout_iter_get_cluster_extents pango_layout_iter_get_cluster_extents = FuncLoader.LoadFunction<d_pango_layout_iter_get_cluster_extents>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_get_cluster_extents"));

		public void GetClusterExtents(out Pango.Rectangle ink_rect, out Pango.Rectangle logical_rect) {
			IntPtr native_ink_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			IntPtr native_logical_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			pango_layout_iter_get_cluster_extents(Handle, native_ink_rect, native_logical_rect);
			ink_rect = Pango.Rectangle.New (native_ink_rect);
			Marshal.FreeHGlobal (native_ink_rect);
			logical_rect = Pango.Rectangle.New (native_logical_rect);
			Marshal.FreeHGlobal (native_logical_rect);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_pango_layout_iter_get_index(IntPtr raw);
		static d_pango_layout_iter_get_index pango_layout_iter_get_index = FuncLoader.LoadFunction<d_pango_layout_iter_get_index>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_get_index"));

		public int Index { 
			get {
				int raw_ret = pango_layout_iter_get_index(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_layout_iter_get_layout(IntPtr raw);
		static d_pango_layout_iter_get_layout pango_layout_iter_get_layout = FuncLoader.LoadFunction<d_pango_layout_iter_get_layout>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_get_layout"));

		public Pango.Layout Layout { 
			get {
				IntPtr raw_ret = pango_layout_iter_get_layout(Handle);
				Pango.Layout ret = GLib.Object.GetObject(raw_ret) as Pango.Layout;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_layout_iter_get_layout_extents(IntPtr raw, IntPtr ink_rect, IntPtr logical_rect);
		static d_pango_layout_iter_get_layout_extents pango_layout_iter_get_layout_extents = FuncLoader.LoadFunction<d_pango_layout_iter_get_layout_extents>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_get_layout_extents"));

		public void GetLayoutExtents(out Pango.Rectangle ink_rect, out Pango.Rectangle logical_rect) {
			IntPtr native_ink_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			IntPtr native_logical_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			pango_layout_iter_get_layout_extents(Handle, native_ink_rect, native_logical_rect);
			ink_rect = Pango.Rectangle.New (native_ink_rect);
			Marshal.FreeHGlobal (native_ink_rect);
			logical_rect = Pango.Rectangle.New (native_logical_rect);
			Marshal.FreeHGlobal (native_logical_rect);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_layout_iter_get_line(IntPtr raw);
		static d_pango_layout_iter_get_line pango_layout_iter_get_line = FuncLoader.LoadFunction<d_pango_layout_iter_get_line>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_get_line"));

		public Pango.LayoutLine Line { 
			get {
				IntPtr raw_ret = pango_layout_iter_get_line(Handle);
				Pango.LayoutLine ret = raw_ret == IntPtr.Zero ? null : (Pango.LayoutLine) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.LayoutLine), false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_layout_iter_get_line_extents(IntPtr raw, IntPtr ink_rect, IntPtr logical_rect);
		static d_pango_layout_iter_get_line_extents pango_layout_iter_get_line_extents = FuncLoader.LoadFunction<d_pango_layout_iter_get_line_extents>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_get_line_extents"));

		public void GetLineExtents(out Pango.Rectangle ink_rect, out Pango.Rectangle logical_rect) {
			IntPtr native_ink_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			IntPtr native_logical_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			pango_layout_iter_get_line_extents(Handle, native_ink_rect, native_logical_rect);
			ink_rect = Pango.Rectangle.New (native_ink_rect);
			Marshal.FreeHGlobal (native_ink_rect);
			logical_rect = Pango.Rectangle.New (native_logical_rect);
			Marshal.FreeHGlobal (native_logical_rect);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_layout_iter_get_line_readonly(IntPtr raw);
		static d_pango_layout_iter_get_line_readonly pango_layout_iter_get_line_readonly = FuncLoader.LoadFunction<d_pango_layout_iter_get_line_readonly>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_get_line_readonly"));

		public Pango.LayoutLine LineReadonly { 
			get {
				IntPtr raw_ret = pango_layout_iter_get_line_readonly(Handle);
				Pango.LayoutLine ret = raw_ret == IntPtr.Zero ? null : (Pango.LayoutLine) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.LayoutLine), false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_layout_iter_get_line_yrange(IntPtr raw, out int y0_, out int y1_);
		static d_pango_layout_iter_get_line_yrange pango_layout_iter_get_line_yrange = FuncLoader.LoadFunction<d_pango_layout_iter_get_line_yrange>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_get_line_yrange"));

		public void GetLineYrange(out int y0_, out int y1_) {
			pango_layout_iter_get_line_yrange(Handle, out y0_, out y1_);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_layout_iter_get_run(IntPtr raw);
		static d_pango_layout_iter_get_run pango_layout_iter_get_run = FuncLoader.LoadFunction<d_pango_layout_iter_get_run>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_get_run"));

		public Pango.LayoutRun Run { 
			get {
				IntPtr raw_ret = pango_layout_iter_get_run(Handle);
				Pango.LayoutRun ret = Pango.LayoutRun.New (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_layout_iter_get_run_extents(IntPtr raw, IntPtr ink_rect, IntPtr logical_rect);
		static d_pango_layout_iter_get_run_extents pango_layout_iter_get_run_extents = FuncLoader.LoadFunction<d_pango_layout_iter_get_run_extents>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_get_run_extents"));

		public void GetRunExtents(out Pango.Rectangle ink_rect, out Pango.Rectangle logical_rect) {
			IntPtr native_ink_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			IntPtr native_logical_rect = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Pango.Rectangle)));
			pango_layout_iter_get_run_extents(Handle, native_ink_rect, native_logical_rect);
			ink_rect = Pango.Rectangle.New (native_ink_rect);
			Marshal.FreeHGlobal (native_ink_rect);
			logical_rect = Pango.Rectangle.New (native_logical_rect);
			Marshal.FreeHGlobal (native_logical_rect);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_layout_iter_get_run_readonly(IntPtr raw);
		static d_pango_layout_iter_get_run_readonly pango_layout_iter_get_run_readonly = FuncLoader.LoadFunction<d_pango_layout_iter_get_run_readonly>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_get_run_readonly"));

		public Pango.LayoutRun RunReadonly { 
			get {
				IntPtr raw_ret = pango_layout_iter_get_run_readonly(Handle);
				Pango.LayoutRun ret = Pango.LayoutRun.New (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_layout_iter_get_type();
		static d_pango_layout_iter_get_type pango_layout_iter_get_type = FuncLoader.LoadFunction<d_pango_layout_iter_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_get_type"));

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_layout_iter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_pango_layout_iter_next_char(IntPtr raw);
		static d_pango_layout_iter_next_char pango_layout_iter_next_char = FuncLoader.LoadFunction<d_pango_layout_iter_next_char>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_next_char"));

		public bool NextChar() {
			bool raw_ret = pango_layout_iter_next_char(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_pango_layout_iter_next_cluster(IntPtr raw);
		static d_pango_layout_iter_next_cluster pango_layout_iter_next_cluster = FuncLoader.LoadFunction<d_pango_layout_iter_next_cluster>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_next_cluster"));

		public bool NextCluster() {
			bool raw_ret = pango_layout_iter_next_cluster(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_pango_layout_iter_next_line(IntPtr raw);
		static d_pango_layout_iter_next_line pango_layout_iter_next_line = FuncLoader.LoadFunction<d_pango_layout_iter_next_line>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_next_line"));

		public bool NextLine() {
			bool raw_ret = pango_layout_iter_next_line(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_pango_layout_iter_next_run(IntPtr raw);
		static d_pango_layout_iter_next_run pango_layout_iter_next_run = FuncLoader.LoadFunction<d_pango_layout_iter_next_run>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_next_run"));

		public bool NextRun() {
			bool raw_ret = pango_layout_iter_next_run(Handle);
			bool ret = raw_ret;
			return ret;
		}

		public LayoutIter(IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_layout_iter_free(IntPtr raw);
		static d_pango_layout_iter_free pango_layout_iter_free = FuncLoader.LoadFunction<d_pango_layout_iter_free>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_layout_iter_free"));

		protected override void Free (IntPtr raw)
		{
			pango_layout_iter_free (raw);
		}

		[Obsolete("Pango.LayoutIter is now freed automatically")]
		public void Free () {}

		class FinalizerInfo {
			IntPtr handle;
			public uint timeoutHandlerId;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				pango_layout_iter_free (handle);
				GLib.Timeout.Remove(timeoutHandlerId);
				return false;
			}
		}

		~LayoutIter ()
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
