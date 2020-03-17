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
        //String[] array = { "le a", "le b", "le c" };

        //public String this[int index]
        //{
        //    set
        //    {
        //        if (index >= 0 && index < array.Length)
        //            array[index] = value;
        //    }
        //    get
        //    {
        //        if (index >= 0 && index < array.Length)
        //            return array[index];
        //        else
        //            return null;
        //    }
        //}
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
