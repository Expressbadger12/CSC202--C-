namespace StudentRecord
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
            lbxStudents = new ListBox();
            btnAddStudents = new Button();
            SuspendLayout();
            // 
            // lbxStudents
            // 
            lbxStudents.FormattingEnabled = true;
            lbxStudents.ItemHeight = 25;
            lbxStudents.Location = new Point(351, 68);
            lbxStudents.Name = "lbxStudents";
            lbxStudents.Size = new Size(180, 129);
            lbxStudents.TabIndex = 0;
            // 
            // btnAddStudents
            // 
            btnAddStudents.Location = new Point(281, 304);
            btnAddStudents.Name = "btnAddStudents";
            btnAddStudents.Size = new Size(285, 34);
            btnAddStudents.TabIndex = 1;
            btnAddStudents.Text = "Add Students";
            btnAddStudents.UseVisualStyleBackColor = true;
            btnAddStudents.Click += btnAddStudents_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddStudents);
            Controls.Add(lbxStudents);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbxStudents;
        private Button btnAddStudents;
    }
}