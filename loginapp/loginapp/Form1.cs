namespace loginapp
{
    public partial class Form1 : Form
    {
        //Hardcoded credentials
        private string validUsername = "admin";
        private string validPassword = "1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            if (username == validUsername && password == validPassword)
            {
                Form2 dashboard = new Form2(username);
                this.Hide();
                dashboard.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}