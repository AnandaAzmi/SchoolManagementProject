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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace SchoolManagementSystem
{
    public partial class EditSiswa : Form
    {
        public EditSiswa()
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

                EditNISN.DataSource = dt;
                EditNISN.ValueMember = "SisNISN";
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

        private void EditSiswa_Load(object sender, EventArgs e)
        {

        }

        private void CariDataSiswa_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM siswa WHERE SisNISN =" + EditNISN.Text;
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                MySqlDataReader mdr;
                mdr = mySqlCommand.ExecuteReader();

                if (mdr.Read())
                {
                    EditNama.Text = mdr.GetString("SisNama");
                    EditKelas.Text = mdr.GetString("SisKelas");
                    EditTglLahir.Text = mdr.GetString("SisTglLahir");
                    EditKelamin.Text = mdr.GetString("SisJenisKelamin");
                    EditAlamat.Text = mdr.GetString("SisAlamat");
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

        private void Home_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Close();
        }

        private void KirimDataSiswa_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "UPDATE siswa SET `SisNama` = '" + EditNama.Text + "', `SisKelas` = '" + EditKelas.Text + "', `SisJenisKelamin` = '" + EditKelamin.Text + "', " +
                    "`SisTglLahir` = '" + EditTglLahir.Text + "', `SisAlamat` = '" + EditAlamat.Text + "' WHERE `siswa`.`SisNISN` = '" + EditNISN.Text + "'";
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

        private void Filter_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM siswa WHERE SisNama LIKE '%"+CariNama.Text+"%'";
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
    }
}
