using Microsoft.VisualStudio.TestTools.UnitTesting;

using SortingAlgorithms.Sort;

namespace SortingAlgorithmsTests.Sort
{
    [TestClass]
    public class MergeSorterTest: GenericSorterTest
    {
        public MergeSorterTest() : base(new MergeSorter<int>())
        {
        }
    }
}
