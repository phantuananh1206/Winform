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
    public partial class frmHOADON : Form
    {
        SQLXULYDULIEU xulydulieu;
        String SQL;
        public frmHOADON()
        {
            InitializeComponent();
        }

        private void frmHOADON_Load(object sender, EventArgs e)
        {
            xulydulieu = new SQLXULYDULIEU();
            loadDataGridView();
            loadComboboxMaKhachHang();
        }

        public void loadDataGridView()
        {
            SQL = " select * from tbHOADON ";
            this.dgvHOADON.DataSource = xulydulieu.bangDuLieu(SQL);
            txtMAHOADON.DataBindings.Clear();
            txtMAHOADON.DataBindings.Add("Text", this.dgvHOADON.DataSource, "MAHOADON");
            txtNGAYXUAT.DataBindings.Clear();
            txtNGAYXUAT.DataBindings.Add("Text", this.dgvHOADON.DataSource, "NGAYXUAT");
            cobMAKHACHHANG.DataBindings.Clear();
            cobMAKHACHHANG.DataBindings.Add("Text", this.dgvHOADON.DataSource, "MAKHACHHANG");
            txtTONGTIEN.DataBindings.Clear();
            txtTONGTIEN.DataBindings.Add("Text", this.dgvHOADON.DataSource, "TONGTIEN");
            txtGHICHU.DataBindings.Clear();
            txtGHICHU.DataBindings.Add("Text", this.dgvHOADON.DataSource, "GHICHU");
        }

        public void loadComboboxMaKhachHang()
        {
            SQL = " select MAKHACHHANG from tbKHACHHANG ";
            this.cobMAKHACHHANG.DataSource = xulydulieu.bangDuLieu(SQL);
            cobMAKHACHHANG.DisplayMember = "MAKHACHHANG";
            cobMAKHACHHANG.ValueMember = "MAKHACHHANG";
        }

        private void btnTHEMMOI_Click(object sender, EventArgs e)
        {
            SQL = " insert into tbHOADON(NGAYXUAT, MAKHACHHANG, TONGTIEN, GHICHU) "
                + "VALUES ('"
                + txtNGAYXUAT.Text + "', "
                + cobMAKHACHHANG.SelectedValue + ", "
                + "'" + txtTONGTIEN.Text + "', "
                + "'" + txtGHICHU.Text +
                "')";
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
            SQL = " update tbHOADON set NGAYXUAT = '" + txtNGAYXUAT.Text + "', "
               + "MAKHACHHANG = " + cobMAKHACHHANG.SelectedValue + ", "
               + "TONGTIEN = '" + txtTONGTIEN.Text + "', "
               + "GHICHU = '" + txtGHICHU.Text + "'  "
               + "where MAHOADON = " + txtMAHOADON.Text;
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
            SQL = " delete from tbHOADON where MAHOADON = " + txtMAHOADON.Text;
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
            SQL = " select * from tbHOADON where MAHOADON = " + txtTIMKIEM.Text;
            this.dgvHOADON.DataSource = xulydulieu.bangDuLieu(SQL);
        }

        private void btnDONG_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Bạn có muốn đóng không?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        
    }
}
