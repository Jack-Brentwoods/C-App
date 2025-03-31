using System;
using System.Windows.Forms;

namespace MyWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Màn hình chính";

            Button btnPage1 = new Button { Left = 50, Top = 30, Text = "Giao diện 1" };
            Button btnPage2 = new Button { Left = 150, Top = 30, Text = "Giao diện 2" };

            btnPage1.Click += (sender, e) => 
            {
                Page1 page1 = new Page1();
                page1.Show();
            };

            btnPage2.Click += (sender, e) => 
            {
                Page2 page2 = new Page2();
                page2.Show();
            };

            this.Controls.Add(btnPage1);
            this.Controls.Add(btnPage2);
        }
    }
}
