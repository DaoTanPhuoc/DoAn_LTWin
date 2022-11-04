using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class HoaDonNhap
    {
        private string MaHDNhap;
        private DateTime NgayLapHD;
        private string MaNVLap;
        private DateTime NgayNhan;


        public HoaDonNhap()
        {
            MaHDNhap1 = null;
            NgayLapHD1 = DateTime.Now;
            MaNVLap1 = null;
            NgayNhan1 = DateTime.Now;
        }

        public HoaDonNhap(string maHDNhap, DateTime ngayLapHD, string maNVLap, DateTime ngayNhan)
        {
            this.MaHDNhap1 = maHDNhap;
            this.NgayLapHD1 = ngayLapHD;
            this.MaNVLap1 = maNVLap;
            this.NgayNhan1 = ngayNhan;
        }

        public string MaHDNhap1 { get => MaHDNhap; set => MaHDNhap = value; }
        public DateTime NgayLapHD1 { get => NgayLapHD; set => NgayLapHD = value; }
        public string MaNVLap1 { get => MaNVLap; set => MaNVLap = value; }
        public DateTime NgayNhan1 { get => NgayNhan; set => NgayNhan = value; }
    }
}
