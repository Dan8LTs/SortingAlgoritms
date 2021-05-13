using Algorithm;
using Algorithm.DataStructures;
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
            for (int i = 0; i < 1000; i++)
            {
                Items.Add(rnd.Next());
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

        [TestMethod]
        public void ShellTest()
        {
            // arrange
            var shell = new ShellSort<int>();
            shell.Items.AddRange(Items);

            // act
            shell.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shell.Items[i]);
            }
        }

        [TestMethod]
        public void TreeTest()
        {
            // arrange
            var tree = new Tree<int>(Items);

            // act
            tree.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], tree.Items[i]);
            }
        }

        [TestMethod]
        public void HeapTest()
        {
            // arrange
            var heap = new Heap<int>(Items);

            // act
            heap.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], heap.Items[i]);
            }
        }

        [TestMethod]
        public void SelectionTest()
        {
            // arrange
            var select = new SelectionSort<int>();
            select.Items.AddRange(Items);

            // act
            select.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], select.Items[i]);
            }
        }

        [TestMethod]
        public void GnomeTest()
        {
            // arrange
            var gnome = new GnomeSort<int>();
            gnome.Items.AddRange(Items);

            // act
            gnome.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], gnome.Items[i]);
            }
        }
    }
}
