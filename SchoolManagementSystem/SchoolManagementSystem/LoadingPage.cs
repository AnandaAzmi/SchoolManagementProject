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
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar.Value = startpoint;
            Percent.Text= startpoint + "%";
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                LoginPage Obj = new LoginPage();
                this.Hide();
                Obj.Show();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
