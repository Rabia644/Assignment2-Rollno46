using static System.Runtime.InteropServices.JavaScript.JSType;

namespace student

{

    partial class AddStudentForm

    {

        private System.ComponentModel.IContainer components = null;



        protected override void Dispose(bool disposing)

        {

            if (disposing && (components != null))

            {

                components.Dispose();

            }

            base.Dispose(disposing);

        }



        #region Windows Form Designer generated code



        private void InitializeComponent()

        {

            lblName = new Label();

            btnSave = new Button();

            lblAge = new Label();

            lblClass = new Label();

            txtName = new TextBox();

            txtAge = new TextBox();

            txtClass = new TextBox();

            SuspendLayout();

            // 

            // lblName

            // 

            lblName.AutoSize = true;

            lblName.Location = new Point(130, 47);

            lblName.Name = "lblName";

            lblName.Size = new Size(59, 25);

            lblName.TabIndex = 0;

            lblName.Text = "Name";

            // 

            // btnSave

            // 

            btnSave.Location = new Point(194, 260);

            btnSave.Name = "btnSave";

            btnSave.Size = new Size(112, 34);

            btnSave.TabIndex = 1;

            btnSave.Text = "Save";

            btnSave.UseVisualStyleBackColor = true;

            btnSave.Click += btnSave_Click;

            // 

            // lblAge

            // 

            lblAge.AutoSize = true;

            lblAge.Location = new Point(130, 117);

            lblAge.Name = "lblAge";

            lblAge.Size = new Size(44, 25);

            lblAge.TabIndex = 2;

            lblAge.Text = "Age";

            // 

            // lblClass

            // 

            lblClass.AutoSize = true;

            lblClass.Location = new Point(130, 177);

            lblClass.Name = "lblClass";

            lblClass.Size = new Size(52, 25);

            lblClass.TabIndex = 3;

            lblClass.Text = "Class";

            // 

            // txtName

            // 

            txtName.Location = new Point(277, 44);

            txtName.Name = "txtName";

            txtName.Size = new Size(150, 31);

            txtName.TabIndex = 4;

            // 

            // txtAge

            // 

            txtAge.Location = new Point(277, 111);

            txtAge.Name = "txtAge";

            txtAge.Size = new Size(150, 31);

            txtAge.TabIndex = 5;

            // 

            // txtClass

            // 

            txtClass.Location = new Point(277, 177);

            txtClass.Name = "txtClass";

            txtClass.Size = new Size(150, 31);

            txtClass.TabIndex = 6;

            // 

            // AddStudentForm

            // 

            AutoScaleDimensions = new SizeF(10F, 25F);

            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(800, 450);

            Controls.Add(txtClass);

            Controls.Add(txtAge);

            Controls.Add(txtName);

            Controls.Add(lblClass);

            Controls.Add(lblAge);

            Controls.Add(btnSave);

            Controls.Add(lblName);

            Name = "AddStudentForm";

            Text = "AddStudentForm";

            ResumeLayout(false);

            PerformLayout();

        }



        #endregion



        private Label lblName;

        private Button btnSave;

        private Label lblAge;

        private Label lblClass;

        private TextBox txtName;

        private TextBox txtAge;

        private TextBox txtClass;

    }

}