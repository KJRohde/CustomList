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
            //arrange
            KyleCustomList<int> testList = new KyleCustomList<int>();
            KyleCustomList<int> testListZip = new KyleCustomList<int>();
            string expected = "2573649";
            string actual;

            testList.Add(2);
            testList.Add(7);
            testList.Add(6);
            testList.Add(4);
            testList.Add(9);
            testListZip.Add(5);
            testListZip.Add(3);


            testList.Zip(testListZip);

        }
    }
}
