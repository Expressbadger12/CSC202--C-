namespace CatapultLaunchSimulator
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
            lblTarget = new Label();
            lblLaunch = new Label();
            lblResult = new Label();
            btnLaunch = new Button();
            btnNewTarget = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Location = new Point(393, 96);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(60, 25);
            lblTarget.TabIndex = 0;
            lblTarget.Text = "Target";
            // 
            // lblLaunch
            // 
            lblLaunch.AutoSize = true;
            lblLaunch.Location = new Point(391, 167);
            lblLaunch.Name = "lblLaunch";
            lblLaunch.Size = new Size(67, 25);
            lblLaunch.TabIndex = 1;
            lblLaunch.Text = "Launch";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(391, 235);
            lblResult.Name = "lblResult";
            lblResult.RightToLeft = RightToLeft.No;
            lblResult.Size = new Size(59, 25);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result";
            // 
            // btnLaunch
            // 
            btnLaunch.Location = new Point(171, 327);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new Size(112, 34);
            btnLaunch.TabIndex = 3;
            btnLaunch.Text = "Launch";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += btnLaunch_Click;
            // 
            // btnNewTarget
            // 
            btnNewTarget.Location = new Point(365, 327);
            btnNewTarget.Name = "btnNewTarget";
            btnNewTarget.Size = new Size(112, 34);
            btnNewTarget.TabIndex = 4;
            btnNewTarget.Text = "New Target";
            btnNewTarget.UseVisualStyleBackColor = true;
            btnNewTarget.Click += btnNewTarget_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(536, 327);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 5;
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
            Controls.Add(btnNewTarget);
            Controls.Add(btnLaunch);
            Controls.Add(lblResult);
            Controls.Add(lblLaunch);
            Controls.Add(lblTarget);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTarget;
        private Label lblLaunch;
        private Label lblResult;
        private Button btnLaunch;
        private Button btnNewTarget;
        private Button btnClear;
    }
}