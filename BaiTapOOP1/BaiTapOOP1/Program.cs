using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nguoi nguoi = new Nguoi();
            //nguoi.NhapNguoi();
            //nguoi.XuatNguoi();

            //NhanVien nhanVien = new NhanVien();
            //nhanVien.Nhap();
            //nhanVien.Xuat();

            NhanVien nhanVien = new NhanVienBC();
            nhanVien.Nhap();
            nhanVien.Xuat();

            Console.ReadKey();
        }
    }
}
