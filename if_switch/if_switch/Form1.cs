using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ifTest();
        }




        private void switchTest()
        {
            int iRet = 3;

            string strResult = string.Empty;

            switch (iRet)
            {   
                case 2:
                case 3:
                    {
                        strResult = "2나 3";
                    }
                    break;
                case 4:
                    {
                        strResult = "4";
                    }
                    break;

                default:
                    {
                        strResult = "몰라";
                    }
                    break;

            }
        }



        private void ifTest()
        {
            int ia = 3;
            int ib = 20;

            string strResult = string.Empty;

            // if, else if, else -> if 조건이 아닐 경우 else if 조건이 아닐 경우 else(나머지)
            if (ia > ib)
            {
                strResult = "ia가 크다";
            }
            else if (ia < ib)
            {
                strResult = "ib가 크다";
            }
            else 
            {
                strResult = "같다";
            }

            // 단항의 경우 괄호는 생략 할 수 있습니다.
            if (ia > ib)
                strResult = "ia가 크다";
            
            else
            strResult = "같다";




            if (ia > ib)
            {
                strResult = "ia가 크다";
            }
            else
            {
                strResult = "같다";
            }

            // 동일 변수에 결과 값을 넣어줄 경우에 if 문을 축약 할 수 있습니다
            strResult = (ia > ib) ? "ia가 크다" : "같다";


            // && || 를 사용 해서 여러가지 조건을 추가 할 수 있습니다.
            if (ia > 5 && ib > 5)
            {
                strResult = "둘다 크다";
            }

            if (ia > 5 || ib > 5)
            {
                strResult = "적어도 둘중에 하나는 크다";
            }




        }

        private void btnIfResult_Click(object sender, EventArgs e)
        {
            int iNumber1 = (int)nNumber1.Value;
            int iNumber2 = (int)nNumber2.Value;


            if(iNumber1 > iNumber2)
            {
                lblIfResult.Text = string.Format("- Number1이 Nubmer2 보다 {0} 더 큽니다.", iNumber1 - iNumber2);
            }
            else if(iNumber1 < iNumber2)
            {
                lblIfResult.Text = string.Format("- Number2가 Nubmer1 보다 {0} 더 큽니다.", iNumber2 - iNumber1);
            }
            else
            {
                lblIfResult.Text = string.Format("- 두 숫자는 같습니다. 숫자 : {0} ", iNumber1);

            }
        }

        private void btnswitchResult_Click(object sender, EventArgs e)
        {
            string strSelect = cboxDay.Text;

            switch (strSelect)
            {
                case "월":
                    lblswitchResult.Text = "- 선택 날짜는 월요일 입니다.";
                    break;
                case "화":
                    lblswitchResult.Text = "- 선택 날짜는 화요일 입니다.";
                    break;
                case "수":
                    lblswitchResult.Text = "- 선택 날짜는 수요일 입니다.";
                    break;
                case "목": // break 문을 쓰지 않고 목과 금을 case를 동시에 사용 합니다.
                case "금":
                    lblswitchResult.Text = "- 선택 날짜는 금요일 입니다.";
                    break;
                default:
                    lblswitchResult.Text = "- 선택 날짜는 주말 입니다(토요일,일요일)";
                    break;
            }
        }
    }
}
