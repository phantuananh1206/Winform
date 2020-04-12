using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Test
{
    class XuLyDuLieu
    {
        private SqlConnection con;
        public XuLyDuLieu()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Winform\Test\Test\DATA\dbTest.mdf;Integrated Security=True";
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
            DataTable dt = new DataTable();
            this.moKetNoi();
            SqlDataAdapter adt = new SqlDataAdapter(SQL, this.con);
            adt.Fill(dt);
            this.dongKetNoi();
            return dt;
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
    }
}
