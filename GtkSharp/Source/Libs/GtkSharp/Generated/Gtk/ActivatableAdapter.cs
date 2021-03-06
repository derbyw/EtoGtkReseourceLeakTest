// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ActivatableAdapter : GLib.GInterfaceAdapter, Gtk.IActivatable {

		[StructLayout (LayoutKind.Sequential)]
		struct GtkActivatableIface {
			IntPtr Update;
			public SyncActionPropertiesNativeDelegate SyncActionProperties;
		}

		static GtkActivatableIface iface;

		static ActivatableAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (ActivatableAdapter));
			iface.SyncActionProperties = new SyncActionPropertiesNativeDelegate (SyncActionProperties_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SyncActionPropertiesNativeDelegate (IntPtr inst, IntPtr action);

		static void SyncActionProperties_cb (IntPtr inst, IntPtr action)
		{
			try {
				IActivatableImplementor __obj = GLib.Object.GetObject (inst, false) as IActivatableImplementor;
				__obj.SyncActionProperties (GLib.Object.GetObject(action) as Gtk.Action);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GtkActivatableIface native_iface = (GtkActivatableIface) Marshal.PtrToStructure (ifaceptr, typeof (GtkActivatableIface));
			native_iface.SyncActionProperties = iface.SyncActionProperties;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public ActivatableAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public ActivatableAdapter (IActivatableImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public ActivatableAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_activatable_get_type();
		static d_gtk_activatable_get_type gtk_activatable_get_type = FuncLoader.LoadFunction<d_gtk_activatable_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_get_type"));

		private static GLib.GType _gtype = new GLib.GType (gtk_activatable_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static IActivatable GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IActivatable GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IActivatableImplementor)
				return new ActivatableAdapter (obj as IActivatableImplementor);
			else if (obj as IActivatable == null)
				return new ActivatableAdapter (obj.Handle);
			else
				return obj as IActivatable;
		}

		public IActivatableImplementor Implementor {
			get {
				return implementor as IActivatableImplementor;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_activatable_get_related_action(IntPtr raw);
		static d_gtk_activatable_get_related_action gtk_activatable_get_related_action = FuncLoader.LoadFunction<d_gtk_activatable_get_related_action>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_get_related_action"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_activatable_set_related_action(IntPtr raw, IntPtr action);
		static d_gtk_activatable_set_related_action gtk_activatable_set_related_action = FuncLoader.LoadFunction<d_gtk_activatable_set_related_action>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_set_related_action"));

		[Obsolete]
		[GLib.Property ("related-action")]
		public Gtk.Action RelatedAction {
			get  {
				IntPtr raw_ret = gtk_activatable_get_related_action(Handle);
				Gtk.Action ret = GLib.Object.GetObject(raw_ret) as Gtk.Action;
				return ret;
			}
			set  {
				gtk_activatable_set_related_action(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_activatable_get_use_action_appearance(IntPtr raw);
		static d_gtk_activatable_get_use_action_appearance gtk_activatable_get_use_action_appearance = FuncLoader.LoadFunction<d_gtk_activatable_get_use_action_appearance>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_get_use_action_appearance"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_activatable_set_use_action_appearance(IntPtr raw, bool use_appearance);
		static d_gtk_activatable_set_use_action_appearance gtk_activatable_set_use_action_appearance = FuncLoader.LoadFunction<d_gtk_activatable_set_use_action_appearance>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_set_use_action_appearance"));

		[Obsolete]
		[GLib.Property ("use-action-appearance")]
		public bool UseActionAppearance {
			get  {
				bool raw_ret = gtk_activatable_get_use_action_appearance(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_activatable_set_use_action_appearance(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_activatable_do_set_related_action(IntPtr raw, IntPtr action);
		static d_gtk_activatable_do_set_related_action gtk_activatable_do_set_related_action = FuncLoader.LoadFunction<d_gtk_activatable_do_set_related_action>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_do_set_related_action"));

		[Obsolete]
		public void DoSetRelatedAction(Gtk.Action action) {
			gtk_activatable_do_set_related_action(Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_activatable_sync_action_properties(IntPtr raw, IntPtr action);
		static d_gtk_activatable_sync_action_properties gtk_activatable_sync_action_properties = FuncLoader.LoadFunction<d_gtk_activatable_sync_action_properties>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_sync_action_properties"));

		[Obsolete]
		public void SyncActionProperties(Gtk.Action action) {
			gtk_activatable_sync_action_properties(Handle, action == null ? IntPtr.Zero : action.Handle);
		}

#endregion
	}
}
