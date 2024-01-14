using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void resetLb_Click(object sender, EventArgs e)
        {
            usernameTB.Text = "";
            PasswordTB.Text = "";
        }

        private void LoginBt_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text == "" || PasswordTB.Text=="")
            {
                MessageBox.Show("Enter Username and Password");

            }
            else if (usernameTB.Text == "Admin" && PasswordTB.Text == "Password")
            {
                MainMenu Obj = new MainMenu();
                Obj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
                usernameTB.Text = "";
                PasswordTB.Text = "";
            }
        }
    }
}
