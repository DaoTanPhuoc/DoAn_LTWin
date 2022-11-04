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
    public class BAL_NhanVien
    {
        public DataTable DocDanhSachNV()
        {
            DAL_NhanVien XuLyNhanVien= new DAL_NhanVien();
            return XuLyNhanVien.DocNhanVien();
        }

        public bool themNhanVien(NhanVien nv)
        {
            DAL_NhanVien XulyNhanVien = new DAL_NhanVien();
            return XulyNhanVien.ThemNhanVien(nv);
        }

        

        public bool SuaNhanVien(NhanVien nv)
        {
            DAL_NhanVien XuLyNhanVien = new DAL_NhanVien();
            return XuLyNhanVien.SuaNhanVien(nv);
        }

        public bool XoaNhanVien(NhanVien nv)
        {
            DAL_NhanVien XuLyNhanVien = new DAL_NhanVien();
            return XuLyNhanVien.XoaNhanVien(nv);
        }

        public DataSet TimNVTheoMa(string ma)
        {
            DAL_NhanVien xuly = new DAL_NhanVien();
            return xuly.TimNV(ma);
        }

        public DataSet TinhTongLuong()
        {
            DAL_NhanVien xuly = new DAL_NhanVien();
            return xuly.TinhTongLuong();
        }

        public DataSet indsNV()
        {
            DAL_NhanVien xuly = new DAL_NhanVien();
            return xuly.inDsNV();
        }

        //Của nhat
        public DataTable docNhanVienThuNgan()
        {
            DAL_NhanVien xuLyNhanVien = new DAL_NhanVien();
            return xuLyNhanVien.laodNV();
        }
        public DataTable docNhanVien()
        {
            DAL_NhanVien xuLyNhanVien = new DAL_NhanVien();
            return xuLyNhanVien.laodMaNV();
        }

        public string layMaNV(string tenNV)
        {
            DAL_NhanVien xulyNV = new DAL_NhanVien();
            return xulyNV.layMaNV(tenNV);
        }

        //chmcong
        public string layTenNV(string manv)
        {
            DAL_NhanVien xuly = new DAL_NhanVien();
            return xuly.LayTenNV(manv);
        }

        public bool KtraTonTaiNV(string maNV)
        {
            DAL_NhanVien xuly = new DAL_NhanVien();
            return xuly.KtraTonTai(maNV);
        }

        public string LayLuongCB(string maNV)
        {
            DAL_NhanVien xuly = new DAL_NhanVien();
            return xuly.LayLuong(maNV);
        }
    }
}
