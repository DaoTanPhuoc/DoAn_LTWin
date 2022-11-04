using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class NhanVien
    {
        private string maNV;
        private string hoTen;
        private DateTime ngSinh;
        private string GioiTinh;
        private string DiaChi;
        private string SDT;
        private float luong;
        private string maChVu;
        private string hinhAnh;
        private int daXoa;

        public NhanVien()
        {
            this.maNV = null;
            this.hoTen = null;
            this.ngSinh = System.DateTime.Now;
            this.GioiTinh1 = null;
            this.DiaChi1 = null;
            this.SDT = null;
            this.luong = 0;
            this.maChVu = null;
        }
        public NhanVien(string maNV, string hoTen, DateTime ngSinh, string GT, string DC, string sdt, float luong, string maChVu, string HA)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.ngSinh = ngSinh;
            this.GioiTinh1 = GT;
            this.DiaChi1 = DC;
            this.SDT = sdt;
            this.luong = luong;
            this.maChVu = maChVu;
            this.HinhAnh = HA;
        }

        public string MNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public DateTime NgSinh
        {
            get { return ngSinh; }
            set { ngSinh = value; }
        }
        public float Luong
        {
            get { return luong; }
            set { luong = value; }
        }
        public string MaChVu
        {
            get { return maChVu; }
            set { maChVu = value; }
        }

        public string SDT1 { get => SDT; set => SDT = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public int DaXoa { get => daXoa; set => daXoa = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }

        public float TinhLuong()
        {
            ChamCong cc = new ChamCong();
            float tinhLuong = 0;
            float tienTru = cc.TinhTienPhat();
            tinhLuong = this.Luong - tienTru;
            return tinhLuong;
        }
    }
}
