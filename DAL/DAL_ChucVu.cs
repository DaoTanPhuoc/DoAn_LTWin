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
    public class DAL_ChucVu:general
    {
        public DataTable layDSTenChucVu()
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select TenCV from tbChucVu where DaXoa=0";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;

            }
            catch (Exception err)
            {
                throw new Exception("Error " + err.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public string layMaChucVu(string tencv)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select MaCV from tbChucVu where TenCV=N'" + tencv + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt.Rows[0]["MaCV"].ToString();

            }
            catch (Exception err)
            {
                throw new Exception("Error " + err.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public string layTenChucVu(string macv)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select TenCV from tbChucVu where MaCV='" + macv + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt.Rows[0]["TenCV"].ToString();

            }
            catch (Exception err)
            {
                throw new Exception("Error " + err.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
