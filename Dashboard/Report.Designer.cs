namespace Dashboard
{
    partial class Report
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
            this.serverFileReportService1 = new CrystalDecisions.Web.Services.ServerFileReportService();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label_noHP = new System.Windows.Forms.Label();
            this.CrystalReport24 = new Dashboard.CrystalReport2();
            this.CrystalReport22 = new Dashboard.CrystalReport2();
            this.CrystalReport21 = new Dashboard.CrystalReport2();
            this.CrystalReport23 = new Dashboard.CrystalReport2();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "C:\\Users\\MyBook Z Series\\source\\repos\\YazidIrul3\\Latihan-LKS\\Dashboard\\CrystalRep" +
    "ort2.rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1183, 713);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // label_noHP
            // 
            this.label_noHP.AutoSize = true;
            this.label_noHP.Location = new System.Drawing.Point(128, 154);
            this.label_noHP.Name = "label_noHP";
            this.label_noHP.Size = new System.Drawing.Size(58, 16);
            this.label_noHP.TabIndex = 1;
            this.label_noHP.Text = "NO HP : ";
            // 
            // CrystalReport24
            // 
            this.CrystalReport24.InitReport += new System.EventHandler(this.CrystalReport24_InitReport);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 713);
            this.Controls.Add(this.label_noHP);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Web.Services.ServerFileReportService serverFileReportService1;
        private CrystalReport2 CrystalReport21;
        private CrystalReport2 CrystalReport22;
        private CrystalReport2 CrystalReport23;
        private CrystalReport2 CrystalReport24;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label_noHP;
    }
}