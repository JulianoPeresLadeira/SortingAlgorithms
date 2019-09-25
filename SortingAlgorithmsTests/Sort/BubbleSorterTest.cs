using Microsoft.VisualStudio.TestTools.UnitTesting;

using SortingAlgorithms.Sort;

namespace SortingAlgorithmsTests.Sort
{
    [TestClass]
    public class BubbleSorterTest : GenericSorterTest
    {
        public BubbleSorterTest() : base(new BubbleSorter<int>())
        {
        }
    }
}
