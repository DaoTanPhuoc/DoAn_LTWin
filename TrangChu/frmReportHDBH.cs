using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;
using BAL;


namespace TrangChu
{
    public partial class frmReportHDBH : Form
    {
        public frmReportHDBH()
        {
            InitializeComponent();
        }

        private void frmReportHDBH_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            BAL_HDBH xuLyRP = new BAL_HDBH();
            fromQLBH qlbh = new fromQLBH();


            ds = xuLyRP.layHDHienTai();
            

            //Khai báo chế độ xử lý báo cáo ở local
            rptHoaDon.ProcessingMode = ProcessingMode.Local;
            //chế độ xem report
            // rptHoaDon.SetDisplayMode(DisplayMode.PrintLayout);// đặt chế dộ hiệm thij xem trước khi in
            // rptHoaDon.ZoomMode = ZoomMode.Percent;
            // rptHoaDon.ZoomPercent = 100;
            rptHoaDon.LocalReport.ReportPath = "Report_HDBH.rdlc";

            //nếu có DL
            if (ds.Tables[0].Rows.Count > 0)
            {
                //tạo nguồn DL cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "ViewHDBH";
                rds.Value = ds.Tables[0];
                //Xoá DL báo cáo cũ trong trương hợp ng dung thực hiện câu truy vấn khác
                rptHoaDon.LocalReport.DataSources.Clear();
                //add DL vao báo cáo
                rptHoaDon.LocalReport.DataSources.Add(rds);
                //Reresh lại báo cáo
                rptHoaDon.RefreshReport();
            }
            else
            {
                MessageBox.Show("Vui lòng lưu hoá đơn", "thông báo");
                this.Close();
            }
        }
    }
}
