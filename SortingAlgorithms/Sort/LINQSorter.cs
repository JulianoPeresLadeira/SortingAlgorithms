using SortingAlgorithms.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Sort
{
    public class LINQSorter<T> : Sorter<T> where T : IComparable
    {
        protected override List<T> DoSort(List<T> list)
        {
            List<T> sortedList = (
                from value in list
                orderby value ascending
                select value).ToList();
            return sortedList;
        }
    }
}
