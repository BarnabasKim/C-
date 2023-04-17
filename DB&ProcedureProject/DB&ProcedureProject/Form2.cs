using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_ProcedureProject
{
    public partial class Form2 : Form
    {
        private string COOK_NAME_CODE;
        private int COOK_PRICE;

        public Form2(string COOK_CODE,int COOK_PRICE)
        {
            InitializeComponent();
            this.COOK_NAME_CODE = COOK_NAME_CODE;
            this.COOK_PRICE = COOK_PRICE;
            txtCookPrice.Text = COOK_PRICE.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int cookPrice = 0;
            if (!int.TryParse(txtCookPrice.Text, out cookPrice))
            {
                MessageBox.Show("가격을 정확히 입력해주세요.");
                return;
            }

            CProcedureTest1 test = new CProcedureTest1();
            bool result = test.UpdatePrice(COOK_NAME_CODE, cookPrice);

            if (result)
            {
                MessageBox.Show("가격이 업데이트되었습니다.");
                this.Close();
            }
            else
            {
                MessageBox.Show("가격 업데이트에 실패하였습니다.");
            }
        }
    }
}
