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
        public int arrayCapacity;

        //construct
 
        public KyleCustomList()
        {
            arrayCapacity = 4;
            items = new T[arrayCapacity];
        }
        //methods

        public void Add(T itemToAdd)
        {

        }
    }
}
