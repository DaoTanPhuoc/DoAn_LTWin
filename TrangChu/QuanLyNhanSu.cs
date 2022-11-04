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
using System;
using System.IO;
using BEL;
using BAL;
using System.Data.OleDb;


namespace TrangChu
{
    public partial class FromQLNS : Form
    {
        public string MaNVDangCCon = null;

        //public SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-8UN64H4C; Initial Catalog=QLTS; Integrated Security=True");
        



        public FromQLNS()
        {
            InitializeComponent();
        }

        private void btnQLNS_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có thực sự muốn thoát ? ", "Thông Báo", MessageBoxButtons.YesNo);
            if (KQ == DialogResult.Yes)
            {
                this.Close();
                fromChucNang f = new fromChucNang();
                f.Show();
            }
        }

        private void btnDuyetAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "jpg(*.jpg)|*.jpg|All files (*.*)|*.*";
            dlg.Title = "Mo file anh ";
            string files = null;
            if (dlg.ShowDialog() == DialogResult.OK)
             {
                files = dlg.FileName;
                ptbHinhAnh.BackgroundImageLayout = ImageLayout.Stretch;
                ptbHinhAnh.Image = Image.FromFile(files);
                LayHinhandCoppy(files);
                txtHinh.Text = files;
            }
        }


        private string LayHinhandCoppy(string url)
        {

            int VT = url.LastIndexOf("\\");
            string ten = url.Substring(VT + 1);
            File.Copy(url, "img\\" + ten,true);
            return ten;
        }

        private string LayHinhAnh(string url)
        {
            int VT = url.LastIndexOf("\\");
            string ten=url.Substring(VT + 1);
            return ten;
        }

        private void copyAnh(string url)
        {
            File.Copy(url, "img\\");
        }
       
        DataGridView row = new DataGridView();
     




        private void FromQLNS_Load(object sender, EventArgs e)
        {
            HienThiDuLieuNhanVien(dgvNV);
            loadTenCV(cboChucVu);
            
        }

        private void loadTenCV(ComboBox cbo)
        {
            BAL_ChucVu xuLy = new BAL_ChucVu();
            cbo.DataSource = xuLy.layDSTenChucVu();
            cbo.DisplayMember = "TenCV";
        }

        private void HienThiDuLieuNhanVien(DataGridView dgv)
        {
            BAL_NhanVien XulyNhanVien = new BAL_NhanVien();
            dgv.DataSource = XulyNhanVien.DocDanhSachNV();
            dgv.Refresh();
            
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            string ma = txtMaNhanVien.Text;
            string ten=txtHoTen.Text;
            DateTime ngSinh=dtpNgaySinh.Value;
            string gioiTinh = null;
            if(radNam.Checked==true)
            {
                gioiTinh = "Nam";
            }
            else if(radNu.Checked==true)
            {
                gioiTinh = "Nữ";
            }
            string diaChi=txtDiaChi.Text;
            string sdt = txtSDT.Text;
            float luong = float.Parse(txtLuong.Text);
            string chucVu =layMaChucVu( cboChucVu.Text);
            string hinh = LayHinhAnh(txtHinh.Text);

            NhanVien nv = new NhanVien(ma, ten, ngSinh, gioiTinh, diaChi, sdt, luong, chucVu,hinh);

            BAL_NhanVien XuLyNhanVien = new BAL_NhanVien();
            bool ketQuaThem = XuLyNhanVien.themNhanVien(nv);
            if (ketQuaThem == true)
            {
                MessageBox.Show("Đã thêm thành công 1 nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDuLieuNhanVien(dgvNV);
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private string layMaChucVu(string tenCv)
        {
            BAL_ChucVu xuLy = new BAL_ChucVu();
            return xuLy.layMaChucVu(tenCv);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            string ma = txtMaNhanVien.Text;
            string ten = txtHoTen.Text;
            DateTime ngSinh = dtpNgaySinh.Value;
            string gioiTinh = null;
            if (radNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else if (radNu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            string diaChi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            float luong = float.Parse(txtLuong.Text);
            string chucVu =layMaChucVu(cboChucVu.Text);
            string hinh = LayHinhAnh(txtHinh.Text);
            

            NhanVien nv = new NhanVien(ma, ten, ngSinh, gioiTinh, diaChi, sdt, luong, chucVu, hinh);

            BAL_NhanVien XuLyNhanVien = new BAL_NhanVien();
            bool ketQuaSua = XuLyNhanVien.SuaNhanVien(nv);
            if (ketQuaSua == true)
            {
                MessageBox.Show("Đã sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDuLieuNhanVien(dgvNV);
            }
            else
                MessageBox.Show("sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string ma = txtMaNhanVien.Text;
            string ten = txtHoTen.Text;
            DateTime ngSinh = dtpNgaySinh.Value;
            string gioiTinh = null;
            if (radNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else if (radNu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            string diaChi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            float luong = float.Parse(txtLuong.Text);
            string chucVu = cboChucVu.Text;
            string hinh = txtHinh.Text;

            NhanVien nv = new NhanVien(ma, ten, ngSinh, gioiTinh, diaChi, sdt, luong, chucVu, hinh);

            BAL_NhanVien XuLyNhanVien = new BAL_NhanVien();
            bool ketQuaSua = XuLyNhanVien.XoaNhanVien(nv);
            if (ketQuaSua == true)
            {
                MessageBox.Show("Đã xóa thành công một nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDuLieuNhanVien(dgvNV);
                txtMaNhanVien.Clear();
                txtHoTen.Clear();
                txtDiaChi.Clear();
                txtSDT.Clear();
                txtLuong.Clear();
                
                txtHinh.Clear();
                txtMaNhanVien.Focus();
            }
            else
                MessageBox.Show("xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formThongKeNV f = new formThongKeNV();
            f.Show();
            this.Hide();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            FormThongKeTinhLuong f = new FormThongKeTinhLuong();
            f.Show();
            this.Hide();
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BAL_ChucVu xuLy = new BAL_ChucVu();
            MaNVDangCCon = dgvNV.CurrentRow.Cells[0].Value.ToString().Trim();
            txtMaNhanVien.Text = dgvNV.CurrentRow.Cells["MaNV"].Value.ToString().Trim();

            txtHoTen.Text = dgvNV.CurrentRow.Cells["HoTenNV"].Value.ToString();
            dtpNgaySinh.Text = dgvNV.CurrentRow.Cells["NgSinh"].Value.ToString();
            string gioiTinh = null;
            gioiTinh = dgvNV.CurrentRow.Cells["GioiTinh"].Value.ToString();
            if (gioiTinh.Equals("Nam"))
            {
                radNam.Checked = true;
                radNu.Checked = false;
            }
            else
            {
                radNu.Checked = true;
                radNam.Checked = false;
            }
            txtDiaChi.Text = dgvNV.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = dgvNV.CurrentRow.Cells["SDT"].Value.ToString();
            txtLuong.Text = dgvNV.CurrentRow.Cells["Luong"].Value.ToString();
            cboChucVu.Text = xuLy.layTenChucVu(dgvNV.CurrentRow.Cells["MaChucVu"].Value.ToString());

            string hinh = dgvNV.CurrentRow.Cells["HinhAnh"].Value.ToString();
            ptbHinhAnh.Image = Image.FromFile("img\\" + hinh);
            txtHinh.Text = hinh;
        }

        
    }
}
