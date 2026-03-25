using System.Collections.Generic;
using VisualTrack;

namespace VisualTrack
{
    public class UndoManager
    {
        private readonly Stack<IUndoAction> _undoStack = new Stack<IUndoAction>();

        public bool CanUndo => _undoStack.Count > 0;

        public void AddAction(IUndoAction action)
        {
            if (action != null)
                _undoStack.Push(action);
        }

        public void Undo()
        {
            if (_undoStack.Count == 0)
                return;

            _undoStack.Pop().Undo();
        }

        public void Clear()
        {
            _undoStack.Clear();
        }
    }
}