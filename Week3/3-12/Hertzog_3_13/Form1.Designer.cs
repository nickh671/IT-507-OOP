namespace Hertzog_3_13
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
            this.SquareFeetLabel = new System.Windows.Forms.Label();
            this.PricePerGallonLabel = new System.Windows.Forms.Label();
            this.SquareFeetTextBox = new System.Windows.Forms.TextBox();
            this.CostPerGallonTextBox = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumGallonsLabel = new System.Windows.Forms.Label();
            this.NumGallonsTB = new System.Windows.Forms.TextBox();
            this.LaborHoursLabel = new System.Windows.Forms.Label();
            this.PaintCostLabel = new System.Windows.Forms.Label();
            this.LaborCostLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.TotalCostTB = new System.Windows.Forms.TextBox();
            this.LaborCostTB = new System.Windows.Forms.TextBox();
            this.PaintCostTB = new System.Windows.Forms.TextBox();
            this.LaborHoursTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SquareFeetLabel
            // 
            this.SquareFeetLabel.AutoSize = true;
            this.SquareFeetLabel.Location = new System.Drawing.Point(22, 31);
            this.SquareFeetLabel.Name = "SquareFeetLabel";
            this.SquareFeetLabel.Size = new System.Drawing.Size(74, 15);
            this.SquareFeetLabel.TabIndex = 0;
            this.SquareFeetLabel.Text = "Square Feet";
            // 
            // PricePerGallonLabel
            // 
            this.PricePerGallonLabel.AutoSize = true;
            this.PricePerGallonLabel.Location = new System.Drawing.Point(22, 65);
            this.PricePerGallonLabel.Name = "PricePerGallonLabel";
            this.PricePerGallonLabel.Size = new System.Drawing.Size(135, 15);
            this.PricePerGallonLabel.TabIndex = 1;
            this.PricePerGallonLabel.Text = "Cost of Paint per Gallon";
            // 
            // SquareFeetTextBox
            // 
            this.SquareFeetTextBox.Location = new System.Drawing.Point(175, 28);
            this.SquareFeetTextBox.Name = "SquareFeetTextBox";
            this.SquareFeetTextBox.Size = new System.Drawing.Size(100, 20);
            this.SquareFeetTextBox.TabIndex = 2;
            this.SquareFeetTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CostPerGallonTextBox
            // 
            this.CostPerGallonTextBox.Location = new System.Drawing.Point(175, 65);
            this.CostPerGallonTextBox.Name = "CostPerGallonTextBox";
            this.CostPerGallonTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostPerGallonTextBox.TabIndex = 3;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(112, 108);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 4;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SquareFeetLabel);
            this.groupBox1.Controls.Add(this.CalcButton);
            this.groupBox1.Controls.Add(this.PricePerGallonLabel);
            this.groupBox1.Controls.Add(this.CostPerGallonTextBox);
            this.groupBox1.Controls.Add(this.SquareFeetTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 170);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paint Inupts";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NumGallonsLabel
            // 
            this.NumGallonsLabel.AutoSize = true;
            this.NumGallonsLabel.Location = new System.Drawing.Point(34, 28);
            this.NumGallonsLabel.Name = "NumGallonsLabel";
            this.NumGallonsLabel.Size = new System.Drawing.Size(126, 15);
            this.NumGallonsLabel.TabIndex = 6;
            this.NumGallonsLabel.Text = "Num Gallons Needed";
            // 
            // NumGallonsTB
            // 
            this.NumGallonsTB.Location = new System.Drawing.Point(196, 28);
            this.NumGallonsTB.Name = "NumGallonsTB";
            this.NumGallonsTB.Size = new System.Drawing.Size(100, 20);
            this.NumGallonsTB.TabIndex = 7;
            // 
            // LaborHoursLabel
            // 
            this.LaborHoursLabel.AutoSize = true;
            this.LaborHoursLabel.Location = new System.Drawing.Point(34, 56);
            this.LaborHoursLabel.Name = "LaborHoursLabel";
            this.LaborHoursLabel.Size = new System.Drawing.Size(135, 15);
            this.LaborHoursLabel.TabIndex = 8;
            this.LaborHoursLabel.Text = "Hours of Labor Needed";
            // 
            // PaintCostLabel
            // 
            this.PaintCostLabel.AutoSize = true;
            this.PaintCostLabel.Location = new System.Drawing.Point(34, 85);
            this.PaintCostLabel.Name = "PaintCostLabel";
            this.PaintCostLabel.Size = new System.Drawing.Size(80, 15);
            this.PaintCostLabel.TabIndex = 9;
            this.PaintCostLabel.Text = "Paint Cost ($)";
            // 
            // LaborCostLabel
            // 
            this.LaborCostLabel.AutoSize = true;
            this.LaborCostLabel.Location = new System.Drawing.Point(34, 111);
            this.LaborCostLabel.Name = "LaborCostLabel";
            this.LaborCostLabel.Size = new System.Drawing.Size(84, 15);
            this.LaborCostLabel.TabIndex = 10;
            this.LaborCostLabel.Text = "Labor Cost ($)";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(34, 135);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(79, 15);
            this.TotalCostLabel.TabIndex = 11;
            this.TotalCostLabel.Text = "Total Cost ($)";
            // 
            // TotalCostTB
            // 
            this.TotalCostTB.Location = new System.Drawing.Point(196, 135);
            this.TotalCostTB.Name = "TotalCostTB";
            this.TotalCostTB.Size = new System.Drawing.Size(100, 20);
            this.TotalCostTB.TabIndex = 12;
            // 
            // LaborCostTB
            // 
            this.LaborCostTB.Location = new System.Drawing.Point(196, 108);
            this.LaborCostTB.Name = "LaborCostTB";
            this.LaborCostTB.Size = new System.Drawing.Size(100, 20);
            this.LaborCostTB.TabIndex = 13;
            // 
            // PaintCostTB
            // 
            this.PaintCostTB.Location = new System.Drawing.Point(196, 82);
            this.PaintCostTB.Name = "PaintCostTB";
            this.PaintCostTB.Size = new System.Drawing.Size(100, 20);
            this.PaintCostTB.TabIndex = 14;
            // 
            // LaborHoursTB
            // 
            this.LaborHoursTB.Location = new System.Drawing.Point(196, 56);
            this.LaborHoursTB.Name = "LaborHoursTB";
            this.LaborHoursTB.Size = new System.Drawing.Size(100, 20);
            this.LaborHoursTB.TabIndex = 15;
            this.LaborHoursTB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumGallonsLabel);
            this.groupBox2.Controls.Add(this.LaborHoursTB);
            this.groupBox2.Controls.Add(this.NumGallonsTB);
            this.groupBox2.Controls.Add(this.PaintCostTB);
            this.groupBox2.Controls.Add(this.LaborHoursLabel);
            this.groupBox2.Controls.Add(this.LaborCostTB);
            this.groupBox2.Controls.Add(this.PaintCostLabel);
            this.groupBox2.Controls.Add(this.TotalCostTB);
            this.groupBox2.Controls.Add(this.LaborCostLabel);
            this.groupBox2.Controls.Add(this.TotalCostLabel);
            this.groupBox2.Location = new System.Drawing.Point(314, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 170);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paint Outputs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 201);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SquareFeetLabel;
        private System.Windows.Forms.Label PricePerGallonLabel;
        private System.Windows.Forms.TextBox SquareFeetTextBox;
        private System.Windows.Forms.TextBox CostPerGallonTextBox;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NumGallonsLabel;
        private System.Windows.Forms.TextBox NumGallonsTB;
        private System.Windows.Forms.Label LaborHoursLabel;
        private System.Windows.Forms.Label PaintCostLabel;
        private System.Windows.Forms.Label LaborCostLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.TextBox TotalCostTB;
        private System.Windows.Forms.TextBox LaborCostTB;
        private System.Windows.Forms.TextBox PaintCostTB;
        private System.Windows.Forms.TextBox LaborHoursTB;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

