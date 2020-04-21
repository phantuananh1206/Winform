using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QUANLYBANHANG.Data_Access
{
    class daKHACHHANG
    {
        SQLXULYDULIEU xulydulieu;
        String SQL;
        public daKHACHHANG()
        {
            xulydulieu = new SQLXULYDULIEU();
        }
        public DataTable tableKHACHHANG()
        {
            SQL = " select * from tbKHACHHANG";
            return xulydulieu.bangDuLieu(SQL);
        }

        public bool themMoi(String tenkhachhang, String gioitinh)
        {
            SQL = " insert into tbKHACHHANG(TENKHACHHANG, GIOITINH)"
                + "Values ('" + tenkhachhang + "', '" + gioitinh + "')";
            return xulydulieu.thucThiSQL(SQL);
        }

        public bool Sua()
        {
            return false;
        }

        public bool XOA()
        {
            return false;
        }
    }
}
