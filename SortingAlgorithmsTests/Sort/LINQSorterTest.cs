using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms.Sort;

namespace SortingAlgorithmsTests.Sort
{
    [TestClass]
    public class LINQSorterTest : GenericSorterTest
    {
        public LINQSorterTest() : base(new LINQSorter<int>())
        {
        }
    }
}
