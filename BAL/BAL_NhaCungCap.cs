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
    public class BAL_NhaCungCap
    {
        public DataTable LoadNCC()
        {
            DAL_NhaCungCap XuLy = new DAL_NhaCungCap();
            return XuLy.LoadMaNCC();
        }
    }
}
