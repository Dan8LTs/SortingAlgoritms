using System;
using System.Collections.Generic;

namespace Algorithm.SortingTypes
{
    public class GnomeSort<T> : BaseAlgorithm<T> where T : IComparable
    {
        public GnomeSort(IEnumerable<T> items) : base(items) { }
        public GnomeSort() { }
        protected override void DoSort()
        {
            var i = 1;
            while(i < Items.Count)
            {
                if (i == 0 || Compare(Items[i], Items[i - 1]) != -1)
                {
                    i++;
                }
                else
                {
                    Swop(i, i - 1);
                    i--;
                }
            }
        }
    }
}
