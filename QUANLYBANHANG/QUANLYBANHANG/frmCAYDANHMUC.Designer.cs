namespace QUANLYBANHANG
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
            this.mitTHEMMOIDANHMUC = new System.Windows.Forms.ToolStripMenuItem();
            this.mitXOADANHMUC = new System.Windows.Forms.ToolStripMenuItem();
            this.mitSUADANHMUC = new System.Windows.Forms.ToolStripMenuItem();
            this.mitTHEMMOISANPHAM = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lvSANPHAM = new System.Windows.Forms.ListView();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvDANHMUC
            // 
            this.trvDANHMUC.ContextMenuStrip = this.contextMenuStrip1;
            this.trvDANHMUC.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvDANHMUC.Location = new System.Drawing.Point(0, 0);
            this.trvDANHMUC.Name = "trvDANHMUC";
            this.trvDANHMUC.Size = new System.Drawing.Size(179, 557);
            this.trvDANHMUC.TabIndex = 0;
            this.trvDANHMUC.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvDANHMUC_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitTHEMMOIDANHMUC,
            this.mitXOADANHMUC,
            this.mitSUADANHMUC,
            this.mitTHEMMOISANPHAM});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 128);
            // 
            // mitTHEMMOIDANHMUC
            // 
            this.mitTHEMMOIDANHMUC.Name = "mitTHEMMOIDANHMUC";
            this.mitTHEMMOIDANHMUC.Size = new System.Drawing.Size(214, 24);
            this.mitTHEMMOIDANHMUC.Text = "Thêm mới danh mục";
            this.mitTHEMMOIDANHMUC.Click += new System.EventHandler(this.mitTHEMMOIDANHMUC_Click);
            // 
            // mitXOADANHMUC
            // 
            this.mitXOADANHMUC.Name = "mitXOADANHMUC";
            this.mitXOADANHMUC.Size = new System.Drawing.Size(214, 24);
            this.mitXOADANHMUC.Text = "Xóa danh mục";
            this.mitXOADANHMUC.Click += new System.EventHandler(this.mitXOADANHMUC_Click);
            // 
            // mitSUADANHMUC
            // 
            this.mitSUADANHMUC.Name = "mitSUADANHMUC";
            this.mitSUADANHMUC.Size = new System.Drawing.Size(214, 24);
            this.mitSUADANHMUC.Text = "Sửa danh mục";
            this.mitSUADANHMUC.Click += new System.EventHandler(this.mitSUADANHMUC_Click);
            // 
            // mitTHEMMOISANPHAM
            // 
            this.mitTHEMMOISANPHAM.Enabled = false;
            this.mitTHEMMOISANPHAM.Name = "mitTHEMMOISANPHAM";
            this.mitTHEMMOISANPHAM.Size = new System.Drawing.Size(214, 24);
            this.mitTHEMMOISANPHAM.Text = "Thêm mới sản phẩm";
            this.mitTHEMMOISANPHAM.Click += new System.EventHandler(this.mitTHEMMOISANPHAM_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(179, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 557);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lvSANPHAM
            // 
            this.lvSANPHAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSANPHAM.Location = new System.Drawing.Point(189, 0);
            this.lvSANPHAM.Name = "lvSANPHAM";
            this.lvSANPHAM.Size = new System.Drawing.Size(499, 557);
            this.lvSANPHAM.TabIndex = 2;
            this.lvSANPHAM.UseCompatibleStateImageBehavior = false;
            // 
            // frmCAYDANHMUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 557);
            this.Controls.Add(this.lvSANPHAM);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.trvDANHMUC);
            this.Name = "frmCAYDANHMUC";
            this.Text = "frmCAYDANHMUC";
            this.Load += new System.EventHandler(this.frmCAYDANHMUC_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvDANHMUC;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView lvSANPHAM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mitTHEMMOIDANHMUC;
        private System.Windows.Forms.ToolStripMenuItem mitXOADANHMUC;
        private System.Windows.Forms.ToolStripMenuItem mitSUADANHMUC;
        private System.Windows.Forms.ToolStripMenuItem mitTHEMMOISANPHAM;
    }
}