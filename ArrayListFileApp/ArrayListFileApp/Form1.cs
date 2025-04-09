using System.Collections;

namespace ArrayListFileApp
{
    public partial class Form1 : Form
    {
        private ArrayList lines = new ArrayList(); //store all the lines
        private string filePath = "data.txt";
        public Form1()
        {
            InitializeComponent();
        }

        //Load lines from fileinto ArrayList and ListBox
        private void btnLoad_Click(object sender, EventArgs e)
        {
            lines.Clear();
            lstLines.Items.Clear();

            if (File.Exists(filePath))
            {
                string[] fileLines = File.ReadAllLines(filePath);
                foreach (string line in fileLines)
                {
                    lines.Add(line);
                    lstLines.Items.Add(line);
                }
                MessageBox.Show("File Loaded.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("File not found! A new one will be created", "Info");
            }
        }
        //add new line to arraylist and file

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newLine = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(newLine))
            {
                MessageBox.Show("Please enter some text.", "Warning");
                return;
            }
            //Add to arraylist
            lines.Add(newLine);
            //add to listbox for display
            lstLines.Items.Add(newLine);
            //append to file
            File.AppendAllText(filePath, newLine + Environment.NewLine);
            txtInput.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lines.Clear();
            lstLines.Items.Clear();
            File.WriteAllText(filePath, String.Empty);
        }
    }
}