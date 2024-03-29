﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTestProject
{
    public class CustomList<T>
    {
        public T[] items;
        public int capacity;
        public int count;

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
               // if ()
                //{
                    return items[i];
                //}
                ////else
                //{

                //}
                
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
         
        public void Remove(T itemToRemove)
        {
            T[] newArray = new T[count];
            for (int i = 0, j = 0; i < count; i++, j++)
            {
                if (itemToRemove.Equals(items[i]))
                {
                    j--;
                }
                else
                {
                    newArray[j] = items[i];
                }
            }
            items = newArray;
            count--;
        }

        public override string ToString()
        {
            string listOfStrings = "";
            for (int i = 0; i < Count; i++)
            {
                listOfStrings += items[i].ToString();
            }
            return listOfStrings;
        }

        public static CustomList<T> operator +(CustomList<T> One, CustomList<T> Two)
        {
            CustomList<T> allCustomLists = new CustomList<T>();
            for (int i = 0; i < One.Count; i++)
            {
                allCustomLists.Add(One[i]);
            }
            for (int i = 0; i < Two.Count; i++)
            {
                allCustomLists.Add(Two[i]);
            }
            return allCustomLists;
        }
    }
}
