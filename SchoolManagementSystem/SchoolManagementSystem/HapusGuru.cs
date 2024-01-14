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
    public partial class HapusGuru : Form
    {
        public HapusGuru()
        {
            InitializeComponent();
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT GurNIP FROM guru";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                DataTable dt = new DataTable();
                dt.Load(mySqlCommand.ExecuteReader());
                database.close_db();

                HapusNIP.DataSource = dt;
                HapusNIP.ValueMember = "GurNIP";
            }
            else
            {
                MessageBox.Show("Database error");
            }

            database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT GurNama FROM guru";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                DataTable dt = new DataTable();
                dt.Load(mySqlCommand.ExecuteReader());
                database.close_db();

                CariNama.DataSource = dt;
                CariNama.ValueMember = "GurNama";
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }

        private void HapusGuru_Load(object sender, EventArgs e)
        {

        }

        private void CekDataGuru_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM guru WHERE GurNIP =" + HapusNIP.Text;
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;

                MySqlDataReader mdr;
                mdr = mySqlCommand.ExecuteReader();

                if (mdr.Read())
                {
                    NamaGuru.Text = mdr.GetString("GurNama");
                    NoTelpGuru.Text = mdr.GetString("GurNoTelp");
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

        private void HapusDataGuru_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "DELETE FROM guru WHERE `guru`.`GurNIP` = " + HapusNIP.Text;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = database.mySqlConnection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                database.close_db();

                DaftarGuru obj = new DaftarGuru();
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
                string query = "SELECT * FROM guru WHERE GurNama LIKE '%" + CariNama.Text + "%'";
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
    }
}
