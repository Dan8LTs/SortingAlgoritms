using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgoritms
{
    class SortedItem
    {
        public VerticalProgressBar VProgressBar { get; private set; }
        public Label Label { get; private set; }
        public int Value { get; set; }
        public SortedItem(int value)
        {
            Value = value;
            VProgressBar = new VerticalProgressBar();
            Label = new Label();

            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(19, 117);
            Label.Name = "label1";
            Label.Size = new System.Drawing.Size(19, 13);
            Label.TabIndex = 5;
            Label.Text = Value.ToString();

            VProgressBar.BackColor = System.Drawing.SystemColors.Desktop;
            VProgressBar.ForeColor = System.Drawing.SystemColors.Desktop;
            VProgressBar.Location = new System.Drawing.Point(12, 29);
            VProgressBar.Maximum = 100;
            VProgressBar.Minimum = 0; 
            VProgressBar.Name = "VProgressBar1";
            VProgressBar.Size = new System.Drawing.Size(26, 84);
            VProgressBar.Step = 1;
            VProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            VProgressBar.TabIndex = 0;
            VProgressBar.Value = Value;
        }
    }
}
