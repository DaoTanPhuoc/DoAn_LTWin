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
using Microsoft.Reporting.WinForms;

namespace TrangChu
{
    public partial class frmThongKeKH : Form
    {
        public frmThongKeKH()
        {
            InitializeComponent();
        }

        private void frmThongKeKH_Load(object sender, EventArgs e)
        {
            this.rptKH.RefreshReport();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.Show();
            this.Hide();
        }

        private void btnInDS_Click(object sender, EventArgs e) //Tất cả khách hàng
        {
            BAL_KhachHang xuLyKH = new BAL_KhachHang();
            DataSet ds = new DataSet();
            if (cbTCKH.Checked == true)
            {
                ds = xuLyKH.thongKeTCKH();
            }
            else if (radKHDaXoa.Checked == false && radKHHT.Checked == true && cbTCKH.Checked == false) //Khách hàng hiện tại 
            {
                ds = xuLyKH.thongKeHT();
            }
            else if (radKHDaXoa.Checked == true && radKHHT.Checked == false && cbTCKH.Checked == false)  //Khách hàng đã xoá
            {
                ds = xuLyKH.thongKeDX();
            }
            rptKH.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rptKH.LocalReport.ReportPath = "rptKhachHang.rdlc";
            if (radKHDaXoa.Checked == false && radKHHT.Checked == false && cbTCKH.Checked == false)
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rptKH.LocalReport.DataSources.Clear();
                rptKH.RefreshReport();
            }
            else if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rptKH.LocalReport.DataSources.Clear();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];
                rptKH.LocalReport.DataSources.Add(rds);
                rptKH.RefreshReport();
            }
        }

        private void cbTCKH_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTCKH.Checked == true)
            {
                radKHHT.Enabled = false;
                radKHDaXoa.Enabled = false;
            }
            else
            {
                radKHHT.Enabled = true;
                radKHDaXoa.Enabled = true;
            }
        }

    
    }
}
