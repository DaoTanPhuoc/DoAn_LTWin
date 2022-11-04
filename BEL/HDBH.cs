using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class HDBH
    {
        private string maHD;
        private DateTime ngayLapHD;
        private string maKH;
        private string maNV;
        private float tongTien;
        private int daXoa;

        public HDBH()
        {
            this.MaHD = null;
            this.ngayLapHD = System.DateTime.Now;
            this.maKH = null;
            this.maNV=null;
            this.tongTien = 0;
            this.daXoa = 0;
        }

        public HDBH(string maHD, DateTime ngLapHD, string MakH, string maNV,float tongTien,int daXoa)
        {
            this.maHD = maHD;
            this.ngayLapHD = ngLapHD;
            this.maKH = MakH;
            this.maNV = maNV;
            this.tongTien = tongTien;
            this.daXoa = daXoa;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public DateTime NgayLapHD { get => ngayLapHD; set => ngayLapHD = value; }
        public string MAKH { get => maKH; set => maKH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
        public int DaXoa { get => daXoa; set => daXoa = value; }
    }
}
