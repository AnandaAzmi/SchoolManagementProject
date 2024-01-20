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
            this.panel4 = new System.Windows.Forms.Panel();
            this.editSiswa = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tambahSiswa = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Refresh = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.HapusSiswa = new System.Windows.Forms.Label();
            this.FormKelas = new System.Windows.Forms.ComboBox();
            this.FormNISN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FormAlamat = new System.Windows.Forms.TextBox();
            this.FormKelamin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FormTglLahir = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FormNama = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.dataGridDaftarSiswa.Location = new System.Drawing.Point(27, 376);
            this.dataGridDaftarSiswa.Name = "dataGridDaftarSiswa";
            this.dataGridDaftarSiswa.Size = new System.Drawing.Size(747, 262);
            this.dataGridDaftarSiswa.TabIndex = 28;
            this.dataGridDaftarSiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridDaftarSiswa.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridDaftarSiswa_CellMouseDoubleClick);
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
            this.SelectFilter.Location = new System.Drawing.Point(27, 349);
            this.SelectFilter.Name = "SelectFilter";
            this.SelectFilter.Size = new System.Drawing.Size(159, 21);
            this.SelectFilter.TabIndex = 29;
            this.SelectFilter.SelectionChangeCommitted += new System.EventHandler(this.SelectFilter_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kelas\r\n";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.editSiswa);
            this.panel4.Location = new System.Drawing.Point(605, 269);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(78, 28);
            this.panel4.TabIndex = 29;
            // 
            // editSiswa
            // 
            this.editSiswa.AutoSize = true;
            this.editSiswa.BackColor = System.Drawing.Color.RoyalBlue;
            this.editSiswa.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSiswa.ForeColor = System.Drawing.Color.White;
            this.editSiswa.Location = new System.Drawing.Point(26, 6);
            this.editSiswa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editSiswa.Name = "editSiswa";
            this.editSiswa.Size = new System.Drawing.Size(27, 13);
            this.editSiswa.TabIndex = 23;
            this.editSiswa.Text = "Edit";
            this.editSiswa.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Controls.Add(this.tambahSiswa);
            this.panel7.Location = new System.Drawing.Point(695, 268);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(78, 28);
            this.panel7.TabIndex = 30;
            // 
            // tambahSiswa
            // 
            this.tambahSiswa.AutoSize = true;
            this.tambahSiswa.BackColor = System.Drawing.Color.RoyalBlue;
            this.tambahSiswa.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahSiswa.ForeColor = System.Drawing.Color.White;
            this.tambahSiswa.Location = new System.Drawing.Point(15, 8);
            this.tambahSiswa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tambahSiswa.Name = "tambahSiswa";
            this.tambahSiswa.Size = new System.Drawing.Size(49, 13);
            this.tambahSiswa.TabIndex = 23;
            this.tambahSiswa.Text = "Tambah";
            this.tambahSiswa.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel8.Controls.Add(this.Refresh);
            this.panel8.Location = new System.Drawing.Point(191, 349);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 21);
            this.panel8.TabIndex = 29;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Refresh
            // 
            this.Refresh.AutoSize = true;
            this.Refresh.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold);
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.Location = new System.Drawing.Point(15, 4);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(69, 13);
            this.Refresh.TabIndex = 0;
            this.Refresh.Text = "Hapus Filter";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel9.Controls.Add(this.HapusSiswa);
            this.panel9.Location = new System.Drawing.Point(514, 269);
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
            this.HapusSiswa.Location = new System.Drawing.Point(17, 7);
            this.HapusSiswa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HapusSiswa.Name = "HapusSiswa";
            this.HapusSiswa.Size = new System.Drawing.Size(40, 13);
            this.HapusSiswa.TabIndex = 23;
            this.HapusSiswa.Text = "Hapus";
            this.HapusSiswa.Click += new System.EventHandler(this.HapusSiswa_Click);
            // 
            // FormKelas
            // 
            this.FormKelas.FormattingEnabled = true;
            this.FormKelas.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.FormKelas.Location = new System.Drawing.Point(271, 212);
            this.FormKelas.Name = "FormKelas";
            this.FormKelas.Size = new System.Drawing.Size(197, 21);
            this.FormKelas.TabIndex = 56;
            // 
            // FormNISN
            // 
            this.FormNISN.Location = new System.Drawing.Point(27, 149);
            this.FormNISN.Name = "FormNISN";
            this.FormNISN.Size = new System.Drawing.Size(197, 20);
            this.FormNISN.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 21);
            this.label9.TabIndex = 54;
            this.label9.Text = "NISN";
            // 
            // FormAlamat
            // 
            this.FormAlamat.Location = new System.Drawing.Point(509, 149);
            this.FormAlamat.Multiline = true;
            this.FormAlamat.Name = "FormAlamat";
            this.FormAlamat.Size = new System.Drawing.Size(264, 84);
            this.FormAlamat.TabIndex = 53;
            // 
            // FormKelamin
            // 
            this.FormKelamin.FormattingEnabled = true;
            this.FormKelamin.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.FormKelamin.Location = new System.Drawing.Point(27, 275);
            this.FormKelamin.Name = "FormKelamin";
            this.FormKelamin.Size = new System.Drawing.Size(197, 21);
            this.FormKelamin.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(506, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 51;
            this.label5.Text = "Alamat Rumah";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 50;
            this.label8.Text = "Jenis Kelamin";
            // 
            // FormTglLahir
            // 
            this.FormTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FormTglLahir.Location = new System.Drawing.Point(271, 149);
            this.FormTglLahir.Name = "FormTglLahir";
            this.FormTglLahir.Size = new System.Drawing.Size(197, 20);
            this.FormTglLahir.TabIndex = 49;
            this.FormTglLahir.Value = new System.DateTime(2024, 1, 9, 8, 15, 18, 0);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(267, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 48;
            this.label10.Text = "Tgl Lahir";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(267, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 21);
            this.label11.TabIndex = 47;
            this.label11.Text = "Kelas";
            // 
            // FormNama
            // 
            this.FormNama.Location = new System.Drawing.Point(27, 212);
            this.FormNama.Name = "FormNama";
            this.FormNama.Size = new System.Drawing.Size(197, 20);
            this.FormNama.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 21);
            this.label12.TabIndex = 45;
            this.label12.Text = "Nama Siswa";
            // 
            // DaftarSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.FormKelas);
            this.Controls.Add(this.FormNISN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FormAlamat);
            this.Controls.Add(this.FormKelamin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FormTglLahir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FormNama);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label editSiswa;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label tambahSiswa;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label Refresh;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label HapusSiswa;
        private System.Windows.Forms.ComboBox FormKelas;
        private System.Windows.Forms.TextBox FormNISN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FormAlamat;
        private System.Windows.Forms.ComboBox FormKelamin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker FormTglLahir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox FormNama;
        private System.Windows.Forms.Label label12;
    }
}