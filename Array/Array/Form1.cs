﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArrayTest();
            ArrayClassTest();
        }


        private void ArrayTest()
        {
            /* int iDay1 = 10;
             int iDay2 = 20;
             int iDay3 = 30;*/


            //string strT1 = "가,나,다,라";
            //string[] strTEST = strT1.Split(',');
            //string[] strTESTArray = { "가", "나", "다", "라" };

            int[] iArraytest1 = { 1, 2, 3, 4, 5 } ;

            int[] iArrayTess2 = new int [5] { 1, 2, 3, 4, 5 }; 
            int[] iArrayTest3 = new int[5];
            iArrayTest3[2] = 3;
            iArrayTest3[4] = 5;
            //iArrayTest3[5] = 5;


            int[,] ArrayTest4 = new int[2, 4]
            { { 1, 2, 3, 4 },  { 10, 20, 30, 40} };


        }


        private void ArrayClassTest()
        {
            int[] iTest = { 10, 20, 30, 40, 50 };


            int i = iTest.Length;




            Array.Clear(iTest, 2, 2);

            Array.Resize(ref iTest, 10 );


            int iSearch30 = Array.IndexOf(iTest, 50);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dgDay.Rows.Clear();

            int[] iTest = { 10, 5, 30, 40, 50, 15, 8 };

            lblArrayCount.Text = String.Format("전체 자료 수 : {0}", iTest.Length.ToString()); 

            dgDay["colDay1", 0].Value = iTest[0];
            dgDay["colDay2", 0].Value = iTest[1];
            dgDay["colDay3", 0].Value = iTest[2];
            dgDay["colDay4", 0].Value = iTest[3];
            dgDay["colDay5", 0].Value = iTest[4];
            dgDay["colDay6", 0].Value = iTest[5];
            dgDay["colDay7", 0].Value = iTest[6];
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            
            dgDay.Rows.Clear();

            int[,] iTest = { { 10, 5, 30, 40, 50, 15, 8 }, { 11, 15, 15, 14, 30, 18, 9 } };

            lblArrayCount.Text = String.Format("전체 자료 수 : {0}", iTest.Length.ToString());

            dgDay.Rows.Add();

            dgDay["colDay1", 0].Value = iTest[0,0];
            dgDay["colDay2", 0].Value = iTest[0,1];
            dgDay["colDay3", 0].Value = iTest[0,2];
            dgDay["colDay4", 0].Value = iTest[0,3];
            dgDay["colDay5", 0].Value = iTest[0,4];
            dgDay["colDay6", 0].Value = iTest[0,5];
            dgDay["colDay7", 0].Value = iTest[0,6];

            dgDay["colDay1", 1].Value = iTest[1,0];
            dgDay["colDay2", 1].Value = iTest[1,1];
            dgDay["colDay3", 1].Value = iTest[1,2];
            dgDay["colDay4", 1].Value = iTest[1,3];
            dgDay["colDay5", 1].Value = iTest[1,4];
            dgDay["colDay6", 1].Value = iTest[1,5];
            dgDay["colDay7", 1].Value = iTest[1,6];
        }
    }
}
