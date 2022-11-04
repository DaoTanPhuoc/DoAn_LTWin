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
    public class BAL_NguyenLieu
    {
        public DataTable DocNguyenLieu()
        {
            DAL_NguyenLieu XuLy = new DAL_NguyenLieu();
            return XuLy.DocNL();
        }

        public bool ThemNguyenLieu(NguyenLieu nl)
        {
            DAL_NguyenLieu XuLyThem = new DAL_NguyenLieu();
            return XuLyThem.ThemNguyenLieu(nl);
        }

        public bool SuaNguyenLieu(NguyenLieu nl)
        {
            DAL_NguyenLieu XuLy = new DAL_NguyenLieu();
            return XuLy.SuaNguyenLieu(nl);
        }

        public bool XoaNguyeLieu(NguyenLieu nl)
        {
            DAL_NguyenLieu xuly = new DAL_NguyenLieu();
            return xuly.XoaNL(nl);
        }

        public DataTable LoadMaNL()
        {
            DAL_NguyenLieu XuLy = new DAL_NguyenLieu();
            return XuLy.LoadMaNL();
        }

        public void layMaNLsauThem(string mnl)
        {
            DAL_NguyenLieu xuLy = new DAL_NguyenLieu();
            xuLy.layMaNLSauKhiThem(mnl);
        }
    }
}
