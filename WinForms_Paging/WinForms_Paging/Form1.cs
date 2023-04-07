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
        private int currentPage = 1;
        private int pageSize = 3;
        private int totalPages = 5;

        
        

        public Form1()
        {
            InitializeComponent();
            Updateitems();

            List<Button> btn = new List<Button>();
            btn.Add(new Button() { Text = "A" });
            btn.Add(new Button() { Text = "B" });
            btn.Add(new Button() { Text = "C" });
            btn.Add(new Button() { Text = "D" });
            btn.Add(new Button() { Text = "E" });
            btn.Add(new Button() { Text = "F" });
            btn.Add(new Button() { Text = "G" });
            btn.Add(new Button() { Text = "H" });
            btn.Add(new Button() { Text = "I" });
            btn.Add(new Button() { Text = "J" });
        
        
        }

        private void Updateitems()
        {
            flowLayoutPanel1.Controls.Clear();


            var items = GetItemsForPage(currentPage, pageSize);

            flowLayoutPanel1.Controls.AddRange(items.ToArray());
        }


        private List<Button> GetItemsForPage(int page, int itemsPerPage)
        {
            var items = new List<Button>();

            int startIndex = (page - 1) * itemsPerPage;
            int endIndex = Math.Min(startIndex + itemsPerPage, flowLayoutPanel1.Controls.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                items.Add((Button)flowLayoutPanel1.Controls[i]);
            }

            return items;

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
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


    }


}
