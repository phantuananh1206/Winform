using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KiemTraWinForm.DataAccess
{
    class daLopkhoa
    {
        SQLXULYDULIEU xuLyDuLieu;
        String SQL;
        public daLopkhoa()
        {
            xuLyDuLieu = new SQLXULYDULIEU();
        }

        public DataTable tableLop()
        {
            //SQL = " select * from TableLophoc ";
            return xuLyDuLieu.bangDuLieu2("psbangLophoc",null);
        }

        public bool suaLop(String malop, String makhoa, String tenlop, String sosv)
        {
            SqlParameter prmalop = new SqlParameter("@malop", SqlDbType.NChar, 10);
            prmalop.Value = malop;
            SqlParameter prmakhoa = new SqlParameter("@makhoa", SqlDbType.NChar, 10);
            prmakhoa.Value = makhoa;
            SqlParameter prtenlop = new SqlParameter("@tenlop", SqlDbType.NVarChar, 50);
            prtenlop.Value = makhoa;
            SqlParameter prsosv = new SqlParameter("@sosv", SqlDbType.Int);
            prsosv.Value = sosv;

            SqlParameter[] pr = { prmalop, prmakhoa, prtenlop, prsosv };
            return xuLyDuLieu.thucThiThuTuc("psSuaLop", pr);
        }

        public bool xoaLop(String malop)
        {
            //String SQL = " delete from TableKhachhang where makhachhang =" + maKH;
            //return xuLyDuLieu.thucThiSQL(SQL);
            SqlParameter prmalop = new SqlParameter("@malop", SqlDbType.NChar, 10);
            prmalop.Value = malop;
            SqlParameter[] pr = { prmalop };
            return xuLyDuLieu.thucThiThuTuc("psXoalop", pr);
        }

        public bool themLop(String malop, String makhoa, String tenlop, String sosv)
        {
            SqlParameter prmalop = new SqlParameter("@malop", SqlDbType.NChar, 10);
            prmalop.Value = malop;
            SqlParameter prmakhoa = new SqlParameter("@makhoa", SqlDbType.NChar, 10);
            prmakhoa.Value = makhoa;
            SqlParameter prtenlop = new SqlParameter("@tenlop", SqlDbType.NVarChar, 50);
            prtenlop.Value = makhoa;
            SqlParameter prsosv = new SqlParameter("@sosv", SqlDbType.Int);
            prsosv.Value = sosv;

            SqlParameter[] pr = { prmalop, prmakhoa, prtenlop, prsosv };
            return xuLyDuLieu.thucThiThuTuc("psThemmoiLop", pr);
        }
    }
}
