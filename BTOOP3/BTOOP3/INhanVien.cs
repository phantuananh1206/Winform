using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOOP3
{
    interface INhanVien
    {
        double mucTamUng { 
            set;
            get; } 
        double tamUngLuong(); 
    }
}
