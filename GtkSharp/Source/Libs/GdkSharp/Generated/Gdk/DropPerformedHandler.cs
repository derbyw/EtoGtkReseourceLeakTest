// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;

	public delegate void DropPerformedHandler(object o, DropPerformedArgs args);

	public class DropPerformedArgs : GLib.SignalArgs {
		public uint Time{
			get {
				return (uint) Args [0];
			}
		}

	}
}
