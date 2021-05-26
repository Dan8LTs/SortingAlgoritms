using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.SortingTypes
{
    public class MergeSort<T> : BaseAlgorithm<T> where T : IComparable
    {
        public MergeSort(IEnumerable<T> items) : base(items) { }
        public MergeSort() { }
        protected override void DoSort()
        {
            var sortedItems = Sort(Items);
            for(int i = 0; i < sortedItems.Count; i++)
            {
                Set(i, sortedItems[i]);
            }
        }
        private List<T> Sort(List<T> items)
        {
            if (items.Count == 1)
            {
                return items;
            }

            var mid = items.Count / 2;
            var left = items.Take(mid).ToList();
            var right = items.Skip(mid).ToList();

            return Merge(Sort(left), Sort(right));
        }
        private List<T> Merge(List<T> left, List<T> right)
        {
            var length = left.Count + right.Count;
            var leftIndex = 0;
            var rightIndex = 0;

            var result = new List<T>();
            for (int i = 0; i < length; i++)
            {
                if (leftIndex < left.Count && rightIndex < right.Count)
                {
                    if (Compare(left[leftIndex], right[rightIndex]) == 1)
                    {
                        result.Add(right[rightIndex]);
                        rightIndex++;
                    }
                    else
                    {
                        result.Add(left[leftIndex]);
                        leftIndex++;
                    }
                }
                else
                {
                    if (rightIndex < right.Count)
                    {
                        result.Add(right[rightIndex]);
                        rightIndex++;
                    }
                    else
                    {
                        result.Add(left[leftIndex]);
                        leftIndex++;
                    }
                }
            }
            return result;
        }
    }
}
