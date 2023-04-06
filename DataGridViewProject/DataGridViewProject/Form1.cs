using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewProject
{
    public partial class Form1 : Form
    {
        List<Food> _list = new List<Food>();
        List<Food> _koreanFoodList = new List<Food>();
        List<Food> _chineseFoodList = new List<Food>();
        List<Food> _westernFoodList = new List<Food>();

        int _pageSize = 10; // 한 페이지에 보여줄 아이템 개수
        int _currentPage = 1; // 현재 페이지
        int _totalPage; // 
        private List<Food> _currentList;

        

        public Form1()
        {
            InitializeComponent();
            Form1_Load();
            //Form2 form2 = new Form2(FooddataGridView,dataGridView1,a);
            SetPaging();

        }

        //페이징 구현
        private void SetPaging()
        {
            int totalCount = _list.Count; // 전체 아이템 개수
            _totalPage = (int)Math.Ceiling(totalCount / (double)_pageSize); // 전체 페이지 개수 계산

            if (_currentPage < 1)
                _currentPage = 1; // 현재 페이지가 1보다 작으면 1로 설정
            else if (_currentPage > _totalPage)
                _currentPage = _totalPage; // 현재 페이지가 전체 페이지보다 크면 전체 페이지로 설정

            // 현재 페이지에 해당하는 아이템 리스트 추출
            _currentList = _list.Skip((_currentPage - 1) * _pageSize).Take(_pageSize).ToList();

            // DataGridView 데이터 소스 설정
            FooddataGridView.DataSource = _currentList;

            // 페이징 정보 출력
            lblPageNumber.Text = $" {_currentPage} / {_totalPage}";
        }

        private void Form1_Load()
        {
            string[] data = { "전체", "한식", "중식", "양식" };
            comboBox1.Items.AddRange(data);
            comboBox1.SelectedIndex = 0;
           
            _koreanFoodList.Add(new Food("한식","비빔밥"));
            _koreanFoodList.Add(new Food("한식", "육개장"));
            _koreanFoodList.Add(new Food("한식", "부침개"));
            _koreanFoodList.Add(new Food("한식", "치킨"));
            _koreanFoodList.Add(new Food("한식", "치킨"));
            _koreanFoodList.Add(new Food("한식", "치킨"));
            _koreanFoodList.Add(new Food("한식", "치킨"));
            _koreanFoodList.Add(new Food("한식", "치킨"));

            _chineseFoodList.Add(new Food("중식", "짜장면"));
            _chineseFoodList.Add(new Food("중식", "짬뽕"));
            _chineseFoodList.Add(new Food("중식", "탕수육"));
            _chineseFoodList.Add(new Food("중식", "양장피"));
            _chineseFoodList.Add(new Food("중식", "꿔바로우"));
            _chineseFoodList.Add(new Food("중식", "꿔바로우"));
            _chineseFoodList.Add(new Food("중식", "꿔바로우"));
            _chineseFoodList.Add(new Food("중식", "꿔바로우"));
            _chineseFoodList.Add(new Food("중식", "꿔바로우"));

            _westernFoodList.Add(new Food("양식", "파스타"));
            _westernFoodList.Add(new Food("양식", "샐러드"));
            _westernFoodList.Add(new Food("양식", "빠에야"));
            _westernFoodList.Add(new Food("양식", "피자"));
            _westernFoodList.Add(new Food("양식", "스테이크"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));

        }



        //조회 버튼
        private void getFood_Click(object sender, EventArgs e)
        {
            
            _list.Clear();

            if (comboBox1.SelectedIndex == 0) // 전체
            {
                _list.AddRange(_koreanFoodList);
                _list.AddRange(_chineseFoodList);
                _list.AddRange(_westernFoodList);
            }
            else if (comboBox1.SelectedIndex == 1) // 한식
            {
                _list.AddRange(_koreanFoodList);
            }
            else if (comboBox1.SelectedIndex == 2) // 중식
            {
                _list.AddRange(_chineseFoodList);
            }
            else if (comboBox1.SelectedIndex == 3) // 양식
            {
                _list.AddRange(_westernFoodList);
            }
            SetPaging();

            //페이징 전 조회 기능 구현
            /* string selectedOption = comboBox1.SelectedItem.ToString();
            switch (selectedOption)
            {
                case "전체":
                    _list = _koreanFoodList.Concat(_chineseFoodList).Concat(_westernFoodList).ToList();
                    break;
                case "한식":
                    _list = _koreanFoodList;
                    break;
                case "중식":
                    _list = _chineseFoodList;
                    break;
                case "양식":
                    _list = _westernFoodList;
                    break;
            }
              FooddataGridView.DataSource = _list;
            */




        }
       
        private void FooddataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = FooddataGridView.Rows[e.RowIndex];
                string name = selectedRow.Cells[2].Value.ToString();

                Form2 form2 = new Form2(FooddataGridView, dataGridView1, name);
                form2.ShowDialog();

            }

        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            SetPaging();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _currentPage--;
            SetPaging();
        }

        //검색 기능 구현중
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var bindingSouce = (BindingSource)FooddataGridView.DataSource;
            var dataTable = (DataTable)bindingSouce.DataSource;

            string searchText = textBox1.Text;

            if (string.IsNullOrEmpty(searchText))
            {
                bindingSouce.Filter = "";
            }
            else
            {
                bindingSouce.Filter = string.Format("Name LIKE '%{0}%' OR Type LIKE '%{0}%'", searchText);
            }
        }
    }
}
