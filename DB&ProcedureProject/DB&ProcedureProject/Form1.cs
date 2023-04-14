using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DB_ProcedureProject
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
          

            CProcedureTest1 test = new CProcedureTest1();
            cTestList list = test.GetFoodKategorie("COOK_CODE", "COOK_KATEGORIE");
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "COOK_KATEGORIE";
            
         
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CProcedureTest1 test = new CProcedureTest1();
            string category = comboBox1.Text;
            DataTable dt = test.GetCookList(category);

            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }


    }
}
