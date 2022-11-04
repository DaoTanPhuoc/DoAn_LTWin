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

namespace TrangChu
{
    public partial class frmThemMon : Form
    {
        public frmThemMon()
        {
            InitializeComponent();
        }

        private void frmThemMon_Load(object sender, EventArgs e)
        {
            DocDanhSachMon(dgvDSMon);
            load_LoaiMon(cboLoaiMon);
        }
        private void load_LoaiMon(ComboBox cbo)
        {
            BAL_LoaiMon xuLyMon = new BAL_LoaiMon();
            cbo.DataSource = xuLyMon.layMaMon();
            cbo.DisplayMember = "MaLoaiMon";
        }

        public void DocDanhSachMon(DataGridView dgv)
        {
            BAL_Mon xuLyMon = new BAL_Mon();
            dgv.DataSource = xuLyMon.DocDanhSachMon();
        }

        private void laydulieuMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMon.Text = dgvDSMon.CurrentRow.Cells["MaMon"].Value.ToString().Trim();
            cboLoaiMon.Text = dgvDSMon.CurrentRow.Cells["LoaiMon"].Value.ToString();
            cboTinhTrang.Text = dgvDSMon.CurrentRow.Cells["TinhTrang"].Value.ToString();
            txtTenMon.Text = dgvDSMon.CurrentRow.Cells["TenMon"].Value.ToString();
            txtDonGia.Text = dgvDSMon.CurrentRow.Cells["DonGia"].Value.ToString();
            txtDonVi.Text = dgvDSMon.CurrentRow.Cells["DonVi"].Value.ToString();
            txtMaMon.ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string maMon = txtMaMon.Text;
                string loaiMon = cboLoaiMon.Text;
                string tinhTrang = cboTinhTrang.Text;
                string tenMon = txtTenMon.Text;
                float donGia = float.Parse(txtDonGia.Text);
                string donVi = txtDonVi.Text;
                int daXoa = 0;
                BAL_Mon xuLyMon = new BAL_Mon();
                bool ketQuaKiemTra = xuLyMon.kiemTraMon(maMon);
                if (ketQuaKiemTra == false)
                {
                    Mon mon = new Mon(maMon, tenMon, loaiMon, donGia, tinhTrang, donVi, daXoa);
                    bool keQuaThem = xuLyMon.themMon(mon);
                    if (keQuaThem == true)
                    {
                        MessageBox.Show("Đã thêm một món ! ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DocDanhSachMon(dgvDSMon);
                        txtMaMon.Clear();
                        txtTenMon.Clear();
                        txtDonVi.Clear();
                        txtDonGia.Clear();
                        txtMaMon.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Mã món đã tồn tại ! ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại !!", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string maMon = txtMaMon.Text;
                string loaiMon = cboLoaiMon.Text;
                string tinhTrang = cboTinhTrang.Text;
                string tenMon = txtTenMon.Text;
                float donGia = float.Parse(txtDonGia.Text);
                string donVi = txtDonVi.Text;
                int daXoa = 0;
                Mon mon = new Mon(maMon, tenMon, loaiMon, donGia, tinhTrang, donVi, daXoa);
                BAL_Mon xuLyMon = new BAL_Mon();
                bool ketquaxoa = xuLyMon.xoaMon(mon);
                if (ketquaxoa == true)
                {
                    MessageBox.Show("Đã xoá một món ! ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DocDanhSachMon(dgvDSMon);
                    txtMaMon.Clear();
                    txtTenMon.Clear();
                    txtDonVi.Clear();
                    txtDonGia.Clear();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại !!", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn món cần xoá !!", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string maMon = txtMaMon.Text;
                string loaiMon = cboLoaiMon.Text;
                string tinhTrang = cboTinhTrang.Text;
                string tenMon = txtTenMon.Text;
                float donGia = float.Parse(txtDonGia.Text);
                string donVi = txtDonVi.Text;
                int daXoa = 0;
                Mon mon = new Mon(maMon, tenMon, loaiMon, donGia, tinhTrang, donVi, daXoa);
                BAL_Mon xuLyMon = new BAL_Mon();
                bool ketquasua = xuLyMon.suaMon(mon);
                if (ketquasua == true)
                {
                    MessageBox.Show("Bạn đã sửa món thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DocDanhSachMon(dgvDSMon);
                    txtMaMon.Clear();
                    txtTenMon.Clear();
                    txtDonVi.Clear();
                    txtDonGia.Clear();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn món bạn cần sửa !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {

            BAL_Mon xuLyMon = new BAL_Mon();
            dgvDSMon.DataSource = xuLyMon.timKiemMon(txttimkiem.Text);

            if (xuLyMon.timKiemMon(txttimkiem.Text).Rows.Count > 0)
            {
                dgvDSMon.DataSource = xuLyMon.timKiemMon(txttimkiem.Text);
                txttimkiem.Clear();
                txttimkiem.Focus();
            }
            else
            {
                MessageBox.Show("Không tìm thấy !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show("Bạn có thật sự muốn thoát !", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == ketQua)
            {
                this.Close();
                fromChucNang f = new fromChucNang();
                f.Show();
            }    
             
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtDonGia.Clear();
            txtDonVi.Clear();
            txtMaMon.Focus();
            txtMaMon.ReadOnly = false;
            DocDanhSachMon(dgvDSMon);
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            frmThongKeMon ftk = new frmThongKeMon();
            ftk.Show();
            this.Hide();
        }

        private void txtmaMon_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtdonGia_keyPress(object sender, KeyPressEventArgs e)
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
