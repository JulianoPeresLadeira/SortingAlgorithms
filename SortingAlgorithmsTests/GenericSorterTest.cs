using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SortingAlgorithms.Business;
using System.Linq;

namespace SortingAlgorithmsTests
{
    public abstract class GenericSorterTest
    {

        private Sorter<int> sorter;

        public GenericSorterTest(Sorter<int> sorter)
        {
            this.sorter = sorter;
        }

        protected bool ListIsSorted(List<int> list)
        {
            return list.Zip(list.Skip(1), (curr, next) => curr <= next).All(x => x);
        }

        [TestMethod]
        public void TestOnRandomList()
        {
            List<int> testInput = new List<int>(new int[] { 9, 1, 5, 6, 3, 4, 8, 2, 7 });
            List<int> sortedArray = this.sorter.Sort(testInput);
            Assert.IsTrue(this.ListIsSorted(sortedArray));
        }

        [TestMethod]
        public void TestOnSortedList()
        {
            List<int> testInput = new List<int>(new int[] { 1, 2, 3 });
            List<int> sortedArray = this.sorter.Sort(testInput);
            Assert.IsTrue(this.ListIsSorted(sortedArray));
        }

        [TestMethod]
        public void TestOnEmptyList()
        {
            List<int> testInput = new List<int>(new int[] { });
            List<int> sortedArray = this.sorter.Sort(testInput);
            Assert.IsTrue(this.ListIsSorted(sortedArray));
        }

        [TestMethod]
        public void TestOnAllNegatives()
        {
            List<int> testInput = new List<int>(new int[] { -1, -2, -3 });
            List<int> sortedArray = this.sorter.Sort(testInput);
            Assert.IsTrue(this.ListIsSorted(sortedArray));
        }

        [TestMethod]
        public void TestOnReversedList()
        {
            List<int> testInput = new List<int>(new int[] { 3, 2, 1 });
            List<int> sortedArray = this.sorter.Sort(testInput);
            Assert.IsTrue(this.ListIsSorted(sortedArray));
        }

        [TestMethod]
        public void TestOnVeryBigList()
        {
            List<int> testInput = new List<int>(new int[] { 7944, 65465, 456, 652, 45, 465, 768, 876, 574, 65, 7465, 4654, 65465, 4879, 857498, 79874, 765765, 7687465, 7461, 12, 12054, 85546, 57465, 74065465, 46507, 657465746, 506574, 60874, 685740, 685706, 8760, 57650, 6754065, 4065, 76807, 986, 89670, 897465, 786, 68, 6807, 867, 60, 768, 78697, 680, 7680, 8697086, 70, 6870, 87, 9680796, 709687980, 9870, 987, 98670986, 67098, 70, 86740, 9867, 98, 740986, 7089, 70, 87, 6897, 65, 79806, 74896, 986, 7089, 67, 9867, 6870, 6850, 657, 60, 587, 65087, 986, 7608, 68507, 687, 0657, 86970, 6870, 687, 6507, 867, 8, 788, 79, 6079, 8607, 8697, 6870, 687, 657, 68574, 687, 68570, 657, 657, 654, 60, 651, 0654, 6504, 645, 40, 5467, 465, 70, 657, 965, 765, 7, 657, 685, 765, 7, 065, 7, 065, 465, 465, 46, 574, 650, 46, 57, 70, 6874, 65, 748, 74987, 98674654, 984, 065, 740986, 40896, 7, 65709, 8640, 9964, 657, 689, 7, 654, 0654, 0, 56, 234, 65460, 8787, 996542064, 4454, 457874, 545444211, 544564, 9878, 674, 3, 34535, 67455514, 42054, 612601, 0564, 46, 4261, 11260, 4, 265, 054, 60, 4, 652, 1, 4, 4054, 105, 4, 54, 014, 1054, 0, 51405, 521, 05645154, 5040, 540, 54, 4454 });
            List<int> sortedArray = this.sorter.Sort(testInput);
            Assert.IsTrue(this.ListIsSorted(sortedArray));
        }

    }
}
