using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTestProject
{
    public class CustomList<T>
    {
        private T[] items;
        private int capacity;
        private int count;

        public int Count
        {
            get
            {
                return count;
            }
        }


        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }

        public void Add(T itemToAdd)
        {
            items[0] = itemToAdd;
        }

        public bool Remove(T item)
        {

            return true;
        }
    }
}
