namespace QUANLYBANHANG
{
    partial class frmHOADON
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnDONG = new System.Windows.Forms.Button();
            this.btnTIMKIEM = new System.Windows.Forms.Button();
            this.btnHIENTHI = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnTHEMMOI = new System.Windows.Forms.Button();
            this.dgvHOADON = new System.Windows.Forms.DataGridView();
            this.txtTIMKIEM = new System.Windows.Forms.TextBox();
            this.txtGHICHU = new System.Windows.Forms.TextBox();
            this.txtTONGTIEN = new System.Windows.Forms.TextBox();
            this.txtNGAYXUAT = new System.Windows.Forms.TextBox();
            this.txtMAHOADON = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cobMAKHACHHANG = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOADON)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nhập mã cần tìm";
            // 
            // btnDONG
            // 
            this.btnDONG.Location = new System.Drawing.Point(655, 224);
            this.btnDONG.Name = "btnDONG";
            this.btnDONG.Size = new System.Drawing.Size(80, 43);
            this.btnDONG.TabIndex = 25;
            this.btnDONG.Text = "Đóng";
            this.btnDONG.UseVisualStyleBackColor = true;
            this.btnDONG.Click += new System.EventHandler(this.btnDONG_Click);
            // 
            // btnTIMKIEM
            // 
            this.btnTIMKIEM.Location = new System.Drawing.Point(493, 224);
            this.btnTIMKIEM.Name = "btnTIMKIEM";
            this.btnTIMKIEM.Size = new System.Drawing.Size(80, 43);
            this.btnTIMKIEM.TabIndex = 24;
            this.btnTIMKIEM.Text = "Tìm kiếm";
            this.btnTIMKIEM.UseVisualStyleBackColor = true;
            this.btnTIMKIEM.Click += new System.EventHandler(this.btnTIMKIEM_Click);
            // 
            // btnHIENTHI
            // 
            this.btnHIENTHI.Location = new System.Drawing.Point(655, 101);
            this.btnHIENTHI.Name = "btnHIENTHI";
            this.btnHIENTHI.Size = new System.Drawing.Size(80, 45);
            this.btnHIENTHI.TabIndex = 23;
            this.btnHIENTHI.Text = "Hiển thị";
            this.btnHIENTHI.UseVisualStyleBackColor = true;
            this.btnHIENTHI.Click += new System.EventHandler(this.btnHIENTHI_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(493, 101);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(80, 43);
            this.btnXOA.TabIndex = 22;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Location = new System.Drawing.Point(655, 30);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(80, 43);
            this.btnSUA.TabIndex = 21;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnTHEMMOI
            // 
            this.btnTHEMMOI.Location = new System.Drawing.Point(493, 30);
            this.btnTHEMMOI.Name = "btnTHEMMOI";
            this.btnTHEMMOI.Size = new System.Drawing.Size(82, 43);
            this.btnTHEMMOI.TabIndex = 20;
            this.btnTHEMMOI.Text = "Thêm mới";
            this.btnTHEMMOI.UseVisualStyleBackColor = true;
            this.btnTHEMMOI.Click += new System.EventHandler(this.btnTHEMMOI_Click);
            // 
            // dgvHOADON
            // 
            this.dgvHOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHOADON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvHOADON.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHOADON.Location = new System.Drawing.Point(0, 291);
            this.dgvHOADON.Name = "dgvHOADON";
            this.dgvHOADON.RowTemplate.Height = 24;
            this.dgvHOADON.Size = new System.Drawing.Size(829, 192);
            this.dgvHOADON.TabIndex = 19;
            // 
            // txtTIMKIEM
            // 
            this.txtTIMKIEM.Location = new System.Drawing.Point(473, 196);
            this.txtTIMKIEM.Name = "txtTIMKIEM";
            this.txtTIMKIEM.Size = new System.Drawing.Size(134, 22);
            this.txtTIMKIEM.TabIndex = 6;
            // 
            // txtGHICHU
            // 
            this.txtGHICHU.Location = new System.Drawing.Point(206, 163);
            this.txtGHICHU.Name = "txtGHICHU";
            this.txtGHICHU.Size = new System.Drawing.Size(200, 22);
            this.txtGHICHU.TabIndex = 5;
            // 
            // txtTONGTIEN
            // 
            this.txtTONGTIEN.Location = new System.Drawing.Point(206, 124);
            this.txtTONGTIEN.Name = "txtTONGTIEN";
            this.txtTONGTIEN.Size = new System.Drawing.Size(200, 22);
            this.txtTONGTIEN.TabIndex = 4;
            // 
            // txtNGAYXUAT
            // 
            this.txtNGAYXUAT.Location = new System.Drawing.Point(206, 56);
            this.txtNGAYXUAT.Name = "txtNGAYXUAT";
            this.txtNGAYXUAT.Size = new System.Drawing.Size(200, 22);
            this.txtNGAYXUAT.TabIndex = 2;
            // 
            // txtMAHOADON
            // 
            this.txtMAHOADON.Location = new System.Drawing.Point(206, 21);
            this.txtMAHOADON.Name = "txtMAHOADON";
            this.txtMAHOADON.Size = new System.Drawing.Size(200, 22);
            this.txtMAHOADON.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ngày xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã hóa đơn";
            // 
            // cobMAKHACHHANG
            // 
            this.cobMAKHACHHANG.FormattingEnabled = true;
            this.cobMAKHACHHANG.Location = new System.Drawing.Point(206, 88);
            this.cobMAKHACHHANG.Name = "cobMAKHACHHANG";
            this.cobMAKHACHHANG.Size = new System.Drawing.Size(200, 24);
            this.cobMAKHACHHANG.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAHOADON";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NGAYXUAT";
            this.Column2.HeaderText = "Ngày xuất";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MAKHACHHANG";
            this.Column3.HeaderText = "Mã khách hàng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TONGTIEN";
            this.Column4.HeaderText = "Tổng tiền";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GHICHU";
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.Name = "Column5";
            // 
            // frmHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 483);
            this.Controls.Add(this.cobMAKHACHHANG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDONG);
            this.Controls.Add(this.btnTIMKIEM);
            this.Controls.Add(this.btnHIENTHI);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnTHEMMOI);
            this.Controls.Add(this.dgvHOADON);
            this.Controls.Add(this.txtTIMKIEM);
            this.Controls.Add(this.txtGHICHU);
            this.Controls.Add(this.txtTONGTIEN);
            this.Controls.Add(this.txtNGAYXUAT);
            this.Controls.Add(this.txtMAHOADON);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHOADON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHOADON";
            this.Load += new System.EventHandler(this.frmHOADON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOADON)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDONG;
        private System.Windows.Forms.Button btnTIMKIEM;
        private System.Windows.Forms.Button btnHIENTHI;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnTHEMMOI;
        private System.Windows.Forms.DataGridView dgvHOADON;
        private System.Windows.Forms.TextBox txtTIMKIEM;
        private System.Windows.Forms.TextBox txtGHICHU;
        private System.Windows.Forms.TextBox txtTONGTIEN;
        private System.Windows.Forms.TextBox txtNGAYXUAT;
        private System.Windows.Forms.TextBox txtMAHOADON;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobMAKHACHHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}