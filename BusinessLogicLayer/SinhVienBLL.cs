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
   public class SinhVienBLL
    {
        DAL dal = DAL.getDbInstance();

        //Load danh sách sinh viên

        public DataSet DSSV(ref string error)
        {
            dal.GetDBConnection();
            return dal.ExecuteQueryDataSet("spDanhSachSinhVien", CommandType.StoredProcedure, ref error);
        }


        //Load danh sách sinh viên theo id lớp

        public DataSet DSSVIDlop(ref string error,int IDLop)
        {
            dal.GetDBConnection();
            return dal.ExecuteQueryDataSet("spDSSVTheoMaLop", CommandType.StoredProcedure, ref error,new SqlParameter("@IDLop",IDLop));
        }

        //Thêm sinh viên

        public bool ThemSinhVien(ref string error, string TenSV, string DiaChi, string Email, string SoDienThoai)
        {
            dal.GetDBConnection();
            return dal.MyExecuteNonQuery("spThemSV", CommandType.StoredProcedure, ref error,
                new SqlParameter("@TenSV", TenSV), new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@Email", Email), new SqlParameter("@SoDienThoai", SoDienThoai));
        }
        //Sửa sinh viên
        public bool SuaSinhVien(ref string error, int IDSV, string DiaChi, string Email, string SoDienThoai)
        {
            dal.GetDBConnection();
            return dal.MyExecuteNonQuery("spSuaSV", CommandType.StoredProcedure, ref error, new SqlParameter("@IDSV", IDSV),
                new SqlParameter("@DiaChi", DiaChi),new SqlParameter("@Email", Email), 
                new SqlParameter("@SoDienThoai", SoDienThoai));
        }

        // Xóa sinh viên
        public bool XoaSinhVien(ref string error, int IDSV)
        {
            dal.GetDBConnection();
            return dal.MyExecuteNonQuery("spXoaSinhVien", CommandType.StoredProcedure, ref error, new SqlParameter("@IDSV", IDSV));
        }


        // Thêm sinh viên vào lớp
        public bool ThemSinhVienVaoLop(ref string error, int IDSV,int IDLop)
        {
            dal.GetDBConnection();
            return dal.MyExecuteNonQuery("spCapNhapDiemSinhVien", CommandType.StoredProcedure, ref error, 
                new SqlParameter("@IDSV", IDSV), new SqlParameter("@IDLop", IDLop));
        }


        // sửa điểm sinh viên trong lớp
        public bool CapNhapDiem(ref string error, int IDSV, int IDLop,double DiemQuaTrinh,double DiemCuoiKi)
        {
            dal.GetDBConnection();
            return dal.MyExecuteNonQuery("spCapNhapDiemSinhVien", CommandType.StoredProcedure, ref error,
                new SqlParameter("@IDSV", IDSV), new SqlParameter("@IDLop", IDLop),
                new SqlParameter("@DiemQuaTrinh", DiemQuaTrinh), new SqlParameter("@DiemCuoiKi", DiemCuoiKi));
        }
    }
}
