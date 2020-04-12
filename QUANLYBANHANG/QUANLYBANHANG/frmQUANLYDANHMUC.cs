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
    public partial class frmQUANLYDANHMUC : Form
    {
        SQLXULYDULIEU xulydulieu;
        String SQL;
        private String madanhmuc;

        public String MADANHMUC
        {
            get { return madanhmuc; }
            set { madanhmuc = value; }
        }

        public frmQUANLYDANHMUC()
        {
            InitializeComponent();
        }

        private void frmQUANLYDANHMUC_Load(object sender, EventArgs e)
        {
            xulydulieu = new SQLXULYDULIEU();
            loadDataGridViewDanhMuc();
            loadComboBoxDanhMucCha();
            //this.cobDanhMucCha.SelectedValue = this.madanhmuc;
        }

        public void loadDataGridViewDanhMuc()
        {
            SQL = " Select * from tbDANHMUC ";
            this.dgvDANHMUC.DataSource = xulydulieu.bangDuLieu(SQL);
            txtMaDanhMuc.DataBindings.Clear();
            txtMaDanhMuc.DataBindings.Add("Text", this.dgvDANHMUC.DataSource, "MADANHMUC");
            txtTenDanhMuc.DataBindings.Clear();
            txtTenDanhMuc.DataBindings.Add("Text", this.dgvDANHMUC.DataSource, "TENDANHMUC");
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", this.dgvDANHMUC.DataSource, "MOTA");
            this.cobDanhMucCha.DataBindings.Clear();
            this.cobDanhMucCha.DataBindings.Add("SelectedValue", this.dgvDANHMUC.DataSource, "DANHMUCCHA");
         }

        public void loadComboBoxDanhMucCha()
        {
            SQL = " select TENDANHMUC, MADANHMUC from tbDANHMUC";
            cobDanhMucCha.DataSource = xulydulieu.bangDuLieu(SQL);
            cobDanhMucCha.DisplayMember = "TENDANHMUC";
            cobDanhMucCha.ValueMember = "MADANHMUC";
          }

      

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            SQL = " insert into tbDANHMUC(TENDANHMUC, DANHMUCCHA, MOTA)"
                + " VALUES ("
                + "'" + txtTenDanhMuc.Text + "'," + cobDanhMucCha.SelectedValue + ", " + "'" + txtMoTa.Text + "'"
            + ")";
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn lưu mẫu tin này không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xulydulieu.thucThiSQL(SQL))
                {
                    MessageBox.Show("Thông tin đã được lưu");
                    loadDataGridViewDanhMuc();
                     }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {          
                SQL = " delete from tbDANHMUC where MADANHMUC = " +  txtMaDanhMuc.Text ;
                DialogResult result;
                result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xulydulieu.thucThiSQL(SQL))
                    {
                        MessageBox.Show("Xóa thành công");
                        loadDataGridViewDanhMuc();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {          
                SQL = " update tbDANHMUC set TENDANHMUC = " + "'" + txtTenDanhMuc.Text + "'" + ", DANHMUCCHA = "
                    + cobDanhMucCha.SelectedValue + ", MOTA = "
                    + "'" + txtMoTa.Text + "'" + " where MADANHMUC = " + txtMaDanhMuc.Text ;
                DialogResult result;
                result = MessageBox.Show("Bạn có muốn sửa mẫu tin này không?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xulydulieu.thucThiSQL(SQL))
                    {
                        MessageBox.Show("Thông tin đã được sửa");
                        loadDataGridViewDanhMuc();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                   }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SQL = " select * from tbDANHMUC where MADANHMUC = " + txtTimKiem.Text ;    
            this.dgvDANHMUC.DataSource = xulydulieu.bangDuLieu(SQL);
       } 

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đóng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDataGridViewDanhMuc();
        }
    }
}
