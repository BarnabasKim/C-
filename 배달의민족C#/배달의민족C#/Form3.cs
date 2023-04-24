using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 배달의민족C_
{
    public partial class Form3 : Form
    {
        private string COOK_NAME_CODE;
        private int COOK_PRICE;
        private int COOK_COUNT;
        private Form1 _form1;

        public Form3(string COOK_NAME_CODE, int COOK_PRICE, int COOK_COUNT, Form1 form1)
        {
            InitializeComponent();
            this.COOK_NAME_CODE = COOK_NAME_CODE;
            this.COOK_PRICE = COOK_PRICE;
            this.COOK_COUNT = COOK_COUNT;

            tboxPrice.Text = COOK_PRICE.ToString();
            tboxQty.Text = COOK_COUNT.ToString();
            _form1 = form1;

          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int cookPrice = 0;
            if (!int.TryParse(tboxPrice.Text, out cookPrice))
            {
                MessageBox.Show("가격을 정확히 입력해주세요.");
                return;
            }

            int cookCount = 0;
            if (!int.TryParse(tboxQty.Text, out cookCount))
            {
                MessageBox.Show("수량을 정확히 입력해주세요.");
                return;
            }

            배달의민족_Method test = new 배달의민족_Method();
            bool result = test.UpdatePrice(COOK_NAME_CODE, cookPrice, cookCount);
            Console.WriteLine(result);

            if (result)
            {
                MessageBox.Show("가격과 수량이 업데이트되었습니다.");
                _form1.RefreshData();
                this.Close();
            }
            else
            {
                MessageBox.Show("가격 업데이트에 실패하였습니다.");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}

