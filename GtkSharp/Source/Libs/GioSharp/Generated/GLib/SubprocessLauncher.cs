// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class SubprocessLauncher : GLib.Object {

		public SubprocessLauncher (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_subprocess_launcher_new(int flags);
		static d_g_subprocess_launcher_new g_subprocess_launcher_new = FuncLoader.LoadFunction<d_g_subprocess_launcher_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_new"));

		public SubprocessLauncher (GLib.SubprocessFlags flags) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SubprocessLauncher)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("flags");
				vals.Add (new GLib.Value (flags));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			owned = true;
			Raw = g_subprocess_launcher_new((int) flags);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_subprocess_launcher_get_type();
		static d_g_subprocess_launcher_get_type g_subprocess_launcher_get_type = FuncLoader.LoadFunction<d_g_subprocess_launcher_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_subprocess_launcher_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_subprocess_launcher_getenv(IntPtr raw, IntPtr variable);
		static d_g_subprocess_launcher_getenv g_subprocess_launcher_getenv = FuncLoader.LoadFunction<d_g_subprocess_launcher_getenv>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_getenv"));

		public string Getenv(string variable) {
			IntPtr native_variable = GLib.Marshaller.StringToPtrGStrdup (variable);
			IntPtr raw_ret = g_subprocess_launcher_getenv(Handle, native_variable);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_variable);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_launcher_set_child_setup(IntPtr raw, GLibSharp.SpawnChildSetupFuncNative child_setup, IntPtr user_data, GLib.DestroyNotify destroy_notify);
		static d_g_subprocess_launcher_set_child_setup g_subprocess_launcher_set_child_setup = FuncLoader.LoadFunction<d_g_subprocess_launcher_set_child_setup>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_set_child_setup"));

		public GLib.SpawnChildSetupFunc ChildSetup { 
			set {
				GLibSharp.SpawnChildSetupFuncWrapper value_wrapper = new GLibSharp.SpawnChildSetupFuncWrapper (value);
				IntPtr user_data;
				GLib.DestroyNotify destroy_notify;
				if (value == null) {
					user_data = IntPtr.Zero;
					destroy_notify = null;
				} else {
					user_data = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy_notify = GLib.DestroyHelper.NotifyHandler;
				}
				g_subprocess_launcher_set_child_setup(Handle, value_wrapper.NativeDelegate, user_data, destroy_notify);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_launcher_set_cwd(IntPtr raw, IntPtr cwd);
		static d_g_subprocess_launcher_set_cwd g_subprocess_launcher_set_cwd = FuncLoader.LoadFunction<d_g_subprocess_launcher_set_cwd>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_set_cwd"));

		public string Cwd { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_subprocess_launcher_set_cwd(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_launcher_set_environ(IntPtr raw, IntPtr env);
		static d_g_subprocess_launcher_set_environ g_subprocess_launcher_set_environ = FuncLoader.LoadFunction<d_g_subprocess_launcher_set_environ>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_set_environ"));

		public string Environ { 
			set {
				g_subprocess_launcher_set_environ(Handle, GLib.Marshaller.StringToPtrGStrdup(value));
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_launcher_set_stderr_file_path(IntPtr raw, IntPtr path);
		static d_g_subprocess_launcher_set_stderr_file_path g_subprocess_launcher_set_stderr_file_path = FuncLoader.LoadFunction<d_g_subprocess_launcher_set_stderr_file_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_set_stderr_file_path"));

		public string StderrFilePath { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_subprocess_launcher_set_stderr_file_path(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_launcher_set_stdin_file_path(IntPtr raw, IntPtr path);
		static d_g_subprocess_launcher_set_stdin_file_path g_subprocess_launcher_set_stdin_file_path = FuncLoader.LoadFunction<d_g_subprocess_launcher_set_stdin_file_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_set_stdin_file_path"));

		public string StdinFilePath { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_subprocess_launcher_set_stdin_file_path(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_launcher_set_stdout_file_path(IntPtr raw, IntPtr path);
		static d_g_subprocess_launcher_set_stdout_file_path g_subprocess_launcher_set_stdout_file_path = FuncLoader.LoadFunction<d_g_subprocess_launcher_set_stdout_file_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_set_stdout_file_path"));

		public string StdoutFilePath { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_subprocess_launcher_set_stdout_file_path(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_launcher_setenv(IntPtr raw, IntPtr variable, IntPtr value, bool overwrite);
		static d_g_subprocess_launcher_setenv g_subprocess_launcher_setenv = FuncLoader.LoadFunction<d_g_subprocess_launcher_setenv>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_setenv"));

		public void Setenv(string variable, string value, bool overwrite) {
			IntPtr native_variable = GLib.Marshaller.StringToPtrGStrdup (variable);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			g_subprocess_launcher_setenv(Handle, native_variable, native_value, overwrite);
			GLib.Marshaller.Free (native_variable);
			GLib.Marshaller.Free (native_value);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_subprocess_launcher_spawnv(IntPtr raw, IntPtr argv, out IntPtr error);
		static d_g_subprocess_launcher_spawnv g_subprocess_launcher_spawnv = FuncLoader.LoadFunction<d_g_subprocess_launcher_spawnv>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_spawnv"));

		public unsafe GLib.Subprocess Spawnv(string argv) {
			IntPtr native_argv = GLib.Marshaller.StringToPtrGStrdup (argv);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_subprocess_launcher_spawnv(Handle, native_argv, out error);
			GLib.Subprocess ret = GLib.Object.GetObject(raw_ret) as GLib.Subprocess;
			GLib.Marshaller.Free (native_argv);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_launcher_take_fd(IntPtr raw, int source_fd, int target_fd);
		static d_g_subprocess_launcher_take_fd g_subprocess_launcher_take_fd = FuncLoader.LoadFunction<d_g_subprocess_launcher_take_fd>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_take_fd"));

		public void TakeFd(int source_fd, int target_fd) {
			g_subprocess_launcher_take_fd(Handle, source_fd, target_fd);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_launcher_take_stderr_fd(IntPtr raw, int fd);
		static d_g_subprocess_launcher_take_stderr_fd g_subprocess_launcher_take_stderr_fd = FuncLoader.LoadFunction<d_g_subprocess_launcher_take_stderr_fd>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_take_stderr_fd"));

		public void TakeStderrFd(int fd) {
			g_subprocess_launcher_take_stderr_fd(Handle, fd);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_launcher_take_stdin_fd(IntPtr raw, int fd);
		static d_g_subprocess_launcher_take_stdin_fd g_subprocess_launcher_take_stdin_fd = FuncLoader.LoadFunction<d_g_subprocess_launcher_take_stdin_fd>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_take_stdin_fd"));

		public void TakeStdinFd(int fd) {
			g_subprocess_launcher_take_stdin_fd(Handle, fd);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_launcher_take_stdout_fd(IntPtr raw, int fd);
		static d_g_subprocess_launcher_take_stdout_fd g_subprocess_launcher_take_stdout_fd = FuncLoader.LoadFunction<d_g_subprocess_launcher_take_stdout_fd>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_take_stdout_fd"));

		public void TakeStdoutFd(int fd) {
			g_subprocess_launcher_take_stdout_fd(Handle, fd);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_subprocess_launcher_unsetenv(IntPtr raw, IntPtr variable);
		static d_g_subprocess_launcher_unsetenv g_subprocess_launcher_unsetenv = FuncLoader.LoadFunction<d_g_subprocess_launcher_unsetenv>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_subprocess_launcher_unsetenv"));

		public void Unsetenv(string variable) {
			IntPtr native_variable = GLib.Marshaller.StringToPtrGStrdup (variable);
			g_subprocess_launcher_unsetenv(Handle, native_variable);
			GLib.Marshaller.Free (native_variable);
		}

#endregion
	}
}