using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace KiemTraWinForm.BusinessLogic
{
    class blLop
    {
        DataAccess.daLopkhoa daLop;
        Form guiLop;

        public blLop(Form f)
        {
            this.guiLop = f;
            daLop = new DataAccess.daLopkhoa();
            hienThi();
        }

        public void hienThi()
        {
            DataGridView grv = (DataGridView)this.guiLop.Controls["dgvLophoc"];
            grv.DataSource = daLop.tableLop();
        }

        public void loadComboBox()
        {
            SQLXULYDULIEU xuly = new SQLXULYDULIEU();
            String SQL;
            SQL = " select tenkhoa, makhoa from TableKhoa ";
            ComboBox cobmakhoa = (ComboBox)this.guiLop.Controls["cobmakhoa"];
            cobmakhoa.DataSource = xuly.bangDuLieu(SQL);
            cobmakhoa.DisplayMember = "tenkhoa";
            cobmakhoa.ValueMember = "makhoa";
        }

        public void themMoiLop()
        {
            TextBox txtmalop = (TextBox)this.guiLop.Controls["txtmalop"];
            ComboBox cobmakhoa = (ComboBox)this.guiLop.Controls["cobmakhoa"];
            TextBox txttenlop = (TextBox)this.guiLop.Controls["txttenlop"];
            TextBox txtsosv = (TextBox)this.guiLop.Controls["txtsosv"];
            DialogResult result = MessageBox.Show("Thong bao", "ban co muon luu khong", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daLop.themLop(txtmalop.Text,cobmakhoa.SelectedItem.ToString(),txttenlop.Text,txtsosv.Text))
                {
                    MessageBox.Show("oke");
                }
            }
        }

        public void xoalop()
        {
            TextBox txtmalop = (TextBox)this.guiLop.Controls["txtmalop"];
            DialogResult result = MessageBox.Show("Thong bao", "ban co muon xoa khong", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daLop.xoaLop(txtmalop.Text))
                {
                    MessageBox.Show("oke");
                }
            }
        }

        public void capNhat()
        {
            TextBox txtmalop = (TextBox)this.guiLop.Controls["txtmalop"];
            TextBox txtmakhoa = (TextBox)this.guiLop.Controls["txtmakhoa"];
            TextBox txttenlop = (TextBox)this.guiLop.Controls["txttenlop"];
            TextBox txtsosv = (TextBox)this.guiLop.Controls["txtsosv"];
            DialogResult result = MessageBox.Show("Thong bao", "ban co muon luu khong", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daLop.suaLop(txtmakhoa.Text, txtmakhoa.Text, txttenlop.Text, txtsosv.Text))
                {
                    MessageBox.Show("oke");
                }
            }
        }
    }
}
