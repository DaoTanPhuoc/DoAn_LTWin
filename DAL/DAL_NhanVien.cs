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
    public class DAL_NhanVien : general
    {
        public DataTable DocNhanVien()
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("select * from tbNhanVien where DaXoa=0", con);
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




        public bool ThemNhanVien(NhanVien nv)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "insert into tbNhanVien values ('" + nv.MNV + "',N'" + nv.HoTen + "','" + nv.NgSinh + "',N'" + nv.GioiTinh1 + "',N'" + nv.DiaChi1 + "','" + nv.SDT1 + "','" + nv.Luong + "','" + nv.MaChVu + "','" + nv.HinhAnh + "','" + nv.DaXoa + "')";
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

        public bool SuaNhanVien(NhanVien nv)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "update tbNhanVien set HoTenNV=N'" + nv.HoTen + "',NgSinh='" + nv.NgSinh + "',GioiTinh=N'" + nv.GioiTinh1 +
                "',DiaChi=N'" + nv.DiaChi1 + "',SDT='" + nv.SDT1 + "',Luong='" + nv.Luong + "',MaChucVu='" + nv.MaChVu + "',HinhAnh='" + nv.HinhAnh + "' where MaNV='" + nv.MNV + "'";
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

        public bool XoaNhanVien(NhanVien nv)
        {
            DataTable dt = new DataTable();
            bool kq = false;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "update tbNhanVien set daxoa=1 where MaNV='" + nv.MNV + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return kq = true;
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
            return kq;
        }

        public DataSet TimNV(string ma)
        {
            DataSet ds = new DataSet();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select * from tbNhanVien where DaXoa=0 and MaNV='" + ma + "'";
            try
            {
                SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
                cmd.Fill(ds);

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

        public DataSet TinhTongLuong()
        {
            DataSet ds = new DataSet();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select MaNV,HoTenNV,NgSinh,GioiTinh,DiaChi,SDT,Luong,MaChucVu,TongLuong from ThongKeNV ";
            try
            {
                SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
                cmd.Fill(ds);

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

        public DataSet inDsNV()
        {
            DataSet ds = new DataSet();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select * from tbNhanVien ";
            try
            {
                SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
                cmd.Fill(ds);

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






        //cuanhat
        public DataTable laodNV()
        {
            DataTable dtNhanVien = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select HoTenNV from tbNhanVien where DaXoa=0", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dtNhanVien.Load(rd);
                return dtNhanVien;

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

        public DataTable laodMaNV()
        {
            DataTable dtNhanVien = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select MaNV from tbNhanVien where DaXoa=0", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dtNhanVien.Load(rd);
                return dtNhanVien;

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



        public string layMaNV(string tenNV)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select MaNV from tbNhanVien where  HoTenNV=N'" + tenNV + "'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt.Rows[0]["MaNV"].ToString();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                con.Close();
            }
        }

        //ChamCong
        public string LayTenNV(string maNV)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select HoTenNV from tbNhanVien where MaNV='" + maNV + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt.Rows[0]["HoTenNV"].ToString();
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

        public bool KtraTonTai(string maNV)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select MaNV from tbNhanVien where MaNV='" + maNV + "'";
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

        public string LayLuong(string maNV)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select Luong from tbNhanVien where maNV='" + maNV + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt.Rows[0]["Luong"].ToString();
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
