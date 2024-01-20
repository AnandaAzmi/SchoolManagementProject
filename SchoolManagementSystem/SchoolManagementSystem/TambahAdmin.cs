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
    public partial class TambahAdmin : Form
    {
        public TambahAdmin()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Close();
        }

        private void Kehadiran_Click(object sender, EventArgs e)
        {
            Kehadiran obj = new Kehadiran();
            obj.Show();
            this.Close();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Kompensasi obj = new Kompensasi();
            obj.Show();
            this.Close();
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(pass.Text) || string.IsNullOrEmpty(verifikasi.Text))
            {
                MessageBox.Show("Isi Semua Kolom");
            }
            else
            {
                MySqlCommand cmd;
                var database = new Database();
                if (database.connect_db())
                {
                    cmd = new MySqlCommand();
                    string query = "INSERT INTO `admin` (`AdID`, `AdUsername`, `AdPass`) VALUES " +
                        "(NULL, '" + username.Text + "', '" + pass.Text + "')";
                    cmd.Connection = database.mySqlConnection;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();


                    database.close_db();
                    HapusForm();
                    MainMenu obj = new MainMenu();
                    obj.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Database error");
                }
            }
        }

        private void HapusForm()
        {
            username.Text = "";
            password.Text = "";
            verifikasi.Text = "";
        }

        private void TambahAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
