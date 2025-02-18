namespace _5._1Functions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtX = new TextBox();
            txtY = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            cmbOperation = new ComboBox();
            rdoRedAngle = new RadioButton();
            lblX = new Label();
            lblY = new Label();
            lblZ = new Label();
            pictureBox1 = new PictureBox();
            rdoBlueAngle = new RadioButton();
            txtZ = new TextBox();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtX
            // 
            txtX.Location = new Point(356, 135);
            txtX.Name = "txtX";
            txtX.Size = new Size(100, 23);
            txtX.TabIndex = 0;
            // 
            // txtY
            // 
            txtY.Location = new Point(356, 179);
            txtY.Name = "txtY";
            txtY.Size = new Size(100, 23);
            txtY.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(240, 317);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(474, 317);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cmbOperation
            // 
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Location = new Point(551, 136);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(121, 23);
            cmbOperation.TabIndex = 4;
            // 
            // rdoRedAngle
            // 
            rdoRedAngle.AutoSize = true;
            rdoRedAngle.Location = new Point(79, 224);
            rdoRedAngle.Name = "rdoRedAngle";
            rdoRedAngle.Size = new Size(122, 19);
            rdoRedAngle.TabIndex = 5;
            rdoRedAngle.TabStop = true;
            rdoRedAngle.Text = "Theta = Red Angle";
            rdoRedAngle.UseVisualStyleBackColor = true;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(267, 135);
            lblX.Name = "lblX";
            lblX.Size = new Size(68, 15);
            lblX.TabIndex = 6;
            lblX.Text = "Length of X";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(267, 182);
            lblY.Name = "lblY";
            lblY.Size = new Size(68, 15);
            lblY.TabIndex = 7;
            lblY.Text = "Length of Y";
            // 
            // lblZ
            // 
            lblZ.AutoSize = true;
            lblZ.Location = new Point(267, 228);
            lblZ.Name = "lblZ";
            lblZ.Size = new Size(68, 15);
            lblZ.TabIndex = 8;
            lblZ.Text = "Length of Z";
            lblZ.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // rdoBlueAngle
            // 
            rdoBlueAngle.AutoSize = true;
            rdoBlueAngle.Location = new Point(79, 249);
            rdoBlueAngle.Name = "rdoBlueAngle";
            rdoBlueAngle.Size = new Size(125, 19);
            rdoBlueAngle.TabIndex = 10;
            rdoBlueAngle.TabStop = true;
            rdoBlueAngle.Text = "Theta = Blue Angle";
            rdoBlueAngle.UseVisualStyleBackColor = true;
            // 
            // txtZ
            // 
            txtZ.Location = new Point(356, 224);
            txtZ.Name = "txtZ";
            txtZ.Size = new Size(100, 23);
            txtZ.TabIndex = 11;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(358, 277);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(51, 15);
            lblResult.TabIndex = 12;
            lblResult.Text = "Solution";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(txtZ);
            Controls.Add(rdoBlueAngle);
            Controls.Add(pictureBox1);
            Controls.Add(lblZ);
            Controls.Add(lblY);
            Controls.Add(lblX);
            Controls.Add(rdoRedAngle);
            Controls.Add(cmbOperation);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Name = "Form1";
            Text = "Simple Trigonometry Calculator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtX;
        private TextBox txtY;
        private Button btnCalculate;
        private Button btnClear;
        private ComboBox cmbOperation;
        private RadioButton rdoRedAngle;
        private Label lblX;
        private Label lblY;
        private Label lblZ;
        private PictureBox pictureBox1;
        private RadioButton rdoBlueAngle;
        private TextBox txtZ;
        private Label lblResult;
    }
}
