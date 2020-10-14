// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct RegionIter : IEquatable<RegionIter> {

		private IntPtr _dummy1;
		private uint dummy2;
		private IntPtr _dummy3;

		public static GtkSource.RegionIter Zero = new GtkSource.RegionIter ();

		public static GtkSource.RegionIter New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return GtkSource.RegionIter.Zero;
			return (GtkSource.RegionIter) Marshal.PtrToStructure (raw, typeof (GtkSource.RegionIter));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_source_region_iter_get_subregion(IntPtr raw, IntPtr start, IntPtr end);
		static d_gtk_source_region_iter_get_subregion gtk_source_region_iter_get_subregion = FuncLoader.LoadFunction<d_gtk_source_region_iter_get_subregion>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_region_iter_get_subregion"));

		public bool GetSubregion(Gtk.TextIter start, Gtk.TextIter end) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_start = GLib.Marshaller.StructureToPtrAlloc (start);
			IntPtr native_end = GLib.Marshaller.StructureToPtrAlloc (end);
			bool raw_ret = gtk_source_region_iter_get_subregion(this_as_native, native_start, native_end);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_start);
			Marshal.FreeHGlobal (native_end);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_source_region_iter_is_end(IntPtr raw);
		static d_gtk_source_region_iter_is_end gtk_source_region_iter_is_end = FuncLoader.LoadFunction<d_gtk_source_region_iter_is_end>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_region_iter_is_end"));

		public bool IsEnd { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				bool raw_ret = gtk_source_region_iter_is_end(this_as_native);
				bool ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_source_region_iter_next(IntPtr raw);
		static d_gtk_source_region_iter_next gtk_source_region_iter_next = FuncLoader.LoadFunction<d_gtk_source_region_iter_next>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_region_iter_next"));

		public bool Next() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			bool raw_ret = gtk_source_region_iter_next(this_as_native);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		static void ReadNative (IntPtr native, ref GtkSource.RegionIter target)
		{
			target = New (native);
		}

		public bool Equals (RegionIter other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is RegionIter && Equals ((RegionIter) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
