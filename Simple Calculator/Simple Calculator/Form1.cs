namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close this window?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            //Read input from the textboxes
            double number1 = double.Parse(FirstNumber_Textbox.Text);//double is datatype for a number with decimle
            double number2 = double.Parse(SecondNumber_Textbox.Text);//parse makes it a double even if theres letters

            //preform addition
            double result = number1 + number2;

            //display the result in the third textbox
            Result_Textbox.Text = result.ToString();
        }
    }
}