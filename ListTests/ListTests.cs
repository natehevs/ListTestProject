using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListTestProject;

namespace ListTests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void CustomList_Add_AddingOneValueCount()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 1;
            int actual;
            int number1 = 8;

            //act
            list1.Add(number1);
            actual = list1.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_AddingFiveValueArrayResize()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 5;
            int actual;
            int number1 = 8;
            int number2 = 8;
            int number3 = 8;
            int number4 = 8;
            int number5 = 8;
            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list1.Add(number5);
            actual = list1.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_CountIncrements()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 1;
            int actual;

            //act
            list1.Add(100);
            actual = list1.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_IndexZero()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 43;
            int actual;

            //act
            testList.Add(43);
            actual = testList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_Index4()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 43;
            int actual;

            //act
            testList.Add(32);
            testList.Add(33);
            testList.Add(34);
            testList.Add(49);
            testList.Add(43);
            actual = testList[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_Adding9ValueArrayResize()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 9;
            int actual;
            int number1 = 8;
            int number2 = 8;
            int number3 = 8;
            int number4 = 8;
            int number5 = 8;
            int number6 = 8;
            int number7 = 8;
            int number8 = 8;
            int number9 = 8;
            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list1.Add(number5);
            list1.Add(number6);
            list1.Add(number7);
            list1.Add(number8);
            list1.Add(number9);
            actual = list1.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
