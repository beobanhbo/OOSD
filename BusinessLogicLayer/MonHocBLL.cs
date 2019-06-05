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
    public class MonHocBLL
    {

        DAL dal = DAL.getDbInstance();

        //Danh sách môn học

        public DataSet DSMH(ref string error)
        {
            dal.GetDBConnection();
            return dal.ExecuteQueryDataSet("spDSMH", CommandType.StoredProcedure, ref error);

        }
    }
}
