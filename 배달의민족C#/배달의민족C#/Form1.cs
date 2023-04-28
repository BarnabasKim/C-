using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 배달의민족C_
{
    public partial class Form1 : Form
    {
        private string _Data;

        private SerialPort _SP_PRINTER = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            
            배달의민족_Method test = new 배달의민족_Method();
            cTestList list = test.GetFoodKategorie("COOK_CODE", "COOK_KATEGORIE");
            comboBox1.DataSource = list;
            comboBox2.DataSource = list;


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this; // Form1을 Form2의 Owner로 설정합니다.
            form2.Location = new Point(this.Right - form2.Width, this.Top);
            form2.ShowDialog();
        }
        // 배달 음식 추가 기능
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
                _Data = bdm.AddFoodItem(COOK_NAME, COOK_PRICE, COOK_COUNT, COOK_CODE);

                SerialOpen();

                // 바코드 출력
                try
                {
                        byte[] buf = Encoding.Default.GetBytes(_Data);
                        // 바이트로 인코딩(한글 깨짐 방지)
                        _SP_PRINTER.Write(buf, 0, buf.Length);
                        // 인코딩한 바이트를 인덱스 0 부터 바이트길이까지
                }

                catch (InvalidOperationException) { }

                SerialClose();

               // MessageBox.Show(_Data);
                MessageBox.Show("음식이 추가되었습니다.");
            }


            catch (Exception ex)
            {
                MessageBox.Show("음식 추가에 실패하였습니다: " + ex.Message);
            }
            RfreshFood();

        }
        //초기화
        private void btnClear_Click(object sender, EventArgs e)
        {
            RfreshFood();
        }
        // 데이터 초기화 기능
        private void RfreshFood()
        {
            tbxFood.Text = string.Empty;
            tboxPrice.Text = string.Empty;
            tboxCount.Text = string.Empty;
        }


        // 데이터 쌓이지 않게 초기화
        public void RefreshData()
        {
            배달의민족_Method bdm = new 배달의민족_Method();
            string category = comboBox2.Text;
            DataTable dt = bdm.GetCookList(category);

        
            if (dt != null)
            {
                
                dataGridView1.DataSource = dt;   // DataGridView에 데이터 표시
                dataGridView1.Columns["코드"].Visible = false;

                NumIndex();
                GetAllData();
            }


        }

        //Row index 순번 정해주기
        private void NumIndex()
        {
            foreach (DataGridViewRow oRow in dataGridView1.Rows)
            {
                oRow.HeaderCell.Value = (oRow.Index + 1).ToString();
            }

            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        /// <summary>
        /// 데이터 조회 및 빈 행 추가
        /// </summary>
        private void GetAllData()
        {
            dataGridView1.DataSource = null;

            int totalRows = 50;
            int dataRowCount = 0;

            배달의민족_Method bdm = new 배달의민족_Method();
            string category = comboBox2.Text;
            DataTable dt = bdm.GetCookList(category);

            if (dt != null)
            {
                dataRowCount = dt.Rows.Count;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["코드"].Visible = false;
            }

            for (int i = dataRowCount; i < totalRows; i++)
            {
                DataRow row = dt.NewRow();
                dt.Rows.Add(row);
            }

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView1.DataSource = dt;


            NumIndex();

        }

        //조회 버튼
        private void button2_Click(object sender, EventArgs e)
        {

            GetAllData();

        }



        // 배달 삭제 
        private void btnDelAll_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasSelected = false; // 체크박스가 선택되었는지 여부를 나타내는 변수
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Column1"].Value != null && (bool)row.Cells["Column1"].Value)
                    {
                        if (row.Cells["음식"].Value != null && row.Cells["수량"].Value != null)
                        {
                            hasSelected = true;
                            string COOK_NAME = row.Cells["음식"].Value.ToString();
                            int COOK_COUNT = Convert.ToInt32(row.Cells["수량"].Value);
                            if (COOK_COUNT == 0) continue; // 데이터가 0일 경우에는 삭제하지 않음
                            배달의민족_Method bdm = new 배달의민족_Method();
                            bdm.DeleteFoodItem(COOK_NAME, COOK_COUNT);
                        }
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
                MessageBox.Show("빈행의 값은 삭제할 수 없습니다." );
            }
        }



        // 셀 클릭시 체크박스 클릭 되도록
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = (DataGridView)sender;
                dgv.Rows[e.RowIndex].Cells["Column1"].Value = !(bool)dgv.Rows[e.RowIndex].Cells["Column1"].FormattedValue;
              
            }
        }


        //Form2의 메뉴 클릭 버튼, 위치 변경
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this; // Form1을 Form2의 Owner로 설정합니다.
            form2.Location = new Point(this.Right - form2.Width, this.Top);
            form2.ShowDialog();

        }
        /// <summary>
        /// 수정 기능 구현
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

            int COOK_PRICE = 0;
            if (selectedRow.Cells["가격"].Value != DBNull.Value)
            {
                COOK_PRICE = Convert.ToInt32(selectedRow.Cells["가격"].Value);
            }

            int COOK_COUNT = 0;
            if (selectedRow.Cells["수량"].Value != DBNull.Value)
            {
                COOK_COUNT = Convert.ToInt32(selectedRow.Cells["수량"].Value);
            }

            string COOK_NAME_CODE = string.Empty;
            if (selectedRow.Cells["코드"].Value != DBNull.Value)
            {
                COOK_NAME_CODE = selectedRow.Cells["코드"].Value.ToString();
            }

            if (!string.IsNullOrEmpty(COOK_NAME_CODE) && COOK_PRICE != 0 && COOK_COUNT != 0)
            {
                Form3 form3 = new Form3(COOK_NAME_CODE, COOK_PRICE, COOK_COUNT, this);
                form3.ShowDialog();
            }
        }


        /// <summary>
        /// 검색 기능 구현 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("검색 정보를 입력해주세요");
            }
            else
            {
                string SearchItem = textBox1.Text.ToString();
                배달의민족_Method bdm = new 배달의민족_Method();
                DataTable dt = bdm.searchData(SearchItem);
                
                if (dt != null && dt.Rows.Count > 0)
                {
                    

                    dataGridView1.DataSource = dt; //검색결과를 DataGridView에 바인딩
                }
                else
                {
                    MessageBox.Show("검색 결과가 없습니다.");
                }

                //텍스트 박스 초기화
                textBox1.Text = "";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnSearch_Click(sender, e);
            }
        }

        
        // 바코드 시리얼 통신 오픈
        private void SerialOpen()
        {
            string printer_port = System.Configuration.ConfigurationSettings.AppSettings.Get("PRINTER_PORT");

            try
            {
                if (_SP_PRINTER.IsOpen)
                    _SP_PRINTER.Close();

                _SP_PRINTER.PortName = printer_port;
                _SP_PRINTER.BaudRate = 9600;
                _SP_PRINTER.Open();


            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }
        // 바코드 시리얼 통신 닫기
        private void SerialClose()
        {
            _SP_PRINTER.Close();
        }


            

    }
}





  


