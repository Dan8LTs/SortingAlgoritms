using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithm
{
    public class BaseAlgorithm<T> where T : IComparable
    {
        public int SwopCount { get; protected set; } = 0;
        public int CompareCount { get; protected set; } = 0;
        public List<T> Items { get; set; } = new List<T>();
        protected void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
                SwopCount++;
            }
        }
        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            SwopCount = 0;

            timer.Start();
            DoSort();
            timer.Stop();
            return timer.Elapsed;
        }
        protected virtual void DoSort()
        {
            Items.Sort();
        }
    }
}
