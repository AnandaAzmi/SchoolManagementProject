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
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();
            TampilJumlah();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            TampilJumlah();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {
            Kompensasi Obj = new Kompensasi();
            Obj.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DetailGuru_Click(object sender, EventArgs e)
        {
            DaftarGuru obj = new DaftarGuru();
            obj.Show();
            this.Hide();
        }

        private void DetailSiswa_Click(object sender, EventArgs e)
        {
            DaftarSiswa obj = new DaftarSiswa();
            obj.Show();
            this.Hide();
        }

        private void TampilJumlah()
        {

            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT COUNT(*)  FROM siswa";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                int count = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                JmlhSiswa.Text = count.ToString();

                query = "SELECT COUNT(*)  FROM guru";
                mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                count = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                JmlhGuru.Text = count.ToString();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {
            Kehadiran obj = new Kehadiran();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            TampilJumlah();
        }
    }
}
