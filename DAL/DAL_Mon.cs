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
    public class DAL_Mon:general
    {   
       public DataTable docDSMon(string loaiMon)
       {
            DataTable dtMon = new DataTable();

            if (ConnectionState.Closed == con.State)
                con.Open();

            if (loaiMon=="Cafe")
            {


                SqlCommand cmd = new SqlCommand("select * from tbMon where LoaiMon like '%CF%'", con);
                try
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    dtMon.Rows.Clear();
                    dtMon.Load(rd);
                    //dtGrMon.Refresh();
                    return dtMon;
                }
                catch (Exception err)
                {
                    throw;
                }
            }
            else if (loaiMon=="TraSua")
            {

                SqlCommand cmd = new SqlCommand("select * from tbMon where LoaiMon like '%TS%'", con);
                try
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    dtMon.Rows.Clear();
                    dtMon.Load(rd);
                    //dtGrMon.Refresh();
                    return dtMon;

                }
                catch (Exception err)
                {
                    throw;
                }
            }
            else if (loaiMon=="Banh")
            {

                SqlCommand cmd = new SqlCommand("select * from tbMon where LoaiMon like '%BA%'", con);
                try
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    dtMon.Rows.Clear();
                    dtMon.Load(rd);
                    //dtGrMon.Refresh();
                    return dtMon;

                }
                catch (Exception err)
                {
                    throw;
                }
            }

            return null;
       }

        //lấy tên món
        public string layTenMon(string maMon)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select TenMon from tbMon where MaMon='" + maMon + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();
                
                dt.Load(rdr);
                return dt.Rows[0]["TenMon"].ToString();
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

        public DataTable timKiemMon(string cachTim,string ndTim)
        {
            DataTable dtMon=new DataTable();
            switch (cachTim)
            {
                case "Theo Mã":
                    if (ConnectionState.Closed == con.State)
                        con.Open();
                    string sql = "select * from tbMon where MaMon like '%" + ndTim.Trim() + "%'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    dtMon.Rows.Clear();
                    dtMon.Load(rd);
                    return dtMon;
                    //break;
                case "Theo Tên":
                    if (ConnectionState.Closed == con.State)
                        con.Open();
                    string sql1 = "select * from tbMon where TenMon like '%" + ndTim.Trim() + "%'";
                    SqlCommand cmd1 = new SqlCommand(sql1, con);
                    SqlDataReader rd1 = cmd1.ExecuteReader();
                    dtMon.Rows.Clear();
                    dtMon.Load(rd1);
                    return dtMon;
                    //break;
                case "Theo Mã Loại Món":
                    if (ConnectionState.Closed == con.State)
                        con.Open();
                    string sql2 = "select * from tbMon where LoaiMon like '%" + ndTim.Trim() + "%'";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    SqlDataReader rd2 = cmd2.ExecuteReader();
                    dtMon.Rows.Clear();
                    dtMon.Load(rd2);
                    return dtMon;
                    //break;
                default:
                    return null;
                    //break;
            }
        }

        //cua MẪn
        public DataTable DocDanhSachMon()
        {
            DataTable dtMon = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select *from tbMon where daxoa=0";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dtMon.Load(rd);
                return dtMon;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //public string layTenMon(string maMon)
        //{
        //    DataTable dt = new DataTable();
        //    if (ConnectionState.Closed == con.State)
        //        con.Open();
        //    string sql = "select *from tbMon where MaMon='" + maMon + "'";
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    try
        //    {
        //        SqlDataReader rd = cmd.ExecuteReader();
        //        dt.Load(rd);
        //        return dt.Rows[0]["TenMon"].ToString();
        //    }
        //    catch (Exception err)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}


        public bool themMon(Mon mon)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                int daxoa = 0;
                string sql = "insert into tbMon values('" + mon.MaMon + "',N'" + mon.TenMon + "',N'" + mon.LoaiMon + "','" + mon.DonGia + "',N'" + mon.TinhTrang + "','" + mon.DonVi1 + "N','" + daxoa + "')";
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
        public bool xoaMon(Mon mon)
        {
            DataTable dt = new DataTable();
            bool ketquaxoa = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE tbMon set daxoa=1 where MaMon='" + mon.MaMon + "'";
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
        public bool suaMon(Mon mon)
        {
            DataTable dt = new DataTable();
            bool ketquasua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE tbMon set TenMon=N'" + mon.TenMon + "',loaiMon='" + mon.LoaiMon + "',DonGia=" + mon.DonGia + ",TinhTrang=N'" + mon.TinhTrang + "',DonVi=N'" + mon.DonVi1 + "'where MaMon='" + mon.MaMon + "'";
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
        public DataTable timKiemMon(string maMon)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "select * from tbMon where daxoa=0 and MaMon='" + maMon + "'";
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
        public bool kiemTraMon(string MaMon)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "select mamon from tbMon where MaMon='" + MaMon + "'";
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
        public DataSet thongkeMonHT()
        {
            DataSet ds = new DataSet();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select * from tbMon where daxoa=0";
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
        public DataSet thongkeMonDaXoa()
        {
            DataSet ds = new DataSet();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select *from tbMon where daxoa=1";
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
        public DataSet thongkeTatCaMon()
        {
            DataSet ds = new DataSet();
            if (ConnectionState.Closed == con.State)
                con.Open();
            try
            {
                string sql = "select * from tbMon";
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
