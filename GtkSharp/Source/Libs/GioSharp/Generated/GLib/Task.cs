// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Task : GLib.Object, GLib.IAsyncResult {

		public Task (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_task_new(IntPtr source_object, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr callback_data);
		static d_g_task_new g_task_new = FuncLoader.LoadFunction<d_g_task_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_new"));

		public Task (IntPtr source_object, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Task)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			owned = true;
			Raw = g_task_new(source_object, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_task_get_completed(IntPtr raw);
		static d_g_task_get_completed g_task_get_completed = FuncLoader.LoadFunction<d_g_task_get_completed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_get_completed"));

		[GLib.Property ("completed")]
		public bool Completed {
			get  {
				bool raw_ret = g_task_get_completed(Handle);
				bool ret = raw_ret;
				return ret;
			}
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
		delegate void d_g_task_attach_source(IntPtr raw, IntPtr source, GLibSharp.GSourceFuncNative cb);
		static d_g_task_attach_source g_task_attach_source = FuncLoader.LoadFunction<d_g_task_attach_source>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_attach_source"));

		public void AttachSource(GLib.Source source, GLib.GSourceFunc cb) {
			GLibSharp.GSourceFuncWrapper cb_wrapper = new GLibSharp.GSourceFuncWrapper (cb);
			g_task_attach_source(Handle, source == null ? IntPtr.Zero : source.Handle, cb_wrapper.NativeDelegate);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_task_get_cancellable(IntPtr raw);
		static d_g_task_get_cancellable g_task_get_cancellable = FuncLoader.LoadFunction<d_g_task_get_cancellable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_get_cancellable"));

		public GLib.Cancellable Cancellable { 
			get {
				IntPtr raw_ret = g_task_get_cancellable(Handle);
				GLib.Cancellable ret = GLib.Object.GetObject(raw_ret) as GLib.Cancellable;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_task_get_check_cancellable(IntPtr raw);
		static d_g_task_get_check_cancellable g_task_get_check_cancellable = FuncLoader.LoadFunction<d_g_task_get_check_cancellable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_get_check_cancellable"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_task_set_check_cancellable(IntPtr raw, bool check_cancellable);
		static d_g_task_set_check_cancellable g_task_set_check_cancellable = FuncLoader.LoadFunction<d_g_task_set_check_cancellable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_set_check_cancellable"));

		public bool CheckCancellable { 
			get {
				bool raw_ret = g_task_get_check_cancellable(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				g_task_set_check_cancellable(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_task_get_context(IntPtr raw);
		static d_g_task_get_context g_task_get_context = FuncLoader.LoadFunction<d_g_task_get_context>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_get_context"));

		public GLib.MainContext Context { 
			get {
				IntPtr raw_ret = g_task_get_context(Handle);
				GLib.MainContext ret = new GLib.MainContext(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_task_get_priority(IntPtr raw);
		static d_g_task_get_priority g_task_get_priority = FuncLoader.LoadFunction<d_g_task_get_priority>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_get_priority"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_task_set_priority(IntPtr raw, int priority);
		static d_g_task_set_priority g_task_set_priority = FuncLoader.LoadFunction<d_g_task_set_priority>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_set_priority"));

		public int Priority { 
			get {
				int raw_ret = g_task_get_priority(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				g_task_set_priority(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_task_get_return_on_cancel(IntPtr raw);
		static d_g_task_get_return_on_cancel g_task_get_return_on_cancel = FuncLoader.LoadFunction<d_g_task_get_return_on_cancel>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_get_return_on_cancel"));

		public bool ReturnOnCancel { 
			get {
				bool raw_ret = g_task_get_return_on_cancel(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_task_get_source_object(IntPtr raw);
		static d_g_task_get_source_object g_task_get_source_object = FuncLoader.LoadFunction<d_g_task_get_source_object>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_get_source_object"));

		public IntPtr SourceObject { 
			get {
				IntPtr raw_ret = g_task_get_source_object(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_task_get_source_tag(IntPtr raw);
		static d_g_task_get_source_tag g_task_get_source_tag = FuncLoader.LoadFunction<d_g_task_get_source_tag>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_get_source_tag"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_task_set_source_tag(IntPtr raw, IntPtr source_tag);
		static d_g_task_set_source_tag g_task_set_source_tag = FuncLoader.LoadFunction<d_g_task_set_source_tag>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_set_source_tag"));

		public IntPtr SourceTag { 
			get {
				IntPtr raw_ret = g_task_get_source_tag(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
			set {
				g_task_set_source_tag(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_task_get_task_data(IntPtr raw);
		static d_g_task_get_task_data g_task_get_task_data = FuncLoader.LoadFunction<d_g_task_get_task_data>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_get_task_data"));

		public IntPtr TaskData { 
			get {
				IntPtr raw_ret = g_task_get_task_data(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_task_get_type();
		static d_g_task_get_type g_task_get_type = FuncLoader.LoadFunction<d_g_task_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_task_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_task_had_error(IntPtr raw);
		static d_g_task_had_error g_task_had_error = FuncLoader.LoadFunction<d_g_task_had_error>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_had_error"));

		public bool HadError() {
			bool raw_ret = g_task_had_error(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_task_is_valid(IntPtr result, IntPtr source_object);
		static d_g_task_is_valid g_task_is_valid = FuncLoader.LoadFunction<d_g_task_is_valid>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_is_valid"));

		public static bool IsValid(IntPtr result, IntPtr source_object) {
			bool raw_ret = g_task_is_valid(result, source_object);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_task_propagate_boolean(IntPtr raw, out IntPtr error);
		static d_g_task_propagate_boolean g_task_propagate_boolean = FuncLoader.LoadFunction<d_g_task_propagate_boolean>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_propagate_boolean"));

		public unsafe bool PropagateBoolean() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_task_propagate_boolean(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_task_propagate_int(IntPtr raw, out IntPtr error);
		static d_g_task_propagate_int g_task_propagate_int = FuncLoader.LoadFunction<d_g_task_propagate_int>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_propagate_int"));

		public unsafe long PropagateInt() {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_task_propagate_int(Handle, out error);
			long ret = (long) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_task_propagate_pointer(IntPtr raw, out IntPtr error);
		static d_g_task_propagate_pointer g_task_propagate_pointer = FuncLoader.LoadFunction<d_g_task_propagate_pointer>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_propagate_pointer"));

		public unsafe IntPtr PropagatePointer() {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_task_propagate_pointer(Handle, out error);
			IntPtr ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_task_report_error(IntPtr source_object, GLibSharp.AsyncReadyCallbackNative cb, IntPtr callback_data, IntPtr source_tag, IntPtr error);
		static d_g_task_report_error g_task_report_error = FuncLoader.LoadFunction<d_g_task_report_error>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_report_error"));

		public static void ReportError(IntPtr source_object, GLib.AsyncReadyCallback cb, IntPtr source_tag, IntPtr error) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_task_report_error(source_object, cb_wrapper.NativeDelegate, IntPtr.Zero, source_tag, error);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_task_return_boolean(IntPtr raw, bool result);
		static d_g_task_return_boolean g_task_return_boolean = FuncLoader.LoadFunction<d_g_task_return_boolean>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_return_boolean"));

		public void ReturnBoolean(bool result) {
			g_task_return_boolean(Handle, result);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_task_return_error(IntPtr raw, IntPtr error);
		static d_g_task_return_error g_task_return_error = FuncLoader.LoadFunction<d_g_task_return_error>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_return_error"));

		public void ReturnError(IntPtr error) {
			g_task_return_error(Handle, error);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_task_return_error_if_cancelled(IntPtr raw);
		static d_g_task_return_error_if_cancelled g_task_return_error_if_cancelled = FuncLoader.LoadFunction<d_g_task_return_error_if_cancelled>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_return_error_if_cancelled"));

		public bool ReturnErrorIfCancelled() {
			bool raw_ret = g_task_return_error_if_cancelled(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_task_return_int(IntPtr raw, IntPtr result);
		static d_g_task_return_int g_task_return_int = FuncLoader.LoadFunction<d_g_task_return_int>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_return_int"));

		public void ReturnInt(long result) {
			g_task_return_int(Handle, new IntPtr (result));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_task_return_pointer(IntPtr raw, IntPtr result, GLib.DestroyNotify result_destroy);
		static d_g_task_return_pointer g_task_return_pointer = FuncLoader.LoadFunction<d_g_task_return_pointer>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_return_pointer"));

		public void ReturnPointer(IntPtr result, GLib.DestroyNotify result_destroy) {
			g_task_return_pointer(Handle, result, result_destroy);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_task_run_in_thread(IntPtr raw, GLibSharp.TaskThreadFuncNative task_func);
		static d_g_task_run_in_thread g_task_run_in_thread = FuncLoader.LoadFunction<d_g_task_run_in_thread>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_run_in_thread"));

		public void RunInThread(GLib.TaskThreadFunc task_func) {
			GLibSharp.TaskThreadFuncWrapper task_func_wrapper = new GLibSharp.TaskThreadFuncWrapper (task_func);
			g_task_run_in_thread(Handle, task_func_wrapper.NativeDelegate);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_task_run_in_thread_sync(IntPtr raw, GLibSharp.TaskThreadFuncNative task_func);
		static d_g_task_run_in_thread_sync g_task_run_in_thread_sync = FuncLoader.LoadFunction<d_g_task_run_in_thread_sync>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_run_in_thread_sync"));

		public void RunInThreadSync(GLib.TaskThreadFunc task_func) {
			GLibSharp.TaskThreadFuncWrapper task_func_wrapper = new GLibSharp.TaskThreadFuncWrapper (task_func);
			g_task_run_in_thread_sync(Handle, task_func_wrapper.NativeDelegate);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_task_set_return_on_cancel(IntPtr raw, bool return_on_cancel);
		static d_g_task_set_return_on_cancel g_task_set_return_on_cancel = FuncLoader.LoadFunction<d_g_task_set_return_on_cancel>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_set_return_on_cancel"));

		public bool SetReturnOnCancel(bool return_on_cancel) {
			bool raw_ret = g_task_set_return_on_cancel(Handle, return_on_cancel);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_task_set_task_data(IntPtr raw, IntPtr task_data, GLib.DestroyNotify task_data_destroy);
		static d_g_task_set_task_data g_task_set_task_data = FuncLoader.LoadFunction<d_g_task_set_task_data>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_task_set_task_data"));

		public void SetTaskData(IntPtr task_data, GLib.DestroyNotify task_data_destroy) {
			g_task_set_task_data(Handle, task_data, task_data_destroy);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_async_result_get_source_object(IntPtr raw);
		static d_g_async_result_get_source_object g_async_result_get_source_object = FuncLoader.LoadFunction<d_g_async_result_get_source_object>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_async_result_get_source_object"));

		GLib.Object GLib.IAsyncResult.SourceObject { 
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
