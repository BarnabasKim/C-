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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPage1_Click(object sender, EventArgs e)
        {
            Form1 form1 = this.Owner as Form1;

            if (form1 != null)
            {
                form1.tabControl1.SelectedTab = form1.tabPage1;
            }
        }

        private void btnPage2_Click(object sender, EventArgs e)
        {
            Form1 form1 = this.Owner as Form1;
            if (form1 != null)
            {
                form1.tabControl1.SelectedTab = form1.tabPage2;
            }
        }
    }
}
