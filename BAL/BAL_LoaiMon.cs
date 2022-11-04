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
    public class BAL_LoaiMon
    {
        public DataTable layMaMon()
        {
            DAL_LoaiMon xuLyMon = new DAL_LoaiMon();
            return xuLyMon.layMaMon();
        }
    }
}
