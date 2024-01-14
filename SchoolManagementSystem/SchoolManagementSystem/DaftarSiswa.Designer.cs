namespace SchoolManagementSystem
{
    partial class DaftarSiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaftarSiswa));
            this.panel6 = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridDaftarSiswa = new System.Windows.Forms.DataGridView();
            this.siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolManagementDataSet1 = new SchoolManagementSystem.SchoolManagementDataSet1();
            this.schoolManagementDataSet = new SchoolManagementSystem.SchoolManagementDataSet();
            this.schoolManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siswaTableAdapter = new SchoolManagementSystem.SchoolManagementDataSet1TableAdapters.SiswaTableAdapter();
            this.SelectFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Filter = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Refresh = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.HapusSiswa = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDaftarSiswa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementDataSetBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SkyBlue;
            this.panel6.Controls.Add(this.label50);
            this.panel6.Controls.Add(this.label41);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(804, 69);
            this.panel6.TabIndex = 27;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.SkyBlue;
            this.label50.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.Black;
            this.label50.Location = new System.Drawing.Point(60, 40);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(206, 13);
            this.label50.TabIndex = 31;
            this.label50.Text = "Mencerdaskan anak bangsa untuk negeri";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.SkyBlue;
            this.label41.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.DarkOrange;
            this.label41.Location = new System.Drawing.Point(58, 15);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(195, 25);
            this.label41.TabIndex = 30;
            this.label41.Text = "SMA NUSA BANGSA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.Home);
            this.panel1.Location = new System.Drawing.Point(510, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 28);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.BackColor = System.Drawing.Color.RoyalBlue;
            this.Home.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(21, 7);
            this.Home.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(38, 13);
            this.Home.TabIndex = 23;
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(601, 28);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(78, 28);
            this.panel5.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kehadiran";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(691, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(82, 28);
            this.panel3.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kompensasi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Daftar Siswa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridDaftarSiswa
            // 
            this.dataGridDaftarSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDaftarSiswa.Location = new System.Drawing.Point(26, 194);
            this.dataGridDaftarSiswa.Name = "dataGridDaftarSiswa";
            this.dataGridDaftarSiswa.Size = new System.Drawing.Size(747, 421);
            this.dataGridDaftarSiswa.TabIndex = 28;
            this.dataGridDaftarSiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // siswaBindingSource
            // 
            this.siswaBindingSource.DataMember = "Siswa";
            this.siswaBindingSource.DataSource = this.schoolManagementDataSet1;
            // 
            // schoolManagementDataSet1
            // 
            this.schoolManagementDataSet1.DataSetName = "SchoolManagementDataSet1";
            this.schoolManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolManagementDataSet
            // 
            this.schoolManagementDataSet.DataSetName = "SchoolManagementDataSet";
            this.schoolManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolManagementDataSetBindingSource
            // 
            this.schoolManagementDataSetBindingSource.DataSource = this.schoolManagementDataSet;
            this.schoolManagementDataSetBindingSource.Position = 0;
            // 
            // siswaTableAdapter
            // 
            this.siswaTableAdapter.ClearBeforeFill = true;
            // 
            // SelectFilter
            // 
            this.SelectFilter.FormattingEnabled = true;
            this.SelectFilter.Items.AddRange(new object[] {
            "X",
            "XI",
            "XII"});
            this.SelectFilter.Location = new System.Drawing.Point(26, 167);
            this.SelectFilter.Name = "SelectFilter";
            this.SelectFilter.Size = new System.Drawing.Size(159, 21);
            this.SelectFilter.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kelas\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.Filter);
            this.panel2.Location = new System.Drawing.Point(200, 167);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 21);
            this.panel2.TabIndex = 29;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.BackColor = System.Drawing.Color.RoyalBlue;
            this.Filter.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.ForeColor = System.Drawing.Color.White;
            this.Filter.Location = new System.Drawing.Point(15, 4);
            this.Filter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(33, 13);
            this.Filter.TabIndex = 23;
            this.Filter.Text = "Filter\r\n";
            this.Filter.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(601, 161);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(78, 28);
            this.panel4.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Edit";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(691, 160);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(78, 28);
            this.panel7.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tambah";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel8.Controls.Add(this.Refresh);
            this.panel8.Location = new System.Drawing.Point(270, 167);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(66, 21);
            this.panel8.TabIndex = 29;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Refresh
            // 
            this.Refresh.AutoSize = true;
            this.Refresh.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold);
            this.Refresh.Location = new System.Drawing.Point(15, 4);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(46, 13);
            this.Refresh.TabIndex = 0;
            this.Refresh.Text = "Refresh";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel9.Controls.Add(this.HapusSiswa);
            this.panel9.Location = new System.Drawing.Point(510, 161);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(78, 28);
            this.panel9.TabIndex = 30;
            // 
            // HapusSiswa
            // 
            this.HapusSiswa.AutoSize = true;
            this.HapusSiswa.BackColor = System.Drawing.Color.RoyalBlue;
            this.HapusSiswa.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HapusSiswa.ForeColor = System.Drawing.Color.White;
            this.HapusSiswa.Location = new System.Drawing.Point(19, 8);
            this.HapusSiswa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HapusSiswa.Name = "HapusSiswa";
            this.HapusSiswa.Size = new System.Drawing.Size(40, 13);
            this.HapusSiswa.TabIndex = 23;
            this.HapusSiswa.Text = "Hapus";
            this.HapusSiswa.Click += new System.EventHandler(this.HapusSiswa_Click);
            // 
            // DaftarSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectFilter);
            this.Controls.Add(this.dataGridDaftarSiswa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DaftarSiswa";
            this.Text = "DaftarSiswa";
            this.Load += new System.EventHandler(this.DaftarSiswa_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDaftarSiswa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementDataSetBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridDaftarSiswa;
        private System.Windows.Forms.BindingSource schoolManagementDataSetBindingSource;
        private SchoolManagementDataSet schoolManagementDataSet;
        private SchoolManagementDataSet1 schoolManagementDataSet1;
        private System.Windows.Forms.BindingSource siswaBindingSource;
        private SchoolManagementDataSet1TableAdapters.SiswaTableAdapter siswaTableAdapter;
        private System.Windows.Forms.ComboBox SelectFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Filter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label Refresh;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label HapusSiswa;
    }
}