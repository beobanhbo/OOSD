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
    public partial class frmSinhVienTheoLop : Form
    {
        string error;
        public int idlop;
        int tongsinhvien = 0;
        SinhVienBLL sinhvienBLL;
        DataSet ds,dssv;
        Form f;
        public frmSinhVienTheoLop(Form f)
        {
            this.f = f;
            sinhvienBLL = new SinhVienBLL();
            ds = new DataSet();
            dssv = new DataSet();
            InitializeComponent();
        }    

        private void frmSinhVienTheoLop_Load(object sender, EventArgs e)
        {
            load();
            
        }
        void load()
        {
            try
            {
                ds = sinhvienBLL.DSSVIDlop(ref error, idlop);
                dgvDanhsachSVtheoLop.DataSource = ds.Tables[0];
                dssv = sinhvienBLL.DSSV(ref error);
                cbxSV.DataSource = dssv.Tables[0];
                cbxSV.DisplayMember = "TenSV";
                cbxSV.ValueMember = "IDSV";
                dong();
                tongsinhvien = dgvDanhsachSVtheoLop.Rows.Count - 1;
            }
            catch (Exception)
            {

                throw;
            }
        }
       

        void dong()
        {
            cbxSV.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            

        }
        void mo()
        {
            cbxSV.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnThoat.Enabled = false;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            mo();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int idsv = Convert.ToInt32(cbxSV.SelectedValue.ToString());
                bool kt = sinhvienBLL.ThemSinhVienVaoLop(ref error, idsv, idlop);
                if(kt)
                {
                    MessageBox.Show("Thêm thành công !!!", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    load();

                }else
                {

                    MessageBox.Show("Thêm thất bại !!!", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi! Thêm thất bại !!!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            dong();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dong();
        }

        private void dgvDanhsachSVtheoLop_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
            if (tongsinhvien>e.RowIndex)
            {
                try
                {
                    int idsv = Convert.ToInt32(dgvDanhsachSVtheoLop.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int column = e.ColumnIndex;
                    string giatri = dgvDanhsachSVtheoLop.Rows[e.RowIndex].Cells[column].Value.ToString().Trim();
                    double dqt = 0;
                    double dck = 0;
                    if (giatri != "")
                        try
                        {
                            dqt = Convert.ToDouble(dgvDanhsachSVtheoLop.Rows[e.RowIndex].Cells[2].Value.ToString());
                            dck = Convert.ToDouble(dgvDanhsachSVtheoLop.Rows[e.RowIndex].Cells[3].Value.ToString());

                            if (dqt < 0)
                            {
                                dqt = 0;
                            }
                            if (dqt > 10)
                                {
                                    dqt = 10;
                                }
                            if (dck < 0)
                            {
                                dck = 0;
                            }
                            if (dck > 10)
                                {
                                    dck = 10;
                                }
                            bool kt=sinhvienBLL.CapNhapDiem(ref error, idsv, idlop, dqt, dck);
                          
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Vui lòng nhập lại dữ liệu", "Lỗi",
                                                      MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    else
                    {
                        dgvDanhsachSVtheoLop.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng nhập lại dữ liệu", "Lỗi",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Bạn đi xa quá rồi", "Lỗi",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                load();
            }
        }

        private void cbxSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhsachSVtheoLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Show();
        }
    }
}
