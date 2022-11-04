using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BEL
{
    public class CT_HDBH
    {
        private string maHD;
        private string maMon;
        private int soLuong;
        private string DVT;
        private float donGia;
        private float chietKhau;
        private float thanhTien;

        public CT_HDBH()
        {
            this.MaHD = null;
            this.MaMon = null;
            this.soLuong = 0;
            this.DVT = null;
            this.DonGia = 0;
            this.ChietKhau = 0;
            this.ThanhTien = 0;
        }

        public CT_HDBH(string maHD, string maMon, int soLuong, string DVT, float donGia, float chietKhau, float thanhTien)
        {
            this.MaHD = maHD;
            this.MaMon = maMon;
            this.soLuong = soLuong;
            this.DVT = DVT;
            this.DonGia = donGia;
            this.ChietKhau = chietKhau;
            this.ThanhTien = thanhTien;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaMon { get => maMon; set => maMon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float ChietKhau { get => chietKhau; set => chietKhau = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public string DVT1 { get => DVT; set => DVT = value; }

       
    }
}
