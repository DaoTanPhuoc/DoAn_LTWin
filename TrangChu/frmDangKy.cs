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
using System.Security.Cryptography;

namespace TrangChu
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            loadMaNV(cboUser);
            loadTenChucVu(cboChVu);
        }
        
        private void loadTenChucVu(ComboBox cbo)
        {
            BAL_ChucVu xuLy = new BAL_ChucVu();
            cbo.DataSource = xuLy.layDSTenChucVu();
            cbo.DisplayMember = "TenCV";
        }

        private void loadMaNV(ComboBox cbo)
        {
            BAL_NhanVien xuLy=new BAL_NhanVien();
            cbo.DataSource = xuLy.docNhanVien();
            cbo.DisplayMember = "MaNV";
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            BAL_TaiKhoan xuLy = new BAL_TaiKhoan();
            BAL_ChucVu xuLyCV = new BAL_ChucVu();
            string user = cboUser.Text;
            string pass =MaHoa(txtPass.Text);
            string maChVu =xuLyCV.layMaChucVu( cboChVu.Text);
            if (xuLy.KTUserDK(user) == false)
            {
                TaiKhoan taiKhoan = new TaiKhoan(user, pass, maChVu);

                bool kqDK = xuLy.dangKyTK(taiKhoan);
                if (kqDK)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Tài Khoản Đã Có!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        static string key = "2giotoitaigoccayda";
        //Mã Hoá
        public static string MaHoa(string toEncrypt)
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        //Giải mã
        //public static string GiaiMaHoa(string toDecrypt)
        //{
        //    bool useHashing = true;
        //    byte[] keyArray;
        //    byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

        //    if (useHashing)
        //    {
        //        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        //        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
        //    }
        //    else
        //        keyArray = UTF8Encoding.UTF8.GetBytes(key);

        //    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        //    tdes.Key = keyArray;
        //    tdes.Mode = CipherMode.ECB;
        //    tdes.Padding = PaddingMode.PKCS7;

        //    ICryptoTransform cTransform = tdes.CreateDecryptor();
        //    byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

        //    return UTF8Encoding.UTF8.GetString(resultArray);
        //}

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
            FromDangNhap dn=new FromDangNhap();
            dn.ShowDialog();
            this.Hide();
        }

        private void btnXemTK_Click(object sender, EventArgs e)
        {
            this.Close();
            frmXemTaiKhoan x = new frmXemTaiKhoan();
            x.ShowDialog();
            this.Hide();
        }
    }
}
