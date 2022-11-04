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
    public class DAL_TaiKhoan:general
    {
        public DataTable hienThiDSTK()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            DataTable dt = new DataTable();
            string sql = "select * from tbTaiKhoan" ;
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
        public bool dangKyTK(TaiKhoan tk)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            DataTable dt = new DataTable();
            string sql = "Insert into tbTaiKhoan(Username,Pass,ChucVu) values('" + tk.UserName1+"','"+tk.Password1+"','"+tk.MaCV1+"')";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
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

    
        public bool KTDangNhapTK(string user, string pass)
        {
            if(con.State==ConnectionState.Closed)
                con.Open();
            DataTable dt = new DataTable();
            string sql = "select * from tbTaiKhoan where UserName='"+user+"' and Pass='"+pass+"'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0) return true;
                return false;
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

        public void luuTaiKhoan(string user)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            DataTable dt = new DataTable();
            string sql = "select * from tbTaiKhoan where UserName='" + user + "'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                general.User = dt.Rows[0]["Username"].ToString();
               // general.ChucVu = dt.Rows[0]["ChucVu"].ToString();

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
        public bool xoaTK(string id)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            DataTable dt = new DataTable();
            string sql = "DELETE FROM tbTaiKhoan where ID='"+id+"'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
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

        public bool KTUserDK(string user)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            DataTable dt = new DataTable();
            string sql = "Select * from tbTaiKhoan where Username='"+user+"'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0) return true;
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

        public DataTable get_UserInfo()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            DataTable dt = new DataTable();
            string user=general.User;
            string sql = "select * from tbTaiKhoan where UserName='" + user + "'";
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

        public bool suaMKTK(string id, string pass)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            DataTable dt = new DataTable();
            string sql = "Update tbTaiKhoan set Pass='"+pass+"' where ID='"+id+"'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
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
    }
}
