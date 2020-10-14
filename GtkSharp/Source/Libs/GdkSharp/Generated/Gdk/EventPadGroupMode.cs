// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct EventPadGroupMode : IEquatable<EventPadGroupMode> {

		public Gdk.EventType Type;
		private IntPtr _window;
		public Gdk.Window Window {
			get {
				return GLib.Object.GetObject(_window) as Gdk.Window;
			}
			set {
				_window = value == null ? IntPtr.Zero : value.Handle;
			}
		}
		public sbyte SendEvent;
		public uint Time;
		public uint Group;
		public uint Mode;

		public static Gdk.EventPadGroupMode Zero = new Gdk.EventPadGroupMode ();

		public static Gdk.EventPadGroupMode New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gdk.EventPadGroupMode.Zero;
			return (Gdk.EventPadGroupMode) Marshal.PtrToStructure (raw, typeof (Gdk.EventPadGroupMode));
		}

		public bool Equals (EventPadGroupMode other)
		{
			return true && Type.Equals (other.Type) && Window.Equals (other.Window) && SendEvent.Equals (other.SendEvent) && Time.Equals (other.Time) && Group.Equals (other.Group) && Mode.Equals (other.Mode);
		}

		public override bool Equals (object other)
		{
			return other is EventPadGroupMode && Equals ((EventPadGroupMode) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Type.GetHashCode () ^ Window.GetHashCode () ^ SendEvent.GetHashCode () ^ Time.GetHashCode () ^ Group.GetHashCode () ^ Mode.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
