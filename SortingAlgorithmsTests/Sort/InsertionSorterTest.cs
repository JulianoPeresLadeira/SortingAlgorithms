using Microsoft.VisualStudio.TestTools.UnitTesting;

using SortingAlgorithms.Sort;

namespace SortingAlgorithmsTests.Sort
{
    [TestClass]
    public class InsertionSorterTest : GenericSorterTest
    {
        public InsertionSorterTest() : base(new InsertionSorter<int>())
        {
        }
    }
}
