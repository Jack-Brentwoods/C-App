using System;
using System.Windows.Forms;

namespace MyWinFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Đăng nhập";
            
            // Giao diện đơn giản
            TextBox txtUser = new TextBox { Left = 50, Top = 30, Width = 200 };
            TextBox txtPass = new TextBox { Left = 50, Top = 70, Width = 200, PasswordChar = '*' };
            Button btnLogin = new Button { Left = 50, Top = 110, Text = "Đăng nhập" };

            btnLogin.Click += (sender, e) =>
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            };

            this.Controls.Add(txtUser);
            this.Controls.Add(txtPass);
            this.Controls.Add(btnLogin);
        }
    }
}
