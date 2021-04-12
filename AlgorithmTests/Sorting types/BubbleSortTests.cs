using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm.Sorting_types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sorting_types.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            // arrange

            var bubble = new BubbleSort<int>();
            var rnd = new Random();
            var items = new List<int>();

            for(int i = 0; i < 5; i++)
            {
                bubble.Items.Add(rnd.Next(0, 100));
            }

            items.AddRange(bubble.Items);
            items.Sort();
            // act
            bubble.Sort();

            // assert
            for(int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], bubble.Items[i]);
            }
        }
    }
}