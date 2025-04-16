using Newtonsoft.Json;

namespace StudentRecord
{
    public partial class Form1 : Form
    {
        private string filePath = "students.json";
        private List<Student> studentList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2();
            if(addForm.ShowDialog() == DialogResult.OK)
            {
                studentList.Add(addForm.NewStudent);
                SaveStudentsToFile();
                LoadStudentsFromFile();
            }
        }

        private void SaveStudentsToFile()
        {
            string json = JsonConvert.SerializeObject(studentList, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentsFromFile();
        }
        private void LoadStudentsFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                studentList = JsonConvert.DeserializeObject<List<Student>>(json) ?? new List<Student>();
            }
            lbxStudents.Items.Clear();
            foreach (var student in studentList)
            {
                lbxStudents.Items.Add($"{student.Name} (Age {student.Age})");
            }
        }
    }
}