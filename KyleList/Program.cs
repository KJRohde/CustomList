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
                KyleCustomList<int> testListLeft = new KyleCustomList<int>();
                KyleCustomList<int> testListRight = new KyleCustomList<int>();
                KyleCustomList<int> addedList = new KyleCustomList<int>();
                string expected = "246356";
                string actual;


                //act
                testListLeft.Add(2);
                testListLeft.Add(4);
                testListLeft.Add(6);
                testListRight.Add(3);
                testListRight.Add(5);
                testListRight.Add(6);


                addedList = testListLeft + testListRight;
                actual = addedList.ToString();

        }
    }
}
