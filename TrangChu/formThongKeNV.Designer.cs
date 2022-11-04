namespace TrangChu
{
    partial class formThongKeNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formThongKeNV));
            this.rptNV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.radTKtheoMa = new System.Windows.Forms.RadioButton();
            this.radInDsNV = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptNV
            // 
            this.rptNV.LocalReport.ReportEmbeddedResource = "TrangChu.rptNhanVien.rdlc";
            this.rptNV.Location = new System.Drawing.Point(13, 164);
            this.rptNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rptNV.Name = "rptNV";
            this.rptNV.ServerReport.BearerToken = null;
            this.rptNV.Size = new System.Drawing.Size(1027, 485);
            this.rptNV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(210, 25);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(219, 27);
            this.txtMaNV.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(528, 10);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 49);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // radTKtheoMa
            // 
            this.radTKtheoMa.AutoSize = true;
            this.radTKtheoMa.Location = new System.Drawing.Point(15, 57);
            this.radTKtheoMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTKtheoMa.Name = "radTKtheoMa";
            this.radTKtheoMa.Size = new System.Drawing.Size(191, 23);
            this.radTKtheoMa.TabIndex = 4;
            this.radTKtheoMa.Text = "Tìm Kiếm theo MaNV";
            this.radTKtheoMa.UseVisualStyleBackColor = true;
            this.radTKtheoMa.CheckedChanged += new System.EventHandler(this.radTKtheoMa_CheckedChanged);
            // 
            // radInDsNV
            // 
            this.radInDsNV.AutoSize = true;
            this.radInDsNV.Location = new System.Drawing.Point(15, 104);
            this.radInDsNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radInDsNV.Name = "radInDsNV";
            this.radInDsNV.Size = new System.Drawing.Size(147, 23);
            this.radInDsNV.TabIndex = 5;
            this.radInDsNV.Text = "In danh sách NV";
            this.radInDsNV.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(528, 81);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 48);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.radInDsNV);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.radTKtheoMa);
            this.groupBox1.Location = new System.Drawing.Point(31, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(692, 142);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // formThongKeNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(219)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1040, 694);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rptNV);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formThongKeNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Nhân Viên";
            this.Load += new System.EventHandler(this.formThongKeNV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton radTKtheoMa;
        private System.Windows.Forms.RadioButton radInDsNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}