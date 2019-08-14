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
        //Remove from list methods
        [TestMethod]
        public void Remove_RemoveFromListofOne_ReturnEmptyList()
        {
            //arrange
            KyleCustomList<int> testList = new KyleCustomList<int>();
            int expected = 0;
            int actual;


            //act
            testList.Add(1);
            testList.Remove(1);
            actual = testList.count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ReduceCount_ReduceCountByOne()
        {
            //arrange
            KyleCustomList<int> testList = new KyleCustomList<int>();
            int expected = 2;
            int actual;


            //act
            testList.Add(4);
            testList.Add(1);
            testList.Add(2);
            testList.Remove(1);
            actual = testList.count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        //public void Remove_RemoveMultipleIndexes_ReduceCountByNumberOfInstances()
        //{
        //    //arrange
        //    KyleCustomList<int> testList = new KyleCustomList<int>();
        //    int expected = 7;
        //    int actual;


        //    //act
        //    testList.Remove(1);
        //    actual = testList.count;

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        [TestMethod]
        public void Remove_RemoveNothing_ReturnSameList()
        {
            //arrange
            KyleCustomList<int> testList = new KyleCustomList<int>();
            KyleCustomList<int> expected = testList;
            KyleCustomList<int> actual;


            //act
            testList.Add(3);
            testList.Add(6);
            testList.Add(4);
            testList.Add(8);
            testList.Remove(1);
            actual = testList;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveFromMiddleOfList_ScootIndexOver()
        {
            //arrange
            KyleCustomList<int> testList = new KyleCustomList<int>();
            int expected = 0;
            int actual;


            //act
            testList.Add(2);
            testList.Add(4);
            testList.Add(7);
            testList.Add(6);
            testList.Remove(6);
            actual = testList[3];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveOnlyFirstInstance_LaterInstancesStillThere()
        {
            //arrange
            KyleCustomList<int> testList = new KyleCustomList<int>();
            int expected = 4;
            int actual;


            //act
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testList.Add(6);
            testList.Remove(4);
            actual = testList[1];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Adding two arrays test methods
        [TestMethod]
        public void CombineTwoLists_CombineTwoLists_RightListAfterLeftList()
        {
            //arrange
            KyleCustomList<int> testListLeft = new KyleCustomList<int>();
            KyleCustomList<int> testListRight = new KyleCustomList<int>();
            KyleCustomList<int> addedList = new KyleCustomList<int>();
            KyleCustomList<int> expected = new KyleCustomList<int>() { 2, 4, 6, 3, 5, 6 };
            KyleCustomList<int> actual;


            //act
            testListLeft.Add(2);
            testListLeft.Add(4);
            testListLeft.Add(6);
            testListRight.Add(3);
            testListRight.Add(5);
            testListRight.Add(6);


            addedList = testListLeft + testListRight;
            actual = addedList;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CombineTwoLists_CombineEmptyListRight_LeftListUnchanged()
        {
            //arrange
            KyleCustomList<int> testListLeft = new KyleCustomList<int>();
            KyleCustomList<int> testListRight = new KyleCustomList<int>();
            KyleCustomList<int> addedList = new KyleCustomList<int>();
            KyleCustomList<int> expected = new KyleCustomList<int>() { 2, 4, 6};
            KyleCustomList<int> actual;


            //act
            testListLeft.Add(2);
            testListLeft.Add(4);
            testListLeft.Add(6);


            addedList = testListLeft + testListRight;
            actual = addedList;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CombineTwoLists_CombineEmptyListLeft_RightListUnchanged()
        {
            //arrange
            KyleCustomList<int> testListLeft = new KyleCustomList<int>();
            KyleCustomList<int> testListRight = new KyleCustomList<int>();
            KyleCustomList<int> addedList = new KyleCustomList<int>();
            KyleCustomList<int> expected = new KyleCustomList<int>() {3, 5, 6 };
            KyleCustomList<int> actual;


            //act
            testListRight.Add(3);
            testListRight.Add(5);
            testListRight.Add(6);


            addedList = testListLeft + testListRight;
            actual = addedList;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CombineTwoLists_CombineDifferentDataType_SomeException()
        {
            //arrange
            KyleCustomList<int> testListLeft = new KyleCustomList<int>();
            KyleCustomList<int> testListRight = new KyleCustomList<int>();
            KyleCustomList<int> addedList = new KyleCustomList<int>();
            Exception expected = TypeAccessException;
            Exception actual;


            //act
            testListLeft.Add(2);
            testListLeft.Add(4);
            testListLeft.Add(6);
            testListRight.Add(3);
            testListRight.Add(5);
            testListRight.Add(6);


            addedList = testListLeft + testListRight;
            actual = Exception;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
