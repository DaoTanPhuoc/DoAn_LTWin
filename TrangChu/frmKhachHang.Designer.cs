namespace TrangChu
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.btnInDS = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSKH = new System.Windows.Forms.DataGridView();
            this.btnthoatkh = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnthemkhachhang = new System.Windows.Forms.Button();
            this.btnxoakh = new System.Windows.Forms.Button();
            this.btnsuakh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.lblkhachhang = new System.Windows.Forms.Label();
            this.lbltenkh = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lblsdt = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txttenKH = new System.Windows.Forms.TextBox();
            this.txtmaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInDS
            // 
            this.btnInDS.BackColor = System.Drawing.Color.Lime;
            this.btnInDS.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDS.Image = ((System.Drawing.Image)(resources.GetObject("btnInDS.Image")));
            this.btnInDS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInDS.Location = new System.Drawing.Point(722, 284);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(131, 51);
            this.btnInDS.TabIndex = 45;
            this.btnInDS.Text = "Thống Kê";
            this.btnInDS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInDS.UseVisualStyleBackColor = false;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.txttimkiem);
            this.groupBox4.Controls.Add(this.btntimkiem);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(222, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 74);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Theo Mã";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(186, 31);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(138, 27);
            this.txttimkiem.TabIndex = 19;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiem.Location = new System.Drawing.Point(22, 23);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(135, 42);
            this.btntimkiem.TabIndex = 18;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSKH);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(905, 176);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiển Thị Thông Tin";
            // 
            // dgvDSKH
            // 
            this.dgvDSKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSKH.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSKH.Location = new System.Drawing.Point(3, 18);
            this.dgvDSKH.Name = "dgvDSKH";
            this.dgvDSKH.RowHeadersWidth = 51;
            this.dgvDSKH.RowTemplate.Height = 24;
            this.dgvDSKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKH.Size = new System.Drawing.Size(899, 155);
            this.dgvDSKH.TabIndex = 36;
            this.dgvDSKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LaydulieuKH_CellClick);
            // 
            // btnthoatkh
            // 
            this.btnthoatkh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoatkh.Image = ((System.Drawing.Image)(resources.GetObject("btnthoatkh.Image")));
            this.btnthoatkh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoatkh.Location = new System.Drawing.Point(93, 155);
            this.btnthoatkh.Name = "btnthoatkh";
            this.btnthoatkh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnthoatkh.Size = new System.Drawing.Size(100, 42);
            this.btnthoatkh.TabIndex = 17;
            this.btnthoatkh.Text = "Thoát";
            this.btnthoatkh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoatkh.UseVisualStyleBackColor = true;
            this.btnthoatkh.Click += new System.EventHandler(this.btnthoatkh_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.Image")));
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(152, 91);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(128, 42);
            this.btnreset.TabIndex = 17;
            this.btnreset.Text = "Làm Mới";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnthemkhachhang
            // 
            this.btnthemkhachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemkhachhang.Image = ((System.Drawing.Image)(resources.GetObject("btnthemkhachhang.Image")));
            this.btnthemkhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemkhachhang.Location = new System.Drawing.Point(28, 27);
            this.btnthemkhachhang.Name = "btnthemkhachhang";
            this.btnthemkhachhang.Size = new System.Drawing.Size(117, 42);
            this.btnthemkhachhang.TabIndex = 14;
            this.btnthemkhachhang.Text = "  Thêm ";
            this.btnthemkhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemkhachhang.UseVisualStyleBackColor = true;
            this.btnthemkhachhang.Click += new System.EventHandler(this.btnthemkhachhang_Click);
            // 
            // btnxoakh
            // 
            this.btnxoakh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoakh.Image = ((System.Drawing.Image)(resources.GetObject("btnxoakh.Image")));
            this.btnxoakh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnxoakh.Location = new System.Drawing.Point(164, 27);
            this.btnxoakh.Name = "btnxoakh";
            this.btnxoakh.Size = new System.Drawing.Size(92, 42);
            this.btnxoakh.TabIndex = 15;
            this.btnxoakh.Text = "Xoá";
            this.btnxoakh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoakh.UseVisualStyleBackColor = true;
            this.btnxoakh.Click += new System.EventHandler(this.btnxoakh_Click);
            // 
            // btnsuakh
            // 
            this.btnsuakh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuakh.Image = ((System.Drawing.Image)(resources.GetObject("btnsuakh.Image")));
            this.btnsuakh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsuakh.Location = new System.Drawing.Point(28, 91);
            this.btnsuakh.Name = "btnsuakh";
            this.btnsuakh.Size = new System.Drawing.Size(100, 42);
            this.btnsuakh.TabIndex = 16;
            this.btnsuakh.Text = "Sửa";
            this.btnsuakh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsuakh.UseVisualStyleBackColor = true;
            this.btnsuakh.Click += new System.EventHandler(this.btnsuakh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Yellow;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.lblkhachhang);
            this.groupBox2.Controls.Add(this.lbltenkh);
            this.groupBox2.Controls.Add(this.lblgioitinh);
            this.groupBox2.Controls.Add(this.lblsdt);
            this.groupBox2.Controls.Add(this.txtsdt);
            this.groupBox2.Controls.Add(this.txttenKH);
            this.groupBox2.Controls.Add(this.txtmaKH);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 203);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Khách Hàng";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radnam);
            this.groupBox5.Controls.Add(this.radnu);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(429, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 59);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radnam.Location = new System.Drawing.Point(16, 22);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(62, 23);
            this.radnam.TabIndex = 24;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radnu.Location = new System.Drawing.Point(120, 24);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(51, 23);
            this.radnu.TabIndex = 25;
            this.radnu.TabStop = true;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // lblkhachhang
            // 
            this.lblkhachhang.AutoSize = true;
            this.lblkhachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkhachhang.Location = new System.Drawing.Point(13, 47);
            this.lblkhachhang.Name = "lblkhachhang";
            this.lblkhachhang.Size = new System.Drawing.Size(117, 19);
            this.lblkhachhang.TabIndex = 19;
            this.lblkhachhang.Text = "Mã Khách Hàng";
            // 
            // lbltenkh
            // 
            this.lbltenkh.AutoSize = true;
            this.lbltenkh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenkh.Location = new System.Drawing.Point(13, 139);
            this.lbltenkh.Name = "lbltenkh";
            this.lbltenkh.Size = new System.Drawing.Size(120, 19);
            this.lbltenkh.TabIndex = 20;
            this.lbltenkh.Text = "Tên Khách Hàng";
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgioitinh.Location = new System.Drawing.Point(325, 51);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(74, 19);
            this.lblgioitinh.TabIndex = 21;
            this.lblgioitinh.Text = "Giới Tính";
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsdt.Location = new System.Drawing.Point(325, 134);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(106, 19);
            this.lblsdt.TabIndex = 22;
            this.lblsdt.Text = "Số Điện Thoại";
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(463, 133);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(154, 27);
            this.txtsdt.TabIndex = 28;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // txttenKH
            // 
            this.txttenKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenKH.Location = new System.Drawing.Point(152, 139);
            this.txttenKH.Name = "txttenKH";
            this.txttenKH.Size = new System.Drawing.Size(157, 27);
            this.txttenKH.TabIndex = 27;
            // 
            // txtmaKH
            // 
            this.txtmaKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaKH.Location = new System.Drawing.Point(152, 44);
            this.txtmaKH.Name = "txtmaKH";
            this.txtmaKH.Size = new System.Drawing.Size(157, 27);
            this.txtmaKH.TabIndex = 26;
            this.txtmaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmaKH_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 32);
            this.label1.TabIndex = 41;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.btnthoatkh);
            this.groupBox1.Controls.Add(this.btnreset);
            this.groupBox1.Controls.Add(this.btnthemkhachhang);
            this.groupBox1.Controls.Add(this.btnxoakh);
            this.groupBox1.Controls.Add(this.btnsuakh);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(637, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 203);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(219)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(929, 547);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSKH;
        private System.Windows.Forms.Button btnthoatkh;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnthemkhachhang;
        private System.Windows.Forms.Button btnxoakh;
        private System.Windows.Forms.Button btnsuakh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.Label lblkhachhang;
        private System.Windows.Forms.Label lbltenkh;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txttenKH;
        private System.Windows.Forms.TextBox txtmaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}