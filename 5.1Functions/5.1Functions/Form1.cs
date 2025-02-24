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
            //set tags for groups
            txtX.Tag = "Group1"; //group1 = textboxes/text inputs
            txtY.Tag = "Group1";
            txtZ.Tag = "Group1";
            btnCalculate.Tag = "Group2"; //group2 = buttons
            btnClear.Tag = "Group2";
            cmbOperation.Tag = "Group3"; //group3 = combo boxes
            rdoBlueAngle.Tag = "Group4"; // group4 = radio buttons
            rdoRedAngle.Tag = "Group4";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)// foreachloop that returns all GUI elements colors that could have changed back to their default. 
            {
                if (ctrl.Tag != null && ctrl.Tag.ToString() != "Group4")
                {
                    ctrl.BackColor = SystemColors.Window;
                }
                else if (ctrl is RadioButton && ctrl.Tag != null && ctrl.Tag.ToString() == "Group4")
                {
                    ctrl.BackColor = SystemColors.Control;
                }
            }
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
                cmbOperation.BackColor = Color.LightCoral; //makes combo box red if nothing is selected
                solution = 0;
            }

            //checks to see if the triangle is possible (I'm sure there are more reasons a triangle could be impossible, but this will do for now)
            if (x + y <= z || z + y <= x || x + z <= y || y == 0 || x == 0 || z == 0)
            {
                ShowErrorMessage("Triangle Impossible");
                foreach (Control ctrl in this.Controls)// foreachloop that makes every textbox in group1 red when the triangle is impossible
                {
                    if (ctrl is TextBox && ctrl.Tag != null && ctrl.Tag.ToString() == "Group1")
                    {
                        ctrl.BackColor = Color.LightCoral;
                    }
                }
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
                foreach (Control ctrl in this.Controls)// foreachloop that makes every radiobutton in group4 red when the there is no theta
                {
                    if (ctrl is RadioButton && ctrl.Tag != null && ctrl.Tag.ToString() == "Group4")
                    {
                        ctrl.BackColor = Color.LightCoral;
                    }
                }
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
                foreach (Control ctrl in this.Controls)// foreachloop that makes every radiobutton in group4 red when the there is no theta
                {
                    if (ctrl is RadioButton && ctrl.Tag != null && ctrl.Tag.ToString() == "Group4")
                    {
                        ctrl.BackColor = Color.LightCoral;
                    }
                }
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
                foreach (Control ctrl in this.Controls)// foreachloop that makes every radiobutton in group4 red when the there is no theta
                {
                    if (ctrl is RadioButton && ctrl.Tag != null && ctrl.Tag.ToString() == "Group4")
                    {
                        ctrl.BackColor = Color.LightCoral;
                    }
                }
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
            foreach (Control ctrl in this.Controls)// foreachloop that returns all GUI elements colors that could have changed back to their default. 
            {
                if (ctrl.Tag != null && ctrl.Tag.ToString() != "Group4")
                {
                    ctrl.BackColor = SystemColors.Window;
                }
                else if (ctrl is RadioButton && ctrl.Tag != null && ctrl.Tag.ToString() == "Group4")
                {
                    ctrl.BackColor = SystemColors.Control;
                }
            }
        }
    }
}

//Unused code that might come in handy later
//foreach (Control ctrl in this.Controls)// foreachloop that returns all radio buttons back to their default color if there is a value for theta. 
//{
//    if (ctrl is RadioButton && ctrl.Tag != null && ctrl.Tag.ToString() == "Group4")
//    {
//        ctrl.BackColor = SystemColors.Control;
//    }
//}