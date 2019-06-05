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
    public partial class frmGiangVien : Form
    {
        string error;
        GiangVienBLL gvbll;
        DataSet ds;
        public frmGiangVien()
        {
            gvbll = new GiangVienBLL();
            ds = new DataSet();
            InitializeComponent();
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
            ds = gvbll.DSGV(ref error);
            dgvDanhsachGV.DataSource = ds.Tables[0];
            cbxTimKiem.SelectedIndex = 0;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //Kiểm tra xem có lọc được hay không
            bool kt = false;
            DataView dv = null;
            try
            {
                if (cbxTimKiem.Text == "IDGV")
                {
                    if (txtTimKiem.Text.Trim() != "")
                    {
                        try
                        {
                            int idsv = Convert.ToInt32(txtTimKiem.Text);

                            dv = new DataView(ds.Tables[0], "IDGV = " + idsv, "IDGV Desc", DataViewRowState.CurrentRows);
                            dgvDanhsachGV.DataSource = dv;

                            kt = true;
                        }
                        catch
                        {
                            dgvDanhsachGV.DataSource = ds.Tables[0];

                        }
                    }
                    else
                    {
                        dgvDanhsachGV.DataSource = ds.Tables[0];
                    }
                }
                else
                {
                    if (txtTimKiem.Text.Trim() != "")
                    {

                        dv = new DataView(ds.Tables[0], "TenGV LIKE '% " + txtTimKiem.Text + "%'", "IDGV Desc", DataViewRowState.CurrentRows);
                        dgvDanhsachGV.DataSource = dv;
                        //string filterField = "TenSV";
                        //ds.Tables[0].DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, txtTimKiem.Text);
                        kt = true;
                    }
                    else
                    {
                        dgvDanhsachGV.DataSource = ds.Tables[0];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm rồi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
               
            }
        }


    }
}
