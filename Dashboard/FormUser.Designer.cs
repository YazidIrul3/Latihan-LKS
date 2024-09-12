namespace Dashboard
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_KelolaUser = new System.Windows.Forms.Button();
            this.Btn_KelolaLaporan = new System.Windows.Forms.Button();
            this.Btn_LogActivity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Tambah = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Hapus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbluserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lKSMartDataSet = new Dashboard.LKSMartDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.dataSet1 = new Dashboard.DataSet1();
            this.tbl_userTableAdapter = new Dashboard.LKSMartDataSetTableAdapters.tbl_userTableAdapter();
            this.Txt_Username = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Alamat = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Telepon = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Password = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Nama = new System.Windows.Forms.MaskedTextBox();
            this.Txt_TipeUser = new System.Windows.Forms.MaskedTextBox();
            this.fOODXYZDataSet = new Dashboard.FOODXYZDataSet();
            this.tbluserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_userTableAdapter1 = new Dashboard.FOODXYZDataSetTableAdapters.tbl_userTableAdapter();
            this.tbluserBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKSMartDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODXYZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Btn_KelolaUser);
            this.panel1.Controls.Add(this.Btn_KelolaLaporan);
            this.panel1.Controls.Add(this.Btn_LogActivity);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 782);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(112, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 44);
            this.label10.TabIndex = 11;
            this.label10.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(107, 678);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_KelolaUser
            // 
            this.Btn_KelolaUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.Btn_KelolaUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_KelolaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_KelolaUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_KelolaUser.Location = new System.Drawing.Point(48, 438);
            this.Btn_KelolaUser.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_KelolaUser.Name = "Btn_KelolaUser";
            this.Btn_KelolaUser.Size = new System.Drawing.Size(236, 54);
            this.Btn_KelolaUser.TabIndex = 7;
            this.Btn_KelolaUser.Text = "Kelola User";
            this.Btn_KelolaUser.UseVisualStyleBackColor = false;
            this.Btn_KelolaUser.Click += new System.EventHandler(this.Btn_LogActivity_Click);
            // 
            // Btn_KelolaLaporan
            // 
            this.Btn_KelolaLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.Btn_KelolaLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_KelolaLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_KelolaLaporan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_KelolaLaporan.Location = new System.Drawing.Point(48, 512);
            this.Btn_KelolaLaporan.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_KelolaLaporan.Name = "Btn_KelolaLaporan";
            this.Btn_KelolaLaporan.Size = new System.Drawing.Size(236, 54);
            this.Btn_KelolaLaporan.TabIndex = 5;
            this.Btn_KelolaLaporan.Text = "Kelola Laporan";
            this.Btn_KelolaLaporan.UseVisualStyleBackColor = false;
            this.Btn_KelolaLaporan.Click += new System.EventHandler(this.Btn_KelolaLaporan_Click);
            // 
            // Btn_LogActivity
            // 
            this.Btn_LogActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.Btn_LogActivity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_LogActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LogActivity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_LogActivity.Location = new System.Drawing.Point(48, 589);
            this.Btn_LogActivity.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_LogActivity.Name = "Btn_LogActivity";
            this.Btn_LogActivity.Size = new System.Drawing.Size(236, 54);
            this.Btn_LogActivity.TabIndex = 4;
            this.Btn_LogActivity.Text = "Log Activity";
            this.Btn_LogActivity.UseVisualStyleBackColor = false;
            this.Btn_LogActivity.Click += new System.EventHandler(this.Btn_LogActivity_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(387, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pages /Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(384, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kelola User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipe User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telepon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(448, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(780, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(780, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Password";
            // 
            // Btn_Tambah
            // 
            this.Btn_Tambah.BackColor = System.Drawing.Color.Green;
            this.Btn_Tambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Tambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Tambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Tambah.Location = new System.Drawing.Point(784, 255);
            this.Btn_Tambah.Name = "Btn_Tambah";
            this.Btn_Tambah.Size = new System.Drawing.Size(93, 40);
            this.Btn_Tambah.TabIndex = 17;
            this.Btn_Tambah.Text = "Tambah";
            this.Btn_Tambah.UseVisualStyleBackColor = false;
            this.Btn_Tambah.Click += new System.EventHandler(this.Btn_Tambah_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.Olive;
            this.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Edit.Location = new System.Drawing.Point(897, 255);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(93, 40);
            this.Btn_Edit.TabIndex = 18;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Hapus
            // 
            this.Btn_Hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Hapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Hapus.Location = new System.Drawing.Point(1009, 255);
            this.Btn_Hapus.Name = "Btn_Hapus";
            this.Btn_Hapus.Size = new System.Drawing.Size(93, 40);
            this.Btn_Hapus.TabIndex = 19;
            this.Btn_Hapus.Text = "Hapus";
            this.Btn_Hapus.UseVisualStyleBackColor = false;
            this.Btn_Hapus.Click += new System.EventHandler(this.Btn_Hapus_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(354, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 321);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(964, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(826, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(180, 34);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iduserDataGridViewTextBoxColumn,
            this.tipeuserDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.teleponDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbluserBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(82, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(924, 235);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "id_user";
            this.iduserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.ReadOnly = true;
            this.iduserDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipeuserDataGridViewTextBoxColumn
            // 
            this.tipeuserDataGridViewTextBoxColumn.DataPropertyName = "tipe_user";
            this.tipeuserDataGridViewTextBoxColumn.HeaderText = "tipe_user";
            this.tipeuserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipeuserDataGridViewTextBoxColumn.Name = "tipeuserDataGridViewTextBoxColumn";
            this.tipeuserDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // teleponDataGridViewTextBoxColumn
            // 
            this.teleponDataGridViewTextBoxColumn.DataPropertyName = "telepon";
            this.teleponDataGridViewTextBoxColumn.HeaderText = "telepon";
            this.teleponDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teleponDataGridViewTextBoxColumn.Name = "teleponDataGridViewTextBoxColumn";
            this.teleponDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbluserBindingSource
            // 
            this.tbluserBindingSource.DataMember = "tbl_user";
            this.tbluserBindingSource.DataSource = this.lKSMartDataSet;
            // 
            // lKSMartDataSet
            // 
            this.lKSMartDataSet.DataSetName = "LKSMartDataSet";
            this.lKSMartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label9.Location = new System.Drawing.Point(30, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 31);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tabel User";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_userTableAdapter
            // 
            this.tbl_userTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_Username
            // 
            this.Txt_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_Username.Location = new System.Drawing.Point(784, 130);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(240, 22);
            this.Txt_Username.TabIndex = 14;
            this.Txt_Username.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // Txt_Alamat
            // 
            this.Txt_Alamat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Alamat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_Alamat.Location = new System.Drawing.Point(452, 375);
            this.Txt_Alamat.Name = "Txt_Alamat";
            this.Txt_Alamat.Size = new System.Drawing.Size(240, 22);
            this.Txt_Alamat.TabIndex = 12;
            this.Txt_Alamat.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // Txt_Telepon
            // 
            this.Txt_Telepon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Telepon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_Telepon.Location = new System.Drawing.Point(452, 295);
            this.Txt_Telepon.Name = "Txt_Telepon";
            this.Txt_Telepon.Size = new System.Drawing.Size(240, 22);
            this.Txt_Telepon.TabIndex = 10;
            this.Txt_Telepon.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // Txt_Password
            // 
            this.Txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_Password.Location = new System.Drawing.Point(784, 212);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(240, 22);
            this.Txt_Password.TabIndex = 16;
            this.Txt_Password.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.Txt_Password.UseSystemPasswordChar = true;
            // 
            // Txt_Nama
            // 
            this.Txt_Nama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Nama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_Nama.Location = new System.Drawing.Point(452, 212);
            this.Txt_Nama.Name = "Txt_Nama";
            this.Txt_Nama.Size = new System.Drawing.Size(240, 22);
            this.Txt_Nama.TabIndex = 8;
            this.Txt_Nama.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // Txt_TipeUser
            // 
            this.Txt_TipeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_TipeUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_TipeUser.Location = new System.Drawing.Point(452, 130);
            this.Txt_TipeUser.Name = "Txt_TipeUser";
            this.Txt_TipeUser.Size = new System.Drawing.Size(240, 22);
            this.Txt_TipeUser.TabIndex = 6;
            this.Txt_TipeUser.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.Txt_TipeUser.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_TipeUser_MaskInputRejected);
            // 
            // fOODXYZDataSet
            // 
            this.fOODXYZDataSet.DataSetName = "FOODXYZDataSet";
            this.fOODXYZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbluserBindingSource1
            // 
            this.tbluserBindingSource1.DataMember = "tbl_user";
            this.tbluserBindingSource1.DataSource = this.fOODXYZDataSet;
            // 
            // tbl_userTableAdapter1
            // 
            this.tbl_userTableAdapter1.ClearBeforeFill = true;
            // 
            // tbluserBindingSource2
            // 
            this.tbluserBindingSource2.DataMember = "tbl_user";
            this.tbluserBindingSource2.DataSource = this.fOODXYZDataSet;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 755);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_Hapus);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Tambah);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_Username);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Alamat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Telepon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Nama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_TipeUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormUser";
            this.Text = "i8";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKSMartDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODXYZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_KelolaUser;
        private System.Windows.Forms.Button Btn_KelolaLaporan;
        private System.Windows.Forms.Button Btn_LogActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Tambah;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Hapus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DataSet1 dataSet1;
        private LKSMartDataSet lKSMartDataSet;
        private System.Windows.Forms.BindingSource tbluserBindingSource;
        private LKSMartDataSetTableAdapters.tbl_userTableAdapter tbl_userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox Txt_Username;
        private System.Windows.Forms.MaskedTextBox Txt_Alamat;
        private System.Windows.Forms.MaskedTextBox Txt_Telepon;
        private System.Windows.Forms.MaskedTextBox Txt_Password;
        private System.Windows.Forms.MaskedTextBox Txt_Nama;
        private System.Windows.Forms.MaskedTextBox Txt_TipeUser;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FOODXYZDataSet fOODXYZDataSet;
        private System.Windows.Forms.BindingSource tbluserBindingSource1;
        private FOODXYZDataSetTableAdapters.tbl_userTableAdapter tbl_userTableAdapter1;
        private System.Windows.Forms.BindingSource tbluserBindingSource2;
    }
}