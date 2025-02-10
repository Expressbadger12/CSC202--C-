namespace Temperatureconverterwtfunctions
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
            txtInputTemp = new TextBox();
            txtConvertedTemp = new TextBox();
            btmConvert = new Button();
            btnClear = new Button();
            cbxUnit = new ComboBox();
            lblMessage = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtInputTemp
            // 
            txtInputTemp.Location = new Point(309, 66);
            txtInputTemp.Name = "txtInputTemp";
            txtInputTemp.Size = new Size(150, 31);
            txtInputTemp.TabIndex = 0;
            // 
            // txtConvertedTemp
            // 
            txtConvertedTemp.Location = new Point(309, 149);
            txtConvertedTemp.Name = "txtConvertedTemp";
            txtConvertedTemp.Size = new Size(150, 31);
            txtConvertedTemp.TabIndex = 1;
            // 
            // btmConvert
            // 
            btmConvert.Location = new Point(242, 278);
            btmConvert.Name = "btmConvert";
            btmConvert.Size = new Size(112, 34);
            btmConvert.TabIndex = 2;
            btmConvert.Text = "Convert";
            btmConvert.UseVisualStyleBackColor = true;
            btmConvert.Click += btmConvert_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(420, 278);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cbxUnit
            // 
            cbxUnit.FormattingEnabled = true;
            cbxUnit.Location = new Point(555, 116);
            cbxUnit.Name = "cbxUnit";
            cbxUnit.Size = new Size(182, 33);
            cbxUnit.TabIndex = 4;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(342, 210);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(59, 25);
            lblMessage.TabIndex = 5;
            lblMessage.Text = "Result";
            lblMessage.Click += lblMessage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 72);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 6;
            label1.Text = "Enter Temperature";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblMessage);
            Controls.Add(cbxUnit);
            Controls.Add(btnClear);
            Controls.Add(btmConvert);
            Controls.Add(txtConvertedTemp);
            Controls.Add(txtInputTemp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInputTemp;
        private TextBox txtConvertedTemp;
        private Button btmConvert;
        private Button btnClear;
        private ComboBox cbxUnit;
        private Label lblMessage;
        private Label label1;
    }
}