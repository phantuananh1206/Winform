namespace QUANLYBANHANG.GUI
{
    partial class guiKHACHHANG
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
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.txtGIOITINH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.dgvKHACHHANG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHACHHANG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên khách hàng";
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Location = new System.Drawing.Point(263, 66);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(145, 22);
            this.txtHOTEN.TabIndex = 1;
            // 
            // txtGIOITINH
            // 
            this.txtGIOITINH.Location = new System.Drawing.Point(263, 123);
            this.txtGIOITINH.Name = "txtGIOITINH";
            this.txtGIOITINH.Size = new System.Drawing.Size(145, 22);
            this.txtGIOITINH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giới tính";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Location = new System.Drawing.Point(275, 180);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(88, 44);
            this.btnTHEM.TabIndex = 2;
            this.btnTHEM.Text = "Thêm mới";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // dgvKHACHHANG
            // 
            this.dgvKHACHHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHACHHANG.Location = new System.Drawing.Point(12, 263);
            this.dgvKHACHHANG.Name = "dgvKHACHHANG";
            this.dgvKHACHHANG.RowTemplate.Height = 24;
            this.dgvKHACHHANG.Size = new System.Drawing.Size(648, 197);
            this.dgvKHACHHANG.TabIndex = 3;
            // 
            // guiKHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 472);
            this.Controls.Add(this.dgvKHACHHANG);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.txtGIOITINH);
            this.Controls.Add(this.txtHOTEN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "guiKHACHHANG";
            this.Text = "guiKHACHHANG";
            this.Load += new System.EventHandler(this.guiKHACHHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHACHHANG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.TextBox txtGIOITINH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.DataGridView dgvKHACHHANG;
    }
}