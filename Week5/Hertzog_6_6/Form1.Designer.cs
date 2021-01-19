namespace Hertzog_6_6
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
            this.chargesGB = new System.Windows.Forms.GroupBox();
            this.daysLabel = new System.Windows.Forms.Label();
            this.medLabel = new System.Windows.Forms.Label();
            this.surgicalLabel = new System.Windows.Forms.Label();
            this.labLabel = new System.Windows.Forms.Label();
            this.rehabLabel = new System.Windows.Forms.Label();
            this.daysTB = new System.Windows.Forms.TextBox();
            this.medsTB = new System.Windows.Forms.TextBox();
            this.surgicalTB = new System.Windows.Forms.TextBox();
            this.labTB = new System.Windows.Forms.TextBox();
            this.rehabTB = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.chargesGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // chargesGB
            // 
            this.chargesGB.Controls.Add(this.totalTB);
            this.chargesGB.Controls.Add(this.totalLabel);
            this.chargesGB.Controls.Add(this.rehabTB);
            this.chargesGB.Controls.Add(this.labTB);
            this.chargesGB.Controls.Add(this.surgicalTB);
            this.chargesGB.Controls.Add(this.medsTB);
            this.chargesGB.Controls.Add(this.daysTB);
            this.chargesGB.Controls.Add(this.rehabLabel);
            this.chargesGB.Controls.Add(this.labLabel);
            this.chargesGB.Controls.Add(this.surgicalLabel);
            this.chargesGB.Controls.Add(this.medLabel);
            this.chargesGB.Controls.Add(this.daysLabel);
            this.chargesGB.Location = new System.Drawing.Point(0, 0);
            this.chargesGB.Name = "chargesGB";
            this.chargesGB.Size = new System.Drawing.Size(272, 200);
            this.chargesGB.TabIndex = 0;
            this.chargesGB.TabStop = false;
            this.chargesGB.Text = "Charges and Fees";
            this.chargesGB.Enter += new System.EventHandler(this.chargesGB_Enter);
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(8, 30);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(135, 15);
            this.daysLabel.TabIndex = 0;
            this.daysLabel.Text = "Number of Days Stayed";
            // 
            // medLabel
            // 
            this.medLabel.AutoSize = true;
            this.medLabel.Location = new System.Drawing.Point(75, 56);
            this.medLabel.Name = "medLabel";
            this.medLabel.Size = new System.Drawing.Size(68, 15);
            this.medLabel.TabIndex = 1;
            this.medLabel.Text = "Medication";
            // 
            // surgicalLabel
            // 
            this.surgicalLabel.AutoSize = true;
            this.surgicalLabel.Location = new System.Drawing.Point(61, 85);
            this.surgicalLabel.Name = "surgicalLabel";
            this.surgicalLabel.Size = new System.Drawing.Size(82, 15);
            this.surgicalLabel.TabIndex = 2;
            this.surgicalLabel.Text = "Surgical Fees";
            // 
            // labLabel
            // 
            this.labLabel.AutoSize = true;
            this.labLabel.Location = new System.Drawing.Point(85, 112);
            this.labLabel.Name = "labLabel";
            this.labLabel.Size = new System.Drawing.Size(58, 15);
            this.labLabel.TabIndex = 3;
            this.labLabel.Text = "Lab Fees";
            // 
            // rehabLabel
            // 
            this.rehabLabel.AutoSize = true;
            this.rehabLabel.Location = new System.Drawing.Point(12, 138);
            this.rehabLabel.Name = "rehabLabel";
            this.rehabLabel.Size = new System.Drawing.Size(131, 15);
            this.rehabLabel.TabIndex = 4;
            this.rehabLabel.Text = "Physical Rehabilitation";
            // 
            // daysTB
            // 
            this.daysTB.Location = new System.Drawing.Point(166, 33);
            this.daysTB.Name = "daysTB";
            this.daysTB.Size = new System.Drawing.Size(100, 20);
            this.daysTB.TabIndex = 5;
            // 
            // medsTB
            // 
            this.medsTB.Location = new System.Drawing.Point(166, 59);
            this.medsTB.Name = "medsTB";
            this.medsTB.Size = new System.Drawing.Size(100, 20);
            this.medsTB.TabIndex = 6;
            // 
            // surgicalTB
            // 
            this.surgicalTB.Location = new System.Drawing.Point(166, 85);
            this.surgicalTB.Name = "surgicalTB";
            this.surgicalTB.Size = new System.Drawing.Size(100, 20);
            this.surgicalTB.TabIndex = 7;
            // 
            // labTB
            // 
            this.labTB.Location = new System.Drawing.Point(166, 112);
            this.labTB.Name = "labTB";
            this.labTB.Size = new System.Drawing.Size(100, 20);
            this.labTB.TabIndex = 8;
            // 
            // rehabTB
            // 
            this.rehabTB.Location = new System.Drawing.Point(166, 138);
            this.rehabTB.Name = "rehabTB";
            this.rehabTB.Size = new System.Drawing.Size(100, 20);
            this.rehabTB.TabIndex = 9;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(91, 169);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(52, 15);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total ($)";
            // 
            // totalTB
            // 
            this.totalTB.Location = new System.Drawing.Point(166, 169);
            this.totalTB.Name = "totalTB";
            this.totalTB.ReadOnly = true;
            this.totalTB.Size = new System.Drawing.Size(100, 20);
            this.totalTB.TabIndex = 11;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(106, 206);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 234);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.chargesGB);
            this.Name = "Form1";
            this.Text = "Hospital Stay";
            this.chargesGB.ResumeLayout(false);
            this.chargesGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox chargesGB;
        private System.Windows.Forms.TextBox rehabTB;
        private System.Windows.Forms.TextBox labTB;
        private System.Windows.Forms.TextBox surgicalTB;
        private System.Windows.Forms.TextBox medsTB;
        private System.Windows.Forms.TextBox daysTB;
        private System.Windows.Forms.Label rehabLabel;
        private System.Windows.Forms.Label labLabel;
        private System.Windows.Forms.Label surgicalLabel;
        private System.Windows.Forms.Label medLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button calcButton;
    }
}

