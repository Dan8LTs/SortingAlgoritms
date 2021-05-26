using System;
using System.Collections.Generic;

namespace Algorithm.SortingTypes
{
    public class QuickSort<T> : BaseAlgorithm<T> where T : IComparable
    {
        public QuickSort(IEnumerable<T> items) : base(items) { }
        public QuickSort() { }

        protected override void DoSort()
        {
            QSorting(0, Items.Count - 1);
        }
        private void QSorting(int left, int right)
        {
            if(left >= right)
            {
                return;
            }
            var pivot = Sorting(left, right);
            QSorting(left, pivot - 1);
            QSorting(pivot + 1, right);
        }
        private int Sorting(int left, int right)
        {
            var pointer = left;
            for(int i = left; i <= right; i++)
            {
                if(Compare(Items[i], Items[right]) == -1)
                {
                    Swop(pointer, i);
                    pointer++;
                }
            }
            Swop(pointer, right);
            return pointer;
        }
    }
}
