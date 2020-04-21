using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYBANHANG
{
    class SQLXULYDULIEU
    {
        private SqlConnection con;

        public SQLXULYDULIEU()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Winform\QUANLYBANHANG\QUANLYBANHANG\DATA\dbQUANLYBANHANG.mdf;Integrated Security=True";
        }

        public void moKetNoi()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        public void dongKetNoi()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public DataTable bangDuLieu(String SQL)
        {
            DataTable tb = new DataTable();
            this.moKetNoi();
            SqlDataAdapter adp = new SqlDataAdapter(SQL, this.con);
            adp.Fill(tb);
            this.dongKetNoi();
            return tb;
        }

        public bool thucThiSQL(String SQL)
        {
            try
            {
                this.moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.con;
                cmd.CommandText = SQL;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                this.dongKetNoi();
            }
            return false;
        }

        public object thucThiGiaTriDon(String SQL)
        {
            try
            {
                this.moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.con;
                cmd.CommandText = SQL;

                return cmd.ExecuteScalar();
            }
            catch (SqlException ex) { }
            finally
            {
                this.dongKetNoi();
            }
            return null;
        }
        /// <summary>
        /// Phương thức thực thi thủ tục SQL Server
        /// Giá trị trả về kiểu Boolean (true, false)
        /// </summary>
        /// <param name="NameProcedure">Tên thủ tục SQL Server</param>
        /// <param name="pr">Danh sách tham số</param>
        /// <returns>bool</returns>

        public bool thucThiThuTuc(String NameProcedure, SqlParameter [] pr)
        {
            bool flag = false;
            try
            {
                moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = NameProcedure;
                cmd.Connection = this.con;
                if (pr != null)
                    cmd.Parameters.AddRange(pr);
                if (cmd.ExecuteNonQuery() != 0)
                    flag = true;
            }
            catch (SqlException ex)
            {
                           }
            finally
            {
                dongKetNoi();
            }
            return flag;
        }
        public object thucThiGiaTriDonThuTuc(String NameProcedure, SqlParameter[] pr)
        {
            try
            {
                this.moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = this.con;
                cmd.CommandText = NameProcedure;
                if (pr != null)
                    cmd.Parameters.AddRange(pr);
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex) { }
            finally
            {
                this.dongKetNoi();
            }
            return null;
        }

        public DataTable bangDuLieu2(String NameProcedure, SqlParameter[] pr)
        {
            DataTable tb = new DataTable();
            try
            {
                moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = NameProcedure;
                cmd.Connection = this.con;
                if (pr != null)
                    cmd.Parameters.AddRange(pr);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(tb);
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                dongKetNoi();
            }
            return tb;
        }
    }
}
