// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class TrashMonitor : GLib.Object {

		public TrashMonitor (IntPtr raw) : base(raw) {}

		protected TrashMonitor() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Signal("trash-state-changed")]
		public event System.EventHandler TrashStateChanged {
			add {
				this.AddSignalHandler ("trash-state-changed", value);
			}
			remove {
				this.RemoveSignalHandler ("trash-state-changed", value);
			}
		}

#endregion
	}
}