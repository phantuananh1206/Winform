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
    public partial class guiLOPHOC : Form
    {
        Business_Logic.blLOPHOC nghiepvu;
        public guiLOPHOC()
        {
            InitializeComponent();
        }

        private void guiLOPHOC_Load(object sender, EventArgs e)
        {
            nghiepvu = new Business_Logic.blLOPHOC(this);
            nghiepvu.loadComboboxKhoa();
            loadData();
        }

        private void loadData()
        {
            nghiepvu.hienThi();
            txtMALOP.DataBindings.Clear();
            txtMALOP.DataBindings.Add("Text", this.dgvLOPHOC.DataSource, "MALOP");
            cobKHOA.DataBindings.Clear();
            cobKHOA.DataBindings.Add("Text", this.dgvLOPHOC.DataSource, "MAKHOA");
            txtTENLOP.DataBindings.Clear();
            txtTENLOP.DataBindings.Add("Text", this.dgvLOPHOC.DataSource, "TENLOP");
            txtSOSINHVIEN.DataBindings.Clear();
            txtSOSINHVIEN.DataBindings.Add("Text", this.dgvLOPHOC.DataSource, "SOSV");
        }
        private void btnTHEMMOI_Click(object sender, EventArgs e)
        {
            nghiepvu.themMoiLopHoc();
            loadData();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            nghiepvu.capNhatLopHoc();
            loadData();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            nghiepvu.xoaLopHoc();
            loadData();
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            nghiepvu.timKiemLopHoc();
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
