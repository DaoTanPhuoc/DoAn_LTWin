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
    public class DAL_KhachHang:general
    {
        public DataTable layThongTinKH()
        {
            DataTable dt = new DataTable();
            if(ConnectionState.Closed==con.State)
                con.Open();
            string sql = "select MaKH from tbKhachHang where DaXoa=0";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch(Exception err)
            {
                throw ;
            }
            finally
            {
                con.Close();
            }
        }

        public string layTenKH(string maKH)
        {
            DataTable dt = new DataTable();
            if(maKH=="NULL"||maKH=="")
                return "NULL";
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql="select TenKH from tbKhachHang where DaXoa=0 and MaKH='"+maKH+"'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd=cmd.ExecuteReader();
                dt.Load(rd);
                return dt.Rows[0]["TenKH"].ToString();
            }
            catch(Exception err)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        //của mẫn
        public DataTable DocDanhSachKhachHang()
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "Select * from tbKhachHang where daxoa=0";
            SqlCommand cmd = new SqlCommand(sql, con);
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
        public bool themKhachHang(KhachHang khachhang)
        {

            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                int daXoa = 0;
                string sql = "insert into tbKhachHang values('" + khachhang.MaKH + "',N'" + khachhang.TenKH + "',N'" + khachhang.GioiTinh + "','" + khachhang.SDT1 + "'," + daXoa + ")";
                SqlCommand command = new SqlCommand(sql, con);
                if (command.ExecuteNonQuery() > 0)
                    ketqua = true;
            }
            catch (Exception err)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return ketqua;
        }
        public bool xoaKH(KhachHang khachhang)
        {
            DataTable dt = new DataTable();
            bool ketquaxoa = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE tbKhachHang set daXoa=1 where MaKh='" + khachhang.MaKH + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    ketquaxoa = true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return ketquaxoa;
        }
        public bool suaKH(KhachHang kh)
        {
            DataTable dt = new DataTable();
            bool ketquasua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE tbKhachHang set TenKH= N'" + kh.TenKH + "',GioiTinh=N'" + kh.GioiTinh + "',SDT='" + kh.SDT1 + "' where MaKh='" + kh.MaKH + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    ketquasua = true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return ketquasua;
        }
        public DataTable timkiemKH(string makh)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "select * from tbKhachHang where daxoa=0 and MaKH='" + makh + "'";
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
        public bool kiemTraID(string Makh)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "select makh from tbKhachHang where MaKH='" + Makh + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
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

        public DataSet thongKeKHHT()
        {
            DataSet ds = new DataSet();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "Select * from tbKhachHang where daxoa=0";

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
                sqlDataAdapter.Fill(ds);
                return ds;
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
        public DataSet thongKeDaXoa()
        {
            DataSet ds = new DataSet();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "Select * from tbKhachHang where daxoa=1";

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
                sqlDataAdapter.Fill(ds);
                return ds;
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
        public DataSet thongKeTatCaKH()
        {
            DataSet ds = new DataSet();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "Select * from tbKhachHang";

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
                sqlDataAdapter.Fill(ds);
                return ds;
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
