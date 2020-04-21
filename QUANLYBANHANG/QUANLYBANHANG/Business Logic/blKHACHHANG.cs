    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG.Business_Logic
{
    class blKHACHHANG
    {
        Data_Access.daKHACHHANG daKHACHHANG;
        Form guiKHACHHANG;

        public blKHACHHANG(Form f)
        {
            this.guiKHACHHANG = f;
            daKHACHHANG = new Data_Access.daKHACHHANG();
            hienthi();
        }

        public void hienthi()
        {
            DataGridView grv =  (DataGridView) this.guiKHACHHANG.Controls["dgvKHACHHANG"];
            grv.DataSource = daKHACHHANG.tableKHACHHANG();
        }   

        public void themMoi()
        {
            TextBox txtTENKHACHHANG = (TextBox)this.guiKHACHHANG.Controls["txtHOTEN"];
            TextBox txtGioiTinh = (TextBox)this.guiKHACHHANG.Controls["txtGIOITINH"];
            DialogResult result = MessageBox.Show("Thông báo", "Bạn có lưu thông tin này không?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daKHACHHANG.themMoi(txtTENKHACHHANG.Text, txtGioiTinh.Text))
                    MessageBox.Show("Đã lưu thông tin");
            }
        }
    }
}
