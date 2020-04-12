using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class frmMAIN : Form
    {
        public frmMAIN()
        {
            InitializeComponent();
        }

        public bool ktForm(String nameForm)
        {
            
            foreach (Form f in this.MdiChildren){
                if (f.Name.Equals(nameForm))
                {
                    f.Activate();
                    return true;
                }
                           }
            return false;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ktForm("frmDANGNHAP"))
            {
                frmDANGNHAP frmDangNhap = new frmDANGNHAP();
                frmDangNhap.MdiParent = this;
                frmDangNhap.Show();
            }
        }

        private void danhmụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ktForm("frmQUANLYDANHMUC"))
            {
                frmQUANLYDANHMUC frmquanlydanhmuc = new frmQUANLYDANHMUC();
                frmquanlydanhmuc.MdiParent = this;
                frmquanlydanhmuc.Show();
            }
        }
    }
}
