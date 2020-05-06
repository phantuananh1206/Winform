using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS414B_PhanTuanAnh_2321122511_QUANLYNHANSU.Business_Logic
{
    class blHOSO
    {
        Data_Access.daHOSO daHoSo;
        Form guiHoSo;
        SQLXULYDULIEU xuLyDuLieu;
        String SQL;
        public blHOSO(Form f)
        {
            this.guiHoSo = f;
            daHoSo = new Data_Access.daHOSO();
            xuLyDuLieu = new SQLXULYDULIEU();
        }


        void binding_Format(object sender, ConvertEventArgs e)
        {
            if (e.Value.ToString() == "Nam") e.Value = true;
            else e.Value = false;
        }

        void binding_Parse(object sender, ConvertEventArgs e)
        {
            if ((bool)e.Value) e.Value = "Nam";
            else e.Value = "Nữ";
        }

        public void hienThi()
        {
            DataGridView dgvHOSONHANSU = (DataGridView)this.guiHoSo.Controls["dgvHOSONHANSU"];
            dgvHOSONHANSU.DataSource = daHoSo.tableHoSo();
            GroupBox grbHOSO = (GroupBox)this.guiHoSo.Controls["grbTHONGTINCANHAN"];
            TextBox txtMANHANVIEN = (TextBox)grbHOSO.Controls["txtMANHANVIEN"];
            TextBox txtHOTEN = (TextBox)grbHOSO.Controls["txtHOTEN"];
            DateTimePicker dtpNGAYSINH = (DateTimePicker)grbHOSO.Controls["dtpNGAYSINH"];
            CheckBox cbGIOITINH = (CheckBox)grbHOSO.Controls["cbGIOITINH"];
            ComboBox cobPHONGBAN = (ComboBox)grbHOSO.Controls["cobPHONGBAN"];
            PictureBox ptbANHNHANVIEN = (PictureBox)grbHOSO.Controls["ptbANHNHANVIEN"];
            txtMANHANVIEN.DataBindings.Clear();
            txtMANHANVIEN.DataBindings.Add("Text", dgvHOSONHANSU.DataSource, "ma_nhan_vien");
            txtHOTEN.DataBindings.Clear();
            txtHOTEN.DataBindings.Add("Text", dgvHOSONHANSU.DataSource, "ho_ten");
            dtpNGAYSINH.DataBindings.Clear();
            dtpNGAYSINH.DataBindings.Add("Text", dgvHOSONHANSU.DataSource, "ngay_sinh");
            cbGIOITINH.DataBindings.Clear();
            Binding binding = new Binding("Checked", dgvHOSONHANSU.DataSource, "gioi_tinh");
            binding.Format += new ConvertEventHandler(binding_Format);
            binding.Parse += new ConvertEventHandler(binding_Parse);
            cbGIOITINH.DataBindings.Add(binding); 
            cobPHONGBAN.DataBindings.Clear();
            cobPHONGBAN.DataBindings.Add("SelectedValue", dgvHOSONHANSU.DataSource, "ma_phong_ban");
            ptbANHNHANVIEN.DataBindings.Clear();
            ptbANHNHANVIEN.DataBindings.Add("Image", dgvHOSONHANSU.DataSource, "anh_nhan_vien", true);
        }


        public void loadComboBoxPhongBan()
        {
            SQL = " select ma_phong_ban, ten_phong_ban from tbPHONGBAN ";
            GroupBox grbHOSO = (GroupBox)this.guiHoSo.Controls["grbTHONGTINCANHAN"];
            ComboBox cobMAPHONGBAN = (ComboBox)grbHOSO.Controls["cobPHONGBAN"];
            cobMAPHONGBAN.DataSource = xuLyDuLieu.bangDuLieu(SQL);
            cobMAPHONGBAN.DisplayMember = "ten_phong_ban";
            cobMAPHONGBAN.ValueMember = "ma_phong_ban";
        }

        public String cbGioiTinh()
        {
            String gioiTinh;
            GroupBox grbHOSO = (GroupBox)this.guiHoSo.Controls["grbTHONGTINCANHAN"];
            CheckBox cbGIOITINH = (CheckBox)grbHOSO.Controls["cbGIOITINH"];
            if (cbGIOITINH.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            return gioiTinh;
        }

        public void loadAnhNhanVien()
        {
            GroupBox grbHOSO = (GroupBox)this.guiHoSo.Controls["grbTHONGTINCANHAN"];
            PictureBox ptbANHNHANVIEN = (PictureBox)grbHOSO.Controls["ptbANHNHANVIEN"];
            OpenFileDialog oFileDlog = new OpenFileDialog();
            oFileDlog.Multiselect = false;
            oFileDlog.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png | All files (*.*) | *.*";
            DialogResult result = oFileDlog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ptbANHNHANVIEN.ImageLocation = oFileDlog.FileName;
            }
        }

        public void themMoiHoSo()
        {         
            GroupBox grbHOSO = (GroupBox)this.guiHoSo.Controls["grbTHONGTINCANHAN"];
            TextBox txtMANHANVIEN = (TextBox)grbHOSO.Controls["txtMANHANVIEN"];
            TextBox txtHOTEN = (TextBox)grbHOSO.Controls["txtHOTEN"];
            DateTimePicker dtpNGAYSINH = (DateTimePicker)grbHOSO.Controls["dtpNGAYSINH"];
            CheckBox cbGIOITINH = (CheckBox)grbHOSO.Controls["cbGIOITINH"];
            ComboBox cobPHONGBAN = (ComboBox)grbHOSO.Controls["cobPHONGBAN"];
            PictureBox ptbANHNHANVIEN = (PictureBox)grbHOSO.Controls["ptbANHNHANVIEN"];
            byte[] arrayAnh = File.ReadAllBytes(ptbANHNHANVIEN.ImageLocation);
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn lưu mẫu tin này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daHoSo.themHoSo(txtMANHANVIEN.Text, txtHOTEN.Text, dtpNGAYSINH.Value, cbGioiTinh(),
                    cobPHONGBAN.SelectedValue.ToString(), arrayAnh))
                {
                    MessageBox.Show("Lưu thành công!");
                }
                else
                {
                    MessageBox.Show("Mẫu tin này chưa được lưu!");
                }
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            using (var mS = new MemoryStream())
            {
                imageIn.Save(mS, imageIn.RawFormat);
                return mS.ToArray();
            }
        }

        public void suaHoSo()
        {
            GroupBox grbHOSO = (GroupBox)this.guiHoSo.Controls["grbTHONGTINCANHAN"];
            TextBox txtMANHANVIEN = (TextBox)grbHOSO.Controls["txtMANHANVIEN"];
            TextBox txtHOTEN = (TextBox)grbHOSO.Controls["txtHOTEN"];
            DateTimePicker dtpNGAYSINH = (DateTimePicker)grbHOSO.Controls["dtpNGAYSINH"];
            CheckBox cbGIOITINH = (CheckBox)grbHOSO.Controls["cbGIOITINH"];
            ComboBox cobPHONGBAN = (ComboBox)grbHOSO.Controls["cobPHONGBAN"];
            PictureBox ptbANHNHANVIEN = (PictureBox)grbHOSO.Controls["ptbANHNHANVIEN"];
            byte[] arrayAnh = imageToByteArray(ptbANHNHANVIEN.Image);
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn sửa mẫu tin này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daHoSo.suaHoSo(txtMANHANVIEN.Text, txtHOTEN.Text, dtpNGAYSINH.Value, cbGioiTinh(),
                    cobPHONGBAN.SelectedValue.ToString(), arrayAnh))
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Mẫu tin này chưa được sửa!");
                }
            }
        }

        public void xoaHoSo()
        {
            GroupBox grbHOSO = (GroupBox)this.guiHoSo.Controls["grbTHONGTINCANHAN"];
            TextBox txtMANHANVIEN = (TextBox)grbHOSO.Controls["txtMANHANVIEN"];
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xóa mẫu tin này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (daHoSo.xoaHoSo(txtMANHANVIEN.Text))
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Mẫu tin này chưa được xóa!");
                }
            }
        }

        public void timKiemHoSo()
        {
            GroupBox grbHOSO = (GroupBox)this.guiHoSo.Controls["grbTHONGTINCANHAN"];
            TextBox txtMANHANVIEN = (TextBox)grbHOSO.Controls["txtMANHANVIEN"];
            DataGridView dgvHOSONHANSU = (DataGridView)this.guiHoSo.Controls["dgvHOSONHANSU"];
            dgvHOSONHANSU.DataSource = daHoSo.timKiemHoSo(txtMANHANVIEN.Text);             
        }
    }
}
