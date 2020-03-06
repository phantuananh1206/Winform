using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP1
{
    class NhanVienBC:NhanVien
    {
        private Double heSoLuong;

        public Double HeSoLuong
        {
            get { return heSoLuong; }
            set { heSoLuong = value; }
        }
        public NhanVienBC() : base()
        {

        }
        //public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }



        public NhanVienBC(string hoTen, DateTime ngaySinh, string gioiTinh, long soCM, string maNV, DateTime ngayVao, double luongCoBan, double heSoLuong)
            : base(hoTen, ngaySinh, gioiTinh, soCM, maNV, ngayVao, luongCoBan)
        {
            this.HeSoLuong = heSoLuong;
        }

        public NhanVienBC(NhanVienBC nvbc) : base(new NhanVien(nvbc.HoTen, nvbc.NgaySinh, nvbc.GioiTinh, nvbc.SoCM, nvbc.MaNV, nvbc.NgayVao, nvbc.LuongCoBan))
        {
            this.HeSoLuong = nvbc.heSoLuong;
        }

        override public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap he so luong : ");
            this.HeSoLuong = Convert.ToDouble(Console.ReadLine());
        }

        override public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("He so luong: " + this.HeSoLuong);
            Console.WriteLine("Luong: " + this.tinhLuong());
            Console.WriteLine("Phu cap: " + this.tinhPhuCap());
        }

        public Double tinhLuong()
        {
           return base.LuongCoBan * this.HeSoLuong + this.tinhPhuCap();
        }

        public Double tinhPhuCap()
        {
            if (base.tinhThamNien() > 5)
            {
                return 200;
            }
            else
            {
                return 100;
            }
        }
    }
}
