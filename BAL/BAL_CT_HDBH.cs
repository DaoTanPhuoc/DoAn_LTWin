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
    public class BAL_CT_HDBH
    {
        public bool themCTHD(CT_HDBH cthdbh)
        {
            DAL_CT_HDBH xuLyCTHDBH=new DAL_CT_HDBH();
            return xuLyCTHDBH.themCTHD(cthdbh);
        }
        public DataSet layTatCaCTHDBH()
        {
            DAL_CT_HDBH xuLy = new DAL_CT_HDBH();
            return xuLy.layTatCaCTHD();
        }

        public DataSet layTatCaCTHD_TheoNgay(DateTime date)
        {
            DAL_CT_HDBH xuLy = new DAL_CT_HDBH();
            return xuLy.layCTHDTheoNgay(date);
        }
    }
}
