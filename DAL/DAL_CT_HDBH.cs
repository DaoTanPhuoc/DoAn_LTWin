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
    public class DAL_CT_HDBH:general
    {
        public bool themCTHD(CT_HDBH cthd)
        {
          
            DataTable dtCTHD=new DataTable();
         
           if(ConnectionState.Closed==con.State)
                con.Open();

            string sql1 = "Insert into tbCT_HoaDonBH Values('" + cthd.MaHD + "','" + cthd.MaMon + "'," + cthd.SoLuong + ",N'" + cthd.DVT1 + "'," + cthd.DonGia + "," + cthd.ChietKhau + "," + cthd.ThanhTien + ")";
            try
            {
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                SqlDataReader rd1=cmd1.ExecuteReader();
                dtCTHD.Load(rd1);
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

        public DataSet layTatCaCTHD()
        {
            DataSet ds = new DataSet();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select MaHD, MaMon,SoLuong,DVT,DonGia,ChietKhau,ThanhTien from tbCT_HoaDonBH";
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

        public DataSet layCTHDTheoNgay(DateTime date)
        {
            DataSet ds = new DataSet();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select * from tbCT_HoaDonBH, tbHoaDonBH where tbCT_HoaDonBH.MaHD=tbHoaDonBH.MaHD and  NgayLapHD >  '" + date + "'";
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
