namespace QuanLySinhVien
{
    partial class frmGiangVien
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
            this.cbxTimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhsachGV = new System.Windows.Forms.DataGridView();
            this.IDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTimKiem
            // 
            this.cbxTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimKiem.FormattingEnabled = true;
            this.cbxTimKiem.Items.AddRange(new object[] {
            "IDGV",
            "Tên"});
            this.cbxTimKiem.Location = new System.Drawing.Point(235, 16);
            this.cbxTimKiem.Name = "cbxTimKiem";
            this.cbxTimKiem.Size = new System.Drawing.Size(74, 27);
            this.cbxTimKiem.TabIndex = 1212155;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 1212154;
            this.label1.Text = "Tìm kiếm";
            // 
            // dgvDanhsachGV
            // 
            this.dgvDanhsachGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDGV,
            this.TenGV,
            this.DiaChi,
            this.SoDienThoai,
            this.Email});
            this.dgvDanhsachGV.Location = new System.Drawing.Point(11, 48);
            this.dgvDanhsachGV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhsachGV.Name = "dgvDanhsachGV";
            this.dgvDanhsachGV.ReadOnly = true;
            this.dgvDanhsachGV.RowTemplate.Height = 24;
            this.dgvDanhsachGV.Size = new System.Drawing.Size(653, 251);
            this.dgvDanhsachGV.TabIndex = 1212153;
            // 
            // IDGV
            // 
            this.IDGV.DataPropertyName = "IDGV";
            this.IDGV.HeaderText = "IDGV";
            this.IDGV.Name = "IDGV";
            this.IDGV.ReadOnly = true;
            this.IDGV.Width = 50;
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên GV";
            this.TenGV.Name = "TenGV";
            this.TenGV.ReadOnly = true;
            this.TenGV.Width = 160;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 120;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 180;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(116, 16);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(113, 26);
            this.txtTimKiem.TabIndex = 1212146;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 312);
            this.Controls.Add(this.cbxTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhsachGV);
            this.Controls.Add(this.txtTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giảng Viên";
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhsachGV;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}