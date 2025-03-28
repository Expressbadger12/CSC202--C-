namespace Arrays
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
            btnAddSub = new Button();
            cbxSelectProduct = new ComboBox();
            cbxCart = new ComboBox();
            lblselected = new Label();
            lblSelect = new Label();
            lblCart = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // btnAddSub
            // 
            btnAddSub.Location = new Point(367, 312);
            btnAddSub.Name = "btnAddSub";
            btnAddSub.Size = new Size(75, 23);
            btnAddSub.TabIndex = 0;
            btnAddSub.Text = "Add";
            btnAddSub.UseVisualStyleBackColor = true;
            btnAddSub.Click += btnAddSub_Click;
            // 
            // cbxSelectProduct
            // 
            cbxSelectProduct.FormattingEnabled = true;
            cbxSelectProduct.Location = new Point(352, 174);
            cbxSelectProduct.Name = "cbxSelectProduct";
            cbxSelectProduct.Size = new Size(121, 23);
            cbxSelectProduct.TabIndex = 2;
            cbxSelectProduct.SelectedIndexChanged += cbxSelectProduct_SelectedIndexChanged;
            // 
            // cbxCart
            // 
            cbxCart.FormattingEnabled = true;
            cbxCart.Location = new Point(624, 108);
            cbxCart.Name = "cbxCart";
            cbxCart.Size = new Size(121, 23);
            cbxCart.TabIndex = 3;
            // 
            // lblselected
            // 
            lblselected.AutoSize = true;
            lblselected.Location = new Point(395, 261);
            lblselected.Name = "lblselected";
            lblselected.Size = new Size(0, 15);
            lblselected.TabIndex = 4;
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Location = new Point(297, 141);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(249, 15);
            lblSelect.TabIndex = 5;
            lblSelect.Text = "Select product to add or remove from the cart";
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.Location = new Point(664, 75);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(29, 15);
            lblCart.TabIndex = 6;
            lblCart.Text = "Cart";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(662, 277);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(31, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(lblCart);
            Controls.Add(lblSelect);
            Controls.Add(lblselected);
            Controls.Add(cbxCart);
            Controls.Add(cbxSelectProduct);
            Controls.Add(btnAddSub);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddSub;
        private ComboBox cbxSelectProduct;
        private ComboBox cbxCart;
        private Label lblselected;
        private Label lblSelect;
        private Label lblCart;
        private Label lblTotal;
    }
}
