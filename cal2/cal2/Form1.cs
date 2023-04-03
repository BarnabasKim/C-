using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       public double resultVal = 0;  // 계산된 숫자를 저장할 변수
        public double num = 0;      // 입력된 숫자를 저장할 변수
        public bool isNewNum = true; // 새로운 숫자 입력 여부 확인 변수(연산 버튼 클릭 후 설정)
        public string recentCal = "+"; // 연산 버튼 클릭시 클릭 값을 저장할 변수



        public void NumBtn_click(object sender, EventArgs e)
        {
           
            if (recentCal == "=")
            {
                resultVal = 0; isNewNum = true; num = 0; recentCal = "+";
                ResultBox.Text = "0"; ProcessBox.Text = "0";
            } // if end "=" 버튼 클릭후 새로운 계산 시 초기화

            Button btnNum = sender as Button; // =(Button)sender ; // object 타입인 sender 를 button 타입으로 형변환
            num = double.Parse(btnNum.Text); // 클릭한 버튼의 값 받아오기



            if (isNewNum )   //1. 계산 종료 후 새로운 숫자값이면 혹은 프로그램이 맨 처음 시작되었다면
            {
                ResultBox.Text = num.ToString(); // 2. 새로운 숫자값으로 설정 
                isNewNum = false;
            }
            else if (ResultBox.Text == "0") // 3.resultBox의 현재 출력 값인 0인 경우
            {
                ResultBox.Text = num.ToString(); // 4. 0 대신 숫자값으로 변경 
            }
            else  // 5. 그 외의 경우
            {
                ResultBox.Text = num.ToString(); // 6. 기준 출력값 뒤에 클릭한 숫자값을 붙임.
            }
            ProcessBox.Text += num.ToString(); // ProcessBox에 클릭한 값 붙임.
        }

       //NumBtn_Click() end


        public void BtnCal_Click(object sender, EventArgs e)
        {
            Button btnCal = (Button)sender;


            if (!isNewNum ) // 계산 버튼 연속 클릭 되었을 때를 방지
            {
                num = double.Parse(ResultBox.Text); // 숫자 버튼을 클릭하여 입력된 값(string)을 dobule로 변환
                switch (recentCal)
                {
                    case "+":
                        resultVal = resultVal + num; // 최종 계산 값을 변수 resultVal에 저장
                        break;
                    case "-":
                        resultVal = resultVal - num; // 최종 계산 값을 변수 resultVal에 저장
                        break;
                    case "*":
                        resultVal = resultVal * num; // 최종 계산 값을 변수 resultVal에 저장
                        break;
                    case "/":
                        resultVal = resultVal / num; // 최종 계산 값을 변수 resultVal에 저장
                        break;
                }
                ResultBox.Text = resultVal.ToString(); // 계산값 출력 
            }

            recentCal = btnCal.Text;   // 최근 버튼 클릭 값을 변수 recentCal에 저장 
            ProcessBox.Text += recentCal; //ProcessBox에 클릭한 연산 버튼 값 일력
            isNewNum = true; // 계산 종료 후 새로운 숫자값임을 증명 
        } // BtnCal_Click End

        private void BtnClear_Click(object sender, EventArgs e)
        {
            resultVal = 0; isNewNum = true; num = 0; recentCal = "+";
            ResultBox.Text = "0"; ProcessBox.Text += 0;
        } // BtnClear_Click end

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (!ResultBox.Text.Contains(".")) 
            {
                ResultBox.Text += ".";
                ProcessBox.Text = ".";  
            } // BtnDot_Click end

            
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if(ResultBox.Text != "0" && recentCal != "=" && ResultBox.Text.Length > 0) 
            {
                ResultBox.Text = ResultBox.Text.Substring(0, ResultBox.Text.Length - 1);
                ProcessBox.Text = ProcessBox.Text.Substring(0, ProcessBox.Text.Length - 1);
            }
        }// BtnRemove_Click End
    }


   
    
}
