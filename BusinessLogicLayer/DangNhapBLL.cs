using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DangNhapBLL
    {
        DAL dal = DAL.getDbInstance();
        //Hàm đăng nhập

        public DataSet DangNhap(ref string er, string TenTaiKhoan, string MatKhau)
        {
            dal.GetDBConnection();
            return dal.ExecuteQueryDataSet("spDangNhap", CommandType.StoredProcedure, ref er,
                new SqlParameter("@TenTaiKhoan", TenTaiKhoan), new SqlParameter("@MatKhau", MatKhau));
        }
    }
}
