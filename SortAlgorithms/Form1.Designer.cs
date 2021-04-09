
namespace SortAlgorithms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.fillNumbers = new System.Windows.Forms.Button();
            this.fillTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.BubbleSortBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SwapLbl = new System.Windows.Forms.Label();
            this.CompareLbl = new System.Windows.Forms.Label();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.CocktailSortBtn = new System.Windows.Forms.Button();
            this.InsertionSortBtn = new System.Windows.Forms.Button();
            this.ShellSortBtn = new System.Windows.Forms.Button();
            this.SelectionSortBtn = new System.Windows.Forms.Button();
            this.HeapSortBtn = new System.Windows.Forms.Button();
            this.GnomeSortBtn = new System.Windows.Forms.Button();
            this.TreeSortBtn = new System.Windows.Forms.Button();
            this.LsdRadixSortBtn = new System.Windows.Forms.Button();
            this.MsdRadixSortBtn = new System.Windows.Forms.Button();
            this.MergeSortBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.addTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add number";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(168, 32);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(12, 35);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(137, 20);
            this.addTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.fillNumbers);
            this.panel2.Controls.Add(this.fillTextBox);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 74);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fill array with random numbers";
            // 
            // fillNumbers
            // 
            this.fillNumbers.Location = new System.Drawing.Point(168, 32);
            this.fillNumbers.Name = "fillNumbers";
            this.fillNumbers.Size = new System.Drawing.Size(75, 23);
            this.fillNumbers.TabIndex = 1;
            this.fillNumbers.Text = "Fill";
            this.fillNumbers.UseVisualStyleBackColor = true;
            this.fillNumbers.Click += new System.EventHandler(this.fillNumbers_Click);
            // 
            // fillTextBox
            // 
            this.fillTextBox.Location = new System.Drawing.Point(12, 35);
            this.fillTextBox.Name = "fillTextBox";
            this.fillTextBox.Size = new System.Drawing.Size(137, 20);
            this.fillTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(258, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 135);
            this.panel3.TabIndex = 3;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // BubbleSortBtn
            // 
            this.BubbleSortBtn.Location = new System.Drawing.Point(12, 187);
            this.BubbleSortBtn.Name = "BubbleSortBtn";
            this.BubbleSortBtn.Size = new System.Drawing.Size(75, 23);
            this.BubbleSortBtn.TabIndex = 5;
            this.BubbleSortBtn.Text = "Bubble Sort";
            this.BubbleSortBtn.UseVisualStyleBackColor = true;
            this.BubbleSortBtn.Click += new System.EventHandler(this.BubbleSortBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = " ";
            // 
            // SwapLbl
            // 
            this.SwapLbl.AutoSize = true;
            this.SwapLbl.Location = new System.Drawing.Point(12, 295);
            this.SwapLbl.Name = "SwapLbl";
            this.SwapLbl.Size = new System.Drawing.Size(10, 13);
            this.SwapLbl.TabIndex = 7;
            this.SwapLbl.Text = " ";
            // 
            // CompareLbl
            // 
            this.CompareLbl.AutoSize = true;
            this.CompareLbl.Location = new System.Drawing.Point(12, 312);
            this.CompareLbl.Name = "CompareLbl";
            this.CompareLbl.Size = new System.Drawing.Size(10, 13);
            this.CompareLbl.TabIndex = 8;
            this.CompareLbl.Text = " ";
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(12, 277);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(10, 13);
            this.TimeLbl.TabIndex = 9;
            this.TimeLbl.Text = " ";
            // 
            // CocktailSortBtn
            // 
            this.CocktailSortBtn.Location = new System.Drawing.Point(12, 216);
            this.CocktailSortBtn.Name = "CocktailSortBtn";
            this.CocktailSortBtn.Size = new System.Drawing.Size(75, 23);
            this.CocktailSortBtn.TabIndex = 10;
            this.CocktailSortBtn.Text = "Cocktail Sort";
            this.CocktailSortBtn.UseVisualStyleBackColor = true;
            this.CocktailSortBtn.Click += new System.EventHandler(this.CocktailSortBtn_Click);
            // 
            // InsertionSortBtn
            // 
            this.InsertionSortBtn.Location = new System.Drawing.Point(108, 187);
            this.InsertionSortBtn.Name = "InsertionSortBtn";
            this.InsertionSortBtn.Size = new System.Drawing.Size(85, 23);
            this.InsertionSortBtn.TabIndex = 11;
            this.InsertionSortBtn.Text = "Insertion Sort";
            this.InsertionSortBtn.UseVisualStyleBackColor = true;
            this.InsertionSortBtn.Click += new System.EventHandler(this.InsertionSortBtn_Click);
            // 
            // ShellSortBtn
            // 
            this.ShellSortBtn.Location = new System.Drawing.Point(213, 216);
            this.ShellSortBtn.Name = "ShellSortBtn";
            this.ShellSortBtn.Size = new System.Drawing.Size(75, 23);
            this.ShellSortBtn.TabIndex = 12;
            this.ShellSortBtn.Text = "Shell Sort";
            this.ShellSortBtn.UseVisualStyleBackColor = true;
            this.ShellSortBtn.Click += new System.EventHandler(this.ShellSortBtn_Click);
            // 
            // SelectionSortBtn
            // 
            this.SelectionSortBtn.Location = new System.Drawing.Point(108, 216);
            this.SelectionSortBtn.Name = "SelectionSortBtn";
            this.SelectionSortBtn.Size = new System.Drawing.Size(85, 23);
            this.SelectionSortBtn.TabIndex = 13;
            this.SelectionSortBtn.Text = "Selection Sort";
            this.SelectionSortBtn.UseVisualStyleBackColor = true;
            this.SelectionSortBtn.Click += new System.EventHandler(this.SelectionSortBtn_Click);
            // 
            // HeapSortBtn
            // 
            this.HeapSortBtn.Location = new System.Drawing.Point(307, 187);
            this.HeapSortBtn.Name = "HeapSortBtn";
            this.HeapSortBtn.Size = new System.Drawing.Size(75, 23);
            this.HeapSortBtn.TabIndex = 14;
            this.HeapSortBtn.Text = "Heap Sort";
            this.HeapSortBtn.UseVisualStyleBackColor = true;
            this.HeapSortBtn.Click += new System.EventHandler(this.HeapSortBtn_Click);
            // 
            // GnomeSortBtn
            // 
            this.GnomeSortBtn.Location = new System.Drawing.Point(213, 187);
            this.GnomeSortBtn.Name = "GnomeSortBtn";
            this.GnomeSortBtn.Size = new System.Drawing.Size(75, 23);
            this.GnomeSortBtn.TabIndex = 15;
            this.GnomeSortBtn.Text = "Gnome Sort";
            this.GnomeSortBtn.UseVisualStyleBackColor = true;
            this.GnomeSortBtn.Click += new System.EventHandler(this.GnomeSortBtn_Click);
            // 
            // TreeSortBtn
            // 
            this.TreeSortBtn.Location = new System.Drawing.Point(308, 216);
            this.TreeSortBtn.Name = "TreeSortBtn";
            this.TreeSortBtn.Size = new System.Drawing.Size(75, 23);
            this.TreeSortBtn.TabIndex = 16;
            this.TreeSortBtn.Text = "Tree Sort";
            this.TreeSortBtn.UseVisualStyleBackColor = true;
            this.TreeSortBtn.Click += new System.EventHandler(this.TreeSortBtn_Click);
            // 
            // LsdRadixSortBtn
            // 
            this.LsdRadixSortBtn.Location = new System.Drawing.Point(404, 187);
            this.LsdRadixSortBtn.Name = "LsdRadixSortBtn";
            this.LsdRadixSortBtn.Size = new System.Drawing.Size(90, 23);
            this.LsdRadixSortBtn.TabIndex = 17;
            this.LsdRadixSortBtn.Text = "Lsd Radix Sort";
            this.LsdRadixSortBtn.UseVisualStyleBackColor = true;
            this.LsdRadixSortBtn.Click += new System.EventHandler(this.LsdRadixSortBtn_Click);
            // 
            // MsdRadixSortBtn
            // 
            this.MsdRadixSortBtn.Location = new System.Drawing.Point(404, 216);
            this.MsdRadixSortBtn.Name = "MsdRadixSortBtn";
            this.MsdRadixSortBtn.Size = new System.Drawing.Size(90, 23);
            this.MsdRadixSortBtn.TabIndex = 18;
            this.MsdRadixSortBtn.Text = "Msd Radix Sort";
            this.MsdRadixSortBtn.UseVisualStyleBackColor = true;
            this.MsdRadixSortBtn.Click += new System.EventHandler(this.MsdRadixSortBtn_Click);
            // 
            // MergeSortBtn
            // 
            this.MergeSortBtn.Location = new System.Drawing.Point(516, 187);
            this.MergeSortBtn.Name = "MergeSortBtn";
            this.MergeSortBtn.Size = new System.Drawing.Size(75, 23);
            this.MergeSortBtn.TabIndex = 19;
            this.MergeSortBtn.Text = "Merge Sort";
            this.MergeSortBtn.UseVisualStyleBackColor = true;
            this.MergeSortBtn.Click += new System.EventHandler(this.MergeSortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 354);
            this.Controls.Add(this.MergeSortBtn);
            this.Controls.Add(this.MsdRadixSortBtn);
            this.Controls.Add(this.LsdRadixSortBtn);
            this.Controls.Add(this.TreeSortBtn);
            this.Controls.Add(this.GnomeSortBtn);
            this.Controls.Add(this.HeapSortBtn);
            this.Controls.Add(this.SelectionSortBtn);
            this.Controls.Add(this.ShellSortBtn);
            this.Controls.Add(this.InsertionSortBtn);
            this.Controls.Add(this.CocktailSortBtn);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.CompareLbl);
            this.Controls.Add(this.SwapLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BubbleSortBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fillNumbers;
        private System.Windows.Forms.TextBox fillTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button BubbleSortBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CompareLbl;
        private System.Windows.Forms.Label SwapLbl;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Button CocktailSortBtn;
        private System.Windows.Forms.Button InsertionSortBtn;
        private System.Windows.Forms.Button ShellSortBtn;
        private System.Windows.Forms.Button SelectionSortBtn;
        private System.Windows.Forms.Button HeapSortBtn;
        private System.Windows.Forms.Button GnomeSortBtn;
        private System.Windows.Forms.Button TreeSortBtn;
        private System.Windows.Forms.Button LsdRadixSortBtn;
        private System.Windows.Forms.Button MsdRadixSortBtn;
        private System.Windows.Forms.Button MergeSortBtn;
    }
}

