
namespace CuaHangBanSach
{
    partial class frmCuaHangBanSach
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvLstSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đếmSốCuốnSáchTrongKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đếmTổngSốLượngTồnKhoCủaTấtCảCácSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhTổngTiềnHàngTồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtLoaiSach = new System.Windows.Forms.TextBox();
            this.txtGiaSach = new System.Windows.Forms.TextBox();
            this.txtSoLuongTonKho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSoCuonSach = new System.Windows.Forms.Label();
            this.lblSoLuongTonKho = new System.Windows.Forms.Label();
            this.lblTongTienHangTonKho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstSach)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cửa Hàng Bán Sách";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1246, 118);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 42);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1246, 170);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 42);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1246, 222);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(131, 42);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvLstSach
            // 
            this.dgvLstSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLstSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLstSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colLoaiSach,
            this.colGiaTien,
            this.colSLTonKho});
            this.dgvLstSach.Location = new System.Drawing.Point(12, 118);
            this.dgvLstSach.Name = "dgvLstSach";
            this.dgvLstSach.RowHeadersWidth = 51;
            this.dgvLstSach.RowTemplate.Height = 24;
            this.dgvLstSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLstSach.Size = new System.Drawing.Size(768, 342);
            this.dgvLstSach.TabIndex = 7;
            this.dgvLstSach.DoubleClick += new System.EventHandler(this.dgvLstSach_DoubleClick);
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.MinimumWidth = 6;
            this.colMaSach.Name = "colMaSach";
            // 
            // colTenSach
            // 
            this.colTenSach.DataPropertyName = "TenSach";
            this.colTenSach.HeaderText = "Tên Sách";
            this.colTenSach.MinimumWidth = 6;
            this.colTenSach.Name = "colTenSach";
            // 
            // colLoaiSach
            // 
            this.colLoaiSach.DataPropertyName = "LoaiSach";
            this.colLoaiSach.HeaderText = "Loại Sách";
            this.colLoaiSach.MinimumWidth = 6;
            this.colLoaiSach.Name = "colLoaiSach";
            // 
            // colGiaTien
            // 
            this.colGiaTien.DataPropertyName = "GiaTien";
            this.colGiaTien.HeaderText = "Giá Tiền";
            this.colGiaTien.MinimumWidth = 6;
            this.colGiaTien.Name = "colGiaTien";
            // 
            // colSLTonKho
            // 
            this.colSLTonKho.DataPropertyName = "SoLuongTonKho";
            this.colSLTonKho.HeaderText = "Số Lượng Tồn Kho";
            this.colSLTonKho.MinimumWidth = 6;
            this.colSLTonKho.Name = "colSLTonKho";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đếmSốCuốnSáchTrongKhoToolStripMenuItem,
            this.đếmTổngSốLượngTồnKhoCủaTấtCảCácSáchToolStripMenuItem,
            this.tínhTổngTiềnHàngTồnKhoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1391, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đếmSốCuốnSáchTrongKhoToolStripMenuItem
            // 
            this.đếmSốCuốnSáchTrongKhoToolStripMenuItem.Name = "đếmSốCuốnSáchTrongKhoToolStripMenuItem";
            this.đếmSốCuốnSáchTrongKhoToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.đếmSốCuốnSáchTrongKhoToolStripMenuItem.Text = "Đếm số cuốn sách trong kho";
            this.đếmSốCuốnSáchTrongKhoToolStripMenuItem.Click += new System.EventHandler(this.đếmSốCuốnSáchTrongKhoToolStripMenuItem_Click);
            // 
            // đếmTổngSốLượngTồnKhoCủaTấtCảCácSáchToolStripMenuItem
            // 
            this.đếmTổngSốLượngTồnKhoCủaTấtCảCácSáchToolStripMenuItem.Name = "đếmTổngSốLượngTồnKhoCủaTấtCảCácSáchToolStripMenuItem";
            this.đếmTổngSốLượngTồnKhoCủaTấtCảCácSáchToolStripMenuItem.Size = new System.Drawing.Size(333, 24);
            this.đếmTổngSốLượngTồnKhoCủaTấtCảCácSáchToolStripMenuItem.Text = "Đếm tổng số lượng tồn kho của tất cả các sách";
            this.đếmTổngSốLượngTồnKhoCủaTấtCảCácSáchToolStripMenuItem.Click += new System.EventHandler(this.đếmTổngSốLượngTồnKhoCủaTấtCảCácSáchToolStripMenuItem_Click);
            // 
            // tínhTổngTiềnHàngTồnKhoToolStripMenuItem
            // 
            this.tínhTổngTiềnHàngTồnKhoToolStripMenuItem.Name = "tínhTổngTiềnHàngTồnKhoToolStripMenuItem";
            this.tínhTổngTiềnHàngTồnKhoToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.tínhTổngTiềnHàngTồnKhoToolStripMenuItem.Text = "Tính tổng tiền hàng tồn kho";
            this.tínhTổngTiềnHàngTồnKhoToolStripMenuItem.Click += new System.EventHandler(this.tínhTổngTiềnHàngTồnKhoToolStripMenuItem_Click);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(1029, 126);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(189, 34);
            this.txtMaSach.TabIndex = 9;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(1029, 170);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(189, 34);
            this.txtTenSach.TabIndex = 10;
            // 
            // txtLoaiSach
            // 
            this.txtLoaiSach.Location = new System.Drawing.Point(1029, 210);
            this.txtLoaiSach.Name = "txtLoaiSach";
            this.txtLoaiSach.Size = new System.Drawing.Size(189, 34);
            this.txtLoaiSach.TabIndex = 11;
            // 
            // txtGiaSach
            // 
            this.txtGiaSach.Location = new System.Drawing.Point(1029, 250);
            this.txtGiaSach.Name = "txtGiaSach";
            this.txtGiaSach.Size = new System.Drawing.Size(189, 34);
            this.txtGiaSach.TabIndex = 12;
            // 
            // txtSoLuongTonKho
            // 
            this.txtSoLuongTonKho.Location = new System.Drawing.Point(1029, 290);
            this.txtSoLuongTonKho.Name = "txtSoLuongTonKho";
            this.txtSoLuongTonKho.Size = new System.Drawing.Size(189, 34);
            this.txtSoLuongTonKho.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(809, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(809, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên Sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(809, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Loại Sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(809, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Giá Sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(809, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Số Lượng Tồn Kho";
            // 
            // lblSoCuonSach
            // 
            this.lblSoCuonSach.AutoSize = true;
            this.lblSoCuonSach.Location = new System.Drawing.Point(809, 353);
            this.lblSoCuonSach.Name = "lblSoCuonSach";
            this.lblSoCuonSach.Size = new System.Drawing.Size(79, 29);
            this.lblSoCuonSach.TabIndex = 19;
            this.lblSoCuonSach.Text = "label7";
            // 
            // lblSoLuongTonKho
            // 
            this.lblSoLuongTonKho.AutoSize = true;
            this.lblSoLuongTonKho.Location = new System.Drawing.Point(809, 393);
            this.lblSoLuongTonKho.Name = "lblSoLuongTonKho";
            this.lblSoLuongTonKho.Size = new System.Drawing.Size(79, 29);
            this.lblSoLuongTonKho.TabIndex = 20;
            this.lblSoLuongTonKho.Text = "label8";
            // 
            // lblTongTienHangTonKho
            // 
            this.lblTongTienHangTonKho.AutoSize = true;
            this.lblTongTienHangTonKho.Location = new System.Drawing.Point(809, 431);
            this.lblTongTienHangTonKho.Name = "lblTongTienHangTonKho";
            this.lblTongTienHangTonKho.Size = new System.Drawing.Size(79, 29);
            this.lblTongTienHangTonKho.TabIndex = 21;
            this.lblTongTienHangTonKho.Text = "label9";
            // 
            // frmCuaHangBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 816);
            this.Controls.Add(this.lblTongTienHangTonKho);
            this.Controls.Add(this.lblSoLuongTonKho);
            this.Controls.Add(this.lblSoCuonSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoLuongTonKho);
            this.Controls.Add(this.txtGiaSach);
            this.Controls.Add(this.txtLoaiSach);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.dgvLstSach);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCuaHangBanSach";
            this.Text = "Cửa Hàng Bán Sách";
            this.Load += new System.EventHandler(this.frmCuaHangBanSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstSach)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvLstSach;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đếmSốCuốnSáchTrongKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đếmTổngSốLượngTồnKhoCủaTấtCảCácSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhTổngTiềnHàngTồnKhoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtLoaiSach;
        private System.Windows.Forms.TextBox txtGiaSach;
        private System.Windows.Forms.TextBox txtSoLuongTonKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLTonKho;
        private System.Windows.Forms.Label lblSoCuonSach;
        private System.Windows.Forms.Label lblSoLuongTonKho;
        private System.Windows.Forms.Label lblTongTienHangTonKho;
    }
}

