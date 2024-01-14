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
    public partial class Kehadiran : Form
    {
        bool filter = false;
        public Kehadiran()
        {
            InitializeComponent();

            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT KelNama FROM kelas";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                DataTable dt = new DataTable();
                dt.Load(mySqlCommand.ExecuteReader());
                database.close_db();

                HadirKelas.DataSource = dt;
                HadirKelas.ValueMember = "KelNama";
                SelectFilter.DataSource = dt;
                SelectFilter.ValueMember = "KelNama";
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void Kehadiran_Load(object sender, EventArgs e)
        {
            IsiTabelKehadiran();
        }

        private void HadirKelas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TampilNamaSiswa();
        }

        private void TampilNamaSiswa ()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT SisNama FROM siswa WHERE SisKelas LIKE '" + HadirKelas.SelectedValue + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                DataTable dt = new DataTable();
                dt.Load(mySqlCommand.ExecuteReader());
                database.close_db();

                HadirNama.DataSource = dt;
                HadirNama.DisplayMember = "Name";
                HadirNama.ValueMember = "SisNama";
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            var database = new Database();
            if (database.connect_db())
            {
                cmd = new MySqlCommand();
                string query = "INSERT INTO `kehadiran` (`DirID`, `DirSiswa`, `DirTanggal`, `DirStatus`) " +
                    "VALUES (NULL, '" + HadirNama.Text + "', '" + HadirTanggal.Text + "', '" + HadirStatus.Text + "')";

                cmd.Connection = database.mySqlConnection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();


                database.close_db();
                if (filter == false)
                {
                    IsiTabelKehadiran();
                }
                else
                {
                    IsiTabelKehadiranKelas();
                }
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void IsiTabelKehadiran()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT `kehadiran`.*, `siswa`.`SisKelas` FROM `kehadiran` LEFT JOIN `siswa` ON `kehadiran`.`DirSiswa` = `siswa`.`SisNama`;";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridDaftarKehadiran.DataSource = bindingSource;

                database.close_db();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void IsiTabelKehadiranKelas()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT `kehadiran`.*, `siswa`.`SisKelas` FROM `kehadiran` LEFT JOIN `siswa` ON `kehadiran`.`DirSiswa` = `siswa`.`SisNama` " +
                    "WHERE `kehadiran`.`DirTanggal` LIKE '" + FilterTanggal.Text + "' AND `siswa`.`SisKelas` = '" + SelectFilter.Text + "'; ";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridDaftarKehadiran.DataSource = bindingSource;

                database.close_db();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            IsiTabelKehadiranKelas();
            filter = true;
        }
    }
}
