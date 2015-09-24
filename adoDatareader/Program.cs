using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sovellus hakee sql serveriltä DemoxOy-tietokannasta lanaolt-taulusta paskaa
namespace adoDatareader
{
    class Program
    {
        static void Main(string[] args)
        {
            //getData_Datareader();
            getData_Datatable();
        }

        static void getData_Datatable()
        {
            //UI-kerros datan esittämistä varten
            try
            {
                //haetaan DataTablen avulla
                DataTable dt = getDataReal();
                //loopilla mun korvissain rivit läpi
                string rivi = "";

                foreach(DataRow dr in dt.Rows)
                {
                    rivi = "";
                    foreach(DataColumn dc in dt.Columns)
                    {
                        rivi += dr[dc].ToString() + "\t";
                    }
                    Console.WriteLine(rivi);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("homo " + ex.Message);
            }
        }

        static DataTable getDataReal()
        {
            //DBkerros, haetaan DemoxOy-tietokannasta taulun lasnaolot

            try
            {
                string sql;
                sql = "SELECT asioid, lastname, firstname FROM lasnaolot";
                string connStr = @"Data source=eight.labranet.jamk.fi;initial catalog=DemoxOy;user=koodari;password=koodari13";
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

        private static DataTable getDataSimple()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("eNimi", typeof(String));
            dt.Columns.Add("sNimi", typeof(String));

            dt.Rows.Add("hessu", "hopo");
            dt.Rows.Add("mikki", "hiiri");
            return dt;
        }

        static void getData_Datareader(){
            try
            {
                string sql;
                sql = "SELECT asioid, lastname, firstname FROM lasnaolot";
                string connStr = @"Data source=eight.labranet.jamk.fi;initial catalog=DemoxOy;user=koodari;password=koodari13";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    //avataan yhteys
                    conn.Open();
                    //luodaan komento = command-olio
                    using(SqlCommand cmd = new SqlCommand(sql,conn))
                    {
                        //luodaan reader
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            //käydään rdr läpi
                            if (rdr.HasRows)
                            {
                                while (rdr.Read())
                                {
                                    Console.WriteLine("{0}\t{1}\t{2}", rdr.GetString(0), rdr.GetString(1), rdr.GetString(2));
                                }
                            }
                            else
                            {
                                Console.WriteLine("Haista paska");
                            }
                            rdr.Close();
                        }
                    }
                    conn.Close();
                    Console.WriteLine("Kuole syöpään kakkapää");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Haista vittu " + ex.Message);
            }
        }
    }
}
