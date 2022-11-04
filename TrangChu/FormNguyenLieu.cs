using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;


namespace TrangChu
{
    public partial class FormNguyenLieu : Form
    {
        public FormNguyenLieu()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show(" Bạn có thực sự muốn thoát ? ", "Thông Báo", MessageBoxButtons.YesNo);
            if (KQ == DialogResult.Yes)
            {
                this.Close();
                fromChucNang f = new fromChucNang();
                f.Show();
            }
        }

        private void HienThiNL(DataGridView dgv)
        {
            BAL_NguyenLieu XuLyThemNL= new BAL_NguyenLieu();
            dgv.DataSource = XuLyThemNL.DocNguyenLieu();
        }

        private void HienThiNCC(ComboBox cbo)
        {
            BAL_NhaCungCap xuly= new BAL_NhaCungCap();
            cbo.DataSource = xuly.LoadNCC();
            cbo.DisplayMember = "MaNCC";
        }

        private void FormNguyenLieu_Load(object sender, EventArgs e)
        {
            HienThiNL(dgvNL);
            HienThiNCC(cboNL);
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            


            DataTable dt = new DataTable();
            string maNL= txtMaNL.Text;
            string ten= txtTenNL.Text;
            string maNCC=cboNL.Text;
            string DVT = txtDVT.Text;
            int SLHienCo = int.Parse(txtSoLuongHienCo.Text);
            int daxoa = 0;
            NguyenLieu nl=new NguyenLieu(maNL,ten,maNCC,DVT,SLHienCo,daxoa);

            BAL_NguyenLieu XuLyThemNL= new BAL_NguyenLieu();
            XuLyThemNL.layMaNLsauThem(txtMaNL.Text);
            bool kq = XuLyThemNL.ThemNguyenLieu(nl);
            if(kq==true)
            {
                MessageBox.Show("Thêm nguyên liệu thành công! ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                HienThiNL(dgvNL);
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string maNL = txtMaNL.Text;
            string ten = txtTenNL.Text;
            string maNCC = cboNL.Text;
            string DVT = txtDVT.Text;
            int SLHienCo = int.Parse(txtSoLuongHienCo.Text);
            int daxoa = 0;
            NguyenLieu nl = new NguyenLieu(maNL, ten, maNCC, DVT, SLHienCo, daxoa);
            BAL_NguyenLieu XuLy = new BAL_NguyenLieu();
            bool kq = XuLy.SuaNguyenLieu(nl);
            if(kq== true)
            {
                MessageBox.Show("Sửa Nguyên Liệu thành công! ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                HienThiNL(dgvNL);
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string MaDangCon= null;

    

        private void dgvNL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MaDangCon = dgvNL.CurrentRow.Cells[0].Value.ToString().Trim();
            txtMaNL.Text = dgvNL.CurrentRow.Cells["MaNL"].Value.ToString().Trim();
            txtTenNL.Text = dgvNL.CurrentRow.Cells["TenNL"].Value.ToString().Trim();
            cboNL.Text = dgvNL.CurrentRow.Cells["MaNCC"].Value.ToString().Trim();
            txtDVT.Text = dgvNL.CurrentRow.Cells["DonViTinh"].Value.ToString().Trim();
            txtSoLuongHienCo.Text = dgvNL.CurrentRow.Cells["SoLuongHienCo"].Value.ToString().Trim();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string maNL = txtMaNL.Text;
            string ten = txtTenNL.Text;
            string maNCC = cboNL.Text;
            string DVT = txtDVT.Text;
            int SLHienCo = int.Parse(txtSoLuongHienCo.Text);
            int daxoa = 0;
            NguyenLieu nl = new NguyenLieu(maNL, ten, maNCC, DVT, SLHienCo, daxoa);
            BAL_NguyenLieu XuLy = new BAL_NguyenLieu();
            bool kq = XuLy.XoaNguyeLieu(nl);
            if(kq==true)
            {
                MessageBox.Show("Đã Xóa Thành Công", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                HienThiNL(dgvNL);
                txtMaNL.Clear();
                txtTenNL.Clear();
                txtDVT.Clear();
                txtSoLuongHienCo.Clear();
            }
            else
            {
                MessageBox.Show("xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            //maNLieuDangChon = txtMaNL.Text;
            //flag = false;
            //this.Close();
            HoaDonNhapKho hdnk = new HoaDonNhapKho();
            hdnk.Show();
            this.Hide();
        }
    }
}
