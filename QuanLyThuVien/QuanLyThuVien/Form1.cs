using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class frmNguoiMuon : Form
    {
        SQLXULYDULIEU xulydulieu;
        String SQL;
        public frmNguoiMuon()
        {
            InitializeComponent();
        }

        private void frmNguoiMuon_Load(object sender, EventArgs e)
        {
            xulydulieu = new SQLXULYDULIEU();
            loadDataGridViewDanhSach();
        }
        public void loadDataGridViewDanhSach()
        {
            SQL = " Select * from BANDOC ";
            this.dgvDanhSach.DataSource = xulydulieu.bangDuLieu(SQL);
            txtMaThe.DataBindings.Clear();
            txtMaThe.DataBindings.Add("Text", this.dgvDanhSach.DataSource, "MATHE");
            txtTenBanDoc.DataBindings.Clear();
            txtTenBanDoc.DataBindings.Add("Text", this.dgvDanhSach.DataSource, "TENBANDOC");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", this.dgvDanhSach.DataSource, "DIACHI");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", this.dgvDanhSach.DataSource, "SODT");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SQL = " insert into BANDOC(MATHE, TENBANDOC, DIACHI, SODT)"
                + " VALUES ("
                + "'" + txtMaThe.Text + "', '" + txtTenBanDoc.Text + "', " + "'" + txtDienThoai.Text + "', "
                + "'" + txtDiaChi.Text +"'"
            + ")";
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn lưu mẫu tin này không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xulydulieu.thucThiSQL(SQL))
                {
                    MessageBox.Show("Thông tin đã được lưu");
                    loadDataGridViewDanhSach();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SQL = " update BANDOC set TENBANDOC = " + "'" + txtTenBanDoc.Text + "'" + ", DIACHI = '"
                    + txtDiaChi.Text + "', SODT = "
                    + "'" + txtDienThoai.Text + "'" + " where MATHE = '" + txtMaThe.Text + "'";
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn sửa mẫu tin này không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xulydulieu.thucThiSQL(SQL))
                {
                    MessageBox.Show("Thông tin đã được sửa");
                    loadDataGridViewDanhSach();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SQL = " delete from BANDOC where MATHE = '" + txtMaThe.Text + "'";
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xulydulieu.thucThiSQL(SQL))
                {
                    MessageBox.Show("Xóa thành công");
                    loadDataGridViewDanhSach();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            loadDataGridViewDanhSach();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL = " select * from BANDOC where MATHE = '" + textBox1.Text + "'";
            this.dgvDanhSach.DataSource = xulydulieu.bangDuLieu(SQL);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đóng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
