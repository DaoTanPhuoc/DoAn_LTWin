using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BEL;
using BAL;

namespace TrangChu
{
    public partial class HoaDonNhapKho : Form
    {
        public HoaDonNhapKho()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show(" Bạn có thực sự muốn thoát? ", "Thông Báo", MessageBoxButtons.YesNo);
            if (KQ == DialogResult.Yes)
            {
                FormNguyenLieu f = new FormNguyenLieu();
                f.Show();
                this.Hide();
            }
        }

        private void HienThiHDN(DataGridView dgv)
        {
            BAL_HoaDonNhap xuly= new BAL_HoaDonNhap ();
            dgv.DataSource = xuly.Dochdn();
        }

        private void HienThiCTHD(DataGridView dgvCT)
        {
            BAL_CTHDN xuly= new BAL_CTHDN ();
            dgvCT.DataSource = xuly.DocCThd();
        }


     


        
        private void HoaDonNhapKho_Load(object sender, EventArgs e)
        {
            HienThiHDN(dgvHDN);

            HienThiCTHD(dgvCTHD);
            BAL_HoaDonNhap xuLy = new BAL_HoaDonNhap();
            txtMaNguyenLieu.Text = xuLy.loadMaNL();
            taoMaHD();
        }

        private void taoMaHD()
        {
            //lấy ngày giờ hiện tại
            DateTime dateTime = DateTime.Now;
            // txtNgayGio.Text = dateTime.ToString();
            txtMaHoaDonNhap.Text = dateTime.ToString().Replace(" ", "").Replace(":", "").Replace("/", "").Replace("-", "");
        }
        private float TinhTongTien()
        {
            float tongtien;
            int sl = int.Parse(txtSoLuong.Text);
            float dongia = float.Parse(txtDonGia.Text);
            tongtien = sl * dongia;
            return tongtien;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            

            DataTable dt = new DataTable();

            string mahdL=txtMaHoaDonNhap.Text;
            DateTime Ngaylaphd=dtpNgayLapHD.Value;
            string maNVlap=txtMaNVLap.Text;
            DateTime NgNhan = dtpNgayNhan.Value;

            HoaDonNhap hdn= new HoaDonNhap(mahdL,Ngaylaphd,maNVlap,NgNhan);
            BAL_HoaDonNhap xuly = new BAL_HoaDonNhap();
            bool kq = xuly.Themhdn(hdn);
            if(kq==true)
            {
                MessageBox.Show("Đã thêm thành công 1 nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiHDN(dgvHDN);
            }
            else
            {
                MessageBox.Show("Thêm thất bại !","Thông Báo ",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string manl = txtMaNguyenLieu.Text;
            float donGia =float.Parse( txtDonGia.Text);
            int slNhap = int.Parse(txtSoLuong.Text);
            float thanhTien = float.Parse(txtThanhTien.Text);

            CT_HDK CTHD = new CT_HDK(mahdL,manl,donGia,slNhap,thanhTien);
            BAL_CTHDN xuLyCTHD = new BAL_CTHDN();
            bool kqCT = xuLyCTHD.ThemCTHD(CTHD);
            if(kq==true)
            {
                MessageBox.Show("Đã thêm thành công 1 nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiCTHD(dgvCTHD);
            }
            else
            {
                MessageBox.Show("Thêm thất bại !", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if(txtDonGia.Text.Count()>0)
            {
               txtThanhTien.Text= TinhTongTien().ToString();
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Count() > 0)
            {
                txtThanhTien.Text = TinhTongTien().ToString();
            }
        }

     
    }
}
