namespace QuanLySinhVien
{
    partial class frmGVRieng
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
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.XinchaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQuaTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCuoiKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachSVtheoLop)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.dgvDanhsachSVtheoLop.Location = new System.Drawing.Point(9, 85);
            this.dgvDanhsachSVtheoLop.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhsachSVtheoLop.Name = "dgvDanhsachSVtheoLop";
            this.dgvDanhsachSVtheoLop.RowTemplate.Height = 25;
            this.dgvDanhsachSVtheoLop.Size = new System.Drawing.Size(453, 267);
            this.dgvDanhsachSVtheoLop.TabIndex = 1212158;
            this.dgvDanhsachSVtheoLop.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsachSVtheoLop_CellEndEdit);
            // 
            // cbxLop
            // 
            this.cbxLop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(86, 36);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(376, 29);
            this.cbxLop.TabIndex = 1212164;
            this.cbxLop.SelectedIndexChanged += new System.EventHandler(this.cbxLop_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 21);
            this.label9.TabIndex = 1212163;
            this.label9.Text = "Tên Lớp";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(375, 368);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 27);
            this.btnThoat.TabIndex = 1212159;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XinchaoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(470, 24);
            this.menuStrip1.TabIndex = 1212165;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // XinchaoToolStripMenuItem
            // 
            this.XinchaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.XinchaoToolStripMenuItem.Name = "XinchaoToolStripMenuItem";
            this.XinchaoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.XinchaoToolStripMenuItem.Text = "Xin chào";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
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
            // frmGVRieng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 404);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDanhsachSVtheoLop);
            this.Controls.Add(this.cbxLop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGVRieng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giảng Viên";
            this.Load += new System.EventHandler(this.frmGVRieng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachSVtheoLop)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhsachSVtheoLop;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem XinchaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQuaTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCuoiKi;
    }
}