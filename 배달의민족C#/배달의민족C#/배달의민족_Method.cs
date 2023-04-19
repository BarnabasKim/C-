using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배달의민족C_
{
    internal class 배달의민족_Method
    {
        string connectionString = "Data Source=tobesystem.co.kr,19813;Initial Catalog=EXAMPLE_DONG;User ID=donguser; Password=dongpwd12#";

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

                    // SqlDataAdapter를 이용해 결과 데이터를 DataSet으로 가져옴
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    adapter.Fill(ds);

                    // 결과 데이터의 첫번째 테이블을 가져옴
                    DataTable dt = ds.Tables[0];

                    // 리스트에 전체 카테고리 항목 추가
                    list.Add(new cTestItem1
                    {
                        COOK_CODE = COOK_CODE,
                        COOK_KATEGORIE = "전체",
                    });


                    // 결과 데이터에서 DataRow를 순회하며 리스트에 항목 추가
                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add(new cTestItem1
                        {
                            COOK_CODE = row["COOK_CODE"].ToString(),
                            COOK_KATEGORIE = row["COOK_KATEGORIE"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("데이터베이스 연결 실패: " + ex.Message);
            }
            return list;
        }


        public void AddFoodItem(String COOK_NAME, int COOK_PRICE, int COOK_COUNT, String COOK_CODE)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_KDW_FOOD_ADD", connect);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add(new SqlParameter("COOK_NAME", COOK_NAME));
                    cmd.Parameters.Add(new SqlParameter("COOK_PRICE", COOK_PRICE));
                    cmd.Parameters.Add(new SqlParameter("COOK_COUNT", COOK_COUNT));
                    cmd.Parameters.Add(new SqlParameter("COOK_CODE", COOK_CODE));

                    connect.Open();
                    cmd.ExecuteNonQuery();
                    string COOK_NAME_CODE = cmd.Parameters["@COOK_NAME_CODE"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("데이터베이스 연결 실패: " + ex.Message);

            }
        }



        public DataTable GetCookList(string category)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_KDW_FOOD_GET_TEST", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("category", category));

                    connect.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();


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


        public void DeleteFoodItem(string COOK_NAME, string COOK_COUNT)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_KDW_FOOD_DELETE", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("COOK_NAME", COOK_NAME));
                    cmd.Parameters.Add(new SqlParameter("COOK_COUNT", COOK_COUNT));
                    connect.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("데이터베이스 연결 실패: " + ex.Message);
            }
        }






    }
}
