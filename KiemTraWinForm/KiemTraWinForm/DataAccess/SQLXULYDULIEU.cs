using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KiemTraWinForm
{
    class SQLXULYDULIEU
    {
        private SqlConnection con;

        public SQLXULYDULIEU()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Tep Chuong Trinh\Visual Studio 2013\Project\CS414-nguyenduchuy_2321117989\KiemTraWinForm\KiemTraWinForm\database\KiemTraWinFrom.mdf;Integrated Security=True";
        }

        public void moKetNoi()
        {
            if (con.State == ConnectionState.Closed) con.Open();
        }

        public void dongKetNoi()
        {
            if (con.State == ConnectionState.Open) con.Close();
        }

        public DataTable bangDuLieu(String SQL)
        {
            DataTable table = new DataTable();
            this.moKetNoi();
            SqlDataAdapter adp = new SqlDataAdapter(SQL, this.con);
            adp.Fill(table);
            this.dongKetNoi();
            return table;
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
            } return null;
        }

        public bool thucThiThuTuc(String nameProc, SqlParameter[] pr)
        {
            bool flag = false;
            try
            {
                this.moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameProc;
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
                this.dongKetNoi();
            }
            return flag;
        }

        public object thucThiThuTucGiaTriDon(String nameProcedure, SqlParameter[] pr)
        {
            try
            {
                this.moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameProcedure;
                cmd.Connection = this.con;
                if (pr != null)
                    cmd.Parameters.AddRange(pr);
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                this.dongKetNoi();
            }
            return null;
        }

      

        public DataTable bangDuLieuThuTuc(String nameProcedure, SqlParameter[] pr)
        {
            DataTable tb = new DataTable();
            try
            {
                this.moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameProcedure;
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
                this.dongKetNoi();
            }
            return tb;
        }
    }
}
