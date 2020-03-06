using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NGUOI;
namespace BaiTap1
{
    class Mainn
    {
        static void Main(string[] args)
        {
            SINHVIEN sv = new SINHVIEN();
            sv.HOTEN = "Le Van A";
            String ht = sv.HOTEN;
        }
    }
}
