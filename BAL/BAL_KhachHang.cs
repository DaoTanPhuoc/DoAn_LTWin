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
    public class BAL_KhachHang
    {
        public string layTenKH(string makH)
        {
            DAL_KhachHang xuLyKH = new DAL_KhachHang();
            return xuLyKH.layTenKH(makH);
        }
        public DataTable layThTinKH()
        {
            DAL_KhachHang xuLyKH = new DAL_KhachHang();
            return xuLyKH.layThongTinKH();
        }


        //cua mẫn
        public DataTable DocDanhSachKhachHang()
        {
            DAL_KhachHang xuLyKhachHang = new DAL_KhachHang();
            return xuLyKhachHang.DocDanhSachKhachHang();
        }
        public bool themKhachHang(KhachHang kh)
        {
            DAL_KhachHang xuLyKhachHang = new DAL_KhachHang();
            return xuLyKhachHang.themKhachHang(kh);
        }
        public bool xoaKH(KhachHang kh)
        {
            DAL_KhachHang xuLyKhachHang = new DAL_KhachHang();
            return xuLyKhachHang.xoaKH(kh);
        }
        public bool suaKH(KhachHang kh)
        {
            DAL_KhachHang xuLyKhachHang = new DAL_KhachHang();
            return xuLyKhachHang.suaKH(kh);
        }
        public DataTable timkiemKH(string MaKh)
        {
            DAL_KhachHang xuLyKhachHang = new DAL_KhachHang();
            return xuLyKhachHang.timkiemKH(MaKh);
        }
        public bool kiemTraID(string makh)
        {
            DAL_KhachHang xuLyKhachHang = new DAL_KhachHang();
            return xuLyKhachHang.kiemTraID(makh);
        }
        public DataSet thongKeHT()
        {
            DAL_KhachHang xuLyThongKe = new DAL_KhachHang();
            return xuLyThongKe.thongKeKHHT();
        }
        public DataSet thongKeDX()
        {
            DAL_KhachHang xuLyThongKe = new DAL_KhachHang();
            return xuLyThongKe.thongKeDaXoa();
        }
        public DataSet thongKeTCKH()
        {
            DAL_KhachHang xuLyThongKe = new DAL_KhachHang();
            return xuLyThongKe.thongKeTatCaKH();
        }
    }
}
