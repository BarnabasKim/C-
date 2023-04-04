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

        public Form1()
        {
            InitializeComponent();
            Form1_Load();

            

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

            _chineseFoodList.Add(new Food("중식", "짜장면"));
            _chineseFoodList.Add(new Food("중식", "짬뽕"));
            _chineseFoodList.Add(new Food("중식", "탕수육"));
            _chineseFoodList.Add(new Food("중식", "양장피"));
            _chineseFoodList.Add(new Food("중식", "꿔바로우"));

            _westernFoodList.Add(new Food("양식", "파스타"));
            _westernFoodList.Add(new Food("양식", "샐러드"));
            _westernFoodList.Add(new Food("양식", "빠에야"));
            _westernFoodList.Add(new Food("양식", "피자"));
            _westernFoodList.Add(new Food("양식", "스테이크"));
            _westernFoodList.Add(new Food("양식", "바질페스토"));

        }



        //조회 버튼
        private void getFood_Click(object sender, EventArgs e)
        {
            /*  Food _food = new Food();
             if(comboBox1.SelectedIndex == 0)
             {

                 _food.Type = "한식";
                 _food.Name = "비빔밥";
                 _list.Add(_food);
                 FooddataGridView.DataSource = _list;
             }*/
            string selectedOption = comboBox1.SelectedItem.ToString();
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


        }

        private void FooddataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView; 

            int curRow = e.1
        }
    }
}
