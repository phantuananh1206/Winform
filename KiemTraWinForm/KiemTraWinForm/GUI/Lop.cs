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
    public partial class frmLop : Form
    {
        SQLXULYDULIEU xuLyDuLieu;
        String SQL;
        BusinessLogic.blLop nghiepvu;
        public frmLop()
        {
            InitializeComponent();
        }

        public void dataBinding()
        {
            txtmalop.DataBindings.Clear();
            txtmalop.DataBindings.Add("Text", this.dgvLophoc.DataSource, "malop");
            txttenlop.DataBindings.Clear();
            txttenlop.DataBindings.Add("Text", this.dgvLophoc.DataSource, "tenlop");
            this.cobmakhoa.DataBindings.Clear();
            this.cobmakhoa.DataBindings.Add("SelectedValue", this.dgvLophoc.DataSource, "makhoa");
        }

        public void LoadComboBoxMaKhoa()
        {
            nghiepvu.loadComboBox();
        }

        private void btnThemlop_Click(object sender, EventArgs e)
        {
            nghiepvu.themMoiLop();
            nghiepvu.hienThi();
        }

        private void btnSualop_Click(object sender, EventArgs e)
        {
            nghiepvu.capNhat();
            nghiepvu.hienThi();
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            xuLyDuLieu = new SQLXULYDULIEU();
            nghiepvu = new BusinessLogic.blLop(this);
            dataBinding();
            LoadComboBoxMaKhoa();
        }

        private void btnXoalop_Click(object sender, EventArgs e)
        {
            nghiepvu.xoalop();
            nghiepvu.hienThi();
        }

        private void btnDonglop_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
