using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenNhanVien
{
    class Nhanvien:Nguoi
    {
        protected String Manv;

        public String MANV
        {
            get { return Manv; }
            set { Manv = value; }
        }
        protected DateTime Ngayvao;

        public DateTime NGAYVAO
        {
            get { return Ngayvao; }
            set { Ngayvao = value; }
        }
        protected Double Luongcoban;

        public Double LUONGCOBAN
        {
            get { return Luongcoban; }
            set { Luongcoban = value; }
        }

        public Nhanvien() { }
        public Nhanvien()
        {

        }
    }
}
