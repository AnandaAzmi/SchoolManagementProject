using MySql.Data.MySqlClient;
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
            string username = usernameTB.Text;
            string password = PasswordTB.Text;
            bool masuk = false;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tidak boleh ada kolom yang kosong");
            }
            else
            {
                var database = new Database();
                if (database.connect_db())
                {
                    string query = "SELECT * FROM admin";
                    MySqlCommand mySqlCommand = new MySqlCommand(query);
                    mySqlCommand.Connection = database.mySqlConnection;

                    MySqlDataReader reader = mySqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        if (username.Equals(reader.GetString("AdUsername")) && password.Equals(reader.GetString("AdPass")))
                        {
                            masuk = true;
                        }
                    }

                    if (masuk)
                    {
                        MessageBox.Show("Login Sukses");
                        MainMenu obj = new MainMenu();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Invalid");
                    }
                }
            }
        }
    }
}
