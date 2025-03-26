namespace GroceryTracker
{
    public partial class Form1 : Form
    {
        //Create two arrays
        private string[] itemNames = new string[10];
        private double[] itemPrices = new double[10];
        private int itemCount = 0; //tracks the number of items added
        public Form1()
        {
            InitializeComponent();
        }

        //Calculate and display the total cost
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (itemCount == 0)
            {
                MessageBox.Show("No items have been added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double totalCost = itemPrices.Take(itemCount).Sum();
            lblTotal.Text = $"total cost: ${totalCost:F2}";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (itemCount >= itemNames.Length)
            {
                MessageBox.Show("Shopping list is full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = txtItemName.Text.Trim();
            if (!double.TryParse(txtItemPrice.Text, out double price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price (greater than 0)", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Store data in arrays
            itemNames[itemCount] = name;
            itemPrices[itemCount] = price;
            itemCount++;
            //Update Listbox
            lstItems.Items.Add($"{name} - ${price:F2}");
            //Clear input fields
            txtItemName.Clear();
            txtItemPrice.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstItems.Items.Clear();
            lblTotal.Text = "";
            //Need to clear arrays
            Array.Clear(itemNames, 0, itemNames.Length);
            Array.Clear(itemPrices, 0, itemPrices.Length);
            itemCount = 0;
        }
    }
}