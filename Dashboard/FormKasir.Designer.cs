namespace Dashboard
{
    partial class FormKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKasir));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_Tambah = new System.Windows.Forms.Button();
            this.Txt_Quantitias = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_HargaSatuan = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Telepon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_NamaPelanggan = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_TotalHarga = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_Buy = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_kembalian = new System.Windows.Forms.Label();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.Btn_Simpan = new System.Windows.Forms.Button();
            this.Txt_cash = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_PilihMenu = new System.Windows.Forms.ComboBox();
            this.tblbarangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fOODXYZDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOODXYZDataSet = new Dashboard.FOODXYZDataSet();
            this.tblbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_barangTableAdapter = new Dashboard.FOODXYZDataSetTableAdapters.tbl_barangTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODXYZDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODXYZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-1, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 776);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 242);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(48, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "TRANKSAKSI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(101, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "KASIR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(88, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "KELOLA";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(110, 638);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Reset.Location = new System.Drawing.Point(1022, 161);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(93, 40);
            this.Btn_Reset.TabIndex = 33;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = false;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Btn_Tambah
            // 
            this.Btn_Tambah.BackColor = System.Drawing.Color.Green;
            this.Btn_Tambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Tambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Tambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Tambah.Location = new System.Drawing.Point(1022, 115);
            this.Btn_Tambah.Name = "Btn_Tambah";
            this.Btn_Tambah.Size = new System.Drawing.Size(93, 40);
            this.Btn_Tambah.TabIndex = 31;
            this.Btn_Tambah.Text = "Tambah";
            this.Btn_Tambah.UseVisualStyleBackColor = false;
            this.Btn_Tambah.Click += new System.EventHandler(this.Btn_Tambah_Click);
            // 
            // Txt_Quantitias
            // 
            this.Txt_Quantitias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Quantitias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_Quantitias.Location = new System.Drawing.Point(719, 190);
            this.Txt_Quantitias.Name = "Txt_Quantitias";
            this.Txt_Quantitias.Size = new System.Drawing.Size(240, 22);
            this.Txt_Quantitias.TabIndex = 30;
            this.Txt_Quantitias.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.Txt_Quantitias.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_Quantitias_MaskInputRejected);
            this.Txt_Quantitias.TextChanged += new System.EventHandler(this.Txt_Quantitias_TextChanged);
            this.Txt_Quantitias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Quantitias_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(715, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 22);
            this.label8.TabIndex = 29;
            this.label8.Text = "Quantitias";
            // 
            // Txt_HargaSatuan
            // 
            this.Txt_HargaSatuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_HargaSatuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_HargaSatuan.Location = new System.Drawing.Point(719, 115);
            this.Txt_HargaSatuan.Name = "Txt_HargaSatuan";
            this.Txt_HargaSatuan.Size = new System.Drawing.Size(240, 22);
            this.Txt_HargaSatuan.TabIndex = 28;
            this.Txt_HargaSatuan.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(715, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Harga Satuan";
            // 
            // Txt_Telepon
            // 
            this.Txt_Telepon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Telepon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_Telepon.Location = new System.Drawing.Point(387, 190);
            this.Txt_Telepon.Name = "Txt_Telepon";
            this.Txt_Telepon.Size = new System.Drawing.Size(240, 22);
            this.Txt_Telepon.TabIndex = 25;
            this.Txt_Telepon.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.Txt_Telepon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_Telepon_MaskInputRejected);
            this.Txt_Telepon.TextChanged += new System.EventHandler(this.Txt_Telepon_TextChanged);
            this.Txt_Telepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Telepon_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Telepon";
            // 
            // Txt_NamaPelanggan
            // 
            this.Txt_NamaPelanggan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_NamaPelanggan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_NamaPelanggan.Location = new System.Drawing.Point(387, 274);
            this.Txt_NamaPelanggan.Name = "Txt_NamaPelanggan";
            this.Txt_NamaPelanggan.Size = new System.Drawing.Size(240, 22);
            this.Txt_NamaPelanggan.TabIndex = 23;
            this.Txt_NamaPelanggan.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nama Pelanggan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label10.Location = new System.Drawing.Point(361, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(319, 40);
            this.label10.TabIndex = 35;
            this.label10.Text = "FORM TRANKSAKSI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label11.Location = new System.Drawing.Point(364, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 19);
            this.label11.TabIndex = 34;
            this.label11.Text = "Pages /Dashboard";
            // 
            // Txt_TotalHarga
            // 
            this.Txt_TotalHarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_TotalHarga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_TotalHarga.Location = new System.Drawing.Point(719, 274);
            this.Txt_TotalHarga.Name = "Txt_TotalHarga";
            this.Txt_TotalHarga.Size = new System.Drawing.Size(240, 22);
            this.Txt_TotalHarga.TabIndex = 37;
            this.Txt_TotalHarga.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.Txt_TotalHarga.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_TotalHarga_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(715, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "Total Harga";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.labelTotal);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(387, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 293);
            this.panel2.TabIndex = 38;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label16.Location = new System.Drawing.Point(591, 261);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 19);
            this.label16.TabIndex = 14;
            this.label16.Text = "Rp. 0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label15.Location = new System.Drawing.Point(462, 261);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 19);
            this.label15.TabIndex = 13;
            this.label15.Text = "Desc";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.labelTotal.Location = new System.Drawing.Point(591, 242);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(43, 19);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "Rp. 0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label13.Location = new System.Drawing.Point(462, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 19);
            this.label13.TabIndex = 11;
            this.label13.Text = "Total Harga";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(3, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(679, 182);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.TabIndexChanged += new System.EventHandler(this.dataGridView1_TabIndexChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No Transaksi";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kode Barang";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nama Barang";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Harga Satuan";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Qty";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Satuan";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 31);
            this.label12.TabIndex = 9;
            this.label12.Text = "Tabel Transaksi";
            // 
            // Btn_Buy
            // 
            this.Btn_Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Buy.Location = new System.Drawing.Point(387, 674);
            this.Btn_Buy.Name = "Btn_Buy";
            this.Btn_Buy.Size = new System.Drawing.Size(213, 40);
            this.Btn_Buy.TabIndex = 41;
            this.Btn_Buy.Text = "Bayar";
            this.Btn_Buy.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(383, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Pilih Menu";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(383, 717);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 16);
            this.label17.TabIndex = 42;
            this.label17.Text = "Jumlah Kembalian";
            // 
            // label_kembalian
            // 
            this.label_kembalian.AutoSize = true;
            this.label_kembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kembalian.Location = new System.Drawing.Point(522, 717);
            this.label_kembalian.Name = "label_kembalian";
            this.label_kembalian.Size = new System.Drawing.Size(43, 16);
            this.label_kembalian.TabIndex = 43;
            this.label_kembalian.Text = "Rp. 0";
            // 
            // Btn_Print
            // 
            this.Btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.Btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Print.Location = new System.Drawing.Point(846, 628);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(93, 40);
            this.Btn_Print.TabIndex = 44;
            this.Btn_Print.Text = "Print";
            this.Btn_Print.UseVisualStyleBackColor = false;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // Btn_Simpan
            // 
            this.Btn_Simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.Btn_Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Simpan.Location = new System.Drawing.Point(977, 628);
            this.Btn_Simpan.Name = "Btn_Simpan";
            this.Btn_Simpan.Size = new System.Drawing.Size(93, 40);
            this.Btn_Simpan.TabIndex = 45;
            this.Btn_Simpan.Text = "Simpan";
            this.Btn_Simpan.UseVisualStyleBackColor = false;
            this.Btn_Simpan.Click += new System.EventHandler(this.Btn_Simpan_Click);
            // 
            // Txt_cash
            // 
            this.Txt_cash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_cash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_cash.Location = new System.Drawing.Point(385, 646);
            this.Txt_cash.Name = "Txt_cash";
            this.Txt_cash.Size = new System.Drawing.Size(215, 22);
            this.Txt_cash.TabIndex = 46;
            this.Txt_cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_cash.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.Txt_cash.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.Txt_cash.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(168)))), ((int)(((byte)(227)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(385, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 47;
            this.button1.Text = "Cash";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_PilihMenu
            // 
            this.Txt_PilihMenu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblbarangBindingSource1, "kode_barang", true));
            this.Txt_PilihMenu.DataSource = this.tblbarangBindingSource1;
            this.Txt_PilihMenu.DisplayMember = "kode_barang";
            this.Txt_PilihMenu.FormattingEnabled = true;
            this.Txt_PilihMenu.Location = new System.Drawing.Point(385, 115);
            this.Txt_PilihMenu.Name = "Txt_PilihMenu";
            this.Txt_PilihMenu.Size = new System.Drawing.Size(240, 24);
            this.Txt_PilihMenu.TabIndex = 48;
            this.Txt_PilihMenu.ValueMember = "kode_barang";
            this.Txt_PilihMenu.SelectedIndexChanged += new System.EventHandler(this.Txt_PilihMenu_SelectedIndexChanged);
            // 
            // tblbarangBindingSource1
            // 
            this.tblbarangBindingSource1.DataMember = "tbl_barang";
            this.tblbarangBindingSource1.DataSource = this.fOODXYZDataSetBindingSource;
            // 
            // fOODXYZDataSetBindingSource
            // 
            this.fOODXYZDataSetBindingSource.DataSource = this.fOODXYZDataSet;
            this.fOODXYZDataSetBindingSource.Position = 0;
            // 
            // fOODXYZDataSet
            // 
            this.fOODXYZDataSet.DataSetName = "FOODXYZDataSet";
            this.fOODXYZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblbarangBindingSource
            // 
            this.tblbarangBindingSource.DataMember = "tbl_barang";
            this.tblbarangBindingSource.DataSource = this.fOODXYZDataSet;
            // 
            // tbl_barangTableAdapter
            // 
            this.tbl_barangTableAdapter.ClearBeforeFill = true;
            // 
            // FormKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 847);
            this.Controls.Add(this.Txt_PilihMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_cash);
            this.Controls.Add(this.Btn_Simpan);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.label_kembalian);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Btn_Buy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Txt_TotalHarga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Btn_Tambah);
            this.Controls.Add(this.Txt_Quantitias);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_HargaSatuan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Telepon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_NamaPelanggan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Name = "FormKasir";
            this.Text = "Kasir";
            this.Load += new System.EventHandler(this.FormKasir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODXYZDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODXYZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_Tambah;
        private System.Windows.Forms.MaskedTextBox Txt_Quantitias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox Txt_HargaSatuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox Txt_Telepon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Txt_NamaPelanggan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox Txt_TotalHarga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button Btn_Buy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_kembalian;
        private System.Windows.Forms.Button Btn_Print;
        private System.Windows.Forms.Button Btn_Simpan;
        private System.Windows.Forms.MaskedTextBox Txt_cash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Txt_PilihMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private FOODXYZDataSet fOODXYZDataSet;
        private System.Windows.Forms.BindingSource tblbarangBindingSource;
        private FOODXYZDataSetTableAdapters.tbl_barangTableAdapter tbl_barangTableAdapter;
        private System.Windows.Forms.BindingSource tblbarangBindingSource1;
        private System.Windows.Forms.BindingSource fOODXYZDataSetBindingSource;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}