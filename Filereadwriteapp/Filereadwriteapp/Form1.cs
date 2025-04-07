namespace Filereadwriteapp
{
    public partial class Form1 : Form
    {
        private string filePath = "sample.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(filePath, txtContent.Text);
                MessageBox.Show("Text Successfully writen to file!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    txtContent.Text = File.ReadAllText(filePath);
                } else
                {
                    MessageBox.Show("File not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error reading file:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}