using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class BubbleSort<T> : BaseAlgorithm<T> where T : IComparable
    {
        public BubbleSort(IEnumerable<T> items) : base(items) { }
        public BubbleSort() { }

        protected override void DoSort()
        {
            var count = Items.Count;

            for(int v = 0; v < count; v++)
            {
                for (int i = 0; i < count - 1 - v; i++)
                {
                    var itemA = Items[i];
                    var itemB = Items[i + 1];

                    if (Compare(itemA, itemB) == 1)
                    {
                        Swop(i, i + 1);
                    }
                }
            }
        }
    }
}
