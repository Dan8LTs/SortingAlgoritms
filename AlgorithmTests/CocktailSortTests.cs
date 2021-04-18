using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Algorithm.SortingType.Tests
{
    [TestClass()]
    public class CocktailSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            // arrange
            var cocktail = new CocktailSort<int>();
            var rnd = new Random();
            var items = new List<int>();

            for (int i = 0; i < 5000; i++)
            {
                cocktail.Items.Add(rnd.Next(0, 100));
            }

            items.AddRange(cocktail.Items);
            items.Sort();

            // act
            cocktail.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], cocktail.Items[i]);
            }
        }
    }
}