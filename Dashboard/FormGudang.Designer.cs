namespace Dashboard
{
    partial class FormGudang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_KodeBarang = new System.Windows.Forms.MaskedTextBox();
            this.Txt_JumlahBarang = new System.Windows.Forms.MaskedTextBox();
            this.Txt_NamaBarang = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Satuan = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_HargaSatuan = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_Hapus = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Tambah = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_Search = new System.Windows.Forms.RichTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tblbarangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fOODXYZDataSet = new Dashboard.FOODXYZDataSet();
            this.tblbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lKSMartDataSet1 = new Dashboard.LKSMartDataSet1();
            this.tbl_barangTableAdapter = new Dashboard.LKSMartDataSet1TableAdapters.tbl_barangTableAdapter();
            this.expire_date = new System.Windows.Forms.DateTimePicker();
            this.tbl_barangTableAdapter1 = new Dashboard.FOODXYZDataSetTableAdapters.tbl_barangTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODXYZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKSMartDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 732);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(75, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "BARANG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(74, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "GUDANG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(85, 415);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label4.Location = new System.Drawing.Point(340, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "KELOLA BARANG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label5.Location = new System.Drawing.Point(343, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pages /Dashboard";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kode Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Jumlah Barang";
            // 
            // Txt_KodeBarang
            // 
            this.Txt_KodeBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_KodeBarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_KodeBarang.Location = new System.Drawing.Point(508, 100);
            this.Txt_KodeBarang.Name = "Txt_KodeBarang";
            this.Txt_KodeBarang.Size = new System.Drawing.Size(358, 22);
            this.Txt_KodeBarang.TabIndex = 13;
            this.Txt_KodeBarang.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // Txt_JumlahBarang
            // 
            this.Txt_JumlahBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_JumlahBarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_JumlahBarang.Location = new System.Drawing.Point(508, 149);
            this.Txt_JumlahBarang.Name = "Txt_JumlahBarang";
            this.Txt_JumlahBarang.Size = new System.Drawing.Size(358, 22);
            this.Txt_JumlahBarang.TabIndex = 14;
            this.Txt_JumlahBarang.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.Txt_JumlahBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_JumlahBarang_KeyPress);
            // 
            // Txt_NamaBarang
            // 
            this.Txt_NamaBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_NamaBarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_NamaBarang.Location = new System.Drawing.Point(508, 201);
            this.Txt_NamaBarang.Name = "Txt_NamaBarang";
            this.Txt_NamaBarang.Size = new System.Drawing.Size(358, 22);
            this.Txt_NamaBarang.TabIndex = 16;
            this.Txt_NamaBarang.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(351, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nama Barang";
            // 
            // Txt_Satuan
            // 
            this.Txt_Satuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Satuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_Satuan.Location = new System.Drawing.Point(508, 249);
            this.Txt_Satuan.Name = "Txt_Satuan";
            this.Txt_Satuan.Size = new System.Drawing.Size(358, 22);
            this.Txt_Satuan.TabIndex = 18;
            this.Txt_Satuan.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.Txt_Satuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Satuan_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(351, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Satuan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(351, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Expired Data";
            // 
            // Txt_HargaSatuan
            // 
            this.Txt_HargaSatuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_HargaSatuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_HargaSatuan.Location = new System.Drawing.Point(508, 346);
            this.Txt_HargaSatuan.Name = "Txt_HargaSatuan";
            this.Txt_HargaSatuan.Size = new System.Drawing.Size(358, 22);
            this.Txt_HargaSatuan.TabIndex = 22;
            this.Txt_HargaSatuan.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.Txt_HargaSatuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_HargaSatuan_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(351, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Harga Satuan";
            // 
            // Btn_Hapus
            // 
            this.Btn_Hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Hapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Hapus.Location = new System.Drawing.Point(943, 279);
            this.Btn_Hapus.Name = "Btn_Hapus";
            this.Btn_Hapus.Size = new System.Drawing.Size(93, 40);
            this.Btn_Hapus.TabIndex = 25;
            this.Btn_Hapus.Text = "Hapus";
            this.Btn_Hapus.UseVisualStyleBackColor = false;
            this.Btn_Hapus.Click += new System.EventHandler(this.Btn_Hapus_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.Olive;
            this.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Edit.Location = new System.Drawing.Point(943, 201);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(93, 40);
            this.Btn_Edit.TabIndex = 24;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Tambah
            // 
            this.Btn_Tambah.BackColor = System.Drawing.Color.Green;
            this.Btn_Tambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Tambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Tambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Tambah.Location = new System.Drawing.Point(943, 131);
            this.Btn_Tambah.Name = "Btn_Tambah";
            this.Btn_Tambah.Size = new System.Drawing.Size(93, 40);
            this.Btn_Tambah.TabIndex = 23;
            this.Btn_Tambah.Text = "Tambah";
            this.Btn_Tambah.UseVisualStyleBackColor = false;
            this.Btn_Tambah.Click += new System.EventHandler(this.Btn_Tambah_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Txt_Search);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.Btn_Search);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(355, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 305);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Txt_Search
            // 
            this.Txt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Search.Location = new System.Drawing.Point(604, 16);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(180, 34);
            this.Txt_Search.TabIndex = 29;
            this.Txt_Search.Text = "";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(930, 220);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Search.Location = new System.Drawing.Point(811, 12);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(102, 38);
            this.Btn_Search.TabIndex = 21;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label12.Location = new System.Drawing.Point(19, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 31);
            this.label12.TabIndex = 9;
            this.label12.Text = "Tabel User";
            // 
            // tblbarangBindingSource1
            // 
            this.tblbarangBindingSource1.DataMember = "tbl_barang";
            this.tblbarangBindingSource1.DataSource = this.fOODXYZDataSet;
            // 
            // fOODXYZDataSet
            // 
            this.fOODXYZDataSet.DataSetName = "FOODXYZDataSet";
            this.fOODXYZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblbarangBindingSource
            // 
            this.tblbarangBindingSource.DataMember = "tbl_barang";
            this.tblbarangBindingSource.DataSource = this.lKSMartDataSet1;
            // 
            // lKSMartDataSet1
            // 
            this.lKSMartDataSet1.DataSetName = "LKSMartDataSet1";
            this.lKSMartDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_barangTableAdapter
            // 
            this.tbl_barangTableAdapter.ClearBeforeFill = true;
            // 
            // expire_date
            // 
            this.expire_date.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.expire_date.CustomFormat = "yyyy/MM/dd";
            this.expire_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expire_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expire_date.Location = new System.Drawing.Point(508, 297);
            this.expire_date.Name = "expire_date";
            this.expire_date.Size = new System.Drawing.Size(358, 27);
            this.expire_date.TabIndex = 28;
            this.expire_date.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // tbl_barangTableAdapter1
            // 
            this.tbl_barangTableAdapter1.ClearBeforeFill = true;
            // 
            // FormGudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 771);
            this.Controls.Add(this.expire_date);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_Hapus);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Tambah);
            this.Controls.Add(this.Txt_HargaSatuan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txt_Satuan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txt_NamaBarang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_JumlahBarang);
            this.Controls.Add(this.Txt_KodeBarang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "FormGudang";
            this.Text = "FormGudang";
            this.Load += new System.EventHandler(this.FormGudang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODXYZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKSMartDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox Txt_KodeBarang;
        private System.Windows.Forms.MaskedTextBox Txt_JumlahBarang;
        private System.Windows.Forms.MaskedTextBox Txt_NamaBarang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox Txt_Satuan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox Txt_HargaSatuan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_Hapus;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Tambah;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView2;
        private LKSMartDataSet1 lKSMartDataSet1;
        private System.Windows.Forms.BindingSource tblbarangBindingSource;
        private LKSMartDataSet1TableAdapters.tbl_barangTableAdapter tbl_barangTableAdapter;
        private System.Windows.Forms.DateTimePicker expire_date;
        private FOODXYZDataSet fOODXYZDataSet;
        private System.Windows.Forms.BindingSource tblbarangBindingSource1;
        private FOODXYZDataSetTableAdapters.tbl_barangTableAdapter tbl_barangTableAdapter1;
        private System.Windows.Forms.RichTextBox Txt_Search;
    }
}