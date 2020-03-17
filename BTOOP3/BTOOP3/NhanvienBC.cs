using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOOP3
{
    class NhanvienBC:Nhanvien,INhanVien
    {
        private Double muctamung;
        private Double Hesoluong;

        public Double HESOLUONG
        {
            get { return Hesoluong; }
            set { Hesoluong = value; }
        } 
        public NhanvienBC():base()
        {

        }

        public NhanvienBC(String hoten, DateTime ngaysinh, String gioitinh, long socm, String manv, DateTime ngayvao, Double luongcoban
            ,Double hesoluong):base(hoten, ngaysinh, gioitinh, socm, manv, ngayvao, luongcoban)
        {
            this.Hesoluong = hesoluong;
        }

        override public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap he so luong : ");
            this.Hesoluong = Convert.ToDouble(Console.ReadLine());
        }

        override public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("He so luong : " + this.Hesoluong);
            Console.WriteLine("Phu cap : " + this.Phucap());
            Console.WriteLine("Thuc linh : " + this.Tinhluong());
        }

        override public Double Phucap()
        {
            if (base.Tinhthamnien() < 5)
                return 200000;
            else
                return 500000;
        }

        public double mucTamUng { 
            set { this.muctamung = 0.5; } 
            get { return this.muctamung; } }
        public double tamUngLuong() { 
            return (this.Hesoluong * base.LUONGCOBAN + this.Phucap()) * this.muctamung; }   

        override public Double Tinhluong()
        {
            return this.Hesoluong * base.LUONGCOBAN + this.Phucap() - this.tamUngLuong();
        }

    }
}
