using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.SortingTypes
{
    public class InsertSort<T> : BaseAlgorithm<T> where T: IComparable
    {
        public InsertSort(IEnumerable<T> items) : base(items) { }
        public InsertSort() { }
        protected override void DoSort()
        {
            for(int i = 1; i < Items.Count; i++)
            {
                var tempItem = Items[i];
                var j = i;
                while(j > 0 && Compare(tempItem, Items[j - 1]) == -1)
                {
                    Swop(j, j - 1);
                    j--;
                }
                Items[j] = tempItem;
            }
        }
    }
}
