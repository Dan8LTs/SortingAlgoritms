
using Algorithm.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.SortingTypes
{
    public class TreeSort<T> : BaseAlgorithm<T> where T: IComparable
    {
        protected override void DoSort()
        {
            var tree = new Tree<T>(Items);
            var sorted = tree.Inorder();
            Items = sorted;
        }
    }
}
