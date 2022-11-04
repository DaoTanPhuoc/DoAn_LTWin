using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_ViPham
    {
        private string maVP;
        private string NDViPham;
        private float TienTruLuong;
        private int DaXoa;

        public BEL_ViPham()
        {
            this.MaVP = null;
            this.NDViPham1 = null;
            this.TienTruLuong1 = 0;
            this.DaXoa1 = 0;
        }

        public BEL_ViPham(string MVP, string NDVP, float tien, int xoa)
        {
            this.MaVP = MVP;
            this.NDViPham1 = NDVP;
            this.TienTruLuong1 = tien;
            this.DaXoa1 = xoa;
        }

        public string MaVP { get => maVP; set => maVP = value; }
        public string NDViPham1 { get => NDViPham; set => NDViPham = value; }
        public float TienTruLuong1 { get => TienTruLuong; set => TienTruLuong = value; }
        public int DaXoa1 { get => DaXoa; set => DaXoa = value; }
    }
}
