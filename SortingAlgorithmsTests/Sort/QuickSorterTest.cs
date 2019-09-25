using Microsoft.VisualStudio.TestTools.UnitTesting;

using SortingAlgorithms.Sort;

namespace SortingAlgorithmsTests.Sort
{
    [TestClass]
    public class QuickSorterTest : GenericSorterTest
    {
        public QuickSorterTest() : base(new QuickSorter<int>())
        {
        }
    }
}
