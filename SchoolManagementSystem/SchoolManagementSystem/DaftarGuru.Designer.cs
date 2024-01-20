namespace SchoolManagementSystem
{
    partial class DaftarGuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaftarGuru));
            this.label9 = new System.Windows.Forms.Label();
            this.FormAlamat = new System.Windows.Forms.TextBox();
            this.FormKelamin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FormTglLahir = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FormNIP = new System.Windows.Forms.TextBox();
            this.FormNama = new System.Windows.Forms.TextBox();
            this.hapusGuru = new System.Windows.Forms.Label();
            this.editGuru = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Kehadiran = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Kompensasi = new System.Windows.Forms.Label();
            this.dataGridDaftarGuru = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolManagementDataSet1 = new SchoolManagementSystem.SchoolManagementDataSet1();
            this.schoolManagementDataSet = new SchoolManagementSystem.SchoolManagementDataSet();
            this.schoolManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siswaTableAdapter = new SchoolManagementSystem.SchoolManagementDataSet1TableAdapters.SiswaTableAdapter();
            this.FormNoTelp = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tambahGuru = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDaftarGuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementDataSetBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.label9.Size = new System.Drawing.Size(35, 21);
            this.label9.TabIndex = 75;
            this.label9.Text = "NIP";
            // 
            // FormAlamat
            // 
            this.FormAlamat.Location = new System.Drawing.Point(509, 149);
            this.FormAlamat.Multiline = true;
            this.FormAlamat.Name = "FormAlamat";
            this.FormAlamat.Size = new System.Drawing.Size(264, 84);
            this.FormAlamat.TabIndex = 74;
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
            this.FormKelamin.TabIndex = 73;
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
            this.label5.TabIndex = 72;
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
            this.label8.TabIndex = 71;
            this.label8.Text = "Jenis Kelamin";
            // 
            // FormTglLahir
            // 
            this.FormTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FormTglLahir.Location = new System.Drawing.Point(271, 149);
            this.FormTglLahir.Name = "FormTglLahir";
            this.FormTglLahir.Size = new System.Drawing.Size(197, 22);
            this.FormTglLahir.TabIndex = 70;
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
            this.label10.TabIndex = 69;
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
            this.label11.Size = new System.Drawing.Size(119, 21);
            this.label11.TabIndex = 68;
            this.label11.Text = "Nomor Telepon";
            // 
            // FormNIP
            // 
            this.FormNIP.Location = new System.Drawing.Point(27, 149);
            this.FormNIP.Name = "FormNIP";
            this.FormNIP.Size = new System.Drawing.Size(197, 22);
            this.FormNIP.TabIndex = 76;
            // 
            // FormNama
            // 
            this.FormNama.Location = new System.Drawing.Point(27, 212);
            this.FormNama.Name = "FormNama";
            this.FormNama.Size = new System.Drawing.Size(197, 22);
            this.FormNama.TabIndex = 67;
            // 
            // hapusGuru
            // 
            this.hapusGuru.AutoSize = true;
            this.hapusGuru.BackColor = System.Drawing.Color.RoyalBlue;
            this.hapusGuru.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusGuru.ForeColor = System.Drawing.Color.White;
            this.hapusGuru.Location = new System.Drawing.Point(17, 7);
            this.hapusGuru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hapusGuru.Name = "hapusGuru";
            this.hapusGuru.Size = new System.Drawing.Size(40, 13);
            this.hapusGuru.TabIndex = 23;
            this.hapusGuru.Text = "Hapus";
            this.hapusGuru.Click += new System.EventHandler(this.hapusGuru_Click);
            // 
            // editGuru
            // 
            this.editGuru.AutoSize = true;
            this.editGuru.BackColor = System.Drawing.Color.RoyalBlue;
            this.editGuru.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGuru.ForeColor = System.Drawing.Color.White;
            this.editGuru.Location = new System.Drawing.Point(26, 6);
            this.editGuru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editGuru.Name = "editGuru";
            this.editGuru.Size = new System.Drawing.Size(27, 13);
            this.editGuru.TabIndex = 23;
            this.editGuru.Text = "Edit";
            this.editGuru.Click += new System.EventHandler(this.editGuru_Click);
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
            this.label12.Size = new System.Drawing.Size(91, 21);
            this.label12.TabIndex = 66;
            this.label12.Text = "Nama Guru";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel9.Controls.Add(this.hapusGuru);
            this.panel9.Location = new System.Drawing.Point(514, 269);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(78, 28);
            this.panel9.TabIndex = 64;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.editGuru);
            this.panel4.Location = new System.Drawing.Point(605, 269);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(78, 28);
            this.panel4.TabIndex = 62;
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
            this.panel6.TabIndex = 58;
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
            this.panel5.Controls.Add(this.Kehadiran);
            this.panel5.Location = new System.Drawing.Point(601, 28);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(78, 28);
            this.panel5.TabIndex = 27;
            // 
            // Kehadiran
            // 
            this.Kehadiran.AutoSize = true;
            this.Kehadiran.BackColor = System.Drawing.Color.RoyalBlue;
            this.Kehadiran.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kehadiran.ForeColor = System.Drawing.Color.White;
            this.Kehadiran.Location = new System.Drawing.Point(13, 7);
            this.Kehadiran.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Kehadiran.Name = "Kehadiran";
            this.Kehadiran.Size = new System.Drawing.Size(60, 13);
            this.Kehadiran.TabIndex = 23;
            this.Kehadiran.Text = "Kehadiran";
            this.Kehadiran.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.Kompensasi);
            this.panel3.Location = new System.Drawing.Point(691, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(82, 28);
            this.panel3.TabIndex = 26;
            // 
            // Kompensasi
            // 
            this.Kompensasi.AutoSize = true;
            this.Kompensasi.BackColor = System.Drawing.Color.RoyalBlue;
            this.Kompensasi.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kompensasi.ForeColor = System.Drawing.Color.White;
            this.Kompensasi.Location = new System.Drawing.Point(8, 6);
            this.Kompensasi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Kompensasi.Name = "Kompensasi";
            this.Kompensasi.Size = new System.Drawing.Size(70, 13);
            this.Kompensasi.TabIndex = 24;
            this.Kompensasi.Text = "Kompensasi";
            this.Kompensasi.Click += new System.EventHandler(this.Kompensasi_Click);
            // 
            // dataGridDaftarGuru
            // 
            this.dataGridDaftarGuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDaftarGuru.Location = new System.Drawing.Point(27, 332);
            this.dataGridDaftarGuru.Name = "dataGridDaftarGuru";
            this.dataGridDaftarGuru.Size = new System.Drawing.Size(747, 306);
            this.dataGridDaftarGuru.TabIndex = 59;
            this.dataGridDaftarGuru.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridDaftarGuru_CellMouseDoubleClick);
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
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Daftar Guru";
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
            // FormNoTelp
            // 
            this.FormNoTelp.Location = new System.Drawing.Point(271, 212);
            this.FormNoTelp.Name = "FormNoTelp";
            this.FormNoTelp.Size = new System.Drawing.Size(197, 22);
            this.FormNoTelp.TabIndex = 78;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.tambahGuru);
            this.panel2.Location = new System.Drawing.Point(696, 268);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(78, 28);
            this.panel2.TabIndex = 64;
            // 
            // tambahGuru
            // 
            this.tambahGuru.AutoSize = true;
            this.tambahGuru.BackColor = System.Drawing.Color.RoyalBlue;
            this.tambahGuru.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahGuru.ForeColor = System.Drawing.Color.White;
            this.tambahGuru.Location = new System.Drawing.Point(15, 8);
            this.tambahGuru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tambahGuru.Name = "tambahGuru";
            this.tambahGuru.Size = new System.Drawing.Size(49, 13);
            this.tambahGuru.TabIndex = 23;
            this.tambahGuru.Text = "Tambah";
            this.tambahGuru.Click += new System.EventHandler(this.tambahGuru_Click);
            // 
            // DaftarGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FormNoTelp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FormAlamat);
            this.Controls.Add(this.FormKelamin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FormTglLahir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FormNIP);
            this.Controls.Add(this.FormNama);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dataGridDaftarGuru);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DaftarGuru";
            this.Text = "ListGuru";
            this.Load += new System.EventHandler(this.DaftarGuru_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDaftarGuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementDataSetBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FormAlamat;
        private System.Windows.Forms.ComboBox FormKelamin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker FormTglLahir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox FormNIP;
        private System.Windows.Forms.TextBox FormNama;
        private System.Windows.Forms.Label hapusGuru;
        private System.Windows.Forms.Label editGuru;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Kehadiran;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Kompensasi;
        private System.Windows.Forms.DataGridView dataGridDaftarGuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource siswaBindingSource;
        private SchoolManagementDataSet1 schoolManagementDataSet1;
        private SchoolManagementDataSet schoolManagementDataSet;
        private System.Windows.Forms.BindingSource schoolManagementDataSetBindingSource;
        private SchoolManagementDataSet1TableAdapters.SiswaTableAdapter siswaTableAdapter;
        private System.Windows.Forms.TextBox FormNoTelp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label tambahGuru;
    }
}