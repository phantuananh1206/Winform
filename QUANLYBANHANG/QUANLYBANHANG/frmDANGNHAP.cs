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
using System.Data;

namespace QUANLYBANHANG
{
    public partial class frmDANGNHAP : Form
    {
        //SqlConnection CON;
        SQLXULYDULIEU xulydulieu;
        public frmDANGNHAP()
        {
            InitializeComponent();
        }

        private void frmDANGNHAP_Load(object sender, EventArgs e)
        {
            //CON = new SqlConnection();
            //CON.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Winform\QUANLYBANHANG\QUANLYBANHANG\DATA\dbQUANLYBANHANG.mdf;Integrated Security=True";
            //CON.Open();

            //CON.Close();
            xulydulieu = new SQLXULYDULIEU();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this.CON.Open();

            String SQL = "select count(*) from tbLOGIN where "
                    + " TENDANGNHAP ='" + this.txtUser.Text + "'"
                    + " AND"
                    + " MATKHAU = '" +this.txtPassWord.Text + "'";
            //SqlCommand cmd = new SqlCommand(SQL, this.CON);
            //int ketqua = (int) cmd.ExecuteScalar();
            int ketqua = (int) xulydulieu.thucThiGiaTriDon(SQL);
            if (ketqua > 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
            //this.CON.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                
            }
        }

        
    }
}
