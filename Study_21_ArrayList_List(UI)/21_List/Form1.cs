using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_List
{
    public partial class Form1 : Form
    {
        enum enBossName
        {
            보검,
            신혜,
            해인,
            보영,
        }

        enum enClassName
        {
            진,
            정국,
            RM,
            지민,
            제이홉,
            뷔,
            슈가,

            은비,
            사쿠라,
            혜원,
            예나,
            채연,
            채원,
            민주,
            히토미,
            유리,
            유진,
            원영,
            나코,
        }

        List<string> _strList = new List<string>();  // List의 경우 Type을 선언 하고 사용
        ArrayList _arList = new ArrayList();

        int _iPlayerCount = 0;

        Hashtable _ht = new Hashtable();
        Dictionary<string, string> _dic = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();


            //dgViewList.Columns.Add("dgKey", "Key");  // Column 추가
            //dgViewList.Columns.Add("dgValue", "Value");  // Column 추가
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;

            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "pbox1":
                    strSelectText = enBossName.보검.ToString();
                    break;
                case "pbox2":
                    strSelectText = enBossName.신혜.ToString();
                    break;
                case "pbox3":
                    strSelectText = enBossName.해인.ToString();
                    break;
                case "pbox4":
                    strSelectText = enBossName.보영.ToString();
                    break;
            }

            int iTotalCount = Enum.GetValues(typeof(enClassName)).Length;

            if (iTotalCount > _iPlayerCount)
            {
                enClassName enName = (enClassName)_iPlayerCount;

                _dic.Add(enName.ToString(), strSelectText);

                fUIDisplay(iTotalCount, enName.ToString());
                fDataGridViewDisplay();

                _iPlayerCount++;
            }
            else
            {
                lblPlayerName.Text = "투표를 완료 하였습니다.";
            }

        }

        bool _click = false;

        private void fUIDisplay(int iTotalCount, string strPlayerName)
        {
            int i보검 = 0;
            int i신혜 = 0;
            int i해인 = 0;
            int i보영 = 0;

            foreach (string oitem in _dic.Values)
            {
                // string 값을 enum으로 형변환 하는 부분

                switch (oitem)
                {
                    case "보검":
                        i보검++;
                        break;
                    case "신혜":
                        i신혜++;
                        break;
                    case "해인":
                        i해인++;
                        break;
                    case "보영":
                        i보영++;
                        break;
                }
            }

            lblPick1.Text = i보검.ToString();
            lblPick2.Text = i신혜.ToString();
            lblPick3.Text = i해인.ToString();
            lblPick4.Text = i보영.ToString();


            // 0 / 0
            lblTotalCount.Text = string.Format("{0} / {1}", _iPlayerCount + 1, iTotalCount);
            lblPlayerName.Text = strPlayerName;
        }


        private void fDataGridViewDisplay()
        {
            //dgViewList.DataSource = _strList.Select(x => new { Value = x }).ToList();

            dgViewList.DataSource = _dic.ToArray();


            //dgViewList.Rows.Clear();

            //foreach (KeyValuePair<string,string> oitem in _dic)
            //{
            //    dgViewList.Rows.Add(oitem.Key, oitem.Value);
            //}

            foreach (DataGridViewRow oRow in dgViewList.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }

            dgViewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

    }
}