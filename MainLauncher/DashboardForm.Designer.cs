namespace student
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddStudent = new Button();
            btnViewStudents = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(245, 50);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(112, 34);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnViewStudents
            // 
            btnViewStudents.Location = new Point(245, 118);
            btnViewStudents.Name = "btnViewStudents";
            btnViewStudents.Size = new Size(112, 34);
            btnViewStudents.TabIndex = 1;
            btnViewStudents.Text = "View Students";
            btnViewStudents.UseVisualStyleBackColor = true;
            btnViewStudents.Click += btnViewStudents_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(245, 190);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnViewStudents);
            Controls.Add(btnAddStudent);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddStudent;
        private Button btnViewStudents;
        private Button btnExit;
    }
}