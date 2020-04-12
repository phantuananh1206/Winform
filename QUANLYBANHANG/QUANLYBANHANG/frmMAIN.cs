using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG
{
    public partial class frmMAIN : Form
    {
        public frmMAIN()
        {
            InitializeComponent();
        }

        public bool kiemTraForm(String nameForm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(nameForm))
                {
                    f.Activate();
                    return true;
                }
            }
            return false;
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            if (!kiemTraForm("frmDANGNHAP"))
            {
                frmDANGNHAP frmDangNhap = new frmDANGNHAP();
                frmDangNhap.MdiParent = this;
                frmDangNhap.Show();
            }
        }

        private void menuitDanhMuc_Click(object sender, EventArgs e)
        {
            if (!kiemTraForm("frmQUANHLYDANHMUC"))
            {
                frmQUANLYDANHMUC frmquanlydanhmuc = new frmQUANLYDANHMUC();
                frmquanlydanhmuc.MdiParent = this;
                frmquanlydanhmuc.Show();
            }
        }

        private void sảnphẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!kiemTraForm("frmQUANLYSANPHAM"))
            {
                frmQUANLYSANPHAM frmquanlysanpham = new frmQUANLYSANPHAM();
                frmquanlysanpham.MdiParent = this;
                frmquanlysanpham.Show();
            }
        }

        private void kháchhàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!kiemTraForm("frmKHACHHANG"))
            {
                frmKHACHHANG frmkhachhang = new frmKHACHHANG();
                frmkhachhang.MdiParent = this;
                frmkhachhang.Show();
            }
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!kiemTraForm("frmHOADON"))
            {
                frmHOADON frmhoadon = new frmHOADON();
                frmhoadon.MdiParent = this;
                frmhoadon.Show();
            }
        }

        private void chitiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!kiemTraForm("frmCHITIET"))
            {
                frmCHITIET frmchitiet = new frmCHITIET();
                frmchitiet.MdiParent = this;
                frmchitiet.Show();
            }
        }
    }
}
