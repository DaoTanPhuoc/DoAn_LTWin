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
    public partial class frmChamCong : Form
    {
        public frmChamCong()
        {
            InitializeComponent();
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            HienThiDuLieuChamCong(dgvCC);
        }
        public string MaCCDangCCon = null;
        private void txtMNVCC_TextChanged(object sender, EventArgs e)
        {
            BAL_NhanVien xuly = new BAL_NhanVien();

            if (xuly.KtraTonTaiNV(txtMNVCC.Text))
            {

                txtTenNVCC.Text = xuly.layTenNV(txtMNVCC.Text);
            }
            else
            {
                txtTenNVCC.Text = null;
            }
        }

        private void txtMNVVP_TextChanged(object sender, EventArgs e)
        {
            BAL_NhanVien xuly = new BAL_NhanVien();

            if (xuly.KtraTonTaiNV(txtMNVVP.Text))
            {

                txtTenNVVP.Text = xuly.layTenNV(txtMNVVP.Text);
                txtLuongCB.Text = xuly.LayLuongCB(txtMNVVP.Text);
            }
            else
            {
                txtTenNVVP.Text = null;
            }
        }

        private void txtMaVP_TextChanged(object sender, EventArgs e)
        {
            BAL_ViPham xuly = new BAL_ViPham();
            if (xuly.KtraTonTaiMaVP(txtMaVP.Text))
            {
                txtNDVP.Text = xuly.layTenVP(txtMaVP.Text);
                txtTienPhat.Text = xuly.LayTienPhatNV(txtMaVP.Text).ToString();
            }
            else
            {
                txtNDVP.Text = null;
                txtTienPhat.Text = null;
            }
        }

        private void HienThiDuLieuChamCong(DataGridView dgv)
        {
            BAL_ChamCong Xuly = new BAL_ChamCong();
            dgv.DataSource = Xuly.DocDanhSachCC();
            dgv.Refresh();

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show(" Bạn có thực sự muốn thoát? ", "Thông Báo", MessageBoxButtons.YesNo);
            if (KQ == DialogResult.Yes)
            {
                this.Close();
                fromChucNang f = new fromChucNang();
                f.Show();
            }
        }

        public float TienPhatTam = 0;
        private void btnCongTienPhat_Click(object sender, EventArgs e)
        {
            TienPhatTam += float.Parse(txtTienPhat.Text);
            float luongCoBan = float.Parse(txtLuongCB.Text);
            float kqTinhLuong = luongCoBan - TienPhatTam;
            txtTienSauPhat.Text = kqTinhLuong.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string MaCC = txtMaCC.Text;
            DateTime ngVP = dtpNgayVP.Value;
            string MaNVcc = txtMNVCC.Text;
            string MaNVvp = txtMNVVP.Text;
            string MaVp = txtMaVP.Text;
            float TongLuong = float.Parse(txtTienSauPhat.Text);
            int DaXoa = 0;

            BEL_ChamCong cc = new BEL_ChamCong(MaCC, ngVP, MaNVcc, MaNVvp, MaVp, TongLuong, DaXoa);

            BAL_ChamCong xuly = new BAL_ChamCong();
            bool ketQuaThem = xuly.themCC(cc);
            if (ketQuaThem == true)
            {
                MessageBox.Show("Đã thêm thành công 1 dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDuLieuChamCong(dgvCC);
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void dgvCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaCCDangCCon = dgvCC.CurrentRow.Cells[0].Value.ToString().Trim();
            txtMaCC.Text = dgvCC.CurrentRow.Cells["MaChamCong"].Value.ToString().Trim();

            dtpNgayVP.Text = dgvCC.CurrentRow.Cells["NgayViPham"].Value.ToString();

            txtMNVCC.Text = dgvCC.CurrentRow.Cells["MaNVCC"].Value.ToString();
            txtTenNVVP.Text = dgvCC.CurrentRow.Cells["MaNVVP"].Value.ToString();
            txtMaVP.Text = dgvCC.CurrentRow.Cells["MaViPham"].Value.ToString();
            txtTienSauPhat.Text = dgvCC.CurrentRow.Cells["TongLuong"].Value.ToString();
        }

 
    }
}
