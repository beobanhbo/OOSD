using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL
    {
        SqlCommand cmd;
        SqlDataAdapter adp;

        private static DAL dbInstance;
        private readonly SqlConnection cnn = new SqlConnection(@"Data Source=(local);Initial Catalog=OOSDQLSV;Integrated Security=True");


        public static DAL getDbInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new DAL();
            }
            return dbInstance;
        }
        public SqlConnection GetDBConnection()
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();

                cmd = cnn.CreateCommand();

            }
            catch (Exception)
            {

            }

            return cnn;
        }
   
        private DAL()
        {

        }
        //Hàm trả về kiểu dữ liệu là dataset
        public DataSet ExecuteQueryDataSet(string StrSql, CommandType ct,
            ref string error, params SqlParameter[] param)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = StrSql;
                cmd.CommandType = ct;

                if (param != null)
                {
                    foreach (SqlParameter p in param)
                    {
                        cmd.Parameters.Add(p);
                    }
                }

                adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                cnn.Close();
                return ds;
            }
            catch (SqlException e)
            {
                error = e.Message;
            }
            return null;
        }

        public bool MyExecuteNonQuery(string StrSql, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = StrSql;
                cmd.CommandType = ct;

                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                if (param != null)
                {
                    foreach (SqlParameter p in param)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException e)
            {
                error = e.Message;
            }
            finally
            {
                cnn.Close();

            }
            return f;
        }
        
    }
}
