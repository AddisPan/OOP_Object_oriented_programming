using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//date:2019/10/13
//Autor:A108222040_潘凌徵
//Objective:是否為閏年
namespace 閏年WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void JudgeButton_Click(object sender, EventArgs e)
        {
            int Leapyear = 0;
            int inLeapyear = 0;

            //將YearTextBox轉成整數,閏年為:除以四為整除,除以一百不整除,除以四百能整除
            int year = int.Parse(YearTextBox.Text);
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                MessageBox.Show(Leapyear + "輸入的是閏年！");
            }
            else
            {
                MessageBox.Show(inLeapyear + "輸入的不是閏年！");
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {

            //不得輸入大於4000以上的數字
            try 
            {
                int number; //輸入年的數目
                number = int.Parse(YearTextBox.Text);
                if (number > 4000)
                {
                    MessageBox.Show("不符合!");
                }
            }
            catch
            {
                //如果是非整數
                MessageBox.Show("請輸入整數!");
                YearTextBox.Text = "0";
            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            //宣告變數
            int Leapyear = 0;
            int inLeapyear = 0;
            int year = int.Parse(YearTextBox.Text);
           
            try
            {
                //除以四為整除,除以一百不整除,除以四百能整除
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    MessageBox.Show("輸入的是閏年！");
                    Leapyear += 1;
                }
                else
                {
                    MessageBox.Show("輸入的不是閏年！");
                    inLeapyear += 1;
                }
            }
            catch
            {
                //宣告變數接受使用者在訊息視窗中回答
                DialogResult ans;
                ans = MessageBox.Show("閏年和非閏年的次數", "閏年次數的統計", MessageBoxButtons.YesNo);
                if (ans == DialogResult.Yes)
                {
                    MessageBox.Show("閏年的次數為:" + Leapyear);
                }
                if (ans == DialogResult.No)
                {
                    MessageBox.Show("非閏年的次數:" + inLeapyear);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //清除資料
            YearTextBox.Text = "";
        }
    }
    }
