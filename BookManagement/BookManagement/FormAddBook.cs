using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class FormAddBook : Form
    {
        public Book NewBook { get; private set; }
        public FormAddBook()
        {
            InitializeComponent();
            cmbGenre.Items.AddRange(new string[] { "Fiction", "Nonfiction", "Fantasy", "Science", "Biography" });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string genre = cmbGenre.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || genre == null)
            {
                MessageBox.Show("Please complete all fields!");
                return;
            }
            NewBook = new Book
            {
                Title = title,
                Author = author,
                Genre = genre
            };
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
