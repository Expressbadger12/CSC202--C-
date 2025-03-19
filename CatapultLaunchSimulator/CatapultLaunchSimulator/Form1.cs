using System.Security.AccessControl;

namespace CatapultLaunchSimulator
{
    public partial class Form1 : Form
    {

        private int targetDistance; //stores randomly generated target distance
        private Random random = new Random(); //Random generator
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }
        //function to initialize the game by setting a random target distance
        private void InitializeGame()
        {
            targetDistance = random.Next(50, 150); // Target between 50 and 150 (maybe 151) distance
            lblTarget.Text = $"target Distance: {targetDistance} m";
            btnLaunch.Enabled = true; //Enable launch button
            btnNewTarget.Enabled = true;
            btnLaunch.Enabled = true;
            btnClear.Enabled = false; //Disable clear button until first launch
            lblResult.Text = "Ready to Launch!";
            lblResult.ForeColor = Color.Black;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            int launchDistance = random.Next(40, 160); // Simulated launch distance
            lblLaunch.Text = $"Launch Distance: {launchDistance} m";
            //check if the launch hit the target\
            if (launchDistance == targetDistance)
            {
                lblResult.Text = "Direct Hit! Well Done!";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                int missBy = Math.Abs(launchDistance - targetDistance);// math is a class. abs is absolute value
                lblResult.Text = $"Missed by {missBy} m.";
                lblResult.ForeColor = Color.Red;
            }
            //Enable Clear button after launch
            btnClear.Enabled = true;
        }

        private void btnNewTarget_Click(object sender, EventArgs e)
        {
            InitializeGame(); //Reset with a new target
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblLaunch.Text = "Launch Distance: -- m";
            lblResult.Text = "Ready to Launch";
            lblResult.ForeColor = Color.Black;
            btnClear.Enabled = false; //disable clear button until next launch
        }
    }
}