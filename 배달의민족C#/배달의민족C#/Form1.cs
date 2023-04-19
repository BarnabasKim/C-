using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 배달의민족C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            배달의민족_Method test =new 배달의민족_Method();
           cTestList list = test.GetFoodKategorie("COOK_CODE", "COOK_KATEGORIE");
            comboBox1.DataSource = list;
            comboBox2.DataSource = list;
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(this.Location.X + this.Width, this.Location.Y);
      



        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this; // Form1을 Form2의 Owner로 설정합니다.
            form2.ShowDialog();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
         
            // textbox1에 입력된 값
            string COOK_NAME = tbxFood.Text;
            // textbox2에 입력된 값
            int COOK_PRICE = int.Parse(tboxPrice.Text);
            // textbox3에 입력된 값
            int COOK_COUNT = int.Parse(tboxCount.Text);
            // Combobox에서 선택된 값
            string COOK_CODE = comboBox1.SelectedValue.ToString();

            try
            {
                배달의민족_Method bdm = new 배달의민족_Method();
                bdm.AddFoodItem(COOK_NAME, COOK_PRICE, COOK_COUNT, COOK_CODE);
                MessageBox.Show("음식이 추가되었습니다.");
            }

           
            catch (Exception ex)
            {
                MessageBox.Show("음식 추가에 실패하였습니다: " + ex.Message);
            }
            RfreshFood();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RfreshFood();
        }

        private void RfreshFood()
        {
            tbxFood.Text = string.Empty;
            tboxPrice.Text = string.Empty;
            tboxCount.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this; // Form1을 Form2의 Owner로 설정합니다.
            form2.ShowDialog();
        }


        public void RefreshData()
        {
            배달의민족_Method bdm = new 배달의민족_Method();
            string category = comboBox2.Text;
            DataTable dt = bdm.GetCookList(category);


            // 가져온 데이터가 존재할 경우
            if (dt != null)
            {
                dataGridView1.DataSource = dt;   // DataGridView에 데이터 표시
            }

         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Column1"].Value != null)
                    {
                        string COOK_NAME = row.Cells["음식"].Value.ToString();
                        string COOK_COUNT = row.Cells["수량"].Value.ToString();
                        배달의민족_Method bdm = new 배달의민족_Method();
                        bdm.DeleteFoodItem(COOK_NAME, COOK_COUNT);
                        
                    }
                }
                MessageBox.Show("음식이 삭제되었습니다.");
            }
            catch(Exception ex) 
            {
                MessageBox.Show("음식 삭제에 실패하였습니다: " + ex.Message);
            }

            RefreshData();


        }
    }
    }


      /*  private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedValue.ToString());

            //cTestList list = test.GetFoodKategorie(comboBox1.SelectedValue.ToString(), tbxFood.Text, Convert.ToInt32(tboxPrice.Text));
        }*/
  


