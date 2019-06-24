using System;
using System.Collections;

namespace MyConsoleApp
{
    public class Stack
    {
        private ArrayList _list;

        public Stack(ArrayList list)
        {
            _list = list;
        }

        public void Push(object obj)
        {
            if(obj == null)
                throw new InvalidOperationException("Null is an invalid object parameter");

            _list.Add(obj);
        }

        public Object Pop()
        {
            if(_list.Count == 0)
                throw new InvalidOperationException("Cannot remove from an empty list");

            var index = _list.Count - 1;
            var element = _list[index];
            _list.RemoveAt(index);
            return element;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}