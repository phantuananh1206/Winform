using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG
{
    public partial class frmKHACHHANG : Form
    {
        SQLXULYDULIEU xulydulieu;
        String SQL;


        public frmKHACHHANG()
        {
            InitializeComponent();
        }

        private void frmKHACHHANG_Load(object sender, EventArgs e)
        {
            xulydulieu = new SQLXULYDULIEU();
            loadDataGridView();
        }

        public void loadDataGridView()
        {
            SQL = " select * from tbKHACHHANG";
            this.dgvKHACHHANG.DataSource = xulydulieu.bangDuLieu(SQL);
            txtMAKHACHHANG.DataBindings.Clear();
            txtMAKHACHHANG.DataBindings.Add("Text", this.dgvKHACHHANG.DataSource, "MAKHACHHANG");
            txtTENKHACHHANG.DataBindings.Clear();
            txtTENKHACHHANG.DataBindings.Add("Text", this.dgvKHACHHANG.DataSource, "TENKHACHHANG");
            txtGIOITINH.DataBindings.Clear();
            txtGIOITINH.DataBindings.Add("Text", this.dgvKHACHHANG.DataSource, "GIOITINH");
            txtDIACHI.DataBindings.Clear();
            txtDIACHI.DataBindings.Add("Text", this.dgvKHACHHANG.DataSource, "DIACHI");
            txtEMAIL.DataBindings.Clear();
            txtEMAIL.DataBindings.Add("Text", this.dgvKHACHHANG.DataSource, "EMAIL");
            txtSODIENTHOAI.DataBindings.Clear();
            txtSODIENTHOAI.DataBindings.Add("Text", this.dgvKHACHHANG.DataSource, "SODIENTHOAI");
        }

        private void btnTHEMMOI_Click(object sender, EventArgs e)
        {
            SQL = " insert into tbKHACHHANG(MAKHACHHANG, TENKHACHHANG, GIOITINH, DIACHI, EMAIL, SODIENTHOAI)"
                + "VALUES (" + txtMAKHACHHANG.Text + ", "
                + "'" + txtTENKHACHHANG.Text + "', "
                + "'" + txtGIOITINH.Text + "', "
                + "'" + txtDIACHI.Text + "', "
                + "'" + txtEMAIL.Text + "', "
                + "'" + txtSODIENTHOAI.Text + "')";
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thêm mẫu tin này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xulydulieu.thucThiSQL(SQL))
                {
                    MessageBox.Show("Thêm thành công!");
                    loadDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể thêm mẫu tin này!");
                }
            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            SQL = " update tbKHACHHANG set TENKHACHHANG = '" + txtTENKHACHHANG.Text + "', "
                + "GIOITINH = '" + txtGIOITINH.Text + "', "
                + "DIACHI = '" + txtDIACHI.Text + "', "
                + "EMAIL = '" + txtEMAIL.Text + "', "
                + "SODIENTHOAI = '" + txtSODIENTHOAI.Text + "' "
                + "where MAKHACHHANG = " + txtMAKHACHHANG.Text;
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn sửa mẫu tin này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xulydulieu.thucThiSQL(SQL))
                {
                    MessageBox.Show("Sửa thành công!");
                    loadDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể sửa mẫu tin này!");
                }
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            SQL = " delete from tbKHACHHANG where MAKHACHHANG = " + txtMAKHACHHANG.Text;
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xóa mẫu tin này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xulydulieu.thucThiSQL(SQL))
                {
                    MessageBox.Show("Xóa thành công!");
                    loadDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể xóa mẫu tin này!");
                }
            }
        }

        private void btnHIENTHI_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            SQL = " select * from tbKHACHHANG where MAKHACHHANG = " + txtTIMKIEM.Text;
            this.dgvKHACHHANG.DataSource = xulydulieu.bangDuLieu(SQL);
        }

        private void btnDONG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

    }
}
