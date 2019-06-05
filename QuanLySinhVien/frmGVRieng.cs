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
    public partial class frmGVRieng : Form
    {
        LopBLL lopbll ;
        SinhVienBLL sinhVienbll;
        DataSet dssinhvien, dslop,dsidgv;
        public string tentaikhoan,matkhau;

        int tongsinhvien = 0;
        int idlop = 0;

        string error;
        Form f;
        public frmGVRieng(Form f)
        {
            sinhVienbll = new SinhVienBLL();
            lopbll = new LopBLL();
            dssinhvien = new DataSet();
            dslop = new DataSet();
            dsidgv = new DataSet();
            this.f = f;
            InitializeComponent();
        }

        private void frmGVRieng_Load(object sender, EventArgs e)
        {
            this.XinchaoToolStripMenuItem.Text = "Xin chào " + tentaikhoan;
            load();
        }
        void load()
        {
            try
            {
               
                dsidgv = lopbll.IDGV(ref error, tentaikhoan);
                int idgv = Convert.ToInt32(dsidgv.Tables[0].Rows[0]["IDGV"].ToString());

                dslop = lopbll.DSLopTheoGV(ref error, idgv);
                cbxLop.DataSource = dslop.Tables[0];
                cbxLop.DisplayMember = "TenLop";
                cbxLop.ValueMember = "IDLop";
                cbxLop.SelectedIndex = 0;
                

                hienthidata();

            }
            catch (Exception)
            {

                DialogResult tl = MessageBox.Show("Lỗi load", "Lỗi", MessageBoxButtons.OK,
             MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

       void  hienthidata()
        {
          try
            {
                string a = cbxLop.SelectedValue.ToString();
                idlop = Convert.ToInt32(a);

                dssinhvien = sinhVienbll.DSSVIDlop(ref error, idlop);
                dgvDanhsachSVtheoLop.DataSource = dssinhvien.Tables[0];

                tongsinhvien = dssinhvien.Tables[0].Rows.Count;
            }catch
            {

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            hienthidata();
        }

        private void dgvDanhsachSVtheoLop_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (tongsinhvien > e.RowIndex)
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
                            bool kt = sinhVienbll.CapNhapDiem(ref error, idsv, idlop, dqt, dck);

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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.f2 = this;
            f.matkhau = matkhau;
            f.tentaikhoan = tentaikhoan;
            f.Show();
        }
    }
}
