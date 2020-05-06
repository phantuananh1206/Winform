using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS414B_PhanTuanAnh_2321122511_QUANLYNHANSU.GUI
{
    public partial class main_form : Form
    {
        public main_form()
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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void nhậpHồSơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!kiemTraForm("sub_form_ho_so"))
            {
                sub_form_ho_so frmhoso = new sub_form_ho_so();
                frmhoso.MdiParent = this;
                frmhoso.Show();
            }
        }
    }
}
