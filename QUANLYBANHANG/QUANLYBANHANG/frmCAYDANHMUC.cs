using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG
{
    public partial class frmCAYDANHMUC : Form
    {
        SQLXULYDULIEU xuly;
        String SQL;
        DataTable tbDANHMUC;

        public frmCAYDANHMUC()
        {
            InitializeComponent();
        }

        private void frmCAYDANHMUC_Load(object sender, EventArgs e)
        {
            xuly = new SQLXULYDULIEU();
            loadTreeView();
            loadListView(null);
        }

        public void loadListView(String MaDanhMuc)
        {
            lvSANPHAM.Columns.Clear();
            lvSANPHAM.Items.Clear();
            ColumnHeader clMASP = new ColumnHeader();
            clMASP.Text = "Mã sản phẩm";
            ColumnHeader clTENSP = new ColumnHeader();
            clTENSP.Text = "Tên sản phẩm";
            ColumnHeader clSOLUONG = new ColumnHeader();
            clSOLUONG.Text = "Số lượng";
            ColumnHeader clDONGIA = new ColumnHeader();
            clDONGIA.Text = "Đơn giá";
            ColumnHeader clMADANHMUC = new ColumnHeader();
            clMADANHMUC.Text = "Mã danh mục";
            this.lvSANPHAM.Columns.AddRange(new ColumnHeader[] { clMASP, clTENSP, clSOLUONG, clDONGIA, clMADANHMUC });
            SQL = " select * from tbSANPHAM ";
            if (MaDanhMuc!= null)
                SQL += " where MADANHMUC = " + MaDanhMuc;
            DataTable tbSANPHAM = xuly.bangDuLieu(SQL);
            foreach(DataRow row in tbSANPHAM.Rows){
                ListViewItem itemMASANPHAM = new ListViewItem();
                itemMASANPHAM.Text = row["MASP"].ToString();
                ListViewItem.ListViewSubItem itemTENSANPHAM = new ListViewItem.ListViewSubItem();
                itemTENSANPHAM.Text = row["TENSP"].ToString();
                ListViewItem.ListViewSubItem itemSOLUONG = new ListViewItem.ListViewSubItem();
                itemSOLUONG.Text = row["SOLUONG"].ToString();
                ListViewItem.ListViewSubItem itemDONGIA = new ListViewItem.ListViewSubItem();
                itemDONGIA.Text = row["DONGIA"].ToString();
                ListViewItem.ListViewSubItem itemMADANHMUC = new ListViewItem.ListViewSubItem();
                itemMADANHMUC.Text = row["MADANHMUC"].ToString();
                itemMASANPHAM.SubItems.Add(itemTENSANPHAM);
                itemMASANPHAM.SubItems.Add(itemSOLUONG);
                itemMASANPHAM.SubItems.Add(itemDONGIA);
                itemMASANPHAM.SubItems.Add(itemMADANHMUC);
                lvSANPHAM.Items.Add(itemMASANPHAM);
            }
            lvSANPHAM.View = View.Details;
        }

        public void loadTreeView()
        {
            trvDANHMUC.Nodes.Clear();
            SQL = " select * from tbDANHMUC ";
            tbDANHMUC = xuly.bangDuLieu(SQL);

            tbDANHMUC.DefaultView.RowFilter = "DANHMUCCHA = 0";
            foreach (DataRow row in tbDANHMUC.DefaultView.ToTable().Rows)
            {
                TreeNode NODEPARENT = new TreeNode();
                NODEPARENT.Text = row["TENDANHMUC"].ToString();
                NODEPARENT.Tag = row["MADANHMUC"];
                DeQuyNode(NODEPARENT, row["MADANHMUC"].ToString());
                trvDANHMUC.Nodes.Add(NODEPARENT);
            }
            trvDANHMUC.ExpandAll();
        }

        public void DeQuyNode(TreeNode NodeParent, String MADANHMUCCHA)
        {
            tbDANHMUC.DefaultView.RowFilter = "DANHMUCCHA = " + MADANHMUCCHA;
            foreach (DataRow row in tbDANHMUC.DefaultView.ToTable().Rows)
            {
                TreeNode NodeChil = new TreeNode();
                NodeChil.Text = row["TENDANHMUC"].ToString();
                NodeChil.Tag = row["MADANHMUC"];
                NodeParent.Nodes.Add(NodeChil);
                DeQuyNode(NodeChil, row["MADANHMUC"].ToString());
            }
        }

        private void mitTHEMMOIDANHMUC_Click(object sender, EventArgs e)
        {
            frmQUANLYDANHMUC frmquanlydanhmuc = new frmQUANLYDANHMUC();
            frmquanlydanhmuc.MADANHMUC = trvDANHMUC.SelectedNode.Tag.ToString();
            frmquanlydanhmuc.ShowDialog();
            loadTreeView();
        }

        private void mitXOADANHMUC_Click(object sender, EventArgs e)
        {
            frmQUANLYDANHMUC frmquanlydanhmuc = new frmQUANLYDANHMUC();
            frmquanlydanhmuc.MADANHMUC = trvDANHMUC.SelectedNode.Tag.ToString();
            frmquanlydanhmuc.ShowDialog();
            loadTreeView();
        }

        private void trvDANHMUC_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            loadListView(e.Node.Tag.ToString());
            if (e.Node.Nodes.Count <= 0)
                this.mitTHEMMOISANPHAM.Enabled = true;
            else
                this.mitTHEMMOISANPHAM.Enabled = false;
        }

        private void mitSUADANHMUC_Click(object sender, EventArgs e)
        {
            frmQUANLYDANHMUC frmquanlydanhmuc = new frmQUANLYDANHMUC();
            frmquanlydanhmuc.MADANHMUC = trvDANHMUC.SelectedNode.Tag.ToString();
            frmquanlydanhmuc.ShowDialog();
            loadTreeView();
        }

        private void mitTHEMMOISANPHAM_Click(object sender, EventArgs e)
        {
            frmQUANLYSANPHAM frmquanlysanpham = new frmQUANLYSANPHAM();
            frmquanlysanpham.MASP = trvDANHMUC.SelectedNode.Tag.ToString();
            frmquanlysanpham.ShowDialog();
            loadTreeView();
        }
    }
}
