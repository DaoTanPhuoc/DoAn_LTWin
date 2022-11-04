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
    public class BAL_CTHDN
    {
        public DataTable DocCThd()
        {
            DAL_CTHD xuly=new DAL_CTHD();
            return xuly.DocCTHD();
        }
        public bool ThemCTHD(CT_HDK cthd)
        {
            DAL_CTHD xuly = new DAL_CTHD();
            return xuly.ThemCT_HD(cthd);
        }
    }
}
