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
    public class DAL_ChamCong:general
    {
        public DataTable DocChamCong()
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("select * from tbChamCong where DaXoa=0", con);
            try
            {
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




        public bool ThemChamCong(BEL_ChamCong cc)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "insert into tbChamCong values ('" + cc.MaChamcong1 + "','" + cc.NgayViPham1 + "','" + cc.MaNVCC + "',N'" + cc.MaNVViPham + "','" + cc.MaViPham + "','" + cc.TongLuong1 + "','" +cc.DaXoa1 + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        
    }
}
