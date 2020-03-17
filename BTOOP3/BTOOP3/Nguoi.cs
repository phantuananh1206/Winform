using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOOP3
{
    class Nguoi
    {
        protected String Hoten;

        protected String HOTEN
        {
            get { return Hoten; }
            set { Hoten = value; }
        }
        protected DateTime Ngaysinh;

        protected DateTime NGAYSINH
        {
            get { return Ngaysinh; }
            set { Ngaysinh = value; }
        }
        protected String GioiTinh;

        protected String GIOITINH
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        protected long Socm;

        protected long SOCM
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
            this.GioiTinh = gioitinh;
            this.Socm = socm;
        }

        public Nguoi(Nguoi nguoi)
        {
            this.Hoten = nguoi.Hoten;
            this.Ngaysinh = nguoi.Ngaysinh;
            this.GioiTinh = nguoi.GioiTinh;
            this.Socm = nguoi.Socm;
        }

        public int Tinhtuoi()
        {
            return DateTime.Today.Year - this.Ngaysinh.Year;
        }

        public void Nhap(){
            Console.WriteLine("Nhap ho va ten : ");
            this.Hoten = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh : ");
            this.Ngaysinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh : ");
            this.GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhap so cm : ");
            this.Socm = Convert.ToInt32(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ho va ten : " + this.Hoten);
            Console.WriteLine("Ngay sinh : " + this.Ngaysinh);
            Console.WriteLine("Gioi tinh : " + this.GioiTinh);
            Console.WriteLine("So cm : " + this.Socm);
        }

    }
}
