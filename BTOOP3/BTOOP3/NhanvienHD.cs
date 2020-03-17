using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOOP3
{
    class NhanvienHD:Nhanvien,INhanVien
    {
        private int Ngaycong;
        private double muctamung;
        public int NGAYCONG
        {
            get { return Ngaycong; }
            set { Ngaycong = value; }
        }
        public NhanvienHD():base()
        {

        }

        public NhanvienHD(String hoten, DateTime ngaysinh, String gioitinh, long socm, String manv, DateTime ngayvao, Double luongcoban
            , int ngaycong)
            : base(hoten, ngaysinh, gioitinh, socm, manv, ngayvao, luongcoban)
        {
            this.Ngaycong = ngaycong;
        }

        override public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap ngay cong : ");
            this.Ngaycong = Convert.ToInt16(Console.ReadLine());
        }

        override public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ngay cong : " + this.Ngaycong);
        }

        override public Double Phucap()
        {
            if (base.Tinhthamnien() < 2)
                return 200000;
            else
                return 300000;
        }
        public double mucTamUng        {            
            set {this.muctamung=0.3; }            
            get { return this.muctamung; }       }
        public double tamUngLuong() { 
            return (this.Ngaycong * (base.LUONGCOBAN / this.Ngaycong) + this.Phucap()) * this.muctamung; }    

        override public Double Tinhluong()
        {
            return this.Ngaycong * (base.LUONGCOBAN / this.Ngaycong) + this.Phucap() - this.tamUngLuong();
        }
    }
}
