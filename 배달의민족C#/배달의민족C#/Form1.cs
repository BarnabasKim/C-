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
            }


        }
        //조회
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            int totalRows = 50;

            for (int i = 0; i < totalRows; i++)
            {
                dataGridView1.Rows.Add();
            }

            RefreshData();

            int currentRows = dataGridView1.RowCount;

            if (dataGridView1.DataSource != null)
            {
                for (int i = currentRows; i < totalRows; i++)
                {
                    dataGridView1.Rows[i].Cells["음식"].Value = "";
                    dataGridView1.Rows[i].Cells["가격"].Value = "";
                    dataGridView1.Rows[i].Cells["수량"].Value = "";
                }
            }

            foreach (DataGridViewRow oRow in dataGridView1.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }

            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
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


    //    //체크박스 크기 키우기
    //    private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    //    {
    //        if (e.RowIndex >= 0 && e.ColumnIndex >= 0) //체크박스 크기 키우기
    //        {
    //            DataGridView dgv = (DataGridView)sender;
    //            if (dgv.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
    //            {
    //                int checkBoxSize = 30;
    //                e.PaintBackground(e.CellBounds, true);
    //                ControlPaint.DrawCheckBox(e.Graphics, (e.CellBounds.Width - checkBoxSize) / 2,
    //e.CellBounds.Y + (e.CellBounds.Height - checkBoxSize) / 2,
    //                   checkBoxSize, checkBoxSize, (bool)e.FormattedValue ? ButtonState.Checked : ButtonState.Normal);
    //                e.Handled = true;
    //            }
    //        }
    //    }

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
            int COOK_PRICE = Convert.ToInt32(selectedRow.Cells["가격"].Value);
            int COOK_COUNT = Convert.ToInt32(selectedRow.Cells["수량"].Value);
            string COOK_NAME_CODE = selectedRow.Cells["코드"].Value.ToString();

            Form3 form3 = new Form3(COOK_NAME_CODE, COOK_PRICE, COOK_COUNT, this);
            form3.ShowDialog();

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





  


