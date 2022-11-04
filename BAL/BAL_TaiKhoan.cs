using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    public class BAL_TaiKhoan
    {
        public bool LayTK(string user, string pass)
        {
            DAL_TaiKhoan xuly = new DAL_TaiKhoan();
            return xuly.KTDangNhapTK(user, pass);
        }

        public bool dangKyTK(TaiKhoan tk)
        {
            DAL_TaiKhoan xuLy = new DAL_TaiKhoan();
            return xuLy.dangKyTK(tk);
        }

        public DataTable hienThiDSTK()
        {
            DAL_TaiKhoan xuLy = new DAL_TaiKhoan();
            return xuLy.hienThiDSTK();
        }

        public void luuTaiKhoan(string user)
        {
            DAL_TaiKhoan xuLy = new DAL_TaiKhoan();
            xuLy.luuTaiKhoan(user);
        }

        public bool xoaTK(string id)
        {
            DAL_TaiKhoan xuLytk = new DAL_TaiKhoan();
            return xuLytk.xoaTK(id);
        }

        public DataTable get_UserInfo()
        {
            DAL_TaiKhoan xuLy = new DAL_TaiKhoan();
            return xuLy.get_UserInfo();
        }

        public bool KTUserDK(string user)
        {
            DAL_TaiKhoan xuLy = new DAL_TaiKhoan();
            return xuLy.KTUserDK(user);
        }
        public bool suaMKTK(string id, string Pass)
        {
            DAL_TaiKhoan xuLy = new DAL_TaiKhoan();
            return xuLy.suaMKTK(id, Pass);
        }
    }
}
