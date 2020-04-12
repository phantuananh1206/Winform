using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class frmCAYDANHMUC : Form
    {
        XuLyDuLieu xuly;
        String SQL;
        DataTable tbDANHMUC;
        public frmCAYDANHMUC()
        {
            InitializeComponent();
        }

        private void frmCAYDANHMUC_Load(object sender, EventArgs e)
        {
            xuly = new XuLyDuLieu();
            loadTreeView();
            loadListView(null);
        }

        private void trvDANHMUC_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            loadListView(e.Node.Tag.ToString());
            if (e.Node.Nodes.Count <= 0)
                mitTHEMMOISANPHAM.Enabled = true;
            else
                mitTHEMMOISANPHAM.Enabled = false;
        }

        public void loadListView(String maDanhMuc)
        {
            lvSanPham.Columns.Clear();
            lvSanPham.Items.Clear();
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

            this.lvSanPham.Columns.AddRange(new ColumnHeader[] { clMASP, clTENSP, clSOLUONG, clDONGIA, clMADANHMUC });
            SQL = " select * from tbSANPHAM ";
            if (maDanhMuc != null)
                SQL += " where MADANHMUC = " + maDanhMuc;
            DataTable tbSanPham = xuly.bangDuLieu(SQL);
            foreach (DataRow row in tbSanPham.Rows)
            {
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
                lvSanPham.Items.Add(itemMASANPHAM);
             }
            lvSanPham.View = View.Details;
        }
        public void loadTreeView()
        {
            trvDANHMUC.Nodes.Clear();
            SQL = " select * from tbDANHMUC ";
            tbDANHMUC = xuly.bangDuLieu(SQL);

            tbDANHMUC.DefaultView.RowFilter = "DANHMUCCHA = 0";
            foreach (DataRow row in tbDANHMUC.DefaultView.ToTable().Rows)
            {
                TreeNode nodeParent = new TreeNode();
                nodeParent.Text = row["TENDANHMUC"].ToString();
                nodeParent.Tag = row["MADANHMUC"];
                DeQuyNode(nodeParent, row["MADANHMUC"].ToString());
                trvDANHMUC.Nodes.Add(nodeParent);
            }
            trvDANHMUC.ExpandAll();
        }
        private void thêmMớiDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQUANLYDANHMUC frmquanlydanhmuc = new frmQUANLYDANHMUC();
            frmquanlydanhmuc.MADANHMUC = trvDANHMUC.SelectedNode.Tag.ToString();
            frmquanlydanhmuc.ShowDialog();
            loadTreeView();
        }

        public void DeQuyNode(TreeNode nodeParent, String MADANHMUCCHA)
        {
            tbDANHMUC.DefaultView.RowFilter = "DANHMUCCHA = " + MADANHMUCCHA;
            foreach (DataRow row in tbDANHMUC.DefaultView.ToTable().Rows)
            {
                TreeNode nodeChill = new TreeNode();
                nodeChill.Text = row["TENDANHMUC"].ToString();
                nodeChill.Tag = row["MADANHMUC"];
                nodeParent.Nodes.Add(nodeChill);
                DeQuyNode(nodeChill, row["MADANHMUC"].ToString());
            }

        }

        private void sửaDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQUANLYDANHMUC frmquanlydanhmuc = new frmQUANLYDANHMUC();
            frmquanlydanhmuc.MADANHMUC = trvDANHMUC.SelectedNode.Tag.ToString();
            frmquanlydanhmuc.ShowDialog();
            loadTreeView();
        }

        private void xóaDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQUANLYDANHMUC frmquanlydanhmuc = new frmQUANLYDANHMUC();
            frmquanlydanhmuc.MADANHMUC = trvDANHMUC.SelectedNode.Tag.ToString();
            frmquanlydanhmuc.ShowDialog();
            loadTreeView();
        }

        

        
    }
}
