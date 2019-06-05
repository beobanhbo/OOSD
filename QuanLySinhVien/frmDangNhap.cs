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
    public partial class frmDangNhap : Form
    {
        DangNhapBLL dnbll;
        DataSet ds;
        string error;
        public frmDangNhap()
        {
            dnbll = new DangNhapBLL();
            ds = new DataSet();
            InitializeComponent();
            txtTenDangNhap.Text = Properties.Settings.Default.user;
            txtMatKhau.Text = Properties.Settings.Default.pass;
            ckbMatKhau.Checked = Properties.Settings.Default.check;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtTenDangNhap.Text.ToString().Trim();
                string password = txtMatKhau.Text.ToString().Trim();
                if (string.IsNullOrEmpty(user))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập !!!", "Lỗi",
                 MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtTenDangNhap.ResetText();
                    txtTenDangNhap.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu !!!", "Lỗi",
                     MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtMatKhau.ResetText();
                        txtMatKhau.Focus();
                    }
                    else
                    {
                        CheckQuyen proxy = new ProxyQuyen();
                        ds = dnbll.DangNhap(ref error, txtTenDangNhap.Text, txtMatKhau.Text);
                        // kiểm tra tài khoản có tồn tại không
                        int kt = ds.Tables[0].Rows.Count;
                        if (kt > 0)
                        {
                            if (ckbMatKhau.Checked == true)
                            {
                                Properties.Settings.Default.user = user;
                                Properties.Settings.Default.pass = password;
                                Properties.Settings.Default.check = true;
                                Properties.Settings.Default.Save();
                            }
                            else
                            {
                                Properties.Settings.Default.user = "";
                                Properties.Settings.Default.pass = "";
                                Properties.Settings.Default.check = false;
                                Properties.Settings.Default.Save();
                            }
                            int quyen = Convert.ToInt32(ds.Tables[0].Rows[0]["Quyen"].ToString());
                            int a = proxy.KiemtraAdmin(quyen);
                            if (a == 1)
                            {
                               
                                frmTrangChu frmTrangChu = new frmTrangChu(this);
                                this.Hide();
                                frmTrangChu.tentaikhoan = txtTenDangNhap.Text;
                                frmTrangChu.matkhau = txtMatKhau.Text;
                                frmTrangChu.ShowDialog();

                               
                            }
                            else
                            {
                                if(a==2)
                                {
                                    frmGVRieng frmRieng = new frmGVRieng(this);
                                    frmRieng.tentaikhoan = txtTenDangNhap.Text;
                                    frmRieng.matkhau = txtMatKhau.Text;
                                    this.Hide();
                                    frmRieng.Show();
                                }else
                                {
                                    MessageBox.Show("Bạn đã hết quyền đăng nhập !!!", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                    txtTenDangNhap.ResetText();
                                    txtMatKhau.ResetText();
                                    txtTenDangNhap.Focus();
                                }

                            }
                             txtTenDangNhap.ResetText();
                                txtMatKhau.ResetText();
                                ckbMatKhau.Checked = false;
                                txtTenDangNhap.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !!!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            txtTenDangNhap.ResetText();
                            txtMatKhau.ResetText();
                            txtTenDangNhap.Focus();

                        }

                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi !!!", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có thực sự muốn thoát không??", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (tl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
