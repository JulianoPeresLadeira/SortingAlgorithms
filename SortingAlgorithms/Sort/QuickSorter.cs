using System;
using System.Collections.Generic;
using System.Linq;

using SortingAlgorithms.Business;

namespace SortingAlgorithms.Sort
{
    public class QuickSorter<T> : Sorter<T> where T : IComparable
    {

        protected override List<T> DoSort(List<T> list)
        {

            if (list.Count <= 1)
            {
                return list;
            }

            T pivot = list.First();
            list.RemoveAt(0);

            List<T> less = new List<T>();
            List<T> more = new List<T>();
            List<T> same = new List<T>();

            same.Add(pivot);

            foreach (T element in list)
            {
                if (element.CompareTo(pivot) > 0)
                {
                    more.Add(element);
                }
                else if (element.CompareTo(pivot) == 0)
                {
                    same.Add(element);
                }
                else
                {
                    less.Add(element);
                }
            }

            List<T> sorted = new List<T>();


            sorted.AddRange(this.DoSort(less));
            sorted.AddRange(same);
            sorted.AddRange(this.DoSort(more));

            return sorted;
        }
    }
}
