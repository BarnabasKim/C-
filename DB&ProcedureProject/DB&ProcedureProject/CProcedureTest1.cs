﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_ProcedureProject
{
    internal class CProcedureTest1
    {


        string connectionString = "Data Source=tobesystem.co.kr,19813;Initial Catalog=EXAMPLE_DONG;User ID=donguser; Password=dongpwd12#";
        DataTable dataTable = new DataTable();

        public cTestList GetFoodKategorie(string COOK_CODE, string COOK_KATEGORIE)
        {
            cTestList list = new cTestList();
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_KDW_FOOD_GET_COMBO", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("COOK_CODE", COOK_CODE));
                    cmd.Parameters.Add(new SqlParameter("COOK_KATEGORIE", COOK_KATEGORIE));

                    connect.Open();


                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    adapter.Fill(ds);

                    DataTable dt = ds.Tables[0];


                    list.Add(new cTestItem1
                    {
                        COOK_CODE = COOK_CODE,
                        COOK_KATEGORIE = "전체",
                    });



                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add(new cTestItem1
                        {
                            COOK_CODE = row["COOK_CODE"].ToString(),
                            COOK_KATEGORIE = row["COOK_KATEGORIE"].ToString()
                    });
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine("데이터베이스 연결 실패: " + ex.Message);
            }
            return list;
        }


        public DataTable GetCookList(string category)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_KDW_FOOD_GET", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("category", category));

                    connect.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    
         /*           DataColumn COOK_NAME_CODE = new DataColumn("COOK_NAME_CODE");
                    dt.Columns.Add(COOK_NAME_CODE);*/
                    
                    adapter.Fill(dt);

                    return dt;


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("데이터베이스 연결 실패: " + ex.Message);
                return null;
            }
        }

        public bool UpdatePrice(string COOK_NAME_CODE, int COOK_PRICE)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_KDW_FOOD_UPDATE", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("COOK_NAME_CODE", COOK_NAME_CODE));
                    cmd.Parameters.Add(new SqlParameter("COOK_PRICE", COOK_PRICE));

                    connect.Open();

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("데이터베이스 연결 실패: " + ex.Message);
                return false;
            }
        }




 




    }
}
