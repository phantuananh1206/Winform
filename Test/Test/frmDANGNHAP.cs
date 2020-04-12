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
    public partial class frmDANGNHAP : Form
    {
        String SQL;
        XuLyDuLieu xuLyDL;
        
        public frmDANGNHAP()
        {
            InitializeComponent();
        }

        private void frmDANGNHAP_Load(object sender, EventArgs e)
        {
            xuLyDL = new XuLyDuLieu();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SQL = " select count(*) from tbDANGNHAP where TENDANGNHAP = '"
                + this.txtTenDangNhap.Text + "'"
                + " AND "
                + " MATKHAU = '" + this.txtMatKhau.Text + "'";
            int ketqua = (int) xuLyDL.thucThiGiaTriDon(SQL);
            if (ketqua > 0)
            {
                MessageBox.Show("Dang nhap thanh cong!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai ten tai dang nhap hoac mat khau!");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Ban co muon thoat khong?", "Thong bao", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            Application.Exit();
        }

        

    }
}
