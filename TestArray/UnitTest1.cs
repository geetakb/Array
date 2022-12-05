using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ArrayT;

namespace TestArray
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
    [TestClass]
    public class movedZeroesAtEnd
    {
        [TestMethod]
        public void Array_With_Numbers()
        {
            //Assert
            int[] arr = new int[] { 7, 8, 0, 3, 0, 1, 0, 4 };
            int n = arr.Length;
            //act
           int[] arr1= pushToEnd(arr, n);
            //assert
            var expectedArray = " 7, 8, 3, 1, 4, 0, 0 ";
            Assert.AreEqual(expectedArray, arr);
        }

    }

}
