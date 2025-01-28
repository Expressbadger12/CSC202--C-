namespace Simple_Calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            FirstNumber_Textbox = new TextBox();
            SecondNumber_Textbox = new TextBox();
            Result_Textbox = new TextBox();
            Calculate_Button = new Button();
            Close_Button = new Button();
            multiplybutton = new Button();
            subtract = new Button();
            dividebutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 58);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter First Number";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 128);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter Second Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 202);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Result";
            label3.Click += label3_Click;
            // 
            // FirstNumber_Textbox
            // 
            FirstNumber_Textbox.Location = new Point(333, 58);
            FirstNumber_Textbox.Margin = new Padding(3, 2, 3, 2);
            FirstNumber_Textbox.Name = "FirstNumber_Textbox";
            FirstNumber_Textbox.Size = new Size(150, 28);
            FirstNumber_Textbox.TabIndex = 3;
            // 
            // SecondNumber_Textbox
            // 
            SecondNumber_Textbox.Location = new Point(333, 128);
            SecondNumber_Textbox.Margin = new Padding(3, 2, 3, 2);
            SecondNumber_Textbox.Name = "SecondNumber_Textbox";
            SecondNumber_Textbox.Size = new Size(150, 28);
            SecondNumber_Textbox.TabIndex = 4;
            // 
            // Result_Textbox
            // 
            Result_Textbox.BackColor = SystemColors.ActiveBorder;
            Result_Textbox.Location = new Point(333, 202);
            Result_Textbox.Margin = new Padding(3, 2, 3, 2);
            Result_Textbox.Name = "Result_Textbox";
            Result_Textbox.ReadOnly = true;
            Result_Textbox.Size = new Size(150, 28);
            Result_Textbox.TabIndex = 5;
            // 
            // Calculate_Button
            // 
            Calculate_Button.Location = new Point(153, 170);
            Calculate_Button.Margin = new Padding(3, 2, 3, 2);
            Calculate_Button.Name = "Calculate_Button";
            Calculate_Button.Size = new Size(111, 26);
            Calculate_Button.TabIndex = 6;
            Calculate_Button.Text = "Add";
            Calculate_Button.UseVisualStyleBackColor = true;
            Calculate_Button.Click += Calculate_Button_Click;
            // 
            // Close_Button
            // 
            Close_Button.Location = new Point(350, 278);
            Close_Button.Margin = new Padding(3, 2, 3, 2);
            Close_Button.Name = "Close_Button";
            Close_Button.Size = new Size(111, 26);
            Close_Button.TabIndex = 7;
            Close_Button.Text = "Close";
            Close_Button.UseVisualStyleBackColor = true;
            Close_Button.Click += Close_Button_Click;
            // 
            // multiplybutton
            // 
            multiplybutton.Location = new Point(401, 170);
            multiplybutton.Margin = new Padding(3, 2, 3, 2);
            multiplybutton.Name = "multiplybutton";
            multiplybutton.Size = new Size(111, 26);
            multiplybutton.TabIndex = 8;
            multiplybutton.Text = "Multiply";
            multiplybutton.UseVisualStyleBackColor = true;
            multiplybutton.Click += multiplybutton_Click;
            // 
            // subtract
            // 
            subtract.Location = new Point(284, 170);
            subtract.Margin = new Padding(3, 2, 3, 2);
            subtract.Name = "subtract";
            subtract.Size = new Size(111, 26);
            subtract.TabIndex = 9;
            subtract.Text = "Subtract";
            subtract.UseVisualStyleBackColor = true;
            subtract.Click += subtract_Click;
            // 
            // dividebutton
            // 
            dividebutton.Location = new Point(531, 170);
            dividebutton.Margin = new Padding(3, 2, 3, 2);
            dividebutton.Name = "dividebutton";
            dividebutton.Size = new Size(111, 26);
            dividebutton.TabIndex = 10;
            dividebutton.Text = "divide";
            dividebutton.UseVisualStyleBackColor = true;
            dividebutton.Click += dividebutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 360);
            Controls.Add(dividebutton);
            Controls.Add(subtract);
            Controls.Add(multiplybutton);
            Controls.Add(Close_Button);
            Controls.Add(Calculate_Button);
            Controls.Add(Result_Textbox);
            Controls.Add(SecondNumber_Textbox);
            Controls.Add(FirstNumber_Textbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox FirstNumber_Textbox;
        private TextBox SecondNumber_Textbox;
        private TextBox Result_Textbox;
        private Button Calculate_Button;
        private Button Close_Button;
        private Button multiplybutton;
        private Button subtract;
        private Button dividebutton;
    }
}