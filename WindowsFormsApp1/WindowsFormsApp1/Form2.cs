using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ChildForm : Form
    {
        String RecivedData;
        public ChildForm(string txtMsg)
        {
            InitializeComponent();

            RecivedData += txtMsg;
            
            display2.Text = RecivedData;
        }

        public void testtt(string test)
        {
            DialogResult = DialogResult.OK;
            display2.Text = test;
        }


    }
    
}
