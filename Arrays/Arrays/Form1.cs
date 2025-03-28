namespace Arrays
{
    public partial class Form1 : Form
    {
        //declare arrays (I don't think that most of these need to be 2 dimentional, but i realized it too late)
        string[,] products = new string[2, 5] { { "0", "1", "2", "3", "4" }, { "Milk", "Eggs", "Bread", "Ham", "Apples" } };
        double[,] prices = new double[2, 5] { { 0, 1, 2, 3, 4 }, { 3.99, 40, 5, 9.99, 7 } };
        string[,] cart = new string[2,5];
        int cartsize = 0;
        double total;
        public Form1()
        {
            InitializeComponent();
            LoadProducts();
            lblselected.Text = "";
            total = 0;
            lblTotal.Text = "Total: $0";
            btnAddSub.Text = "Add";
        }

        private void LoadProducts() //Populate the product list combo box using array
        {
            for (int i = 0; i < products.GetLength(1); i++)
            {
                cbxSelectProduct.Items.Add(products[1, i]);
            }
        }

        private void cbxSelectProduct_SelectedIndexChanged(object sender, EventArgs e) //this function changes the label to tell you the price of the selected product (as well as changes the add button to subtract if its already in your cart)
        {
            int IdexNum = cbxSelectProduct.SelectedIndex;

            if (IdexNum >= 0)
            {
                string ProName = products[1, IdexNum];
                double price = prices[1, IdexNum];
                lblselected.Text = $"{ProName} ---- ${price}";
                btnAddSub.Text = "Add";

                int cartIndex = Findproduct(ProName);

                if (cartIndex == -1)
                {
                    btnAddSub.Text = "Add";
                }
                else
                {
                    btnAddSub.Text = "Subtract"; 
                }
            }

        }

        //this function adds the item to the cart combo box if it is not already there and it removes the item from the cart if it is there. It also adds and suubtracts the items price from the total respectivly
        private void btnAddSub_Click(object sender, EventArgs e) // This is super messy because it went through a few iterations and the people on the internet that I asked game many different solutions and it's kind of a frankenstien of a bunch of different stuff but it works
        {
            int IdexNum = cbxSelectProduct.SelectedIndex;
       

            if (IdexNum >= -2) //this is a bad way to do this but it works so it stays
            {
                string ProName = products[1, IdexNum];
                double price = prices[1, IdexNum];
                int cartIndex = Findproduct(ProName);
                
                if (cartIndex == -1)
                {
                    total += price;
                    lblTotal.Text = $"Total: ${total}";
                    cart[0, cartsize] = products[1, IdexNum];
                    cart[1, cartsize] = prices[1, IdexNum].ToString();
                    cartsize++;
                    FattenCart();
                    btnAddSub.Text = "Subtract";
                }
                else
                {
                    RemoveFromCart(cartIndex);
                    total -= price;
                    lblTotal.Text = $"Total: ${total}";
                    btnAddSub.Text = "Add";
                }
            }
        }

        //this function checks to see if the selected product is in the cart
        private int Findproduct(string proName)
        {
            for (int i = 0; i < cartsize; i++)
            {
                if (cart[0, i] == proName)
                {
                    return i;
                }
            }
            return -1;
        }

        //This function removes the selected item from the cart
        private void RemoveFromCart(int Index)
        {
            for (int i = Index; i < cartsize; i++)
            {
                cart[0, i] = cart[0, i + 1];
                cart[1, i] = cart[1, i + 1];
            }

            cart[0, cartsize] = null;
            cart[1, cartsize] = null;
            cartsize--;
            FattenCart() ;
        }

        //this function refreshes the cart combo box to reflect recent changes
        private void FattenCart()
        {
            cbxCart.Items.Clear();
            for (int i = 0; i < cartsize; i++)
            {
                cbxCart.Items.Add($"{cart[0, i]}");
            }
        }
    }
}
