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
    public partial class TambahGuru : Form
    {
        public TambahGuru()
        {
            InitializeComponent();
        }

        private void TambahGuru_Load(object sender, EventArgs e)
        {

        }

        private void KirimForm_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            var database = new Database();
            if (database.connect_db())
            {
                cmd = new MySqlCommand();
                string query = "INSERT INTO `guru` (`GurID`, `GurNama`, `GurNoTelp`, `GurTglLahir`, `GurNIP`, `GurJenisKelamin`, `GurAlamat`) VALUES " +
                    "(NULL, '" + FormNama.Text + "', '" + FormTelp.Text + "', '" + FormTglLahir.Text + "', '" + FormNIP.Text + "', '" + FormKelamin.Text + "', '" + FormAlamat.Text + "')";
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
    }
}
