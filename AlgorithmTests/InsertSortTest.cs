using Algorithm;
using Algorithm.SortingType;
using Algorithm.SortingTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTests
{
    [TestClass]
    public class SortTest
    {
        Random rnd = new Random();
        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();
            for(int i = 10000; i > 1; i--)
            {
                Items.Add(i);
            }
            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod]
        public void BubbleTest()
        {
            // arrange

            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(Items);

            // act
            bubble.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubble.Items[i]);
            }
        }
        
        [TestMethod]
        public void CocktailTest()
        {
            // arrange
            var cocktail = new CocktailSort<int>();
            cocktail.Items.AddRange(Items);

            // act
            cocktail.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], cocktail.Items[i]);
            }
        }
        
        [TestMethod]
        public void InsertTest()
        {
            // arrange
            var insert = new InsertSort<int>();
            insert.Items.AddRange(Items);

            // act
            insert.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insert.Items[i]);
            }
        }
    }
}
