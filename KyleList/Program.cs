using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleList
{
    class Program
    {
        static void Main(string[] args)
        {
            KyleCustomList<int> testList = new KyleCustomList<int>();
            int expected = 6;
            int actual;


            //act
            testList.Add(2);
            testList.Add(4);
            testList.Add(7);
            testList.Add(6);
            testList.Remove(7);
            actual = testList[3];

        }
    }
}
