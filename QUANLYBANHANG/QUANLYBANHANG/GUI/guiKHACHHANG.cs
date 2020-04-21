using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG.GUI
{
    public partial class guiKHACHHANG : Form
    {
        Business_Logic.blKHACHHANG nghiepvu;
        public guiKHACHHANG()
        {
            InitializeComponent();
        }

        private void guiKHACHHANG_Load(object sender, EventArgs e)
        {
            nghiepvu = new Business_Logic.blKHACHHANG(this);
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            nghiepvu.themMoi();
            nghiepvu.hienthi();
        }
    }
}
