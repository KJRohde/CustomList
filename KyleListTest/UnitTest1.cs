using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KyleList;

namespace KyleListTest
{
    [TestClass]
    public class KyleListTest
    {

        //Add to list methods
        [TestMethod]
        public void Add_AddToEmptyList_ItemToIndexZero()
        {
            //arrange
            KyleCustomList<int> testList = new KyleCustomList<int>();
            int expected = 1;
            int actual;


            //act
            testList.Add(1);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToListWithItem_ItemToLastIndex()
        {
            //arrange
            KyleCustomList<int> testList = new KyleCustomList<int>();
            int expected = 5;
            int actual;


            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(5);
            actual = testList[2];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //add a test for when array size must change

        [TestMethod]
        public void Add_AddToEmptyList_CountGoesToTwo()
        {
            //arrange
            KyleCustomList<int> testList = new KyleCustomList<int>();
            int expected = 2;
            int actual;


            //act
            testList.Add(5);
            testList.Add(1);
            actual = testList.count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToFullArray_ArrayCapacityDoubles()
        {
            //arrange
            KyleCustomList<int> testList = new KyleCustomList<int>();
            int expected = 16;
            int actual;


            //act
            testList.Add(5);
            testList.Add(2);
            testList.Add(3);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Add(9);
            testList.Add(9);
            testList.Add(9);
            actual = testList.capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToFullArray_PreviousArrayStays()
        {
                    //arrange
                    //Adding doubling capacity each time capacity is exceeded
            KyleCustomList<int> testList = new KyleCustomList<int>();
            int expected = 2;
            int actual;


            //act
            testList.Add(5);
            testList.Add(2);
            testList.Add(3);
            testList.Add(7);
            testList.Add(8);
            testList.Add(9);
            actual = testList[1];

             //assert
             Assert.AreEqual(expected, actual);
        }
        //        //Remove from list methods
        //        public void Remove_RemoveFromListofOne_ReturnEmptyList()
        //        {
        //            //arrange
        //            KyleCustomList<int> testList = new KyleCustomList<int>();
        //            int expected = 0;
        //            int actual;


        //            //act
        //            testList.Remove(1);
        //            actual = testList.count;

        //            //assert
        //            Assert.AreEqual(expected, actual);
        //        }
        //        public void Remove_ReduceCount_ReduceCountByOne()
        //        {
        //            //arrange
        //            KyleCustomList<int> testList = new KyleCustomList<int>();
        //            int expected = 3;
        //            int actual;


        //            //act
        //            testList.Remove(1);
        //            actual = testList.count;

        //            //assert
        //            Assert.AreEqual(expected, actual);
        //        }
        //        public void Remove_RemoveMultipleIndexes_ReduceCountByNumberOfInstances()
        //        {
        //            //arrange
        //            KyleCustomList<int> testList = new KyleCustomList<int>();
        //            int expected = 7;
        //            int actual;


        //            //act
        //            testList.Remove(1);
        //            actual = testList.Count;

        //            //assert
        //            Assert.AreEqual(expected, actual);
        //        }
        //        public void Remove_RemoveNothing_ReturnSameList()
        //        {
        //            //arrange
        //            KyleCustomList<int> testList = new KyleCustomList<int>();
        //            expected = testList;
        //            actual;


        //            //act
        //            testList.Remove(1);
        //            actual = testList;

        //            //assert
        //            Assert.AreEqual(expected, actual);
        //        }
        //        public void Remove_RemoveFromMiddleOfList_ScootIndexOver()
        //        {
        //            //arrange
        //            KyleCustomList<int> testList = new KyleCustomList<int>();
        //            int expected = 3;
        //            int actual;


        //            //act
        //            testList.Remove(6);
        //            actual = testList[2];

        //            //assert
        //            Assert.AreEqual(expected, actual);
        //        }
    }
}
