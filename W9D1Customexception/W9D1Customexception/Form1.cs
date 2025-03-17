

namespace W9D1Customexception
{
    public partial class Form1 : Form
    {
        private decimal accountBalance = 500; //starting balance
        public Form1()
        {
            InitializeComponent();
            UpdateBalanceLabel();
        }

        //funciton to withdraw money
        private void WithdrawMoney(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be greater than zero");
            }
            if (amount > accountBalance)
            {
                throw new InsufficientFundsException("Insufficient funds for this withdraw.");
            }
            accountBalance -= amount; // accountbalance = account balance -amount
        }
        //update the balance label
        private void UpdateBalanceLabel()
        {
            lblBalance.Text = $"Balance: ${accountBalance:F2}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = decimal.Parse(txtAmount.Text);
                WithdrawMoney(amount);
                lblMessage.Text = "Withdrawal successful";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                UpdateBalanceLabel();
            }
            catch (FormatException) //if input is not a valid decimal number
            {
                lblMessage.Text = "Please enter a valid number!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            catch (InsufficientFundsException ex)
            {
                lblMessage.Text = ex.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
                txtAmount.Text = "";
                lblMessage.Text = "";
        }
    }
}
//create custom exception class
public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
    {

    }
}