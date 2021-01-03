namespace Hertzog_2_6
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Betelgeuse_Label = new System.Windows.Forms.Label();
            this.Meissa_Label = new System.Windows.Forms.Label();
            this.Alnilam_Label = new System.Windows.Forms.Label();
            this.Mintaka_Label = new System.Windows.Forms.Label();
            this.Alnitak_Label = new System.Windows.Forms.Label();
            this.Saiph_Label = new System.Windows.Forms.Label();
            this.Rigel_Label = new System.Windows.Forms.Label();
            this.Show_Star_Button = new System.Windows.Forms.Button();
            this.Hide_Star_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hertzog_2_6.Properties.Resources.Orion;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 468);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Betelgeuse_Label
            // 
            this.Betelgeuse_Label.AutoSize = true;
            this.Betelgeuse_Label.Location = new System.Drawing.Point(54, 30);
            this.Betelgeuse_Label.Name = "Betelgeuse_Label";
            this.Betelgeuse_Label.Size = new System.Drawing.Size(69, 15);
            this.Betelgeuse_Label.TabIndex = 1;
            this.Betelgeuse_Label.Text = "Betelgeuse";
            this.Betelgeuse_Label.Visible = false;
            this.Betelgeuse_Label.Click += new System.EventHandler(this.Betelgeuse_Label_Click);
            // 
            // Meissa_Label
            // 
            this.Meissa_Label.AutoSize = true;
            this.Meissa_Label.Location = new System.Drawing.Point(257, 65);
            this.Meissa_Label.Name = "Meissa_Label";
            this.Meissa_Label.Size = new System.Drawing.Size(47, 15);
            this.Meissa_Label.TabIndex = 2;
            this.Meissa_Label.Text = "Meissa";
            this.Meissa_Label.Visible = false;
            // 
            // Alnilam_Label
            // 
            this.Alnilam_Label.AutoSize = true;
            this.Alnilam_Label.Location = new System.Drawing.Point(162, 241);
            this.Alnilam_Label.Name = "Alnilam_Label";
            this.Alnilam_Label.Size = new System.Drawing.Size(48, 15);
            this.Alnilam_Label.TabIndex = 3;
            this.Alnilam_Label.Text = "Alnilam";
            this.Alnilam_Label.Visible = false;
            // 
            // Mintaka_Label
            // 
            this.Mintaka_Label.AutoSize = true;
            this.Mintaka_Label.Location = new System.Drawing.Point(238, 198);
            this.Mintaka_Label.Name = "Mintaka_Label";
            this.Mintaka_Label.Size = new System.Drawing.Size(51, 15);
            this.Mintaka_Label.TabIndex = 4;
            this.Mintaka_Label.Text = "Mintaka";
            this.Mintaka_Label.Visible = false;
            // 
            // Alnitak_Label
            // 
            this.Alnitak_Label.AutoSize = true;
            this.Alnitak_Label.Location = new System.Drawing.Point(71, 232);
            this.Alnitak_Label.Name = "Alnitak_Label";
            this.Alnitak_Label.Size = new System.Drawing.Size(43, 15);
            this.Alnitak_Label.TabIndex = 5;
            this.Alnitak_Label.Text = "Alnitak";
            this.Alnitak_Label.Visible = false;
            // 
            // Saiph_Label
            // 
            this.Saiph_Label.AutoSize = true;
            this.Saiph_Label.Location = new System.Drawing.Point(73, 391);
            this.Saiph_Label.Name = "Saiph_Label";
            this.Saiph_Label.Size = new System.Drawing.Size(39, 15);
            this.Saiph_Label.TabIndex = 6;
            this.Saiph_Label.Text = "Saiph";
            this.Saiph_Label.Visible = false;
            // 
            // Rigel_Label
            // 
            this.Rigel_Label.AutoSize = true;
            this.Rigel_Label.Location = new System.Drawing.Point(263, 361);
            this.Rigel_Label.Name = "Rigel_Label";
            this.Rigel_Label.Size = new System.Drawing.Size(36, 15);
            this.Rigel_Label.TabIndex = 7;
            this.Rigel_Label.Text = "Rigel";
            this.Rigel_Label.Visible = false;
            // 
            // Show_Star_Button
            // 
            this.Show_Star_Button.Location = new System.Drawing.Point(12, 478);
            this.Show_Star_Button.Name = "Show_Star_Button";
            this.Show_Star_Button.Size = new System.Drawing.Size(102, 46);
            this.Show_Star_Button.TabIndex = 8;
            this.Show_Star_Button.Text = "Show Star Names";
            this.Show_Star_Button.UseVisualStyleBackColor = true;
            this.Show_Star_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hide_Star_Button
            // 
            this.Hide_Star_Button.Location = new System.Drawing.Point(145, 478);
            this.Hide_Star_Button.Name = "Hide_Star_Button";
            this.Hide_Star_Button.Size = new System.Drawing.Size(104, 46);
            this.Hide_Star_Button.TabIndex = 9;
            this.Hide_Star_Button.Text = "Hide Star Names";
            this.Hide_Star_Button.UseVisualStyleBackColor = true;
            this.Hide_Star_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(288, 478);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(102, 46);
            this.Exit_Button.TabIndex = 11;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 536);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Hide_Star_Button);
            this.Controls.Add(this.Show_Star_Button);
            this.Controls.Add(this.Rigel_Label);
            this.Controls.Add(this.Saiph_Label);
            this.Controls.Add(this.Alnitak_Label);
            this.Controls.Add(this.Mintaka_Label);
            this.Controls.Add(this.Alnilam_Label);
            this.Controls.Add(this.Meissa_Label);
            this.Controls.Add(this.Betelgeuse_Label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Betelgeuse_Label;
        private System.Windows.Forms.Label Meissa_Label;
        private System.Windows.Forms.Label Alnilam_Label;
        private System.Windows.Forms.Label Mintaka_Label;
        private System.Windows.Forms.Label Alnitak_Label;
        private System.Windows.Forms.Label Saiph_Label;
        private System.Windows.Forms.Label Rigel_Label;
        private System.Windows.Forms.Button Show_Star_Button;
        private System.Windows.Forms.Button Hide_Star_Button;
        private System.Windows.Forms.Button Exit_Button;
    }
}

