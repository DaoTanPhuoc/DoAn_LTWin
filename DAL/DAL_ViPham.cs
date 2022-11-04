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
    public class DAL_ViPham:general
    {
        // doc du lieu
        public DataTable LoadVP()
        {
            DataTable dt = new DataTable();
            if(con.State== ConnectionState.Closed)
                con.Open();
            string sql = "select* from ViPham where DaXoa=0";
            SqlCommand cmd = new SqlCommand(sql,con);
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




        public bool ThemVP(BEL_ViPham vp)
        {
            DataTable dt = new DataTable();
            if(con.State== ConnectionState.Closed)
                con.Open();
            string sql = "insert into ViPham values('" + vp.MaVP + "',N'" + vp.NDViPham1 + "'," + vp.TienTruLuong1 + ","+vp.DaXoa1+")";
            SqlCommand cmd = new SqlCommand(sql,con);
            try
            {
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


        public bool SuaVP(BEL_ViPham vp)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "update ViPham set noiDungViPham=N'" + vp.NDViPham1 + "',tienTruLuong='" + vp.TienTruLuong1 + "' where maViPham='" + vp.MaVP + "'";
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
        }


        public bool XoaVP(BEL_ViPham vp)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "update ViPham set DaXoa=1 where maViPham='" + vp.MaVP + "'"; 
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
        }


        public string LayTenVP(string maVP)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select noiDungViPham from ViPham where maViPham = '" + maVP + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt.Rows[0]["noiDungViPham"].ToString();
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

        public bool KtraTonTai(string maVP)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select maViPham from ViPham where maViPham = '" + maVP + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    return true;
                return false;
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

        public float LayTienPhat(string maVP)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select tienTruLuong from ViPham where maViPham='" + maVP + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return float.Parse(dt.Rows[0]["tienTruLuong"].ToString());
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
