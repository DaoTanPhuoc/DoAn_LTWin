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
using BAL;
using System.Security.Cryptography;


namespace TrangChu
{
    public partial class FromDangNhap : Form
    {
        public FromDangNhap()
        {
            InitializeComponent();
        }



        private void DangNhap_Click(object sender, EventArgs e)//ảnh Login In 
        {
            string user = txtUserNam.Text;
            string pass =MaHoa( txtPass.Text);
           
            DataTable dt = new DataTable();
            BAL_TaiKhoan xuLy = new BAL_TaiKhoan();
            bool kq = xuLy.LayTK(user, pass);
            if (txtUserNam.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhap tên tài khoản!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtPass.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhap mật khẩu!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (kq)
            {
                xuLy.luuTaiKhoan(user);
                fromChucNang f = new fromChucNang();
            f.Show();
            this.Hide();// ẩn đi form đăng nhập sao khi bấm vào btnDangNhap
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FromDangNhap_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void ckHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHienMK.Checked) 
                txtPass.UseSystemPasswordChar = false;
            else 
                txtPass.UseSystemPasswordChar = true;
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có thực sự muốn thoát ? ", "Thông Báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (KQ == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        





        static string key = "2giotoitaigoccayda";
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
    }
}
