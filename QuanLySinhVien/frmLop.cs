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
    public partial class frmLop : Form
    {
        string error;
        LopBLL lopBLL;
        GiangVienBLL giangVienBLL;
        MonHocBLL monHocBLL;
        DataSet dslop,dsmh,dsgv;
        Form f;
        public frmLop(Form f)
        {
            this.f = f;
            lopBLL = new LopBLL();
            giangVienBLL = new GiangVienBLL();
            monHocBLL = new MonHocBLL();



            dslop = new DataSet();
            dsmh = new DataSet();
            dsgv = new DataSet();
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            try
            {
                dslop = lopBLL.DSLop(ref error);
               
                dgvDanhsachLop.DataSource = dslop.Tables[0];

                dsgv = giangVienBLL.DSGV(ref error);
                cbxGV.DataSource = dsgv.Tables[0];
                cbxGV.DisplayMember = "TenGV";
                cbxGV.ValueMember = "IDGV";

                dsmh = monHocBLL.DSMH(ref error);
                cbxMH.DataSource = dsmh.Tables[0];
                cbxMH.DisplayMember = "TenMH";
                cbxMH.ValueMember = "IDMH";
                dong();

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi load !!!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }
        void mo()
        {
            pnThongtin.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnThoat.Enabled = false;
            dgvDanhsachLop.Enabled = false;
        }
        void dong()
        {
            pnThongtin.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            txtTen.ResetText();
            dgvDanhsachLop.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            mo();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtTen.Text.Trim();
                int idgv = Convert.ToInt32(cbxGV.SelectedValue.ToString());
                string idmh = cbxMH.SelectedValue.ToString();
                if (ten != "")
                {
                    bool kt=lopBLL.ThemLop(ref error, ten, idgv, idmh);
                    if (kt)
                    {
                        MessageBox.Show("Bạn đã thêm thành công !!!", "Thông báo",
                             MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                        load();
                    }
                }
                else
                {
                    MessageBox.Show("Nhập tên lớp !!!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Thêm !!!", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            dong();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Show();
        }


  
        private void dgvDanhsachLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                frmSinhVienTheoLop frm = new frmSinhVienTheoLop(this);
                
                frm.idlop = Convert.ToInt32(dgvDanhsachLop.Rows[numrow].Cells["IDLop"].Value.ToString());
                this.Hide();
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Click không hợp lệ !!!", "Thông báo",
                                             MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
