namespace KiemTraWinForm
{
    partial class frmMain
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xửLýKếtQuảHọcTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêBáoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.cậpNhậtToolStripMenuItem,
            this.xửLýKếtQuảHọcTậpToolStripMenuItem,
            this.thốngKêBáoCaoToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(690, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmKhoaToolStripMenuItem,
            this.thêmLớpToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thêmKhoaToolStripMenuItem
            // 
            this.thêmKhoaToolStripMenuItem.Name = "thêmKhoaToolStripMenuItem";
            this.thêmKhoaToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.thêmKhoaToolStripMenuItem.Text = "Thêm khoa";
            this.thêmKhoaToolStripMenuItem.Click += new System.EventHandler(this.thêmKhoaToolStripMenuItem_Click);
            // 
            // thêmLớpToolStripMenuItem
            // 
            this.thêmLớpToolStripMenuItem.Name = "thêmLớpToolStripMenuItem";
            this.thêmLớpToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.thêmLớpToolStripMenuItem.Text = "Thêm lớp";
            this.thêmLớpToolStripMenuItem.Click += new System.EventHandler(this.thêmLớpToolStripMenuItem_Click);
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lớpHọcToolStripMenuItem});
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.lớpHọcToolStripMenuItem.Text = "Lớp học";
            // 
            // xửLýKếtQuảHọcTậpToolStripMenuItem
            // 
            this.xửLýKếtQuảHọcTậpToolStripMenuItem.Name = "xửLýKếtQuảHọcTậpToolStripMenuItem";
            this.xửLýKếtQuảHọcTậpToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.xửLýKếtQuảHọcTậpToolStripMenuItem.Text = "Xử lý kết quả học tập";
            // 
            // thốngKêBáoCaoToolStripMenuItem
            // 
            this.thốngKêBáoCaoToolStripMenuItem.Name = "thốngKêBáoCaoToolStripMenuItem";
            this.thốngKêBáoCaoToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.thốngKêBáoCaoToolStripMenuItem.Text = "Thống kê báo cao";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 414);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quan Ly Sinh Vien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xửLýKếtQuảHọcTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBáoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmLớpToolStripMenuItem;
    }
}

