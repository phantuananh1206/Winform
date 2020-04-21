namespace CS414B_PhanTuanAnh_2321122511_QUANLYSINHVIEN.GUI
{
    partial class guiKHOA
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvKHOA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbCHITIETKHOA = new System.Windows.Forms.GroupBox();
            this.grbTHONGTINKHOA = new System.Windows.Forms.GroupBox();
            this.txtTIMKIEM = new System.Windows.Forms.TextBox();
            this.txtTENKHOA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMAKHOA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDONG = new System.Windows.Forms.Button();
            this.btnHIENTHI = new System.Windows.Forms.Button();
            this.btnTIMKIEM = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnTHEM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHOA)).BeginInit();
            this.grbCHITIETKHOA.SuspendLayout();
            this.grbTHONGTINKHOA.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(229, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "BIỂU MẪU QUẢN LÝ KHOA";
            // 
            // dgvKHOA
            // 
            this.dgvKHOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHOA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvKHOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKHOA.Location = new System.Drawing.Point(3, 23);
            this.dgvKHOA.Name = "dgvKHOA";
            this.dgvKHOA.RowTemplate.Height = 24;
            this.dgvKHOA.Size = new System.Drawing.Size(854, 201);
            this.dgvKHOA.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAKHOA";
            this.Column1.HeaderText = "Mã khoa";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENKHOA";
            this.Column2.HeaderText = "Tên khoa";
            this.Column2.Name = "Column2";
            // 
            // grbCHITIETKHOA
            // 
            this.grbCHITIETKHOA.Controls.Add(this.dgvKHOA);
            this.grbCHITIETKHOA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbCHITIETKHOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCHITIETKHOA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbCHITIETKHOA.Location = new System.Drawing.Point(0, 260);
            this.grbCHITIETKHOA.Name = "grbCHITIETKHOA";
            this.grbCHITIETKHOA.Size = new System.Drawing.Size(860, 227);
            this.grbCHITIETKHOA.TabIndex = 13;
            this.grbCHITIETKHOA.TabStop = false;
            this.grbCHITIETKHOA.Text = "Chi tiết khoa";
            // 
            // grbTHONGTINKHOA
            // 
            this.grbTHONGTINKHOA.Controls.Add(this.txtTIMKIEM);
            this.grbTHONGTINKHOA.Controls.Add(this.txtTENKHOA);
            this.grbTHONGTINKHOA.Controls.Add(this.label4);
            this.grbTHONGTINKHOA.Controls.Add(this.txtMAKHOA);
            this.grbTHONGTINKHOA.Controls.Add(this.label2);
            this.grbTHONGTINKHOA.Controls.Add(this.btnDONG);
            this.grbTHONGTINKHOA.Controls.Add(this.btnHIENTHI);
            this.grbTHONGTINKHOA.Controls.Add(this.btnTIMKIEM);
            this.grbTHONGTINKHOA.Controls.Add(this.btnSUA);
            this.grbTHONGTINKHOA.Controls.Add(this.label1);
            this.grbTHONGTINKHOA.Controls.Add(this.btnXOA);
            this.grbTHONGTINKHOA.Controls.Add(this.btnTHEM);
            this.grbTHONGTINKHOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTHONGTINKHOA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbTHONGTINKHOA.Location = new System.Drawing.Point(3, 44);
            this.grbTHONGTINKHOA.Name = "grbTHONGTINKHOA";
            this.grbTHONGTINKHOA.Size = new System.Drawing.Size(857, 210);
            this.grbTHONGTINKHOA.TabIndex = 14;
            this.grbTHONGTINKHOA.TabStop = false;
            this.grbTHONGTINKHOA.Text = "Thông tin khoa";
            // 
            // txtTIMKIEM
            // 
            this.txtTIMKIEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTIMKIEM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTIMKIEM.Location = new System.Drawing.Point(420, 91);
            this.txtTIMKIEM.Name = "txtTIMKIEM";
            this.txtTIMKIEM.Size = new System.Drawing.Size(155, 27);
            this.txtTIMKIEM.TabIndex = 48;
            // 
            // txtTENKHOA
            // 
            this.txtTENKHOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENKHOA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTENKHOA.Location = new System.Drawing.Point(566, 26);
            this.txtTENKHOA.Name = "txtTENKHOA";
            this.txtTENKHOA.Size = new System.Drawing.Size(155, 27);
            this.txtTENKHOA.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(399, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nhập mã khoa cần tìm";
            // 
            // txtMAKHOA
            // 
            this.txtMAKHOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAKHOA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtMAKHOA.Location = new System.Drawing.Point(179, 26);
            this.txtMAKHOA.Name = "txtMAKHOA";
            this.txtMAKHOA.Size = new System.Drawing.Size(155, 27);
            this.txtMAKHOA.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(458, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tên khoa:";
            // 
            // btnDONG
            // 
            this.btnDONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDONG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDONG.Location = new System.Drawing.Point(721, 124);
            this.btnDONG.Name = "btnDONG";
            this.btnDONG.Size = new System.Drawing.Size(104, 39);
            this.btnDONG.TabIndex = 47;
            this.btnDONG.Text = "Đóng";
            this.btnDONG.UseVisualStyleBackColor = true;
            this.btnDONG.Click += new System.EventHandler(this.btnDONG_Click);
            // 
            // btnHIENTHI
            // 
            this.btnHIENTHI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHIENTHI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHIENTHI.Location = new System.Drawing.Point(587, 124);
            this.btnHIENTHI.Name = "btnHIENTHI";
            this.btnHIENTHI.Size = new System.Drawing.Size(104, 39);
            this.btnHIENTHI.TabIndex = 44;
            this.btnHIENTHI.Text = "Hiển thị";
            this.btnHIENTHI.UseVisualStyleBackColor = true;
            this.btnHIENTHI.Click += new System.EventHandler(this.btnHIENTHI_Click);
            // 
            // btnTIMKIEM
            // 
            this.btnTIMKIEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTIMKIEM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTIMKIEM.Location = new System.Drawing.Point(444, 124);
            this.btnTIMKIEM.Name = "btnTIMKIEM";
            this.btnTIMKIEM.Size = new System.Drawing.Size(104, 39);
            this.btnTIMKIEM.TabIndex = 45;
            this.btnTIMKIEM.Text = "Tìm kiếm";
            this.btnTIMKIEM.UseVisualStyleBackColor = true;
            this.btnTIMKIEM.Click += new System.EventHandler(this.btnTIMKIEM_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSUA.Location = new System.Drawing.Point(306, 124);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(104, 39);
            this.btnSUA.TabIndex = 46;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(78, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Mã khoa:";
            // 
            // btnXOA
            // 
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXOA.Location = new System.Drawing.Point(159, 124);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(104, 39);
            this.btnXOA.TabIndex = 43;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnTHEM
            // 
            this.btnTHEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHEM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTHEM.Location = new System.Drawing.Point(31, 124);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(102, 39);
            this.btnTHEM.TabIndex = 42;
            this.btnTHEM.Text = "Thêm mới";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // guiKHOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 487);
            this.Controls.Add(this.grbTHONGTINKHOA);
            this.Controls.Add(this.grbCHITIETKHOA);
            this.Controls.Add(this.label3);
            this.Name = "guiKHOA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "guiKHOA";
            this.Load += new System.EventHandler(this.guiKHOA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHOA)).EndInit();
            this.grbCHITIETKHOA.ResumeLayout(false);
            this.grbTHONGTINKHOA.ResumeLayout(false);
            this.grbTHONGTINKHOA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvKHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox grbCHITIETKHOA;
        private System.Windows.Forms.GroupBox grbTHONGTINKHOA;
        private System.Windows.Forms.TextBox txtTIMKIEM;
        private System.Windows.Forms.TextBox txtTENKHOA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMAKHOA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDONG;
        private System.Windows.Forms.Button btnHIENTHI;
        private System.Windows.Forms.Button btnTIMKIEM;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnTHEM;
    }
}