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
    public partial class frmCHITIET : Form
    {
        SQLXULYDULIEU xulydulieu;
        String SQL;
        public frmCHITIET()
        {
            InitializeComponent();
        }

        private void frmCHITIET_Load(object sender, EventArgs e)
        {
            xulydulieu = new SQLXULYDULIEU();
            loadDataGridView();
            loadComboboxMASP();
            loadComboboxMAHOADON();
        }

        public void loadDataGridView()
        {
            SQL = " select * from tbCHITIET ";
            this.dgvCHITIET.DataSource = xulydulieu.bangDuLieu(SQL);
            txtMACHITIET.DataBindings.Clear();
            txtMACHITIET.DataBindings.Add("Text", this.dgvCHITIET.DataSource, "MACHITIET");
            cobMASANPHAM.DataBindings.Clear();
            cobMASANPHAM.DataBindings.Add("Text", this.dgvCHITIET.DataSource, "MASP");
            txtSOLUONG.DataBindings.Clear();
            txtSOLUONG.DataBindings.Add("Text", this.dgvCHITIET.DataSource, "SOLUONG");
            txtDONGIA.DataBindings.Clear();
            txtDONGIA.DataBindings.Add("Text", this.dgvCHITIET.DataSource, "DONGIA");
            txtGHICHU.DataBindings.Clear();
            txtGHICHU.DataBindings.Add("Text", this.dgvCHITIET.DataSource, "GHICHU");
            cobMAHOADON.DataBindings.Clear();
            cobMAHOADON.DataBindings.Add("Text", this.dgvCHITIET.DataSource, "MAHOADON");
        }

        public void loadComboboxMASP()
        {
            SQL = " select MASP from tbSANPHAM ";
            this.cobMASANPHAM.DataSource = xulydulieu.bangDuLieu(SQL);
            cobMASANPHAM.DisplayMember = "MASP";
            cobMASANPHAM.ValueMember = "MASP";
        }

        public void loadComboboxMAHOADON()
        {
            SQL = " select MAHOADON from tbHOADON ";
            this.cobMAHOADON.DataSource = xulydulieu.bangDuLieu(SQL);
            cobMAHOADON.DisplayMember = "MAHOADON";
            cobMAHOADON.ValueMember = "MAHOADON";
        }
        
        private void btnTHEMMOI_Click(object sender, EventArgs e)
        {
            SQL = " insert into tbCHITIET(MASP, SOLUONG, DONGIA, GHICHU, MAHOADON) "
                + "VALUES ("
                + cobMASANPHAM.SelectedValue + ", "
                + "'" + txtSOLUONG.Text + "', "
                + "'" + txtDONGIA.Text + "', "
                + "'" + txtGHICHU.Text + "', "
                + cobMAHOADON.Text + ")";
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
            SQL = " update tbCHITIET set MASP = " + cobMASANPHAM.SelectedValue + ", "
               + "SOLUONG = '" + txtSOLUONG.Text + "', "
               + "DONGIA = '" + txtDONGIA.Text + "', "
               + "GHICHU = '" + txtGHICHU.Text + "', "
               + "MAHOADON = " + cobMAHOADON.SelectedValue
               + "where MACHITIET = " + txtMACHITIET.Text;
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
            SQL = " delete from tbCHITIET where MACHITIET = " + txtMACHITIET.Text;
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
            SQL = " select * from tbCHITIET where MACHITIET = " + txtTIMKIEM.Text;
            this.dgvCHITIET.DataSource = xulydulieu.bangDuLieu(SQL);
           
        }

        private void btnDONG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không?", "Thông báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        
    }
}
