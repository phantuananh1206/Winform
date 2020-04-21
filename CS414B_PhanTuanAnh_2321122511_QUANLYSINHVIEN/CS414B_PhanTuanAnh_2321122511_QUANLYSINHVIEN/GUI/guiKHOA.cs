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
    public partial class guiKHOA : Form
    {
        Business_Logic.blKHOA nghiepvu;
        public guiKHOA()
        {
            InitializeComponent();
        }

        private void guiKHOA_Load(object sender, EventArgs e)
        {
            nghiepvu = new Business_Logic.blKHOA(this);
            loadData();
        }

        private void loadData()
        {
            nghiepvu.hienThi();
            txtMAKHOA.DataBindings.Clear();
            txtMAKHOA.DataBindings.Add("Text", this.dgvKHOA.DataSource, "MAKHOA");
            txtTENKHOA.DataBindings.Clear();
            txtTENKHOA.DataBindings.Add("Text", this.dgvKHOA.DataSource, "TENKHOA");
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            nghiepvu.themMoiKhoa();
            loadData();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            nghiepvu.xoaKhoa();
            loadData();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            nghiepvu.capNhatKhoa();
            loadData();
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            nghiepvu.timKiemKhoa();
        }

        private void btnHIENTHI_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnDONG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

    }
}
