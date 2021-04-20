using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.SortingTypes
{
    public class InsertSort<T> : BaseAlgorithm<T> where T: IComparable
    {
        protected override void DoSort()
        {
            for(int i = 1; i < Items.Count; i++)
            {
                var tempItem = Items[i];
                var j = i;
                while(j > 0 && tempItem.CompareTo(Items[j - 1]) == -1)
                {
                    Items[j] = Items[j - 1];
                    j--;
                    SwopCount++;
                    CompareCount++;
                }
                Items[j] = tempItem;
            }
        }
    }
}
