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
    public partial class sub_form_ho_so : Form
    {
        Business_Logic.blHOSO nghiepvu;
        SQLXULYDULIEU xuLyDuLieu;
        public sub_form_ho_so()
        {
            InitializeComponent();
        }

        private void sub_form_ho_so_Load(object sender, EventArgs e)
        {
            xuLyDuLieu = new SQLXULYDULIEU();
            nghiepvu = new Business_Logic.blHOSO(this);
            nghiepvu.loadComboBoxPhongBan();
            nghiepvu.hienThi();
        }


        private void ptbANHNHANVIEN_DoubleClick(object sender, EventArgs e)
        {
            nghiepvu.loadAnhNhanVien();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            nghiepvu.themMoiHoSo();
            nghiepvu.hienThi();
        } 

        private void btnSUA_Click(object sender, EventArgs e)
        {
            nghiepvu.suaHoSo();
            nghiepvu.hienThi();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            nghiepvu.xoaHoSo();
            nghiepvu.hienThi();
        }

        private void btnDONG_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn đóng không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
                this.Close();
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            nghiepvu.timKiemHoSo();
        }

        private void btnHIENTHI_Click(object sender, EventArgs e)
        {
            nghiepvu.hienThi();
        }
    }
}
