namespace Guessthenumber
{
    public partial class Form1 : Form
    {
        private int secretNumber; // Store the guess number
        private Random random = new Random(); // Store the random number
        public Form1()
        {
            InitializeComponent();
            btnCheckGuess.Enabled = false;
            lblMessage.Text = string.Empty;
        }
        //Function: Initialize a new game
        private void StartNewGame()
        {
            secretNumber = random.Next(1, 100); // random number between 1-100
            lblMessage.Text = "Guess a number between 1 and 100!";
            lblMessage.ForeColor = System.Drawing.Color.Black;
            txtUserGuess.Text = "";
            btnCheckGuess.Enabled = true; //enable guessing
        }
        private void btnCheckGuess_Click(object sender, EventArgs e)
        {
            int userguess;
            //if statements to handle different situations
            if (!int.TryParse(txtUserGuess.Text, out userguess))
            {
                lblMessage.Text = "Please enter a valid number!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }
            //second if statement
            if (userguess == secretNumber)
            {
                lblMessage.Text = "Correct! You guessed it!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                btnCheckGuess.Enabled = false;
            }
            else if (userguess < secretNumber)
            {
                lblMessage.Text = "Too low! Try again!";
                lblMessage.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                lblMessage.Text = "Too high! Try again";
                lblMessage.ForeColor = System.Drawing.Color.Blue;
            }

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}