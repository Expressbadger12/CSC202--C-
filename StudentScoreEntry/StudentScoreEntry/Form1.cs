namespace StudentScoreEntry
{
    public partial class Form1 : Form
    {
        private string[] studentNames = new string[10]; //array of strings-fits ten elements
        private int[] studentScorres = new int[10];
        private int studentCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (studentCount >= studentNames.Length)
            {
                MessageBox.Show("student list is full!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = txtStudentName.Text.Trim();
            if (!int.TryParse(txtStudentScores.Text, out int score) || score < 0 || score > 100)
            {
                MessageBox.Show("please enter a valid score )1-100)", "Invalidate input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtStudentName.Text == "")
            {
                MessageBox.Show("Please enter student's name", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //student data in arrays
            studentNames[studentCount] = name;
            studentScorres[studentCount] = score;
            studentCount++;
            //Update the list box
            lstStudents.Items.Add($"{name} -- {score}");
            //clrear input fields
            txtStudentScores.Clear();
            txtStudentName.Clear();
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            if (studentCount == 0)
            {
                MessageBox.Show("No students have been added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double average = studentScorres.Take(studentCount).Average();
            lblAverage.Text = $"Average score {average:F2}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();
            lblAverage.Text = "";
            Array.Clear(studentNames, 0, studentNames.Length);
            Array.Clear(studentScorres, 0, studentScorres.Length);
            studentCount = 0;
        }
    }
}