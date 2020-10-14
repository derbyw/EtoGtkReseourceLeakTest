// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class StateSet : GLib.Object {

		public StateSet (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_state_set_new();
		static d_atk_state_set_new atk_state_set_new = FuncLoader.LoadFunction<d_atk_state_set_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_set_new"));

		public StateSet () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (StateSet)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			owned = true;
			Raw = atk_state_set_new();
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
		delegate bool d_atk_state_set_add_state(IntPtr raw, int type);
		static d_atk_state_set_add_state atk_state_set_add_state = FuncLoader.LoadFunction<d_atk_state_set_add_state>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_set_add_state"));

		public bool AddState(Atk.StateType type) {
			bool raw_ret = atk_state_set_add_state(Handle, (int) type);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_state_set_add_states(IntPtr raw, out int types, int n_types);
		static d_atk_state_set_add_states atk_state_set_add_states = FuncLoader.LoadFunction<d_atk_state_set_add_states>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_set_add_states"));

		public Atk.StateType AddStates(int n_types) {
			Atk.StateType types;
			int native_types;
			atk_state_set_add_states(Handle, out native_types, n_types);
			types = (Atk.StateType) native_types;
			return types;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_state_set_and_sets(IntPtr raw, IntPtr compare_set);
		static d_atk_state_set_and_sets atk_state_set_and_sets = FuncLoader.LoadFunction<d_atk_state_set_and_sets>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_set_and_sets"));

		public Atk.StateSet AndSets(Atk.StateSet compare_set) {
			IntPtr raw_ret = atk_state_set_and_sets(Handle, compare_set == null ? IntPtr.Zero : compare_set.Handle);
			Atk.StateSet ret = GLib.Object.GetObject(raw_ret) as Atk.StateSet;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_state_set_clear_states(IntPtr raw);
		static d_atk_state_set_clear_states atk_state_set_clear_states = FuncLoader.LoadFunction<d_atk_state_set_clear_states>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_set_clear_states"));

		public void ClearStates() {
			atk_state_set_clear_states(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_state_set_contains_state(IntPtr raw, int type);
		static d_atk_state_set_contains_state atk_state_set_contains_state = FuncLoader.LoadFunction<d_atk_state_set_contains_state>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_set_contains_state"));

		public bool ContainsState(Atk.StateType type) {
			bool raw_ret = atk_state_set_contains_state(Handle, (int) type);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_state_set_contains_states(IntPtr raw, out int types, int n_types);
		static d_atk_state_set_contains_states atk_state_set_contains_states = FuncLoader.LoadFunction<d_atk_state_set_contains_states>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_set_contains_states"));

		public bool ContainsStates(out Atk.StateType types, int n_types) {
			int native_types;
			bool raw_ret = atk_state_set_contains_states(Handle, out native_types, n_types);
			bool ret = raw_ret;
			types = (Atk.StateType) native_types;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_state_set_get_type();
		static d_atk_state_set_get_type atk_state_set_get_type = FuncLoader.LoadFunction<d_atk_state_set_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_set_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = atk_state_set_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_state_set_is_empty(IntPtr raw);
		static d_atk_state_set_is_empty atk_state_set_is_empty = FuncLoader.LoadFunction<d_atk_state_set_is_empty>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_set_is_empty"));

		public bool IsEmpty { 
			get {
				bool raw_ret = atk_state_set_is_empty(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_state_set_or_sets(IntPtr raw, IntPtr compare_set);
		static d_atk_state_set_or_sets atk_state_set_or_sets = FuncLoader.LoadFunction<d_atk_state_set_or_sets>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_set_or_sets"));

		public Atk.StateSet OrSets(Atk.StateSet compare_set) {
			IntPtr raw_ret = atk_state_set_or_sets(Handle, compare_set == null ? IntPtr.Zero : compare_set.Handle);
			Atk.StateSet ret = GLib.Object.GetObject(raw_ret) as Atk.StateSet;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_state_set_remove_state(IntPtr raw, int type);
		static d_atk_state_set_remove_state atk_state_set_remove_state = FuncLoader.LoadFunction<d_atk_state_set_remove_state>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_set_remove_state"));

		public bool RemoveState(Atk.StateType type) {
			bool raw_ret = atk_state_set_remove_state(Handle, (int) type);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_state_set_xor_sets(IntPtr raw, IntPtr compare_set);
		static d_atk_state_set_xor_sets atk_state_set_xor_sets = FuncLoader.LoadFunction<d_atk_state_set_xor_sets>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_state_set_xor_sets"));

		public Atk.StateSet XorSets(Atk.StateSet compare_set) {
			IntPtr raw_ret = atk_state_set_xor_sets(Handle, compare_set == null ? IntPtr.Zero : compare_set.Handle);
			Atk.StateSet ret = GLib.Object.GetObject(raw_ret) as Atk.StateSet;
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
