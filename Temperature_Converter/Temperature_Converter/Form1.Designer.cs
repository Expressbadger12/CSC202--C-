namespace Temperature_Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtInput = new TextBox();
            txtOutput = new TextBox();
            btnconvert = new Button();
            btnClear = new Button();
            comboBoxConversionTypes = new ComboBox();
            LblLastConverted = new Label();
            SuspendLayout();
            // 
            // TxtInput
            // 
            TxtInput.Location = new Point(316, 118);
            TxtInput.Name = "TxtInput";
            TxtInput.Size = new Size(150, 31);
            TxtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(316, 223);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(150, 31);
            txtOutput.TabIndex = 1;
            // 
            // btnconvert
            // 
            btnconvert.Location = new Point(334, 167);
            btnconvert.Name = "btnconvert";
            btnconvert.Size = new Size(112, 34);
            btnconvert.TabIndex = 2;
            btnconvert.Text = "Convert";
            btnconvert.UseVisualStyleBackColor = true;
            btnconvert.Click += btnconvert_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(316, 341);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 34);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // comboBoxConversionTypes
            // 
            comboBoxConversionTypes.FormattingEnabled = true;
            comboBoxConversionTypes.Location = new Point(86, 171);
            comboBoxConversionTypes.Name = "comboBoxConversionTypes";
            comboBoxConversionTypes.Size = new Size(182, 33);
            comboBoxConversionTypes.TabIndex = 4;
            comboBoxConversionTypes.SelectedIndexChanged += comboBoxConversionTypes_SelectedIndexChanged;
            // 
            // LblLastConverted
            // 
            LblLastConverted.AutoSize = true;
            LblLastConverted.Location = new Point(360, 402);
            LblLastConverted.Name = "LblLastConverted";
            LblLastConverted.Size = new Size(41, 25);
            LblLastConverted.TabIndex = 5;
            LblLastConverted.Text = "o_o";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblLastConverted);
            Controls.Add(comboBoxConversionTypes);
            Controls.Add(btnClear);
            Controls.Add(btnconvert);
            Controls.Add(txtOutput);
            Controls.Add(TxtInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtInput;
        private TextBox txtOutput;
        private Button btnconvert;
        private Button btnClear;
        private ComboBox comboBoxConversionTypes;
        private Label LblLastConverted;
    }
}