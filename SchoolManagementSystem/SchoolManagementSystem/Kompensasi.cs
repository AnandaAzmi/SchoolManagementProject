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

namespace SchoolManagementSystem
{
    public partial class Kompensasi : Form
    {
        public Kompensasi()
        {
            InitializeComponent();
            DisplayKompensasi();
            Fillnisn();

        }

        SqlConnection Con = new SqlConnection();
        private void DisplayKompensasi()
        {
            Con.Open();
            string Query = "Select * from KompensasiTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            kompenDgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Fillnisn()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select NISN from StudentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("NISN", typeof(int));
            dt.Load(rdr);
            nisnCb.ValueMember = "NISN";
            nisnCb.DataSource = dt;
            Con.Close() ;
        }
        private void GetStudName()
        {
            //yang ini sesuaikan sama database StudentTbl nya....
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from StudentTbl where NISN=@SID", Con);
            cmd.Parameters.AddWithValue("@SID", nisnCb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                namasiswaTb.Text = dr["NamaSiswa"].ToString();

            }
            Con.Close();
        }
        private void Reset()
        {
            jmlTb.Text = "";
            namasiswaTb.Text = "";
            nisnCb.SelectedIndex = -1;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (namasiswaTb.Text == "" || jmlTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                string paymentperiode;
                paymentperiode = tanggalDtp.Value.Month.ToString() + "/"+ tanggalDtp.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) from KompensasiTbl where ' NISN = '" + nisnCb.SelectedValue.ToString() + " 'and Bulan = '" + paymentperiode.ToString() + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    MessageBox.Show("There is No Due for This Month");
                }
                else
                {
                    //Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into KompensasiTbl(NISN,NamaSiswa,Bulan,Jumlah) values (@SId,@SName,@SMonth,@SJml)", Con); //yang ini @ nya juga disesuaiin sama studentTbl
                    cmd.Parameters.AddWithValue("@SId", nisnCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SName", namasiswaTb.Text);
                    cmd.Parameters.AddWithValue("@SMonth", paymentperiode);
                    cmd.Parameters.AddWithValue("@SAmt", jmlTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kompensasi Successfully Paid");

                }
                Con.Close();
                DisplayKompensasi();
                Reset();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu(); Obj.Show();
            this.Hide();
        }

        private void nisnCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetStudName();
        }
    }
}
  //tabel yang dibutuhkan  
  //nama tabel : KompensasiTbl
  //Kolom : PayId, NISN, NamaSiswa, Bulan, Jumlah
