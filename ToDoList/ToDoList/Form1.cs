namespace ToDoList
{
    public partial class Form1 : Form
    {
        //list to store tasks
        private List<string> tasks = new List<string>();
        //(), [], <>
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string task = txtTaskInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(task))
            {
                MessageBox.Show("Please enter a valid task!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //add task to the list
            tasks.Add(task);
            UpdateTaskList();
            //Clear input field
            txtTaskInput.Clear();
        }
        //function UpdateTaskList with the latest tasks
        private void UpdateTaskList()
        {
            lstTasks.Items.Clear();
            foreach (string task in tasks)
            {
                lstTasks.Items.Add(task);
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task to remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Remove the selected task
            tasks.RemoveAt(lstTasks.SelectedIndex);
            UpdateTaskList();
        }

        private void btnMarkDone_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task to mark as done!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = lstTasks.SelectedIndex;
            if (!tasks[index].Contains("✅"))
            {
                tasks[index] = "✅ " + tasks[index]; //add checkmark to task
            }
            UpdateTaskList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}