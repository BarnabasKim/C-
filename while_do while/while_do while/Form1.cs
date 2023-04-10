using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_do_while
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 프로그램의 진입점 입니다.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 화면에서 "로또 번호" Button을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResult_Click(object sender, EventArgs e)
        {
            //List<int> LArray = new List<int>();

            // 1-45번호 6개
            int[] iArray = new int[6];   //로또 번호를 저장 할 배열을 생성 합니다.
            int iCount = 0;

            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            while (Array.IndexOf(iArray, 0) != -1)   //배열에서 0이 나오는 위치가 없을 경우 배열이 다 채워 졌다고 판단 합니다.(로또 숫자를 다 선택하지 못했을 경우 계속 진행)
            {
                int iNumber = rd.Next(1, 46);   //(1 <= x < 46) 1~45의 숫자 중 랜덤한 하나의 숫자를 등록 합니다. 

                if (Array.IndexOf(iArray, iNumber) == -1)  // 배열에서 찾는 숫자가 없을 경우 랜덤으로 호출 한 숫자를 배열에 등록 합니다. 
                {
                    iArray[iCount] = iNumber;    // 현재 횟수의 배열에 찾은 난수를 저장해주고
               //     sb.Append(string.Format("{0}. ", iNumber));
                    iCount++;   // 횟수를 하나 증가 시켜 줍니다. (난수를 저장할 배열의 위치)
                }
            }




            /* 숫자를 정렬해서 화면에 보여주기 위해서는?
               위에서 정해진 배열을 정렬하고 그 배열을 다시 순서대로 돌려서(foreeach) 숫자를 text 형태로 작성 하면 됩니다.  */

            Array.Sort(iArray);


            foreach (int iNum in iArray)
            {
                sb.Append(string.Format(string.Format("{0}. ", iNum)));
            }


            lblwhileResult.Text = sb.ToString();
            lboxwhileResult.Items.Add(sb.ToString());
        }


        /// <summary>
        /// 화면에서 "선택 번호 뽑기" Button을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndowhile_Click(object sender, EventArgs e)
        {
            // 1-100 중의 숫자 1개 선택

            Random rd = new Random();

            int iNumber = int.Parse(tboxNumber.Text);     // tboxNumber에서 지정한 숫자를 가져 옵니다. 

            // 사용자가 요구하지 않은 숫자를 입력하였을 때 사용자에게 확인 메세지를 보냄
            if (iNumber < 1 || iNumber > 100)
            {
                MessageBox.Show("1-100 사이의 숫자를 지정해 주세요.");
                return;
            }

            int iCheckNumber = 0;
            int iCount = 0;

            do  // 난수를 생성 후에 비교를 하여야 하기 때문에 1번은 꼭 진행 해야 함
            {
                iCheckNumber = rd.Next(1, 101);
                iCount++;

            } while (iNumber != iCheckNumber);  // 비교한 값이 다를 경우 다시 찾음


            /*  위에서 do while 문을 쓰지 않고 while문을 썼을때의 처리 방법
            
            iCheckNumber = rd.Next(1, 101);   // do while문을 들어가기 전에 같은 작업을 한번 더 수행 하고 들어가면 됨 
            if (iNumber != iCheckNumber)      // 처음 한번은 꼭 진행 해야 한다는 내용때문에 do while문을 꼭 써야 한다고 생각 할 필요는 없습니다.
            {
                while (iNumber != iCheckNumber)
                {
                    iCheckNumber = rd.Next(1, 101);
                    iCount++;
                }
            }
            */

            lbldowhileResult.Text = string.Format(" - 뽑은 숫자 {0}을 {1}회만에 찾았습니다.", iNumber, iCount);

        }
    }
}
