using System;
using System.Drawing;
using System.Windows.Forms;

namespace SortingAlgoritms
{
    class SortedItem : IComparable
    {
        public VerticalProgressBar.VerticalProgressBar VProgressBar { get; private set; }
        public Label Label { get; private set; }
        public int Value { get; private set; }
        public int Number { get; private set; }
        public int StartNumber { get; private set; }
        public SortedItem(int value, int number)
        {
            Value = value;
            Number = number;
            StartNumber = number;
            VProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Label = new Label();

            var x = number * 25;

            VProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            VProgressBar.Color = Color.Blue;
            VProgressBar.Location = new Point(x, 0);
            VProgressBar.Maximum = 100;
            VProgressBar.Minimum = 0;
            VProgressBar.Name = "VProgressBar" + number;
            VProgressBar.Size = new Size(18, 96);
            VProgressBar.Step = 1;
            VProgressBar.Style = VerticalProgressBar.Styles.Solid;
            VProgressBar.TabIndex = number;
            VProgressBar.Value = Value;
            
            Label.AutoSize = true;
            Label.Location = new Point(x, 100);
            Label.Name = "label" + number;
            Label.Size = new Size(19, 13);
            Label.TabIndex = number;
            Label.Text = Value.ToString();
        }

        public void SetPosition(int number)
        {
            Number = number;
            var x = number * 25;
            VProgressBar.Location = new Point(x, 0);
            VProgressBar.Name = "VProgressBar" + number;
            Label.Location = new Point(x, 100);
            Label.Name = "label" + number;
        }
        public void SetColor(Color color)
        {
            VProgressBar.Color = color;
        }

        public void Refresh()
        {
            Number = StartNumber;
            var x = Number * 25;
            VProgressBar.Location = new Point(x, 0);
            VProgressBar.Name = "VProgressBar" + Number;
            Label.Location = new Point(x, 100);
            Label.Name = "label" + Number;
        }

        public int CompareTo(object obj)
        {
            if (obj is SortedItem item)
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
        public override int GetHashCode()
        {
            return Value;
        }
    }
}
