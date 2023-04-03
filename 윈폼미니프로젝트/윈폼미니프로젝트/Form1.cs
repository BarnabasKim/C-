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
        Color labeOriginalColor;
        

        public Form1()
        {
            InitializeComponent();
            /*label1.BackColor = Color.BlueViolet;*/
            tablePartLayout.Visible = false;
            OneweekTableLayout.Visible = false;
            tableLayoutSpec.Visible = false;
            tableLayoutSpec2.Visible = false;


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

        private void CarBtn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Carlb1.Text = btn.Text;

            CarTableLayout.Visible = false;
            tablePartLayout.Visible = true;
            label1.BackColor = Color.BlueViolet;
           

        }

        private void PartBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Partlbl.Text = btn.Text;

            tablePartLayout.Visible = false;
            OneweekTableLayout.Visible = true;
            label1.BackColor = Color.DarkGray;
            label2.BackColor = Color.BlueViolet;

        }

        private void WeekBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            weeklbl.Text = btn.Text;

            OneweekTableLayout.Visible = false;
            tableLayoutSpec.Visible = true;
            label1.BackColor = Color.DarkGray;
            label2.BackColor = Color.DarkGray;
            label3.BackColor = Color.BlueViolet;

        }

        private void SpecBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Speclbl.Text = btn.Text;

            tableLayoutSpec.Visible = false;
            tableLayoutSpec2.Visible = true;
            label1.BackColor = Color.DarkGray;
            label2.BackColor = Color.DarkGray;
            label3.BackColor = Color.DarkGray;
            label4.BackColor = Color.BlueViolet;

        }

        private void SpecBtn_Click2(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Speclbl2.Text = btn.Text;

            tableLayoutSpec2.Visible = false;
            label1.BackColor = Color.DarkGray;
            label2.BackColor = Color.DarkGray;
            label3.BackColor = Color.DarkGray;
            label4.BackColor = Color.DarkGray;
            label5.BackColor = Color.BlueViolet;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            doClear();

        }

        private void doClear()
        {
            Carlb1.Text = "";
            Partlbl.Text = Carlb1.Text;
            weeklbl.Text = "";
            Speclbl.Text = weeklbl.Text;
            Speclbl2.Text = "";
            CarTableLayout.Visible = true;
            tablePartLayout.Visible = false;
            OneweekTableLayout.Visible = false;
            tableLayoutSpec.Visible = false;
            tableLayoutSpec2.Visible = false;
            label1.BackColor = Color.DarkGray;
            label2.BackColor = Color.DarkGray;
            label3.BackColor = Color.DarkGray;
            label4.BackColor = Color.DarkGray;
            label5.BackColor = Color.DarkGray;
        }
    }
}
