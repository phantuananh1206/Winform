using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMAIN : Form
    {
        public frmMAIN()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Kiemtra("frmDANGNHAP"))
            {
                frmDANGNHAP frmdangnhap = new frmDANGNHAP();
                frmdangnhap.MdiParent = this;
                frmdangnhap.Show();
            }
        }

        public bool Kiemtra(string formName)
        {
            bool flag = false;
            foreach (Form frm in this.MdiChildren)
                if (frm.Name.Equals(formName))
                {
                    flag = true;
                    frm.Activate();
                }
            return flag;
        }

        private void nhậpDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Kiemtra("frm_NHAPDANHMUC"))
            {
                frm_NHAPDANHMUC frmnhapdanhmuc = new frm_NHAPDANHMUC();
                frmnhapdanhmuc.MdiParent = this;
                frmnhapdanhmuc.Show();
            }
        }
    }
}
