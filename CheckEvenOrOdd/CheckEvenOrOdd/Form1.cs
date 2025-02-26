namespace CheckEvenOrOdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMessage.Text = "Enter a number and check if it is even or odd!";
        }
        //function: check if the number is even or odd
        private string CheckEvenOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }

        private void btnCheckGuess_Click(object sender, EventArgs e)
        {
            int userNumber;
            //if statment 1: validate user input
            if (!int.TryParse(txtUserGuess.Text, out userNumber))
            {
                lblMessage.Text = "Please enter a valid number.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }
            //if statement 2: Determine if even or odd
            string result = CheckEvenOdd(userNumber); //calling the function
            lblMessage.Text = $"the number {userNumber} is {result}";
            lblMessage.ForeColor = (result == "Even") ? System.Drawing.Color.Green : System.Drawing.Color.Blue;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            txtUserGuess.Text = "";
            lblMessage.Text = "Enter a number and check if it is even or odd!";
            lblMessage.ForeColor = System.Drawing.Color.Black;
        }
    }
}