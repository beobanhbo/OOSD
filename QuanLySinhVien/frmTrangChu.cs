using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmTrangChu : Form
    {
        public string tentaikhoan, matkhau;
        Form f;
        public frmTrangChu(Form f)
        {
            this.f = f;
            InitializeComponent();
        }

      

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien frmSinhVien = new frmSinhVien();
            this.Hide();
            frmSinhVien.f = this;
            frmSinhVien.Show();
        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop frmLop = new frmLop(this);
            this.Hide();
            frmLop.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có thực sự muốn đăng xuất không??", "Thông báo", MessageBoxButtons.YesNo,
              MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (tl == DialogResult.Yes)
            {
                dangxuat();
            }
        }
        public void dangxuat()
        {
            Properties.Settings.Default.user = "";
            Properties.Settings.Default.pass = "";
            Properties.Settings.Default.check = false;
            Properties.Settings.Default.Save();
            this.Close();
            f.Show();
        }

        private void danhSáchGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiangVien giangVien = new frmGiangVien();
            //this.Hide();
            giangVien.Show();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Xin chào " + tentaikhoan;
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.f1 = this;
            f.matkhau = matkhau;
            f.tentaikhoan = tentaikhoan;
            f.Show();
        }
    }
}
