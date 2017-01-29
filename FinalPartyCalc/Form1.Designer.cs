namespace FinalPartyCalc
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.FancycheckBox = new System.Windows.Forms.CheckBox();
            this.HealthycheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.FancyBirthDayCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BirthDayTotalCostTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TooLongLabel = new System.Windows.Forms.Label();
            this.CakeWritingTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NumberOfGuests";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(76, 54);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // FancycheckBox
            // 
            this.FancycheckBox.AutoSize = true;
            this.FancycheckBox.Checked = true;
            this.FancycheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FancycheckBox.Location = new System.Drawing.Point(76, 94);
            this.FancycheckBox.Name = "FancycheckBox";
            this.FancycheckBox.Size = new System.Drawing.Size(112, 17);
            this.FancycheckBox.TabIndex = 2;
            this.FancycheckBox.Text = "FancyDecorations";
            this.FancycheckBox.UseVisualStyleBackColor = true;
            this.FancycheckBox.CheckedChanged += new System.EventHandler(this.FancycheckBox_CheckedChanged);
            // 
            // HealthycheckBox
            // 
            this.HealthycheckBox.AutoSize = true;
            this.HealthycheckBox.Location = new System.Drawing.Point(76, 139);
            this.HealthycheckBox.Name = "HealthycheckBox";
            this.HealthycheckBox.Size = new System.Drawing.Size(92, 17);
            this.HealthycheckBox.TabIndex = 3;
            this.HealthycheckBox.Text = "HealthyDrinks";
            this.HealthycheckBox.UseVisualStyleBackColor = true;
            this.HealthycheckBox.CheckedChanged += new System.EventHandler(this.HealthycheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TotalCost";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(76, 176);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 5;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(140, 18);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(293, 264);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.HealthycheckBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.CostTextBox);
            this.tabPage1.Controls.Add(this.FancycheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(285, 238);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DiinerParty";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CakeWritingTextBox);
            this.tabPage2.Controls.Add(this.TooLongLabel);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.BirthDayTotalCostTextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.FancyBirthDayCheckBox);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(285, 238);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BirthDayParty";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NumberOfGuests";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(86, 60);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // FancyBirthDayCheckBox
            // 
            this.FancyBirthDayCheckBox.AutoSize = true;
            this.FancyBirthDayCheckBox.Checked = true;
            this.FancyBirthDayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FancyBirthDayCheckBox.Location = new System.Drawing.Point(86, 102);
            this.FancyBirthDayCheckBox.Name = "FancyBirthDayCheckBox";
            this.FancyBirthDayCheckBox.Size = new System.Drawing.Size(112, 17);
            this.FancyBirthDayCheckBox.TabIndex = 3;
            this.FancyBirthDayCheckBox.Text = "FancyDecorations";
            this.FancyBirthDayCheckBox.UseVisualStyleBackColor = true;
            this.FancyBirthDayCheckBox.CheckedChanged += new System.EventHandler(this.FancyBirthDayCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "TotalCost";
            // 
            // BirthDayTotalCostTextBox
            // 
            this.BirthDayTotalCostTextBox.Location = new System.Drawing.Point(98, 196);
            this.BirthDayTotalCostTextBox.Name = "BirthDayTotalCostTextBox";
            this.BirthDayTotalCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.BirthDayTotalCostTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "CakeWriting";
            // 
            // TooLongLabel
            // 
            this.TooLongLabel.AutoSize = true;
            this.TooLongLabel.BackColor = System.Drawing.Color.Red;
            this.TooLongLabel.Location = new System.Drawing.Point(146, 140);
            this.TooLongLabel.Name = "TooLongLabel";
            this.TooLongLabel.Size = new System.Drawing.Size(63, 13);
            this.TooLongLabel.TabIndex = 8;
            this.TooLongLabel.Text = "TOO LONG";
            // 
            // CakeWritingTextBox
            // 
            this.CakeWritingTextBox.Location = new System.Drawing.Point(40, 156);
            this.CakeWritingTextBox.Name = "CakeWritingTextBox";
            this.CakeWritingTextBox.Size = new System.Drawing.Size(187, 20);
            this.CakeWritingTextBox.TabIndex = 9;
            this.CakeWritingTextBox.TextChanged += new System.EventHandler(this.CakeWritingTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox FancycheckBox;
        private System.Windows.Forms.CheckBox HealthycheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox CakeWritingTextBox;
        private System.Windows.Forms.Label TooLongLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BirthDayTotalCostTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox FancyBirthDayCheckBox;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
    }
}

