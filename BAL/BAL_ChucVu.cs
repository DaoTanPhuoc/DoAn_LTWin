using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    public class BAL_ChucVu
    {
        public DataTable layDSTenChucVu()
        {
           DAL_ChucVu dAL_ChucVu = new DAL_ChucVu();
            return dAL_ChucVu.layDSTenChucVu();
        }
        public string layMaChucVu(string tencv)
        {
            DAL_ChucVu dAL_ChucVu = new DAL_ChucVu();
            return dAL_ChucVu.layMaChucVu(tencv);
        }
        public string layTenChucVu(string macv)
        {
            DAL_ChucVu dAL_ChucVu = new DAL_ChucVu();
            return dAL_ChucVu.layTenChucVu(macv);
        }
    }
}
