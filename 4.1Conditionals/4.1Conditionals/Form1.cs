using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace _4._1Conditionals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Tip Calculator";

            comboBox1.Items.Add("10%");
            comboBox1.Items.Add("15%");
            comboBox1.Items.Add("20%");
            comboBox1.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double price, tip, total;
                double percentage;
                percentage = 0;
                price = double.Parse(txtPrice.Text);

                string selectedTip = comboBox1.Text.Trim(); // solution I found on the internet to a problem where the selection of the combo box could be null 

                string cleanedString = Regex.Replace(selectedTip, "%", ""); // research

                double backupcombo;

                bool isNumber = double.TryParse(cleanedString, out backupcombo); // another solution given to me by online researc

                if (selectedTip == "10%")
                {
                    percentage = 0.1;
                }
                else if (selectedTip == "15%")
                {
                    percentage = 0.15;
                }
                else if (selectedTip == "20%")
                {
                    percentage = 0.2;
                }
                else if (isNumber == true)
                {
                    percentage = backupcombo / 100;
                }
                else
                {
                    MessageBox.Show("please enter or select a precentage.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                tip = price * percentage;
                total = tip + price;

                txtTip.Text = $"Tip Amount: ${tip.ToString()}";
                txtTotal.Text = $"Total: ${total.ToString()}";

                if (backupcombo < 0)
                {
                    MessageBox.Show("Nice try, enter a positive number", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTip.Text = "";
                    txtTotal.Text = "";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtTip.Text = "";
            txtTotal.Text = "";
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
