using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraWinForm.BusinessLogic
{
    class blKhoa
    {
        DataAccess.daKhoalop daKhoa;
        Form guiKhoa;

        public blKhoa(Form f)
        {
            this.guiKhoa = f;
            daKhoa = new DataAccess.daKhoalop();
            hienThi(); 
        }

        public void hienThi()
        {
            DataGridView grv =(DataGridView) this.guiKhoa.Controls["dgvKhoa"];
            grv.DataSource = daKhoa.tableKhoa();
        }

        public void themMoiKhoa()
        {
            TextBox txtmakhoa = (TextBox)this.guiKhoa.Controls["txtmakhoa"];
            TextBox txttenkhoa = (TextBox)this.guiKhoa.Controls["txttenkhoa"];
            DialogResult result = MessageBox.Show("Thong bao", "ban co muon luu khong", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daKhoa.themMoi(txtmakhoa.Text, txttenkhoa.Text))
                {
                    MessageBox.Show("oke");
                }
            }
        }

        public void capNhat()
        {
            TextBox txtmakhoa = (TextBox)this.guiKhoa.Controls["txtmakhoa"];
            TextBox txttenkhoa = (TextBox)this.guiKhoa.Controls["txttenkhoa"];
            DialogResult result = MessageBox.Show("Thong bao", "ban co muon luu khong", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daKhoa.themMoi(txtmakhoa.Text, txttenkhoa.Text))
                {
                    MessageBox.Show("oke");
                }
            }
        }

        public void xoaKhoa()
        {
            TextBox txtmakhoa = (TextBox)this.guiKhoa.Controls["txtmakhoa"];
            DialogResult result = MessageBox.Show("Thong bao", "ban co muon xoa khong", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daKhoa.xoaKhoa(txtmakhoa.Text))
                {
                    MessageBox.Show("oke");
                }
            }
        }
    }
}
