using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_CTHD:general
    {
        public DataTable DocCTHD()
        {
            DataTable dt = new DataTable();
            if(con.State==ConnectionState.Closed)
                con.Open();
            string sql = "select * from tbCT_HDNhap";
            try
            {
                SqlCommand cmd = new SqlCommand(sql,con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }



        public bool ThemCT_HD(CT_HDK cthd)
        {

            DataTable dt = new DataTable(); 
            if(con.State==ConnectionState.Closed)
                con.Open();
            string sql = "insert into tbCT_HDNhap values ('" + cthd.MaHDNhap1 + "','" + cthd.MaNL1 + "'," + cthd.DonGia1 +","+
                cthd.SoLuong1 + "," + cthd.ThanhTien1 + ")";
            
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return true;
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
