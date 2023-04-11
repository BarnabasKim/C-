using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct_Class
{
    internal class CPlayer
    {
        //public int iCount = 0;  // Player가 몇회 진행 중인지

        //public int iSun = 0;  // 해에 대한 값
        //public int iMoon = 0;  // 달에 대한 값
        //public int iStar = 0;  // 별에 대한 값

        //public int iCardSum = 0;  // 해, 달, 별을 더한 값

        // 값들을 더해서 반환
        public int CardSun(int iSun, int iMoon, int iStar)
        {
            return iSun + iMoon + iStar;
        }

        // 결과를 String 형태로 변환 (화면에 결과를 보여주기 위해 사용)
        public string ResultText(int iCount ,int iSun, int iMoon, int iStar, int iCardSum)
        {
            return string.Format("{0}회) 해:{1}, 달:{2}, 별:{3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
        }

        public string PlayerPair(int iCount, int iP1CardSum, int iP2CardSum)
        {
            int iCheck = iP1CardSum - iP2CardSum;

            if(iCheck > 0)
            {
                return string.Format("{0}회차 : Player1 이 {1} 만큼 더 큽니다.", iCount, iCheck);
            }else if(iCheck < 0)
            {
                return string.Format("{0}회차 : Player2 가 {1} 만큼 더 큽니다.", iCount, Math.Abs(iCheck));
               // return string.Format("{0}회차 : Player2 가 {1} 만큼 더 큽니다.", iCount, iCheck * -1 );
            }else
            {
                return string.Format("{0}회차 : Player 1과 Player 2의 값이 같습니다. ");
            }

        }


        public string PlayerResult(int iP1CardSum, int iP2CardSum)
        {
            string strReturn = string.Empty;


            if (iP1CardSum > iP2CardSum)
            {
                strReturn = "Player1이 이겼습니다.";
            }
            else if (iP1CardSum < iP2CardSum)
            {
                strReturn = "Player2가 이겼습니다.";
            }
            else
            {
                strReturn = "비겼습니다.";
            }


            return strReturn;
        }
    }
}
