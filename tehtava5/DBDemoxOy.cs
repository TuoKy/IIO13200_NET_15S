using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class DBDemoxOy
    {
      
        public static DataTable getDataReal(string connStr)
        {
            try
            {
                string sql;
                sql = "SELECT * FROM lasnaolot";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    //avataan yhteys
                    conn.Open();
                    //luodaan komento = command-olio
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "lasnaolot");
                        return ds.Tables["lasnaolot"];                        
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getDataRealById(string connStr, string id)
        {
            try
            {
                string sql;
                sql = "SELECT * FROM lasnaolot WHERE asioid = @id;";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    //avataan yhteys
                    conn.Open();
                    //luodaan komento = command-olio
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "lasnaolot");
                        return ds.Tables["lasnaolot"];
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}

