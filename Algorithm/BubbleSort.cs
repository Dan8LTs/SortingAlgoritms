using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class BubbleSort<T> : BaseAlgorithm<T> where T : IComparable
    {
        public override void Sort()
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
                    }
                }
            }
        }
    }
}
