using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KiemTraWinForm.DataAccess
{
    class daKhoalop
    {
        SQLXULYDULIEU xuLyDuLieu;
        String SQL;
        public daKhoalop()
        {
            xuLyDuLieu = new SQLXULYDULIEU();
        }

        public DataTable tableKhoa()
        {
            //SQL = " select * from TableKhoa ";
            return xuLyDuLieu.bangDuLieu2("psbangKhoa",null);
        }

        public bool themMoi(String maKhoa, String tenKhoa)
        {
            SQL = " insert into tbKHOA(MAKHOA, TENKHOA) "
                + " values ('" + maKhoa + "', '" + tenKhoa + "') ";
            SqlParameter prmakhoa = new SqlParameter("@MAKHOA", SqlDbType.NChar, 10);
            prmakhoa.Value = maKhoa;
            SqlParameter prtenkhoa = new SqlParameter("@TENKHOA", SqlDbType.NVarChar, 50);
            prtenkhoa.Value = tenKhoa;
            SqlParameter[] pr = { prmakhoa, prtenkhoa };
           return xuLyDuLieu.thucThiThuTuc("psThemMoiKhoa", pr);
            //return xuLyDuLieu.thucThiSQL(SQL);
        }

        public bool suaKhoa(String maKhoa, String tenKhoa)
        {
            //SQL = " update TableKhachhang "
            //    + " set "
            //    + " tenkhachhang=N'" + tenKH + "',"
            //    + " mota=N'" + tenKH + "'"
            //    + " where madanhmuc=" + maKH;
            //return xuLyDuLieu.thucThiSQL(SQL);
            SqlParameter prmakhoa = new SqlParameter("@makhoa", SqlDbType.NChar, 10);
            prmakhoa.Value = maKhoa;
            SqlParameter prtenkhoa = new SqlParameter("@tenkhoa", SqlDbType.NVarChar, 50);
            prtenkhoa.Value = tenKhoa;
            SqlParameter[] pr = { prmakhoa, prtenkhoa };
            return xuLyDuLieu.thucThiThuTuc("psSuaKhoa", pr);
        }

        public bool xoaKhoa(String maKhoa)
        {
            //String SQL = " delete from TableKhachhang where makhachhang =" + maKH;
            //return xuLyDuLieu.thucThiSQL(SQL);
            SqlParameter prmakhoa = new SqlParameter("@makhoa", SqlDbType.NChar, 10);
            prmakhoa.Value = maKhoa;
            SqlParameter[] pr = { prmakhoa };
            return xuLyDuLieu.thucThiThuTuc("psXoakhoa", pr);
        }
    }
}
