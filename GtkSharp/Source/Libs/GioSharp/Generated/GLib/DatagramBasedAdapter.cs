// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class DatagramBasedAdapter : GLib.GInterfaceAdapter, GLib.IDatagramBased {

		[StructLayout (LayoutKind.Sequential)]
		struct GDatagramBasedInterface {
			public ReceiveMessagesNativeDelegate ReceiveMessages;
			public SendMessagesNativeDelegate SendMessages;
			public CreateSourceNativeDelegate CreateSource;
			public ConditionCheckNativeDelegate ConditionCheck;
			public ConditionWaitNativeDelegate ConditionWait;
		}

		static GDatagramBasedInterface iface;

		static DatagramBasedAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (DatagramBasedAdapter));
			iface.ReceiveMessages = new ReceiveMessagesNativeDelegate (ReceiveMessages_cb);
			iface.SendMessages = new SendMessagesNativeDelegate (SendMessages_cb);
			iface.CreateSource = new CreateSourceNativeDelegate (CreateSource_cb);
			iface.ConditionCheck = new ConditionCheckNativeDelegate (ConditionCheck_cb);
			iface.ConditionWait = new ConditionWaitNativeDelegate (ConditionWait_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int ReceiveMessagesNativeDelegate (IntPtr inst, IntPtr messages, uint num_messages, int flags, long timeout, IntPtr cancellable, out IntPtr error);

		static int ReceiveMessages_cb (IntPtr inst, IntPtr messages, uint num_messages, int flags, long timeout, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				IDatagramBasedImplementor __obj = GLib.Object.GetObject (inst, false) as IDatagramBasedImplementor;
				int __result;
				__result = __obj.ReceiveMessages (GLib.InputMessage.New (messages), num_messages, flags, timeout, GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int SendMessagesNativeDelegate (IntPtr inst, IntPtr messages, uint num_messages, int flags, long timeout, IntPtr cancellable, out IntPtr error);

		static int SendMessages_cb (IntPtr inst, IntPtr messages, uint num_messages, int flags, long timeout, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				IDatagramBasedImplementor __obj = GLib.Object.GetObject (inst, false) as IDatagramBasedImplementor;
				int __result;
				__result = __obj.SendMessages (GLib.OutputMessage.New (messages), num_messages, flags, timeout, GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr CreateSourceNativeDelegate (IntPtr inst, int condition, IntPtr cancellable);

		static IntPtr CreateSource_cb (IntPtr inst, int condition, IntPtr cancellable)
		{
			try {
				IDatagramBasedImplementor __obj = GLib.Object.GetObject (inst, false) as IDatagramBasedImplementor;
				GLib.Source __result;
				__result = __obj.CreateSource ((GLib.IOCondition) condition, GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int ConditionCheckNativeDelegate (IntPtr inst, int condition);

		static int ConditionCheck_cb (IntPtr inst, int condition)
		{
			try {
				IDatagramBasedImplementor __obj = GLib.Object.GetObject (inst, false) as IDatagramBasedImplementor;
				GLib.IOCondition __result;
				__result = __obj.ConditionCheck ((GLib.IOCondition) condition);
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ConditionWaitNativeDelegate (IntPtr inst, int condition, long timeout, IntPtr cancellable, out IntPtr error);

		static bool ConditionWait_cb (IntPtr inst, int condition, long timeout, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				IDatagramBasedImplementor __obj = GLib.Object.GetObject (inst, false) as IDatagramBasedImplementor;
				bool __result;
				__result = __obj.ConditionWait ((GLib.IOCondition) condition, timeout, GLib.Object.GetObject(cancellable) as GLib.Cancellable);
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
			GDatagramBasedInterface native_iface = (GDatagramBasedInterface) Marshal.PtrToStructure (ifaceptr, typeof (GDatagramBasedInterface));
			native_iface.ReceiveMessages = iface.ReceiveMessages;
			native_iface.SendMessages = iface.SendMessages;
			native_iface.CreateSource = iface.CreateSource;
			native_iface.ConditionCheck = iface.ConditionCheck;
			native_iface.ConditionWait = iface.ConditionWait;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public DatagramBasedAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public DatagramBasedAdapter (IDatagramBasedImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public DatagramBasedAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_datagram_based_get_type();
		static d_g_datagram_based_get_type g_datagram_based_get_type = FuncLoader.LoadFunction<d_g_datagram_based_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_datagram_based_get_type"));

		private static GLib.GType _gtype = new GLib.GType (g_datagram_based_get_type ());

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

		public static IDatagramBased GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IDatagramBased GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IDatagramBasedImplementor)
				return new DatagramBasedAdapter (obj as IDatagramBasedImplementor);
			else if (obj as IDatagramBased == null)
				return new DatagramBasedAdapter (obj.Handle);
			else
				return obj as IDatagramBased;
		}

		public IDatagramBasedImplementor Implementor {
			get {
				return implementor as IDatagramBasedImplementor;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_datagram_based_condition_check(IntPtr raw, int condition);
		static d_g_datagram_based_condition_check g_datagram_based_condition_check = FuncLoader.LoadFunction<d_g_datagram_based_condition_check>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_datagram_based_condition_check"));

		public GLib.IOCondition ConditionCheck(GLib.IOCondition condition) {
			int raw_ret = g_datagram_based_condition_check(Handle, (int) condition);
			GLib.IOCondition ret = (GLib.IOCondition) raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_datagram_based_condition_wait(IntPtr raw, int condition, long timeout, IntPtr cancellable, out IntPtr error);
		static d_g_datagram_based_condition_wait g_datagram_based_condition_wait = FuncLoader.LoadFunction<d_g_datagram_based_condition_wait>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_datagram_based_condition_wait"));

		public bool ConditionWait(GLib.IOCondition condition, long timeout, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_datagram_based_condition_wait(Handle, (int) condition, timeout, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_datagram_based_create_source(IntPtr raw, int condition, IntPtr cancellable);
		static d_g_datagram_based_create_source g_datagram_based_create_source = FuncLoader.LoadFunction<d_g_datagram_based_create_source>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_datagram_based_create_source"));

		public GLib.Source CreateSource(GLib.IOCondition condition, GLib.Cancellable cancellable) {
			IntPtr raw_ret = g_datagram_based_create_source(Handle, (int) condition, cancellable == null ? IntPtr.Zero : cancellable.Handle);
			GLib.Source ret = new GLib.Source(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_datagram_based_receive_messages(IntPtr raw, IntPtr messages, uint num_messages, int flags, long timeout, IntPtr cancellable, out IntPtr error);
		static d_g_datagram_based_receive_messages g_datagram_based_receive_messages = FuncLoader.LoadFunction<d_g_datagram_based_receive_messages>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_datagram_based_receive_messages"));

		public int ReceiveMessages(GLib.InputMessage messages, uint num_messages, int flags, long timeout, GLib.Cancellable cancellable) {
			IntPtr native_messages = GLib.Marshaller.StructureToPtrAlloc (messages);
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_datagram_based_receive_messages(Handle, native_messages, num_messages, flags, timeout, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			int ret = raw_ret;
			Marshal.FreeHGlobal (native_messages);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_datagram_based_send_messages(IntPtr raw, IntPtr messages, uint num_messages, int flags, long timeout, IntPtr cancellable, out IntPtr error);
		static d_g_datagram_based_send_messages g_datagram_based_send_messages = FuncLoader.LoadFunction<d_g_datagram_based_send_messages>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_datagram_based_send_messages"));

		public int SendMessages(GLib.OutputMessage messages, uint num_messages, int flags, long timeout, GLib.Cancellable cancellable) {
			IntPtr native_messages = GLib.Marshaller.StructureToPtrAlloc (messages);
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_datagram_based_send_messages(Handle, native_messages, num_messages, flags, timeout, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			int ret = raw_ret;
			Marshal.FreeHGlobal (native_messages);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

#endregion
	}
}
