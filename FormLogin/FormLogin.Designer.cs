namespace FormLogin
{
    partial class Txt_Password
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Txt_Password));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Txt_Email = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(54, 85, 109);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.HotTrack;
            dataGridView1.Location = new Point(-268, -8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(844, 714);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.TitleBar;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(54, 85, 109);
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(129, 228);
            label1.Name = "label1";
            label1.Size = new Size(328, 81);
            label1.TabIndex = 1;
            label1.Text = "LKS MART";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(643, 94);
            label2.Name = "label2";
            label2.Size = new Size(143, 50);
            label2.TabIndex = 2;
            label2.Text = "Sign In";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(644, 158);
            label3.Name = "label3";
            label3.Size = new Size(280, 18);
            label3.TabIndex = 3;
            label3.Text = "Enter your email and password for sign in";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(643, 243);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 4;
            label4.Text = "Email *";
            label4.Click += label4_Click;
            // 
            // Txt_Email
            // 
            Txt_Email.BorderStyle = BorderStyle.FixedSingle;
            Txt_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Email.Location = new Point(644, 275);
            Txt_Email.MaxLength = 32800;
            Txt_Email.Name = "Txt_Email";
            Txt_Email.PlaceholderText = "emall@simple.com";
            Txt_Email.Size = new Size(392, 34);
            Txt_Email.TabIndex = 5;
            Txt_Email.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(643, 337);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 6;
            label5.Text = "Password *";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.HideSelection = false;
            textBox1.Location = new Point(644, 376);
            textBox1.MaxLength = 32800;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "min 8 characters";
            textBox1.Size = new Size(392, 30);
            textBox1.TabIndex = 7;
            textBox1.UseSystemPasswordChar = true;
            textBox1.UseWaitCursor = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(54, 85, 109);
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.InactiveBorder;
            button1.Location = new Point(644, 444);
            button1.Name = "button1";
            button1.Size = new Size(182, 55);
            button1.TabIndex = 8;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.InactiveBorder;
            button2.Location = new Point(854, 444);
            button2.Name = "button2";
            button2.Size = new Size(182, 55);
            button2.TabIndex = 9;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(54, 85, 109);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(203, 327);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Txt_Password
            // 
            AccessibleRole = AccessibleRole.Text;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 661);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(Txt_Email);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Txt_Password";
            Text = "Login";
            Load += Txt_Password_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Txt_Email;
        private Label label5;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}
