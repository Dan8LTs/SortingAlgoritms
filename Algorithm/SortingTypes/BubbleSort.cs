using System;

namespace Algorithm
{
    public class BubbleSort<T> : BaseAlgorithm<T> where T : IComparable
    {
        protected override void DoSort()
        {
            var count = Items.Count;

            for(int v = 0; v < count; v++)
            {
                for (int i = 0; i < count - 1 - v; i++)
                {
                    var itemA = Items[i];
                    var itemB = Items[i + 1];

                    if (itemA.CompareTo(itemB) == 1)
                    {
                        Swop(i, i + 1);
                        CompareCount++;
                    }
                }
            }
        }
    }
}
