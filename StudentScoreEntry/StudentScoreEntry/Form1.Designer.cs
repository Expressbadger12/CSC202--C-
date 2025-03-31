namespace StudentScoreEntry
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
            lblAverage = new Label();
            txtStudentName = new TextBox();
            txtStudentScores = new TextBox();
            btnAddStudent = new Button();
            btnCalculateAverage = new Button();
            lstStudents = new ListBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(387, 322);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(59, 25);
            lblAverage.TabIndex = 0;
            lblAverage.Text = "label1";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(331, 90);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(150, 31);
            txtStudentName.TabIndex = 1;
            // 
            // txtStudentScores
            // 
            txtStudentScores.Location = new Point(330, 138);
            txtStudentScores.Name = "txtStudentScores";
            txtStudentScores.Size = new Size(150, 31);
            txtStudentScores.TabIndex = 2;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(192, 228);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(191, 34);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnCalculateAverage
            // 
            btnCalculateAverage.Location = new Point(458, 228);
            btnCalculateAverage.Name = "btnCalculateAverage";
            btnCalculateAverage.Size = new Size(195, 34);
            btnCalculateAverage.TabIndex = 4;
            btnCalculateAverage.Text = "Calculate Average";
            btnCalculateAverage.UseVisualStyleBackColor = true;
            btnCalculateAverage.Click += btnCalculateAverage_Click;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 25;
            lstStudents.Location = new Point(586, 40);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(180, 129);
            lstStudents.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(357, 388);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 6;
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
            Controls.Add(lstStudents);
            Controls.Add(btnCalculateAverage);
            Controls.Add(btnAddStudent);
            Controls.Add(txtStudentScores);
            Controls.Add(txtStudentName);
            Controls.Add(lblAverage);
            Name = "Form1";
            Text = "Student Score Thing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAverage;
        private TextBox txtStudentName;
        private TextBox txtStudentScores;
        private Button btnAddStudent;
        private Button btnCalculateAverage;
        private ListBox lstStudents;
        private Button btnClear;
    }
}