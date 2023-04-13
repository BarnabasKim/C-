using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormDBTest2.cItem;

namespace WinFormDBTest2
{
    internal class cData
    {
        string connectionString = "Data Source=tobesystem.co.kr,19813;Initial Catalog=EXAMPLE_DONG;User ID=donguser; Password=dongpwd12#";

        public cTestList GetTradingList(string StartDate, string StopDate, string SuppCode)
        {
            cTestList list = new cTestList();

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_SCM_TRADING_GET2", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("START_DATE", StartDate));
                    cmd.Parameters.Add(new SqlParameter("STOP_DATE", StopDate));
                    cmd.Parameters.Add(new SqlParameter("SUPP_CODE", SuppCode));

                    connect.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    adapter.Fill(ds);

                    DataTable dt = ds.Tables[0];

                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add(new cTestItem
                        {
                            WORK_DATE = row["WORK_DATE"].ToString(),
                            SUPP_NAME = row["SUPP_NAME"].ToString(), 
                        });
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return list;
        }
    }
}
