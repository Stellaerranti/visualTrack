using System;
using System.Collections.Generic;
using VisualTrack;

namespace VisualTrack
{
    public class DeleteUndoAction<T> : IUndoAction
    {
        private readonly List<T> _list;
        private readonly T _item;
        private readonly int _index;
        private readonly Action _refresh;

        public DeleteUndoAction(List<T> list, T item, int index, Action refresh)
        {
            _list = list;
            _item = item;
            _index = index;
            _refresh = refresh;
        }

        public void Undo()
        {
            if (_index >= 0 && _index <= _list.Count)
                _list.Insert(_index, _item);
            else
                _list.Add(_item);

            _refresh?.Invoke();
        }
    }
}