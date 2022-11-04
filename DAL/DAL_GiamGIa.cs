using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEL;


namespace DAL
{
    public class DAL_GiamGIa:general
    {
        public DataTable layMaGiamGia()
        {
            if (ConnectionState.Closed == con.State)
                con.Open();
            DataTable dt = new DataTable();
            DateTime ngayHienTai = DateTime.Now;
            string sql = "select MaGiamGia from tbGiamGia where DaXoa=0";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public float layDiscount(string maGiamGia)
        {
            if (ConnectionState.Closed == con.State)
                con.Open();
            DataTable dt = new DataTable();
            DateTime ngayHienTai = DateTime.Now; // DATEDIFF(YEAR, NGSINH, GETDATE())>= 60
            string sql = "select discount from tbGiamGia where DaXoa=0 and" +
                " DATEDIFF(minute,ThoiHan,getdate())>=DATEDIFF(minute,'" + ngayHienTai 
                + "',getdate()) and MaGiamGia='"+maGiamGia+"'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                float kq = float.Parse(dt.Rows[0][0].ToString());
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
