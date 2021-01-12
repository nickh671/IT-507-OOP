namespace Hertzog_4_12
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
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.WorkshopLabel = new System.Windows.Forms.Label();
            this.workshopListBox = new System.Windows.Forms.ListBox();
            this.S = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(12, 44);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(57, 15);
            this.locationLabel.TabIndex = 0;
            this.locationLabel.Text = "Location:";
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.locationListBox.Location = new System.Drawing.Point(75, 44);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(120, 95);
            this.locationListBox.TabIndex = 1;
            // 
            // WorkshopLabel
            // 
            this.WorkshopLabel.AutoSize = true;
            this.WorkshopLabel.Location = new System.Drawing.Point(12, 182);
            this.WorkshopLabel.Name = "WorkshopLabel";
            this.WorkshopLabel.Size = new System.Drawing.Size(65, 15);
            this.WorkshopLabel.TabIndex = 2;
            this.WorkshopLabel.Text = "Workshop:";
            // 
            // workshopListBox
            // 
            this.workshopListBox.FormattingEnabled = true;
            this.workshopListBox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.workshopListBox.Location = new System.Drawing.Point(75, 182);
            this.workshopListBox.Name = "workshopListBox";
            this.workshopListBox.Size = new System.Drawing.Size(120, 95);
            this.workshopListBox.TabIndex = 3;
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(75, 300);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(75, 23);
            this.S.TabIndex = 4;
            this.S.Text = "Register";
            this.S.UseVisualStyleBackColor = true;
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 363);
            this.Controls.Add(this.S);
            this.Controls.Add(this.workshopListBox);
            this.Controls.Add(this.WorkshopLabel);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.locationLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Label WorkshopLabel;
        private System.Windows.Forms.ListBox workshopListBox;
        private System.Windows.Forms.Button S;
    }
}

