namespace Algorithms
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.SortAlgorithm2 = new System.Windows.Forms.Label();
            this.SortAlgorithmList2 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RandomResult = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AlgorithmTime1 = new System.Windows.Forms.TextBox();
            this.AlgorithmTime2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SortAlgorithmList1 = new System.Windows.Forms.ListBox();
            this.SortAlgorithm1 = new System.Windows.Forms.Label();
            this.AlgorithmListBox1 = new System.Windows.Forms.CheckedListBox();
            this.AlgorithmCheckBox = new System.Windows.Forms.Label();
            this.spBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.spBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Min";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(559, 50);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // SortAlgorithm2
            // 
            this.SortAlgorithm2.AutoSize = true;
            this.SortAlgorithm2.Location = new System.Drawing.Point(555, 107);
            this.SortAlgorithm2.Name = "SortAlgorithm2";
            this.SortAlgorithm2.Size = new System.Drawing.Size(84, 13);
            this.SortAlgorithm2.TabIndex = 3;
            this.SortAlgorithm2.Text = "Sort Algorithm 2:";
            // 
            // SortAlgorithmList2
            // 
            this.SortAlgorithmList2.FormattingEnabled = true;
            this.SortAlgorithmList2.Location = new System.Drawing.Point(558, 132);
            this.SortAlgorithmList2.Name = "SortAlgorithmList2";
            this.SortAlgorithmList2.Size = new System.Drawing.Size(100, 290);
            this.SortAlgorithmList2.TabIndex = 5;
            this.SortAlgorithmList2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(432, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Min and Max number: ";
            // 
            // RandomResult
            // 
            this.RandomResult.FormattingEnabled = true;
            this.RandomResult.Location = new System.Drawing.Point(306, 132);
            this.RandomResult.Name = "RandomResult";
            this.RandomResult.Size = new System.Drawing.Size(100, 290);
            this.RandomResult.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Random Result:";
            // 
            // AlgorithmTime1
            // 
            this.AlgorithmTime1.Location = new System.Drawing.Point(685, 161);
            this.AlgorithmTime1.Name = "AlgorithmTime1";
            this.AlgorithmTime1.Size = new System.Drawing.Size(100, 20);
            this.AlgorithmTime1.TabIndex = 10;
            // 
            // AlgorithmTime2
            // 
            this.AlgorithmTime2.Location = new System.Drawing.Point(685, 227);
            this.AlgorithmTime2.Name = "AlgorithmTime2";
            this.AlgorithmTime2.Size = new System.Drawing.Size(100, 20);
            this.AlgorithmTime2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(682, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Algorithm 1 time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Algorithm 2 time:";
            // 
            // SortAlgorithmList1
            // 
            this.SortAlgorithmList1.FormattingEnabled = true;
            this.SortAlgorithmList1.Location = new System.Drawing.Point(432, 132);
            this.SortAlgorithmList1.Name = "SortAlgorithmList1";
            this.SortAlgorithmList1.Size = new System.Drawing.Size(100, 290);
            this.SortAlgorithmList1.TabIndex = 14;
            // 
            // SortAlgorithm1
            // 
            this.SortAlgorithm1.AutoSize = true;
            this.SortAlgorithm1.Location = new System.Drawing.Point(429, 107);
            this.SortAlgorithm1.Name = "SortAlgorithm1";
            this.SortAlgorithm1.Size = new System.Drawing.Size(84, 13);
            this.SortAlgorithm1.TabIndex = 15;
            this.SortAlgorithm1.Text = "Sort Algorithm 1:";
            // 
            // AlgorithmListBox1
            // 
            this.AlgorithmListBox1.FormattingEnabled = true;
            this.AlgorithmListBox1.Location = new System.Drawing.Point(64, 52);
            this.AlgorithmListBox1.Name = "AlgorithmListBox1";
            this.AlgorithmListBox1.Size = new System.Drawing.Size(184, 364);
            this.AlgorithmListBox1.TabIndex = 16;
            // 
            // AlgorithmCheckBox
            // 
            this.AlgorithmCheckBox.AutoSize = true;
            this.AlgorithmCheckBox.Location = new System.Drawing.Point(61, 26);
            this.AlgorithmCheckBox.Name = "AlgorithmCheckBox";
            this.AlgorithmCheckBox.Size = new System.Drawing.Size(101, 13);
            this.AlgorithmCheckBox.TabIndex = 17;
            this.AlgorithmCheckBox.Text = "Pick two algorithms:";
            // 
            // spBar
            // 
            this.spBar.Location = new System.Drawing.Point(681, 50);
            this.spBar.Maximum = 500;
            this.spBar.Name = "spBar";
            this.spBar.Size = new System.Drawing.Size(104, 45);
            this.spBar.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 469);
            this.Controls.Add(this.spBar);
            this.Controls.Add(this.AlgorithmCheckBox);
            this.Controls.Add(this.AlgorithmListBox1);
            this.Controls.Add(this.SortAlgorithm1);
            this.Controls.Add(this.SortAlgorithmList1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AlgorithmTime2);
            this.Controls.Add(this.AlgorithmTime1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RandomResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SortAlgorithmList2);
            this.Controls.Add(this.SortAlgorithm2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.spBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label SortAlgorithm2;
        private System.Windows.Forms.ListBox SortAlgorithmList2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox RandomResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AlgorithmTime1;
        private System.Windows.Forms.TextBox AlgorithmTime2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox SortAlgorithmList1;
        private System.Windows.Forms.Label SortAlgorithm1;
        private System.Windows.Forms.CheckedListBox AlgorithmListBox1;
        private System.Windows.Forms.Label AlgorithmCheckBox;
        private System.Windows.Forms.TrackBar spBar;
    }
}

