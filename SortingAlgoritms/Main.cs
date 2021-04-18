using System;
using System.Collections.Generic;
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
                var item = new SortedItem(value);
                items.Add(item);
                panel2.Controls.Add(item.VProgressBar);
                panel2.Controls.Add(item.Label);
            }
            TextboxAdd.Text = "";
        }

        private void AddListButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TextboxAddList.Text, out int value))
            {
                var rnd = new Random();
                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next());
                    items.Add(item);
                    panel2.Controls.Add(item.VProgressBar);
                    panel2.Controls.Add(item.Label);
                }
            }
            TextboxAddList.Text = "";
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
