namespace additionfactorialthing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = "Enter two numbers to calculate the sum of all numbers in between them (inclusive)";
        }
        //function to calculate
        private int CalculateSum(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i; //==> sum = sum+1
            }
            return sum;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //get numbers from textbox
                int startNum = int.Parse(txtStart.Text);
                int endNum = int.Parse(txtEnd.Text);
                //If statment
                if (startNum > endNum)
                {
                    throw new ArgumentException("The starting number must be less than or equal to the ending number");
                }
                //calculate teh sum using hte loop from earlier
                int result = CalculateSum(startNum, endNum);
                //display result
                lblResult.Text = $"Sum of all numbers between {startNum} and {endNum} (inclusive) is {result}";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            catch (FormatException) // non-numeric input
            {
                lblResult.Text = "Please enter a valid number!";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
            catch (ArgumentException ex) //invalid input range
            {
                lblResult.Text = ex.Message;
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnd.Text = "";
            txtStart.Text = "";
            lblResult.Text = "Enter two numbers to calculate the sum of all numbers in between them (inclusive)";
            lblResult.ForeColor = System.Drawing.Color.Black;
        }
    }
}
