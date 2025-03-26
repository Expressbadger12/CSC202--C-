namespace GroceryTracker
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
            txtItemName = new TextBox();
            txtItemPrice = new TextBox();
            btnAddItem = new Button();
            btnCalculate = new Button();
            lstItems = new ListBox();
            lblTotal = new Label();
            lblName = new Label();
            lblPrice = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(284, 123);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(150, 31);
            txtItemName.TabIndex = 0;
            // 
            // txtItemPrice
            // 
            txtItemPrice.Location = new Point(284, 212);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.Size = new Size(150, 31);
            txtItemPrice.TabIndex = 1;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(307, 278);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(112, 34);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(262, 336);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(202, 34);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate Total";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 25;
            lstItems.Location = new Point(499, 75);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(180, 129);
            lstItems.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(565, 266);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(49, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(140, 123);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 25);
            lblName.TabIndex = 6;
            lblName.Text = "Item Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(141, 222);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(90, 25);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Item Price";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(307, 394);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 8;
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
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(lblTotal);
            Controls.Add(lstItems);
            Controls.Add(btnCalculate);
            Controls.Add(btnAddItem);
            Controls.Add(txtItemPrice);
            Controls.Add(txtItemName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtItemName;
        private TextBox txtItemPrice;
        private Button btnAddItem;
        private Button btnCalculate;
        private ListBox lstItems;
        private Label lblTotal;
        private Label lblName;
        private Label lblPrice;
        private Button btnClear;
    }
}