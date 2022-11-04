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
using Microsoft.Reporting.WinForms;


namespace TrangChu
{
    public partial class FormThongKeTinhLuong : Form
    {
        public FormThongKeTinhLuong()
        {
            InitializeComponent();
        }

        private void FormThongKeTinhLuong_Load(object sender, EventArgs e)
        {
            BAL_NhanVien xuly = new BAL_NhanVien();
            
            DataSet ds = new DataSet();
            ds = xuly.TinhTongLuong();
            

            rptTinhLuong.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rptTinhLuong.LocalReport.ReportPath = "TinhTongLuongNV.rdlc";

            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];

                rptTinhLuong.LocalReport.DataSources.Add(rds);
                rptTinhLuong.RefreshReport();
            }
            this.rptTinhLuong.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FromQLNS f = new FromQLNS();
            f.Show();
            this.Hide();
        }
    }
}
