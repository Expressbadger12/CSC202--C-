namespace additionfactorialthing
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
            lblResult = new Label();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            lblStart = new Label();
            lblEnd = new Label();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(190, 280);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 25);
            lblResult.TabIndex = 0;
            lblResult.Text = "label1";
            // 
            // txtStart
            // 
            txtStart.Location = new Point(266, 54);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(150, 31);
            txtStart.TabIndex = 1;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(266, 151);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(150, 31);
            txtEnd.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(176, 357);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(405, 371);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(97, 51);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(143, 25);
            lblStart.TabIndex = 5;
            lblStart.Text = "Starting Number";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(103, 154);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(137, 25);
            lblEnd.TabIndex = 6;
            lblEnd.Text = "Ending Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEnd);
            Controls.Add(lblStart);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private TextBox txtStart;
        private TextBox txtEnd;
        private Button btnCalculate;
        private Button btnClear;
        private Label lblStart;
        private Label lblEnd;
    }
}
