namespace MainLauncher
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
            btnProject1 = new Button();
            btnProject2 = new Button();
            btnProject3 = new Button();
            btnProject4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnProject1
            // 
            btnProject1.Location = new Point(212, 126);
            btnProject1.Name = "btnProject1";
            btnProject1.Size = new Size(112, 34);
            btnProject1.TabIndex = 0;
            btnProject1.Text = "Project1";
            btnProject1.UseVisualStyleBackColor = true;
            btnProject1.Click += btnProject1_Click_1;
            // 
            // btnProject2
            // 
            btnProject2.Location = new Point(378, 126);
            btnProject2.Name = "btnProject2";
            btnProject2.Size = new Size(112, 34);
            btnProject2.TabIndex = 1;
            btnProject2.Text = "Project2";
            btnProject2.UseVisualStyleBackColor = true;
            btnProject2.Click += btnProject2_Click_1;
            // 
            // btnProject3
            // 
            btnProject3.Location = new Point(212, 202);
            btnProject3.Name = "btnProject3";
            btnProject3.Size = new Size(112, 34);
            btnProject3.TabIndex = 2;
            btnProject3.Text = "Project3";
            btnProject3.UseVisualStyleBackColor = true;
            btnProject3.Click += btnProject3_Click_1;
            // 
            // btnProject4
            // 
            btnProject4.Location = new Point(378, 202);
            btnProject4.Name = "btnProject4";
            btnProject4.Size = new Size(112, 34);
            btnProject4.TabIndex = 3;
            btnProject4.Text = "Project4";
            btnProject4.UseVisualStyleBackColor = true;
            btnProject4.Click += btnProject4_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 43);
            label1.Name = "label1";
            label1.Size = new Size(211, 38);
            label1.TabIndex = 4;
            label1.Text = "Rabia roll no 46";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnProject4);
            Controls.Add(btnProject3);
            Controls.Add(btnProject2);
            Controls.Add(btnProject1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProject1;
        private Button btnProject2;
        private Button btnProject3;
        private Button btnProject4;
        private Label label1;
    }
}
