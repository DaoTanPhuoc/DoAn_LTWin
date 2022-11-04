using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEL;
using BAL;
using DAL;
namespace BAL
{
    public class BAL_ChamCong
    {
        public DataTable DocDanhSachCC()
        {
            DAL_ChamCong XuLy = new DAL_ChamCong();
            return XuLy.DocChamCong();
        }

        public bool themCC(BEL_ChamCong cc)
        {
            DAL_ChamCong XuLy = new DAL_ChamCong();
            return XuLy.ThemChamCong(cc);
        }

       
    }
}
