namespace QUANLYBANHANG
{
    partial class frmKHACHHANG
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
            this.txtMAKHACHHANG = new System.Windows.Forms.TextBox();
            this.dgvKHACHHANG = new System.Windows.Forms.DataGridView();
            this.btnTHEMMOI = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTENKHACHHANG = new System.Windows.Forms.TextBox();
            this.txtGIOITINH = new System.Windows.Forms.TextBox();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtSODIENTHOAI = new System.Windows.Forms.TextBox();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnHIENTHI = new System.Windows.Forms.Button();
            this.btnTIMKIEM = new System.Windows.Forms.Button();
            this.btnDONG = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTIMKIEM = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHACHHANG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // txtMAKHACHHANG
            // 
            this.txtMAKHACHHANG.Location = new System.Drawing.Point(206, 31);
            this.txtMAKHACHHANG.Name = "txtMAKHACHHANG";
            this.txtMAKHACHHANG.Size = new System.Drawing.Size(200, 22);
            this.txtMAKHACHHANG.TabIndex = 1;
            // 
            // dgvKHACHHANG
            // 
            this.dgvKHACHHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHACHHANG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvKHACHHANG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKHACHHANG.Location = new System.Drawing.Point(0, 282);
            this.dgvKHACHHANG.Name = "dgvKHACHHANG";
            this.dgvKHACHHANG.RowTemplate.Height = 24;
            this.dgvKHACHHANG.Size = new System.Drawing.Size(812, 192);
            this.dgvKHACHHANG.TabIndex = 3;
            // 
            // btnTHEMMOI
            // 
            this.btnTHEMMOI.Location = new System.Drawing.Point(493, 21);
            this.btnTHEMMOI.Name = "btnTHEMMOI";
            this.btnTHEMMOI.Size = new System.Drawing.Size(82, 43);
            this.btnTHEMMOI.TabIndex = 4;
            this.btnTHEMMOI.Text = "Thêm mới";
            this.btnTHEMMOI.UseVisualStyleBackColor = true;
            this.btnTHEMMOI.Click += new System.EventHandler(this.btnTHEMMOI_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại";
            // 
            // txtTENKHACHHANG
            // 
            this.txtTENKHACHHANG.Location = new System.Drawing.Point(206, 66);
            this.txtTENKHACHHANG.Name = "txtTENKHACHHANG";
            this.txtTENKHACHHANG.Size = new System.Drawing.Size(200, 22);
            this.txtTENKHACHHANG.TabIndex = 2;
            // 
            // txtGIOITINH
            // 
            this.txtGIOITINH.Location = new System.Drawing.Point(206, 101);
            this.txtGIOITINH.Name = "txtGIOITINH";
            this.txtGIOITINH.Size = new System.Drawing.Size(200, 22);
            this.txtGIOITINH.TabIndex = 3;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.Location = new System.Drawing.Point(206, 134);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(200, 22);
            this.txtDIACHI.TabIndex = 4;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(206, 173);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(200, 22);
            this.txtEMAIL.TabIndex = 5;
            // 
            // txtSODIENTHOAI
            // 
            this.txtSODIENTHOAI.Location = new System.Drawing.Point(206, 209);
            this.txtSODIENTHOAI.Name = "txtSODIENTHOAI";
            this.txtSODIENTHOAI.Size = new System.Drawing.Size(200, 22);
            this.txtSODIENTHOAI.TabIndex = 6;
            // 
            // btnSUA
            // 
            this.btnSUA.Location = new System.Drawing.Point(655, 21);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(80, 43);
            this.btnSUA.TabIndex = 4;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(493, 88);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(80, 43);
            this.btnXOA.TabIndex = 4;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnHIENTHI
            // 
            this.btnHIENTHI.Location = new System.Drawing.Point(655, 88);
            this.btnHIENTHI.Name = "btnHIENTHI";
            this.btnHIENTHI.Size = new System.Drawing.Size(80, 43);
            this.btnHIENTHI.TabIndex = 4;
            this.btnHIENTHI.Text = "Hiển thị";
            this.btnHIENTHI.UseVisualStyleBackColor = true;
            this.btnHIENTHI.Click += new System.EventHandler(this.btnHIENTHI_Click);
            // 
            // btnTIMKIEM
            // 
            this.btnTIMKIEM.Location = new System.Drawing.Point(493, 209);
            this.btnTIMKIEM.Name = "btnTIMKIEM";
            this.btnTIMKIEM.Size = new System.Drawing.Size(80, 43);
            this.btnTIMKIEM.TabIndex = 4;
            this.btnTIMKIEM.Text = "Tìm kiếm";
            this.btnTIMKIEM.UseVisualStyleBackColor = true;
            this.btnTIMKIEM.Click += new System.EventHandler(this.btnTIMKIEM_Click);
            // 
            // btnDONG
            // 
            this.btnDONG.Location = new System.Drawing.Point(655, 209);
            this.btnDONG.Name = "btnDONG";
            this.btnDONG.Size = new System.Drawing.Size(80, 43);
            this.btnDONG.TabIndex = 4;
            this.btnDONG.Text = "Đóng";
            this.btnDONG.UseVisualStyleBackColor = true;
            this.btnDONG.Click += new System.EventHandler(this.btnDONG_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nhập mã cần tìm";
            // 
            // txtTIMKIEM
            // 
            this.txtTIMKIEM.Location = new System.Drawing.Point(471, 173);
            this.txtTIMKIEM.Name = "txtTIMKIEM";
            this.txtTIMKIEM.Size = new System.Drawing.Size(134, 22);
            this.txtTIMKIEM.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENKHACHHANG";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GIOITINH";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DIACHI";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "EMAIL";
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SODIENTHOAI";
            this.Column6.HeaderText = "Số điện thoại";
            this.Column6.Name = "Column6";
            // 
            // frmKHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 474);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDONG);
            this.Controls.Add(this.btnTIMKIEM);
            this.Controls.Add(this.btnHIENTHI);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnTHEMMOI);
            this.Controls.Add(this.dgvKHACHHANG);
            this.Controls.Add(this.txtSODIENTHOAI);
            this.Controls.Add(this.txtTIMKIEM);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtDIACHI);
            this.Controls.Add(this.txtGIOITINH);
            this.Controls.Add(this.txtTENKHACHHANG);
            this.Controls.Add(this.txtMAKHACHHANG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKHACHHANG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.frmKHACHHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHACHHANG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMAKHACHHANG;
        private System.Windows.Forms.DataGridView dgvKHACHHANG;
        private System.Windows.Forms.Button btnTHEMMOI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTENKHACHHANG;
        private System.Windows.Forms.TextBox txtGIOITINH;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtSODIENTHOAI;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnHIENTHI;
        private System.Windows.Forms.Button btnTIMKIEM;
        private System.Windows.Forms.Button btnDONG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTIMKIEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}