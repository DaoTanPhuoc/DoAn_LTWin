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
    public class DAL_NhaCungCap:general
    {
        public DataTable LoadMaNCC()
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select MaNCC from tbNhaCungCap where DaXoa=0 ";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception ex)
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
