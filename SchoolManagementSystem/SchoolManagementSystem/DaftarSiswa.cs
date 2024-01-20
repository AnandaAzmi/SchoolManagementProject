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
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SchoolManagementSystem
{
    public partial class DaftarSiswa : Form
    {
        
        public DaftarSiswa()
        {
            InitializeComponent();
            IsiFormKelas();
            IsiFilterKelas();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DaftarSiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolManagementDataSet1.Siswa' table. You can move, or remove it, as needed.
            //this.siswaTableAdapter.Fill(this.schoolManagementDataSet1.Siswa);
            IsiTabelSiswa();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if(!CekKelas())
            {
                TambahKelas();
            }
            
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
                HapusForm();
                IsiTabelSiswa();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void IsiTabelSiswa()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM siswa";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "UPDATE siswa SET `SisNama` = '" + FormNama.Text + "', `SisKelas` = '" + FormKelas.Text + "', `SisJenisKelamin` = '" + FormKelamin.Text + "', " +
                    "`SisTglLahir` = '" + FormTglLahir.Text + "', `SisAlamat` = '" + FormAlamat.Text + "' WHERE `siswa`.`SisNISN` = '" + FormNISN.Text + "'";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = database.mySqlConnection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                database.close_db();

                HapusForm();
            }
            else
            {
                MessageBox.Show("Database error");
            }
            IsiTabelSiswa();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            IsiTabelSiswa();
            SelectFilter.Text = "";
        }

        private void HapusSiswa_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "DELETE FROM siswa WHERE `siswa`.`SisNISN` = " + FormNISN.Text;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = database.mySqlConnection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                database.close_db();

                HapusForm();
            }
            else
            {
                MessageBox.Show("Database error");
            }
            IsiTabelSiswa();
        }

        private void dataGridDaftarSiswa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormNISN.Text = dataGridDaftarSiswa.Rows[e.RowIndex].Cells[1].Value.ToString();

            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM siswa WHERE SisNISN =" + FormNISN.Text;
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                MySqlDataReader mdr;
                mdr = mySqlCommand.ExecuteReader();

                if (mdr.Read())
                {
                    FormNama.Text = mdr.GetString("SisNama");
                    FormKelamin.Text = mdr.GetString("SisJenisKelamin");
                    FormTglLahir.Text = mdr.GetString("SisTglLahir");
                    FormKelas.Text = mdr.GetString("SisKelas");
                    FormAlamat.Text = mdr.GetString("SisAlamat");
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

        private bool CekKelas()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string kelas = FormKelas.Text;
                string query = "SELECT * FROM kelas";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    if (kelas.Equals(reader.GetString("KelNama")))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void TambahKelas()
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
            }
            else
            {
                MessageBox.Show("Database error");
            }
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

        private void IsiFilterKelas()
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

                SelectFilter.DataSource = dt;
                SelectFilter.ValueMember = "KelNama";
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void SelectFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM siswa WHERE SisKelas LIKE '" + SelectFilter.SelectedValue + "'";
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

        private void HapusForm()
        {
            FormNISN.Text = "";
            FormNama.Text = "";
            FormKelamin.Text = "";
            FormTglLahir.Text = "";
            FormKelas.Text = "";
            FormAlamat.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Kehadiran obj = new Kehadiran();
            obj.Show();
            this.Close();
        }
    }
}
