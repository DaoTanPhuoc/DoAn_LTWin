using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_ChamCong
    {
        private string MaChamcong;
        private DateTime NgayViPham;
        private string LoiViPham;
        private string maNVCC;
        private string maNVViPham;
        private string maViPham;
        private float TongLuong;
        private int DaXoa;

        public BEL_ChamCong()
        {
            this.MaChamcong1 = null;
            this.NgayViPham1 = System.DateTime.Now;
            
            this.MaNVCC = null;
            this.MaNVViPham = null;
            this.MaViPham = null;
            this.TongLuong1 = 0;
            this.DaXoa1 = 0;
        }
        public BEL_ChamCong(string macc, DateTime ngayVP,  string maNVCC, string MaNVVP, string mvp, float tongluong, int daxoa)
        {
            this.MaChamcong1 = macc;
            this.NgayViPham1 = ngayVP;
            
            this.MaNVCC = maNVCC;
            this.MaNVViPham = MaNVVP;
            this.MaViPham = mvp;
            this.TongLuong1 = tongluong;
            this.DaXoa1 = daxoa;
        }

        public string MaChamcong1 { get => MaChamcong; set => MaChamcong = value; }
        public DateTime NgayViPham1 { get => NgayViPham; set => NgayViPham = value; }
       
        public string MaNVCC { get => maNVCC; set => maNVCC = value; }
        public string MaNVViPham { get => maNVViPham; set => maNVViPham = value; }
        
        public string MaViPham { get => maViPham; set => maViPham = value; }
        public float TongLuong1 { get => TongLuong; set => TongLuong = value; }
        public int DaXoa1 { get => DaXoa; set => DaXoa = value; }

        public float TinhTienPhat()
        {
            BEL_ViPham vp = new BEL_ViPham();
            float tienTru = 0;
            if (this.maViPham == vp.MaVP)
            {
                tienTru = vp.TienTruLuong1;

            }
            return tienTru;
        }
    }
}
