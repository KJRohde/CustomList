﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleList
{
    public class KyleCustomList<T>
    {
        //member variables
        public T[] items;
        public T[] subArray;
        public T[] addedLists;
        public int capacity = 4;
        public T input
        {
            get
            {
                return input;
            }
            set
            {
                input = value;
            }
        }
        public int Capacity
        {
            set
            {
                capacity = value;
            }
        }
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
        public int count;


        //construct
 
        public KyleCustomList()

        {
            count = 0;
            items = new T[capacity];
        }
        //methods
        public static KyleCustomList<T> operator + (KyleCustomList<T> left, KyleCustomList<T> right)
        {
            for (int i = 0; i < right.count; i++)
            {
                left.Add(right[i]);
            }
            return left;
        }

        public void Add(T item)
        {
            if (count < capacity)
            {
                items[count] = item;
                count++;
            }
            else
            {
                subArray = items;
                capacity *= 2;
                items = new T[capacity];
                for(int i = 0; i < (capacity/2); i++)
                {
                    items[i] = subArray[i];
                }
                items[count] = item;
                count++;
            }
        }
        public void Remove(T itemToRemove)
        {
            for (int i = 0; i < count; i++)
            {
                if (itemToRemove.Equals(items[i]))
                {
                    for (int n = (i); n <= count - 1; n++)
                    {
                        if (n < count - 1)
                        {
                            items[n] = items[n + 1];
                        }
                        else if (n == count - 1)
                        {
                            items[n] = default(T);
                        }
                    }
                    count--;
                    break;
                }
            }
        }
        public override string ToString()
        {
            string input = "";
            for (int i = 0; i < count; i++)
            {
                input += items[i].ToString();

            }
            return input;
        }
    }
}
