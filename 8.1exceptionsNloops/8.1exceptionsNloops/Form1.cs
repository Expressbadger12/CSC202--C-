namespace _8._1exceptionsNloops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = "";
            lblResult.ForeColor = System.Drawing.Color.Black;
        }

        private int RollDice(int NumberOfDice, int Type)
        {
            int result = 0;
            Random random = new Random();


            for (int i = 1; i <= NumberOfDice; i++)
            {
                int tooHigh = Type + 1;
                result += random.Next(1, tooHigh);
            }
            return result;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int numD = int.Parse(txtNumberOfDice.Text);
                int Dtype = int.Parse(txtType.Text);
                if (numD < 0 || Dtype < 0)
                {
                    throw new ArgumentOutOfRangeException("Nice try, buddy. Positive numbers only.");
                }
                int answer = RollDice(numD, Dtype);
                lblResult.Text = $"The result of rolling {numD}d{Dtype} is {answer}";
                lblResult.ForeColor = System.Drawing.Color.Green;
            } 
            catch(FormatException) //non-numeric input
            {
                lblResult.Text = "Please enter a valid numeric input!";
                lblResult.ForeColor= System.Drawing.Color.Red;
            }
            catch(ArgumentOutOfRangeException ex) // Negative number
            {
                lblResult.Text = ex.Message;
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblResult.ForeColor = Color.Black;
            txtType.Text = "";
            txtNumberOfDice.Text = "";
        }
    }
}
