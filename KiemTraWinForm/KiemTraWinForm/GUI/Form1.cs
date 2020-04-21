using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraWinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public bool Checkform(string formName)
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

        private void thêmKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Checkform("frmKhoa"))
            {
                GUI.frmKhoa frmKH = new GUI.frmKhoa();
                frmKH.MdiParent = this;
                frmKH.Show();
            }
        }

        private void thêmLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Checkform("frmLop"))
            {
                GUI.frmLop frmlop = new GUI.frmLop();
                frmlop.MdiParent = this;
                frmlop.Show();
            }
        }
    }
}
