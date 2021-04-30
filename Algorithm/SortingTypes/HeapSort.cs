using Algorithm.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.SortingTypes
{
    public class HeapSort<T> : BaseAlgorithm<T> where T : IComparable
    {
        protected override void DoSort()
        {
            var heap = new Heap<T>(Items);
            var sorted = heap.Order();
            Items = sorted;
        }
    }
}
