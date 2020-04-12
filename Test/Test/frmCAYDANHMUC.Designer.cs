namespace Test
{
    partial class frmCAYDANHMUC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trvDANHMUC = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmMớiDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitTHEMMOISANPHAM = new System.Windows.Forms.ToolStripMenuItem();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvDANHMUC
            // 
            this.trvDANHMUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvDANHMUC.ContextMenuStrip = this.contextMenuStrip1;
            this.trvDANHMUC.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvDANHMUC.Location = new System.Drawing.Point(0, 0);
            this.trvDANHMUC.Name = "trvDANHMUC";
            this.trvDANHMUC.Size = new System.Drawing.Size(260, 524);
            this.trvDANHMUC.TabIndex = 0;
            this.trvDANHMUC.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvDANHMUC_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớiDanhMụcToolStripMenuItem,
            this.sửaDanhMụcToolStripMenuItem,
            this.xóaDanhMụcToolStripMenuItem,
            this.mitTHEMMOISANPHAM});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 128);
            // 
            // thêmMớiDanhMụcToolStripMenuItem
            // 
            this.thêmMớiDanhMụcToolStripMenuItem.Name = "thêmMớiDanhMụcToolStripMenuItem";
            this.thêmMớiDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.thêmMớiDanhMụcToolStripMenuItem.Text = "Thêm mới danh mục";
            this.thêmMớiDanhMụcToolStripMenuItem.Click += new System.EventHandler(this.thêmMớiDanhMụcToolStripMenuItem_Click);
            // 
            // sửaDanhMụcToolStripMenuItem
            // 
            this.sửaDanhMụcToolStripMenuItem.Name = "sửaDanhMụcToolStripMenuItem";
            this.sửaDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.sửaDanhMụcToolStripMenuItem.Text = "Sửa danh mục";
            this.sửaDanhMụcToolStripMenuItem.Click += new System.EventHandler(this.sửaDanhMụcToolStripMenuItem_Click);
            // 
            // xóaDanhMụcToolStripMenuItem
            // 
            this.xóaDanhMụcToolStripMenuItem.Name = "xóaDanhMụcToolStripMenuItem";
            this.xóaDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.xóaDanhMụcToolStripMenuItem.Text = "Xóa danh mục";
            this.xóaDanhMụcToolStripMenuItem.Click += new System.EventHandler(this.xóaDanhMụcToolStripMenuItem_Click);
            // 
            // mitTHEMMOISANPHAM
            // 
            this.mitTHEMMOISANPHAM.Enabled = false;
            this.mitTHEMMOISANPHAM.Name = "mitTHEMMOISANPHAM";
            this.mitTHEMMOISANPHAM.Size = new System.Drawing.Size(214, 24);
            this.mitTHEMMOISANPHAM.Text = "Thêm mới sản phẩm";
            // 
            // lvSanPham
            // 
            this.lvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSanPham.Location = new System.Drawing.Point(260, 0);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(628, 524);
            this.lvSanPham.TabIndex = 1;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            // 
            // frmCAYDANHMUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 524);
            this.Controls.Add(this.lvSanPham);
            this.Controls.Add(this.trvDANHMUC);
            this.Name = "frmCAYDANHMUC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCAYDANHMUC";
            this.Load += new System.EventHandler(this.frmCAYDANHMUC_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvDANHMUC;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitTHEMMOISANPHAM;
    }
}