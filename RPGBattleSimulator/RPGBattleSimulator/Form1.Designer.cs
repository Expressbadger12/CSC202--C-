namespace RPGBattleSimulator
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
            btnAttack = new Button();
            btnHealth = new Button();
            btnSpell = new Button();
            btnReset = new Button();
            btnQuit = new Button();
            txtYourHealth = new TextBox();
            txtEnemyHealth = new TextBox();
            lblUpdate = new Label();
            lblEnemyHealth = new Label();
            lblYourHealth = new Label();
            lblPlayerUpdate = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(111, 284);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(112, 34);
            btnAttack.TabIndex = 0;
            btnAttack.Text = "Attack";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // btnHealth
            // 
            btnHealth.Location = new Point(278, 284);
            btnHealth.Name = "btnHealth";
            btnHealth.Size = new Size(223, 34);
            btnHealth.TabIndex = 2;
            btnHealth.Text = "Drink Health Portion";
            btnHealth.UseVisualStyleBackColor = true;
            btnHealth.Click += btnHealth_Click;
            // 
            // btnSpell
            // 
            btnSpell.Location = new Point(551, 284);
            btnSpell.Name = "btnSpell";
            btnSpell.Size = new Size(112, 34);
            btnSpell.TabIndex = 3;
            btnSpell.Text = "Spell";
            btnSpell.UseVisualStyleBackColor = true;
            btnSpell.Click += btnSpell_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(155, 363);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(498, 363);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(112, 34);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // txtYourHealth
            // 
            txtYourHealth.BackColor = Color.MediumTurquoise;
            txtYourHealth.Location = new Point(298, 185);
            txtYourHealth.Name = "txtYourHealth";
            txtYourHealth.ReadOnly = true;
            txtYourHealth.Size = new Size(150, 31);
            txtYourHealth.TabIndex = 6;
            txtYourHealth.Text = "100";
            // 
            // txtEnemyHealth
            // 
            txtEnemyHealth.BackColor = Color.Salmon;
            txtEnemyHealth.Location = new Point(298, 109);
            txtEnemyHealth.Name = "txtEnemyHealth";
            txtEnemyHealth.ReadOnly = true;
            txtEnemyHealth.Size = new Size(150, 31);
            txtEnemyHealth.TabIndex = 7;
            txtEnemyHealth.Text = "100";
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Location = new Point(278, 18);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(189, 25);
            lblUpdate.TabIndex = 8;
            lblUpdate.Text = "A bandit has attacked!";
            // 
            // lblEnemyHealth
            // 
            lblEnemyHealth.AutoSize = true;
            lblEnemyHealth.Location = new Point(155, 115);
            lblEnemyHealth.Name = "lblEnemyHealth";
            lblEnemyHealth.Size = new Size(125, 25);
            lblEnemyHealth.TabIndex = 9;
            lblEnemyHealth.Text = "Enemy Health:";
            // 
            // lblYourHealth
            // 
            lblYourHealth.AutoSize = true;
            lblYourHealth.Location = new Point(155, 188);
            lblYourHealth.Name = "lblYourHealth";
            lblYourHealth.Size = new Size(107, 25);
            lblYourHealth.TabIndex = 10;
            lblYourHealth.Text = "Your Health:";
            // 
            // lblPlayerUpdate
            // 
            lblPlayerUpdate.AutoSize = true;
            lblPlayerUpdate.Location = new Point(278, 57);
            lblPlayerUpdate.Name = "lblPlayerUpdate";
            lblPlayerUpdate.Size = new Size(0, 25);
            lblPlayerUpdate.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(523, 96);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 12;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblPlayerUpdate);
            Controls.Add(lblYourHealth);
            Controls.Add(lblEnemyHealth);
            Controls.Add(lblUpdate);
            Controls.Add(txtEnemyHealth);
            Controls.Add(txtYourHealth);
            Controls.Add(btnQuit);
            Controls.Add(btnReset);
            Controls.Add(btnSpell);
            Controls.Add(btnHealth);
            Controls.Add(btnAttack);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAttack;
        private Button btnHealth;
        private Button btnSpell;
        private Button btnReset;
        private Button btnQuit;
        private TextBox txtYourHealth;
        private TextBox txtEnemyHealth;
        private Label lblUpdate;
        private Label lblEnemyHealth;
        private Label lblYourHealth;
        private Label lblPlayerUpdate;
        private Label label1;
    }
}
