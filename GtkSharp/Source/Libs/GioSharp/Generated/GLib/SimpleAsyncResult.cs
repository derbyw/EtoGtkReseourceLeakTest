// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class SimpleAsyncResult : GLib.Object, GLib.IAsyncResult {

		public SimpleAsyncResult (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_simple_async_result_new(IntPtr source_object, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data, IntPtr source_tag);
		static d_g_simple_async_result_new g_simple_async_result_new = FuncLoader.LoadFunction<d_g_simple_async_result_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_new"));

		public SimpleAsyncResult (GLib.Object source_object, GLib.AsyncReadyCallback cb, IntPtr source_tag) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SimpleAsyncResult)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			owned = true;
			Raw = g_simple_async_result_new(source_object == null ? IntPtr.Zero : source_object.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero, source_tag);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_simple_async_result_new_from_error(IntPtr source_object, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data, IntPtr error);
		static d_g_simple_async_result_new_from_error g_simple_async_result_new_from_error = FuncLoader.LoadFunction<d_g_simple_async_result_new_from_error>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_new_from_error"));

		public static SimpleAsyncResult NewFromError(GLib.Object source_object, GLib.AsyncReadyCallback cb, IntPtr error)
		{
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			SimpleAsyncResult result = new SimpleAsyncResult (g_simple_async_result_new_from_error(source_object == null ? IntPtr.Zero : source_object.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero, error));
			return result;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_simple_async_result_new_take_error(IntPtr source_object, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data, IntPtr error);
		static d_g_simple_async_result_new_take_error g_simple_async_result_new_take_error = FuncLoader.LoadFunction<d_g_simple_async_result_new_take_error>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_new_take_error"));

		public static SimpleAsyncResult NewTakeError(GLib.Object source_object, GLib.AsyncReadyCallback cb, IntPtr error)
		{
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			SimpleAsyncResult result = new SimpleAsyncResult (g_simple_async_result_new_take_error(source_object == null ? IntPtr.Zero : source_object.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero, error));
			return result;
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
		delegate void d_g_simple_async_result_complete(IntPtr raw);
		static d_g_simple_async_result_complete g_simple_async_result_complete = FuncLoader.LoadFunction<d_g_simple_async_result_complete>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_complete"));

		[Obsolete]
		public void Complete() {
			g_simple_async_result_complete(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_simple_async_result_complete_in_idle(IntPtr raw);
		static d_g_simple_async_result_complete_in_idle g_simple_async_result_complete_in_idle = FuncLoader.LoadFunction<d_g_simple_async_result_complete_in_idle>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_complete_in_idle"));

		[Obsolete]
		public void CompleteInIdle() {
			g_simple_async_result_complete_in_idle(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_simple_async_result_get_op_res_gboolean(IntPtr raw);
		static d_g_simple_async_result_get_op_res_gboolean g_simple_async_result_get_op_res_gboolean = FuncLoader.LoadFunction<d_g_simple_async_result_get_op_res_gboolean>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_get_op_res_gboolean"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_simple_async_result_set_op_res_gboolean(IntPtr raw, bool op_res);
		static d_g_simple_async_result_set_op_res_gboolean g_simple_async_result_set_op_res_gboolean = FuncLoader.LoadFunction<d_g_simple_async_result_set_op_res_gboolean>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_set_op_res_gboolean"));

		[Obsolete]
		public bool OpResGboolean { 
			get {
				bool raw_ret = g_simple_async_result_get_op_res_gboolean(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				g_simple_async_result_set_op_res_gboolean(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_simple_async_result_get_op_res_gpointer(IntPtr raw);
		static d_g_simple_async_result_get_op_res_gpointer g_simple_async_result_get_op_res_gpointer = FuncLoader.LoadFunction<d_g_simple_async_result_get_op_res_gpointer>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_get_op_res_gpointer"));

		[Obsolete]
		public IntPtr OpResGpointer { 
			get {
				IntPtr raw_ret = g_simple_async_result_get_op_res_gpointer(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_simple_async_result_get_op_res_gssize(IntPtr raw);
		static d_g_simple_async_result_get_op_res_gssize g_simple_async_result_get_op_res_gssize = FuncLoader.LoadFunction<d_g_simple_async_result_get_op_res_gssize>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_get_op_res_gssize"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_simple_async_result_set_op_res_gssize(IntPtr raw, IntPtr op_res);
		static d_g_simple_async_result_set_op_res_gssize g_simple_async_result_set_op_res_gssize = FuncLoader.LoadFunction<d_g_simple_async_result_set_op_res_gssize>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_set_op_res_gssize"));

		[Obsolete]
		public long OpResGssize { 
			get {
				IntPtr raw_ret = g_simple_async_result_get_op_res_gssize(Handle);
				long ret = (long) raw_ret;
				return ret;
			}
			set {
				g_simple_async_result_set_op_res_gssize(Handle, new IntPtr (value));
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_simple_async_result_get_source_tag(IntPtr raw);
		static d_g_simple_async_result_get_source_tag g_simple_async_result_get_source_tag = FuncLoader.LoadFunction<d_g_simple_async_result_get_source_tag>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_get_source_tag"));

		[Obsolete]
		public IntPtr SourceTag { 
			get {
				IntPtr raw_ret = g_simple_async_result_get_source_tag(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_simple_async_result_get_type();
		static d_g_simple_async_result_get_type g_simple_async_result_get_type = FuncLoader.LoadFunction<d_g_simple_async_result_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_simple_async_result_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_simple_async_result_is_valid(IntPtr result, IntPtr source, IntPtr source_tag);
		static d_g_simple_async_result_is_valid g_simple_async_result_is_valid = FuncLoader.LoadFunction<d_g_simple_async_result_is_valid>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_is_valid"));

		[Obsolete]
		public static bool IsValid(GLib.IAsyncResult result, GLib.Object source, IntPtr source_tag) {
			bool raw_ret = g_simple_async_result_is_valid(result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), source == null ? IntPtr.Zero : source.Handle, source_tag);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_simple_async_result_propagate_error(IntPtr raw, out IntPtr dest);
		static d_g_simple_async_result_propagate_error g_simple_async_result_propagate_error = FuncLoader.LoadFunction<d_g_simple_async_result_propagate_error>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_propagate_error"));

		[Obsolete]
		public unsafe bool PropagateError() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_simple_async_result_propagate_error(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_simple_async_result_run_in_thread(IntPtr raw, GLibSharp.SimpleAsyncThreadFuncNative func, int io_priority, IntPtr cancellable);
		static d_g_simple_async_result_run_in_thread g_simple_async_result_run_in_thread = FuncLoader.LoadFunction<d_g_simple_async_result_run_in_thread>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_run_in_thread"));

		[Obsolete]
		public void RunInThread(GLib.SimpleAsyncThreadFunc func, int io_priority, GLib.Cancellable cancellable) {
			GLibSharp.SimpleAsyncThreadFuncWrapper func_wrapper = new GLibSharp.SimpleAsyncThreadFuncWrapper (func);
			g_simple_async_result_run_in_thread(Handle, func_wrapper.NativeDelegate, io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_simple_async_result_set_check_cancellable(IntPtr raw, IntPtr check_cancellable);
		static d_g_simple_async_result_set_check_cancellable g_simple_async_result_set_check_cancellable = FuncLoader.LoadFunction<d_g_simple_async_result_set_check_cancellable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_set_check_cancellable"));

		public GLib.Cancellable CheckCancellable { 
			set {
				g_simple_async_result_set_check_cancellable(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_simple_async_result_set_error_va(IntPtr raw, int domain, int code, IntPtr format, IntPtr args);
		static d_g_simple_async_result_set_error_va g_simple_async_result_set_error_va = FuncLoader.LoadFunction<d_g_simple_async_result_set_error_va>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_set_error_va"));

		[Obsolete]
		public void SetErrorVa(int domain, int code, string format, IntPtr args) {
			IntPtr native_format = GLib.Marshaller.StringToPtrGStrdup (format);
			g_simple_async_result_set_error_va(Handle, domain, code, native_format, args);
			GLib.Marshaller.Free (native_format);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_simple_async_result_set_from_error(IntPtr raw, IntPtr error);
		static d_g_simple_async_result_set_from_error g_simple_async_result_set_from_error = FuncLoader.LoadFunction<d_g_simple_async_result_set_from_error>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_set_from_error"));

		[Obsolete]
		public IntPtr FromError { 
			set {
				g_simple_async_result_set_from_error(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_simple_async_result_set_handle_cancellation(IntPtr raw, bool handle_cancellation);
		static d_g_simple_async_result_set_handle_cancellation g_simple_async_result_set_handle_cancellation = FuncLoader.LoadFunction<d_g_simple_async_result_set_handle_cancellation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_set_handle_cancellation"));

		[Obsolete]
		public bool HandleCancellation { 
			set {
				g_simple_async_result_set_handle_cancellation(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_simple_async_result_set_op_res_gpointer(IntPtr raw, IntPtr op_res, GLib.DestroyNotify destroy_op_res);
		static d_g_simple_async_result_set_op_res_gpointer g_simple_async_result_set_op_res_gpointer = FuncLoader.LoadFunction<d_g_simple_async_result_set_op_res_gpointer>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_set_op_res_gpointer"));

		[Obsolete]
		public void SetOpResGpointer(IntPtr op_res, GLib.DestroyNotify destroy_op_res) {
			g_simple_async_result_set_op_res_gpointer(Handle, op_res, destroy_op_res);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_simple_async_result_take_error(IntPtr raw, IntPtr error);
		static d_g_simple_async_result_take_error g_simple_async_result_take_error = FuncLoader.LoadFunction<d_g_simple_async_result_take_error>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_result_take_error"));

		[Obsolete]
		public void TakeError(IntPtr error) {
			g_simple_async_result_take_error(Handle, error);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_simple_async_report_gerror_in_idle(IntPtr objekt, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data, IntPtr error);
		static d_g_simple_async_report_gerror_in_idle g_simple_async_report_gerror_in_idle = FuncLoader.LoadFunction<d_g_simple_async_report_gerror_in_idle>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_report_gerror_in_idle"));

		[Obsolete]
		public static void ReportGerrorInIdle(GLib.Object objekt, GLib.AsyncReadyCallback cb, IntPtr error) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_simple_async_report_gerror_in_idle(objekt == null ? IntPtr.Zero : objekt.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero, error);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_simple_async_report_take_gerror_in_idle(IntPtr objekt, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data, IntPtr error);
		static d_g_simple_async_report_take_gerror_in_idle g_simple_async_report_take_gerror_in_idle = FuncLoader.LoadFunction<d_g_simple_async_report_take_gerror_in_idle>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_async_report_take_gerror_in_idle"));

		[Obsolete]
		public static void ReportTakeGerrorInIdle(GLib.Object objekt, GLib.AsyncReadyCallback cb, IntPtr error) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_simple_async_report_take_gerror_in_idle(objekt == null ? IntPtr.Zero : objekt.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero, error);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_async_result_get_source_object(IntPtr raw);
		static d_g_async_result_get_source_object g_async_result_get_source_object = FuncLoader.LoadFunction<d_g_async_result_get_source_object>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_async_result_get_source_object"));

		public GLib.Object SourceObject { 
			get {
				IntPtr raw_ret = g_async_result_get_source_object(Handle);
				GLib.Object ret = GLib.Object.GetObject (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_async_result_get_user_data(IntPtr raw);
		static d_g_async_result_get_user_data g_async_result_get_user_data = FuncLoader.LoadFunction<d_g_async_result_get_user_data>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_async_result_get_user_data"));

		public IntPtr UserData { 
			get {
				IntPtr raw_ret = g_async_result_get_user_data(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_async_result_is_tagged(IntPtr raw, IntPtr source_tag);
		static d_g_async_result_is_tagged g_async_result_is_tagged = FuncLoader.LoadFunction<d_g_async_result_is_tagged>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_async_result_is_tagged"));

		public bool IsTagged(IntPtr source_tag) {
			bool raw_ret = g_async_result_is_tagged(Handle, source_tag);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_async_result_legacy_propagate_error(IntPtr raw, out IntPtr error);
		static d_g_async_result_legacy_propagate_error g_async_result_legacy_propagate_error = FuncLoader.LoadFunction<d_g_async_result_legacy_propagate_error>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_async_result_legacy_propagate_error"));

		public bool LegacyPropagateError() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_async_result_legacy_propagate_error(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
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
