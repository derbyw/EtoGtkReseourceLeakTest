// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void SwipeHandler(object o, SwipeArgs args);

	public class SwipeArgs : GLib.SignalArgs {
		public double VelocityX{
			get {
				return (double) Args [0];
			}
		}

		public double VelocityY{
			get {
				return (double) Args [1];
			}
		}

	}
}
