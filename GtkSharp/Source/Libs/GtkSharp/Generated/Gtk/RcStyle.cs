// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class RcStyle : GLib.Object {

		public RcStyle (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_rc_style_new();
		static d_gtk_rc_style_new gtk_rc_style_new = FuncLoader.LoadFunction<d_gtk_rc_style_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_rc_style_new"));

		public RcStyle () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RcStyle)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			owned = true;
			Raw = gtk_rc_style_new();
		}

		static CreateRcStyleNativeDelegate CreateRcStyle_cb_delegate;
		static CreateRcStyleNativeDelegate CreateRcStyleVMCallback {
			get {
				if (CreateRcStyle_cb_delegate == null)
					CreateRcStyle_cb_delegate = new CreateRcStyleNativeDelegate (CreateRcStyle_cb);
				return CreateRcStyle_cb_delegate;
			}
		}

		static void OverrideCreateRcStyle (GLib.GType gtype)
		{
			OverrideCreateRcStyle (gtype, CreateRcStyleVMCallback);
		}

		static void OverrideCreateRcStyle (GLib.GType gtype, CreateRcStyleNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("create_rc_style"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr CreateRcStyleNativeDelegate (IntPtr inst);

		static IntPtr CreateRcStyle_cb (IntPtr inst)
		{
			try {
				RcStyle __obj = GLib.Object.GetObject (inst, false) as RcStyle;
				Gtk.RcStyle __result;
				__result = __obj.OnCreateRcStyle ();
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.RcStyle), ConnectionMethod="OverrideCreateRcStyle")]
		protected virtual Gtk.RcStyle OnCreateRcStyle ()
		{
			return InternalCreateRcStyle ();
		}

		private Gtk.RcStyle InternalCreateRcStyle ()
		{
			CreateRcStyleNativeDelegate unmanaged = class_abi.BaseOverride<CreateRcStyleNativeDelegate>(this.LookupGType(), "create_rc_style");
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle);
			return GLib.Object.GetObject(__result) as Gtk.RcStyle;
		}

		static MergeNativeDelegate Merge_cb_delegate;
		static MergeNativeDelegate MergeVMCallback {
			get {
				if (Merge_cb_delegate == null)
					Merge_cb_delegate = new MergeNativeDelegate (Merge_cb);
				return Merge_cb_delegate;
			}
		}

		static void OverrideMerge (GLib.GType gtype)
		{
			OverrideMerge (gtype, MergeVMCallback);
		}

		static void OverrideMerge (GLib.GType gtype, MergeNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("merge"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MergeNativeDelegate (IntPtr inst, IntPtr src);

		static void Merge_cb (IntPtr inst, IntPtr src)
		{
			try {
				RcStyle __obj = GLib.Object.GetObject (inst, false) as RcStyle;
				__obj.OnMerge (GLib.Object.GetObject(src) as Gtk.RcStyle);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.RcStyle), ConnectionMethod="OverrideMerge")]
		protected virtual void OnMerge (Gtk.RcStyle src)
		{
			InternalMerge (src);
		}

		private void InternalMerge (Gtk.RcStyle src)
		{
			MergeNativeDelegate unmanaged = class_abi.BaseOverride<MergeNativeDelegate>(this.LookupGType(), "merge");
			if (unmanaged == null) return;

			unmanaged (this.Handle, src == null ? IntPtr.Zero : src.Handle);
		}

		static CreateStyleNativeDelegate CreateStyle_cb_delegate;
		static CreateStyleNativeDelegate CreateStyleVMCallback {
			get {
				if (CreateStyle_cb_delegate == null)
					CreateStyle_cb_delegate = new CreateStyleNativeDelegate (CreateStyle_cb);
				return CreateStyle_cb_delegate;
			}
		}

		static void OverrideCreateStyle (GLib.GType gtype)
		{
			OverrideCreateStyle (gtype, CreateStyleVMCallback);
		}

		static void OverrideCreateStyle (GLib.GType gtype, CreateStyleNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("create_style"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr CreateStyleNativeDelegate (IntPtr inst);

		static IntPtr CreateStyle_cb (IntPtr inst)
		{
			try {
				RcStyle __obj = GLib.Object.GetObject (inst, false) as RcStyle;
				Gtk.Style __result;
				__result = __obj.OnCreateStyle ();
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.RcStyle), ConnectionMethod="OverrideCreateStyle")]
		protected virtual Gtk.Style OnCreateStyle ()
		{
			return InternalCreateStyle ();
		}

		private Gtk.Style InternalCreateStyle ()
		{
			CreateStyleNativeDelegate unmanaged = class_abi.BaseOverride<CreateStyleNativeDelegate>(this.LookupGType(), "create_style");
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle);
			return GLib.Object.GetObject(__result) as Gtk.Style;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_rc_style_copy(IntPtr raw);
		static d_gtk_rc_style_copy gtk_rc_style_copy = FuncLoader.LoadFunction<d_gtk_rc_style_copy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_rc_style_copy"));

		[Obsolete]
		public Gtk.RcStyle Copy() {
			IntPtr raw_ret = gtk_rc_style_copy(Handle);
			Gtk.RcStyle ret = GLib.Object.GetObject(raw_ret, true) as Gtk.RcStyle;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_rc_style_get_type();
		static d_gtk_rc_style_get_type gtk_rc_style_get_type = FuncLoader.LoadFunction<d_gtk_rc_style_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_rc_style_get_type"));

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_rc_style_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}