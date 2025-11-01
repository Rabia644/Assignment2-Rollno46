namespace Firstform
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            logout = new Button();
            welcome = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(62, 74);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "profile";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(62, 151);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "settings";
            button2.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            logout.Location = new Point(62, 222);
            logout.Name = "logout";
            logout.Size = new Size(112, 34);
            logout.TabIndex = 3;
            logout.Text = "logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += btnLogout_Click;
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.Location = new Point(78, 21);
            welcome.Name = "welcome";
            welcome.Size = new Size(82, 25);
            welcome.TabIndex = 4;
            welcome.Text = "welcome";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(welcome);
            Controls.Add(logout);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Label welcome;
        private Button logout;
    }
}