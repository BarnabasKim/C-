﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _13.Inheritance
{
    class CCycle : CBase
    {
        public Rectangle _rtCircle1;  // 바퀴1
        public Rectangle _rtCircle2;  // 바퀴2
        public Rectangle _rtSquare1;  // 몸통1

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="sName"></param>
        public CCycle(string sName)
        {
            strName = sName;  // 클래스를 생성 할 때 이름을 가져와서 strName에 넣어 줌
            _Pen = new Pen(Color.Black, 3);  // 펜에 대한 색상과 굵기를 설정

            _rtCircle1 = new Rectangle(30, 150, 120, 120);  // 바퀴1에 대한 위치 및 크기를 설정
            _rtCircle2 = new Rectangle(210, 150, 120, 120);  // 바퀴2에 대한 위치 및 크기를 설정
            _rtSquare1 = new Rectangle(60, 90, 240, 60);  // 몸통1에 대한 위치 및 크기를 설정
        }

        /// <summary>
        /// 설정 되어 있는 Pen에 대한 정보를 반환
        /// </summary>
        /// <returns></returns>
        public Pen fPenInfo()
        {
            return _Pen;
        }

        /// <summary>
        /// 외부에서 그림의 위치를 이동시키는 함수를 호출
        /// </summary>
        /// <param name="iMove"></param>
        public void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fCircle2Move(iMove);
            fSquare1Move(iMove);
        }

        /// <summary>
        /// 바퀴1의 위치를 가져와서 X 위치값을 이동 시키고 다시 바퀴1에 위치 정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        protected void fCircle1Move(int iMove)
        {
            Point oPoint = _rtCircle1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCircle1.Location = oPoint;
        }

        /// <summary>
        /// 바퀴2의 위치를 가져와서 X 위치값을 이동 시키고 다시 바퀴1에 위치 정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        protected void fCircle2Move(int iMove)
        {
            Point oPoint = _rtCircle2.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCircle2.Location = oPoint;
        }

        /// <summary>
        /// 몸통1의 위치를 가져와서 X 위치값을 이동 시키고 다시 바퀴1에 위치 정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        protected void fSquare1Move(int iMove)
        {
            Point oPoint = _rtSquare1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare1.Location = oPoint;
        }
    }
}

