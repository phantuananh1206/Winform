using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CS414B_PhanTuanAnh_2321122511_QUANLYNHANSU.Data_Access
{
    class daHOSO
    {
        SQLXULYDULIEU xuLyDuLieu;

        public daHOSO()
        {
            xuLyDuLieu = new SQLXULYDULIEU();
        }

        public DataTable tableHoSo()
        {
            return xuLyDuLieu.bangDuLieuThuTuc("psBangDuLieuHoSo", null);
        }

        public bool themHoSo(String maNhanVien, String hoTen, DateTime ngaySinh, String gioiTinh,
            String maPhongBan, byte[] anhNhanVien)
        {
            SqlParameter prMANHANVIEN = new SqlParameter("@MANHANVIEN", SqlDbType.NChar, 10);
            prMANHANVIEN.Value = maNhanVien;
            SqlParameter prHOTEN = new SqlParameter("@HOTEN", SqlDbType.NVarChar, 200);
            prHOTEN.Value = hoTen;
            SqlParameter prNGAYSINH = new SqlParameter("@NGAYSINH", SqlDbType.DateTime);
            prNGAYSINH.Value = ngaySinh;
            SqlParameter prGIOITINH = new SqlParameter("@GIOITINH", SqlDbType.NVarChar, 5);
            prGIOITINH.Value = gioiTinh;
            SqlParameter prMAPHONGBAN = new SqlParameter("@MAPHONGBAN", SqlDbType.NChar, 10);
            prMAPHONGBAN.Value = maPhongBan;
            SqlParameter prANHNHANVIEN = new SqlParameter("@ANHNHANVIEN", SqlDbType.Image);
            prANHNHANVIEN.Value = anhNhanVien;
            SqlParameter[] pr = { prMANHANVIEN, prHOTEN, prNGAYSINH, prGIOITINH, prMAPHONGBAN, prANHNHANVIEN};
            return xuLyDuLieu.thucThiThuTuc("psThemMoiHoSo", pr);
        }

        public bool suaHoSo(String maNhanVien, String hoTen, DateTime ngaySinh, String gioiTinh,
            String maPhongBan, byte[] anhNhanVien)
        {
            SqlParameter prMANHANVIEN = new SqlParameter("@MANHANVIEN", SqlDbType.NChar, 10);
            prMANHANVIEN.Value = maNhanVien;
            SqlParameter prHOTEN = new SqlParameter("@HOTEN", SqlDbType.NVarChar, 200);
            prHOTEN.Value = hoTen;
            SqlParameter prNGAYSINH = new SqlParameter("@NGAYSINH", SqlDbType.DateTime);
            prNGAYSINH.Value = ngaySinh;
            SqlParameter prGIOITINH = new SqlParameter("@GIOITINH", SqlDbType.NVarChar, 5);
            prGIOITINH.Value = gioiTinh;
            SqlParameter prMAPHONGBAN = new SqlParameter("@MAPHONGBAN", SqlDbType.NChar, 10);
            prMAPHONGBAN.Value = maPhongBan;
            SqlParameter prANHNHANVIEN = new SqlParameter("@ANHNHANVIEN", SqlDbType.Image);
            prANHNHANVIEN.Value = anhNhanVien;
            SqlParameter[] pr = { prMANHANVIEN, prHOTEN, prNGAYSINH, prGIOITINH, prMAPHONGBAN, prANHNHANVIEN };
            return xuLyDuLieu.thucThiThuTuc("psSuaHoSo", pr);
        }

        public bool xoaHoSo(String maNhanVien)
        {
            SqlParameter prMANHANVIEN = new SqlParameter("@MANHANVIEN", SqlDbType.NChar, 10);
            prMANHANVIEN.Value = maNhanVien;

            SqlParameter[] pr = { prMANHANVIEN };
            return xuLyDuLieu.thucThiThuTuc("psXoaHoSo", pr);
        }

        public DataTable timKiemHoSo(String maNhanVien)
        {
            SqlParameter prMANHANVIEN = new SqlParameter("@MANHANVIEN", SqlDbType.NChar, 10);
            prMANHANVIEN.Value = maNhanVien;

            SqlParameter[] pr = { prMANHANVIEN };
            return xuLyDuLieu.bangDuLieuThuTuc("psTimKiemHoSo", pr);
        }

    }
}
