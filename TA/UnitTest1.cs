using NUnit.Framework;
using ArrayT;
namespace TA
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        
    }

    
    public class movedZeroesAtEnd
    {
        [TestCase]
        public void Array_With_Numbers()
        {
            
            //Assert
            int[] arr = new int[] { 7, 8, 0, 3, 0, 1, 0, 4 };
            int n = arr.Length;
            //act
            int[] arr1= pushToEnd(arr, n);
            //assert
            var expectedArray = new int[] { 7, 8, 3, 1, 4, 0, 0 };
            Assert.AreEqual(expectedArray, arr1);

        }

    }
}