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

namespace QUANLYBANHANG
{
    public partial class frmHOADONXUAT : Form
    {
        SQLXULYDULIEU xulydulieu;
        String SQL;
        String SQL2;
        DataTable tbCHITIETHOADON;
        public frmHOADONXUAT()
        {
            InitializeComponent();
        }

        private void frmHOADONXUAT_Load(object sender, EventArgs e)
        {
            xulydulieu = new SQLXULYDULIEU();
            loadComboboxKhachHang();
            loadComboboxSanPham();
            loadComboboxMaHoaDon();
            CHITIETHOADON();
        }

        public void CHITIETHOADON()
        {
            tbCHITIETHOADON = new DataTable();
            tbCHITIETHOADON.Columns.Add("MACHITIET", typeof(int));
            tbCHITIETHOADON.Columns.Add("MASP", typeof(int));
            tbCHITIETHOADON.Columns.Add("SOLUONG", typeof(double));
            tbCHITIETHOADON.Columns.Add("DONGIA", typeof(double));
            tbCHITIETHOADON.Columns.Add("THANHTIEN", typeof(double), "SOLUONG * DONGIA");
            tbCHITIETHOADON.Columns.Add("MAHOADON", typeof(int));
            //tbCHITIETHOADON.NewRow();
            this.dgvCHITIETHOADON.DataSource = tbCHITIETHOADON;
        }

      
        public void loadComboboxKhachHang()
        {
            SQL = " select MAKHACHHANG, TENKHACHHANG + '-' + SODIENTHOAI as HOTENSDT from tbKHACHHANG ";
            this.cobKHACHHANG.DataSource = xulydulieu.bangDuLieu(SQL);
            cobKHACHHANG.DisplayMember = "HOTENSDT";
            cobKHACHHANG.ValueMember = "MAKHACHHANG";
        }

        public void loadComboboxSanPham()
        {
            SQL = " select MASP, TENSP from tbSANPHAM";

            cobSanPham.DataSource = xulydulieu.bangDuLieu(SQL);
            cobSanPham.DisplayMember = "TENSP";
            cobSanPham.ValueMember = "MASP";
        }

        public void loadComboboxMaHoaDon()
        {
            SQL = " select MAHOADON from tbHOADON";

            cobMAHOADON.DataSource = xulydulieu.bangDuLieu(SQL);
            cobMAHOADON.DisplayMember = "MAHOADON";
            cobMAHOADON.ValueMember = "MAHOADON";
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {

                SqlParameter prGHICHU = new SqlParameter("@GHICHU", SqlDbType.NVarChar, 1000);
                prGHICHU.Value = txtGHICHU.Text;
                SqlParameter prNGAYXUAT = new SqlParameter("@NGAYXUAT", SqlDbType.DateTime);
                prNGAYXUAT.Value = dtpNGAYXUAT.Value;
                SqlParameter prMAKHACHHANG = new SqlParameter("@MAKHACHHANG", SqlDbType.Int);
                prMAKHACHHANG.Value = cobKHACHHANG.SelectedValue;
                SqlParameter prTONGTIEN = new SqlParameter("@TONGTIEN", SqlDbType.Int);
                prTONGTIEN.Value = txtTONGTIEN.Text;

                SqlParameter[] pr = { prNGAYXUAT, prMAKHACHHANG, prTONGTIEN, prGHICHU };

                DialogResult result;
                result = MessageBox.Show("Bạn có muốn lưu mẫu tin này không?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xulydulieu.thucThiThuTuc("psThemMoiHoaDon", pr))
                    {
                        MessageBox.Show("Thông tin đã được lưu");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }

                foreach (DataRow row in tbCHITIETHOADON.Rows)
                {
                    SqlParameter prGHICHU2 = new SqlParameter("@GHICHU", SqlDbType.NVarChar, 1000);
                    prGHICHU2.Value = txtGHICHU.Text;
                    SqlParameter prMASP = new SqlParameter("@MASP", SqlDbType.Int);
                    prMASP.Value = row["MASP"].ToString();
                    SqlParameter prSOLUONG = new SqlParameter("@SOLUONG", SqlDbType.Int);
                    prSOLUONG.Value = row["SOLUONG"].ToString();
                    SqlParameter prDONGIA = new SqlParameter("@DONGIA", SqlDbType.Int);
                    prDONGIA.Value = row["DONGIA"].ToString();
                    SqlParameter prMAHOADON = new SqlParameter("@MAHOADON", SqlDbType.Int);
                    prMAHOADON.Value = row["MAHOADON"].ToString();
                    SqlParameter[] pr2 = { prMASP, prSOLUONG, prDONGIA, prGHICHU2, prMAHOADON };

                    DialogResult result2;
                    result2 = MessageBox.Show("Bạn có muốn lưu mẫu tin này không?", "Thông báo", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result2 == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (xulydulieu.thucThiThuTuc("psThemMoiChiTiet", pr2))
                        {
                            MessageBox.Show("Thông tin đã được lưu");
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                    }
                }
        }

        private void dgvCHITIETHOADON_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox cob = e.Control as ComboBox;
            if (cob != null)
            {
                cob.SelectedIndexChanged -= new EventHandler(cobSanPham_SelectedIndexChanged);
                cob.SelectedIndexChanged += new EventHandler(cobSanPham_SelectedIndexChanged);
            }
        }

        private void cobSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                ComboBox cob = sender as ComboBox;
                if (cob != null && cob.SelectedValue != null)
                {
                    SQL = "select * from tbSANPHAM where masp = " + ((ComboBox)sender).SelectedValue.ToString();

                    DataTable dttb = xulydulieu.bangDuLieu(SQL);
                    foreach (DataRow row in dttb.Rows)
                    {
                        this.dgvCHITIETHOADON.CurrentRow.Cells[3].Value = row["DONGIA"].ToString();
                    }
                    //SQL = " select DONGIA from tbSANPHAM where MASP = " + ((ComboBox)sender).SelectedValue.ToString();
                    //object DONGIA = xulydulieu.thucThiGiaTriDon(SQL);
                    //this.dgvCHITIETHOADON.Rows[this.dgvCHITIETHOADON.CurrentRow.Index].Cells[3].Value = DONGIA;
                }
             
            //this.dgvCHITIETHOADON.CurrentRow.Cells[4].Value = DONGIA;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            SqlParameter prMAHOADON = new SqlParameter("@MAHOADON", SqlDbType.Int);
            prMAHOADON.Value = txtMAHOADON.Text;
            SqlParameter prGHICHU = new SqlParameter("@GHICHU", SqlDbType.NVarChar, 1000);
            prGHICHU.Value = txtGHICHU.Text;
            SqlParameter prNGAYXUAT = new SqlParameter("@NGAYXUAT", SqlDbType.DateTime);
            prNGAYXUAT.Value = dtpNGAYXUAT.Value;
            SqlParameter prMAKHACHHANG = new SqlParameter("@MAKHACHHANG", SqlDbType.Int);
            prMAKHACHHANG.Value = cobKHACHHANG.SelectedValue;
            SqlParameter prTONGTIEN = new SqlParameter("@TONGTIEN", SqlDbType.Int);
            prTONGTIEN.Value = txtTONGTIEN.Text;

            SqlParameter[] pr = { prMAHOADON, prNGAYXUAT, prMAKHACHHANG, prTONGTIEN, prGHICHU };

            DialogResult result;
            result = MessageBox.Show("Bạn có muốn sửa mẫu tin này không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xulydulieu.thucThiThuTuc("psSuaHoaDon", pr))
                {
                    MessageBox.Show("Thông tin đã được lưu");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }

            foreach (DataRow row in tbCHITIETHOADON.Rows)
            {
                SqlParameter prMACHITIET = new SqlParameter("@MACHITIET", SqlDbType.Int);
                prMACHITIET.Value = row["MACHITIET"].ToString();
                SqlParameter prGHICHU2 = new SqlParameter("@GHICHU", SqlDbType.NVarChar, 1000);
                prGHICHU2.Value = txtGHICHU.Text;
                SqlParameter prMASP = new SqlParameter("@MASP", SqlDbType.Int);
                prMASP.Value = row["MASP"].ToString();
                SqlParameter prSOLUONG = new SqlParameter("@SOLUONG", SqlDbType.Int);
                prSOLUONG.Value = row["SOLUONG"].ToString();
                SqlParameter prDONGIA = new SqlParameter("@DONGIA", SqlDbType.Int);
                prDONGIA.Value = row["DONGIA"].ToString();
                SqlParameter prMAHOADON2 = new SqlParameter("@MAHOADON", SqlDbType.Int);
                prMAHOADON2.Value = row["MAHOADON"].ToString();
                SqlParameter[] pr2 = { prMACHITIET, prMASP, prSOLUONG, prDONGIA, prGHICHU2, prMAHOADON2 };

                DialogResult result2;
                result2 = MessageBox.Show("Bạn có muốn sửa mẫu tin này không?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result2 == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xulydulieu.thucThiThuTuc("psSuaChiTiet", pr2))
                    {
                        MessageBox.Show("Thông tin đã được lưu");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            SqlParameter prMAHOADON = new SqlParameter("@MAHOADON", SqlDbType.Int);
            prMAHOADON.Value = txtMAHOADON.Text;
            SqlParameter[] pr = { prMAHOADON };
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xóa mẫu tin này không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (xulydulieu.thucThiThuTuc("psXoaHoaDon", pr))
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }

            foreach (DataRow row in tbCHITIETHOADON.Rows)
            {
                SqlParameter prMACHITIET = new SqlParameter("@MACHITIET", SqlDbType.Int);
                prMACHITIET.Value = row["MACHITIET"].ToString();
                SqlParameter[] pr2 = { prMACHITIET };
                DialogResult result2;
                result2 = MessageBox.Show("Bạn có muốn xóa mẫu tin này không?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result2 == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xulydulieu.thucThiThuTuc("psXoaChiTiet", pr2))
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
        }

        private void btnDONG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đóng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        

    }
}
