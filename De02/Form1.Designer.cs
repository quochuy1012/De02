namespace De02
{
    partial class Form1
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
            this.dtNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnKLuu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // dtNgaynhap
            // 
            this.dtNgaynhap.Location = new System.Drawing.Point(667, 250);
            this.dtNgaynhap.Name = "dtNgaynhap";
            this.dtNgaynhap.Size = new System.Drawing.Size(200, 22);
            this.dtNgaynhap.TabIndex = 26;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(667, 289);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(130, 24);
            this.cboLoaiSP.TabIndex = 25;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(667, 206);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(130, 22);
            this.txtTenSP.TabIndex = 24;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(667, 160);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(130, 22);
            this.txtMaSP.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Loại SP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên SP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã SP:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(548, 432);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnKLuu
            // 
            this.btnKLuu.Location = new System.Drawing.Point(436, 432);
            this.btnKLuu.Name = "btnKLuu";
            this.btnKLuu.Size = new System.Drawing.Size(75, 23);
            this.btnKLuu.TabIndex = 17;
            this.btnKLuu.Text = "KLưu";
            this.btnKLuu.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(332, 432);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(237, 432);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(47, 432);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // LoaiSP
            // 
            this.LoaiSP.HeaderText = "Loại SP";
            this.LoaiSP.MinimumWidth = 6;
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.Width = 125;
            // 
            // Ngaynhap
            // 
            this.Ngaynhap.HeaderText = "Ngày nhập";
            this.Ngaynhap.MinimumWidth = 6;
            this.Ngaynhap.Name = "Ngaynhap";
            this.Ngaynhap.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 125;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 125;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(144, 432);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.Ngaynhap,
            this.LoaiSP});
            this.dgvSanpham.Location = new System.Drawing.Point(10, 112);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.RowHeadersWidth = 51;
            this.dgvSanpham.RowTemplate.Height = 24;
            this.dgvSanpham.Size = new System.Drawing.Size(552, 293);
            this.dgvSanpham.TabIndex = 12;
            this.dgvSanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanpham_CellContentClick);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(237, 83);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(47, 83);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(172, 22);
            this.txttim.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 486);
            this.Controls.Add(this.dtNgaynhap);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvSanpham);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtNgaynhap;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnKLuu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label label1;
    }
}

