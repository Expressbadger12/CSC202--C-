namespace StudentRecord
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            txtName = new TextBox();
            txtAge = new TextBox();
            lblName = new Label();
            lblAge = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(349, 312);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(349, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(349, 156);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(150, 31);
            txtAge.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(205, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(205, 162);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(44, 25);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtName;
        private TextBox txtAge;
        private Label lblName;
        private Label lblAge;
    }
}