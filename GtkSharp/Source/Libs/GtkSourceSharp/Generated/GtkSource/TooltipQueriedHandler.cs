// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;

	public delegate void TooltipQueriedHandler(object o, TooltipQueriedArgs args);

	public class TooltipQueriedArgs : GLib.SignalArgs {
		public Gtk.TextIter Iter{
			get {
				return (Gtk.TextIter) Args [0];
			}
		}

		public Gdk.Rectangle Area{
			get {
				return (Gdk.Rectangle) Args [1];
			}
		}

		public int X{
			get {
				return (int) Args [2];
			}
		}

		public int Y{
			get {
				return (int) Args [3];
			}
		}

		public Gtk.Tooltip Tooltip{
			get {
				return (Gtk.Tooltip) Args [4];
			}
		}

	}
}
