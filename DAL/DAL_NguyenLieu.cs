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
    public class DAL_NguyenLieu:general
    {
        public DataTable DocNL()
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbNguyenLieu where DaXoa=0",con);
            try
            {
                SqlDataReader rd= cmd.ExecuteReader();
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

        public bool ThemNguyenLieu(NguyenLieu nl)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "insert into tbNguyenLieu values('" + nl.MaNL1 + "',N'" + nl.TenNL1 + "','" + nl.NCC1 + "','" + nl.DonViTinh1 + "'," +
                nl.SoLuongHienCo1 + ",'" + nl.DaXoa1+"')";
            SqlCommand cmd= new SqlCommand(sql,con);
            try
            {
                SqlDataReader rd=cmd.ExecuteReader();
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
            return false;
        }
        
        public bool SuaNguyenLieu(NguyenLieu nl)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "update tbNguyenLieu set TenNL=N'" + nl.TenNL1 +
                "',DonViTinh=N'" + nl.DonViTinh1 + "',SoLuongHienCo=" + nl.SoLuongHienCo1 + " where MaNL='"+nl.MaNL1+"'";
               SqlCommand cmd= new SqlCommand (sql,con);
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

        public bool XoaNL(NguyenLieu nl)
        {
            DataTable dt= new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "update  tbNguyenLieu set DaXoa=1 where MaNL='"+nl.MaNL1+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
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

        public DataTable LoadMaNL()
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select MaNL from tbNguyenLieu where DaXoa=0";
            try
            {
                SqlCommand cmd = new SqlCommand (sql, con);
                SqlDataReader rd= cmd.ExecuteReader();
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

        public void layMaNLSauKhiThem(string maNL)
        {
            general.MaNL=maNL;
        }

       
    }
}
