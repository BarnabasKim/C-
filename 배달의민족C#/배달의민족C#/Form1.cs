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

            배달의민족_Method test = new 배달의민족_Method();
            cTestList list = test.GetFoodKategorie("COOK_CODE", "COOK_KATEGORIE");
            comboBox1.DataSource = list;
            comboBox2.DataSource = list;


            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "선택";
            checkBoxColumn.Name = "Column1";
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            checkBoxColumn.FillWeight = 30;

            // DataGridView 컬럼 추가
            dataGridView1.Columns.Add(checkBoxColumn);


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this; // Form1을 Form2의 Owner로 설정합니다.
            form2.Location = new Point(this.Right - form2.Width, this.Top);
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
                dataGridView1.Columns["코드"].Visible = false;
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
                bool hasSelected = false; // 체크박스가 선택되었는지 여부를 나타내는 변수
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Column1"].Value != null && (bool)row.Cells["Column1"].Value)
                    {
                        hasSelected = true;
                        string COOK_NAME = row.Cells["음식"].Value.ToString();
                        string COOK_COUNT = row.Cells["수량"].Value.ToString();
                        배달의민족_Method bdm = new 배달의민족_Method();
                        bdm.DeleteFoodItem(COOK_NAME, COOK_COUNT);
                    }
                }
                if (hasSelected) // 하나 이상의 체크박스가 선택된 경우에만 삭제 성공 메시지 출력
                {
                    MessageBox.Show("음식이 삭제되었습니다.");
                    RefreshData();
                }
                else // 체크박스가 선택되지 않은 경우 에러 메시지 출력
                {
                    MessageBox.Show("삭제할 음식을 선택해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("음식 삭제에 실패하였습니다: " + ex.Message);
            }
        }



        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) //체크박스 크기 키우기
            {
                DataGridView dgv = (DataGridView)sender;
                if (dgv.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
                {
                    int checkBoxSize = 30;
                    e.PaintBackground(e.CellBounds, true);
                    ControlPaint.DrawCheckBox(e.Graphics, (e.CellBounds.Width - checkBoxSize) / 2,
    e.CellBounds.Y + (e.CellBounds.Height - checkBoxSize) / 2,
                       checkBoxSize, checkBoxSize, (bool)e.FormattedValue ? ButtonState.Checked : ButtonState.Normal);
                    e.Handled = true;
                }
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = (DataGridView)sender;
                dgv.Rows[e.RowIndex].Cells["Column1"].Value = !(bool)dgv.Rows[e.RowIndex].Cells["Column1"].FormattedValue;
                dgv.RefreshEdit();
            }
        }

   

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this; // Form1을 Form2의 Owner로 설정합니다.
            form2.Location = new Point(this.Right - form2.Width, this.Top);
            form2.ShowDialog();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            int COOK_PRICE = Convert.ToInt32(selectedRow.Cells["가격"].Value);
            int COOK_COUNT = Convert.ToInt32(selectedRow.Cells["수량"].Value);
            string COOK_NAME_CODE = selectedRow.Cells["코드"].Value.ToString();

            Form3 form3 = new Form3(COOK_NAME_CODE, COOK_PRICE, COOK_COUNT, this);
            form3.ShowDialog();

        }
    }



}



      /*  private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedValue.ToString());

            //cTestList list = test.GetFoodKategorie(comboBox1.SelectedValue.ToString(), tbxFood.Text, Convert.ToInt32(tboxPrice.Text));
        }*/
  


