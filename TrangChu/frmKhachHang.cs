using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace TrangChu
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DocDanhSachKhachHang(dgvDSKH);
        }
        private void LaydulieuKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaKH.ReadOnly = true;
            string maKH = dgvDSKH.CurrentRow.Cells["MaKH"].Value.ToString().Trim();
            txtmaKH.Text = maKH;
            txttenKH.Text = dgvDSKH.CurrentRow.Cells["TenKH"].Value.ToString();
            string GioiTinh = null;
            GioiTinh = dgvDSKH.CurrentRow.Cells["GioiTinh"].Value.ToString();
            if (GioiTinh.Equals("Nam"))
            {
                radnam.Checked = true;
                radnu.Checked = false;
            }
            else
            {
                radnam.Checked = true;
                radnu.Checked = false;
            }
            txtsdt.Text = dgvDSKH.CurrentRow.Cells["SDT"].Value.ToString();
        }
        public void DocDanhSachKhachHang(DataGridView dgv)
        {
            BAL_KhachHang xuLyKhachHang = new BAL_KhachHang();
            dgv.DataSource = xuLyKhachHang.DocDanhSachKhachHang();
        }
        private void btnthemkhachhang_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string maKH = txtmaKH.Text;
                string tenKH = txttenKH.Text;
                string gioitinh = null;
                if (radnam.Checked == true)
                    gioitinh = "Nam";
                else
                    gioitinh = "Nữ";
                string sdt = txtsdt.Text;
                int daxoa = 0;
                BAL_KhachHang xuLyKhachHang = new BAL_KhachHang();
                bool ketQuaKiemTra = xuLyKhachHang.kiemTraID(maKH);
                if (ketQuaKiemTra == false)
                {
                    KhachHang kh = new KhachHang(maKH, tenKH, gioitinh, sdt, daxoa);
                    bool KetQuaThem = xuLyKhachHang.themKhachHang(kh);
                    if (KetQuaThem == true)
                    {
                        MessageBox.Show("Đã Thêm Một Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DocDanhSachKhachHang(dgvDSKH);
                        txtmaKH.Clear();
                        txttenKH.Clear();
                        txtsdt.Clear();
                        txtmaKH.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại !!", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnxoakh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string maKH = txtmaKH.Text;
            string tenKH = txttenKH.Text;
            string gioitinh = null;
            if (radnam.Checked == true)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";
            string sdt = txtsdt.Text;
            int daxoa = 0;
            KhachHang kh = new KhachHang(maKH, tenKH, gioitinh, sdt, daxoa);
            BAL_KhachHang xuLyKhachHang = new BAL_KhachHang();
            bool ketquaxoa = xuLyKhachHang.xoaKH(kh);

            if (ketquaxoa == true)
            {
                MessageBox.Show("Đã xoá một khách hàng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DocDanhSachKhachHang(dgvDSKH);
                txtmaKH.Clear();
                txttenKH.Clear();
                txtsdt.Clear();
                txtmaKH.Focus();

            }
            else
            {
                MessageBox.Show("Xoá thất bại !!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsuakh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string maKH = txtmaKH.Text;
            string tenKH = txttenKH.Text;
            string gioiTinh = null;
            if (radnam.Checked == true)
                gioiTinh = "Nam";
            else
                gioiTinh = "Nữ";
            string sdt = txtsdt.Text;
            int daxoa = 0;
            KhachHang kh = new KhachHang(maKH, tenKH, gioiTinh, sdt, daxoa);
            BAL_KhachHang xuLyKhachHang = new BAL_KhachHang();
            bool ketquasua = xuLyKhachHang.suaKH(kh);
            if (ketquasua == true)
            {
                MessageBox.Show("Bạn đã sửa khách hàng thành công !! ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DocDanhSachKhachHang(dgvDSKH);
            }
            else
            {
                MessageBox.Show("Sửa đã thất bại !!", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnthoatkh_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show("Bạn có thật sự muốn thoát ! ", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == ketQua)
            {
                this.Close();
                fromChucNang f = new fromChucNang();
                f.Show();
            }                 
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmaKH.Text = null;
            txttenKH.Text = null;
            txtsdt.Text = null;
            txtmaKH.Focus();
            txtmaKH.ReadOnly = false;
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            BAL_KhachHang xuLyKhachHang = new BAL_KhachHang();
            dgvDSKH.DataSource = xuLyKhachHang.timkiemKH(txttimkiem.Text);
            if (xuLyKhachHang.timkiemKH(txttimkiem.Text).Rows.Count > 0)
            {
                dgvDSKH.DataSource = xuLyKhachHang.timkiemKH(txttimkiem.Text);
                txttimkiem.Clear();
                txttimkiem.Focus();
            }
            else
            {
                MessageBox.Show("Không tìm thấy!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnInDS_Click(object sender, EventArgs e)
        {
            frmThongKeKH f = new frmThongKeKH();
            f.Show();
            this.Hide();
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtmaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
