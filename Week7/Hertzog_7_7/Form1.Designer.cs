namespace Hertzog_7_7
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leastTB = new System.Windows.Forms.TextBox();
            this.greatestTB = new System.Windows.Forms.TextBox();
            this.avgTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average change in population";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year of greatest increase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year of least increase";
            // 
            // leastTB
            // 
            this.leastTB.Location = new System.Drawing.Point(210, 72);
            this.leastTB.Name = "leastTB";
            this.leastTB.ReadOnly = true;
            this.leastTB.Size = new System.Drawing.Size(100, 20);
            this.leastTB.TabIndex = 3;
            // 
            // greatestTB
            // 
            this.greatestTB.Location = new System.Drawing.Point(210, 39);
            this.greatestTB.Name = "greatestTB";
            this.greatestTB.ReadOnly = true;
            this.greatestTB.Size = new System.Drawing.Size(100, 20);
            this.greatestTB.TabIndex = 4;
            // 
            // avgTB
            // 
            this.avgTB.Location = new System.Drawing.Point(210, 9);
            this.avgTB.Name = "avgTB";
            this.avgTB.ReadOnly = true;
            this.avgTB.Size = new System.Drawing.Size(100, 20);
            this.avgTB.TabIndex = 5;
            this.avgTB.TextChanged += new System.EventHandler(this.avgTB_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 124);
            this.Controls.Add(this.avgTB);
            this.Controls.Add(this.greatestTB);
            this.Controls.Add(this.leastTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox leastTB;
        private System.Windows.Forms.TextBox greatestTB;
        private System.Windows.Forms.TextBox avgTB;
    }
}

