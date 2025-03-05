namespace factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = "Enter a number to calculate its factorial";
        }
        //function 1: calculate factornial using a loop
        private int Calculatefactorial(int number)
        {
            int result = 1; //its a bug will change later // changed it to 1
            for (int i = 1; i <= number; i++)
            {
                result *= i; //result = result multipled by i
            }
            return result;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int userNumber = int.Parse(txtNumber.Text);
                //if statement ensures the number is non-negative
                if (userNumber < 0)
                {
                    throw new ArgumentOutOfRangeException("Factornial is not defined for negative numbers");
                }
                //call factornial function
                int result = Calculatefactorial(userNumber);
                //display result
                lblResult.Text = $"Factorial of {userNumber} is: {result}";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            catch (FormatException) //exception 1: non-numeric input
            {
                lblResult.Text = "Please enter a valid number";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                lblResult.Text = ex.Message;
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Enter a number to calculate its factorial";
            txtNumber.Text = "";
            lblResult.ForeColor = System.Drawing.Color.Black;
        }
    }
}
