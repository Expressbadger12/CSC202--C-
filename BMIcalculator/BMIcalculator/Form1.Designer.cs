namespace BMIcalculator
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
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            comboBoxUnit = new ComboBox();
            lblResult = new Label();
            lblCategory = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            SuspendLayout();
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(233, 103);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 0;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(236, 146);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(350, 229);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(474, 229);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Location = new Point(428, 103);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(121, 23);
            comboBoxUnit.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(137, 237);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(39, 15);
            lblResult.TabIndex = 5;
            lblResult.Text = "Result";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(218, 237);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(63, 15);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Catagories";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(121, 154);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(98, 15);
            lblHeight.TabIndex = 7;
            lblHeight.Text = "Enter your height";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(119, 106);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(100, 15);
            lblWeight.TabIndex = 8;
            lblWeight.Text = "Enter your weight";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWeight);
            Controls.Add(lblHeight);
            Controls.Add(lblCategory);
            Controls.Add(lblResult);
            Controls.Add(comboBoxUnit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWeight;
        private TextBox txtHeight;
        private Button btnCalculate;
        private Button btnClear;
        private ComboBox comboBoxUnit;
        private Label lblResult;
        private Label lblCategory;
        private Label lblHeight;
        private Label lblWeight;
    }
}
