using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class GiangVienBLL
    {

        DAL dal = DAL.getDbInstance();
        //Danh sách giảng viên

        public DataSet DSGV(ref string error)
        {
            dal.GetDBConnection();
            return dal.ExecuteQueryDataSet("spDSGV", CommandType.StoredProcedure, ref error);

        }

        //Đổi mật khẩu

        public bool DoiMK(ref string error, string TenTaiKhoan, string MatKhau, string MatKhauMoi)
        {
            dal.GetDBConnection();
            return dal.MyExecuteNonQuery("spDoiMK", CommandType.StoredProcedure, ref error, new SqlParameter("@TenTaiKhoan", TenTaiKhoan)
                , new SqlParameter("@MatKhau", MatKhau), new SqlParameter("@MatKhauMoi", MatKhauMoi));
        }
    }
}
