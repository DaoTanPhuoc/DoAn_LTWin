using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BEL;

namespace BAL
{
    public class BAL_Mon
    {
        public DataTable layDanhSachMon(string loaiMon)
        {
            DAL_Mon xuLyMon=new DAL_Mon();
            return xuLyMon.docDSMon(loaiMon);
        }

        public string layTenMon(string maMon)
        {
            DAL_Mon xuLyMon = new DAL_Mon();
            return xuLyMon.layTenMon(maMon);
        }

        public DataTable timKiemMon(string cachTim, string ndTim)
        {
            DAL_Mon xuLyMon=new DAL_Mon();
            return xuLyMon.timKiemMon(cachTim, ndTim);
        }


        //Của MÃn
        public DataTable DocDanhSachMon()
        {
            DAL_Mon xuLyMon = new DAL_Mon();
            return xuLyMon.DocDanhSachMon();
        }
        public bool themMon(Mon mon)
        {
            DAL_Mon xyLyMon = new DAL_Mon();
            return xyLyMon.themMon(mon);
        }
        public bool xoaMon(Mon mon)
        {
            DAL_Mon xuLyMon = new DAL_Mon();
            return xuLyMon.xoaMon(mon);
        }
        public bool suaMon(Mon mon)
        {
            DAL_Mon xuLyMon = new DAL_Mon();
            return xuLyMon.suaMon(mon);
        }
        public DataTable timKiemMon(string maMon)
        {
            DAL_Mon xuLyMon = new DAL_Mon();
            return xuLyMon.timKiemMon(maMon);
        }
        public bool kiemTraMon(string maMon)
        {
            DAL_Mon xuLyMon = new DAL_Mon();
            return xuLyMon.kiemTraMon(maMon);
        }
        public DataSet thongkeMonHT()
        {
            DAL_Mon xuLyMon = new DAL_Mon();
            return xuLyMon.thongkeMonHT();
        }
        public DataSet thongkeMonDaXoa()
        {
            DAL_Mon xuLyMon = new DAL_Mon();
            return xuLyMon.thongkeMonDaXoa();
        }
        public DataSet thongkeTatCaMon()
        {
            DAL_Mon xuLyMon = new DAL_Mon();
            return xuLyMon.thongkeTatCaMon();
        }
    }
}
