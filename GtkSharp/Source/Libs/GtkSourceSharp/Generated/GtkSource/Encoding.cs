// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Encoding : GLib.Opaque {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_encoding_copy(IntPtr raw);
		static d_gtk_source_encoding_copy gtk_source_encoding_copy = FuncLoader.LoadFunction<d_gtk_source_encoding_copy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_encoding_copy"));

		public GtkSource.Encoding Copy() {
			IntPtr raw_ret = gtk_source_encoding_copy(Handle);
			GtkSource.Encoding ret = raw_ret == IntPtr.Zero ? null : (GtkSource.Encoding) GLib.Opaque.GetOpaque (raw_ret, typeof (GtkSource.Encoding), true);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_encoding_get_all();
		static d_gtk_source_encoding_get_all gtk_source_encoding_get_all = FuncLoader.LoadFunction<d_gtk_source_encoding_get_all>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_encoding_get_all"));

		public static GLib.SList All { 
			get {
				IntPtr raw_ret = gtk_source_encoding_get_all();
				GLib.SList ret = new GLib.SList(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_encoding_get_charset(IntPtr raw);
		static d_gtk_source_encoding_get_charset gtk_source_encoding_get_charset = FuncLoader.LoadFunction<d_gtk_source_encoding_get_charset>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_encoding_get_charset"));

		public string Charset { 
			get {
				IntPtr raw_ret = gtk_source_encoding_get_charset(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_encoding_get_current();
		static d_gtk_source_encoding_get_current gtk_source_encoding_get_current = FuncLoader.LoadFunction<d_gtk_source_encoding_get_current>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_encoding_get_current"));

		public static GtkSource.Encoding Current { 
			get {
				IntPtr raw_ret = gtk_source_encoding_get_current();
				GtkSource.Encoding ret = raw_ret == IntPtr.Zero ? null : (GtkSource.Encoding) GLib.Opaque.GetOpaque (raw_ret, typeof (GtkSource.Encoding), false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_encoding_get_default_candidates();
		static d_gtk_source_encoding_get_default_candidates gtk_source_encoding_get_default_candidates = FuncLoader.LoadFunction<d_gtk_source_encoding_get_default_candidates>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_encoding_get_default_candidates"));

		public static GLib.SList DefaultCandidates { 
			get {
				IntPtr raw_ret = gtk_source_encoding_get_default_candidates();
				GLib.SList ret = new GLib.SList(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_encoding_get_from_charset(IntPtr charset);
		static d_gtk_source_encoding_get_from_charset gtk_source_encoding_get_from_charset = FuncLoader.LoadFunction<d_gtk_source_encoding_get_from_charset>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_encoding_get_from_charset"));

		public static GtkSource.Encoding GetFromCharset(string charset) {
			IntPtr native_charset = GLib.Marshaller.StringToPtrGStrdup (charset);
			IntPtr raw_ret = gtk_source_encoding_get_from_charset(native_charset);
			GtkSource.Encoding ret = raw_ret == IntPtr.Zero ? null : (GtkSource.Encoding) GLib.Opaque.GetOpaque (raw_ret, typeof (GtkSource.Encoding), false);
			GLib.Marshaller.Free (native_charset);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_encoding_get_name(IntPtr raw);
		static d_gtk_source_encoding_get_name gtk_source_encoding_get_name = FuncLoader.LoadFunction<d_gtk_source_encoding_get_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_encoding_get_name"));

		public string Name { 
			get {
				IntPtr raw_ret = gtk_source_encoding_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_encoding_get_type();
		static d_gtk_source_encoding_get_type gtk_source_encoding_get_type = FuncLoader.LoadFunction<d_gtk_source_encoding_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_encoding_get_type"));

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_source_encoding_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_encoding_get_utf8();
		static d_gtk_source_encoding_get_utf8 gtk_source_encoding_get_utf8 = FuncLoader.LoadFunction<d_gtk_source_encoding_get_utf8>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_encoding_get_utf8"));

		public static GtkSource.Encoding Utf8 { 
			get {
				IntPtr raw_ret = gtk_source_encoding_get_utf8();
				GtkSource.Encoding ret = raw_ret == IntPtr.Zero ? null : (GtkSource.Encoding) GLib.Opaque.GetOpaque (raw_ret, typeof (GtkSource.Encoding), false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_encoding_to_string(IntPtr raw);
		static d_gtk_source_encoding_to_string gtk_source_encoding_to_string = FuncLoader.LoadFunction<d_gtk_source_encoding_to_string>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_encoding_to_string"));

		public override string ToString() {
			IntPtr raw_ret = gtk_source_encoding_to_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		public Encoding(IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_encoding_free(IntPtr raw);
		static d_gtk_source_encoding_free gtk_source_encoding_free = FuncLoader.LoadFunction<d_gtk_source_encoding_free>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_encoding_free"));

		protected override void Free (IntPtr raw)
		{
			gtk_source_encoding_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;
			public uint timeoutHandlerId;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gtk_source_encoding_free (handle);
				GLib.Timeout.Remove(timeoutHandlerId);
				return false;
			}
		}

		~Encoding ()
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
