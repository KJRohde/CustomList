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
        public int capacity = 4;
        public int Capacity
        {
            set
            {
                capacity = value;
            }
        }
        public int index;
        public T this[int Index]
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
            if (count <= capacity)
            {
                items[count] = item;
                count++;
            }
            else
            {
                capacity *= 2;
                items[count] = item;
                count++;
            }
        }
    }
}
