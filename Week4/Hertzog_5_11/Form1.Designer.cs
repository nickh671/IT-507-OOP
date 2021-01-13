namespace Hertzog_5_11
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
            this.numberTB = new System.Windows.Forms.TextBox();
            this.guessesLabel = new System.Windows.Forms.Label();
            this.guessesTB = new System.Windows.Forms.TextBox();
            this.highLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a Number (1-100):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numberTB
            // 
            this.numberTB.Location = new System.Drawing.Point(159, 37);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(100, 20);
            this.numberTB.TabIndex = 1;
            // 
            // guessesLabel
            // 
            this.guessesLabel.AutoSize = true;
            this.guessesLabel.Location = new System.Drawing.Point(12, 80);
            this.guessesLabel.Name = "guessesLabel";
            this.guessesLabel.Size = new System.Drawing.Size(119, 15);
            this.guessesLabel.TabIndex = 2;
            this.guessesLabel.Text = "Number of Guesses:";
            // 
            // guessesTB
            // 
            this.guessesTB.Location = new System.Drawing.Point(159, 80);
            this.guessesTB.Name = "guessesTB";
            this.guessesTB.ReadOnly = true;
            this.guessesTB.Size = new System.Drawing.Size(100, 20);
            this.guessesTB.TabIndex = 3;
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Location = new System.Drawing.Point(35, 124);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(60, 15);
            this.highLabel.TabIndex = 4;
            this.highLabel.Text = "Too High!";
            this.highLabel.Visible = false;
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.Location = new System.Drawing.Point(182, 124);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(57, 15);
            this.lowLabel.TabIndex = 5;
            this.lowLabel.Text = "Too Low!";
            this.lowLabel.Visible = false;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(99, 167);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 6;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 259);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.guessesTB);
            this.Controls.Add(this.guessesLabel);
            this.Controls.Add(this.numberTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.Label guessesLabel;
        private System.Windows.Forms.TextBox guessesTB;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Button guessButton;
    }
}

