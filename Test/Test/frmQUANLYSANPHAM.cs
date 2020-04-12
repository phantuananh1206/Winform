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
    public partial class frmQUANLYSANPHAM : Form
    {
        XuLyDuLieu xuly;
        String SQL;
        public frmQUANLYSANPHAM()
        {
            InitializeComponent();
        }

        private void frmQUANLYSANPHAM_Load(object sender, EventArgs e)
        {
            xuly = new XuLyDuLieu();
            loadDataGridView();
            loadComboboxMaDanhMuc();
        }

        public void loadDataGridView()
        {
            SQL = " select * from tbSANPHAM ";
            this.dgvSanPham.DataSource = xuly.bangDuLieu(SQL);
            txtMaSanPham.DataBindings.Clear();
            txtMaSanPham.DataBindings.Add("Text", this.dgvSanPham.DataSource, "MASP");
            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", this.dgvSanPham.DataSource, "TENSP");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", this.dgvSanPham.DataSource, "SOLUONG");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", this.dgvSanPham.DataSource, "DONGIA");
            cobMaDanhMuc.DataBindings.Clear();
            cobMaDanhMuc.DataBindings.Add("SelectedValue", this.dgvSanPham.DataSource, "MADANHMUC");
        }

        public void loadComboboxMaDanhMuc()
        {
            SQL = " select TENDANHMUC, MADANHMUC from tbDANHMUC ";
            this.cobMaDanhMuc.DataSource = xuly.bangDuLieu(SQL);
            cobMaDanhMuc.DisplayMember = "TENDANHMUC";
            cobMaDanhMuc.ValueMember = "MADANHMUC";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SQL = " insert into tbSANPHAM (TENSP, SOLUONG, DONGIA, MADANHMUC) values('"
                + txtTenSanPham.Text + "', "
                + txtSoLuong.Text + ", "
                + txtDonGia.Text + ", "
                + cobMaDanhMuc.SelectedValue +")";
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thêm sản phẩm này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xuly.thucThiSQL(SQL))
                {
                    MessageBox.Show("Thêm thành công!");
                    loadDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể thêm sản phẩm");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SQL = " update tbSANPHAM set TENSP = '" + txtTenSanPham.Text + "', "
                + "SOLUONG = " + txtSoLuong.Text + ", "
                + "DONGIA = " + txtDonGia.Text + ", "
                + "MADANHMUC = " + cobMaDanhMuc.SelectedValue 
                + "where MASP = " + txtMaSanPham.Text;
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn sửa sản phẩm này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xuly.thucThiSQL(SQL))
                {
                    MessageBox.Show("Sửa thành công!");
                    loadDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể swa sản phẩm");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SQL = "delete from tbSANPHAM where MASP = " + txtMaSanPham.Text;
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xuly.thucThiSQL(SQL))
                {
                    MessageBox.Show("Xóa thành công!");
                    loadDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể xóa sản phẩm");
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
       
    }
}
