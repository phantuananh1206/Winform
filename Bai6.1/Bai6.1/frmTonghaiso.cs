using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6._1
{
    public partial class frmTonghaiso : Form
    {
        public frmTonghaiso()
        {
            InitializeComponent();
        }

        private void btnTinhtong_Click(object sender, EventArgs e)
        {
            double a,b, ketqua;
            a = Double.Parse(txtSoA.Text);
            b = Double.Parse(txtSoB.Text);
            ketqua = a + b;
            txtKetqua.Text = ketqua.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
    
}
