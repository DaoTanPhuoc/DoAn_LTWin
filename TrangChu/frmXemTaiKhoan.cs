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
    public partial class frmXemTaiKhoan : Form
    {
        public frmXemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangKy frmDangKy = new frmDangKy();
            frmDangKy.Show();
            this.Hide();
        }

        private void frmXemTaiKhoan_Load(object sender, EventArgs e)
        {
            hienThiDSTaiKhoan(dgvDSTK);
        
        }

        public void hienThiDSTaiKhoan(DataGridView dgv)
        {
            BAL_TaiKhoan xuLy = new BAL_TaiKhoan();
            dgv.DataSource = xuLy.hienThiDSTK();
        }

       


        private void dgvDSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDSTK.Rows[e.RowIndex];

                txtIDDangChon.Text = Convert.ToString(row.Cells["ID"].Value);
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (txtIDDangChon.Text.Length > 0)
            {
                BAL_TaiKhoan xuLyTK = new BAL_TaiKhoan();
                bool kqXoa = xuLyTK.xoaTK(txtIDDangChon.Text);
                if (kqXoa)
                {
                    MessageBox.Show("Xoá Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThiDSTaiKhoan(dgvDSTK);
                }
                else
                {
                    MessageBox.Show("Xoá Không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
                MessageBox.Show("Vui lòng chọn thông tin Tài khoản!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void radXoaTK_CheckedChanged(object sender, EventArgs e)
        {
            if(radXoaTK.Checked == true && radDoiMK.Checked == false)
            {
                btnDoiMK.Visible = false;
                btnXoaTK.Visible = true;
                lblMK.Visible = false;
                txtDoiMK.Visible = false;
            }
            else
            {
                btnDoiMK.Visible = true;
                btnXoaTK.Visible = false;
                lblMK.Visible = true;
                txtDoiMK.Visible = true;

            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if(txtIDDangChon.Text.Length>0)
            {
                if (txtDoiMK.Text.Length > 0)
                {
                    string pass = MaHoa( txtDoiMK.Text);
                    string ID =txtIDDangChon.Text;
                    BAL_TaiKhoan xuLyTK = new BAL_TaiKhoan();
                    bool KQSuaMK = xuLyTK.suaMKTK(ID, pass);
                    if (KQSuaMK==true)
                    {
                        MessageBox.Show("Đổi Mật Khẩu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThiDSTaiKhoan(dgvDSTK);
                    }
                }
                else
                {
                    MessageBox.Show("Nhập Mật Khẩu Cần Đổi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Vui lòng chọn thông tin Tài khoản!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
