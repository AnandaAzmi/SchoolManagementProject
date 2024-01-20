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
    public partial class DaftarGuru : Form
    {
        public DaftarGuru()
        {
            InitializeComponent();
        }

        private void DaftarGuru_Load(object sender, EventArgs e)
        {
            IsiTabelGuru();
        }


        private void Home_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Kehadiran obj = new Kehadiran();
            obj.Show();
            this.Close();
        }

        private void Kompensasi_Click(object sender, EventArgs e)
        {
            Kompensasi obj = new Kompensasi();
            obj.Show();
            this.Close();
        }

        private void tambahGuru_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            var database = new Database();
            if (database.connect_db())
            {
                cmd = new MySqlCommand();
                string query = "INSERT INTO `guru` (`GurID`, `GurNama`, `GurNoTelp`, `GurTglLahir`, `GurNIP`, `GurJenisKelamin`, `GurAlamat`) VALUES " +
                    "(NULL, '" + FormNama.Text + "', '" + FormNoTelp.Text + "', '" + FormTglLahir.Text + "', '" + FormNIP.Text + "', '" + FormKelamin.Text + "', '" + FormAlamat.Text + "')";
                cmd.Connection = database.mySqlConnection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                database.close_db();
                HapusForm();
                IsiTabelGuru();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void editGuru_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "UPDATE guru SET `GurNama` = '" + FormNama.Text + "', `GurNoTelp` = '" + FormNoTelp.Text + "', `GurJenisKelamin` = '" + FormKelamin.Text + "', " +
                    "`GurTglLahir` = '" + FormTglLahir.Text + "', `GurAlamat` = '" + FormAlamat.Text + "' WHERE `guru`.`GurNIP` = '" + FormNIP.Text + "'";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = database.mySqlConnection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                database.close_db();
                HapusForm();
                IsiTabelGuru();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void hapusGuru_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "DELETE FROM guru WHERE `guru`.`GurNIP` = " + FormNIP.Text;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = database.mySqlConnection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                database.close_db();
                HapusForm();
                IsiTabelGuru();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void IsiTabelGuru()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM guru";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridDaftarGuru.DataSource = bindingSource;

                database.close_db();
            }
            else
            {
                MessageBox.Show("Database error");
            }

        }

        private void dataGridDaftarGuru_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormNIP.Text = dataGridDaftarGuru.Rows[e.RowIndex].Cells[1].Value.ToString();

            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM guru WHERE GurNIP =" + FormNIP.Text;
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                MySqlDataReader mdr;
                mdr = mySqlCommand.ExecuteReader();

                if (mdr.Read())
                {
                    FormNama.Text = mdr.GetString("GurNama");
                    FormKelamin.Text = mdr.GetString("GurJenisKelamin");
                    FormTglLahir.Text = mdr.GetString("GurTglLahir");
                    FormNoTelp.Text = mdr.GetString("GurNoTelp");
                    FormAlamat.Text = mdr.GetString("GurAlamat");
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

        private void HapusForm()
        {
            FormNIP.Text = "";
            FormNama.Text = "";
            FormKelamin.Text = "";
            FormTglLahir.Text = "";
            FormNoTelp.Text = "";
            FormAlamat.Text = "";
        }
    }


}
