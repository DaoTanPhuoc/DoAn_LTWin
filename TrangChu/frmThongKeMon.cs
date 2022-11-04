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
    public partial class frmThongKeMon : Form
    {
        public frmThongKeMon()
        {
            InitializeComponent();
        }

        private void frmThongKeMon_Load(object sender, EventArgs e)
        {
            this.rptTKMon.RefreshReport();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmThemMon f = new frmThemMon();
            f.Show();
            this.Hide();
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            BAL_Mon xuLyMon = new BAL_Mon();
            DataSet ds = new DataSet();
            if (radTCM.Checked == true)
            {
                ds = xuLyMon.thongkeTatCaMon();
            }
            else if (radmondx.Checked == false && radht.Checked == true && radTCM.Checked == false)
            {
                ds = xuLyMon.thongkeMonHT();
            }
            else if (radmondx.Checked == true && radht.Checked == false && radTCM.Checked == false)
            {
                ds = xuLyMon.thongkeMonDaXoa();
            }
            rptTKMon.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rptTKMon.LocalReport.ReportPath = "rptMon.rdlc";
            if (radmondx.Checked == false && radht.Checked == false && radTCM.Checked == false)
            {
                MessageBox.Show(" Vui lòng chọn chức năng !!", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rptTKMon.LocalReport.DataSources.Clear();
                rptTKMon.RefreshReport();
            }
            else if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rptTKMon.LocalReport.DataSources.Clear();
                rds.Name = "dsMon";
                rds.Value = ds.Tables[0];
                rptTKMon.LocalReport.DataSources.Add(rds);
                rptTKMon.RefreshReport();
            }
        }
    }
}
