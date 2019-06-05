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
    public class LopBLL
    {
        DAL dal = DAL.getDbInstance();
        //Danh sách tất cả các lớp

        public DataSet DSLop(ref string error)
        {
            dal.GetDBConnection();
            return dal.ExecuteQueryDataSet("spDSLop", CommandType.StoredProcedure,ref error);
                
        }


        //Thêm lớp

        public bool ThemLop(ref string error,string TenLop,int IDGV,string IDMH)
        {
            dal.GetDBConnection();
            return dal.MyExecuteNonQuery("spThemLop", CommandType.StoredProcedure, ref error,
                new SqlParameter("@TenLop",TenLop),new SqlParameter("@IDGV",IDGV),new SqlParameter("@IDMH",IDMH));

        }


        //--danh sách lớp theo giảng viên


        public DataSet DSLopTheoGV(ref string error,int IDGV)
        {
            dal.GetDBConnection();
            return dal.ExecuteQueryDataSet("spDSLopTheoGiangVien", CommandType.StoredProcedure, ref error,
                new SqlParameter("@IDGV",IDGV));

        }

        //--IDGV giảng viên


        public DataSet IDGV(ref string error, string TenTaiKhoan)
        {
            dal.GetDBConnection();
            return dal.ExecuteQueryDataSet("spIDGV", CommandType.StoredProcedure, ref error,
                new SqlParameter("@TenTaiKhoan", TenTaiKhoan));

        }


    }
}
