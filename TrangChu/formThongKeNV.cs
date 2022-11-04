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
using Microsoft.Reporting.WinForms;
using BEL;
using BAL;
namespace TrangChu
{
    public partial class formThongKeNV : Form
    {
        public formThongKeNV()
        {
            InitializeComponent();
        }

        private void formThongKeNV_Load(object sender, EventArgs e)
        {



            this.rptNV.RefreshReport();
        }

        

        private void btnOK_Click(object sender, EventArgs e)
        {
            BAL_NhanVien xuly= new BAL_NhanVien();
            DataSet ds = new DataSet();
            if(radTKtheoMa.Checked==true)
            {
                string ma= txtMaNV.Text;
                ds= xuly.TimNVTheoMa(ma);
            }
            else if(radInDsNV.Checked==true && radTKtheoMa.Checked==false)
            {
                ds = xuly.indsNV();
            }
            rptNV.LocalReport.DataSources.Clear();
            rptNV.RefreshReport();
            rptNV.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rptNV.LocalReport.ReportPath = "rptNhanVien.rdlc";
            if(radInDsNV.Checked==false && radTKtheoMa.Checked==false)
            {
                MessageBox.Show("Chua chon chuc nang", "Thong bao",MessageBoxButtons.OK, MessageBoxIcon.Information);
                rptNV.LocalReport.DataSources.Clear();
                rptNV.RefreshReport();
            }
            else if (ds.Tables[0].Rows.Count>0)
            {
                ReportDataSource rds = new ReportDataSource();
                rptNV.LocalReport.DataSources.Clear();
                rds.Name = "datasetNhanVien";
                rds.Value = ds.Tables[0];

                rptNV.LocalReport.DataSources.Add(rds);
                rptNV.RefreshReport();
            }
           
        }

        private void radTKtheoMa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTKtheoMa.Checked == false)
            {
                txtMaNV.Enabled = false;
            }
            else
            {
                txtMaNV.Enabled = true;
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            FromQLNS f = new FromQLNS();
            f.Show();
            this.Hide();
        }

       
    }
}
