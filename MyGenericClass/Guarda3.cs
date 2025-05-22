using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T val1;
        private T val2;
        private T val3;

        public Guarda3()
        {
            val1 = default;
            val2 = default;
            val3 = default;
        }

        public T GetItem(int i)
        {
            return i switch
            {
                0 => val1,
                1 => val2,
                2 => val3,
                _ => throw new IndexOutOfRangeException()
            };
        }

        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0: val1 = item; break;
                case 1: val2 = item; break;
                case 2: val3 = item; break;
                default: throw new IndexOutOfRangeException();
            }
        }
    }
}