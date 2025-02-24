namespace Guessthenumber
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
            lblMessage = new Label();
            txtUserGuess = new TextBox();
            btnCheckGuess = new Button();
            btnNewGame = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(360, 242);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(59, 25);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "label1";
            lblMessage.Click += lblMessage_Click;
            // 
            // txtUserGuess
            // 
            txtUserGuess.Location = new Point(330, 109);
            txtUserGuess.Name = "txtUserGuess";
            txtUserGuess.Size = new Size(150, 31);
            txtUserGuess.TabIndex = 1;
            // 
            // btnCheckGuess
            // 
            btnCheckGuess.Location = new Point(267, 291);
            btnCheckGuess.Name = "btnCheckGuess";
            btnCheckGuess.RightToLeft = RightToLeft.No;
            btnCheckGuess.Size = new Size(271, 34);
            btnCheckGuess.TabIndex = 2;
            btnCheckGuess.Text = "Check Guess";
            btnCheckGuess.UseVisualStyleBackColor = true;
            btnCheckGuess.Click += btnCheckGuess_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(267, 351);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(271, 34);
            btnNewGame.TabIndex = 3;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNewGame);
            Controls.Add(btnCheckGuess);
            Controls.Add(txtUserGuess);
            Controls.Add(lblMessage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private TextBox txtUserGuess;
        private Button btnCheckGuess;
        private Button btnNewGame;
    }
}