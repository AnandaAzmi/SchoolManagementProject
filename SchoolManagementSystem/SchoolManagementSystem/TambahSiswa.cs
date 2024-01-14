using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class TambahSiswa : Form
    {
        
        public TambahSiswa()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TambahSiswa_Load(object sender, EventArgs e)
        {
            TampilKelas();
        }

        private void KirimDataSiswa_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            
            var database = new Database();
            if (database.connect_db())
            {
                cmd = new MySqlCommand();
                string query = "INSERT INTO `siswa` (`SisID`, `SisNISN`, `SisNama`, `SisKelas`, `SisJenisKelamin`, `SisTglLahir`, `SisAlamat`) VALUES " +
                    "(NULL, '" + FormNISN.Text + "', '" + FormNama.Text + "', '" + FormKelas.Text + "', '" + FormKelamin.Text + "', '" + FormTglLahir.Text + "', '" + FormAlamat.Text + "')";
                cmd.Connection = database.mySqlConnection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                

                database.close_db();
                DaftarSiswa obj = new DaftarSiswa();
                obj.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void TampilKelas()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT KelNama FROM kelas";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                DataTable dt = new DataTable();
                dt.Load(mySqlCommand.ExecuteReader());
                database.close_db();

                FormKelas.DataSource = dt;
                FormKelas.ValueMember = "KelNama";
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            var database = new Database();
            if (database.connect_db())
            {
                cmd = new MySqlCommand();
                string query = "INSERT INTO `kelas` (`KelID`, `KelNama`) VALUES " +
                    "(NULL, '" + FormKelas.Text + "')";
                cmd.Connection = database.mySqlConnection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();


                database.close_db();
                TampilKelas();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }
    }
}
