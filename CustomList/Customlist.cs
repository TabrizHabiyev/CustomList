using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    class Customlist<T>
    {
        private T[] _arr { get; set; }
        public Customlist(int size = 10)
        {
            _arr = new T[size];

        }
        public T this[int index] 
        {
            get 
            {
                try
                {
                    return _arr[index];
                }
                catch
                {

                    return _arr[0];
                }
            }
            set 
            {
                try
                {
                    if (index == _arr.Length-1)
                    {
                        T[] copy = new T[_arr.Length+10];
                        _arr = copy;
                    }
                    _arr[index] = value;
                  
                }
                catch 
                {
                    Console.WriteLine("Out of range");
                    Console.ReadLine();
                }
            }
        }

        public int LastIndexOf(T item)
        {
            return Array.LastIndexOf(_arr, item);
        }

        public int IndexOf(T item)
        {
            return Array.IndexOf(_arr, item);
        }

        public void Clear()
        {
            Array.Clear(_arr, 0, _arr.Length);
        }

        public void Remove(T item)
        {
            //int _delete = Array.IndexOf(_arr, item);
            //if (_delete !<0)
            //{
            //    _arr[_delete] = null;
            //}
        }

        //Add method
        public void Add(T item)
        {
            for (int i = 0; i < _arr.Length+1; i++)
            {
                if (_arr[i] == null)
                {
                    _arr[i] = item;

                    break;
                }
            }
        }

    }
}
