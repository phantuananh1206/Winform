namespace QUANLYBANHANG
{
    partial class frmMAIN
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnTrịHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchhàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnphẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chitiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnTrịHệThốngToolStripMenuItem,
            this.quảnLýNhậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnTrịHệThốngToolStripMenuItem
            // 
            this.quảnTrịHệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin});
            this.quảnTrịHệThốngToolStripMenuItem.Name = "quảnTrịHệThốngToolStripMenuItem";
            this.quảnTrịHệThốngToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.quảnTrịHệThốngToolStripMenuItem.Text = "&Quản trị hệ thống";
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(157, 26);
            this.menuLogin.Text = "Đăng &nhập";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // quảnLýNhậpToolStripMenuItem
            // 
            this.quảnLýNhậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitDanhMuc,
            this.sảnphẩmToolStripMenuItem,
            this.kháchhàngToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.chitiếtToolStripMenuItem});
            this.quảnLýNhậpToolStripMenuItem.Name = "quảnLýNhậpToolStripMenuItem";
            this.quảnLýNhậpToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.quảnLýNhậpToolStripMenuItem.Text = "Quản lý nhập";
            // 
            // menuitDanhMuc
            // 
            this.menuitDanhMuc.Name = "menuitDanhMuc";
            this.menuitDanhMuc.Size = new System.Drawing.Size(181, 26);
            this.menuitDanhMuc.Text = "&Danh mục";
            this.menuitDanhMuc.Click += new System.EventHandler(this.menuitDanhMuc_Click);
            // 
            // kháchhàngToolStripMenuItem
            // 
            this.kháchhàngToolStripMenuItem.Name = "kháchhàngToolStripMenuItem";
            this.kháchhàngToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.kháchhàngToolStripMenuItem.Text = "&Khách hàng";
            this.kháchhàngToolStripMenuItem.Click += new System.EventHandler(this.kháchhàngToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.hóaĐơnToolStripMenuItem.Text = "&Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // sảnphẩmToolStripMenuItem
            // 
            this.sảnphẩmToolStripMenuItem.Name = "sảnphẩmToolStripMenuItem";
            this.sảnphẩmToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.sảnphẩmToolStripMenuItem.Text = "&Sản phẩm";
            this.sảnphẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnphẩmToolStripMenuItem_Click);
            // 
            // chitiếtToolStripMenuItem
            // 
            this.chitiếtToolStripMenuItem.Name = "chitiếtToolStripMenuItem";
            this.chitiếtToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.chitiếtToolStripMenuItem.Text = "&Chi tiết";
            this.chitiếtToolStripMenuItem.Click += new System.EventHandler(this.chitiếtToolStripMenuItem_Click);
            // 
            // frmMAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 382);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnTrịHệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuitDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem kháchhàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnphẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chitiếtToolStripMenuItem;
    }
}