namespace TrangChu
{
    partial class frmThongKeMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeMon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTCM = new System.Windows.Forms.RadioButton();
            this.radht = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.radmondx = new System.Windows.Forms.RadioButton();
            this.btnin = new System.Windows.Forms.Button();
            this.rptTKMon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.radTCM);
            this.groupBox1.Controls.Add(this.radht);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.radmondx);
            this.groupBox1.Controls.Add(this.btnin);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 102);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // radTCM
            // 
            this.radTCM.AutoSize = true;
            this.radTCM.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTCM.Location = new System.Drawing.Point(660, 50);
            this.radTCM.Name = "radTCM";
            this.radTCM.Size = new System.Drawing.Size(120, 23);
            this.radTCM.TabIndex = 5;
            this.radTCM.TabStop = true;
            this.radTCM.Text = "Tất Cả Món ";
            this.radTCM.UseVisualStyleBackColor = true;
            // 
            // radht
            // 
            this.radht.AutoSize = true;
            this.radht.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radht.Location = new System.Drawing.Point(428, 50);
            this.radht.Name = "radht";
            this.radht.Size = new System.Drawing.Size(136, 23);
            this.radht.TabIndex = 4;
            this.radht.TabStop = true;
            this.radht.Text = "Món Hiện Tại ";
            this.radht.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.AllowDrop = true;
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(884, 37);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 51);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // radmondx
            // 
            this.radmondx.AutoSize = true;
            this.radmondx.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radmondx.Location = new System.Drawing.Point(195, 51);
            this.radmondx.Name = "radmondx";
            this.radmondx.Size = new System.Drawing.Size(121, 23);
            this.radmondx.TabIndex = 3;
            this.radmondx.TabStop = true;
            this.radmondx.Text = "Món Đã Xoá";
            this.radmondx.UseVisualStyleBackColor = true;
            // 
            // btnin
            // 
            this.btnin.AllowDrop = true;
            this.btnin.BackColor = System.Drawing.Color.Yellow;
            this.btnin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnin.ForeColor = System.Drawing.Color.Red;
            this.btnin.Location = new System.Drawing.Point(38, 30);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(137, 57);
            this.btnin.TabIndex = 2;
            this.btnin.Text = "In Danh Sách ";
            this.btnin.UseVisualStyleBackColor = false;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // rptTKMon
            // 
            this.rptTKMon.AutoSize = true;
            this.rptTKMon.Location = new System.Drawing.Point(12, 129);
            this.rptTKMon.Name = "rptTKMon";
            this.rptTKMon.ServerReport.BearerToken = null;
            this.rptTKMon.Size = new System.Drawing.Size(999, 534);
            this.rptTKMon.TabIndex = 4;
            // 
            // frmThongKeMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(219)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1023, 673);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rptTKMon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongKeMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongKeMon";
            this.Load += new System.EventHandler(this.frmThongKeMon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTCM;
        private System.Windows.Forms.RadioButton radht;
        private System.Windows.Forms.RadioButton radmondx;
        private System.Windows.Forms.Button btnin;
        private Microsoft.Reporting.WinForms.ReportViewer rptTKMon;
        private System.Windows.Forms.Button btnThoat;
    }
}