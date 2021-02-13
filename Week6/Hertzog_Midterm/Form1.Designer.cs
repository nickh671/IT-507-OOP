namespace Hertzog_Midterm
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
            this.label1 = new System.Windows.Forms.Label();
            this.totalBudgetTB = new System.Windows.Forms.TextBox();
            this.numBillsTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthLB = new System.Windows.Forms.ListBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.budgetGB = new System.Windows.Forms.GroupBox();
            this.billsGB = new System.Windows.Forms.GroupBox();
            this.enterBillBtn = new System.Windows.Forms.Button();
            this.billTB = new System.Windows.Forms.TextBox();
            this.billLabel = new System.Windows.Forms.Label();
            this.resultGB = new System.Windows.Forms.GroupBox();
            this.verdictTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalSpentTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resultNumBillsTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resultBudgetTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.monthTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.budgetGB.SuspendLayout();
            this.billsGB.SuspendLayout();
            this.resultGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Budget:";
            // 
            // totalBudgetTB
            // 
            this.totalBudgetTB.Location = new System.Drawing.Point(117, 27);
            this.totalBudgetTB.Name = "totalBudgetTB";
            this.totalBudgetTB.Size = new System.Drawing.Size(120, 20);
            this.totalBudgetTB.TabIndex = 1;
            // 
            // numBillsTB
            // 
            this.numBillsTB.Location = new System.Drawing.Point(117, 62);
            this.numBillsTB.Name = "numBillsTB";
            this.numBillsTB.Size = new System.Drawing.Size(120, 20);
            this.numBillsTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Bills:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Month:";
            // 
            // monthLB
            // 
            this.monthLB.FormattingEnabled = true;
            this.monthLB.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthLB.Location = new System.Drawing.Point(117, 101);
            this.monthLB.Name = "monthLB";
            this.monthLB.Size = new System.Drawing.Size(120, 95);
            this.monthLB.TabIndex = 5;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(117, 215);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(120, 23);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // budgetGB
            // 
            this.budgetGB.Controls.Add(this.label1);
            this.budgetGB.Controls.Add(this.submitBtn);
            this.budgetGB.Controls.Add(this.totalBudgetTB);
            this.budgetGB.Controls.Add(this.monthLB);
            this.budgetGB.Controls.Add(this.numBillsTB);
            this.budgetGB.Controls.Add(this.label3);
            this.budgetGB.Controls.Add(this.label2);
            this.budgetGB.Location = new System.Drawing.Point(12, 12);
            this.budgetGB.Name = "budgetGB";
            this.budgetGB.Size = new System.Drawing.Size(266, 264);
            this.budgetGB.TabIndex = 7;
            this.budgetGB.TabStop = false;
            this.budgetGB.Text = "Budget";
            // 
            // billsGB
            // 
            this.billsGB.Controls.Add(this.enterBillBtn);
            this.billsGB.Controls.Add(this.billTB);
            this.billsGB.Controls.Add(this.billLabel);
            this.billsGB.Location = new System.Drawing.Point(298, 12);
            this.billsGB.Name = "billsGB";
            this.billsGB.Size = new System.Drawing.Size(241, 264);
            this.billsGB.TabIndex = 8;
            this.billsGB.TabStop = false;
            this.billsGB.Text = "Bills";
            // 
            // enterBillBtn
            // 
            this.enterBillBtn.Location = new System.Drawing.Point(82, 65);
            this.enterBillBtn.Name = "enterBillBtn";
            this.enterBillBtn.Size = new System.Drawing.Size(128, 23);
            this.enterBillBtn.TabIndex = 2;
            this.enterBillBtn.Text = "Enter";
            this.enterBillBtn.UseVisualStyleBackColor = true;
            this.enterBillBtn.Click += new System.EventHandler(this.enterBillBtn_Click);
            // 
            // billTB
            // 
            this.billTB.Location = new System.Drawing.Point(82, 24);
            this.billTB.Name = "billTB";
            this.billTB.Size = new System.Drawing.Size(128, 20);
            this.billTB.TabIndex = 1;
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Location = new System.Drawing.Point(6, 27);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(59, 15);
            this.billLabel.TabIndex = 0;
            this.billLabel.Text = "Enter Bill:";
            this.billLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // resultGB
            // 
            this.resultGB.Controls.Add(this.verdictTB);
            this.resultGB.Controls.Add(this.label8);
            this.resultGB.Controls.Add(this.totalSpentTB);
            this.resultGB.Controls.Add(this.label7);
            this.resultGB.Controls.Add(this.resultNumBillsTB);
            this.resultGB.Controls.Add(this.label6);
            this.resultGB.Controls.Add(this.resultBudgetTB);
            this.resultGB.Controls.Add(this.label5);
            this.resultGB.Controls.Add(this.monthTB);
            this.resultGB.Controls.Add(this.label4);
            this.resultGB.Location = new System.Drawing.Point(12, 282);
            this.resultGB.Name = "resultGB";
            this.resultGB.Size = new System.Drawing.Size(527, 140);
            this.resultGB.TabIndex = 9;
            this.resultGB.TabStop = false;
            this.resultGB.Text = "Result";
            this.resultGB.Enter += new System.EventHandler(this.resultGB_Enter);
            // 
            // verdictTB
            // 
            this.verdictTB.Location = new System.Drawing.Point(379, 56);
            this.verdictTB.Name = "verdictTB";
            this.verdictTB.ReadOnly = true;
            this.verdictTB.Size = new System.Drawing.Size(100, 20);
            this.verdictTB.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Verdict:";
            // 
            // totalSpentTB
            // 
            this.totalSpentTB.Location = new System.Drawing.Point(379, 23);
            this.totalSpentTB.Name = "totalSpentTB";
            this.totalSpentTB.ReadOnly = true;
            this.totalSpentTB.Size = new System.Drawing.Size(100, 20);
            this.totalSpentTB.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Spent ($):";
            // 
            // resultNumBillsTB
            // 
            this.resultNumBillsTB.Location = new System.Drawing.Point(117, 93);
            this.resultNumBillsTB.Name = "resultNumBillsTB";
            this.resultNumBillsTB.ReadOnly = true;
            this.resultNumBillsTB.Size = new System.Drawing.Size(100, 20);
            this.resultNumBillsTB.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number of Bills:";
            // 
            // resultBudgetTB
            // 
            this.resultBudgetTB.Location = new System.Drawing.Point(117, 59);
            this.resultBudgetTB.Name = "resultBudgetTB";
            this.resultBudgetTB.ReadOnly = true;
            this.resultBudgetTB.Size = new System.Drawing.Size(100, 20);
            this.resultBudgetTB.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Budget ($):";
            // 
            // monthTB
            // 
            this.monthTB.Location = new System.Drawing.Point(117, 26);
            this.monthTB.Name = "monthTB";
            this.monthTB.ReadOnly = true;
            this.monthTB.Size = new System.Drawing.Size(100, 20);
            this.monthTB.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Month:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 434);
            this.Controls.Add(this.resultGB);
            this.Controls.Add(this.billsGB);
            this.Controls.Add(this.budgetGB);
            this.Name = "Form1";
            this.Text = "Midterm";
            this.budgetGB.ResumeLayout(false);
            this.budgetGB.PerformLayout();
            this.billsGB.ResumeLayout(false);
            this.billsGB.PerformLayout();
            this.resultGB.ResumeLayout(false);
            this.resultGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalBudgetTB;
        private System.Windows.Forms.TextBox numBillsTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox monthLB;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.GroupBox budgetGB;
        private System.Windows.Forms.GroupBox billsGB;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.Button enterBillBtn;
        private System.Windows.Forms.TextBox billTB;
        private System.Windows.Forms.GroupBox resultGB;
        private System.Windows.Forms.TextBox monthTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultNumBillsTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultBudgetTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox verdictTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalSpentTB;
        private System.Windows.Forms.Label label7;
    }
}

