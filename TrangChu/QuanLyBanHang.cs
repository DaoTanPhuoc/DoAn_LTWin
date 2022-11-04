using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;
using BEL;
using BAL;

namespace TrangChu
{
    public partial class fromQLBH : Form
    {
        private void btnQLBH_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("bạn có thực sự muốn thoát? ", "Thông Báo", MessageBoxButtons.YesNo);
            if (KQ == DialogResult.Yes)
            {
                this.Close();
                fromChucNang f = new fromChucNang();
                f.Show();
            }
        }
        public fromQLBH()
        {
            InitializeComponent();
        }

        private void fromQLBH_Load(object sender, EventArgs e)
        {
            //Add hình lên tab
            ImageList iconsList = new ImageList();
            iconsList.TransparentColor = Color.Blue;
            iconsList.ColorDepth = ColorDepth.Depth32Bit;
            iconsList.ImageSize = new Size(30, 30);
            iconsList.Images.Add(Image.FromFile("img tong/imgIcon/TraSua.PNG"));
            iconsList.Images.Add(Image.FromFile("img tong/imgIcon/ThongKe.PNG"));

            tbctHoaDonBH.ImageList = iconsList;
            tbChonMon.ImageIndex = 0;
            tbThongKeHD.ImageIndex = 1;

           
            thongTinHD();
            hienThiDSMon(dtGrMon);
            ngayGioLapHD();
            loadNV();
            loadKhachHang(cboMaKH);



            this.rptHDBH.RefreshReport();
        }
        //load nhanvien thu ngan
        //string MAKH;
        private void loadNV()
        {
            DataTable dt = new DataTable();
            BAL_TaiKhoan xuLyTK = new BAL_TaiKhoan();
            dt = xuLyTK.get_UserInfo();
            txtNhanVien.Text =layTenNV(dt.Rows[0]["Username"].ToString());
        }
        private string layTenNV(string maNV)
        {
            BAL_NhanVien xuLyNV = new BAL_NhanVien();
            return xuLyNV.layTenNV(maNV);
        }

        //private void cboMaKH_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    string maKH = cboMaKH.SelectedItem.ToString();
        //    BAL_KhachHang xuLyLayTenKH = new BAL_KhachHang();
        //    txtKhachHang.Text = xuLyLayTenKH.layTenKH(maKH);
        //}
        //private string layTenKH(string makh)
        //{

        //    return xuLyLayTenKH.layTenKH(cboMaKH.Text);
        //}

        private void loadKhachHang(ComboBox cbo)
        {

            BAL_KhachHang xuLyKH = new BAL_KhachHang();
            cbo.DataSource = xuLyKH.layThTinKH();


            cbo.DisplayMember = "MaKH";
        }
        //phát sinh mã HD
        public void thongTinHD()
        {
            //lấy ngày giờ hiện tại
            DateTime dateTime = DateTime.Now;
            // txtNgayGio.Text = dateTime.ToString();
            txtMaHD.Text = dateTime.ToString().Replace(" ", "").Replace(":", "").Replace("/", "").Replace("-", "");

        }

        //Hiển thị món
        public void hienThiDSMon(DataGridView cf)
        {
            string loaiMon = null;
            if (radCaFe.Checked == true)
            {
                loaiMon = "Cafe";
            }
            else if (radTraSua.Checked == true)
            {
                loaiMon = "TraSua";
            }
            else if (radBanh.Checked == true)
            {
                loaiMon = "Banh";
            }

            BAL_Mon xuLyMon = new BAL_Mon();
            cf.DataSource = xuLyMon.layDanhSachMon(loaiMon);
        }

        //Ngày Giờ Lập HD
        public DateTime ngaLapHD;
        public void ngayGioLapHD()
        {
            ngaLapHD = DateTime.Now;

            txtNgayLapHD.Text = ngaLapHD.ToString();
        }

        private List<CT_HDBH> dsMon = new List<CT_HDBH>();
        private CT_HDBH cthd;
        //Sự kiện cellClick 
        private void dtGrMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtGrMon.Rows[e.RowIndex];

                string maMon = Convert.ToString(row.Cells["MaMon"].Value);
                string tenMon = layTenMon(maMon).Trim();
                string loaiMon = Convert.ToString(row.Cells["LoaiMon"].Value);
                float donGia = Convert.ToInt64(row.Cells["DonGia"].Value);
                string tinhTrang = Convert.ToString(row.Cells["TinhTrang"].Value);
                string donVi = Convert.ToString(row.Cells["DonVi"].Value);
                int soLuong = 1;
                float chietKhau = float.Parse(txtChietKhau.Text);
                cthd = new CT_HDBH(txtMaHD.Text, maMon, soLuong, donVi, donGia, chietKhau, 0);

                themHD(cthd, dsMon);

                lstHD.Refresh();
                hienThiDSMonDaChon(lstHD, dsMon);
                tongTien();
            }




        }

        //Thêm món vào Lisview HD
        private void themHD(CT_HDBH mon, List<CT_HDBH> m)
        {

            int check = 0;
            foreach (CT_HDBH ct in m)
            {
                if (ct.MaMon == cthd.MaMon)
                {
                    ct.SoLuong++;
                    check = 1;

                    continue;
                }
            }
            if (check == 0)
                m.Add(mon);
            lstHD.Items.Clear();

        }

        //Hiển thị DS món đã chọn lên listview
        private void hienThiDSMonDaChon(ListView lv, List<CT_HDBH> dsmon)
        {
            foreach (CT_HDBH m in dsmon)
            {
                string tenMon = layTenMon(m.MaMon).Trim();
                ListViewItem lvi = new ListViewItem(m.SoLuong.ToString());
                lvi.SubItems.Add(m.MaMon);
                lvi.SubItems.Add(tenMon);
                lvi.SubItems.Add(m.DVT1);
                lvi.SubItems.Add(m.DonGia.ToString());
                float donGia = m.DonGia;
                m.ThanhTien = m.SoLuong * donGia;
                lvi.SubItems.Add(m.ThanhTien.ToString());

                lv.Items.Add(lvi);
            }
        }

        //Hàm lấy tên món từ mã món
        public string layTenMon(string maMon)
        {
            BAL_Mon xuLyMon = new BAL_Mon();
            return xuLyMon.layTenMon(maMon);
        }

        //xử lý rad caFe
        private void hienThiDSMonCF_checkChanged(object sender, EventArgs e)
        {
            if (radCaFe.Checked == true)
            {
                hienThiDSMon(dtGrMon);
            }
            else
                return;
        }

        //xử lý rad Trà sữa
        private void hienThiDSMonTS_checkChanged(object sender, EventArgs e)
        {

            if (radTraSua.Checked == true)
            {
                hienThiDSMon(dtGrMon);
            }
            else
                return;
        }

        //xử lý rad Bánh
        private void hienThiDSMonBA_checkChanged(object sender, EventArgs e)
        {
            if (radBanh.Checked == true)
            {
                hienThiDSMon(dtGrMon);
            }
            else
                return;
        }



        //timg kiếm SP
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dtTimMon = new DataTable();
            string cachTim = cboCachTim.SelectedItem.ToString();
            string timKiem = txtTimKiem.Text;
            BAL_Mon xuLyTimMon = new BAL_Mon();
            dtGrMon.DataSource = xuLyTimMon.timKiemMon(cachTim, timKiem);
        }

        //Tăng Số Lượng món trong HD
        string maDangChon;
        private void btnCongMon_Click(object sender, EventArgs e)
        {
            foreach (CT_HDBH ct in dsMon)
            {

                if (maDangChon == ct.MaMon)
                {
                    ct.SoLuong++;
                    break;
                }
            }

            lstHD.Items.Clear();
            lstHD.Refresh();
            hienThiDSMonDaChon(lstHD, dsMon);
            tongTien();
        }
        //Giảm số lượng món trong HD
        private void btnTruMon_Click_1(object sender, EventArgs e)
        {
            foreach (CT_HDBH ct in dsMon)
            {
                if (maDangChon == ct.MaMon)
                {
                    if (ct.SoLuong < 2)
                        return;
                    else
                    {
                        ct.SoLuong--;
                        break;
                    }
                }
            }
            lstHD.Items.Clear();
            lstHD.Refresh();
            hienThiDSMonDaChon(lstHD, dsMon);
            tongTien();
        }

        //món đang chọn trong listview
        private void lstHD_SelectedIndexChanged(object sender, MouseEventArgs e)
        {
            maDangChon = lstHD.SelectedItems[0].SubItems[1].Text;
            // nếu đã chọn món thì hiện nút tăng giảm số lượng món có trong HD
            if (maDangChon != null)
            {
                btnXoa.Enabled = true;
                btnTruMon.Enabled = true;
                btnCongMon.Enabled = true;
            }
        }

        // Tính tổng tiền HD
        public void tongTien()
        {
            float tong = 0;
            foreach (CT_HDBH ct in dsMon)
            {
                tong += ct.ThanhTien;
            }
            float Chkhau = float.Parse(txtChietKhau.Text);
            tong = tong - (tong * (Chkhau / 100));
            txtTongTien.Text = tong.ToString();
        }

        //xoá món đang chon trong listView
        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (CT_HDBH ct in dsMon)
            {

                if (maDangChon == ct.MaMon)
                {
                    dsMon.Remove(ct);
                    break;
                }
            }

            lstHD.Items.Clear();
            lstHD.Refresh();
            hienThiDSMonDaChon(lstHD, dsMon);
            tongTien();
        }

        //Huỷ hoá đơn
        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            dsMon.Clear();
            lstHD.Refresh();
            lstHD.Items.Clear();
            hienThiDSMonDaChon(lstHD, dsMon);
            tongTien();
        }

        //tính tổng tền khi thay đổi giá trị chiết khấu
        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            //nếu chiết khấu có độ dài khác không
            if (txtChietKhau.Text.Length != 0)
                tongTien();
        }

        //Lưu hoá đơn tính tiền
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            BAL_HDBH xuLyHDBH = new BAL_HDBH();
            if (xuLyHDBH.kTraMaHD(txtMaHD.Text) == true)
            {
                //nếu chưa chọn món thì thông báo lỗi
                if (dsMon.Count <= 0)
                {
                    MessageBox.Show("Vui lòng chọn món!!", "Thông báo!");
                    return;
                }
                BAL_NhanVien xuLyNV = new BAL_NhanVien();
                string maHD = txtMaHD.Text;
                string maMon = null, DVT = null;
                int soLuong = 0;
                float donGia = 0, chietKhau = 0, thanhTien = 0;

                string maNV =xuLyNV.layMaNV(txtNhanVien.Text);
                float tongTien = Convert.ToInt64(txtTongTien.Text);
                BAL_KhachHang xuLyKH = new BAL_KhachHang();
                string MaKH = cboMaKH.Text.Trim();

                //thêm vô bảng HDBH
                HDBH hdbh = new HDBH(maHD, ngaLapHD, MaKH, maNV, tongTien, 0);

                bool kqhdbh = xuLyHDBH.themHDBH(hdbh);
                if (kqhdbh == true)
                {
                    MessageBox.Show("Thêm thành công [HDBH]", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo!");
                    return;
                }


                //Thêm vô bảng CTHDBH
                foreach (CT_HDBH ct in dsMon)
                {
                    chietKhau = ct.ChietKhau;
                    DVT = ct.DVT1;
                    soLuong = ct.SoLuong;
                    maMon = ct.MaMon;
                    donGia = ct.DonGia;
                    thanhTien = ct.ThanhTien;
                    CT_HDBH cthd = new CT_HDBH(maHD, maMon, soLuong, DVT, donGia, chietKhau, thanhTien);
                    BAL_CT_HDBH xulyCTHDBH = new BAL_CT_HDBH();
                    bool kq = xulyCTHDBH.themCTHD(cthd);

                }
            }
            else
                MessageBox.Show("Hoá Đơn Dã có!\n Vui lòng Reset lại tạo hoá đơn mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //load lại hoá đơn
        private void btnReSetHD_Click(object sender, EventArgs e)
        {

            txtGiamGia.Text = "";
            txtChietKhau.Text = "0";
            dsMon.Clear();
            lstHD.Refresh();
            lstHD.Items.Clear();
            hienThiDSMonDaChon(lstHD, dsMon);
            tongTien();
            this.OnLoad(e);
        }

        //Ktra Giảm Giá
        public float KtraGiamGia()
        {
            return 0;
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            BAL_HDBH xuLyGanMaHD = new BAL_HDBH();
            bool ganMaHD = xuLyGanMaHD.ganMaHD(txtMaHD.Text);
            if (ganMaHD == false)
            {
                MessageBox.Show("Vui lòng lưu hoá đơn!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmReportHDBH rb = new frmReportHDBH();
            rb.ShowDialog();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            BAL_GiamGia xuLyMaGiamGia = new BAL_GiamGia();

            string layMa = xuLyMaGiamGia.layMaGiamGIa().Rows[0]["MaGiamGia"].ToString().Trim();
            if (txtGiamGia.Text.Count() > 0)
            {
                if (txtGiamGia.Text.Trim() == layMa)
                {
                    float discount = xuLyMaGiamGia.layDiscount(txtGiamGia.Text) / 100;
                    txtChietKhau.Text = discount.ToString();
                }
                else
                {
                    txtChietKhau.Text = "0";
                }
            }
        }


        //Thống Kê Hoá Đơn
        private void btnTimHD_Click(object sender, EventArgs e)
        {
            BAL_HDBH xuLyHDBH = new BAL_HDBH();
            BAL_CT_HDBH xuLyCTHDBH = new BAL_CT_HDBH();
            DataSet dsHoaDonBH = new DataSet();
            DataSet dsCTHoaDonBH = new DataSet();
            dsHoaDonBH.Clear();
            dsCTHoaDonBH.Clear();
       

            if (radTatCa.Checked == true&&radTheoNgay.Checked==false)
            {
                dsHoaDonBH = xuLyHDBH.layTatCaHD();
                dsCTHoaDonBH = xuLyCTHDBH.layTatCaCTHDBH();
            }
            else if(radTheoNgay.Checked == true&&radTatCa.Checked==false)
            {
                dsHoaDonBH =xuLyHDBH.layHoaDonBHTheoNgay(dtNgLapHD.Value);
                dsCTHoaDonBH = xuLyCTHDBH.layTatCaCTHD_TheoNgay(dtNgLapHD.Value);
            }
            rptHDBH.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rptHDBH.LocalReport.ReportPath = "rdlcThongKeHDBH.rdlc";
            if (dsHoaDonBH.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rptHDBH.LocalReport.DataSources.Clear();
                rds.Name = "tbHDBH";
                rds.Value = dsHoaDonBH.Tables[0];

                ReportDataSource rds1 = new ReportDataSource();
                rds1.Name = "tbCT_HDBH";
                rds1.Value = dsCTHoaDonBH.Tables[0];

                rptHDBH.LocalReport.DataSources.Add(rds);
                rptHDBH.LocalReport.DataSources.Add(rds1);
         
                rptHDBH.RefreshReport();
            }
        }

        //Chỉ cho nhập số
        private void txtChietKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar>=42 && e.KeyChar<=57|| e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled=true;
            }    
        }

        private void rptHDBH_Load(object sender, EventArgs e)
        {

        }
    }
}
