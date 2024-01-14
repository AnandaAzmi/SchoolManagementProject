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
    public partial class HapusSiswa : Form
    {
        public HapusSiswa()
        {
            InitializeComponent();
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT SisNISN FROM siswa";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                DataTable dt = new DataTable();
                dt.Load(mySqlCommand.ExecuteReader());
                database.close_db();

                HapusNISN.DataSource = dt;
                HapusNISN.ValueMember = "SisNISN";
            }
            else
            {
                MessageBox.Show("Database error");
            }
            
            database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT SisNama FROM siswa";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                DataTable dt = new DataTable();
                dt.Load(mySqlCommand.ExecuteReader());
                database.close_db();

                CariNama.DataSource = dt;
                CariNama.ValueMember = "SisNama";
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void HapusSiswa_Load(object sender, EventArgs e)
        {

        }

        private void CekDataSiswa_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM siswa WHERE SisNISN =" + HapusNISN.Text;
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                MySqlDataReader mdr;
                mdr = mySqlCommand.ExecuteReader();

                if (mdr.Read())
                {
                    NamaSiswa.Text = mdr.GetString("SisNama");
                    KelasSiswa.Text = mdr.GetString("SisKelas");
                }
                else
                {
                    MessageBox.Show("Record Not Found!");
                }
                database.close_db();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM siswa WHERE SisNama LIKE '%" + CariNama.Text + "%'";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridDaftarSiswa.DataSource = bindingSource;

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

        private void label2_Click(object sender, EventArgs e)
        {
            Kompensasi obj = new Kompensasi();
            obj.Show();
            this.Close();
        }

        private void HapusDataSiswa_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "DELETE FROM siswa WHERE `siswa`.`SisNISN` = " + HapusNISN.Text;
                MySqlCommand cmd = new MySqlCommand();
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
    }
}
