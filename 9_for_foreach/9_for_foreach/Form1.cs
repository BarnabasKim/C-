using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_for_foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            tboxResult.Text = string.Empty;

            StringBuilder sb = new StringBuilder();

            int iResult = 0;

            for (int i = 1; i <= 100; i++)
            {
                iResult = iResult = +i;

                sb.Append(string.Format("1에서 {0}까지 더하면 {1} \r\n", i, iResult));
            }


            for (int i = 1; i <= 5; i++)
            {
                for (int a = 1; a <= 3; a++)
                {
                    sb.Append(string.Format("{0}회차{1} 스테이지 진행중....\r\n", i, a));
                }

            }



            tboxResult.Text = sb.ToString();
        }

        private void btnforeach_Click(object sender, EventArgs e)
        {
            tboxResult.Text = string.Empty;

            StringBuilder sb = new StringBuilder();

            string[] strArry = { "나연", "정연", "모모", "사나", "지효", "미나", "다현", "쯔위", "채영" };

            int i = 1;

            foreach (string oValue in strArry) 
            {
                sb.Append(string.Format("{0} 선생님은  {1}반 입니다. \r\n", oValue, i++));
            }

            tboxResult.Text = sb.ToString() ;
        }
    }
}
