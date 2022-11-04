using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class general
    {
        //MINH-NHAT\MINHNHAT
        // LAPTOP-8UN64H4C
        public SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-8UN64H4C;Initial Catalog=QLTS;Integrated Security=True");
        private static string maNL;
        public static string MaNL { get => maNL; set => maNL = value; }
        private static string maHD = null;
        public static string MaHD { get => maHD; set => maHD = value; }
       
       

        //Phân Quyền
        private static string user;
        private static string chucVu;
        public static string User { get => user; set => user = value; }
        public static string ChucVu { get => chucVu; set => chucVu = value; }
    
    }
}
