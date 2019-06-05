namespace QuanLySinhVien
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnThongtin = new System.Windows.Forms.GroupBox();
            this.cbxMH = new System.Windows.Forms.ComboBox();
            this.cbxGV = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDanhsachLop = new System.Windows.Forms.DataGridView();
            this.IDLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachLop)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(91, 28);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(233, 29);
            this.txtTen.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên MH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(330, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tên GV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Lớp";
            // 
            // pnThongtin
            // 
            this.pnThongtin.Controls.Add(this.cbxMH);
            this.pnThongtin.Controls.Add(this.cbxGV);
            this.pnThongtin.Controls.Add(this.txtTen);
            this.pnThongtin.Controls.Add(this.label4);
            this.pnThongtin.Controls.Add(this.label9);
            this.pnThongtin.Controls.Add(this.label2);
            this.pnThongtin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnThongtin.Location = new System.Drawing.Point(12, 12);
            this.pnThongtin.Name = "pnThongtin";
            this.pnThongtin.Size = new System.Drawing.Size(653, 127);
            this.pnThongtin.TabIndex = 1212156;
            this.pnThongtin.TabStop = false;
            this.pnThongtin.Text = "Thông tin";
            // 
            // cbxMH
            // 
            this.cbxMH.FormattingEnabled = true;
            this.cbxMH.Location = new System.Drawing.Point(91, 76);
            this.cbxMH.Name = "cbxMH";
            this.cbxMH.Size = new System.Drawing.Size(233, 29);
            this.cbxMH.TabIndex = 10;
            // 
            // cbxGV
            // 
            this.cbxGV.FormattingEnabled = true;
            this.cbxGV.Location = new System.Drawing.Point(407, 28);
            this.cbxGV.Name = "cbxGV";
            this.cbxGV.Size = new System.Drawing.Size(240, 29);
            this.cbxGV.TabIndex = 10;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(484, 409);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 27);
            this.btnHuy.TabIndex = 1212147;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(391, 409);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 27);
            this.btnLuu.TabIndex = 1212148;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(577, 409);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 27);
            this.btnThoat.TabIndex = 1212149;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(296, 409);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 27);
            this.btnThem.TabIndex = 1212152;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDanhsachLop
            // 
            this.dgvDanhsachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLop,
            this.TenLop,
            this.TenGV,
            this.TenMH,
            this.SoTinChi});
            this.dgvDanhsachLop.Location = new System.Drawing.Point(11, 144);
            this.dgvDanhsachLop.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhsachLop.Name = "dgvDanhsachLop";
            this.dgvDanhsachLop.ReadOnly = true;
            this.dgvDanhsachLop.RowTemplate.Height = 24;
            this.dgvDanhsachLop.Size = new System.Drawing.Size(653, 251);
            this.dgvDanhsachLop.TabIndex = 1212157;
            this.dgvDanhsachLop.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsachLop_CellDoubleClick);
            // 
            // IDLop
            // 
            this.IDLop.DataPropertyName = "IDLop";
            this.IDLop.HeaderText = "ID Lớp";
            this.IDLop.Name = "IDLop";
            this.IDLop.ReadOnly = true;
            this.IDLop.Width = 75;
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            this.TenLop.Width = 160;
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên GV";
            this.TenGV.Name = "TenGV";
            this.TenGV.ReadOnly = true;
            this.TenGV.Width = 150;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên MH";
            this.TenMH.Name = "TenMH";
            this.TenMH.ReadOnly = true;
            this.TenMH.Width = 150;
            // 
            // SoTinChi
            // 
            this.SoTinChi.DataPropertyName = "SoTinChi";
            this.SoTinChi.HeaderText = "Số TC";
            this.SoTinChi.Name = "SoTinChi";
            this.SoTinChi.ReadOnly = true;
            this.SoTinChi.Width = 75;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 455);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDanhsachLop);
            this.Controls.Add(this.pnThongtin);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.pnThongtin.ResumeLayout(false);
            this.pnThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox pnThongtin;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDanhsachLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private System.Windows.Forms.ComboBox cbxMH;
        private System.Windows.Forms.ComboBox cbxGV;
    }
}