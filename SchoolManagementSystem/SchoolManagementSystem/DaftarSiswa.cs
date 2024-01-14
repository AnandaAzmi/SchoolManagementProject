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

namespace SchoolManagementSystem
{
    public partial class DaftarSiswa : Form
    {
        
        public DaftarSiswa()
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

                SelectFilter.DataSource = dt;
                SelectFilter.ValueMember = "KelNama";
            }
            else
            {
                MessageBox.Show("Database error");
            }
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
            FilterTabelSiswa();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            TambahSiswa obj = new TambahSiswa();
            obj.Show();
            this.Close();
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

        private void FilterTabelSiswa()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM siswa WHERE SisKelas LIKE '" + SelectFilter.Text + "'";
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
            EditSiswa obj = new EditSiswa();
            obj.Show();
            this.Close();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            IsiTabelSiswa();
        }

        private void HapusSiswa_Click(object sender, EventArgs e)
        {
            HapusSiswa obj = new HapusSiswa();
            obj.Show();
            this.Close();
        }
    }
}
