using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS414B_PhanTuanAnh_2321122511_QUANLYSINHVIEN.Business_Logic
{
    class blKHOA
    {
         Data_Access.daKHOA daKhoa;
        Form guiKhoa;

        public blKHOA(Form f)
        {
            this.guiKhoa = f;
            daKhoa = new Data_Access.daKHOA();
            hienThi(); 
        }

        public void hienThi()
        {
            GroupBox GB = (GroupBox)this.guiKhoa.Controls["grbCHITIETKHOA"];
            DataGridView grv = (DataGridView)GB.Controls["dgvKHOA"];
            grv.DataSource = daKhoa.tableKhoa();
        }

        public void themMoiKhoa()
        {
            GroupBox GB = (GroupBox)this.guiKhoa.Controls["grbTHONGTINKHOA"];
            TextBox txtMAKHOA = (TextBox)GB.Controls["txtMAKHOA"];
            TextBox txtTENKHOA = (TextBox)GB.Controls["txtTENKHOA"];
            DialogResult result = MessageBox.Show("Bạn có muốn lưu mẫu tin này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daKhoa.themMoiKhoa(txtMAKHOA.Text, txtTENKHOA.Text))
                {
                    MessageBox.Show("Lưu thành công!");
                }
                else
                {
                    MessageBox.Show("Mẫu tin này chưa được lưu!");
                }
            }
        }

        public void capNhatKhoa()
        {
            GroupBox GB = (GroupBox)this.guiKhoa.Controls["grbTHONGTINKHOA"];
            TextBox txtMAKHOA = (TextBox)GB.Controls["txtMAKHOA"];
            TextBox txtTENKHOA = (TextBox)GB.Controls["txtTENKHOA"];
            DialogResult result = MessageBox.Show("Bạn có muốn sửa mẫu tin này không?","Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daKhoa.capNhatKhoa(txtMAKHOA.Text, txtTENKHOA.Text))
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Mẫu tin này chưa được sửa!");
                }
            }
        }

        public void xoaKhoa()
        {
            GroupBox GB = (GroupBox)this.guiKhoa.Controls["grbTHONGTINKHOA"];
            TextBox txtMAKHOA = (TextBox)GB.Controls["txtMAKHOA"];
            DialogResult result = MessageBox.Show("Bạn có muốn xóa mẫu tin này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                daKhoa.xoaKhoa(txtMAKHOA.Text);
                //if (daKhoa.xoaKhoa(txtmakhoa.Text))
                //{
                //    MessageBox.Show("Xóa thành công!");
                //}
                //else
                //{
                //    MessageBox.Show("Mẫu tin này chưa được xóa!");
                //}
            }
        }

        public void timKiemKhoa()
        {
            GroupBox GB = (GroupBox)this.guiKhoa.Controls["grbCHITIETKHOA"];
            GroupBox GB2 = (GroupBox)this.guiKhoa.Controls["grbTHONGTINKHOA"];
            TextBox txtTIMKIEM = (TextBox)GB2.Controls["txtTIMKIEM"];
            DataGridView grv = (DataGridView)GB.Controls["dgvKHOA"];
            grv.DataSource = daKhoa.timKiemKhoa(txtTIMKIEM.Text);
        }

    }
}
