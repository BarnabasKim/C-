using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Paging
{
    public partial class Form1 : Form
    {



        private int currentPage = 1; // 현재 페이지
        private int pageSize = 3; // 한 페이지에 보여줄 버튼의 개수
        private int  _totalPages; // 총 페이지

        List<Button> btns = new List<Button>();
        

        public Form1()
        {
            InitializeComponent();

 
            //이벤트 추가전 
      /*      for (int i = 0; i < 15; i++)
            {
                char c = (char)('A' + i); // 알파벳 문자 계산
                btns.Add(new Button()
                {
                    Text = c.ToString(),
                    BackColor = Color.Black,
                    ForeColor = Color.White,
                    Font = new Font("굴림", 16),
                    Size = new Size(150, 80),
 
                });

            }*/
        // 동적 버튼 이벤트 추가
            for (int i = 0; i < 14; i++)
            {
                char c = (char)('A' + i); // 알파벳 문자 계산
                Button btn = new Button();

                btn.Text = c.ToString();
                btn.BackColor = Color.Black;
                btn.ForeColor = Color.White;
                btn.Font = new Font("굴림", 16);
                btn.Size = new Size(150, 80);
 
                
                btn.Click += new EventHandler(btnClick_Event);
                btns.Add(btn);
            }
            
            // 총 페이지 계산
            _totalPages = (int)Math.Ceiling(btns.Count / (double)pageSize);

            // 초기 버튼 설정
            Updateitems();


        }
        /// <summary>
        /// pageBtns : 현재 페이지에 해당하는 버튼 추출
        /// Skip 함수의 인덱스는 0부터 시작한다.
        /// </summary>
        private void Updateitems()
        {
            var pageBtns = btns.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            flowLayoutPanel1.Controls.Clear();

            foreach (var btn in pageBtns)
            {
                flowLayoutPanel1.Controls.Add(btn);
            }

            // 현재 페이지와 총 페이지 출력
            lblPaging.Text = $"{currentPage} / {_totalPages}";
        }


   
        

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < _totalPages)
            {
                currentPage++;
                Updateitems();
            }
        }

        private void btnBackPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                Updateitems();
            }
        }


        private void btnClick_Event(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show(button.Text);
        }


    }


}
