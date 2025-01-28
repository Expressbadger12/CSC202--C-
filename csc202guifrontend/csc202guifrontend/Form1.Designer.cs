namespace csc202guifrontend
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
            this.FSLabel = new System.Windows.Forms.Label();
            this.lslabel = new System.Windows.Forms.Label();
            this.FNBox = new System.Windows.Forms.TextBox();
            this.LNbox = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.submitbutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rolelabel = new System.Windows.Forms.Label();
            this.Agelabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // FSLabel
            // 
            this.FSLabel.AutoSize = true;
            this.FSLabel.Location = new System.Drawing.Point(220, 93);
            this.FSLabel.Name = "FSLabel";
            this.FSLabel.Size = new System.Drawing.Size(58, 14);
            this.FSLabel.TabIndex = 0;
            this.FSLabel.Text = "First Name";
            // 
            // lslabel
            // 
            this.lslabel.AutoSize = true;
            this.lslabel.Location = new System.Drawing.Point(220, 142);
            this.lslabel.Name = "lslabel";
            this.lslabel.Size = new System.Drawing.Size(57, 14);
            this.lslabel.TabIndex = 1;
            this.lslabel.Text = "Last Name";
            // 
            // FNBox
            // 
            this.FNBox.Location = new System.Drawing.Point(343, 93);
            this.FNBox.Name = "FNBox";
            this.FNBox.Size = new System.Drawing.Size(100, 20);
            this.FNBox.TabIndex = 2;
            // 
            // LNbox
            // 
            this.LNbox.Location = new System.Drawing.Point(343, 142);
            this.LNbox.Name = "LNbox";
            this.LNbox.Size = new System.Drawing.Size(100, 20);
            this.LNbox.TabIndex = 3;
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Location = new System.Drawing.Point(223, 201);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(34, 14);
            this.emaillabel.TabIndex = 4;
            this.emaillabel.Text = "Email";
            this.emaillabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(343, 194);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(100, 20);
            this.emailbox.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(460, 197);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(217, 18);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "I would like to receive email notifications";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // submitbutton
            // 
            this.submitbutton.Location = new System.Drawing.Point(223, 374);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(75, 25);
            this.submitbutton.TabIndex = 7;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(460, 374);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(75, 25);
            this.closebutton.TabIndex = 8;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Clown"});
            this.comboBox1.Location = new System.Drawing.Point(343, 292);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 9;
            // 
            // rolelabel
            // 
            this.rolelabel.AutoSize = true;
            this.rolelabel.Location = new System.Drawing.Point(223, 299);
            this.rolelabel.Name = "rolelabel";
            this.rolelabel.Size = new System.Drawing.Size(28, 14);
            this.rolelabel.TabIndex = 10;
            this.rolelabel.Text = "Role";
            // 
            // Agelabel
            // 
            this.Agelabel.AutoSize = true;
            this.Agelabel.Location = new System.Drawing.Point(223, 252);
            this.Agelabel.Name = "Agelabel";
            this.Agelabel.Size = new System.Drawing.Size(25, 14);
            this.Agelabel.TabIndex = 11;
            this.Agelabel.Text = "Age";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(343, 252);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Agelabel);
            this.Controls.Add(this.rolelabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.LNbox);
            this.Controls.Add(this.FNBox);
            this.Controls.Add(this.lslabel);
            this.Controls.Add(this.FSLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FSLabel;
        private System.Windows.Forms.Label lslabel;
        private System.Windows.Forms.TextBox FNBox;
        private System.Windows.Forms.TextBox LNbox;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label rolelabel;
        private System.Windows.Forms.Label Agelabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

