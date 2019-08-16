using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KyleList
{
    public class KyleCustomList<T> : IEnumerable<T>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        //member variables
        public T[] items;
        public T[] subArray;
        public int capacity = 4;
        public KyleCustomList<T> excessList;
        public KyleCustomList<T> zippedList;
        public KyleCustomList<T> fullZip;
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
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
        public static KyleCustomList<T> operator + (KyleCustomList<T> left, KyleCustomList<T> right)
        {
            for (int i = 0; i < right.count; i++)
            {
                left.Add(right[i]);
            }
            return left;
        }
        public static KyleCustomList<T> operator - (KyleCustomList<T> left, KyleCustomList<T> right)
        {
            for (int i = 0; i < left.count; i++)
            {
                for (int n = 0; n < right.count; n++)
                {
                    if (left[i].Equals(right[n]))
                    {
                        left.Remove(left[i]);
                    }
                }
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
            for (int i = 0; i < count - 1; i++)
            {
                input += "" + items[i].ToString() + ",";
            }
            if (count > 0)
            {
                input += items[count - 1];
            }
            return input;
        }
        public KyleCustomList<T> Zip(KyleCustomList<T> toZip)
        {
            excessList = new KyleCustomList<T>();
            zippedList = new KyleCustomList<T>();
            fullZip = new KyleCustomList<T>();
            if (count >= toZip.count)
            {
                for (int j = toZip.count; j < count; j++)
                {
                    excessList.Add(this[j]);
                }
                for (int i = 0; i < toZip.count; i++)
                {
                    zippedList.Add(this[i]);
                    zippedList.Add(toZip[i]);
                }
            }
            else if (count < toZip.count)
            {
                for (int j = count; j < toZip.count; j++)
                {
                    excessList.Add(toZip[j]);
                }
                for (int i = 0; i < count; i++)
                {
                    zippedList.Add(this[i]);
                    zippedList.Add(toZip[i]);
                }
            }
            fullZip += (zippedList + excessList);
            return fullZip;
        }
    }
}
