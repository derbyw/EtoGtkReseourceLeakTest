// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;

#region Autogenerated code
	public partial interface IUndoManager : GLib.IWrapper {

		event System.EventHandler EmitCanRedoChanged;
		event System.EventHandler EmitCanUndoChanged;
		void BeginNotUndoableAction();
		bool CanRedo();
		void CanRedoChanged();
		bool CanUndo();
		void CanUndoChanged();
		void EndNotUndoableAction();
		void Redo();
		void Undo();
	}

	[GLib.GInterface (typeof (UndoManagerAdapter))]
	public partial interface IUndoManagerImplementor : GLib.IWrapper {

		bool CanUndo ();
		bool CanRedo ();
		void Undo ();
		void Redo ();
		void BeginNotUndoableAction ();
		void EndNotUndoableAction ();
	}
#endregion
}