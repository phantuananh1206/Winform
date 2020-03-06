using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP1
{
    class NhanVien:Nguoi
    {
        private String maNV;

        protected String MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private DateTime ngayVao;

        protected DateTime NgayVao
        {
            get { return ngayVao; }
            set { ngayVao = value; }
        }
        private Double luongCoBan;

        protected Double LuongCoBan
        {
            get { return luongCoBan; }
            set { luongCoBan = value; }
        }

        public NhanVien():base()
        {
           
        }

        //public string MaNV { get => maNV; set => maNV = value; }
        //public DateTime NgayVao { get => ngayVao; set => ngayVao = value; }
        //public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }

        public NhanVien(string hoTen, DateTime ngaySinh, string gioiTinh, long soCM, string maNV, DateTime ngayVao, double luongCoBan)
            :base(hoTen, ngaySinh, gioiTinh, soCM)
        {
            this.MaNV = maNV;
            this.NgayVao = ngayVao;
            this.LuongCoBan = luongCoBan;
        }
        public NhanVien(NhanVien nv):base(new Nguoi(nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.SoCM))
        {
            this.MaNV = nv.maNV;
            this.NgayVao = nv.ngayVao;
            this.LuongCoBan = nv.luongCoBan;
        }

        public int tinhThamNien()
        {
            return DateTime.Today.Year - this.NgayVao.Year;
        }
        virtual public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap ma nhan vien: ");
            this.MaNV = Console.ReadLine();
            Console.WriteLine("Nhap ngay vao : ");
            this.NgayVao = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap luong co ban: ");
            this.LuongCoBan = Convert.ToDouble(Console.ReadLine());
        }
        virtual public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma nhan vien: " + this.MaNV);
            Console.WriteLine("Ngay vao: " + this.NgayVao);
            Console.WriteLine("Luong co ban: " + this.LuongCoBan);
            Console.WriteLine("Tham nien: " + this.tinhThamNien());
        }

       
    }
}
