using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class Heap<T> where T : IComparable
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;
        public T Peek()
        {
            if (Count > 0)
            {
                return items[0];
            }
            else
            {
                throw new ArgumentNullException(nameof(items), "Heap is empty");
            }
        }

        public Heap() { }

        public Heap(IEnumerable<T> items)
        {
            this.items.AddRange(items);
            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }

        public void Add(T item)
        {
            items.Add(item);

            var indexCurrent = Count - 1;
            var indexParent = GetParent(indexCurrent);

            while (indexCurrent > 0 && items[indexParent].CompareTo(items[indexCurrent]) == -1)
            {
                SwapCurrent(indexCurrent, indexParent);
                indexCurrent = indexParent;
                indexParent = GetParent(indexCurrent);
            }
        }

        public T GetMax()
        {
            var result = items[0];
            items[0] = items[Count - 1];
            items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }

        private void Sort(int indexCurrent)
        {
            int indexMax = indexCurrent;
            int indexLeft;
            int indexRight;

            while (indexCurrent < Count)
            {
                indexLeft = indexCurrent * 2 + 1;
                indexRight = indexCurrent * 2 + 2;

                if (indexLeft < Count && items[indexLeft].CompareTo(items[indexMax]) == -1)
                {
                    indexMax = indexLeft;
                }

                if (indexRight < Count && items[indexRight].CompareTo(items[indexMax]) == -1)
                {
                    indexMax = indexRight;
                }

                if (indexMax == indexCurrent)
                {
                    break;
                }

                SwapCurrent(indexCurrent, indexMax);
                indexCurrent = indexMax;
            }
        }

        private void SwapCurrent(int current, int parent)
        {
            var  temp = items[current];
            items[current] = items[parent];
            items[parent] = temp;
        }


        private static int GetParent(int current)
        {
            return (current - 1) / 2;
        }

        public List<T> Order()
        {
            var result = new List<T>();
            while (Count > 0)
            {
                result.Add(GetMax());
            }
            return result;
        }
    }
}
