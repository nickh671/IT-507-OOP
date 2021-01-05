namespace Hertzog_4_4
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
            this.RedButton1 = new System.Windows.Forms.RadioButton();
            this.BlueButton1 = new System.Windows.Forms.RadioButton();
            this.YellowButton1 = new System.Windows.Forms.RadioButton();
            this.RadioGroup1 = new System.Windows.Forms.GroupBox();
            this.RadioGroup2 = new System.Windows.Forms.GroupBox();
            this.RedButton2 = new System.Windows.Forms.RadioButton();
            this.YellowButton2 = new System.Windows.Forms.RadioButton();
            this.BlueButton2 = new System.Windows.Forms.RadioButton();
            this.MixButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RadioGroup1.SuspendLayout();
            this.RadioGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RedButton1
            // 
            this.RedButton1.AutoSize = true;
            this.RedButton1.Location = new System.Drawing.Point(4, 19);
            this.RedButton1.Name = "RedButton1";
            this.RedButton1.Size = new System.Drawing.Size(48, 19);
            this.RedButton1.TabIndex = 0;
            this.RedButton1.TabStop = true;
            this.RedButton1.Text = "Red";
            this.RedButton1.UseVisualStyleBackColor = true;
            this.RedButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // BlueButton1
            // 
            this.BlueButton1.AutoSize = true;
            this.BlueButton1.Location = new System.Drawing.Point(4, 55);
            this.BlueButton1.Name = "BlueButton1";
            this.BlueButton1.Size = new System.Drawing.Size(50, 19);
            this.BlueButton1.TabIndex = 1;
            this.BlueButton1.TabStop = true;
            this.BlueButton1.Text = "Blue";
            this.BlueButton1.UseVisualStyleBackColor = true;
            this.BlueButton1.CheckedChanged += new System.EventHandler(this.BlueButton1_CheckedChanged);
            // 
            // YellowButton1
            // 
            this.YellowButton1.AutoSize = true;
            this.YellowButton1.Location = new System.Drawing.Point(4, 91);
            this.YellowButton1.Name = "YellowButton1";
            this.YellowButton1.Size = new System.Drawing.Size(61, 19);
            this.YellowButton1.TabIndex = 2;
            this.YellowButton1.TabStop = true;
            this.YellowButton1.Text = "Yellow";
            this.YellowButton1.UseVisualStyleBackColor = true;
            this.YellowButton1.CheckedChanged += new System.EventHandler(this.YellowButton1_CheckedChanged);
            // 
            // RadioGroup1
            // 
            this.RadioGroup1.Controls.Add(this.RedButton1);
            this.RadioGroup1.Controls.Add(this.YellowButton1);
            this.RadioGroup1.Controls.Add(this.BlueButton1);
            this.RadioGroup1.Location = new System.Drawing.Point(12, 12);
            this.RadioGroup1.Name = "RadioGroup1";
            this.RadioGroup1.Size = new System.Drawing.Size(149, 144);
            this.RadioGroup1.TabIndex = 3;
            this.RadioGroup1.TabStop = false;
            this.RadioGroup1.Text = "Select the First Color";
            // 
            // RadioGroup2
            // 
            this.RadioGroup2.Controls.Add(this.RedButton2);
            this.RadioGroup2.Controls.Add(this.YellowButton2);
            this.RadioGroup2.Controls.Add(this.BlueButton2);
            this.RadioGroup2.Location = new System.Drawing.Point(191, 12);
            this.RadioGroup2.Name = "RadioGroup2";
            this.RadioGroup2.Size = new System.Drawing.Size(159, 144);
            this.RadioGroup2.TabIndex = 4;
            this.RadioGroup2.TabStop = false;
            this.RadioGroup2.Text = "Select the Second Color";
            // 
            // RedButton2
            // 
            this.RedButton2.AutoSize = true;
            this.RedButton2.Location = new System.Drawing.Point(4, 19);
            this.RedButton2.Name = "RedButton2";
            this.RedButton2.Size = new System.Drawing.Size(48, 19);
            this.RedButton2.TabIndex = 0;
            this.RedButton2.TabStop = true;
            this.RedButton2.Text = "Red";
            this.RedButton2.UseVisualStyleBackColor = true;
            this.RedButton2.CheckedChanged += new System.EventHandler(this.RedButton2_CheckedChanged);
            // 
            // YellowButton2
            // 
            this.YellowButton2.AutoSize = true;
            this.YellowButton2.Location = new System.Drawing.Point(4, 91);
            this.YellowButton2.Name = "YellowButton2";
            this.YellowButton2.Size = new System.Drawing.Size(61, 19);
            this.YellowButton2.TabIndex = 2;
            this.YellowButton2.TabStop = true;
            this.YellowButton2.Text = "Yellow";
            this.YellowButton2.UseVisualStyleBackColor = true;
            this.YellowButton2.CheckedChanged += new System.EventHandler(this.YellowButton2_CheckedChanged);
            // 
            // BlueButton2
            // 
            this.BlueButton2.AutoSize = true;
            this.BlueButton2.Location = new System.Drawing.Point(4, 55);
            this.BlueButton2.Name = "BlueButton2";
            this.BlueButton2.Size = new System.Drawing.Size(50, 19);
            this.BlueButton2.TabIndex = 1;
            this.BlueButton2.TabStop = true;
            this.BlueButton2.Text = "Blue";
            this.BlueButton2.UseVisualStyleBackColor = true;
            this.BlueButton2.CheckedChanged += new System.EventHandler(this.BlueButton2_CheckedChanged);
            // 
            // MixButton
            // 
            this.MixButton.Location = new System.Drawing.Point(86, 178);
            this.MixButton.Name = "MixButton";
            this.MixButton.Size = new System.Drawing.Size(75, 23);
            this.MixButton.TabIndex = 5;
            this.MixButton.Text = "Mix";
            this.MixButton.UseVisualStyleBackColor = true;
            this.MixButton.Click += new System.EventHandler(this.MixButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(191, 178);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 238);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MixButton);
            this.Controls.Add(this.RadioGroup2);
            this.Controls.Add(this.RadioGroup1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.RadioGroup1.ResumeLayout(false);
            this.RadioGroup1.PerformLayout();
            this.RadioGroup2.ResumeLayout(false);
            this.RadioGroup2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RedButton1;
        private System.Windows.Forms.RadioButton BlueButton1;
        private System.Windows.Forms.RadioButton YellowButton1;
        private System.Windows.Forms.GroupBox RadioGroup1;
        private System.Windows.Forms.GroupBox RadioGroup2;
        private System.Windows.Forms.RadioButton RedButton2;
        private System.Windows.Forms.RadioButton YellowButton2;
        private System.Windows.Forms.RadioButton BlueButton2;
        private System.Windows.Forms.Button MixButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

