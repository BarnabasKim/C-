using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataGridViewProject
{
    public partial class Form2 : Form
    {
        private DataGridView _foodDataGridView;
        private DataGridView _dataGridView1;
        private String _name;

        public Form2(DataGridView foodDataGridView, DataGridView dataGridView1, string name)
        {
            InitializeComponent();
            _foodDataGridView = foodDataGridView;
            _dataGridView1 = dataGridView1;
            _name = name;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /* string textBoxValue = textbox1.Text;*/
           string numericBoxValue = numericUpDown.Value.ToString();

            _dataGridView1.Rows.Add(_name, numericBoxValue);

            this.Close();
          
        }


    }
}
