namespace _8._1exceptionsNloops
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
            btnCalculate = new Button();
            lblResult = new Label();
            btnClear = new Button();
            txtNumberOfDice = new TextBox();
            txtType = new TextBox();
            lblTitle = new Label();
            lblD = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(321, 309);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Role";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(344, 250);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 25);
            lblResult.TabIndex = 1;
            lblResult.Text = "label1";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(321, 366);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtNumberOfDice
            // 
            txtNumberOfDice.Location = new Point(207, 188);
            txtNumberOfDice.Name = "txtNumberOfDice";
            txtNumberOfDice.Size = new Size(150, 31);
            txtNumberOfDice.TabIndex = 3;
            // 
            // txtType
            // 
            txtType.Location = new Point(392, 188);
            txtType.Name = "txtType";
            txtType.Size = new Size(150, 31);
            txtType.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(168, 83);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(410, 25);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Enter the number and type of dice you wish to roll";
            // 
            // lblD
            // 
            lblD.AutoSize = true;
            lblD.Location = new Point(362, 193);
            lblD.Name = "lblD";
            lblD.Size = new Size(25, 25);
            lblD.TabIndex = 6;
            lblD.Text = "D";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblD);
            Controls.Add(lblTitle);
            Controls.Add(txtType);
            Controls.Add(txtNumberOfDice);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Dice roller";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label lblResult;
        private Button btnClear;
        private TextBox txtNumberOfDice;
        private TextBox txtType;
        private Label lblTitle;
        private Label lblD;
    }
}
