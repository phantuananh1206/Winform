using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CS414B_PhanTuanAnh_2321122511_QUANLYSINHVIEN.Data_Access
{
    class daLOPHOC
    {
        SQLXULYDULIEU xulydulieu;

        public daLOPHOC()
        {
            xulydulieu = new SQLXULYDULIEU();
        }

        public DataTable tableLopHoc()
        {
            return xulydulieu.bangDuLieuThuTuc("psBangDuLieuLopHoc", null);
        }

        public bool themMoiLopHoc(String maLop, String maKhoa, String tenLop, Int32 soSinhVien)
        {
            SqlParameter prMaLop = new SqlParameter("@MALOP", SqlDbType.NChar, 10);
            prMaLop.Value = maLop;
            SqlParameter prMaKhoa = new SqlParameter("@MaKhoa", SqlDbType.NChar, 10);
            prMaKhoa.Value = maKhoa;
            SqlParameter prTenLop = new SqlParameter("@TENLOP", SqlDbType.NVarChar, 50);
            prTenLop.Value = tenLop;
            SqlParameter prSoSinhVien = new SqlParameter("@SOSV", SqlDbType.Int);
            prSoSinhVien.Value = soSinhVien;
            SqlParameter[] pr = { prMaLop, prMaKhoa, prTenLop, prSoSinhVien };
            return xulydulieu.thucThiThuTuc("psThemMoiLopHoc", pr);
        }

        public bool capNhatLopHoc(String maLop, String maKhoa, String tenLop, Int32 soSinhVien)
        {
            SqlParameter prMaLop = new SqlParameter("@MALOP", SqlDbType.NChar, 10);
            prMaLop.Value = maLop;
            SqlParameter prMaKhoa = new SqlParameter("@MaKhoa", SqlDbType.NChar, 10);
            prMaKhoa.Value = maKhoa;
            SqlParameter prTenLop = new SqlParameter("@TENLOP", SqlDbType.NVarChar, 50);
            prTenLop.Value = tenLop;
            SqlParameter prSoSinhVien = new SqlParameter("@SOSV", SqlDbType.Int);
            prSoSinhVien.Value = soSinhVien;
            SqlParameter[] pr = { prMaLop, prMaKhoa, prTenLop, prSoSinhVien };
            return xulydulieu.thucThiThuTuc("psSuaLopHoc", pr);
        }

        public bool xoaLopHoc(String maLop)
        {
            SqlParameter prMaLop = new SqlParameter("@MALOP", SqlDbType.NChar, 10);
            prMaLop.Value = maLop;
            SqlParameter[] pr = { prMaLop };
            return xulydulieu.thucThiThuTuc("psXoaLopHoc", pr);
        }

        public DataTable timKiemLopHoc(String maLop)
        {
            SqlParameter prMaLop = new SqlParameter("@MALOP", SqlDbType.NChar, 10);
            prMaLop.Value = maLop;
            SqlParameter[] pr = { prMaLop };
            return xulydulieu.bangDuLieuThuTuc("psTimKiemLopHoc", pr);
        }
    }
}
