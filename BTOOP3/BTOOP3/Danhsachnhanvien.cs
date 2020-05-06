using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOOP3
{
    class Danhsachnhanvien
    {
        Dictionary<String, Nhanvien> danhsach;
        public Nhanvien this[String key]
        {
            set
            {
                if (danhsach.ContainsKey(key))
                    danhsach[key] = value;
            }
            get
            {
                if (danhsach.ContainsKey(key))
                    return danhsach[key];
                else
                    return null;
            }
        }
   
        public Danhsachnhanvien()
        {
            danhsach = new Dictionary<string, Nhanvien>();
        }

        public void Them(Nhanvien nv)
        {
            danhsach.Add(nv.MANV, nv);
        }

        public void Xoa(String Manv)
        {
            danhsach.Remove(Manv);
        }

        public Nhanvien tim(String Manv)
        {
            return danhsach[Manv];
        }

        public double Tinhtongluong()
        {
            double tongluong = 0;
            foreach (Nhanvien nv in danhsach.Values)
                tongluong += nv.Tinhluong();
            return tongluong; 
        }

        public void Xuat()
        {
            foreach (Nhanvien nv in danhsach.Values)
                nv.Xuat();
        }

    }
}
