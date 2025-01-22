namespace W2D1OurFIrstGUIApp
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
            Welcome = new Button();
            FNlabel = new Label();
            firstnamebox = new TextBox();
            LNlabel = new Label();
            lastnamebox = new TextBox();
            emailbox = new TextBox();
            EmailLabel = new Label();
            StndLabel = new Label();
            Undergradbullet = new RadioButton();
            gradbullet = new RadioButton();
            Finishbutton = new Button();
            cancelbutton = new Button();
            SuspendLayout();
            // 
            // Welcome
            // 
            Welcome.Location = new Point(270, 32);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(185, 63);
            Welcome.TabIndex = 0;
            Welcome.Text = "Welcome";
            Welcome.UseVisualStyleBackColor = true;
            Welcome.Click += Welcome_Click;
            // 
            // FNlabel
            // 
            FNlabel.AutoSize = true;
            FNlabel.Location = new Point(158, 166);
            FNlabel.Name = "FNlabel";
            FNlabel.Size = new Size(97, 25);
            FNlabel.TabIndex = 1;
            FNlabel.Text = "First Name";
            // 
            // firstnamebox
            // 
            firstnamebox.Location = new Point(289, 166);
            firstnamebox.Name = "firstnamebox";
            firstnamebox.Size = new Size(150, 31);
            firstnamebox.TabIndex = 2;
            // 
            // LNlabel
            // 
            LNlabel.AutoSize = true;
            LNlabel.Location = new Point(160, 223);
            LNlabel.Name = "LNlabel";
            LNlabel.Size = new Size(95, 25);
            LNlabel.TabIndex = 3;
            LNlabel.Text = "Last Name";
            LNlabel.Click += label2_Click;
            // 
            // lastnamebox
            // 
            lastnamebox.Location = new Point(289, 223);
            lastnamebox.Name = "lastnamebox";
            lastnamebox.Size = new Size(150, 31);
            lastnamebox.TabIndex = 4;
            // 
            // emailbox
            // 
            emailbox.Location = new Point(289, 293);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(150, 31);
            emailbox.TabIndex = 5;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(175, 293);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(54, 25);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "Email";
            // 
            // StndLabel
            // 
            StndLabel.AutoSize = true;
            StndLabel.Location = new Point(160, 349);
            StndLabel.Name = "StndLabel";
            StndLabel.Size = new Size(77, 25);
            StndLabel.TabIndex = 7;
            StndLabel.Text = "Student:";
            // 
            // Undergradbullet
            // 
            Undergradbullet.AutoSize = true;
            Undergradbullet.Location = new Point(289, 347);
            Undergradbullet.Name = "Undergradbullet";
            Undergradbullet.Size = new Size(122, 29);
            Undergradbullet.TabIndex = 8;
            Undergradbullet.TabStop = true;
            Undergradbullet.Text = "Undergrad";
            Undergradbullet.UseVisualStyleBackColor = true;
            // 
            // gradbullet
            // 
            gradbullet.AutoSize = true;
            gradbullet.Location = new Point(456, 352);
            gradbullet.Name = "gradbullet";
            gradbullet.Size = new Size(75, 29);
            gradbullet.TabIndex = 9;
            gradbullet.TabStop = true;
            gradbullet.Text = "Grad";
            gradbullet.UseVisualStyleBackColor = true;
            // 
            // Finishbutton
            // 
            Finishbutton.Location = new Point(158, 412);
            Finishbutton.Name = "Finishbutton";
            Finishbutton.Size = new Size(183, 34);
            Finishbutton.TabIndex = 10;
            Finishbutton.Text = "Finish Sign Up!";
            Finishbutton.UseVisualStyleBackColor = true;
            Finishbutton.Click += Finishbutton_Click;
            // 
            // cancelbutton
            // 
            cancelbutton.Location = new Point(434, 412);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(112, 34);
            cancelbutton.TabIndex = 11;
            cancelbutton.Text = "Cancel";
            cancelbutton.UseVisualStyleBackColor = true;
            cancelbutton.Click += cancelbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 469);
            Controls.Add(cancelbutton);
            Controls.Add(Finishbutton);
            Controls.Add(gradbullet);
            Controls.Add(Undergradbullet);
            Controls.Add(StndLabel);
            Controls.Add(EmailLabel);
            Controls.Add(emailbox);
            Controls.Add(lastnamebox);
            Controls.Add(LNlabel);
            Controls.Add(firstnamebox);
            Controls.Add(FNlabel);
            Controls.Add(Welcome);
            Name = "Form1";
            Text = "Sign up form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Welcome;
        private Label FNlabel;
        private TextBox firstnamebox;
        private Label LNlabel;
        private TextBox lastnamebox;
        private TextBox emailbox;
        private Label EmailLabel;
        private Label StndLabel;
        private RadioButton Undergradbullet;
        private RadioButton gradbullet;
        private Button Finishbutton;
        private Button cancelbutton;
    }
}