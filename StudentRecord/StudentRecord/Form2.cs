using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRecord
{
    public partial class Form2 : Form
    {
        public Student NewStudent { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if(!int.TryParse(txtAge.Text.Trim(), out int age) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter Valid Name and Age");
                return;
            }
            NewStudent = new Student
            {
                Name = name,
                Age = age
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
