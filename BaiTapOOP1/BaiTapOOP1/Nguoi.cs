using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP1
{
    class Nguoi
    {
        private String hoTen;

        protected String HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private DateTime ngaySinh;

        protected DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private String gioiTinh;

        protected String GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private long soCM;

        protected long SoCM
        {
            get { return soCM; }
            set { soCM = value; }
        }

        //public string HoTen { get => hoTen; set => hoTen = value; }
        //public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        //public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        //public long SoCM { get => soCM; set => soCM = value; }
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
            this.HoTen = nguoi.hoTen;
            this.NgaySinh = nguoi.ngaySinh;
            this.SoCM = nguoi.soCM;
            this.GioiTinh = nguoi.gioiTinh;
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
            this.SoCM = Convert.ToInt32(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Họ và tên: " + this.HoTen);
            Console.WriteLine("Ngày sinh: " + this.NgaySinh);
            Console.WriteLine("Giới tính: " + this.GioiTinh);
            Console.WriteLine("Số chứng minh: " + this.SoCM);
            Console.WriteLine("Tuổi: " + this.tinhTuoi());
        }
        public int tinhTuoi()
        {
            return DateTime.Today.Year - this.NgaySinh.Year;
        }

       
    }
}
