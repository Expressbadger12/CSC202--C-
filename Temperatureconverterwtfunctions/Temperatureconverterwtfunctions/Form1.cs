namespace Temperatureconverterwtfunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxUnit.Items.Add("Celsius to Fahrenheit");
            cbxUnit.Items.Add("Fahrenheit to Celsius");
            cbxUnit.SelectedIndex = 0;
        }

        private void btmConvert_Click(object sender, EventArgs e)
        {
            double inputTemp = double.Parse(txtInputTemp.Text);
            double convertedTemp;
            string resultUnit;
            //Determine conversion
            if (cbxUnit.SelectedItem.ToString() == "Celsius to Fahrenheit")
            {
                convertedTemp = ConvertCtoF(inputTemp);
                resultUnit = "F";
            }
            else
            {
                convertedTemp = ConvertFtoC(inputTemp);
                resultUnit = "C";
            }
            //display result
            txtConvertedTemp.Text = FormatResult(convertedTemp, resultUnit);
            lblMessage.Text = $"Converted {inputTemp} {cbxUnit.SelectedItem}";
        }
        // function one
        private double ConvertCtoF(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        //function 2
        private double ConvertFtoC(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        //function 3 
        private string FormatResult(double temp, string unit)
        {
            return $"{temp:F2} {unit}";
        }
        //function 4
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputTemp.Text = "";
            txtConvertedTemp.Text = "";
            lblMessage.Text = "Converted Result:";
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}