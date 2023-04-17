using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DB_ProcedureProject
{
    public partial class Form1 : Form
    {
        private int currentPage = 1;
        private int pageSize = 4;
        private int _totalPages;

        private List<Button> btns = new List<Button>();
        public Form1()
        {
            InitializeComponent();
          

            CProcedureTest1 test = new CProcedureTest1();
            cTestList list = test.GetFoodKategorie("COOK_CODE", "COOK_KATEGORIE");
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "COOK_KATEGORIE";
            
         
        }

        private void label2_Click(object sender, EventArgs e)
        {
            currentPage = 1;

            CProcedureTest1 test = new CProcedureTest1();
            string category = comboBox1.Text;
            DataTable dt = test.GetCookList(category);

     


            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }


            _totalPages = (int)Math.Ceiling((double)dt.Rows.Count / pageSize);

                lblPaging.Text = $"{currentPage} / {_totalPages}";


                CreateButtons(dt);

            
        }
    

        private void CreateButtons(DataTable dataTable)
        {
            flowLayoutPanel1.Controls.Clear();
            btns.Clear();




            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, dataTable.Rows.Count);


            for (int i = startIndex; i < endIndex; i++)
            {
                Button btn = new Button();
                btn.Text = dataTable.Rows[i]["음식"].ToString();
                btn.BackColor = Color.Blue;
                btn.ForeColor = Color.White;
                btn.Font = new Font("굴림", 15);
                btn.Size = new Size(110, 50);

                btns.Add(btn);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentPage < _totalPages)
            {
                currentPage++;
                CProcedureTest1 test = new CProcedureTest1();
                string category = comboBox1.Text;
                DataTable dt = test.GetCookList(category);

                CreateButtons(dt);
                lblPaging.Text = $"{currentPage} / {_totalPages}";


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(currentPage > 1)
            {
                currentPage--;
                CProcedureTest1 test = new CProcedureTest1();
                string category = comboBox1.Text;
                DataTable dt = test.GetCookList(category);

                CreateButtons(dt);
                lblPaging.Text = $"{currentPage} / {_totalPages}";

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CProcedureTest1 test = new CProcedureTest1();
         
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            int COOK_PRICE = Convert.ToInt32(selectedRow.Cells["가격"].Value);
            string COOK_NAME_CODE = selectedRow.Cells["코드"].Value.ToString();

            Form2 form2 = new Form2(COOK_NAME_CODE, COOK_PRICE);
            form2.ShowDialog();
        }
    }
}
