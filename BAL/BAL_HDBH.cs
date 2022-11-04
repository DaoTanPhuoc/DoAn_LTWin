using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEL;
using DAL;

namespace BAL
{
    public class BAL_HDBH
    {
        public bool themHDBH(HDBH hdbh)
        {
            DAL_HDBH xuLyHDBH=new DAL_HDBH();
            return xuLyHDBH.themHDBH(hdbh);
        }
        public bool ganMaHD(string maHDHT)
        {
            DAL_HDBH xulyGanMaHD = new DAL_HDBH();
            return xulyGanMaHD.ganHoaDon(maHDHT);
        }

        public bool kTraMaHD(string maHD)
        {
            DAL_HDBH xuLyKtraMaHD=new DAL_HDBH();
            return xuLyKtraMaHD.kTraTonTaiMaHD(maHD);
        }

        //report
        public DataSet layHDHienTai()
        {
            DAL_HDBH xuLyRp = new DAL_HDBH();
            return xuLyRp.LayHDBHHienTai();
        }
        public DataSet layTatCaHD()
        {
            DAL_HDBH xuLy = new DAL_HDBH();
            return xuLy.layTatCaHD();
        }

        //public DataSet layTatCaCTHDBH()
        //{
        //    DAL_HDBH xuLy = new DAL_HDBH();
        //    return xuLy.layTatCaCTHD();
        //}

        public DataSet layHoaDonBHTheoNgay(DateTime date)
        {
            DAL_HDBH xyLy = new DAL_HDBH();
            return xyLy.layHDTheoNgay(date);
        }
    }

   
}
