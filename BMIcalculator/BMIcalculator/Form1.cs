namespace BMIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "BMI Calculator";
            // populate the combo box unit options
            comboBoxUnit.Items.Add("Metric(kg, m)");
            comboBoxUnit.Items.Add("Imperial (lbs, inches)");
            comboBoxUnit.SelectedIndex = 0; // Default selection
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double weight, height, bmi;
                //check unit system and convert input if needed
                if (comboBoxUnit.SelectedIndex.ToString() == "Metric(kg, m)")
                {
                    weight = double.Parse(txtWeight.Text);
                    height = double.Parse(txtHeight.Text);
                }
                else
                {
                    weight = double.Parse(txtWeight.Text) * 0.453592; //converting pounds to kg
                    height = double.Parse(txtHeight.Text) * 0.0254; //converting inches to mt
                }
                if (height <= 0 || weight <= 0)
                {
                    MessageBox.Show("please enter valid positive numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //BMI calculate
                bmi = weight / (height * height);
                lblResult.Text = $"BMI: {bmi:F2}";

                //BMI Category classification
                if (bmi < 18.5)
                {
                    lblCategory.Text = "Category: Underweight";
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    lblCategory.Text = "Catagory: Normal Weight";
                }
                else if (bmi >= 25 && bmi < 29.9)
                {
                    lblCategory.Text = "Catagory: Overweight";
                }
                else
                {
                    lblCategory.Text = "Catagory: Obese";
                }
            } catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWeight.Text = "";
            txtHeight.Text = "";
            lblResult.Text = "BMI:  ";
            lblCategory.Text = "Catagory";
        }
    }
}
