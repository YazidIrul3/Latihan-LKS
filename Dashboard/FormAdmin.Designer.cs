namespace Dashboard
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_LogActivity = new System.Windows.Forms.Button();
            this.Btn_KelolaLaporan = new System.Windows.Forms.Button();
            this.Btn_KelolaUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Btn_Filter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Btn_LogActivity);
            this.panel1.Controls.Add(this.Btn_KelolaLaporan);
            this.panel1.Controls.Add(this.Btn_KelolaUser);
            this.panel1.Location = new System.Drawing.Point(-24, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 732);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(114, 633);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Btn_LogActivity
            // 
            this.Btn_LogActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(167)))), ((int)(((byte)(214)))));
            this.Btn_LogActivity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_LogActivity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_LogActivity.Location = new System.Drawing.Point(55, 556);
            this.Btn_LogActivity.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_LogActivity.Name = "Btn_LogActivity";
            this.Btn_LogActivity.Size = new System.Drawing.Size(236, 54);
            this.Btn_LogActivity.TabIndex = 3;
            this.Btn_LogActivity.Text = "Log Activity";
            this.Btn_LogActivity.UseVisualStyleBackColor = false;
            this.Btn_LogActivity.Click += new System.EventHandler(this.Btn_LogActivity_Click);
            // 
            // Btn_KelolaLaporan
            // 
            this.Btn_KelolaLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.Btn_KelolaLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_KelolaLaporan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_KelolaLaporan.Location = new System.Drawing.Point(55, 467);
            this.Btn_KelolaLaporan.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_KelolaLaporan.Name = "Btn_KelolaLaporan";
            this.Btn_KelolaLaporan.Size = new System.Drawing.Size(236, 54);
            this.Btn_KelolaLaporan.TabIndex = 2;
            this.Btn_KelolaLaporan.Text = "Kelola Laporan";
            this.Btn_KelolaLaporan.UseVisualStyleBackColor = false;
            this.Btn_KelolaLaporan.Click += new System.EventHandler(this.Btn_KelolaLaporan_Click);
            // 
            // Btn_KelolaUser
            // 
            this.Btn_KelolaUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.Btn_KelolaUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_KelolaUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_KelolaUser.Location = new System.Drawing.Point(55, 386);
            this.Btn_KelolaUser.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_KelolaUser.Name = "Btn_KelolaUser";
            this.Btn_KelolaUser.Size = new System.Drawing.Size(236, 54);
            this.Btn_KelolaUser.TabIndex = 1;
            this.Btn_KelolaUser.Text = "Kelola User";
            this.Btn_KelolaUser.UseVisualStyleBackColor = false;
            this.Btn_KelolaUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(332, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pages /Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(329, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "LOG ACTIVITY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dari Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sampai Tanggal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(336, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.dateTimePicker2.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(598, 206);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // Btn_Filter
            // 
            this.Btn_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.Btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Filter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Filter.Location = new System.Drawing.Point(822, 195);
            this.Btn_Filter.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Filter.Name = "Btn_Filter";
            this.Btn_Filter.Size = new System.Drawing.Size(98, 38);
            this.Btn_Filter.TabIndex = 4;
            this.Btn_Filter.Text = "Filter";
            this.Btn_Filter.UseVisualStyleBackColor = false;
            this.Btn_Filter.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(336, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 384);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 314);
            this.dataGridView1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.label5.Location = new System.Drawing.Point(19, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "LOG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(106, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 45);
            this.label10.TabIndex = 13;
            this.label10.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 732);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_Filter);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_KelolaLaporan;
        private System.Windows.Forms.Button Btn_KelolaUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_LogActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button Btn_Filter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

