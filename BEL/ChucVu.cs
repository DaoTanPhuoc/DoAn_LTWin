using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BEL
{
    public class ChucVu
    {
        private string MaCV;
        private string TenCV;
        private int DaXoa;
        private string MaNV;

        public ChucVu(string maCV, string tenCV, int daXoa, string maNV)
        {
            this.MaCV1 = maCV;
            this.TenCV1 = tenCV;
            this.DaXoa1 = daXoa;
            this.MaNV1 = maNV;
        }

        public string MaCV1 { get => MaCV; set => MaCV = value; }
        public string TenCV1 { get => TenCV; set => TenCV = value; }
        public int DaXoa1 { get => DaXoa; set => DaXoa = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
    }
}
