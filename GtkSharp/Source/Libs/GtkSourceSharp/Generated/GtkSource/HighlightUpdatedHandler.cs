// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;

	public delegate void HighlightUpdatedHandler(object o, HighlightUpdatedArgs args);

	public class HighlightUpdatedArgs : GLib.SignalArgs {
		public Gtk.TextIter P0{
			get {
				return (Gtk.TextIter) Args [0];
			}
		}

		public Gtk.TextIter P1{
			get {
				return (Gtk.TextIter) Args [1];
			}
		}

	}
}
