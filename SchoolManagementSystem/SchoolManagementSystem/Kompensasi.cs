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
        public Kompensasi()
        {
            InitializeComponent();
            

        }

        SqlConnection Con = new SqlConnection();
        private void DisplayKompensasi()
        {
            
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        
        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu(); Obj.Show();
            this.Hide();
        }

        private void nisnCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Kompensasi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolManagementDataSet.KompensasiTbl' table. You can move, or remove it, as needed.
            //this.kompensasiTblTableAdapter.Fill(this.schoolManagementDataSet.KompensasiTbl);
            IsiTabel();
        }

        private void kompenDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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

                kompenDgv.DataSource = bindingSource;

                database.close_db();
            }
            else
            {
                MessageBox.Show("Database error");
            }
        }
    }
}
