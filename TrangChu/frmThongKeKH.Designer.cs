namespace TrangChu
{
    partial class frmThongKeKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeKH));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTCKH = new System.Windows.Forms.CheckBox();
            this.radKHHT = new System.Windows.Forms.RadioButton();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnInDS = new System.Windows.Forms.Button();
            this.radKHDaXoa = new System.Windows.Forms.RadioButton();
            this.rptKH = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Orange;
            this.groupBox1.Controls.Add(this.cbTCKH);
            this.groupBox1.Controls.Add(this.radKHHT);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnInDS);
            this.groupBox1.Controls.Add(this.radKHDaXoa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 123);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // cbTCKH
            // 
            this.cbTCKH.AutoSize = true;
            this.cbTCKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTCKH.Location = new System.Drawing.Point(682, 52);
            this.cbTCKH.Name = "cbTCKH";
            this.cbTCKH.Size = new System.Drawing.Size(178, 20);
            this.cbTCKH.TabIndex = 7;
            this.cbTCKH.Text = "In Tất Cả Khách Hàng";
            this.cbTCKH.UseVisualStyleBackColor = true;
            this.cbTCKH.CheckedChanged += new System.EventHandler(this.cbTCKH_CheckedChanged);
            // 
            // radKHHT
            // 
            this.radKHHT.AutoSize = true;
            this.radKHHT.BackColor = System.Drawing.Color.Transparent;
            this.radKHHT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radKHHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKHHT.Location = new System.Drawing.Point(425, 51);
            this.radKHHT.Name = "radKHHT";
            this.radKHHT.Size = new System.Drawing.Size(174, 20);
            this.radKHHT.TabIndex = 6;
            this.radKHHT.TabStop = true;
            this.radKHHT.Text = "Khách Hàng Hiện Tại";
            this.radKHHT.UseVisualStyleBackColor = false;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Lime;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(913, 51);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(91, 51);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnInDS
            // 
            this.btnInDS.BackColor = System.Drawing.Color.Yellow;
            this.btnInDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDS.ForeColor = System.Drawing.Color.Red;
            this.btnInDS.Location = new System.Drawing.Point(19, 32);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(137, 57);
            this.btnInDS.TabIndex = 3;
            this.btnInDS.Text = "In Danh Sách";
            this.btnInDS.UseVisualStyleBackColor = false;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // radKHDaXoa
            // 
            this.radKHDaXoa.AutoSize = true;
            this.radKHDaXoa.BackColor = System.Drawing.Color.Transparent;
            this.radKHDaXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radKHDaXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKHDaXoa.Location = new System.Drawing.Point(172, 51);
            this.radKHDaXoa.Name = "radKHDaXoa";
            this.radKHDaXoa.Size = new System.Drawing.Size(165, 20);
            this.radKHDaXoa.TabIndex = 5;
            this.radKHDaXoa.TabStop = true;
            this.radKHDaXoa.Text = "Khách Hàng Đã Xoá";
            this.radKHDaXoa.UseVisualStyleBackColor = false;
            // 
            // rptKH
            // 
            this.rptKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptKH.Location = new System.Drawing.Point(12, 134);
            this.rptKH.Name = "rptKH";
            this.rptKH.ServerReport.BearerToken = null;
            this.rptKH.Size = new System.Drawing.Size(992, 526);
            this.rptKH.TabIndex = 9;
            // 
            // frmThongKeKH
            // 
            this.AcceptButton = this.btnInDS;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(219)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1016, 671);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rptKH);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongKeKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmThongKeKH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTCKH;
        private System.Windows.Forms.RadioButton radKHHT;
        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.RadioButton radKHDaXoa;
        private Microsoft.Reporting.WinForms.ReportViewer rptKH;
        private System.Windows.Forms.Button btnthoat;
    }
}