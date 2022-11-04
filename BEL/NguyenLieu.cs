using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class NguyenLieu
    {
        private string MaNL;
        private string TenNL;
        private string NCC;
        private string DonViTinh;
        private int SoLuongHienCo;
        private int DaXoa;

        public NguyenLieu()
        {
            this.MaNL1 = null;
            this.TenNL1 = null;
            this.NCC1 = null;
            this.DonViTinh1 = null;
            this.SoLuongHienCo1 = 0;
            this.DaXoa1 = 0;
        }

        public NguyenLieu(string maNL, string tenNL, string ncc, string donViTinh, int soLuongHienCo, int daxoa)
        {
            this.MaNL1 = maNL;
            this.TenNL1 = tenNL;
            this.NCC1 = ncc;
            this.DonViTinh1 = donViTinh;
            this.SoLuongHienCo1 = soLuongHienCo;
            this.DaXoa1 = daxoa;
        }

        public string MaNL1 { get => MaNL; set => MaNL = value; }
        public string TenNL1 { get => TenNL; set => TenNL = value; }
        public string NCC1 { get => NCC; set => NCC = value; }
        public string DonViTinh1 { get => DonViTinh; set => DonViTinh = value; }
        public int SoLuongHienCo1 { get => SoLuongHienCo; set => SoLuongHienCo = value; }
        public int DaXoa1 { get => DaXoa; set => DaXoa = value; }
    }
}
