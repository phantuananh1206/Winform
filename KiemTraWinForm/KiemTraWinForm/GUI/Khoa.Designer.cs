namespace KiemTraWinForm.GUI
{
    partial class frmKhoa
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
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.txttenkhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.btnThemkhoa = new System.Windows.Forms.Button();
            this.btnSuakhoa = new System.Windows.Forms.Button();
            this.btnXoakhoa = new System.Windows.Forms.Button();
            this.btnDongkhoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa";
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(263, 58);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(171, 22);
            this.txtmakhoa.TabIndex = 1;
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.Location = new System.Drawing.Point(263, 106);
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Size = new System.Drawing.Size(171, 22);
            this.txttenkhoa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khoa";
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhoa.Location = new System.Drawing.Point(0, 225);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.RowTemplate.Height = 24;
            this.dgvKhoa.Size = new System.Drawing.Size(682, 150);
            this.dgvKhoa.TabIndex = 4;
            // 
            // btnThemkhoa
            // 
            this.btnThemkhoa.Location = new System.Drawing.Point(141, 174);
            this.btnThemkhoa.Name = "btnThemkhoa";
            this.btnThemkhoa.Size = new System.Drawing.Size(75, 23);
            this.btnThemkhoa.TabIndex = 5;
            this.btnThemkhoa.Text = "Thêm";
            this.btnThemkhoa.UseVisualStyleBackColor = true;
            this.btnThemkhoa.Click += new System.EventHandler(this.btnThemkhoa_Click);
            // 
            // btnSuakhoa
            // 
            this.btnSuakhoa.Location = new System.Drawing.Point(263, 174);
            this.btnSuakhoa.Name = "btnSuakhoa";
            this.btnSuakhoa.Size = new System.Drawing.Size(75, 23);
            this.btnSuakhoa.TabIndex = 6;
            this.btnSuakhoa.Text = "Sửa";
            this.btnSuakhoa.UseVisualStyleBackColor = true;
            this.btnSuakhoa.Click += new System.EventHandler(this.btnSuakhoa_Click);
            // 
            // btnXoakhoa
            // 
            this.btnXoakhoa.Location = new System.Drawing.Point(385, 174);
            this.btnXoakhoa.Name = "btnXoakhoa";
            this.btnXoakhoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoakhoa.TabIndex = 7;
            this.btnXoakhoa.Text = "Xoá";
            this.btnXoakhoa.UseVisualStyleBackColor = true;
            this.btnXoakhoa.Click += new System.EventHandler(this.btnXoakhoa_Click);
            // 
            // btnDongkhoa
            // 
            this.btnDongkhoa.Location = new System.Drawing.Point(517, 174);
            this.btnDongkhoa.Name = "btnDongkhoa";
            this.btnDongkhoa.Size = new System.Drawing.Size(75, 23);
            this.btnDongkhoa.TabIndex = 8;
            this.btnDongkhoa.Text = "Đóng";
            this.btnDongkhoa.UseVisualStyleBackColor = true;
            this.btnDongkhoa.Click += new System.EventHandler(this.btnDongkhoa_Click);
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 375);
            this.Controls.Add(this.btnDongkhoa);
            this.Controls.Add(this.btnXoakhoa);
            this.Controls.Add(this.btnSuakhoa);
            this.Controls.Add(this.btnThemkhoa);
            this.Controls.Add(this.dgvKhoa);
            this.Controls.Add(this.txttenkhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmakhoa);
            this.Controls.Add(this.label1);
            this.Name = "frmKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.Khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.TextBox txttenkhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.Button btnThemkhoa;
        private System.Windows.Forms.Button btnSuakhoa;
        private System.Windows.Forms.Button btnXoakhoa;
        private System.Windows.Forms.Button btnDongkhoa;
    }
}