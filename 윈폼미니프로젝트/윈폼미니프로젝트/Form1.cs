using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윈폼미니프로젝트
{
    public partial class Form1 : Form
    {
        bool blnBtnClosing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Load(@"D:\images\ExitButton.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            if(MessageBox.Show("종료하시겠습니까?" , "종료확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                blnBtnClosing = true;
                this.DialogResult = DialogResult.Abort;
                Application.Exit();
            }
        }

        private void MainImage_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.saramin.co.kr/zf_user/company-info/view/csn/QW9IYjgybnBCMVNTZXBDTEc0RjlCZz09/company_nm/(%EC%A3%BC)%ED%88%AC%EB%B9%84%EC%8B%9C%EC%8A%A4%ED%85%9C");
        }

       
    }
}
