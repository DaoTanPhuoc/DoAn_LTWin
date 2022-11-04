namespace TrangChu
{
    partial class frmXemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemTaiKhoan));
            this.dgvDSTK = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDoiMK = new System.Windows.Forms.RadioButton();
            this.radXoaTK = new System.Windows.Forms.RadioButton();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtDoiMK = new System.Windows.Forms.TextBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.txtIDDangChon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSTK
            // 
            this.dgvDSTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSTK.Location = new System.Drawing.Point(0, 220);
            this.dgvDSTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSTK.Name = "dgvDSTK";
            this.dgvDSTK.RowHeadersWidth = 62;
            this.dgvDSTK.RowTemplate.Height = 28;
            this.dgvDSTK.Size = new System.Drawing.Size(806, 167);
            this.dgvDSTK.TabIndex = 0;
            this.dgvDSTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTK_CellClick);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.Black;
            this.btnQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("btnQuayLai.Image")));
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.Location = new System.Drawing.Point(627, 103);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(118, 47);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDoiMK);
            this.groupBox1.Controls.Add(this.btnQuayLai);
            this.groupBox1.Controls.Add(this.radXoaTK);
            this.groupBox1.Controls.Add(this.lblMK);
            this.groupBox1.Controls.Add(this.txtDoiMK);
            this.groupBox1.Controls.Add(this.btnDoiMK);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.btnXoaTK);
            this.groupBox1.Controls.Add(this.txtIDDangChon);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(799, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng ";
            // 
            // radDoiMK
            // 
            this.radDoiMK.AutoSize = true;
            this.radDoiMK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDoiMK.Location = new System.Drawing.Point(453, 25);
            this.radDoiMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radDoiMK.Name = "radDoiMK";
            this.radDoiMK.Size = new System.Drawing.Size(122, 23);
            this.radDoiMK.TabIndex = 7;
            this.radDoiMK.Text = "Đổi Mật khẩu";
            this.radDoiMK.UseVisualStyleBackColor = true;
            // 
            // radXoaTK
            // 
            this.radXoaTK.AutoSize = true;
            this.radXoaTK.Checked = true;
            this.radXoaTK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radXoaTK.Location = new System.Drawing.Point(224, 25);
            this.radXoaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radXoaTK.Name = "radXoaTK";
            this.radXoaTK.Size = new System.Drawing.Size(131, 23);
            this.radXoaTK.TabIndex = 6;
            this.radXoaTK.TabStop = true;
            this.radXoaTK.Text = "Xoá Tài Khoản";
            this.radXoaTK.UseVisualStyleBackColor = true;
            this.radXoaTK.CheckedChanged += new System.EventHandler(this.radXoaTK_CheckedChanged);
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK.Location = new System.Drawing.Point(31, 146);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(110, 19);
            this.lblMK.TabIndex = 5;
            this.lblMK.Text = "Đổi Mật Khẩu:";
            this.lblMK.Visible = false;
            // 
            // txtDoiMK
            // 
            this.txtDoiMK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoiMK.Location = new System.Drawing.Point(172, 142);
            this.txtDoiMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoiMK.Name = "txtDoiMK";
            this.txtDoiMK.Size = new System.Drawing.Size(132, 27);
            this.txtDoiMK.TabIndex = 4;
            this.txtDoiMK.Visible = false;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.Location = new System.Drawing.Point(365, 103);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(148, 51);
            this.btnDoiMK.TabIndex = 3;
            this.btnDoiMK.Text = "Đổi Mật Khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Visible = false;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(43, 88);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(110, 19);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID Đang Chọn:";
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.Location = new System.Drawing.Point(365, 103);
            this.btnXoaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(148, 51);
            this.btnXoaTK.TabIndex = 1;
            this.btnXoaTK.Text = "Xoá Tài Khoản";
            this.btnXoaTK.UseVisualStyleBackColor = true;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // txtIDDangChon
            // 
            this.txtIDDangChon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDangChon.Location = new System.Drawing.Point(172, 88);
            this.txtIDDangChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDDangChon.Name = "txtIDDangChon";
            this.txtIDDangChon.ReadOnly = true;
            this.txtIDDangChon.Size = new System.Drawing.Size(132, 27);
            this.txtIDDangChon.TabIndex = 0;
            // 
            // frmXemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(219)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(806, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDSTK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmXemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xem Tài Khoản";
            this.Load += new System.EventHandler(this.frmXemTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSTK;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.TextBox txtIDDangChon;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.RadioButton radDoiMK;
        private System.Windows.Forms.RadioButton radXoaTK;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.TextBox txtDoiMK;
    }
}