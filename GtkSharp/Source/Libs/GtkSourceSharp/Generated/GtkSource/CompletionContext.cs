// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class CompletionContext : GLib.InitiallyUnowned {

		public CompletionContext (IntPtr raw) : base(raw) {}

		protected CompletionContext() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("completion")]
		public GtkSource.Completion Completion {
			get {
				GLib.Value val = GetProperty ("completion");
				GtkSource.Completion ret = (GtkSource.Completion) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("iter")]
		public Gtk.TextIter Iter {
			get {
				GLib.Value val = GetProperty ("iter");
				Gtk.TextIter ret = (Gtk.TextIter) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = (GLib.Value) value;
				SetProperty("iter", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_source_completion_context_get_activation(IntPtr raw);
		static d_gtk_source_completion_context_get_activation gtk_source_completion_context_get_activation = FuncLoader.LoadFunction<d_gtk_source_completion_context_get_activation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_context_get_activation"));

		[GLib.Property ("activation")]
		public GtkSource.CompletionActivation Activation {
			get  {
				int raw_ret = gtk_source_completion_context_get_activation(Handle);
				GtkSource.CompletionActivation ret = (GtkSource.CompletionActivation) raw_ret;
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("activation", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("cancelled")]
		public event System.EventHandler Cancelled {
			add {
				this.AddSignalHandler ("cancelled", value);
			}
			remove {
				this.RemoveSignalHandler ("cancelled", value);
			}
		}

		static CancelledNativeDelegate Cancelled_cb_delegate;
		static CancelledNativeDelegate CancelledVMCallback {
			get {
				if (Cancelled_cb_delegate == null)
					Cancelled_cb_delegate = new CancelledNativeDelegate (Cancelled_cb);
				return Cancelled_cb_delegate;
			}
		}

		static void OverrideCancelled (GLib.GType gtype)
		{
			OverrideCancelled (gtype, CancelledVMCallback);
		}

		static void OverrideCancelled (GLib.GType gtype, CancelledNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("cancelled"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CancelledNativeDelegate (IntPtr inst);

		static void Cancelled_cb (IntPtr inst)
		{
			try {
				CompletionContext __obj = GLib.Object.GetObject (inst, false) as CompletionContext;
				__obj.OnCancelled ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GtkSource.CompletionContext), ConnectionMethod="OverrideCancelled")]
		protected virtual void OnCancelled ()
		{
			InternalCancelled ();
		}

		private void InternalCancelled ()
		{
			CancelledNativeDelegate unmanaged = class_abi.BaseOverride<CancelledNativeDelegate>(this.LookupGType(), "cancelled");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("cancelled"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // cancelled
							, null
							, "padding"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("padding"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 10 // padding
							, "cancelled"
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
		delegate void d_gtk_source_completion_context_add_proposals(IntPtr raw, IntPtr provider, IntPtr proposals, bool finished);
		static d_gtk_source_completion_context_add_proposals gtk_source_completion_context_add_proposals = FuncLoader.LoadFunction<d_gtk_source_completion_context_add_proposals>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_context_add_proposals"));

		public void AddProposals(GtkSource.ICompletionProvider provider, GLib.List proposals, bool finished) {
			gtk_source_completion_context_add_proposals(Handle, provider == null ? IntPtr.Zero : ((provider is GLib.Object) ? (provider as GLib.Object).Handle : (provider as GtkSource.CompletionProviderAdapter).Handle), proposals == null ? IntPtr.Zero : proposals.Handle, finished);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_source_completion_context_get_iter(IntPtr raw, IntPtr iter);
		static d_gtk_source_completion_context_get_iter gtk_source_completion_context_get_iter = FuncLoader.LoadFunction<d_gtk_source_completion_context_get_iter>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_context_get_iter"));

		public bool GetIter(Gtk.TextIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool raw_ret = gtk_source_completion_context_get_iter(Handle, native_iter);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_completion_context_get_type();
		static d_gtk_source_completion_context_get_type gtk_source_completion_context_get_type = FuncLoader.LoadFunction<d_gtk_source_completion_context_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_context_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_source_completion_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static CompletionContext ()
		{
			GtkSharp.GtkSourceSharp.ObjectManager.Initialize ();
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
