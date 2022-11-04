using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ChamCong
    {
        private string MaChamcong;
        private DateTime NgayViPham;
        private string LoiViPham;
        private string maNVCC;
        private string maNVViPham;
        private string maViPham;
        private int SoLan;

        public ChamCong()
        {
            this.MaChamcong1 = null;
            this.NgayViPham1 = System.DateTime.Now;
            this.LoiViPham1 = null;
            this.MaNVCC = null;
            this.MaNVViPham = null;
            this.MaViPham = null;
            this.SoLan1 = 0;

        }
        public ChamCong(string macc, DateTime ngayVP, string loiVP, string maNVCC, string MaNVVP, string mvp, int sl)
        {
            this.MaChamcong1 = macc;
            this.NgayViPham1 = ngayVP;
            this.LoiViPham1 = loiVP;
            this.MaNVCC = maNVCC;
            this.MaNVViPham = MaNVVP;
            this.MaViPham = mvp;
            this.SoLan1 = sl;
        }

        public string MaChamcong1 { get => MaChamcong; set => MaChamcong = value; }
        public DateTime NgayViPham1 { get => NgayViPham; set => NgayViPham = value; }
        public string LoiViPham1 { get => LoiViPham; set => LoiViPham = value; }
        public string MaNVCC { get => maNVCC; set => maNVCC = value; }
        public string MaNVViPham { get => maNVViPham; set => maNVViPham = value; }
        public int SoLan1 { get => SoLan; set => SoLan = value; }
        public string MaViPham { get => maViPham; set => maViPham = value; }

        public float TinhTienPhat()
        {
            ViPham vp = new ViPham();
            float tienTru = 0;
            if (this.maViPham == vp.MaVP)
            {
                tienTru = vp.TienTruLuong1;

            }
            return tienTru;
        }
    }
}
