using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QUANLYBANHANG
{
    public partial class frmQUANLYSANPHAM : Form
    {
        SQLXULYDULIEU xulydulieu;
        String SQL;
        private String masanpham;

        public String MASANPHAM
        {
            get { return masanpham; }
            set { masanpham = value; }
        }
        public frmQUANLYSANPHAM()
        {
            InitializeComponent();
        }

        private void frmQUANLYSANPHAM_Load(object sender, EventArgs e)
        {
            xulydulieu = new SQLXULYDULIEU();
            loadGridViewSanPham();
            loadComboBoxDanhMucCha();
            //this.cobDanhMucCha.SelectedValue = this.masanpham;
        }
        public void loadGridViewSanPham()
        {
            try
            {
                SQL = " select * from tbSANPHAM ";
                this.dgvSANPHAM.DataSource = xulydulieu.bangDuLieu(SQL);
                txtMASANPHAM.DataBindings.Clear();
                txtMASANPHAM.DataBindings.Add("Text", this.dgvSANPHAM.DataSource, "MASP");
                txtTENSANPHAM.DataBindings.Clear();
                txtTENSANPHAM.DataBindings.Add("Text", this.dgvSANPHAM.DataSource, "TENSP");
                txtSOLUONG.DataBindings.Clear();
                txtSOLUONG.DataBindings.Add("Text", this.dgvSANPHAM.DataSource, "SOLUONG");
                txtDONGIA.DataBindings.Clear();
                txtDONGIA.DataBindings.Add("Text", this.dgvSANPHAM.DataSource, "DONGIA");
                this.ptbANHSANPHAM.DataBindings.Clear();
                this.ptbANHSANPHAM.DataBindings.Add("Image", this.dgvSANPHAM.DataSource, "HINHANH",true);
                cobDanhMucCha.DataBindings.Clear();
                cobDanhMucCha.DataBindings.Add("SelectedValue", this.dgvSANPHAM.DataSource, "MADANHMUC");
            }
            catch (SqlException ex) { }
        }

        public void loadComboBoxDanhMucCha()
        {
            SQL = " select TENDANHMUC, MADANHMUC from tbDANHMUC";
            cobDanhMucCha.DataSource = xulydulieu.bangDuLieu(SQL);
            cobDanhMucCha.DisplayMember = "TENDANHMUC";
            cobDanhMucCha.ValueMember = "MADANHMUC";
        }
              

      

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            //SQL = " insert into tbSANPHAM (TENSP, SOLUONG, DONGIA, MADANHMUC)"
            //    + " values ("
            //    + "N'" + txtTENSANPHAM.Text + "',"
            //    + this.txtSOLUONG.Text + ","
            //    + this.txtDONGIA.Text + ","
            //    + this.cobDanhMucCha.SelectedValue
            //    + ")";

            byte[] arrayAnh = File.ReadAllBytes(this.ptbANHSANPHAM.ImageLocation);

            
            SqlParameter prTENSANPHAM = new SqlParameter("@TENSP", SqlDbType.NVarChar,200);
            prTENSANPHAM.Value = txtTENSANPHAM.Text;

            SqlParameter prSOLUONG = new SqlParameter("@SOLUONG", SqlDbType.Int);
            prSOLUONG.Value = Convert.ToInt32(txtSOLUONG.Text);

            SqlParameter prDONGIA = new SqlParameter("@DONGIA", SqlDbType.Int);
            prDONGIA.Value = Convert.ToInt32(txtDONGIA.Text);

            SqlParameter prHINHANH = new SqlParameter("@HINHANH", SqlDbType.Image);
            prHINHANH.Value = arrayAnh;

            SqlParameter prMADANHMUC = new SqlParameter("@MADANHMUC", SqlDbType.Int);
            prMADANHMUC.Value = Convert.ToInt16(cobDanhMucCha.SelectedValue);

            SqlParameter[] pr = {prTENSANPHAM, prSOLUONG, prDONGIA, prHINHANH, prMADANHMUC};

            DialogResult result;
            result = MessageBox.Show("Bạn có muốn lưu mẫu tin này không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xulydulieu.thucThiThuTuc("psThemMoiSanPham",pr))
                {
                    MessageBox.Show("Thông tin đã được lưu");
                    loadGridViewSanPham();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            //SQL = " delete from tbSANPHAM where MASP = " + txtMASANPHAM.Text;

            SqlParameter prMASANPHAM = new SqlParameter("@MASP", SqlDbType.NVarChar, 200);
            prMASANPHAM.Value = txtMASANPHAM.Text;

            SqlParameter[] pr = { prMASANPHAM };

            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xulydulieu.thucThiThuTuc("psXoaSanPham",pr))
                {
                    MessageBox.Show("Xóa thành công");
                    loadGridViewSanPham();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            //SQL = " update tbSANPHAM set " + " TENSANPHAM = N'" + txtTENSANPHAM.Text + "',"
            //    + " SOLUONG = " + this.txtSOLUONG.Text + ","
            //    + " DONGIA = " + this.txtDONGIA.Text + ","
            //    + " MADANHMUC = " + this.cobDanhMucCha.SelectedValue
            //    + " where MASP = " + this.txtMASANPHAM.Text;
            byte[] arrayAnh = File.ReadAllBytes(this.ptbANHSANPHAM.ImageLocation);

            SqlParameter prMASANPHAM = new SqlParameter("@MASP", SqlDbType.NVarChar, 200);
            prMASANPHAM.Value = txtMASANPHAM.Text;

            SqlParameter prTENSANPHAM = new SqlParameter("@TENSP", SqlDbType.NVarChar, 200);
            prTENSANPHAM.Value = txtTENSANPHAM.Text;

            SqlParameter prSOLUONG = new SqlParameter("@SOLUONG", SqlDbType.Int);
            prSOLUONG.Value = Convert.ToInt32(txtSOLUONG.Text);

            SqlParameter prDONGIA = new SqlParameter("@DONGIA", SqlDbType.Int);
            prDONGIA.Value = Convert.ToInt32(txtDONGIA.Text);

            SqlParameter prHINHANH = new SqlParameter("@HINHANH", SqlDbType.Image);
            prHINHANH.Value = arrayAnh;

            SqlParameter prMADANHMUC = new SqlParameter("@MADANHMUC", SqlDbType.Int);
            prMADANHMUC.Value = Convert.ToInt16(cobDanhMucCha.SelectedValue);

            SqlParameter[] pr = { prMASANPHAM ,prTENSANPHAM, prSOLUONG, prDONGIA, prHINHANH, prMADANHMUC };
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn sửa mẫu tin này không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xulydulieu.thucThiThuTuc("psSuaSanPham",pr))
                {
                    MessageBox.Show("Thông tin đã được sửa");
                    loadGridViewSanPham();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đóng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

       

        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            //SQL = " select * from tbSANPHAM where MASP = " + this.txtTIMKIEM.Text;
            //this.dgvSANPHAM.DataSource = xulydulieu.bangDuLieu(SQL);
            SqlParameter prMASANPHAM = new SqlParameter("@MASP", SqlDbType.NVarChar, 200);
            prMASANPHAM.Value = txtTIMKIEM.Text;

            SqlParameter[] pr = { prMASANPHAM };

            this.dgvSANPHAM.DataSource = xulydulieu.bangDuLieu("psTimKiemSanPham", pr);
        }

        private void btnSHOW_Click(object sender, EventArgs e)
        {
            loadGridViewSanPham();
        }

        private void ptbANHSANPHAM_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog OFileDlog = new OpenFileDialog();
            OFileDlog.Multiselect = false;
            OFileDlog.Filter = "file image|*.png|*.jpg|*.Bmp";
            DialogResult result = OFileDlog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //this.ptbANHSANPHAM.Image = Image.FromFile(OFileDlog.FileName);
                this.ptbANHSANPHAM.ImageLocation = OFileDlog.FileName;

            }
        }

    }
}
