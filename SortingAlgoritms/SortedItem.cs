using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgoritms
{
    public class SortedItem  : IComparable
    {
        public VerticalProgressBar VProgressBar { get; private set; }
        public Label Label { get; private set; }
        public int Value { get; private set; }
        public int Number { get; private set; }
        public int StartNumber { get; private set; }
        public SortedItem(int value, int number)
        {
            Value = value;
            Number = number;
            StartNumber = number;
            VProgressBar = new VerticalProgressBar();
            Label = new Label();

            var x = number * 25;

            Label.AutoSize = true;
            Label.Location = new Point(x, 117);
            Label.Name = "label" + number;
            Label.Size = new Size(19, 13);
            Label.TabIndex = number;
            Label.Text = Value.ToString();

            VProgressBar.Location = new Point(x, 29);
            VProgressBar.Maximum = 100;
            VProgressBar.Minimum = 0; 
            VProgressBar.Name = "VProgressBar" + number;
            VProgressBar.Size = new Size(20, 84);
            VProgressBar.Step = 1;
            VProgressBar.Style = ProgressBarStyle.Blocks;
            VProgressBar.TabIndex = number;
            VProgressBar.Value = Value;
        }

        public void SetPosition(int number)
        {
            Number = number;
            var x = Number * 25;
            VProgressBar.Location = new Point(x, 29);
            VProgressBar.Name = "VProgressBar" + Number;
            Label.Location = new Point(x, 117);
            Label.Name = "label" + Number;
        }
        public void Refresh()
        {
            Number = StartNumber;
            var x = Number * 25;
            VProgressBar.Location = new Point(x, 29);
            VProgressBar.Name = "ProgressBar" + Number;
            Label.Location = new Point(x, 117);
            Label.Name = "label" + Number;
        }

        public int CompareTo(object obj)
        {
            if(obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));
            }
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
