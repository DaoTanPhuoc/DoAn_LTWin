using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ViPham
    {
        private string maVP;
        private string NDViPham;
        private float TienTruLuong;

        public ViPham()
        {
            this.MaVP = null;
            this.NDViPham1 = null;
            this.TienTruLuong1 = 0;
        }

        public ViPham(string MVP, string NDVP, float tien)
        {
            this.MaVP = MVP;
            this.NDViPham1 = NDVP;
            this.TienTruLuong1 = tien;
        }

        public string MaVP { get => maVP; set => maVP = value; }
        public string NDViPham1 { get => NDViPham; set => NDViPham = value; }
        public float TienTruLuong1 { get => TienTruLuong; set => TienTruLuong = value; }
    }
}
