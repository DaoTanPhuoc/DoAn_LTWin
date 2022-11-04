using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
using BEL;

namespace BAL
{
    public class BAL_HoaDonNhap
    {
        public DataTable Dochdn()
        {
            DAL_HoaDonNhap xuly = new DAL_HoaDonNhap();
            return xuly.DocHDN();
        }

        public bool Themhdn(HoaDonNhap hdn)
        {
            DAL_HoaDonNhap xuly = new DAL_HoaDonNhap();
            return xuly.ThemHDN(hdn);
        }
        public string loadMaNL()
        {
            DAL_HoaDonNhap xuLy = new DAL_HoaDonNhap();
            return xuLy.loadMaNL();
        }
        
    }
}
