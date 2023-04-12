using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Inheritance
{
    class COneCycle : CBase
    {
        public Rectangle _rtCircle1;   //바퀴
        public Rectangle _rtSquare1;   // 몸통

        public COneCycle(string sName) 
        { 
            strName = sName;
            _Pen = new Pen(Color.WhiteSmoke,3);

            _rtCircle1 = new Rectangle(120,150,120,120);
            _rtSquare1 = new Rectangle(150,30,60,120); 

        }


        public Pen fPenInfo()
        {
           // _Pen = new Pen(Color.WhiteSmoke, 3);
            
            return _Pen;
        }

    }
}
