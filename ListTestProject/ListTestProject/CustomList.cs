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

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public T this [int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
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
            T[] newArray;
            if (capacity == count)
            {
                capacity = capacity * 2;
                newArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = items[i];
                }
                items = newArray;
            }
            items[count] = itemToAdd;
            count++;
        }

        public bool Remove(T itemToRemove)
        {
            return true;
        }
    }
}
