using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Algorithm;
using Algorithm.DataStructures;
using Algorithm.SortingType;
using Algorithm.SortingTypes;

namespace SortingAlgoritms
{
    public partial class Main : Form
    {
        List<SortedItem> items = new List<SortedItem>();
        private const int sleep = 40;

        public Main()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TextboxAdd.Text, out int value))
            {
                var item = new SortedItem(value, items.Count);
                items.Add(item);
            }
            RefreshItems();
            TextboxAdd.Text = "";
        }

        private void AddListButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TextboxAddList.Text, out int value))
            {
                var rnd = new Random();
                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(100), items.Count);
                    items.Add(item);
                }
            }
            RefreshItems();
            TextboxAddList.Text = "";
        }
        private void DrawItems(List<SortedItem> items)
        {
            panel2.Controls.Clear();
            panel2.Refresh();

            foreach (var item in items)
            {
                panel2.Controls.Add(item.VProgressBar);
                panel2.Controls.Add(item.Label);
            }

            panel2.Refresh();
        }

        private void RefreshItems()
        {
            foreach (var item in items)
            {
                item.Refresh();
            }

            DrawItems(items);
        }
        private void BtnClick(BaseAlgorithm<SortedItem> algorithm)
        {
            RefreshItems();

            for (int i = 0; i < algorithm.Items.Count; i++)
            {
                algorithm.Items[i].SetPosition(i);
            }
            panel2.Refresh();

            algorithm.CompareEvent += AlgorithmCompareEvent;
            algorithm.SwopEvent += AlgorithmSwopEvent;
            algorithm.SetEvent += AlgorithmSetEvent;
            var time = algorithm.Sort();

            TimeLbl.Text = "Lead time: " + time.Seconds;
            SwopLbl.Text = "Number of exchanges: " + algorithm.SwopCount;
            CompareLbl.Text = "Number of comparisons: " + algorithm.CompareCount;
        }


        private void AlgorithmSwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Aquamarine);
            e.Item2.SetColor(Color.Gold);
            panel2.Refresh();

            Thread.Sleep(sleep);

            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);
            panel2.Refresh();

            Thread.Sleep(sleep);

            e.Item1.SetColor(Color.DarkViolet);
            e.Item2.SetColor(Color.DarkViolet);
            panel2.Refresh();

            Thread.Sleep(sleep);
        }
        private void AlgorithmCompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panel2.Refresh();

            Thread.Sleep(sleep);

            e.Item1.SetColor(Color.DarkViolet);
            e.Item2.SetColor(Color.DarkViolet);
            panel2.Refresh();

            Thread.Sleep(sleep);
        }
        private void AlgorithmSetEvent(object sender, Tuple<int, SortedItem> e)
        {
            e.Item2.SetColor(Color.Red);
            panel2.Refresh();

            Thread.Sleep(sleep);

            e.Item2.SetPosition(e.Item1);
            panel2.Refresh();

            Thread.Sleep(sleep);

            e.Item2.SetColor(Color.DarkViolet);
            panel2.Refresh();

            Thread.Sleep(sleep);
        }
        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            CleaningLabels();
            var bubble = new BubbleSort<SortedItem>(items);
            BtnClick(bubble);
        }
        private void ShellSortButton_Click(object sender, EventArgs e)
        {
            CleaningLabels();
            var shell = new ShellSort<SortedItem>(items);
            BtnClick(shell);
        }

        private void CocktailSortButton_Click(object sender, EventArgs e)
        {
            CleaningLabels();
            var cocktail = new CocktailSort<SortedItem>(items);
            BtnClick(cocktail);
        }

        private void InsertSortButton_Click(object sender, EventArgs e)
        {
            CleaningLabels();
            var insert = new InsertSort<SortedItem>(items);
            BtnClick(insert);
        }

        private void TreeSortButton_Click(object sender, EventArgs e)
        {
            CleaningLabels();
            var tree = new Tree<SortedItem>(items);
            BtnClick(tree);
        }

        private void HeapSortButton_Click(object sender, EventArgs e)
        {
            CleaningLabels();
            var heap = new Heap<SortedItem>(items);
            BtnClick(heap);
        }

        private void SelectionSortButton_Click(object sender, EventArgs e)
        {
            CleaningLabels();
            var select = new SelectionSort<SortedItem>(items);
            BtnClick(select);
        }
        private void GnomeSortButton_Click(object sender, EventArgs e)
        {
            CleaningLabels();
            var gnome = new GnomeSort<SortedItem>(items);
            BtnClick(gnome);
        }
        private void CleaningLabels()
        {
            TimeLbl.Text = "";
            SwopLbl.Text = "";
            CompareLbl.Text = "";
        }
    }
}
