namespace calculator
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
            lblNum1 = new Label();
            txtNum1 = new TextBox();
            lblNum2 = new Label();
            txtNum2 = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnShowHistory = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(50, 30);
            lblNum1.Margin = new Padding(2, 0, 2, 0);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(92, 25);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Number 1";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(150, 30);
            txtNum1.Margin = new Padding(2, 4, 2, 4);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(150, 31);
            txtNum1.TabIndex = 1;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(50, 70);
            lblNum2.Margin = new Padding(2, 0, 2, 0);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(92, 25);
            lblNum2.TabIndex = 2;
            lblNum2.Text = "Number 2";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(150, 70);
            txtNum2.Margin = new Padding(2, 4, 2, 4);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(150, 31);
            txtNum2.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(50, 110);
            btnAdd.Margin = new Padding(2, 4, 2, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(130, 110);
            btnSubtract.Margin = new Padding(2, 4, 2, 4);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(112, 35);
            btnSubtract.TabIndex = 5;
            btnSubtract.Text = "Subtract";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(230, 110);
            btnMultiply.Margin = new Padding(2, 4, 2, 4);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(112, 35);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "Multiply";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.Control;
            btnDivide.Location = new Point(330, 110);
            btnDivide.Margin = new Padding(2, 4, 2, 4);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(112, 35);
            btnDivide.TabIndex = 7;
            btnDivide.Text = "Divide";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnShowHistory
            // 
            btnShowHistory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowHistory.Location = new Point(150, 160);
            btnShowHistory.Margin = new Padding(2, 4, 2, 4);
            btnShowHistory.Name = "btnShowHistory";
            btnShowHistory.Size = new Size(192, 50);
            btnShowHistory.TabIndex = 8;
            btnShowHistory.Text = "Show History";
            btnShowHistory.UseVisualStyleBackColor = true;
            btnShowHistory.Click += btnShowHistory_Click_1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(50, 200);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(63, 25);
            lblResult.TabIndex = 9;
            lblResult.Text = "Result:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnShowHistory);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtNum2);
            Controls.Add(lblNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 4, 2, 4);
            Name = "Form2";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private TextBox txtNum1;
        private Label lblNum2;
        private TextBox txtNum2;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnShowHistory;
        private Label lblResult;
    }
}