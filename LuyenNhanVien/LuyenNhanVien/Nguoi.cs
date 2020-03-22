using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenNhanVien
{
    class Nguoi
    {
        protected String Hoten;

        public String HOTEN
        {
            get { return Hoten; }
            set { Hoten = value; }
        }
        protected DateTime Ngaysinh;

        public DateTime NGAYSINH
        {
            get { return Ngaysinh; }
            set { Ngaysinh = value; }
        }
        protected String Gioitinh;

        public String GIOITINH
        {
            get { return Gioitinh; }
            set { Gioitinh = value; }
        }
        protected long Socm;

        public long SOCM
        {
            get { return Socm; }
            set { Socm = value; }
        }

        public Nguoi()
        {

        }
        public Nguoi(String hoten, DateTime ngaysinh, String gioitinh, long socm)
        {
            this.Hoten = hoten;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Socm = socm;
        }
        public Nguoi(Nguoi nguoi)
        {
            this.Hoten = nguoi.Hoten;
            this.Ngaysinh = nguoi.Ngaysinh;
            this.Gioitinh = nguoi.Gioitinh;
            this.Socm = nguoi.Socm;
        }

        public int tinhtuoi()
        {
            return DateTime.Today.Year - this.Ngaysinh.Year;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ho ten : " + this.Hoten);
            Console.WriteLine("Nhap ngay sinh : " + this.Ngaysinh);
            Console.WriteLine("Nhap gioi tinh : " + this.Gioitinh);
            Console.WriteLine("Nhap so cm : " + this.Socm);
        }

        public void Xuat()
        {
            Console.WriteLine("Ho ten : ");
            this.Hoten = Console.ReadLine();
            Console.WriteLine("Ngay sinh : ");
            this.Ngaysinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Gioi tinh : ");
            this.Gioitinh = Console.ReadLine();
            Console.WriteLine("So cm : ");
            this.Socm = Convert.ToInt32(Console.ReadLine());
        }

    }
}
