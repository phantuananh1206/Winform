using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraWinForm.GUI
{
    public partial class frmKhoa : Form
    {
        BusinessLogic.blKhoa nghiepvu;
        public frmKhoa()
        {
            InitializeComponent();
        }

        public void dataBinding()
        {
            txtmakhoa.DataBindings.Clear();
            txtmakhoa.DataBindings.Add("Text", this.dgvKhoa.DataSource, "makhoa");
            txttenkhoa.DataBindings.Clear();
            txttenkhoa.DataBindings.Add("Text", this.dgvKhoa.DataSource, "tenkhoa");
        }



        private void btnThemkhoa_Click(object sender, EventArgs e)
        {
            nghiepvu.themMoiKhoa();
            nghiepvu.hienThi();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            nghiepvu = new BusinessLogic.blKhoa(this);
            dataBinding();
        }

        private void btnSuakhoa_Click(object sender, EventArgs e)
        {
            nghiepvu.capNhat();
            nghiepvu.hienThi();
        }

        private void btnXoakhoa_Click(object sender, EventArgs e)
        {
            nghiepvu.xoaKhoa();
            nghiepvu.hienThi();
        }

        private void btnDongkhoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
