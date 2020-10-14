// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class CompletionProviderAdapter : GLib.GInterfaceAdapter, GtkSource.ICompletionProvider {

		[StructLayout (LayoutKind.Sequential)]
		struct GtkSourceCompletionProviderIface {
			public GetNameNativeDelegate GetName;
			public GetIconNativeDelegate GetIcon;
			public GetIconNameNativeDelegate GetIconName;
			public GetGiconNativeDelegate GetGicon;
			public PopulateNativeDelegate Populate;
			public MatchNativeDelegate Match;
			public GetActivationNativeDelegate GetActivation;
			public GetInfoWidgetNativeDelegate GetInfoWidget;
			public UpdateInfoNativeDelegate UpdateInfo;
			public GetStartIterNativeDelegate GetStartIter;
			public ActivateProposalNativeDelegate ActivateProposal;
			public GetInteractiveDelayNativeDelegate GetInteractiveDelay;
			public GetPriorityNativeDelegate GetPriority;
		}

		static GtkSourceCompletionProviderIface iface;

		static CompletionProviderAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (CompletionProviderAdapter));
			iface.GetName = new GetNameNativeDelegate (GetName_cb);
			iface.GetIcon = new GetIconNativeDelegate (GetIcon_cb);
			iface.GetIconName = new GetIconNameNativeDelegate (GetIconName_cb);
			iface.GetGicon = new GetGiconNativeDelegate (GetGicon_cb);
			iface.Populate = new PopulateNativeDelegate (Populate_cb);
			iface.Match = new MatchNativeDelegate (Match_cb);
			iface.GetActivation = new GetActivationNativeDelegate (GetActivation_cb);
			iface.GetInfoWidget = new GetInfoWidgetNativeDelegate (GetInfoWidget_cb);
			iface.UpdateInfo = new UpdateInfoNativeDelegate (UpdateInfo_cb);
			iface.GetStartIter = new GetStartIterNativeDelegate (GetStartIter_cb);
			iface.ActivateProposal = new ActivateProposalNativeDelegate (ActivateProposal_cb);
			iface.GetInteractiveDelay = new GetInteractiveDelayNativeDelegate (GetInteractiveDelay_cb);
			iface.GetPriority = new GetPriorityNativeDelegate (GetPriority_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetNameNativeDelegate (IntPtr inst);

		static IntPtr GetName_cb (IntPtr inst)
		{
			try {
				ICompletionProviderImplementor __obj = GLib.Object.GetObject (inst, false) as ICompletionProviderImplementor;
				string __result;
				__result = __obj.Name;
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetIconNativeDelegate (IntPtr inst);

		static IntPtr GetIcon_cb (IntPtr inst)
		{
			try {
				ICompletionProviderImplementor __obj = GLib.Object.GetObject (inst, false) as ICompletionProviderImplementor;
				Gdk.Pixbuf __result;
				__result = __obj.Icon;
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetIconNameNativeDelegate (IntPtr inst);

		static IntPtr GetIconName_cb (IntPtr inst)
		{
			try {
				ICompletionProviderImplementor __obj = GLib.Object.GetObject (inst, false) as ICompletionProviderImplementor;
				string __result;
				__result = __obj.IconName;
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetGiconNativeDelegate (IntPtr inst);

		static IntPtr GetGicon_cb (IntPtr inst)
		{
			try {
				ICompletionProviderImplementor __obj = GLib.Object.GetObject (inst, false) as ICompletionProviderImplementor;
				GLib.IIcon __result;
				__result = __obj.Gicon;
				return __result == null ? IntPtr.Zero : ((__result is GLib.Object) ? (__result as GLib.Object).Handle : (__result as GLib.IconAdapter).Handle);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PopulateNativeDelegate (IntPtr inst, IntPtr context);

		static void Populate_cb (IntPtr inst, IntPtr context)
		{
			try {
				ICompletionProviderImplementor __obj = GLib.Object.GetObject (inst, false) as ICompletionProviderImplementor;
				__obj.Populate (GLib.Object.GetObject(context) as GtkSource.CompletionContext);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool MatchNativeDelegate (IntPtr inst, IntPtr context);

		static bool Match_cb (IntPtr inst, IntPtr context)
		{
			try {
				ICompletionProviderImplementor __obj = GLib.Object.GetObject (inst, false) as ICompletionProviderImplementor;
				bool __result;
				__result = __obj.Match (GLib.Object.GetObject(context) as GtkSource.CompletionContext);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetActivationNativeDelegate (IntPtr inst);

		static int GetActivation_cb (IntPtr inst)
		{
			try {
				ICompletionProviderImplementor __obj = GLib.Object.GetObject (inst, false) as ICompletionProviderImplementor;
				GtkSource.CompletionActivation __result;
				__result = __obj.Activation;
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetInfoWidgetNativeDelegate (IntPtr inst, IntPtr proposal);

		static IntPtr GetInfoWidget_cb (IntPtr inst, IntPtr proposal)
		{
			try {
				ICompletionProviderImplementor __obj = GLib.Object.GetObject (inst, false) as ICompletionProviderImplementor;
				Gtk.Widget __result;
				__result = __obj.GetInfoWidget (GtkSource.CompletionProposalAdapter.GetObject (proposal, false));
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void UpdateInfoNativeDelegate (IntPtr inst, IntPtr proposal, IntPtr info);

		static void UpdateInfo_cb (IntPtr inst, IntPtr proposal, IntPtr info)
		{
			try {
				ICompletionProviderImplementor __obj = GLib.Object.GetObject (inst, false) as ICompletionProviderImplementor;
				__obj.UpdateInfo (GtkSource.CompletionProposalAdapter.GetObject (proposal, false), GLib.Object.GetObject(info) as GtkSource.CompletionInfo);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool GetStartIterNativeDelegate (IntPtr inst, IntPtr context, IntPtr proposal, IntPtr iter);

		static bool GetStartIter_cb (IntPtr inst, IntPtr context, IntPtr proposal, IntPtr iter)
		{
			try {
				ICompletionProviderImplementor __obj = GLib.Object.GetObject (inst, false) as ICompletionProviderImplementor;
				bool __result;
				__result = __obj.GetStartIter (GLib.Object.GetObject(context) as GtkSource.CompletionContext, GtkSource.CompletionProposalAdapter.GetObject (proposal, false), Gtk.TextIter.New (iter));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ActivateProposalNativeDelegate (IntPtr inst, IntPtr proposal, IntPtr iter);

		static bool ActivateProposal_cb (IntPtr inst, IntPtr proposal, IntPtr iter)
		{
			try {
				ICompletionProviderImplementor __obj = GLib.Object.GetObject (inst, false) as ICompletionProviderImplementor;
				bool __result;
				__result = __obj.ActivateProposal (GtkSource.CompletionProposalAdapter.GetObject (proposal, false), Gtk.TextIter.New (iter));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetInteractiveDelayNativeDelegate (IntPtr inst);

		static int GetInteractiveDelay_cb (IntPtr inst)
		{
			try {
				ICompletionProviderImplementor __obj = GLib.Object.GetObject (inst, false) as ICompletionProviderImplementor;
				int __result;
				__result = __obj.InteractiveDelay;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetPriorityNativeDelegate (IntPtr inst);

		static int GetPriority_cb (IntPtr inst)
		{
			try {
				ICompletionProviderImplementor __obj = GLib.Object.GetObject (inst, false) as ICompletionProviderImplementor;
				int __result;
				__result = __obj.Priority;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GtkSourceCompletionProviderIface native_iface = (GtkSourceCompletionProviderIface) Marshal.PtrToStructure (ifaceptr, typeof (GtkSourceCompletionProviderIface));
			native_iface.GetName = iface.GetName;
			native_iface.GetIcon = iface.GetIcon;
			native_iface.GetIconName = iface.GetIconName;
			native_iface.GetGicon = iface.GetGicon;
			native_iface.Populate = iface.Populate;
			native_iface.Match = iface.Match;
			native_iface.GetActivation = iface.GetActivation;
			native_iface.GetInfoWidget = iface.GetInfoWidget;
			native_iface.UpdateInfo = iface.UpdateInfo;
			native_iface.GetStartIter = iface.GetStartIter;
			native_iface.ActivateProposal = iface.ActivateProposal;
			native_iface.GetInteractiveDelay = iface.GetInteractiveDelay;
			native_iface.GetPriority = iface.GetPriority;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public CompletionProviderAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public CompletionProviderAdapter (ICompletionProviderImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public CompletionProviderAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_completion_provider_get_type();
		static d_gtk_source_completion_provider_get_type gtk_source_completion_provider_get_type = FuncLoader.LoadFunction<d_gtk_source_completion_provider_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_provider_get_type"));

		private static GLib.GType _gtype = new GLib.GType (gtk_source_completion_provider_get_type ());

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

		public static ICompletionProvider GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static ICompletionProvider GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is ICompletionProviderImplementor)
				return new CompletionProviderAdapter (obj as ICompletionProviderImplementor);
			else if (obj as ICompletionProvider == null)
				return new CompletionProviderAdapter (obj.Handle);
			else
				return obj as ICompletionProvider;
		}

		public ICompletionProviderImplementor Implementor {
			get {
				return implementor as ICompletionProviderImplementor;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_source_completion_provider_activate_proposal(IntPtr raw, IntPtr proposal, IntPtr iter);
		static d_gtk_source_completion_provider_activate_proposal gtk_source_completion_provider_activate_proposal = FuncLoader.LoadFunction<d_gtk_source_completion_provider_activate_proposal>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_provider_activate_proposal"));

		public bool ActivateProposal(GtkSource.ICompletionProposal proposal, Gtk.TextIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool raw_ret = gtk_source_completion_provider_activate_proposal(Handle, proposal == null ? IntPtr.Zero : ((proposal is GLib.Object) ? (proposal as GLib.Object).Handle : (proposal as GtkSource.CompletionProposalAdapter).Handle), native_iter);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_source_completion_provider_get_activation(IntPtr raw);
		static d_gtk_source_completion_provider_get_activation gtk_source_completion_provider_get_activation = FuncLoader.LoadFunction<d_gtk_source_completion_provider_get_activation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_provider_get_activation"));

		public GtkSource.CompletionActivation Activation { 
			get {
				int raw_ret = gtk_source_completion_provider_get_activation(Handle);
				GtkSource.CompletionActivation ret = (GtkSource.CompletionActivation) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_completion_provider_get_gicon(IntPtr raw);
		static d_gtk_source_completion_provider_get_gicon gtk_source_completion_provider_get_gicon = FuncLoader.LoadFunction<d_gtk_source_completion_provider_get_gicon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_provider_get_gicon"));

		public GLib.IIcon Gicon { 
			get {
				IntPtr raw_ret = gtk_source_completion_provider_get_gicon(Handle);
				GLib.IIcon ret = GLib.IconAdapter.GetObject (raw_ret, false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_completion_provider_get_icon(IntPtr raw);
		static d_gtk_source_completion_provider_get_icon gtk_source_completion_provider_get_icon = FuncLoader.LoadFunction<d_gtk_source_completion_provider_get_icon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_provider_get_icon"));

		public Gdk.Pixbuf Icon { 
			get {
				IntPtr raw_ret = gtk_source_completion_provider_get_icon(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_completion_provider_get_icon_name(IntPtr raw);
		static d_gtk_source_completion_provider_get_icon_name gtk_source_completion_provider_get_icon_name = FuncLoader.LoadFunction<d_gtk_source_completion_provider_get_icon_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_provider_get_icon_name"));

		public string IconName { 
			get {
				IntPtr raw_ret = gtk_source_completion_provider_get_icon_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_completion_provider_get_info_widget(IntPtr raw, IntPtr proposal);
		static d_gtk_source_completion_provider_get_info_widget gtk_source_completion_provider_get_info_widget = FuncLoader.LoadFunction<d_gtk_source_completion_provider_get_info_widget>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_provider_get_info_widget"));

		public Gtk.Widget GetInfoWidget(GtkSource.ICompletionProposal proposal) {
			IntPtr raw_ret = gtk_source_completion_provider_get_info_widget(Handle, proposal == null ? IntPtr.Zero : ((proposal is GLib.Object) ? (proposal as GLib.Object).Handle : (proposal as GtkSource.CompletionProposalAdapter).Handle));
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_source_completion_provider_get_interactive_delay(IntPtr raw);
		static d_gtk_source_completion_provider_get_interactive_delay gtk_source_completion_provider_get_interactive_delay = FuncLoader.LoadFunction<d_gtk_source_completion_provider_get_interactive_delay>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_provider_get_interactive_delay"));

		public int InteractiveDelay { 
			get {
				int raw_ret = gtk_source_completion_provider_get_interactive_delay(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_completion_provider_get_name(IntPtr raw);
		static d_gtk_source_completion_provider_get_name gtk_source_completion_provider_get_name = FuncLoader.LoadFunction<d_gtk_source_completion_provider_get_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_provider_get_name"));

		public string Name { 
			get {
				IntPtr raw_ret = gtk_source_completion_provider_get_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_source_completion_provider_get_priority(IntPtr raw);
		static d_gtk_source_completion_provider_get_priority gtk_source_completion_provider_get_priority = FuncLoader.LoadFunction<d_gtk_source_completion_provider_get_priority>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_provider_get_priority"));

		public int Priority { 
			get {
				int raw_ret = gtk_source_completion_provider_get_priority(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_source_completion_provider_get_start_iter(IntPtr raw, IntPtr context, IntPtr proposal, IntPtr iter);
		static d_gtk_source_completion_provider_get_start_iter gtk_source_completion_provider_get_start_iter = FuncLoader.LoadFunction<d_gtk_source_completion_provider_get_start_iter>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_provider_get_start_iter"));

		public bool GetStartIter(GtkSource.CompletionContext context, GtkSource.ICompletionProposal proposal, Gtk.TextIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool raw_ret = gtk_source_completion_provider_get_start_iter(Handle, context == null ? IntPtr.Zero : context.Handle, proposal == null ? IntPtr.Zero : ((proposal is GLib.Object) ? (proposal as GLib.Object).Handle : (proposal as GtkSource.CompletionProposalAdapter).Handle), native_iter);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_source_completion_provider_match(IntPtr raw, IntPtr context);
		static d_gtk_source_completion_provider_match gtk_source_completion_provider_match = FuncLoader.LoadFunction<d_gtk_source_completion_provider_match>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_provider_match"));

		public bool Match(GtkSource.CompletionContext context) {
			bool raw_ret = gtk_source_completion_provider_match(Handle, context == null ? IntPtr.Zero : context.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_completion_provider_populate(IntPtr raw, IntPtr context);
		static d_gtk_source_completion_provider_populate gtk_source_completion_provider_populate = FuncLoader.LoadFunction<d_gtk_source_completion_provider_populate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_provider_populate"));

		public void Populate(GtkSource.CompletionContext context) {
			gtk_source_completion_provider_populate(Handle, context == null ? IntPtr.Zero : context.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_completion_provider_update_info(IntPtr raw, IntPtr proposal, IntPtr info);
		static d_gtk_source_completion_provider_update_info gtk_source_completion_provider_update_info = FuncLoader.LoadFunction<d_gtk_source_completion_provider_update_info>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_completion_provider_update_info"));

		public void UpdateInfo(GtkSource.ICompletionProposal proposal, GtkSource.CompletionInfo info) {
			gtk_source_completion_provider_update_info(Handle, proposal == null ? IntPtr.Zero : ((proposal is GLib.Object) ? (proposal as GLib.Object).Handle : (proposal as GtkSource.CompletionProposalAdapter).Handle), info == null ? IntPtr.Zero : info.Handle);
		}

#endregion
	}
}