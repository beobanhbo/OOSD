namespace QuanLySinhVien
{
    partial class frmSinhVienTheoLop
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
            this.dgvDanhsachSVtheoLop = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbxSV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IDSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQuaTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCuoiKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachSVtheoLop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhsachSVtheoLop
            // 
            this.dgvDanhsachSVtheoLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachSVtheoLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSV,
            this.TenSV,
            this.DiemQuaTrinh,
            this.DiemCuoiKi});
            this.dgvDanhsachSVtheoLop.Location = new System.Drawing.Point(18, 71);
            this.dgvDanhsachSVtheoLop.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhsachSVtheoLop.Name = "dgvDanhsachSVtheoLop";
            this.dgvDanhsachSVtheoLop.RowTemplate.Height = 25;
            this.dgvDanhsachSVtheoLop.Size = new System.Drawing.Size(453, 267);
            this.dgvDanhsachSVtheoLop.TabIndex = 1212143;
            this.dgvDanhsachSVtheoLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsachSVtheoLop_CellContentClick);
            this.dgvDanhsachSVtheoLop.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsachSVtheoLop_CellEndEdit);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(384, 354);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 27);
            this.btnThoat.TabIndex = 1212150;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(292, 354);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 27);
            this.btnHuy.TabIndex = 1212153;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(199, 354);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 27);
            this.btnLuu.TabIndex = 1212154;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(104, 354);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 27);
            this.btnThem.TabIndex = 1212155;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbxSV
            // 
            this.cbxSV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSV.FormattingEnabled = true;
            this.cbxSV.Location = new System.Drawing.Point(88, 22);
            this.cbxSV.Name = "cbxSV";
            this.cbxSV.Size = new System.Drawing.Size(240, 29);
            this.cbxSV.TabIndex = 1212157;
            this.cbxSV.SelectedIndexChanged += new System.EventHandler(this.cbxSV_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 21);
            this.label9.TabIndex = 1212156;
            this.label9.Text = "Tên SV";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // IDSV
            // 
            this.IDSV.DataPropertyName = "IDSV";
            this.IDSV.HeaderText = "IDSV";
            this.IDSV.Name = "IDSV";
            this.IDSV.ReadOnly = true;
            this.IDSV.Width = 50;
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Tên SV";
            this.TenSV.Name = "TenSV";
            this.TenSV.ReadOnly = true;
            this.TenSV.Width = 150;
            // 
            // DiemQuaTrinh
            // 
            this.DiemQuaTrinh.DataPropertyName = "DiemQuaTrinh";
            this.DiemQuaTrinh.HeaderText = "Điểm Quá Trình";
            this.DiemQuaTrinh.Name = "DiemQuaTrinh";
            this.DiemQuaTrinh.Width = 105;
            // 
            // DiemCuoiKi
            // 
            this.DiemCuoiKi.DataPropertyName = "DiemCuoiKi";
            this.DiemCuoiKi.HeaderText = "Điểm Cuối Kì";
            this.DiemCuoiKi.Name = "DiemCuoiKi";
            this.DiemCuoiKi.Width = 105;
            // 
            // frmSinhVienTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 411);
            this.ControlBox = false;
            this.Controls.Add(this.cbxSV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvDanhsachSVtheoLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSinhVienTheoLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh Viên Theo Lớp";
            this.Load += new System.EventHandler(this.frmSinhVienTheoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachSVtheoLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhsachSVtheoLop;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbxSV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQuaTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCuoiKi;
    }
}