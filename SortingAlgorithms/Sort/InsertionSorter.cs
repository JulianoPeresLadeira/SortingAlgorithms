using SortingAlgorithms.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Sort
{
    public class InsertionSorter<T> : Sorter <T> where T: IComparable
    {
        protected override List<T> DoSort(List<T> list)
        {

            List<T> sortedList = new List<T>();

            while (list.Count > 0)
            {
                T element = list.First();
                list.RemoveAt(0);
                this.OrderedInsert(sortedList, element);
            }

            return sortedList;
        }

        private void OrderedInsert(List<T> list, T element)
        {
            int index = 0;
            bool inserted = false;
            while (!inserted)
            {
                if (index < list.Count)
                {

                    if (element.CompareTo(list[index]) < 1)
                    {
                        list.Insert(index, element);
                        inserted = true;
                    }
                    else
                    {
                        index++;
                    }
                }
                else
                {
                    list.Add(element);
                    inserted = true;
                }
            }
        }
    }
}
