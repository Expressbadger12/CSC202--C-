namespace Temperature_Converter
{
    public partial class Form1 : Form
    {
        //private means I cannot inherit and can't read after the class. More security
        //Double is integer with decimals 
        private double lastConvertedValue;//store last converted number
        private string convertionType = "Celsius to Fahrenheit"; //string is any characters 
        private string appName = "Temperature Converter";
        public Form1()
        {
            InitializeComponent();
            this.Text = appName;//display appName as form title
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            double inputTemperature = double.Parse(TxtInput.Text);//parse makes the text from the TxtInput textbox and makes it a double
            if (convertionType == "Celsius to Fahrenheit")
            {
                lastConvertedValue = (inputTemperature * 9 / 5) + 32; // this converts celsius to fahrenheit
            }
            else
            {
                lastConvertedValue = (inputTemperature - 32) * 5 / 9;
            }
            //display converted value
            txtOutput.Text = lastConvertedValue.ToString("F2");
            LblLastConverted.Text = $"Last Converted: {lastConvertedValue:F2}";

        }

        private void comboBoxConversionTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update conversion type based on combobox selection
            convertionType = comboBoxConversionTypes.SelectedItem.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear input and output text boxes
            TxtInput.Text = "";
            txtOutput.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxConversionTypes.Items.Add("Celsius to Fahrenheit");
            comboBoxConversionTypes.Items.Add("Fahrenheit to Celsius");
            comboBoxConversionTypes.SelectedIndex = 0;
        }
    }
}