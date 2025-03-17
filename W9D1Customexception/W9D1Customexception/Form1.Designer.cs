namespace W9D1Customexception
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
            lblBalance = new Label();
            lblMessage = new Label();
            txtAmount = new TextBox();
            btnWithdraw = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(247, 249);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(71, 25);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Balance";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(247, 342);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(82, 25);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Message";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(283, 82);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 31);
            txtAmount.TabIndex = 2;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(248, 160);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(112, 34);
            btnWithdraw.TabIndex = 3;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(429, 166);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnWithdraw);
            Controls.Add(txtAmount);
            Controls.Add(lblMessage);
            Controls.Add(lblBalance);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBalance;
        private Label lblMessage;
        private TextBox txtAmount;
        private Button btnWithdraw;
        private Button btnClear;
    }
}