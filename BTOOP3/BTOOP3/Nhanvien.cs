using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOOP3
{
    abstract class Nhanvien:Nguoi
    {
        private String MaNV;

        public String MANV
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        private DateTime Ngayvao;

        public DateTime NGAYVAO
        {
            get { return Ngayvao; }
            set { Ngayvao = value; }
        }
        private Double Luongcoban;

        public Double LUONGCOBAN
        {
            get { return Luongcoban; }
            set { Luongcoban = value; }
        }

        public Nhanvien ():base()
	{

	}

        public Nhanvien(String hoten, DateTime ngaysinh, String gioitinh, long socm, String manv, DateTime ngayvao, Double luongcoban)
            :base(hoten, ngaysinh, gioitinh, socm)
        {
            this.MaNV = manv;
            this.Ngayvao = ngayvao;
            this.Luongcoban = luongcoban;
        }

        public Nhanvien(Nhanvien nv)
            : base(new Nguoi(nv.Hoten, nv.Ngaysinh, nv.GioiTinh, nv.Socm))
        {
            this.MaNV = MaNV;
            this.Ngayvao = Ngayvao;
            this.Luongcoban = Luongcoban;
        }

        public int Tinhthamnien()
        {
            return DateTime.Today.Year - this.Ngayvao.Year;
        }

        virtual public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap ma nhan vien : ");
            this.MaNV = Console.ReadLine();
            Console.WriteLine("Nhap ngay vao : ");
            this.Ngayvao = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap luong co ban : ");
            this.Luongcoban = Convert.ToDouble(Console.ReadLine());
        }

        virtual public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma nhan vien : " + this.MaNV);
            Console.WriteLine("Ngay vao : " + this.Ngayvao);
            Console.WriteLine("Luong co ban : " + this.Luongcoban);
        }

        abstract public Double Phucap();
        abstract public Double Tinhluong();

    }
}
