using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Mon
    {
        private string maMon;
        private string tenMon;
        private string loaiMon;
        private float donGia;
        private string tinhTrang;
        private string DonVi;
        private int daXoa;

        public Mon()
        {
            this.MaMon = null;
            this.TenMon = null;
            this.LoaiMon = null;
            this.DonGia = 0;
            this.TinhTrang = null;
            this.DonVi1 = null;
            this.DaXoa = 0;
        }

        public Mon(string maMon, string tenMon, string loaiMon, float donGia, string tinhTrang, string donVi, int daXoa)
        {
            this.MaMon = maMon;
            this.TenMon = tenMon;
            this.LoaiMon = loaiMon;
            this.DonGia = donGia;
            this.TinhTrang = tinhTrang;
            DonVi1 = donVi;
            this.DaXoa = daXoa;
        }

        public string MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public string LoaiMon { get => loaiMon; set => loaiMon = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string DonVi1 { get => DonVi; set => DonVi = value; }
        public int DaXoa { get => daXoa; set => daXoa = value; }
    }
}
