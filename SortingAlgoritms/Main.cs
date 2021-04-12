using System;
using SortingAlgoritms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithm;

namespace SortingAlgoritms
{
    public partial class Main : Form
    {
        BaseAlgorithm<int> algorithm = new BubbleSort<int>();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(richTextBox1.Text, out int value))
            {
                algorithm.Items.Add(value);
                label1.Text += " " + value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            algorithm.Sort();

            foreach(var item in algorithm.Items)
            {
                label2.Text += " " + item;
            }
        }
    }
}
