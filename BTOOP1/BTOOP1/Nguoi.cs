using System;
using System.Collections.Generic;
using System.Text;

namespace BTOOP1
{
    class Nguoi
    {
        private String hoTen;
        private DateTime ngaySinh;
        private String gioiTinh;
        private long soCM;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public long SoCM { get => soCM; set => soCM = value; }
        public Nguoi()
        {

        }

        public Nguoi(string hoTen, DateTime ngaySinh, string gioiTinh, long soCM)
        {
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.SoCM = soCM;
        }

        public Nguoi(Nguoi nguoi)
        {
            this.HoTen = nguoi.HoTen;
            this.NgaySinh = nguoi.NgaySinh;
            this.SoCM = nguoi.SoCM;
            this.GioiTinh = nguoi.GioiTinh;
        }
    
        public int tinhTuoi()
        {
            return DateTime.Today.Year - this.NgaySinh.Year;
        }
         
        public void Nhap()
        {
            Console.WriteLine("Nhập họ và tên: ");
            this.HoTen = Console.ReadLine();
            Console.WriteLine("Nhập ngày sinh: ");
            this.NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giới tính: ");
            this.GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhập số chứng minh: ");
            this.SoCM = Convert.ToInt16(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Họ và tên: " + this.HoTen);
            Console.WriteLine("Ngày sinh: " + this.NgaySinh);
            Console.WriteLine("Giới tính: " + this.GioiTinh);
            Console.WriteLine("Số chứng minh: " + this.SoCM);
            Console.WriteLine("Tuổi: " + this.tinhTuoi());
        }

       
    }
}
