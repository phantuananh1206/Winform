using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUOI
{
    class SINHVIEN
    {
        private String Hoten;
        public String DiaChi;
        //public static int
        public String HOTEN
        {
            set { this.Hoten = value; }
            get { return this.Hoten; }
        }

        public SINHVIEN()
        {

        }
        public SINHVIEN(String hoten)
        {
            this.Hoten = hoten;
        }
        public SINHVIEN(SINHVIEN sv) 
        {
            this.Hoten = sv.Hoten; //hàm khởi tạo copy cho phép copy thuộc tính và kiểu dữ liệu private
        }
        public void Xuat()
        {
            Console.WriteLine("Ho va ten : " + this.Hoten);
        }

    }
    
}
