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
    public class BAL_GiamGia
    {
        public DataTable layMaGiamGIa()
        {
            DAL_GiamGIa xuLyGiamGia = new DAL_GiamGIa();
            return xuLyGiamGia.layMaGiamGia();
        }

        public float layDiscount(string maGiamGia)
        {
            DAL_GiamGIa xuLyLayDisCount=new DAL_GiamGIa();
            return xuLyLayDisCount.layDiscount(maGiamGia);
        }
    }
}
