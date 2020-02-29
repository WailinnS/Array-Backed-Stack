using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Array_Backed_Stack
{
    class Stack<T> : IEnumerable<T> where T : IComparable
    {
        public int Count { get; set; }
        T[] data;

        public Stack(int capacity = 10)
        {
            data = new T[capacity];
            Count = 0;
        }

        public void Push(T value)
        {
            if(Count >= data.Length - 1)
            {
                Resize(data.Length * 2);
            }
            data[Count] = value;
            Count++;
        }

        public T Pop()
        {
            T item = data[Count-1];
            if(Count <= data.Length/ 4)
            {
                Resize(data.Length / 2);
            }
            data[Count-1] = default;
            Count--;
            return item;
        }

        public T Peek()
        {
            return data[Count-1];
        }
        private void Resize(int size)
        {
            T[] temp = new T[size];
            if(size > data.Length -1)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }
            }
            else if(size < data.Length)
            {
                for (int i = 0; i < size; i++)
                {
                    temp[i] = data[i];
                }
            }

            data = temp;
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < data.Length -1; i++)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
