using System;

namespace Algorithm.SortingType
{
    public class CocktailSort<T> : BaseAlgorithm<T> where T : IComparable
    {
        protected override void DoSort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while (left < right)
            {
                var swopCount = SwopCount;

                for (int i = left; i < right; i++)
                {
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swop(i, i + 1);
                        CompareCount++;
                    }
                }
                right--;
                if (swopCount == SwopCount)
                {
                    break;
                }
                for (int i = right; i > left; i--)
                {
                    if (Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swop(i, i - 1);
                        CompareCount++;
                    }
                }
                left++;
                if (swopCount == SwopCount)
                {
                    break;
                }
            }
        }
    }
}
