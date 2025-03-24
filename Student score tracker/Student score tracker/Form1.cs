namespace Student_score_tracker
{
    public partial class Form1 : Form
    {
        //create 2 arrays
        private string[] studentNames = { "Alice", "Chris", "McRib", "Ellen", "Sneven" };
        private int[] studentScores = { 85, 92, 78, 90, 88 };
        public Form1()
        {
            InitializeComponent();
            loadStudentNames();
        }
        //Load student names into the combox
        private void loadStudentNames()
        {
            cbxStudents.Items.AddRange(studentNames);
        }

        //calculate and display student average score
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double average = studentScores.Average();
            lblAverage.Text = $"average score is: {average:F2}";
        }

        private void cbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxStudents.SelectedIndex;
            lblScore.Text = $"Score: {studentScores[selectedIndex]}";
        }
    }
}