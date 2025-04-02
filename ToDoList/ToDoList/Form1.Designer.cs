namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTaskInput = new TextBox();
            btnAddTask = new Button();
            btnRemoveTask = new Button();
            btnMarkDone = new Button();
            lstTasks = new ListBox();
            SuspendLayout();
            // 
            // txtTaskInput
            // 
            txtTaskInput.Location = new Point(318, 144);
            txtTaskInput.Name = "txtTaskInput";
            txtTaskInput.Size = new Size(150, 31);
            txtTaskInput.TabIndex = 0;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(113, 317);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(116, 35);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.Location = new Point(329, 317);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(139, 35);
            btnRemoveTask.TabIndex = 2;
            btnRemoveTask.Text = "Remove Task";
            btnRemoveTask.UseVisualStyleBackColor = true;
            btnRemoveTask.Click += btnRemoveTask_Click;
            // 
            // btnMarkDone
            // 
            btnMarkDone.Location = new Point(542, 317);
            btnMarkDone.Name = "btnMarkDone";
            btnMarkDone.Size = new Size(112, 35);
            btnMarkDone.TabIndex = 3;
            btnMarkDone.Text = "Mark Done";
            btnMarkDone.UseVisualStyleBackColor = true;
            btnMarkDone.Click += btnMarkDone_Click;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 25;
            lstTasks.Location = new Point(578, 70);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(180, 129);
            lstTasks.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstTasks);
            Controls.Add(btnMarkDone);
            Controls.Add(btnRemoveTask);
            Controls.Add(btnAddTask);
            Controls.Add(txtTaskInput);
            Name = "Form1";
            Text = "To Do List";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTaskInput;
        private Button btnAddTask;
        private Button btnRemoveTask;
        private Button btnMarkDone;
        private ListBox lstTasks;
    }
}