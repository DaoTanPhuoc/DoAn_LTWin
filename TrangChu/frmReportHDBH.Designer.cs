namespace TrangChu
{
    partial class frmReportHDBH
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
            this.label1 = new System.Windows.Forms.Label();
            this.rptHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(386, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "In Hoá Đơn";
            // 
            // rptHoaDon
            // 
            this.rptHoaDon.AutoScroll = true;
            this.rptHoaDon.AutoSize = true;
            this.rptHoaDon.LocalReport.ReportEmbeddedResource = "TrangChu.QLBanHang.Report_HDBH.rdlc";
            this.rptHoaDon.Location = new System.Drawing.Point(8, 49);
            this.rptHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rptHoaDon.Name = "rptHoaDon";
            this.rptHoaDon.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.rptHoaDon.ServerReport.BearerToken = null;
            this.rptHoaDon.Size = new System.Drawing.Size(905, 702);
            this.rptHoaDon.TabIndex = 2;
            // 
            // frmReportHDBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(219)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(921, 754);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptHoaDon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReportHDBH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportHDBH";
            this.Load += new System.EventHandler(this.frmReportHDBH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rptHoaDon;
    }
}