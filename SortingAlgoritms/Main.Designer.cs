
namespace SortingAlgoritms
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddRNDLabel = new System.Windows.Forms.Label();
            this.AddListButton = new System.Windows.Forms.Button();
            this.TextboxAddList = new System.Windows.Forms.RichTextBox();
            this.AddLabel = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.TextboxAdd = new System.Windows.Forms.RichTextBox();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CocktailSortButton = new System.Windows.Forms.Button();
            this.InsertSortButton = new System.Windows.Forms.Button();
            this.ShellSortButton = new System.Windows.Forms.Button();
            this.TreeSortButton = new System.Windows.Forms.Button();
            this.HeapSortButton = new System.Windows.Forms.Button();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.SwopLbl = new System.Windows.Forms.Label();
            this.CompareLbl = new System.Windows.Forms.Label();
            this.SelectionSortButton = new System.Windows.Forms.Button();
            this.GnomeSortButton = new System.Windows.Forms.Button();
            this.LsdRadixSortButton = new System.Windows.Forms.Button();
            this.MsdRadixSortButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddRNDLabel);
            this.panel1.Controls.Add(this.AddListButton);
            this.panel1.Controls.Add(this.TextboxAddList);
            this.panel1.Controls.Add(this.AddLabel);
            this.panel1.Controls.Add(this.ButtonAdd);
            this.panel1.Controls.Add(this.TextboxAdd);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 144);
            this.panel1.TabIndex = 0;
            // 
            // AddRNDLabel
            // 
            this.AddRNDLabel.AutoSize = true;
            this.AddRNDLabel.Location = new System.Drawing.Point(11, 81);
            this.AddRNDLabel.Name = "AddRNDLabel";
            this.AddRNDLabel.Size = new System.Drawing.Size(184, 13);
            this.AddRNDLabel.TabIndex = 5;
            this.AddRNDLabel.Text = "Enter the number of random numbers:";
            // 
            // AddListButton
            // 
            this.AddListButton.Location = new System.Drawing.Point(201, 83);
            this.AddListButton.Name = "AddListButton";
            this.AddListButton.Size = new System.Drawing.Size(70, 47);
            this.AddListButton.TabIndex = 4;
            this.AddListButton.Text = "Add List";
            this.AddListButton.UseVisualStyleBackColor = true;
            this.AddListButton.Click += new System.EventHandler(this.AddListButton_Click);
            // 
            // TextboxAddList
            // 
            this.TextboxAddList.Location = new System.Drawing.Point(11, 97);
            this.TextboxAddList.Name = "TextboxAddList";
            this.TextboxAddList.Size = new System.Drawing.Size(184, 31);
            this.TextboxAddList.TabIndex = 3;
            this.TextboxAddList.Text = "";
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Location = new System.Drawing.Point(11, 13);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(67, 13);
            this.AddLabel.TabIndex = 2;
            this.AddLabel.Text = "Add number:";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(172, 13);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(99, 47);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TextboxAdd
            // 
            this.TextboxAdd.Location = new System.Drawing.Point(11, 29);
            this.TextboxAdd.Name = "TextboxAdd";
            this.TextboxAdd.Size = new System.Drawing.Size(155, 31);
            this.TextboxAdd.TabIndex = 0;
            this.TextboxAdd.Text = "";
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Location = new System.Drawing.Point(12, 153);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(82, 23);
            this.BubbleSortButton.TabIndex = 2;
            this.BubbleSortButton.Text = "Bubble Sort";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(301, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 232);
            this.panel2.TabIndex = 3;
            // 
            // CocktailSortButton
            // 
            this.CocktailSortButton.Location = new System.Drawing.Point(101, 153);
            this.CocktailSortButton.Name = "CocktailSortButton";
            this.CocktailSortButton.Size = new System.Drawing.Size(83, 23);
            this.CocktailSortButton.TabIndex = 4;
            this.CocktailSortButton.Text = "Cocktail Sort";
            this.CocktailSortButton.UseVisualStyleBackColor = true;
            this.CocktailSortButton.Click += new System.EventHandler(this.CocktailSortButton_Click);
            // 
            // InsertSortButton
            // 
            this.InsertSortButton.Location = new System.Drawing.Point(190, 153);
            this.InsertSortButton.Name = "InsertSortButton";
            this.InsertSortButton.Size = new System.Drawing.Size(83, 23);
            this.InsertSortButton.TabIndex = 5;
            this.InsertSortButton.Text = "Insertion Sort";
            this.InsertSortButton.UseVisualStyleBackColor = true;
            this.InsertSortButton.Click += new System.EventHandler(this.InsertSortButton_Click);
            // 
            // ShellSortButton
            // 
            this.ShellSortButton.Location = new System.Drawing.Point(12, 182);
            this.ShellSortButton.Name = "ShellSortButton";
            this.ShellSortButton.Size = new System.Drawing.Size(82, 23);
            this.ShellSortButton.TabIndex = 6;
            this.ShellSortButton.Text = "Shell Sort";
            this.ShellSortButton.UseVisualStyleBackColor = true;
            this.ShellSortButton.Click += new System.EventHandler(this.ShellSortButton_Click);
            // 
            // TreeSortButton
            // 
            this.TreeSortButton.Location = new System.Drawing.Point(101, 182);
            this.TreeSortButton.Name = "TreeSortButton";
            this.TreeSortButton.Size = new System.Drawing.Size(83, 23);
            this.TreeSortButton.TabIndex = 7;
            this.TreeSortButton.Text = "Tree Sort";
            this.TreeSortButton.UseVisualStyleBackColor = true;
            this.TreeSortButton.Click += new System.EventHandler(this.TreeSortButton_Click);
            // 
            // HeapSortButton
            // 
            this.HeapSortButton.Location = new System.Drawing.Point(190, 182);
            this.HeapSortButton.Name = "HeapSortButton";
            this.HeapSortButton.Size = new System.Drawing.Size(83, 23);
            this.HeapSortButton.TabIndex = 8;
            this.HeapSortButton.Text = "Heap Sort";
            this.HeapSortButton.UseVisualStyleBackColor = true;
            this.HeapSortButton.Click += new System.EventHandler(this.HeapSortButton_Click);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(9, 291);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(56, 13);
            this.TimeLbl.TabIndex = 9;
            this.TimeLbl.Text = "Lead time:";
            // 
            // SwopLbl
            // 
            this.SwopLbl.AutoSize = true;
            this.SwopLbl.Location = new System.Drawing.Point(9, 344);
            this.SwopLbl.Name = "SwopLbl";
            this.SwopLbl.Size = new System.Drawing.Size(114, 13);
            this.SwopLbl.TabIndex = 10;
            this.SwopLbl.Text = "Number of exchanges:";
            // 
            // CompareLbl
            // 
            this.CompareLbl.AutoSize = true;
            this.CompareLbl.Location = new System.Drawing.Point(9, 318);
            this.CompareLbl.Name = "CompareLbl";
            this.CompareLbl.Size = new System.Drawing.Size(121, 13);
            this.CompareLbl.TabIndex = 11;
            this.CompareLbl.Text = "Number of comparisons:";
            // 
            // SelectionSortButton
            // 
            this.SelectionSortButton.Location = new System.Drawing.Point(12, 211);
            this.SelectionSortButton.Name = "SelectionSortButton";
            this.SelectionSortButton.Size = new System.Drawing.Size(82, 23);
            this.SelectionSortButton.TabIndex = 12;
            this.SelectionSortButton.Text = "Selection Sort";
            this.SelectionSortButton.UseVisualStyleBackColor = true;
            this.SelectionSortButton.Click += new System.EventHandler(this.SelectionSortButton_Click);
            // 
            // GnomeSortButton
            // 
            this.GnomeSortButton.Location = new System.Drawing.Point(101, 211);
            this.GnomeSortButton.Name = "GnomeSortButton";
            this.GnomeSortButton.Size = new System.Drawing.Size(83, 23);
            this.GnomeSortButton.TabIndex = 13;
            this.GnomeSortButton.Text = "Gnome Sort";
            this.GnomeSortButton.UseVisualStyleBackColor = true;
            this.GnomeSortButton.Click += new System.EventHandler(this.GnomeSortButton_Click);
            // 
            // LsdRadixSortButton
            // 
            this.LsdRadixSortButton.Location = new System.Drawing.Point(189, 211);
            this.LsdRadixSortButton.Name = "LsdRadixSortButton";
            this.LsdRadixSortButton.Size = new System.Drawing.Size(83, 23);
            this.LsdRadixSortButton.TabIndex = 14;
            this.LsdRadixSortButton.Text = "LsdRadixSort";
            this.LsdRadixSortButton.UseVisualStyleBackColor = true;
            this.LsdRadixSortButton.Click += new System.EventHandler(this.LsdRadixSortButton_Click);
            // 
            // MsdRadixSortButton
            // 
            this.MsdRadixSortButton.Location = new System.Drawing.Point(12, 240);
            this.MsdRadixSortButton.Name = "MsdRadixSortButton";
            this.MsdRadixSortButton.Size = new System.Drawing.Size(82, 23);
            this.MsdRadixSortButton.TabIndex = 15;
            this.MsdRadixSortButton.Text = "MsdRadixSort";
            this.MsdRadixSortButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(590, 366);
            this.Controls.Add(this.MsdRadixSortButton);
            this.Controls.Add(this.LsdRadixSortButton);
            this.Controls.Add(this.GnomeSortButton);
            this.Controls.Add(this.SelectionSortButton);
            this.Controls.Add(this.CompareLbl);
            this.Controls.Add(this.SwopLbl);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.HeapSortButton);
            this.Controls.Add(this.TreeSortButton);
            this.Controls.Add(this.ShellSortButton);
            this.Controls.Add(this.InsertSortButton);
            this.Controls.Add(this.CocktailSortButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BubbleSortButton);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "SortingAlgorithms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddRNDLabel;
        private System.Windows.Forms.Button AddListButton;
        private System.Windows.Forms.RichTextBox TextboxAddList;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.RichTextBox TextboxAdd;
        private System.Windows.Forms.Button BubbleSortButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CocktailSortButton;
        private System.Windows.Forms.Button InsertSortButton;
        private System.Windows.Forms.Button ShellSortButton;
        private System.Windows.Forms.Button TreeSortButton;
        private System.Windows.Forms.Button HeapSortButton;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Label SwopLbl;
        private System.Windows.Forms.Label CompareLbl;
        private System.Windows.Forms.Button SelectionSortButton;
        private System.Windows.Forms.Button GnomeSortButton;
        private System.Windows.Forms.Button LsdRadixSortButton;
        private System.Windows.Forms.Button MsdRadixSortButton;
    }
}

