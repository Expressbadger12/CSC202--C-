namespace Student_score_tracker
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
            cbxStudents = new ComboBox();
            lblAverage = new Label();
            lblScore = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // cbxStudents
            // 
            cbxStudents.FormattingEnabled = true;
            cbxStudents.Location = new Point(292, 49);
            cbxStudents.Name = "cbxStudents";
            cbxStudents.Size = new Size(182, 33);
            cbxStudents.TabIndex = 0;
            cbxStudents.SelectedIndexChanged += cbxStudents_SelectedIndexChanged;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(246, 180);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(77, 25);
            lblAverage.TabIndex = 1;
            lblAverage.Text = "Average";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(460, 180);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(56, 25);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(237, 320);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(308, 34);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate Average";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(lblScore);
            Controls.Add(lblAverage);
            Controls.Add(cbxStudents);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxStudents;
        private Label lblAverage;
        private Label lblScore;
        private Button btnCalculate;
    }
}