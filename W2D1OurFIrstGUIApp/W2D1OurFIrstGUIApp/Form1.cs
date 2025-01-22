namespace W2D1OurFIrstGUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Sign Up Form!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Finishbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for signing up!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}