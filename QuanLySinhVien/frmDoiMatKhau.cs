using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace QuanLySinhVien
{
    public partial class frmDoiMatKhau : Form
    {
        string error;
        public frmTrangChu f1;
        public frmGVRieng f2;
        public string matkhau, tentaikhoan;
        GiangVienBLL giangVienBLL;
        public frmDoiMatKhau()
        {
            giangVienBLL = new GiangVienBLL();
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string mkcu = txtMKC.Text.Trim();
            string mkmoi = txtMKM.Text.Trim();
            string mknl = txtNL.Text.Trim();
            if (mkmoi != mknl)
            {
                MessageBox.Show("Mật khẩu không trùng nhập lại !!", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtMKM.ResetText();
                txtNL.ResetText();
                txtMKM.Focus();
            }
            else
            {
                if (matkhau != mkcu)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng !!", "Lỗi", MessageBoxButtons.OK,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtMKC.ResetText();
                    txtMKM.ResetText();
                    txtNL.ResetText();
                    txtMKC.Focus();

                }
                else
                {
                    if (mkmoi.Length < 8)
                    {

                        MessageBox.Show("Vui lòng nhập mật khẩu có từ 8 kí tự trở lên !!", "Thông báo", MessageBoxButtons.OK,
                       MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        bool kt = giangVienBLL.DoiMK(ref error, tentaikhoan, mkcu, mkmoi);
                        if (kt)
                        {
                            MessageBox.Show("Đổi thành công !!", "Thông báo", MessageBoxButtons.OK,
                             MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                            this.Close();
                            if(tentaikhoan=="Admin")
                            f1.dangxuat();
                            else
                            {
                                f2.dangxuat();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thất bại !!", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                }
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
