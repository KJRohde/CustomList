using System;
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
        public int capacity = 4;
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
            foreach(T item in items)
            {
                if (itemToRemove.Equals(items[count]))
                {
                    for (int i = count; i < capacity; i++)
                    {
                        items[count] = items[count + 1];
                        count--;
                    }
                }
            }
        }
    }
}
