using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using quickSort;

namespace quickSortTests
{
    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void QuickSort_Test()
        {
            var actual = new int[] { 6, 2, 4, 10, 8, 1, 3, 5, 7, 9, 0 };
            QuickSort.Sort(actual);
            var expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}