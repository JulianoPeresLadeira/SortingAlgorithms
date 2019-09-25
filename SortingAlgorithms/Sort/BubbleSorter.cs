using System;
using System.Collections.Generic;

using SortingAlgorithms.Business;

namespace SortingAlgorithms.Sort
{
    public class BubbleSorter<T> : Sorter <T> where T: IComparable
    {

        protected override List<T> DoSort(List<T> list)
        {
            bool hasSwapped = true;

            do {
                hasSwapped = false;
                int index = 1;
                while (index < list.Count) {
                    T previous = list[(index - 1)];
                    T current = list[(index)];

                    if (current.CompareTo(previous) < 0) {
                        list[(index - 1)] = current;
                        list[(index)] = previous;
                        hasSwapped = true;
                    }
                    index++;
                }
            } while (hasSwapped);

            return list;
        }
    }
}
