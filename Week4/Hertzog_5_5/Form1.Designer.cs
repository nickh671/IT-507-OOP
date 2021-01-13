namespace Hertzog_5_5
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
            this.daysLabel = new System.Windows.Forms.Label();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.penniesLabel = new System.Windows.Forms.Label();
            this.penniesTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(12, 37);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(37, 15);
            this.daysLabel.TabIndex = 0;
            this.daysLabel.Text = "Days:";
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(84, 37);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 20);
            this.daysTextBox.TabIndex = 1;
            // 
            // penniesLabel
            // 
            this.penniesLabel.AutoSize = true;
            this.penniesLabel.Location = new System.Drawing.Point(12, 81);
            this.penniesLabel.Name = "penniesLabel";
            this.penniesLabel.Size = new System.Drawing.Size(55, 15);
            this.penniesLabel.TabIndex = 2;
            this.penniesLabel.Text = "Pannies:";
            // 
            // penniesTextBox
            // 
            this.penniesTextBox.Location = new System.Drawing.Point(84, 81);
            this.penniesTextBox.Name = "penniesTextBox";
            this.penniesTextBox.ReadOnly = true;
            this.penniesTextBox.Size = new System.Drawing.Size(100, 20);
            this.penniesTextBox.TabIndex = 3;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(97, 120);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 168);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.penniesTextBox);
            this.Controls.Add(this.penniesLabel);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.daysLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.Label penniesLabel;
        private System.Windows.Forms.TextBox penniesTextBox;
        private System.Windows.Forms.Button calcButton;
    }
}

