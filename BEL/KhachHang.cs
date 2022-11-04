using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class KhachHang
    {
        private string maKH;
        private string tenKH;
        private string gioiTinh;
        private string SDT;
        private int daXoa;

        public KhachHang()
        {
            this.MaKH = null;
            this.TenKH = null;
            this.GioiTinh = null;
            this.SDT1 = null;
            this.DaXoa=0;
        }

        public KhachHang(string maKH, string tenKH, string gioiTinh, string SDT,  int daXoa)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.GioiTinh = gioiTinh;
            this.SDT1 = SDT;
            this.DaXoa = daXoa;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public int DaXoa { get => daXoa; set => daXoa = value; }
    }
}
