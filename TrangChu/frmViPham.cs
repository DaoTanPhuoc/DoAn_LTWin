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
    public partial class frmViPham : Form
    {
        public frmViPham()
        {
            InitializeComponent();
        }

        private void frmViPham_Load(object sender, EventArgs e)
        {
            loadVP(dgvVP);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            fromChucNang f = new fromChucNang();
            f.Show();
            this.Hide();
        }


        // thêm vi phạm 
        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string mavp = txtMaVP.Text;
            string NDVP = txtNDVP.Text;
            float TienVP = float.Parse(txtTienVP.Text);
            int DaXoa = 0;

            BEL_ViPham vp = new BEL_ViPham(mavp, NDVP, TienVP, DaXoa);

            BAL_ViPham xulyThem = new BAL_ViPham();
            bool kq = xulyThem.ThemVP(vp);
            if (kq == true)
            {
                MessageBox.Show("Đã thêm thành công 1 VP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadVP(dgvVP);
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void loadVP(DataGridView dgv)
        {
            BAL_ViPham xuly = new BAL_ViPham();
            dgv.DataSource = xuly.LoadViPham();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            string ma = txtMaVP.Text;
            string ten = txtNDVP.Text;
            float tientru = float.Parse(txtTienVP.Text);
            int DaXoa = 0;
            BEL_ViPham vp = new BEL_ViPham(ma, ten, tientru, DaXoa);

            BAL_ViPham xuly = new BAL_ViPham();
            bool ketQuaSua = xuly.suaVP(vp);
            if (ketQuaSua == true)
            {
                MessageBox.Show("Đã sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadVP(dgvVP);
            }
            else
                MessageBox.Show("sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public string MaVPDangCon = null;
        private void dgvVP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MaVPDangCon = dgvVP.CurrentRow.Cells[0].Value.ToString().Trim();
            txtMaVP.Text = dgvVP.CurrentRow.Cells["maViPham"].Value.ToString().Trim();

            txtNDVP.Text = dgvVP.CurrentRow.Cells["noiDungViPham"].Value.ToString();
            txtTienVP.Text = dgvVP.CurrentRow.Cells["tienTruLuong"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string ma = txtMaVP.Text;
            string ten = txtNDVP.Text;
            float tienTru = float.Parse(txtTienVP.Text);
            int DaXoa = 0;
            BEL_ViPham vp = new BEL_ViPham(ma, ten, tienTru, DaXoa);

            BAL_ViPham xuly = new BAL_ViPham();
            bool ketQuaSua = xuly.xoaVP(vp);
            if (ketQuaSua == true)
            {
                MessageBox.Show("Đã xóa thành công một nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadVP(dgvVP);
                txtMaVP.Clear();
                txtNDVP.Clear();
                txtTienVP.Clear();

                txtMaVP.Focus();
            }
            else
                MessageBox.Show("xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
