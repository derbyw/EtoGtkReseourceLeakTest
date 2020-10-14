// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Subprocess : GLib.Object, GLib.IInitable {

		public Subprocess (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_subprocess_newv(IntPtr argv, int flags, out IntPtr error);
		static d_g_subprocess_newv g_subprocess_newv = FuncLoader.LoadFunction<d_g_subprocess_newv>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_newv"));

		public unsafe Subprocess (string argv, GLib.SubprocessFlags flags) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Subprocess)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("argv");
				vals.Add (new GLib.Value (argv));
				names.Add ("flags");
				vals.Add (new GLib.Value (flags));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_argv = GLib.Marshaller.StringToPtrGStrdup (argv);
			IntPtr error = IntPtr.Zero;
			owned = true;
			Raw = g_subprocess_newv(native_argv, (int) flags, out error);
			GLib.Marshaller.Free (native_argv);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_subprocess_communicate(IntPtr raw, IntPtr stdin_buf, IntPtr cancellable, IntPtr stdout_buf, IntPtr stderr_buf, out IntPtr error);
		static d_g_subprocess_communicate g_subprocess_communicate = FuncLoader.LoadFunction<d_g_subprocess_communicate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_communicate"));

		public unsafe bool Communicate(GLib.Bytes stdin_buf, GLib.Cancellable cancellable, GLib.Bytes stdout_buf, GLib.Bytes stderr_buf) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_subprocess_communicate(Handle, stdin_buf == null ? IntPtr.Zero : stdin_buf.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, stdout_buf == null ? IntPtr.Zero : stdout_buf.Handle, stderr_buf == null ? IntPtr.Zero : stderr_buf.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_communicate_async(IntPtr raw, IntPtr stdin_buf, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_g_subprocess_communicate_async g_subprocess_communicate_async = FuncLoader.LoadFunction<d_g_subprocess_communicate_async>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_communicate_async"));

		public void CommunicateAsync(GLib.Bytes stdin_buf, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_subprocess_communicate_async(Handle, stdin_buf == null ? IntPtr.Zero : stdin_buf.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_subprocess_communicate_finish(IntPtr raw, IntPtr result, IntPtr stdout_buf, IntPtr stderr_buf, out IntPtr error);
		static d_g_subprocess_communicate_finish g_subprocess_communicate_finish = FuncLoader.LoadFunction<d_g_subprocess_communicate_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_communicate_finish"));

		public unsafe bool CommunicateFinish(GLib.IAsyncResult result, GLib.Bytes stdout_buf, GLib.Bytes stderr_buf) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_subprocess_communicate_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), stdout_buf == null ? IntPtr.Zero : stdout_buf.Handle, stderr_buf == null ? IntPtr.Zero : stderr_buf.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_subprocess_communicate_utf8(IntPtr raw, IntPtr stdin_buf, IntPtr cancellable, IntPtr stdout_buf, IntPtr stderr_buf, out IntPtr error);
		static d_g_subprocess_communicate_utf8 g_subprocess_communicate_utf8 = FuncLoader.LoadFunction<d_g_subprocess_communicate_utf8>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_communicate_utf8"));

		public unsafe bool CommunicateUtf8(string stdin_buf, GLib.Cancellable cancellable, string stdout_buf, string stderr_buf) {
			IntPtr native_stdin_buf = GLib.Marshaller.StringToPtrGStrdup (stdin_buf);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_subprocess_communicate_utf8(Handle, native_stdin_buf, cancellable == null ? IntPtr.Zero : cancellable.Handle, GLib.Marshaller.StringToPtrGStrdup(stdout_buf), GLib.Marshaller.StringToPtrGStrdup(stderr_buf), out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_stdin_buf);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_communicate_utf8_async(IntPtr raw, IntPtr stdin_buf, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_g_subprocess_communicate_utf8_async g_subprocess_communicate_utf8_async = FuncLoader.LoadFunction<d_g_subprocess_communicate_utf8_async>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_communicate_utf8_async"));

		public void CommunicateUtf8Async(string stdin_buf, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_stdin_buf = GLib.Marshaller.StringToPtrGStrdup (stdin_buf);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_subprocess_communicate_utf8_async(Handle, native_stdin_buf, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_stdin_buf);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_subprocess_communicate_utf8_finish(IntPtr raw, IntPtr result, IntPtr stdout_buf, IntPtr stderr_buf, out IntPtr error);
		static d_g_subprocess_communicate_utf8_finish g_subprocess_communicate_utf8_finish = FuncLoader.LoadFunction<d_g_subprocess_communicate_utf8_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_communicate_utf8_finish"));

		public unsafe bool CommunicateUtf8Finish(GLib.IAsyncResult result, string stdout_buf, string stderr_buf) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_subprocess_communicate_utf8_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), GLib.Marshaller.StringToPtrGStrdup(stdout_buf), GLib.Marshaller.StringToPtrGStrdup(stderr_buf), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_force_exit(IntPtr raw);
		static d_g_subprocess_force_exit g_subprocess_force_exit = FuncLoader.LoadFunction<d_g_subprocess_force_exit>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_force_exit"));

		public void ForceExit() {
			g_subprocess_force_exit(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_subprocess_get_exit_status(IntPtr raw);
		static d_g_subprocess_get_exit_status g_subprocess_get_exit_status = FuncLoader.LoadFunction<d_g_subprocess_get_exit_status>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_get_exit_status"));

		public int ExitStatus { 
			get {
				int raw_ret = g_subprocess_get_exit_status(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_subprocess_get_identifier(IntPtr raw);
		static d_g_subprocess_get_identifier g_subprocess_get_identifier = FuncLoader.LoadFunction<d_g_subprocess_get_identifier>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_get_identifier"));

		public string Identifier { 
			get {
				IntPtr raw_ret = g_subprocess_get_identifier(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_subprocess_get_if_exited(IntPtr raw);
		static d_g_subprocess_get_if_exited g_subprocess_get_if_exited = FuncLoader.LoadFunction<d_g_subprocess_get_if_exited>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_get_if_exited"));

		public bool IfExited { 
			get {
				bool raw_ret = g_subprocess_get_if_exited(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_subprocess_get_if_signaled(IntPtr raw);
		static d_g_subprocess_get_if_signaled g_subprocess_get_if_signaled = FuncLoader.LoadFunction<d_g_subprocess_get_if_signaled>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_get_if_signaled"));

		public bool IfSignaled { 
			get {
				bool raw_ret = g_subprocess_get_if_signaled(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_subprocess_get_status(IntPtr raw);
		static d_g_subprocess_get_status g_subprocess_get_status = FuncLoader.LoadFunction<d_g_subprocess_get_status>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_get_status"));

		public int Status { 
			get {
				int raw_ret = g_subprocess_get_status(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_subprocess_get_stderr_pipe(IntPtr raw);
		static d_g_subprocess_get_stderr_pipe g_subprocess_get_stderr_pipe = FuncLoader.LoadFunction<d_g_subprocess_get_stderr_pipe>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_get_stderr_pipe"));

		public GLib.InputStream StderrPipe { 
			get {
				IntPtr raw_ret = g_subprocess_get_stderr_pipe(Handle);
				GLib.InputStream ret = GLib.Object.GetObject(raw_ret) as GLib.InputStream;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_subprocess_get_stdin_pipe(IntPtr raw);
		static d_g_subprocess_get_stdin_pipe g_subprocess_get_stdin_pipe = FuncLoader.LoadFunction<d_g_subprocess_get_stdin_pipe>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_get_stdin_pipe"));

		public GLib.OutputStream StdinPipe { 
			get {
				IntPtr raw_ret = g_subprocess_get_stdin_pipe(Handle);
				GLib.OutputStream ret = GLib.Object.GetObject(raw_ret) as GLib.OutputStream;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_subprocess_get_stdout_pipe(IntPtr raw);
		static d_g_subprocess_get_stdout_pipe g_subprocess_get_stdout_pipe = FuncLoader.LoadFunction<d_g_subprocess_get_stdout_pipe>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_get_stdout_pipe"));

		public GLib.InputStream StdoutPipe { 
			get {
				IntPtr raw_ret = g_subprocess_get_stdout_pipe(Handle);
				GLib.InputStream ret = GLib.Object.GetObject(raw_ret) as GLib.InputStream;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_subprocess_get_successful(IntPtr raw);
		static d_g_subprocess_get_successful g_subprocess_get_successful = FuncLoader.LoadFunction<d_g_subprocess_get_successful>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_get_successful"));

		public bool Successful { 
			get {
				bool raw_ret = g_subprocess_get_successful(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_subprocess_get_term_sig(IntPtr raw);
		static d_g_subprocess_get_term_sig g_subprocess_get_term_sig = FuncLoader.LoadFunction<d_g_subprocess_get_term_sig>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_get_term_sig"));

		public int TermSig { 
			get {
				int raw_ret = g_subprocess_get_term_sig(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_subprocess_get_type();
		static d_g_subprocess_get_type g_subprocess_get_type = FuncLoader.LoadFunction<d_g_subprocess_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_subprocess_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_send_signal(IntPtr raw, int signal_num);
		static d_g_subprocess_send_signal g_subprocess_send_signal = FuncLoader.LoadFunction<d_g_subprocess_send_signal>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_send_signal"));

		public void SendSignal(int signal_num) {
			g_subprocess_send_signal(Handle, signal_num);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_subprocess_wait(IntPtr raw, IntPtr cancellable, out IntPtr error);
		static d_g_subprocess_wait g_subprocess_wait = FuncLoader.LoadFunction<d_g_subprocess_wait>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_wait"));

		public unsafe bool Wait(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_subprocess_wait(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_wait_async(IntPtr raw, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_g_subprocess_wait_async g_subprocess_wait_async = FuncLoader.LoadFunction<d_g_subprocess_wait_async>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_wait_async"));

		public void WaitAsync(GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_subprocess_wait_async(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_subprocess_wait_check(IntPtr raw, IntPtr cancellable, out IntPtr error);
		static d_g_subprocess_wait_check g_subprocess_wait_check = FuncLoader.LoadFunction<d_g_subprocess_wait_check>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_wait_check"));

		public unsafe bool WaitCheck(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_subprocess_wait_check(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_wait_check_async(IntPtr raw, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_g_subprocess_wait_check_async g_subprocess_wait_check_async = FuncLoader.LoadFunction<d_g_subprocess_wait_check_async>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_wait_check_async"));

		public void WaitCheckAsync(GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_subprocess_wait_check_async(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_subprocess_wait_check_finish(IntPtr raw, IntPtr result, out IntPtr error);
		static d_g_subprocess_wait_check_finish g_subprocess_wait_check_finish = FuncLoader.LoadFunction<d_g_subprocess_wait_check_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_wait_check_finish"));

		public unsafe bool WaitCheckFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_subprocess_wait_check_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_subprocess_wait_finish(IntPtr raw, IntPtr result, out IntPtr error);
		static d_g_subprocess_wait_finish g_subprocess_wait_finish = FuncLoader.LoadFunction<d_g_subprocess_wait_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_wait_finish"));

		public unsafe bool WaitFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_subprocess_wait_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_initable_init(IntPtr raw, IntPtr cancellable, out IntPtr error);
		static d_g_initable_init g_initable_init = FuncLoader.LoadFunction<d_g_initable_init>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_initable_init"));

		public bool Init(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_initable_init(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

#endregion
	}
}
