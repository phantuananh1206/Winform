using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Danhsachnhanvien ds = new Danhsachnhanvien();

            char C;
            Console.WriteLine("Nhap 'Y' de tiep tuc va nhan phim bat ky de thoat ");
            C = Char.Parse(Console.ReadLine());
            while (C == 'Y' || C == 'y')
            {
                Nhanvien nv = null;
                char t;
                Console.WriteLine("Nhap 'B' cho nhan vien bien che va 'D' cho nhan vien hop dong ");
                t = Char.Parse(Console.ReadLine());
                if (t == 'B' || t == 'b')
                {
                    nv = new NhanvienBC();
                    nv.Nhap();
                }
                else if (t == 'D' || t == 'd')
                {
                    nv = new NhanvienHD();
                    nv.Nhap();
                }
                ds.Them(nv);
                Console.WriteLine("Nhap 'Y' de tiep tuc va nhan phim bat ky de thoat ");
                C = Char.Parse(Console.ReadLine());
                ds.Xuat();
                Console.WriteLine("Tong luong : " + ds.Tinhtongluong());

                Console.ReadKey();
            } //end while
            Console.WriteLine("Nhap ma nhan vien : ");
            String manv = Console.ReadLine();
            ds.tim(manv).Xuat();
            ds[manv].Xuat();
        }
    }
}
