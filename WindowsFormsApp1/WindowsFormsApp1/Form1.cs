using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        int firstOperand = 0;
        int secondOperand = 0;
        private string txtMsg;
       
        public Form1()
        {
            InitializeComponent();
        }

       
  

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;

            //텍스트박스1
            textBox1.Text += "+";
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;

            //텍스트박스1
            textBox1.Text += "-";

        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;

            //텍스트박스1
            textBox1.Text += "*";

        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;

            //텍스트박스1
            textBox1.Text += "/";

        }

        private void ButtonAllClear_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            display.Text = "0";

            //텍스트박스1
            textBox1.Clear();

        }

     

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if(operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "0";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();

            //텍스트박스1
            textBox1.Text += "0";
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {

            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
           String strNumber = display.Text += "1";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();

            //텍스트박스1
            textBox1.Text += "1";
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "2";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();

            //텍스트박스1
            textBox1.Text += "2";

        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "3";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
            
            //텍스트박스1
            textBox1.Text += "3";

        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "4";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
           
            //텍스트박스1
            textBox1.Text += "4";

        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "5";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
            
            //텍스트박스1
            textBox1.Text += "5";

        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "6";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
            
            //텍스트박스1
            textBox1.Text += "6";

        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "7";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
            
            //텍스트박스1
            textBox1.Text += "7";

        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "8";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
            
            //텍스트박스1
            textBox1.Text += "8";

        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "9";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
            
            //텍스트박스1
            textBox1.Text += "9";

        }

        




        // 기록 남기기
        private void ButtonRecord_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm(txtMsg);

            childForm.Owner = this;

            if (childForm.ShowDialog() == DialogResult.OK)
            {
                childForm.testtt("ss");
            }
        }

        private void ButtonResult_Click_1(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(display.Text);
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (secondOperand == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다";
                }
                else
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
            //텍스트박스1
           

            txtMsg += textBox1.Text + "="  + display.Text + "\r\n";
          

              try
              {
                  DataTable dt = new DataTable();
                  var a = dt.Compute(textBox1.Text, "");
                  textBox1.Text = a.ToString();

              } catch (Exception e1)
              {
                  MessageBox.Show(e1.Message);
              }


        }

        private void btnback_Click(object sender, EventArgs e)
        {   //텍스트박스1
            if (textBox1.Text.Length > 0)
            {
                String text = textBox1.Text;
                textBox1.Text = text.Substring(0, text.Length - 1);
            }

            if(display.Text.Length > 0)
            {
                String text = display.Text;
                display.Text = text.Substring(0, text.Length - 1);
            }
        }
    }
}
