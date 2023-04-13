using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormDBTest2.cItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace WinFormDBTest2
{
    public partial class Form1 : Form
    {
        cTestList cTestList = new cTestList();
        cData cData = new cData();
        private int currentPage = 1;
        private int pageSize = 4;
        private int _totalPages;

        private List<Button> btns = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            string connectionString = "Data Source=tobesystem.co.kr,19813;Initial Catalog=EXAMPLE_DONG;User ID=donguser; Password=dongpwd12#";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT COOK_CODE, COOK_KATEGORIE FROM COOK_STEP_MAIN";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();


            try
            {
                connection.Open();
                adapter.Fill(dataTable);
                MessageBox.Show("DB 연결에 성공하였습니다.");

                comboBox1.Items.Add("전체");
                comboBox1.SelectedIndex = 0;

                foreach (DataRow row in dataTable.Rows)
                {
                    string category = row["COOK_KATEGORIE"].ToString();

                    comboBox1.Items.Add(category);
                }
            }
            catch ( Exception ex) 
            {
                Console.WriteLine("데이터베이스 연결 실패: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            currentPage = 1;
            Updateitems();
            
        }
        private void Updateitems()
        {
            string connectionString = "Data Source=tobesystem.co.kr,19813;Initial Catalog=EXAMPLE_DONG;User ID=donguser; Password=dongpwd12#";
            SqlConnection connection = new SqlConnection(connectionString);
            string selectedCategory = comboBox1.SelectedItem.ToString();
            string selectedCookCode = "";
            string query = "";



            if (selectedCategory == "전체")
            {
                query = $"SELECT B.COOK_KATEGORIE '종류', A.COOK_NAME '음식', A.COOK_PRICE '가격' FROM COOK_STEP_NAME A " +
                        $"LEFT JOIN COOK_STEP_MAIN B ON A.COOK_CODE = B.COOK_CODE";
            }
            else
            {
                query = $"SELECT COOK_CODE FROM COOK_STEP_MAIN WHERE COOK_KATEGORIE = '{selectedCategory}'";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        selectedCookCode = reader["COOK_CODE"].ToString();
                    }
                }

                query = $"SELECT B.COOK_KATEGORIE '종류', A.COOK_NAME '음식', A.COOK_PRICE '가격' FROM COOK_STEP_NAME A " +
                        $"LEFT JOIN COOK_STEP_MAIN B ON A.COOK_CODE = B.COOK_CODE WHERE B.COOK_CODE = '{selectedCookCode}'";
            }

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }

            dataGridView1.DataSource = dt;


            CreateButtons(dt);

         

            _totalPages = (int)Math.Ceiling((double)dt.Rows.Count / pageSize);

            lblPaging.Text = $"{currentPage} / {_totalPages}";
            

        }

        private void CreateButtons(DataTable dataTable)
        {
            flowLayoutPanel1.Controls.Clear();
            btns.Clear();

            


            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, dataTable.Rows.Count);


            for(int i = startIndex; i < endIndex; i++)
            {
                Button btn = new Button();
                btn.Text = dataTable.Rows[i]["음식"].ToString();
                btn.BackColor = Color.Blue;
                btn.ForeColor = Color.White;
                btn.Font = new Font("굴림", 15);
                btn.Size = new Size(110, 50);

                btn.Click += new EventHandler(CreatedButtonClick_Event);

                btns.Add(btn);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < _totalPages)
            {
                currentPage++;

                Updateitems();
            }
        }

        private void btnBackPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;

                Updateitems();
            }
        }


        private void CreatedButtonClick_Event(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            string connectionString = "Data Source=tobesystem.co.kr,19813;Initial Catalog=EXAMPLE_DONG;User ID=donguser; Password=dongpwd12#";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = $"SELECT COOK_PRICE FROM COOK_STEP_NAME WHERE COOK_NAME = '{buttonText}'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(table);

                if(table.Rows.Count > 0)
                {
                    string price = table.Rows[0]["COOK_PRICE"].ToString();
                    MessageBox.Show($"{buttonText} - {price}원");
                }
                else
                {
                    MessageBox.Show($"{buttonText}의 가격정보를 찾을 수 없습니다.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("데이터베이스 연결 실패 : " + ex.Message );
            }
            finally
            {
                connection.Close();
            }
        }
    }





   
}
