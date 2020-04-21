using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS414B_PhanTuanAnh_2321122511_QUANLYSINHVIEN.GUI
{
    public partial class guiMAIN : Form
    {
        public guiMAIN()
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

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!kiemTraForm("guiKHOA"))
            {
                guiKHOA guikhoa = new guiKHOA();
                guikhoa.MdiParent = this;
                guikhoa.Show();
            }
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!kiemTraForm("guiLOPHOC"))
            {
                guiLOPHOC guilophoc = new guiLOPHOC();
                guilophoc.MdiParent = this;
                guilophoc.Show();
            }
        }
    }
}
