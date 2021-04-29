using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Algorithm;

namespace SortingAlgoritms
{
    public partial class Main : Form
    {
        List<SortedItem> items = new List<SortedItem>();

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
                for (int i = 0; i < 8; i++)
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
            foreach(var item in items)
            {
                item.Refresh();
            }

            DrawItems(items);
        }

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            RefreshItems();
            var bubble = new BubbleSort<SortedItem>(items);
            bubble.SwopEvent += Bubble_SwopEvent;
            var time = bubble.Sort();
        }

        private void Bubble_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);

            panel2.Refresh();
        }
    }
    public class VerticalProgressBar : ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04;
                return cp;
            }
        }
    }
}
