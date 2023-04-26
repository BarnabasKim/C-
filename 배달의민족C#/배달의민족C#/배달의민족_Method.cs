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

        string result;
        public string AddFoodItem(String COOK_NAME, int COOK_PRICE, int COOK_COUNT, String COOK_CODE)
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

                    // SqlDataAdapter를 이용해 결과 데이터를 DataSet으로 가져옴
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    adapter.Fill(ds);

                    // 결과 데이터의 첫번째 테이블을 가져옴
                    DataTable dt = ds.Tables[0];

                    DataRow dataRow = dt.Rows[0];
                    result = dataRow["BCR_FORM"].ToString();


                    string COOK_NAME_CODE = cmd.Parameters["@COOK_NAME_CODE"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("데이터베이스 연결 실패: " + ex.Message);

            }
            return result;

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


        public bool UpdatePrice(string COOK_NAME_CODE, int COOK_PRICE, int COOK_COUNT)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {

                    // 저장 프로시저 생성
                    SqlCommand cmd = new SqlCommand("SP_KDW_FOOD_UPDATE", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // 저장 프로시저의 매개변수 설정
                    cmd.Parameters.Add(new SqlParameter("@COOK_PRICE", COOK_PRICE));
                    cmd.Parameters.Add(new SqlParameter("@COOK_NAME_CODE", COOK_NAME_CODE));
                    cmd.Parameters.Add(new SqlParameter("@COOK_COUNT", COOK_COUNT));


                    connect.Open();


                    // SqlCommand 객체를 실행하여 반환된 결과의 행 수를 반환
                    int result = cmd.ExecuteNonQuery();

                    // 행이 한 개 이상이면 true 반환, 아니면 false 반환
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


        public DataTable searchData(string SearchItem)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_KDW_FOOD_SEARCH", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("SearchItem", SearchItem));

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



    }
}
