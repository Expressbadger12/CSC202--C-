using System.ComponentModel.Design;
using System.DirectoryServices;

namespace _5._1Functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //populate the cumbo box
            cmbOperation.Items.Add("Sine of Theta");
            cmbOperation.Items.Add("Cosine of Theta");
            cmbOperation.Items.Add("Tangent of Theta");
            cmbOperation.SelectedIndex = 0;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //makes sure that the program doesn't break when a user clicks calculate without entering values for x, y, and z. (0 is default)
            if (txtX.Text == "" || txtY.Text == "" || txtZ.Text == "")
            {
                ShowErrorMessage("Please enter in values for x, y, and z.");
                txtX.Text = "0";
                txtY.Text = "0";
                txtZ.Text = "0";
            }
            double solution;
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            double z = double.Parse(txtZ.Text);

            //detects what triganomic fuction is selected and then calls the corrisponding function (gives error if no function is selected)
            if (cmbOperation.SelectedIndex == 0)
            {
                solution = FindSine(x, y, z);
            }
            else if (cmbOperation.SelectedIndex == 1)
            {
                solution = FindCosine(x, y, z);
            }
            else if (cmbOperation.SelectedIndex == 2)
            {
                solution = FindTangent(x, y);
            }
            else
            {
                ShowErrorMessage("Please select a triganomic function");
                solution = 0;
            }

            //checks to see if the triangle is possible (I'm sure there are more reasons a triangle could be impossible, but this will do for now)
            if (x + y <= z || z + y <= x || x + z <= y || y == 0 || x == 0 || z == 0)
            {
                ShowErrorMessage("Triangle Impossible");
            }

            lblResult.Text = solution.ToString();
        }

        //sine function (function 1)
        private double FindSine(double x, double y, double z)
        {
            if (rdoRedAngle.Checked == true)
            {
                return (y / z);
            }
            else if (rdoBlueAngle.Checked == true)
            {
                return (x / z);
            }
            else
            {
                ShowErrorMessage("Please select a value for Theta");
                return 0;
            }
        }
        
        //cosine function (function 2)
        private double FindCosine(double x, double y, double z)
        {
            if (rdoRedAngle.Checked == true)
            {
                return (x / z);
            }
            else if (rdoBlueAngle.Checked == true)
            {
                return (y / z);
            }
            else
            {
                ShowErrorMessage("Please select a value for Theta");
                return 0;
            }
        }

        //tangent function (function 3)
        private double FindTangent(double x, double y)
        {
            if (rdoRedAngle.Checked == true)
            {
                return (y / x);
            }
            else if (rdoBlueAngle.Checked == true)
            {
                return (x / y);
            }
            else
            {
                ShowErrorMessage("Please select a value for Theta");
                return 0;
            }
        }

        // error message function (function 4)
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //clear button -- resets everything
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtX.Text = "";
            txtY.Text = "";
            txtZ.Text = "";
            cmbOperation.SelectedIndex = 0;
            rdoBlueAngle.Checked = false;
            rdoRedAngle.Checked = false;
            lblResult.Text = "solution";
        }
    }
}
