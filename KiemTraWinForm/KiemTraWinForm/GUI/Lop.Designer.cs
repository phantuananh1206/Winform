namespace KiemTraWinForm.GUI
{
    partial class frmLop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.txtsosv = new System.Windows.Forms.TextBox();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.cobmakhoa = new System.Windows.Forms.ComboBox();
            this.dgvLophoc = new System.Windows.Forms.DataGridView();
            this.btnDonglop = new System.Windows.Forms.Button();
            this.btnXoalop = new System.Windows.Forms.Button();
            this.btnSualop = new System.Windows.Forms.Button();
            this.btnThemlop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLophoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã khoa";
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(95, 25);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(191, 22);
            this.txtmalop.TabIndex = 4;
            // 
            // txtsosv
            // 
            this.txtsosv.Location = new System.Drawing.Point(441, 92);
            this.txtsosv.Name = "txtsosv";
            this.txtsosv.Size = new System.Drawing.Size(191, 22);
            this.txtsosv.TabIndex = 5;
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(441, 25);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(191, 22);
            this.txttenlop.TabIndex = 6;
            // 
            // cobmakhoa
            // 
            this.cobmakhoa.FormattingEnabled = true;
            this.cobmakhoa.Location = new System.Drawing.Point(95, 90);
            this.cobmakhoa.Name = "cobmakhoa";
            this.cobmakhoa.Size = new System.Drawing.Size(191, 24);
            this.cobmakhoa.TabIndex = 7;
            // 
            // dgvLophoc
            // 
            this.dgvLophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLophoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLophoc.Location = new System.Drawing.Point(0, 232);
            this.dgvLophoc.Name = "dgvLophoc";
            this.dgvLophoc.RowTemplate.Height = 24;
            this.dgvLophoc.Size = new System.Drawing.Size(704, 179);
            this.dgvLophoc.TabIndex = 8;
            // 
            // btnDonglop
            // 
            this.btnDonglop.Location = new System.Drawing.Point(489, 157);
            this.btnDonglop.Name = "btnDonglop";
            this.btnDonglop.Size = new System.Drawing.Size(75, 23);
            this.btnDonglop.TabIndex = 12;
            this.btnDonglop.Text = "Đóng";
            this.btnDonglop.UseVisualStyleBackColor = true;
            this.btnDonglop.Click += new System.EventHandler(this.btnDonglop_Click);
            // 
            // btnXoalop
            // 
            this.btnXoalop.Location = new System.Drawing.Point(357, 157);
            this.btnXoalop.Name = "btnXoalop";
            this.btnXoalop.Size = new System.Drawing.Size(75, 23);
            this.btnXoalop.TabIndex = 11;
            this.btnXoalop.Text = "Xoá";
            this.btnXoalop.UseVisualStyleBackColor = true;
            this.btnXoalop.Click += new System.EventHandler(this.btnXoalop_Click);
            // 
            // btnSualop
            // 
            this.btnSualop.Location = new System.Drawing.Point(235, 157);
            this.btnSualop.Name = "btnSualop";
            this.btnSualop.Size = new System.Drawing.Size(75, 23);
            this.btnSualop.TabIndex = 10;
            this.btnSualop.Text = "Sửa";
            this.btnSualop.UseVisualStyleBackColor = true;
            this.btnSualop.Click += new System.EventHandler(this.btnSualop_Click);
            // 
            // btnThemlop
            // 
            this.btnThemlop.Location = new System.Drawing.Point(113, 157);
            this.btnThemlop.Name = "btnThemlop";
            this.btnThemlop.Size = new System.Drawing.Size(75, 23);
            this.btnThemlop.TabIndex = 9;
            this.btnThemlop.Text = "Thêm";
            this.btnThemlop.UseVisualStyleBackColor = true;
            this.btnThemlop.Click += new System.EventHandler(this.btnThemlop_Click);
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.Controls.Add(this.btnDonglop);
            this.Controls.Add(this.btnXoalop);
            this.Controls.Add(this.btnSualop);
            this.Controls.Add(this.btnThemlop);
            this.Controls.Add(this.dgvLophoc);
            this.Controls.Add(this.cobmakhoa);
            this.Controls.Add(this.txttenlop);
            this.Controls.Add(this.txtsosv);
            this.Controls.Add(this.txtmalop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLop";
            this.Text = "Lop";
            this.Load += new System.EventHandler(this.Lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLophoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.TextBox txtsosv;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.ComboBox cobmakhoa;
        private System.Windows.Forms.DataGridView dgvLophoc;
        private System.Windows.Forms.Button btnDonglop;
        private System.Windows.Forms.Button btnXoalop;
        private System.Windows.Forms.Button btnSualop;
        private System.Windows.Forms.Button btnThemlop;
    }
}