namespace BookManagement
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var addBookForm = new FormAddBook();
            if (addBookForm.ShowDialog() == DialogResult.OK) 
            {
                books.Add(addBookForm.NewBook);
                RefreshBookList();
            }
        }
        private void RefreshBookList()
        {
            lstBooks.Items.Clear();
            foreach (Book book in books)
            {
                lstBooks.Items.Add(book.ToString());
            }
        }
    }
}
