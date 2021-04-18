
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
            this.panel2 = new System.Windows.Forms.Panel();
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
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.Location = new System.Drawing.Point(292, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 144);
            this.panel2.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "SortingAlgorithms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddRNDLabel;
        private System.Windows.Forms.Button AddListButton;
        private System.Windows.Forms.RichTextBox TextboxAddList;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.RichTextBox TextboxAdd;
        private System.Windows.Forms.Panel panel2;
    }
}

