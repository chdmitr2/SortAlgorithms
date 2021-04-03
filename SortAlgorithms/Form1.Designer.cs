
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
            this.panel3.Size = new System.Drawing.Size(337, 135);
            this.panel3.TabIndex = 3;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // BubbleSortBtn
            // 
            this.BubbleSortBtn.Location = new System.Drawing.Point(12, 194);
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
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = " ";
            // 
            // SwapLbl
            // 
            this.SwapLbl.AutoSize = true;
            this.SwapLbl.Location = new System.Drawing.Point(12, 260);
            this.SwapLbl.Name = "SwapLbl";
            this.SwapLbl.Size = new System.Drawing.Size(10, 13);
            this.SwapLbl.TabIndex = 7;
            this.SwapLbl.Text = " ";
            // 
            // CompareLbl
            // 
            this.CompareLbl.AutoSize = true;
            this.CompareLbl.Location = new System.Drawing.Point(12, 282);
            this.CompareLbl.Name = "CompareLbl";
            this.CompareLbl.Size = new System.Drawing.Size(10, 13);
            this.CompareLbl.TabIndex = 8;
            this.CompareLbl.Text = " ";
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(12, 236);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(10, 13);
            this.TimeLbl.TabIndex = 9;
            this.TimeLbl.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 341);
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
    }
}

