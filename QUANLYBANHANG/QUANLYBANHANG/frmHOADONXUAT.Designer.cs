namespace QUANLYBANHANG
{
    partial class frmHOADONXUAT
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
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDONG = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.cobKHACHHANG = new System.Windows.Forms.ComboBox();
            this.dtpNGAYXUAT = new System.Windows.Forms.DateTimePicker();
            this.txtGHICHU = new System.Windows.Forms.TextBox();
            this.txtTONGTIEN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMAHOADON = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCHITIETHOADON = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobSanPham = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clSOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTHANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobMAHOADON = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dbQUANLYBANHANGDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbQUANLYBANHANGDataSet = new QUANLYBANHANG.dbQUANLYBANHANGDataSet();
            this.frmQUANLYSANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETHOADON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbQUANLYBANHANGDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbQUANLYBANHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmQUANLYSANPHAMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(335, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "BIỂU MẪU HÓA ĐƠN XUẤT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDONG);
            this.groupBox1.Controls.Add(this.btnSUA);
            this.groupBox1.Controls.Add(this.btnXOA);
            this.groupBox1.Controls.Add(this.btnTHEM);
            this.groupBox1.Controls.Add(this.cobKHACHHANG);
            this.groupBox1.Controls.Add(this.dtpNGAYXUAT);
            this.groupBox1.Controls.Add(this.txtGHICHU);
            this.groupBox1.Controls.Add(this.txtTONGTIEN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMAHOADON);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 494);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn xuất";
            // 
            // btnDONG
            // 
            this.btnDONG.Location = new System.Drawing.Point(572, 194);
            this.btnDONG.Name = "btnDONG";
            this.btnDONG.Size = new System.Drawing.Size(89, 37);
            this.btnDONG.TabIndex = 7;
            this.btnDONG.Text = "Đóng";
            this.btnDONG.UseVisualStyleBackColor = true;
            this.btnDONG.Click += new System.EventHandler(this.btnDONG_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Location = new System.Drawing.Point(420, 194);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(89, 37);
            this.btnSUA.TabIndex = 7;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(259, 194);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(89, 37);
            this.btnXOA.TabIndex = 7;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnTHEM
            // 
            this.btnTHEM.Location = new System.Drawing.Point(105, 194);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(89, 37);
            this.btnTHEM.TabIndex = 7;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // cobKHACHHANG
            // 
            this.cobKHACHHANG.FormattingEnabled = true;
            this.cobKHACHHANG.Location = new System.Drawing.Point(473, 40);
            this.cobKHACHHANG.Name = "cobKHACHHANG";
            this.cobKHACHHANG.Size = new System.Drawing.Size(153, 28);
            this.cobKHACHHANG.TabIndex = 6;
            // 
            // dtpNGAYXUAT
            // 
            this.dtpNGAYXUAT.CustomFormat = "MM/dd/yyyy";
            this.dtpNGAYXUAT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNGAYXUAT.Location = new System.Drawing.Point(163, 92);
            this.dtpNGAYXUAT.Name = "dtpNGAYXUAT";
            this.dtpNGAYXUAT.Size = new System.Drawing.Size(153, 27);
            this.dtpNGAYXUAT.TabIndex = 5;
            // 
            // txtGHICHU
            // 
            this.txtGHICHU.Location = new System.Drawing.Point(473, 146);
            this.txtGHICHU.Name = "txtGHICHU";
            this.txtGHICHU.Size = new System.Drawing.Size(153, 27);
            this.txtGHICHU.TabIndex = 4;
            // 
            // txtTONGTIEN
            // 
            this.txtTONGTIEN.Location = new System.Drawing.Point(473, 92);
            this.txtTONGTIEN.Name = "txtTONGTIEN";
            this.txtTONGTIEN.Size = new System.Drawing.Size(153, 27);
            this.txtTONGTIEN.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi chú";
            // 
            // txtMAHOADON
            // 
            this.txtMAHOADON.Location = new System.Drawing.Point(163, 40);
            this.txtMAHOADON.Name = "txtMAHOADON";
            this.txtMAHOADON.Size = new System.Drawing.Size(153, 27);
            this.txtMAHOADON.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCHITIETHOADON);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 240);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dgvCHITIETHOADON
            // 
            this.dgvCHITIETHOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCHITIETHOADON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.cobSanPham,
            this.clSOLUONG,
            this.clDONGIA,
            this.clTHANHTIEN,
            this.cobMAHOADON});
            this.dgvCHITIETHOADON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCHITIETHOADON.Location = new System.Drawing.Point(3, 23);
            this.dgvCHITIETHOADON.Name = "dgvCHITIETHOADON";
            this.dgvCHITIETHOADON.RowTemplate.Height = 24;
            this.dgvCHITIETHOADON.Size = new System.Drawing.Size(735, 214);
            this.dgvCHITIETHOADON.TabIndex = 0;
            this.dgvCHITIETHOADON.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCHITIETHOADON_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MACHITIET";
            this.Column1.HeaderText = "Mã chi tiết";
            this.Column1.Name = "Column1";
            // 
            // cobSanPham
            // 
            this.cobSanPham.DataPropertyName = "MASP";
            this.cobSanPham.HeaderText = "Tên sản phẩm";
            this.cobSanPham.Name = "cobSanPham";
            // 
            // clSOLUONG
            // 
            this.clSOLUONG.DataPropertyName = "SOLUONG";
            this.clSOLUONG.HeaderText = "Số lượng";
            this.clSOLUONG.Name = "clSOLUONG";
            this.clSOLUONG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clSOLUONG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clDONGIA
            // 
            this.clDONGIA.DataPropertyName = "DONGIA";
            this.clDONGIA.HeaderText = "Đơn giá";
            this.clDONGIA.Name = "clDONGIA";
            this.clDONGIA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clDONGIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clTHANHTIEN
            // 
            this.clTHANHTIEN.DataPropertyName = "THANHTIEN";
            this.clTHANHTIEN.HeaderText = "Thành tiền";
            this.clTHANHTIEN.Name = "clTHANHTIEN";
            this.clTHANHTIEN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clTHANHTIEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cobMAHOADON
            // 
            this.cobMAHOADON.DataPropertyName = "MAHOADON";
            this.cobMAHOADON.HeaderText = "Mã hóa đơn";
            this.cobMAHOADON.Name = "cobMAHOADON";
            // 
            // dbQUANLYBANHANGDataSetBindingSource
            // 
            this.dbQUANLYBANHANGDataSetBindingSource.DataSource = this.dbQUANLYBANHANGDataSet;
            this.dbQUANLYBANHANGDataSetBindingSource.Position = 0;
            // 
            // dbQUANLYBANHANGDataSet
            // 
            this.dbQUANLYBANHANGDataSet.DataSetName = "dbQUANLYBANHANGDataSet";
            this.dbQUANLYBANHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmQUANLYSANPHAMBindingSource
            // 
            this.frmQUANLYSANPHAMBindingSource.DataSource = typeof(QUANLYBANHANG.frmQUANLYSANPHAM);
            // 
            // frmHOADONXUAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Name = "frmHOADONXUAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHOADONXUAT";
            this.Load += new System.EventHandler(this.frmHOADONXUAT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETHOADON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbQUANLYBANHANGDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbQUANLYBANHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmQUANLYSANPHAMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cobKHACHHANG;
        private System.Windows.Forms.DateTimePicker dtpNGAYXUAT;
        private System.Windows.Forms.TextBox txtTONGTIEN;
        private System.Windows.Forms.TextBox txtMAHOADON;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCHITIETHOADON;
        private System.Windows.Forms.Button btnDONG;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.BindingSource dbQUANLYBANHANGDataSetBindingSource;
        private dbQUANLYBANHANGDataSet dbQUANLYBANHANGDataSet;
        private System.Windows.Forms.BindingSource frmQUANLYSANPHAMBindingSource;
        private System.Windows.Forms.TextBox txtGHICHU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cobSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTHANHTIEN;
        private System.Windows.Forms.DataGridViewComboBoxColumn cobMAHOADON;
    }
}