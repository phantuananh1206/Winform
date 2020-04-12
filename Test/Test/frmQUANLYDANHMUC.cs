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
    public partial class frmQUANLYDANHMUC : Form
    {
        XuLyDuLieu xuly;
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

        public void loadDataGridView()
        {
            SQL = " select * from tbDANHMUC ";
            this.dgvDanhMuc.DataSource = xuly.bangDuLieu(SQL);
            txtMaDanhMuc.DataBindings.Clear();
            txtMaDanhMuc.DataBindings.Add("Text", this.dgvDanhMuc.DataSource, "MADANHMUC");
            txtTenDanhMuc.DataBindings.Clear();
            txtTenDanhMuc.DataBindings.Add("Text", this.dgvDanhMuc.DataSource, "TENDANHMUC");
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", this.dgvDanhMuc.DataSource, "MOTA");
            cobDanhMucCha.DataBindings.Clear();
            cobDanhMucCha.DataBindings.Add("SelectedValue", this.dgvDanhMuc.DataSource, "DANHMUCCHA");
        }

        public void loadComboboxDanhMucCha()
        {
            SQL = " select MADANHMUC , TENDANHMUC from tbDANHMUC ";
            cobDanhMucCha.DataSource = xuly.bangDuLieu(SQL);
            cobDanhMucCha.DisplayMember = "TENDANHMUC";
            cobDanhMucCha.ValueMember = "MADANHMUC";
        }


        private void frmQUANLYDANHMUC_Load(object sender, EventArgs e)
        {
            xuly = new XuLyDuLieu();
            loadDataGridView();
            loadComboboxDanhMucCha();
            this.cobDanhMucCha.SelectedValue = madanhmuc;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SQL = " insert into tbDANHMUC (TENDANHMUC,  DANHMUCCHA, MOTA) values('"
                + txtTenDanhMuc.Text + "', "
                + cobDanhMucCha.SelectedValue + ", '"
                + txtMoTa.Text + "')";
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xuly.thucThiSQL(SQL))
                {
                    MessageBox.Show("Thêm thành công");
                    loadDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể thêm dữ liệu");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SQL = " update tbDANHMUC set TENDANHMUC = '" + txtTenDanhMuc.Text + "', DANHMUCCHA = "
                + cobDanhMucCha.SelectedValue + ", MOTA = '"
                + txtMoTa.Text + "' where  MADANHMUC = '"
                + txtMaDanhMuc.Text + "'";
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xuly.thucThiSQL(SQL))
                {
                    MessageBox.Show("Sửa thành công");
                    loadDataGridView();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SQL = " delete from tbDANHMUC where MADANHMUC = '" + txtMaDanhMuc.Text + "'";
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xuly.thucThiSQL(SQL))
                {
                    MessageBox.Show("Xóa thành công");
                    loadDataGridView();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn đóng không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                     this.Close();
     }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SQL = " select * from tbDANHMUC where MADANHMUC = '" + txtMaTimKiem.Text + "'";
            this.dgvDanhMuc.DataSource = xuly.bangDuLieu(SQL);
        }

        
    }
}
