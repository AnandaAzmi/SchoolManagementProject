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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Close();
        }

        private void label55_Click(object sender, EventArgs e)
        {
            Kompensasi obj = new Kompensasi();
            obj.Show();
            this.Close();
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

        private void DaftarGuru_Load(object sender, EventArgs e)
        {
            IsiTabelGuru();
        }

        private void TambahGuru_Click(object sender, EventArgs e)
        {
            TambahGuru obj = new TambahGuru();
            obj.Show();
            this.Close();
        }

        private void EditGuru_Click(object sender, EventArgs e)
        {
            EditGuru obj = new EditGuru();
            obj.Show();
            this.Close();
        }

        private void HapusGuru_Click(object sender, EventArgs e)
        {
            HapusGuru obj = new HapusGuru();
            obj.Show();
            this.Close();
        }
    }
}
