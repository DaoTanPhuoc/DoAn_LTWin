using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CT_HDK
    {
        private string MaHDNhap;
        private string MaNL;
        private float DonGia;
        private int SoLuong;
        private float ThanhTien;

        public CT_HDK()
        {
            MaHDNhap1 = null;
            MaNL1 = null;
            DonGia1 = 0;
            SoLuong1 = 0;
            ThanhTien1 = 0;
        }
        public CT_HDK(string maHDNhap, string maNL, float donGian, int soLuong, float thanhTien)
        {
            this.MaHDNhap1 = maHDNhap;
            this.MaNL1 = maNL;
            this.DonGia1 = donGian;
            this.SoLuong1 = soLuong;
            this.ThanhTien1 = thanhTien;
        }

        public string MaHDNhap1 { get => MaHDNhap; set => MaHDNhap = value; }
        public string MaNL1 { get => MaNL; set => MaNL = value; }
        public float DonGia1 { get => DonGia; set => DonGia = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public float ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
    }
}
