// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;

	public delegate void MovePageHandler(object o, MovePageArgs args);

	public class MovePageArgs : GLib.SignalArgs {
		public Gtk.ScrollStep Step{
			get {
				return (Gtk.ScrollStep) Args [0];
			}
		}

		public int Num{
			get {
				return (int) Args [1];
			}
		}

	}
}
