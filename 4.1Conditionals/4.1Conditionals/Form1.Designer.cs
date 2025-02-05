namespace _4._1Conditionals
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
            lblPrice = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            txtPrice = new TextBox();
            txtPercentage = new Label();
            txtTip = new TextBox();
            txtTotal = new TextBox();
            lbldollar = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(213, 122);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Price";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(236, 276);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(441, 276);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(339, 122);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 3;
            // 
            // txtPercentage
            // 
            txtPercentage.AutoSize = true;
            txtPercentage.Location = new Point(213, 190);
            txtPercentage.Name = "txtPercentage";
            txtPercentage.Size = new Size(66, 15);
            txtPercentage.TabIndex = 5;
            txtPercentage.Text = "Percentage";
            txtPercentage.Click += label2_Click;
            // 
            // txtTip
            // 
            txtTip.Location = new Point(224, 341);
            txtTip.Name = "txtTip";
            txtTip.ReadOnly = true;
            txtTip.Size = new Size(100, 23);
            txtTip.TabIndex = 9;
            txtTip.Text = "Tip Amount:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(441, 341);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 10;
            txtTotal.Text = "Total";
            // 
            // lbldollar
            // 
            lbldollar.AutoSize = true;
            lbldollar.Location = new Point(320, 125);
            lbldollar.Name = "lbldollar";
            lbldollar.Size = new Size(13, 15);
            lbldollar.TabIndex = 11;
            lbldollar.Text = "$";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(318, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(lbldollar);
            Controls.Add(txtTotal);
            Controls.Add(txtTip);
            Controls.Add(txtPercentage);
            Controls.Add(txtPrice);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblPrice);
            Name = "Form1";
            Text = "Tip Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice;
        private Button btnCalculate;
        private Button btnClear;
        private TextBox txtPrice;
        private Label txtPercentage;
        private TextBox txtTip;
        private TextBox txtTotal;
        private Label lbldollar;
        private ComboBox comboBox1;
    }
}
