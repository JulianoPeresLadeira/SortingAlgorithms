using System;

using SortingAlgorithms.Business;
using System.Collections.Generic;

namespace SortingAlgorithms.Sort
{
    public class MergeSorter<T>: Sorter <T> where T : IComparable
    {
        enum MergeStep
        {
            LEFT,
            RIGHT
        }

        
        protected override List<T> DoSort(List<T> list)
        {

            if (list.Count <= 1) {
                return list;
            }

            List<T> left = new List<T>();
            List<T> right = new List<T>();

            int mergeIndex = list.Count / 2;

            for (int i = 0; i < list.Count; i++)
            {
                if (mergeIndex > 0)
                {
                    left.Add(list[i]);
                    mergeIndex--;
                }
                else
                {
                    right.Add(list[i]);
                }
            }

            List<T> sortedLeft = this.DoSort(left);
            List<T> sortedRight = this.DoSort(right);

            return this.Merge(sortedLeft, sortedRight);
        }

        private List<T> Merge(List<T> left, List<T> right)
        {

            int leftIndex = 0;
            int rightIndex = 0;

            List<T> sortedArr = new List<T>();

            while (leftIndex < left.Count || rightIndex < right.Count)
            {

                MergeStep? step = null;

                if (leftIndex == left.Count)
                {
                    step = MergeStep.RIGHT;
                }
                else if (rightIndex == right.Count)
                {
                    step = MergeStep.LEFT;
                }
                else
                {
                    T leftElement = left[leftIndex];
                    T rightElement = right[rightIndex];

                    if (leftElement.CompareTo(rightElement) < 0)
                    {
                        step = MergeStep.LEFT;
                    }
                    else
                    {
                        step = MergeStep.RIGHT;
                    }
                }

                if (step == MergeStep.LEFT)
                {
                    sortedArr.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    sortedArr.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            return sortedArr;
        }
    }
}
