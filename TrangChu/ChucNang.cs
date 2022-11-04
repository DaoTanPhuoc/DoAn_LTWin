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
using System.Data;
using System.Data.SqlClient;

namespace TrangChu
{
    public partial class fromChucNang : Form
    {
        // kiểm tra thoát
        bool KtraThoat = true;
        public fromChucNang()
        {
            InitializeComponent();
        }


        private void fromChucNang_Load(object sender, EventArgs e)
        {
            phanQuyen();
        }

        private void phanQuyen()
        {
            BAL_TaiKhoan xuLy = new BAL_TaiKhoan();
            DataTable dt = new DataTable();
            dt = xuLy.get_UserInfo();
            if (dt.Rows[0]["ChucVu"].ToString().Trim()== "CV002")
            {
                btnQLNS.Enabled=false ;
                btnQLThemMon.Enabled=false ;
                btnQLThemMon.Enabled = false ;
                btnQuanLyKho.Enabled=false ;
                btnQLChamCong.Enabled=false ;
                btnQLVP.Enabled=false ;
                btnQLKH.Enabled=false ;
                btndangky.Enabled = false;
            }
            else if(dt.Rows[0]["ChucVu"].ToString().Trim() == "CV003")
            {
                btnQLNS.Enabled = false;
                btnQLThemMon.Enabled = false;
                btnBanHang.Enabled=false ;
                btnQLKH.Enabled = false;
                btnQLChamCong.Enabled = false;
                btnQLVP.Enabled = false;
                btndangky.Enabled = false;
            }
        }

        // đăng xuất
        private void button1_Click(object sender, EventArgs e)
        {
            KtraThoat=false;
            this.Close();
            FromDangNhap f= new FromDangNhap();
            f.Show();
        }

        // quản lý nhân sự
        private void btnQLNS_Click(object sender, EventArgs e)
        {
            FromQLNS f= new FromQLNS();
            f.Show();
            this.Hide();
        }



        // tạo event cho chương trình (fromClose) -> để bấm nút x thoát luôn 
        private void fromChucNang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (KtraThoat == true)
            {
                Application.Exit();
            }
        }

        //btnThoat ở from chức năng
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (KtraThoat == true)
            {
                Application.Exit();
            }
        }

        // quản lý bán hàng
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            fromQLBH f= new fromQLBH();
            f.Show();
            this.Hide();
        }


        private void btnQuanLyKho_Click(object sender, EventArgs e)
        {
            FormNguyenLieu f= new FormNguyenLieu();
            f.Show();
            this.Hide();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            frmKhachHang f= new frmKhachHang();
            f.Show();
            this.Hide();
        }

        private void btnQLThemMon_Click(object sender, EventArgs e)
        {
            frmThemMon f = new frmThemMon();
            f.Show();
            this.Hide();
        }


        private void btnQLChamCong_Click(object sender, EventArgs e)
        {
            frmChamCong f= new frmChamCong();
            f.Show();
            this.Hide();
        }

        private void btnQLVP_Click(object sender, EventArgs e)
        {
            frmViPham f = new frmViPham();
            f.Show();
            this.Hide();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {

            frmDangKy dk = new frmDangKy();
            dk.Show();
            this.Hide();
        }
    }
}
