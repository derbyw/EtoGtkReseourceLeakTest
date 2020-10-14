// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class IOModuleScope : GLib.Opaque {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_io_module_scope_block(IntPtr raw, IntPtr basename);
		static d_g_io_module_scope_block g_io_module_scope_block = FuncLoader.LoadFunction<d_g_io_module_scope_block>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_io_module_scope_block"));

		public void Block(string basename) {
			IntPtr native_basename = GLib.Marshaller.StringToPtrGStrdup (basename);
			g_io_module_scope_block(Handle, native_basename);
			GLib.Marshaller.Free (native_basename);
		}

		public IOModuleScope(IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_io_module_scope_new(int flags);
		static d_g_io_module_scope_new g_io_module_scope_new = FuncLoader.LoadFunction<d_g_io_module_scope_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_io_module_scope_new"));

		public IOModuleScope (GLib.IOModuleScopeFlags flags) 
		{
			Raw = g_io_module_scope_new((int) flags);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_io_module_scope_free(IntPtr raw);
		static d_g_io_module_scope_free g_io_module_scope_free = FuncLoader.LoadFunction<d_g_io_module_scope_free>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_io_module_scope_free"));

		protected override void Free (IntPtr raw)
		{
			g_io_module_scope_free (raw);
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
				g_io_module_scope_free (handle);
				GLib.Timeout.Remove(timeoutHandlerId);
				return false;
			}
		}

		~IOModuleScope ()
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
