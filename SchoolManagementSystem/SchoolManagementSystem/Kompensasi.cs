using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SchoolManagementSystem
{
    public partial class Kompensasi : Form
    {
        string selectedNISN, selectedID;
        public Kompensasi()
        {
            InitializeComponent();
            IsiFormKelas();
            IsiTabel();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void Kehadiran_Click(object sender, EventArgs e)
        {
            Kehadiran obj = new Kehadiran();
            obj.Show();
            this.Close();
        }

        private void tombolKompensasi_Click(object sender, EventArgs e)
        {
            Kompensasi obj = new Kompensasi();
            obj.Show();
            this.Close();
        }

        private void Kompensasi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolManagementDataSet.KompensasiTbl' table. You can move, or remove it, as needed.
            //this.kompensasiTblTableAdapter.Fill(this.schoolManagementDataSet.KompensasiTbl);
            IsiTabel();
        }

        private void IsiTabel()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM kompensasi";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridDaftarKompensasi.DataSource = bindingSource;

                database.close_db();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void IsiFormKelas()
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

        private void FormKelas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT SisNama FROM siswa WHERE SisKelas LIKE '" + FormKelas.SelectedValue + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                DataTable dt = new DataTable();
                dt.Load(mySqlCommand.ExecuteReader());
                database.close_db();

                FormNama.DataSource = dt;
                FormNama.DisplayMember = "Name";
                FormNama.ValueMember = "SisNama";
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void FormNama_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM siswa WHERE SisNama LIKE '" + FormNama.SelectedValue + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                MySqlDataReader mdr;
                mdr = mySqlCommand.ExecuteReader();

                if (mdr.Read())
                {
                    selectedNISN = mdr.GetString("SisNISN");
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

        private void Tambah_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            var database = new Database();
            if (database.connect_db())
            {
                cmd = new MySqlCommand();
                string query = "INSERT INTO `kompensasi` (`KomID`, `KomNISN`, `KomNama`, `KomTanggal`, `KomJumlah`, `KomFlagLunas`) " +
                    "VALUES (NULL, '" + selectedNISN + "', '" + FormNama.Text + "', '" + FormTanggal.Text + "', '" + FormJam.Text + "', '" + FormLunas.Checked + "')";

                cmd.Connection = database.mySqlConnection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                IsiTabel();


                database.close_db();
            }
        }

        private void dataGridDaftarKompensasi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedID = dataGridDaftarKompensasi.Rows[e.RowIndex].Cells[0].Value.ToString();

            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM kompensasi WHERE KomID =" + selectedID;
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                MySqlDataReader mdr;
                mdr = mySqlCommand.ExecuteReader();

                if (mdr.Read())
                {
                    FormNama.Text = mdr.GetString("KomNama");
                    FormTanggal.Text = mdr.GetString("KomTanggal");
                    FormJam.Text = mdr.GetString("KomJumlah");
                    FormLunas.Checked = mdr.GetBoolean("KomFlagLunas");
                    FormKelas.Text = "";
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

        private void Edit_Click(object sender, EventArgs e)
        {
            int lunas = Convert.ToInt32(FormLunas.Checked);
            var database = new Database();
            if (database.connect_db())
            {
                string query = "UPDATE `kompensasi` SET `KomNama` = '" + FormNama.Text + "', `KomTanggal` = '" + FormTanggal.Text + "', `KomJumlah` = '" + FormJam.Text + "'," +
                    " `KomFlagLunas` = '" + lunas + "' WHERE `kompensasi`.`KomID` = " + selectedID;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = database.mySqlConnection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                database.close_db();
                IsiTabel();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }
    }
}
