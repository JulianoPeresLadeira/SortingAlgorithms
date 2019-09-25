using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Business
{
    public abstract class Sorter<T> where T: IComparable
    {
        public List<T> Sort(List<T> list)
        {
            if (!this.IsValidInput(list)) {
                return null;
            }

            if (list.Count() < 2) {
                return list;
            }

            List<T> clonedList = new List<T>(list);

            return this.DoSort(clonedList);
        }
        private bool IsValidInput(List<T> list)
        {
            return list != null;
        }

        protected abstract List<T> DoSort(List<T> list);
    }
}
