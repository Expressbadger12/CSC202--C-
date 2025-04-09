namespace ArrayListFileApp
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
            txtInput = new TextBox();
            lstLines = new ListBox();
            btnAdd = new Button();
            btnLoad = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(224, 107);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(150, 31);
            txtInput.TabIndex = 0;
            // 
            // lstLines
            // 
            lstLines.FormattingEnabled = true;
            lstLines.ItemHeight = 25;
            lstLines.Location = new Point(539, 59);
            lstLines.Name = "lstLines";
            lstLines.Size = new Size(222, 254);
            lstLines.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(117, 283);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(346, 283);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(575, 366);
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
            Controls.Add(btnLoad);
            Controls.Add(btnAdd);
            Controls.Add(lstLines);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private ListBox lstLines;
        private Button btnAdd;
        private Button btnLoad;
        private Button btnClear;
    }
}