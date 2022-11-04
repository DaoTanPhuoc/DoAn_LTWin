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
    public class DAL_HDBH : general
    {
        public bool ganHoaDon(string maHD)
        {
            general.MaHD = maHD;
            if(general.MaHD==maHD)
            {
                return true;
            }
            return false;
        }
        public bool themHDBH(HDBH hdbh)
        {
            DataTable dtHDBH = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "Insert into tbHoaDonBH Values('" + hdbh.MaHD + "','" + hdbh.NgayLapHD + "','" + hdbh.MAKH + "',N'" + hdbh.MaNV + "'," + hdbh.TongTien + "," + hdbh.DaXoa + ")";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dtHDBH.Load(rd);
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

        public bool kTraTonTaiMaHD(string maHD)
        {
            DataTable tbmaHD = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select MaHD from tbHoaDonBH where MaHD='"+maHD+"'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                tbmaHD.Load(rd);
                if (tbmaHD.Rows.Count>0) return false;
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


        //report
        //In Hoá Đơn BH
        public DataSet LayHDBHHienTai()
        {
            string maHDHienTai = general.MaHD;
            DataSet ds = new DataSet();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select NgayLapHD, MaHD,MaKH,HoTenNV,TenMon,SoLuong,DVT,DonGia,ThanhTien,ChietKhau,TongTien from View_HoaDonBH where MaHD='" + maHDHienTai + "'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            dataAdapter.Fill(ds);
            con.Close();


            return ds;
        }

        //Thống Kê Tất Cả Hoá Đơn

        public DataSet layTatCaHD()
        {
            DataSet ds = new DataSet();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select MaHD,NgayLapHD,MaKH,MANV,TongTien from tbHoaDonBH";
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
                sqlDataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception err)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet layHDTheoNgay(DateTime date)
        {
            DataSet ds = new DataSet();
            if (ConnectionState.Closed == con.State)
                con.Open();
            //string date1 = date.ToShortDateString();
            string sql = "select * from tbHoaDonBH where NgayLapHD > '"+date+"'";
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
                sqlDataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception err)
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
