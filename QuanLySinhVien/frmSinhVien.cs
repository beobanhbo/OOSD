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
    public partial class frmSinhVien : Form
    {
        bool them = false; //xác nhận xem là thêm hay sửa
        SinhVienBLL sinhVienBLL;
        DataSet dsSV;
        string error;
        public frmTrangChu f;
        public frmSinhVien()
        {
            sinhVienBLL = new SinhVienBLL();
            dsSV = new DataSet();
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            loaddata();
            
        }

        void loaddata()
        {
            try
            {
                dsSV = sinhVienBLL.DSSV(ref error);

                dgvDanhsachSV.DataSource = dsSV.Tables[0];
                cbxTimKiem.SelectedIndex = 0;
                databiding();
                dgvDanhsachSV.Enabled = true;
                dong();
            }
            catch
            {
                MessageBox.Show("Lỗi load", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        //databiding theo dataset
        void databiding()
        {
            try
            {

                txtIDSV.DataBindings.Clear();
                txtTen.DataBindings.Clear();
                txtDiaChi.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtSDT.DataBindings.Clear();

                txtIDSV.DataBindings.Add("text", dsSV.Tables[0], "IDSV", true, DataSourceUpdateMode.Never);
                txtTen.DataBindings.Add("text", dsSV.Tables[0], "TenSV", true, DataSourceUpdateMode.Never);
                txtDiaChi.DataBindings.Add("text", dsSV.Tables[0], "DiaChi", true, DataSourceUpdateMode.Never);
                txtEmail.DataBindings.Add("text", dsSV.Tables[0], "Email", true, DataSourceUpdateMode.Never);
                txtSDT.DataBindings.Add("text", dsSV.Tables[0], "SoDienThoai", true, DataSourceUpdateMode.Never);
            } catch
            {
                MessageBox.Show("Lỗi databiding", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        //databiding theo dataview
        void databiding(DataView dv)
        {
            try
            {

                txtIDSV.DataBindings.Clear();
                txtTen.DataBindings.Clear();
                txtDiaChi.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtSDT.DataBindings.Clear();

                txtIDSV.DataBindings.Add("text", dv, "IDSV", true, DataSourceUpdateMode.Never);
                txtTen.DataBindings.Add("text", dv, "TenSV", true, DataSourceUpdateMode.Never);
                txtDiaChi.DataBindings.Add("text", dv, "DiaChi", true, DataSourceUpdateMode.Never);
                txtEmail.DataBindings.Add("text",dv, "Email", true, DataSourceUpdateMode.Never);
                txtSDT.DataBindings.Add("text", dv, "SoDienThoai", true, DataSourceUpdateMode.Never);
            }
            catch
            {
                MessageBox.Show("Lỗi databiding view", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //Kiểm tra xem có lọc được hay không
            bool kt = false;
            DataView dv = null ;
            try
            {
                if (cbxTimKiem.Text == "IDSV")
                {
                    if (txtTimKiem.Text.Trim() != "")
                    {
                        try
                        {
                            ContextClass context = new ContextClass(new TimSVTheoMSSV());

                            dv = new DataView(dsSV.Tables[0], context.TimKiemTheoTuKhoa(txtTimKiem.Text), "IDSV Desc", DataViewRowState.CurrentRows);
                            dgvDanhsachSV.DataSource = dv;

                            kt = true;
                        }
                        catch
                        {
                            dgvDanhsachSV.DataSource = dsSV.Tables[0];
                            
                        }
                    }
                    else
                    {
                        dgvDanhsachSV.DataSource = dsSV.Tables[0];
                    }
                }
                else
                {
                    if (txtTimKiem.Text.Trim() != "")
                    {
                        ContextClass context = new ContextClass(new TImSVTheoTen());
                        dv = new DataView(dsSV.Tables[0], context.TimKiemTheoTuKhoa(txtTimKiem.Text), "IDSV Desc", DataViewRowState.CurrentRows);
                        dgvDanhsachSV.DataSource = dv;
                        //string filterField = "TenSV";
                        //ds.Tables[0].DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, txtTimKiem.Text);
                        kt = true;
                    }
                    else
                    {
                        dgvDanhsachSV.DataSource = dsSV.Tables[0];
                    }
                }
            }catch
            {
                MessageBox.Show("Lỗi tìm kiếm rồi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }finally
            {
                if(dgvDanhsachSV.Rows.Count>1)
                {
                    if (kt)
                    {
                        databiding(dv);
                    }
                    else
                    {
                        databiding();
                    }
                }
                else
                {
                    reset();
                }
                dong();
               
            }
           
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Show();
        }
       
        /// <summary>
        /// Reset lại tất cả các textbox
        /// </summary>
        void reset()
        {
            txtIDSV.ResetText();
            txtTen.ResetText();
            txtDiaChi.ResetText();
            txtEmail.ResetText();
            txtSDT.ResetText();
        }
        /// <summary>
        /// disable 1 số control
        /// </summary>
        void dong()
        {
            pnThongtin.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
            txtTimKiem.Enabled = true;
        }

        /// <summary>
        /// enable 1 số control
        /// </summary>
        void mo()
        {
            pnThongtin.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            reset();
           
            dgvDanhsachSV.Enabled = false;
            txtTen.Enabled = true;
            mo();
            txtTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            mo();
            txtTen.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool kt = false;
                string diachi = txtDiaChi.Text.Trim();
                string email = txtEmail.Text.Trim();
                string sodienthoai = txtSDT.Text.Trim();
                if (them)
                {
                    string tensv = txtTen.Text.Trim();
                  if(tensv!="")
                    {
                        kt = sinhVienBLL.ThemSinhVien(ref error, tensv, diachi, email, sodienthoai);
                        if (kt)
                        {
                            MessageBox.Show("Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        dong();
                        loaddata();

                    }
                    else
                    {
                        MessageBox.Show("Tên sinh viên không được bỏ trống ", "Thông báo", MessageBoxButtons.OK,
                               MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        txtTen.Focus();
                    }

                }
                else
                {
                    int idnv = Convert.ToInt32(txtIDSV.Text);
                    kt = sinhVienBLL.SuaSinhVien(ref error, idnv,diachi, email, sodienthoai);
                    if (kt)
                    {
                        MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    }
                    dong();
                    loaddata();
                }
                
            }
            catch (Exception)
            {
                this.Close();
                f.Show();
                MessageBox.Show("LỖI", "Lỗi", MessageBoxButtons.OK,
                          MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            pnThongtin.Enabled = false;
            databiding();
            dong();
            dgvDanhsachSV.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult tl = MessageBox.Show("Bạn có thật sự muốn xóa", "Thông báo", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (tl == DialogResult.Yes)
                {
                    int idnv = Convert.ToInt32(txtIDSV.Text);
                    bool kt = sinhVienBLL.XoaSinhVien(ref error, idnv);
                    if (kt)
                    {
                        MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK,
                             MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK,
                              MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    loaddata();
                }
            }
            catch (Exception)
            {
                this.Close();
                f.Show();
                MessageBox.Show("Lỗi xóa sinh viên", "Lỗi", MessageBoxButtons.OK,
                             MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
