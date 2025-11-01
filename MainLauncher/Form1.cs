using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MainLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProject1_Click_1(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\UsEr\source\repos\Firstform\Firstform\bin\Debug\net8.0-windows\Firstform.exe");
        }

        private void btnProject2_Click_1(object sender, EventArgs e)
        {
            Process.Start(@" C:\Users\UsEr\source\repos\student\student\bin\Debug\net8.0-windows\student.exe");
        }

        private void btnProject3_Click_1(object sender, EventArgs e)
        {
            Process.Start(@" C:\Users\UsEr\source\repos\Booksystem\Booksystem\bin\Debug\net8.0-windows\Booksystem.exe");
        }

        private void btnProject4_Click_1(object sender, EventArgs e)
        {
            Process.Start(@" C:\Users\UsEr\source\repos\calculator\calculator\bin\Debug\net8.0-windows\calculator.exe");
        }
    }
}
