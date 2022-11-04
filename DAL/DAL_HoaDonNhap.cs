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
    public class DAL_HoaDonNhap:general
    {
        public DataTable DocHDN()
        {
            DataTable dt = new DataTable();
            if (con.State== ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("select *  from tbHoaDonNhap", con);
            try
            {
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

        public bool ThemHDN(HoaDonNhap hdn)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "insert into tbHoaDonNhap values ('" + hdn.MaHDNhap1 + " ','" + hdn.NgayLapHD1 + " ','" +
                hdn.MaNVLap1 + "','" + hdn.NgayNhan1 + "')";
            
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

        public string loadMaNL()
        {
            return general.MaNL;
        }

    }
}
