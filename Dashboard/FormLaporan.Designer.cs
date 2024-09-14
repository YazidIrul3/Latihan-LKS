namespace Dashboard
{
    partial class FormLaporan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaporan));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_KelolaLaporan = new System.Windows.Forms.Button();
            this.Btn_KelolaUser = new System.Windows.Forms.Button();
            this.Btn_LogActivity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Filter = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbltranksaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOODXYZDataSet = new Dashboard.FOODXYZDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Generate = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.tbl_tranksaksiTableAdapter = new Dashboard.FOODXYZDataSetTableAdapters.tbl_tranksaksiTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltranksaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODXYZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Btn_KelolaLaporan);
            this.panel1.Controls.Add(this.Btn_KelolaUser);
            this.panel1.Controls.Add(this.Btn_LogActivity);
            this.panel1.Location = new System.Drawing.Point(-41, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 788);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(139, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 44);
            this.label5.TabIndex = 9;
            this.label5.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(147, 713);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_KelolaLaporan
            // 
            this.Btn_KelolaLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.Btn_KelolaLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_KelolaLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_KelolaLaporan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_KelolaLaporan.Location = new System.Drawing.Point(88, 550);
            this.Btn_KelolaLaporan.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_KelolaLaporan.Name = "Btn_KelolaLaporan";
            this.Btn_KelolaLaporan.Size = new System.Drawing.Size(236, 54);
            this.Btn_KelolaLaporan.TabIndex = 7;
            this.Btn_KelolaLaporan.Text = "Kelola Laporan";
            this.Btn_KelolaLaporan.UseVisualStyleBackColor = false;
            // 
            // Btn_KelolaUser
            // 
            this.Btn_KelolaUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.Btn_KelolaUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_KelolaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_KelolaUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_KelolaUser.Location = new System.Drawing.Point(88, 473);
            this.Btn_KelolaUser.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_KelolaUser.Name = "Btn_KelolaUser";
            this.Btn_KelolaUser.Size = new System.Drawing.Size(236, 54);
            this.Btn_KelolaUser.TabIndex = 5;
            this.Btn_KelolaUser.Text = "Kelola User";
            this.Btn_KelolaUser.UseVisualStyleBackColor = false;
            this.Btn_KelolaUser.Click += new System.EventHandler(this.Btn_KelolaUser_Click);
            // 
            // Btn_LogActivity
            // 
            this.Btn_LogActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.Btn_LogActivity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_LogActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LogActivity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_LogActivity.Location = new System.Drawing.Point(88, 624);
            this.Btn_LogActivity.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_LogActivity.Name = "Btn_LogActivity";
            this.Btn_LogActivity.Size = new System.Drawing.Size(236, 54);
            this.Btn_LogActivity.TabIndex = 4;
            this.Btn_LogActivity.Text = "Log Activity";
            this.Btn_LogActivity.UseVisualStyleBackColor = false;
            this.Btn_LogActivity.Click += new System.EventHandler(this.Btn_LogActivity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(356, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "LAPORAN PENJUALAN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(359, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pages /Dashboard";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Btn_Filter);
            this.panel2.Controls.Add(this.dateTimePicker4);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(363, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 357);
            this.panel2.TabIndex = 21;
            // 
            // Btn_Filter
            // 
            this.Btn_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.Btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Filter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Filter.Location = new System.Drawing.Point(821, 40);
            this.Btn_Filter.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Filter.Name = "Btn_Filter";
            this.Btn_Filter.Size = new System.Drawing.Size(98, 38);
            this.Btn_Filter.TabIndex = 27;
            this.Btn_Filter.Text = "Filter";
            this.Btn_Filter.UseVisualStyleBackColor = false;
            this.Btn_Filter.Click += new System.EventHandler(this.Btn_Filter_Click);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.dateTimePicker4.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(632, 43);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(176, 27);
            this.dateTimePicker4.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(933, 259);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbltranksaksiBindingSource
            // 
            this.tbltranksaksiBindingSource.DataMember = "tbl_tranksaksi";
            this.tbltranksaksiBindingSource.DataSource = this.fOODXYZDataSet;
            // 
            // fOODXYZDataSet
            // 
            this.fOODXYZDataSet.DataSetName = "FOODXYZDataSet";
            this.fOODXYZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 27);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label9.Location = new System.Drawing.Point(21, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 31);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tabel Tranksaksi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sampai Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Dari Tanggal";
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.Btn_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Generate.Location = new System.Drawing.Point(786, 453);
            this.Btn_Generate.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Generate.Name = "Btn_Generate";
            this.Btn_Generate.Size = new System.Drawing.Size(175, 46);
            this.Btn_Generate.TabIndex = 8;
            this.Btn_Generate.Text = "Generate";
            this.Btn_Generate.UseVisualStyleBackColor = false;
            this.Btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(363, 522);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Omset";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(888, 235);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(1063, 22);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 23;
            this.dateTimePicker3.Value = new System.DateTime(2024, 8, 7, 0, 0, 0, 0);
            // 
            // tbl_tranksaksiTableAdapter
            // 
            this.tbl_tranksaksiTableAdapter.ClearBeforeFill = true;
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 780);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Btn_Generate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormLaporan";
            this.Text = "Laporan";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltranksaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODXYZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_KelolaLaporan;
        private System.Windows.Forms.Button Btn_KelolaUser;
        private System.Windows.Forms.Button Btn_LogActivity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Generate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private FOODXYZDataSet fOODXYZDataSet;
        private System.Windows.Forms.BindingSource tbltranksaksiBindingSource;
        private FOODXYZDataSetTableAdapters.tbl_tranksaksiTableAdapter tbl_tranksaksiTableAdapter;
        private System.Windows.Forms.Button Btn_Filter;
    }
}