using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CS414B_PhanTuanAnh_2321122511_QUANLYSINHVIEN.Data_Access
{
    class daKHOA
    {
        SQLXULYDULIEU xulydulieu;
        public daKHOA()
        {
            xulydulieu = new SQLXULYDULIEU();
        }

        public DataTable tableKhoa()
        {
            return xulydulieu.bangDuLieuThuTuc("psBangDuLieuKhoa",null);
        }

        public bool themMoiKhoa(String maKhoa, String tenKhoa)
        {
            SqlParameter prMaKhoa= new SqlParameter("@MAKHOA", SqlDbType.NChar, 10);
            prMaKhoa.Value = maKhoa;
            SqlParameter prTenKhoa = new SqlParameter("@TENKHOA", SqlDbType.NVarChar, 50);
            prTenKhoa.Value = tenKhoa;
            SqlParameter[] pr = { prMaKhoa, prTenKhoa };
           return xulydulieu.thucThiThuTuc("psThemMoiKhoa", pr);
        }

        public bool capNhatKhoa(String maKhoa, String tenKhoa)
        {
            SqlParameter prMaKhoa = new SqlParameter("@MAKHOA", SqlDbType.NChar, 10);
            prMaKhoa.Value = maKhoa;
            SqlParameter prTenKhoa = new SqlParameter("@TENKHOA", SqlDbType.NVarChar, 50);
            prTenKhoa.Value = tenKhoa;
            SqlParameter[] pr = { prMaKhoa, prTenKhoa };
            return xulydulieu.thucThiThuTuc("psSuaKhoa", pr);
        }

        public bool xoaKhoa(String maKhoa)
        {
            SqlParameter prMaKhoa = new SqlParameter("@MAKHOA", SqlDbType.NChar, 10);
            prMaKhoa.Value = maKhoa;
            SqlParameter[] pr = { prMaKhoa };
            return xulydulieu.thucThiThuTuc("psXoakhoa", pr);
        }

        public DataTable timKiemKhoa(String maKhoa)
        {
            SqlParameter prMaKhoa = new SqlParameter("@MAKHOA", SqlDbType.NChar, 10);
            prMaKhoa.Value = maKhoa;
            SqlParameter[] pr = { prMaKhoa };
            return xulydulieu.bangDuLieuThuTuc("psTimKiemKhoa", pr);
        }
    }
}
