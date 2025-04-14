using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginapp
{
    public partial class Form2 : Form
    {
        private string loggedInUser;
        public Form2(string username)
        {
            InitializeComponent();
            loggedInUser = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); //Close THIS form
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {loggedInUser}!";
        }
    }
}
