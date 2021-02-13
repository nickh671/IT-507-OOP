namespace Hertozg_6_5
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
            this.OLGroup = new System.Windows.Forms.GroupBox();
            this.lubeCheckBox = new System.Windows.Forms.CheckBox();
            this.oilCheckBox = new System.Windows.Forms.CheckBox();
            this.flushesGroup = new System.Windows.Forms.GroupBox();
            this.transFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.radFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.mufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.partsLaborGroup = new System.Windows.Forms.GroupBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.laborLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.partsTotalTextBox = new System.Windows.Forms.TextBox();
            this.serviceLaborTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.partLabel = new System.Windows.Forms.Label();
            this.serviceLaborLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calcButton = new System.Windows.Forms.Button();
            this.OLGroup.SuspendLayout();
            this.flushesGroup.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.partsLaborGroup.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OLGroup
            // 
            this.OLGroup.Controls.Add(this.lubeCheckBox);
            this.OLGroup.Controls.Add(this.oilCheckBox);
            this.OLGroup.Location = new System.Drawing.Point(12, 12);
            this.OLGroup.Name = "OLGroup";
            this.OLGroup.Size = new System.Drawing.Size(182, 82);
            this.OLGroup.TabIndex = 0;
            this.OLGroup.TabStop = false;
            this.OLGroup.Text = "Oil and Lube";
            // 
            // lubeCheckBox
            // 
            this.lubeCheckBox.AutoSize = true;
            this.lubeCheckBox.Location = new System.Drawing.Point(6, 44);
            this.lubeCheckBox.Name = "lubeCheckBox";
            this.lubeCheckBox.Size = new System.Drawing.Size(126, 19);
            this.lubeCheckBox.TabIndex = 1;
            this.lubeCheckBox.Text = "Lube Job ($18.00)";
            this.lubeCheckBox.UseVisualStyleBackColor = true;
            // 
            // oilCheckBox
            // 
            this.oilCheckBox.AutoSize = true;
            this.oilCheckBox.Location = new System.Drawing.Point(6, 19);
            this.oilCheckBox.Name = "oilCheckBox";
            this.oilCheckBox.Size = new System.Drawing.Size(136, 19);
            this.oilCheckBox.TabIndex = 0;
            this.oilCheckBox.Text = "Oil Change ($26.00)";
            this.oilCheckBox.UseVisualStyleBackColor = true;
            // 
            // flushesGroup
            // 
            this.flushesGroup.Controls.Add(this.transFlushCheckBox);
            this.flushesGroup.Controls.Add(this.radFlushCheckBox);
            this.flushesGroup.Location = new System.Drawing.Point(209, 12);
            this.flushesGroup.Name = "flushesGroup";
            this.flushesGroup.Size = new System.Drawing.Size(214, 82);
            this.flushesGroup.TabIndex = 1;
            this.flushesGroup.TabStop = false;
            this.flushesGroup.Text = "Flushes";
            // 
            // transFlushCheckBox
            // 
            this.transFlushCheckBox.AutoSize = true;
            this.transFlushCheckBox.Location = new System.Drawing.Point(6, 44);
            this.transFlushCheckBox.Name = "transFlushCheckBox";
            this.transFlushCheckBox.Size = new System.Drawing.Size(182, 19);
            this.transFlushCheckBox.TabIndex = 1;
            this.transFlushCheckBox.Text = "Transmission Flush ($80.00)";
            this.transFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // radFlushCheckBox
            // 
            this.radFlushCheckBox.AutoSize = true;
            this.radFlushCheckBox.Location = new System.Drawing.Point(6, 19);
            this.radFlushCheckBox.Name = "radFlushCheckBox";
            this.radFlushCheckBox.Size = new System.Drawing.Size(155, 19);
            this.radFlushCheckBox.TabIndex = 0;
            this.radFlushCheckBox.Text = "Radiator Flush ($30.00)";
            this.radFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.Controls.Add(this.tireRotationCheckBox);
            this.miscGroupBox.Controls.Add(this.mufflerCheckBox);
            this.miscGroupBox.Controls.Add(this.inspectionCheckBox);
            this.miscGroupBox.Location = new System.Drawing.Point(12, 109);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Size = new System.Drawing.Size(182, 100);
            this.miscGroupBox.TabIndex = 2;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "Misc";
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(6, 69);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(145, 19);
            this.tireRotationCheckBox.TabIndex = 2;
            this.tireRotationCheckBox.Text = "Tire Rotation ($20.00)";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // mufflerCheckBox
            // 
            this.mufflerCheckBox.AutoSize = true;
            this.mufflerCheckBox.Location = new System.Drawing.Point(6, 44);
            this.mufflerCheckBox.Name = "mufflerCheckBox";
            this.mufflerCheckBox.Size = new System.Drawing.Size(169, 19);
            this.mufflerCheckBox.TabIndex = 1;
            this.mufflerCheckBox.Text = "Replace Muffler ($100.00)";
            this.mufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(6, 19);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(131, 19);
            this.inspectionCheckBox.TabIndex = 0;
            this.inspectionCheckBox.Text = "Inspection ($15.00)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // partsLaborGroup
            // 
            this.partsLaborGroup.Controls.Add(this.laborTextBox);
            this.partsLaborGroup.Controls.Add(this.partsTextBox);
            this.partsLaborGroup.Controls.Add(this.laborLabel);
            this.partsLaborGroup.Controls.Add(this.partsLabel);
            this.partsLaborGroup.Location = new System.Drawing.Point(209, 109);
            this.partsLaborGroup.Name = "partsLaborGroup";
            this.partsLaborGroup.Size = new System.Drawing.Size(214, 100);
            this.partsLaborGroup.TabIndex = 3;
            this.partsLaborGroup.TabStop = false;
            this.partsLaborGroup.Text = "Parts and Labor";
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(90, 58);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(100, 20);
            this.laborTextBox.TabIndex = 3;
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(90, 23);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsTextBox.TabIndex = 2;
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(27, 58);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(57, 15);
            this.laborLabel.TabIndex = 1;
            this.laborLabel.Text = "Labor ($)";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(49, 23);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(35, 15);
            this.partsLabel.TabIndex = 0;
            this.partsLabel.Text = "Parts";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.totalTextBox);
            this.summaryGroupBox.Controls.Add(this.taxTextBox);
            this.summaryGroupBox.Controls.Add(this.partsTotalTextBox);
            this.summaryGroupBox.Controls.Add(this.serviceLaborTextBox);
            this.summaryGroupBox.Controls.Add(this.totalLabel);
            this.summaryGroupBox.Controls.Add(this.taxLabel);
            this.summaryGroupBox.Controls.Add(this.partLabel);
            this.summaryGroupBox.Controls.Add(this.serviceLaborLabel);
            this.summaryGroupBox.Location = new System.Drawing.Point(12, 225);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(411, 151);
            this.summaryGroupBox.TabIndex = 4;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(118, 111);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 7;
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(118, 84);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.ReadOnly = true;
            this.taxTextBox.Size = new System.Drawing.Size(100, 20);
            this.taxTextBox.TabIndex = 6;
            // 
            // partsTotalTextBox
            // 
            this.partsTotalTextBox.Location = new System.Drawing.Point(118, 55);
            this.partsTotalTextBox.Name = "partsTotalTextBox";
            this.partsTotalTextBox.ReadOnly = true;
            this.partsTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsTotalTextBox.TabIndex = 5;
            // 
            // serviceLaborTextBox
            // 
            this.serviceLaborTextBox.Location = new System.Drawing.Point(118, 29);
            this.serviceLaborTextBox.Name = "serviceLaborTextBox";
            this.serviceLaborTextBox.ReadOnly = true;
            this.serviceLaborTextBox.Size = new System.Drawing.Size(100, 20);
            this.serviceLaborTextBox.TabIndex = 4;
            this.serviceLaborTextBox.TextChanged += new System.EventHandler(this.serviceLaborTextBox_TextChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(48, 111);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(64, 15);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total Fees";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(30, 84);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(82, 15);
            this.taxLabel.TabIndex = 2;
            this.taxLabel.Text = "Tax (on parts)";
            // 
            // partLabel
            // 
            this.partLabel.AutoSize = true;
            this.partLabel.Location = new System.Drawing.Point(77, 58);
            this.partLabel.Name = "partLabel";
            this.partLabel.Size = new System.Drawing.Size(35, 15);
            this.partLabel.TabIndex = 1;
            this.partLabel.Text = "Parts";
            // 
            // serviceLaborLabel
            // 
            this.serviceLaborLabel.AutoSize = true;
            this.serviceLaborLabel.Location = new System.Drawing.Point(6, 28);
            this.serviceLaborLabel.Name = "serviceLaborLabel";
            this.serviceLaborLabel.Size = new System.Drawing.Size(106, 15);
            this.serviceLaborLabel.TabIndex = 0;
            this.serviceLaborLabel.Text = "Service and Labor";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(274, 384);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(184, 384);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(92, 384);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 419);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.partsLaborGroup);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.flushesGroup);
            this.Controls.Add(this.OLGroup);
            this.Name = "Form1";
            this.Text = "Automotive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OLGroup.ResumeLayout(false);
            this.OLGroup.PerformLayout();
            this.flushesGroup.ResumeLayout(false);
            this.flushesGroup.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.partsLaborGroup.ResumeLayout(false);
            this.partsLaborGroup.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OLGroup;
        private System.Windows.Forms.CheckBox lubeCheckBox;
        private System.Windows.Forms.CheckBox oilCheckBox;
        private System.Windows.Forms.GroupBox flushesGroup;
        private System.Windows.Forms.CheckBox transFlushCheckBox;
        private System.Windows.Forms.CheckBox radFlushCheckBox;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.CheckBox mufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.GroupBox partsLaborGroup;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label partLabel;
        private System.Windows.Forms.Label serviceLaborLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox partsTotalTextBox;
        private System.Windows.Forms.TextBox serviceLaborTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calcButton;
    }
}

