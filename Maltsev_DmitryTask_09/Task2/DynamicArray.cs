using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class DynamicArray<T>:IEnumerable where T : new()
    {
        private T[] _array=new T[10];
        public DynamicArray()
        {
            _array = new T[8];
        }

        public DynamicArray(int index)
        {
            _array = new T[index];
        }

        public DynamicArray(T[] array)
        {
            _array = array;
        }
        public DynamicArray(IEnumerable<T> ie)
        {
            _array = new T[ie.Count()];
            int k = 0;
            foreach(var p in ie)
            {
                _array[k] = p;
            }
        }
  
        public IEnumerator GetEnumerator()
        {
            return _array.GetEnumerator();
        }

     /*   public IEnumerator GetEnumerator()
        {
            return new ItemNumerator(_item);
        }
    */
        public T this[int index]
        {
            get
            {
                return _array[index];
            }
        }

        public int Length { get; private set; } 

        public int Capacity 
        {
            get
            {
                return _array.Count();
            }
        }

        public T[] Add(T element)
        {
            if (Length < Capacity)
            {
                _array[Length] = element;
                Length += 1;
            }
            else
            {
                T[] newArray = new T[2 * Capacity];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }
                newArray[Length] = element;
                _array = newArray;
                Length += 1;
            }
            return _array;
        }

        public T[] AddRange(T[] array)
        {
            if (Capacity < array.Length + Length)
            {
                T[] newArray = new T[Length + array.Length];
                for (int i = 0; i < Length; i++)
                {
                    newArray[i] = _array[i];
                }
                int k = 0;
                for (int i = Length; i < Length + array.Length; i++)
                {
                    newArray[i] = array[k];
                    k += 1;
                }
                _array = newArray;
                Length += array.Length;
            }
            else
            {
                for (int i = Length; i < Capacity; i++)
                {
                    _array[i] = array[i];
                }
            }
            return _array;
        }

        public bool Remove(int index)
        {
            T[] newArray = new T[Capacity];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < Length - 1; i++)
            {
                newArray[i] = _array[i + 1];
            }
            newArray[Length - 1] = default(T);
            _array = newArray;
            Length -= 1;
            if (EqualityComparer<T>.Default.Equals(_array[Length], default(T)))
            {
                return true;
            }
            else return false;
        }

        public T[] Insert(int index, T element)
        {
            if (Length < Capacity)
            {
                Length += 1;
                InsertingProcess(index, element, Capacity);
            }
            else
            {
                Length += 1;
                InsertingProcess(index, element, Capacity + 1);
            }
            return _array;
        }

        private void InsertingProcess(int index, T element, int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            newArray[index] = element;
            for (int i = index; i < newArray.Length; i++)
            {
                newArray[i] = _array[i - 1];
            }
            _array = newArray;
        }
    }
}
