// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class StateManager {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_state_type_for_name(IntPtr name);
		static d_atk_state_type_for_name atk_state_type_for_name = FuncLoader.LoadFunction<d_atk_state_type_for_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_type_for_name"));

		public static Atk.StateType TypeForName(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			int raw_ret = atk_state_type_for_name(native_name);
			Atk.StateType ret = (Atk.StateType) raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_state_type_get_name(int type);
		static d_atk_state_type_get_name atk_state_type_get_name = FuncLoader.LoadFunction<d_atk_state_type_get_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_type_get_name"));

		public static string TypeGetName(Atk.StateType type) {
			IntPtr raw_ret = atk_state_type_get_name((int) type);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_state_type_register(IntPtr name);
		static d_atk_state_type_register atk_state_type_register = FuncLoader.LoadFunction<d_atk_state_type_register>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_type_register"));

		public static Atk.StateType TypeRegister(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			int raw_ret = atk_state_type_register(native_name);
			Atk.StateType ret = (Atk.StateType) raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

#endregion
	}
}
