using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ItemNumerator<T> : IEnumerator<T>
    {
        private int _position;
        private T[] _item;
        ItemNumerator(T[] item)
        {
            _item = item;
        }
        public T Current
        {
            get
            {
                return _item[_position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            if (_position < _item.Length - 1)
            {
                _position += 1;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            _position = -1;
        }
        public void Dispose() { }
    }
}
