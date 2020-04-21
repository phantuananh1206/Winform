using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS414B_PhanTuanAnh_2321122511_QUANLYSINHVIEN.Business_Logic
{
    class blLOPHOC
    {
        Data_Access.daLOPHOC daLopHoc;
        Form guiLopHoc;
        Data_Access.SQLXULYDULIEU xulydulieu;
        String SQL;

        public blLOPHOC(Form f)
        {
            this.guiLopHoc = f;
            daLopHoc = new Data_Access.daLOPHOC();
            xulydulieu = new Data_Access.SQLXULYDULIEU();
        }

        public void hienThi()
        {
            DataGridView grv = (DataGridView)this.guiLopHoc.Controls["dgvLOPHOC"];
            grv.DataSource = daLopHoc.tableLopHoc();
        }

        public void loadComboboxKhoa()
        {      
            SQL = " select MAKHOA, TENKHOA from tbKHOA ";
            ComboBox cobmakhoa = (ComboBox)this.guiLopHoc.Controls["cobKHOA"];
            cobmakhoa.DataSource = xulydulieu.bangDuLieu(SQL);
            cobmakhoa.DisplayMember = "TENKHOA";
            cobmakhoa.ValueMember = "MAKHOA";
        }

        public void themMoiLopHoc()
        {
            TextBox txtMALOP = (TextBox)this.guiLopHoc.Controls["txtMALOP"];
            ComboBox cobKHOA = (ComboBox)this.guiLopHoc.Controls["cobKHOA"];
            TextBox txtTENLOP = (TextBox)this.guiLopHoc.Controls["txtTENLOP"];
            TextBox txtSOSINHVIEN = (TextBox)this.guiLopHoc.Controls["txtSOSINHVIEN"];
            DialogResult result = MessageBox.Show("Bạn có muốn lưu mẫu tin này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daLopHoc.themMoiLopHoc(txtMALOP.Text, cobKHOA.SelectedValue.ToString(), txtTENLOP.Text, Convert.ToInt32(txtSOSINHVIEN.Text)))
                {
                    MessageBox.Show("Lưu thành công!");
                }
                else
                {
                    MessageBox.Show("Mẫu tin này chưa được lưu!");
                }
            }
        }
        public void capNhatLopHoc()
        {
            TextBox txtMALOP = (TextBox)this.guiLopHoc.Controls["txtMALOP"];
            ComboBox cobKHOA = (ComboBox)this.guiLopHoc.Controls["cobKHOA"];
            TextBox txtTENLOP = (TextBox)this.guiLopHoc.Controls["txtTENLOP"];
            TextBox txtSOSINHVIEN = (TextBox)this.guiLopHoc.Controls["txtSOSINHVIEN"];
            DialogResult result = MessageBox.Show("Bạn có muốn sửa mẫu tin này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daLopHoc.capNhatLopHoc(txtMALOP.Text, cobKHOA.SelectedValue.ToString(), txtTENLOP.Text, Convert.ToInt32(txtSOSINHVIEN.Text)))
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Mẫu tin này chưa được sửa!");
                }
            }
        }

        public void xoaLopHoc()
        {
            TextBox txtMALOP = (TextBox)this.guiLopHoc.Controls["txtMALOP"];
            DialogResult result = MessageBox.Show("Bạn có muốn xóa mẫu tin này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daLopHoc.xoaLopHoc(txtMALOP.Text))
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Mẫu tin này chưa được xóa!");
                }
            }
        }

        public void timKiemLopHoc()
        {
            TextBox txtTIMKIEM = (TextBox)this.guiLopHoc.Controls["txtTIMKIEM"];
            DataGridView grv = (DataGridView)this.guiLopHoc.Controls["dgvLOPHOC"];
            grv.DataSource = daLopHoc.timKiemLopHoc(txtTIMKIEM.Text);
        }
    }
}
