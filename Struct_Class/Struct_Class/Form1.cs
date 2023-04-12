using System.Windows.Forms;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
using CPL = Struct_Class;
 
namespace Struct_Class
{

    public partial class Form1 : Form
    {
        // Player에 대한 구조체(구조체의 경우 Player의 인자들만 가지고 있도록 구성함(함수들은 삭제)
        struct structPlayer
        {
            public int iCount;  // Player가 몇회 진행 중인지

            public int iSun;  // 해에 대한 값
            public int iMoon;  // 달에 대한 값
            public int iStar;  // 별에 대한 값

            public int iCardSum;  // 해, 달, 별을 더한 값

            //// 값들을 더해서 반환
            //public int CardSun(int iSum, int iMoon, int iStar)
            //{
            //    return iSun + iMoon + iStar;
            //}

            //// 결과를 String 형태로 변환 (화면에 결과를 보여주기 위해 사용)
            //public string ResultText()
            //{
            //    return string.Format("{0}회) 해:{1}, 달:{2}, 별:{3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
            //}
        }

        Random _rd = new Random();  // 난수 발생용

        structPlayer _sp1;  //Player1 생성
        structPlayer _sp2;  //Player2 생성

        CPL.CPlayer _clPlayer = new CPL.CPlayer();  // 수식 및 결과 계산을 위한 Player Class 생성

        //classPlayer _clPlayer1 = new classPlayer();  //Test 용 
        //classPlayer _clPlayer2 = new classPlayer();  //Test 용 


        /// <summary>
        /// 프로그램의 진입점 입니다.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 화면에서 "해" 그림을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxSun_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                //_clPlayer1.iSun = iNumber;
                _sp1.iSun = iNumber;   // 구조체가 선택 된 Card의 값을 넣어 줌 (이하 같은 항목의 경우도 동일)

            }
            else
            {
                //_clPlayer2.iSun = iNumber;
                _sp2.iSun = iNumber;
            }

            Result();
        }


        /// <summary>
        /// 화면에서 "달" 그림을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                _sp1.iMoon = iNumber;
            }
            else
            {
                _sp2.iMoon = iNumber;
            }

            Result();
        }


        /// <summary>
        /// 화면에서 "별" 그림을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxStar_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                _sp1.iStar = iNumber;
            }
            else
            {
                _sp2.iStar = iNumber;
            }

            Result();
        }


        /// <summary>
        /// 화면에서 "빈" 그림을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxNone_Click(object sender, EventArgs e)
        {
            // 아무짓도 안하고 한턴을 넘긴다
            Result();
        }


        /// <summary>
        /// 현재 선택 된 Radio Button을 확인해서 선택되지 않은 Radio Button을 선택하기 위해 사용
        /// </summary>
        private void iCheckedChange()
        {
            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;   // 선택 되어 있지 않은 Player를 선택 하도록 함
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }


        /// <summary>
        /// 선택 된 Radio Button에 대해서 해, 달, 별의 값을 더하고 결과를 내용으로 만들어서 ListBox에 표시
        /// </summary>
        private void Result()
        {
            string strResult = string.Empty;

            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                _sp1.iCount++;  // Player에 대한 진행 횟수를 증가

                _sp1.iCardSum = _clPlayer.CardSun(_sp1.iSun, _sp1.iMoon, _sp1.iStar);  // Player Class에서 해, 달, 별의 값을 더하는 함수를 호출, 계산 후 결과를 Player 1 CardSum에 넣어 줌

                strResult = _clPlayer.ResultText(_sp1.iCount, _sp1.iSun, _sp1.iMoon, _sp1.iStar, _sp1.iCardSum);  // Player Class에서 결과 값을 string 형태로 변환하는 함수를 호출

                lboxResult1.Items.Add(strResult);  // 결과 값을 listbox에 등록
            }
            else
            {
                _sp2.iCount++;

                _sp2.iCardSum = _clPlayer.CardSun(_sp2.iSun, _sp2.iMoon, _sp2.iStar);

                strResult = _clPlayer.ResultText(_sp2.iCount, _sp2.iSun, _sp2.iMoon, _sp2.iStar, _sp2.iCardSum);

                lboxResult2.Items.Add(strResult);
            }

            iCheckedChange();  // 다음 Player 선택

            // 결과를 체크 Player1과 Player2의 진행 횟수가 같을 경우 ( => 게임의 한턴이 진행 되었을 경우)
            if (_sp1.iCount == _sp2.iCount)
            {
                lboxNow.Items.Add(_clPlayer.PlayerPair(_sp2.iCount, _sp1.iCardSum, _sp2.iCardSum));   // Player Class에서 두 Player의 Card 합을 비교하는 함수를 호출 후 결과를 List Box에 넣어 줌

                if (_sp2.iCount >= 5)   // 게임 횟수가 5턴이 마무리 되었을 경우 ( => 위에서 Player 1과 Player 2의 횟수가 같을 경우만 체크 함으로 Player1의 횟수나 2의 횟수 중 아무 횟수나 확인 해도 상관 없음)
                {
                    lboxNow.Items.Add(_clPlayer.PlayerResult(_sp1.iCardSum, _sp2.iCardSum));  // Player Class에서 게임 결과를 가져오는 함수를 호출 후 List Box에 넣어줌
                }
            }
        }
    }
}