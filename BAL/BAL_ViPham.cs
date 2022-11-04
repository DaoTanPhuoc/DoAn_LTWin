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
    public class BAL_ViPham
    {

        public DataTable LoadViPham()
        {
            DAL_ViPham xuly= new DAL_ViPham();
            return xuly.LoadVP();
        }

        public bool ThemVP(BEL_ViPham vp)
        {
            DAL_ViPham xuly = new DAL_ViPham();
            return xuly.ThemVP(vp);
        }

        public bool suaVP(BEL_ViPham vp)
        {
            DAL_ViPham xuly = new DAL_ViPham();
            return xuly.SuaVP(vp);
        }

        public bool xoaVP(BEL_ViPham vp)
        {
            DAL_ViPham xuly = new DAL_ViPham();
            return xuly.XoaVP(vp);  
        }

        public string layTenVP(string manv)
        {
            DAL_ViPham xuly = new DAL_ViPham();
            return xuly.LayTenVP(manv);
        }

        public bool KtraTonTaiMaVP(string maVP)
        {
            DAL_ViPham xuly = new DAL_ViPham();
            return xuly.KtraTonTai(maVP);
        }

        public float LayTienPhatNV(string maVP)
        {
            DAL_ViPham xuly = new DAL_ViPham();
            return xuly.LayTienPhat(maVP);
        }
    }
}
