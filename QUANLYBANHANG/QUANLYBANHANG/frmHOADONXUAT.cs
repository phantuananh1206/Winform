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

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            SqlParameter[] pr = new SqlParameter[4];
            SqlParameter prNGAYXUAT = new SqlParameter("@NGAYXUAT", SqlDbType.DateTime);
            prNGAYXUAT.Value = dtpNGAYXUAT.Value;
            SqlParameter prMAKHACHHANG = new SqlParameter("@MAKHACHHANG", SqlDbType.Int);
            prMAKHACHHANG.Value = cobKHACHHANG.SelectedValue;
            SqlParameter prTONGTIEN = new SqlParameter("@TONGTIEN", SqlDbType.Int);
            prTONGTIEN.Value = txtTONGTIEN.Text;
            SqlParameter prGHICHU = new SqlParameter("@GHICHU", SqlDbType.NVarChar,1000);
            prGHICHU.Value = dtpNGAYXUAT.Value;

            int mahoadon = (int)xulydulieu.thucThiGiaTriDonThuTuc("psThemMoiHoaDon", pr);

            foreach (DataRow row in tbCHITIETHOADON.Rows)
            {
                SQL = "insert into tbCHITIETHOADON Values ()";
                xulydulieu.thucThiGiaTriDon(SQL);
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
                    SQL = " select DONGIA from tbSANPHAM where MASP = " + ((ComboBox)sender).SelectedValue.ToString();
            object DONGIA = xulydulieu.thucThiGiaTriDon(SQL);
            this.dgvCHITIETHOADON.Rows[this.dgvCHITIETHOADON.CurrentRow.Index].Cells[3].Value = DONGIA;
                }
             
            //this.dgvCHITIETHOADON.CurrentRow.Cells[4].Value = DONGIA;
            }
            catch (Exception ex)
            {

            }
        }

        

    }
}
