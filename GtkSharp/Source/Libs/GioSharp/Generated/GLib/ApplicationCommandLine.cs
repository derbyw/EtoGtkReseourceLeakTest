// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class ApplicationCommandLine : GLib.Object {

		public ApplicationCommandLine (IntPtr raw) : base(raw) {}

		protected ApplicationCommandLine() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_application_command_line_get_is_remote(IntPtr raw);
		static d_g_application_command_line_get_is_remote g_application_command_line_get_is_remote = FuncLoader.LoadFunction<d_g_application_command_line_get_is_remote>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_application_command_line_get_is_remote"));

		[GLib.Property ("is-remote")]
		public bool IsRemote {
			get  {
				bool raw_ret = g_application_command_line_get_is_remote(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		static PrintLiteralNativeDelegate PrintLiteral_cb_delegate;
		static PrintLiteralNativeDelegate PrintLiteralVMCallback {
			get {
				if (PrintLiteral_cb_delegate == null)
					PrintLiteral_cb_delegate = new PrintLiteralNativeDelegate (PrintLiteral_cb);
				return PrintLiteral_cb_delegate;
			}
		}

		static void OverridePrintLiteral (GLib.GType gtype)
		{
			OverridePrintLiteral (gtype, PrintLiteralVMCallback);
		}

		static void OverridePrintLiteral (GLib.GType gtype, PrintLiteralNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("print_literal"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PrintLiteralNativeDelegate (IntPtr inst, IntPtr message);

		static void PrintLiteral_cb (IntPtr inst, IntPtr message)
		{
			try {
				ApplicationCommandLine __obj = GLib.Object.GetObject (inst, false) as ApplicationCommandLine;
				__obj.OnPrintLiteral (GLib.Marshaller.Utf8PtrToString (message));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.ApplicationCommandLine), ConnectionMethod="OverridePrintLiteral")]
		protected virtual void OnPrintLiteral (string message)
		{
			InternalPrintLiteral (message);
		}

		private void InternalPrintLiteral (string message)
		{
			PrintLiteralNativeDelegate unmanaged = class_abi.BaseOverride<PrintLiteralNativeDelegate>(this.LookupGType(), "print_literal");
			if (unmanaged == null) return;

			IntPtr native_message = GLib.Marshaller.StringToPtrGStrdup (message);
			unmanaged (this.Handle, native_message);
			GLib.Marshaller.Free (native_message);
		}

		static PrinterrLiteralNativeDelegate PrinterrLiteral_cb_delegate;
		static PrinterrLiteralNativeDelegate PrinterrLiteralVMCallback {
			get {
				if (PrinterrLiteral_cb_delegate == null)
					PrinterrLiteral_cb_delegate = new PrinterrLiteralNativeDelegate (PrinterrLiteral_cb);
				return PrinterrLiteral_cb_delegate;
			}
		}

		static void OverridePrinterrLiteral (GLib.GType gtype)
		{
			OverridePrinterrLiteral (gtype, PrinterrLiteralVMCallback);
		}

		static void OverridePrinterrLiteral (GLib.GType gtype, PrinterrLiteralNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("printerr_literal"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PrinterrLiteralNativeDelegate (IntPtr inst, IntPtr message);

		static void PrinterrLiteral_cb (IntPtr inst, IntPtr message)
		{
			try {
				ApplicationCommandLine __obj = GLib.Object.GetObject (inst, false) as ApplicationCommandLine;
				__obj.OnPrinterrLiteral (GLib.Marshaller.Utf8PtrToString (message));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.ApplicationCommandLine), ConnectionMethod="OverridePrinterrLiteral")]
		protected virtual void OnPrinterrLiteral (string message)
		{
			InternalPrinterrLiteral (message);
		}

		private void InternalPrinterrLiteral (string message)
		{
			PrinterrLiteralNativeDelegate unmanaged = class_abi.BaseOverride<PrinterrLiteralNativeDelegate>(this.LookupGType(), "printerr_literal");
			if (unmanaged == null) return;

			IntPtr native_message = GLib.Marshaller.StringToPtrGStrdup (message);
			unmanaged (this.Handle, native_message);
			GLib.Marshaller.Free (native_message);
		}

		static GetStdinNativeDelegate GetStdin_cb_delegate;
		static GetStdinNativeDelegate GetStdinVMCallback {
			get {
				if (GetStdin_cb_delegate == null)
					GetStdin_cb_delegate = new GetStdinNativeDelegate (GetStdin_cb);
				return GetStdin_cb_delegate;
			}
		}

		static void OverrideGetStdin (GLib.GType gtype)
		{
			OverrideGetStdin (gtype, GetStdinVMCallback);
		}

		static void OverrideGetStdin (GLib.GType gtype, GetStdinNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_stdin"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetStdinNativeDelegate (IntPtr inst);

		static IntPtr GetStdin_cb (IntPtr inst)
		{
			try {
				ApplicationCommandLine __obj = GLib.Object.GetObject (inst, false) as ApplicationCommandLine;
				GLib.InputStream __result;
				__result = __obj.OnGetStdin ();
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.ApplicationCommandLine), ConnectionMethod="OverrideGetStdin")]
		protected virtual GLib.InputStream OnGetStdin ()
		{
			return InternalGetStdin ();
		}

		private GLib.InputStream InternalGetStdin ()
		{
			GetStdinNativeDelegate unmanaged = class_abi.BaseOverride<GetStdinNativeDelegate>(this.LookupGType(), "get_stdin");
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle);
			return GLib.Object.GetObject(__result) as GLib.InputStream;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("print_literal"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // print_literal
							, null
							, "printerr_literal"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("printerr_literal"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // printerr_literal
							, "print_literal"
							, "get_stdin"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_stdin"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_stdin
							, "printerr_literal"
							, "padding"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("padding"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 11 // padding
							, "get_stdin"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_application_command_line_create_file_for_arg(IntPtr raw, IntPtr arg);
		static d_g_application_command_line_create_file_for_arg g_application_command_line_create_file_for_arg = FuncLoader.LoadFunction<d_g_application_command_line_create_file_for_arg>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_application_command_line_create_file_for_arg"));

		public GLib.IFile CreateFileForArg(string arg) {
			IntPtr native_arg = GLib.Marshaller.StringToPtrGStrdup (arg);
			IntPtr raw_ret = g_application_command_line_create_file_for_arg(Handle, native_arg);
			GLib.IFile ret = GLib.FileAdapter.GetObject (raw_ret, false);
			GLib.Marshaller.Free (native_arg);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_application_command_line_get_arguments(IntPtr raw, out int argc);
		static d_g_application_command_line_get_arguments g_application_command_line_get_arguments = FuncLoader.LoadFunction<d_g_application_command_line_get_arguments>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_application_command_line_get_arguments"));

		public string GetArguments(out int argc) {
			IntPtr raw_ret = g_application_command_line_get_arguments(Handle, out argc);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_application_command_line_get_cwd(IntPtr raw);
		static d_g_application_command_line_get_cwd g_application_command_line_get_cwd = FuncLoader.LoadFunction<d_g_application_command_line_get_cwd>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_application_command_line_get_cwd"));

		public string Cwd { 
			get {
				IntPtr raw_ret = g_application_command_line_get_cwd(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_application_command_line_get_environ(IntPtr raw);
		static d_g_application_command_line_get_environ g_application_command_line_get_environ = FuncLoader.LoadFunction<d_g_application_command_line_get_environ>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_application_command_line_get_environ"));

		public string Environ { 
			get {
				IntPtr raw_ret = g_application_command_line_get_environ(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_application_command_line_get_exit_status(IntPtr raw);
		static d_g_application_command_line_get_exit_status g_application_command_line_get_exit_status = FuncLoader.LoadFunction<d_g_application_command_line_get_exit_status>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_application_command_line_get_exit_status"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_application_command_line_set_exit_status(IntPtr raw, int exit_status);
		static d_g_application_command_line_set_exit_status g_application_command_line_set_exit_status = FuncLoader.LoadFunction<d_g_application_command_line_set_exit_status>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_application_command_line_set_exit_status"));

		public int ExitStatus { 
			get {
				int raw_ret = g_application_command_line_get_exit_status(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				g_application_command_line_set_exit_status(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_application_command_line_get_platform_data(IntPtr raw);
		static d_g_application_command_line_get_platform_data g_application_command_line_get_platform_data = FuncLoader.LoadFunction<d_g_application_command_line_get_platform_data>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_application_command_line_get_platform_data"));

		public GLib.Variant PlatformData { 
			get {
				IntPtr raw_ret = g_application_command_line_get_platform_data(Handle);
				GLib.Variant ret = new GLib.Variant(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_application_command_line_get_stdin(IntPtr raw);
		static d_g_application_command_line_get_stdin g_application_command_line_get_stdin = FuncLoader.LoadFunction<d_g_application_command_line_get_stdin>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_application_command_line_get_stdin"));

		public GLib.InputStream Stdin { 
			get {
				IntPtr raw_ret = g_application_command_line_get_stdin(Handle);
				GLib.InputStream ret = GLib.Object.GetObject(raw_ret) as GLib.InputStream;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_application_command_line_get_type();
		static d_g_application_command_line_get_type g_application_command_line_get_type = FuncLoader.LoadFunction<d_g_application_command_line_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_application_command_line_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_application_command_line_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_application_command_line_getenv(IntPtr raw, IntPtr name);
		static d_g_application_command_line_getenv g_application_command_line_getenv = FuncLoader.LoadFunction<d_g_application_command_line_getenv>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_application_command_line_getenv"));

		public string Getenv(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = g_application_command_line_getenv(Handle, native_name);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_name);
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}