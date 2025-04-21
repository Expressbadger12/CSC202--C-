namespace BookManagement
{
    partial class FormAddBook
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
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            cmbGenre = new ComboBox();
            btnSave = new Button();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblGenre = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(286, 128);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(150, 31);
            txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(286, 196);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(150, 31);
            txtAuthor.TabIndex = 1;
            // 
            // cmbGenre
            // 
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(565, 56);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(182, 33);
            cmbGenre.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(305, 335);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(151, 139);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(44, 25);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(156, 204);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(67, 25);
            lblAuthor.TabIndex = 5;
            lblAuthor.Text = "Author";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(448, 55);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(58, 25);
            lblGenre.TabIndex = 6;
            lblGenre.Text = "Genre";
            // 
            // FormAddBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGenre);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Controls.Add(cmbGenre);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Name = "FormAddBook";
            Text = "FormAddBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtAuthor;
        private ComboBox cmbGenre;
        private Button btnSave;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblGenre;
    }
}