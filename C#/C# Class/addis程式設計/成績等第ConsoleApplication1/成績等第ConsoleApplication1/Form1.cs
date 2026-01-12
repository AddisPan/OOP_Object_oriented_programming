using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//date:2019/9/28
//Autor:A108222040 潘凌徵
//Objective:成績等第計算
namespace 成績等第ConsoleApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //將使用者輸入的成績轉成整數資料型態
            int first = int.Parse(FirstScoreTextBox.Text);
            int second = int.Parse(SecondScoreTextBox.Text);
            int third = int.Parse(ThirdScoreTextBox.Text);

            //判斷成績為哪個等第,(90以下為B,80以下為C,70以下為D,60以下為F,其他為A)
            if (first < 60)
            {
                ScoreLevel1Label.Text = ("F");
            }
            else if (first < 70)
            {
                ScoreLevel1Label.Text = ("D");
            }
            else if (first < 80)
            {
                ScoreLevel1Label.Text = ("C");
            }
            else if (first < 90)
            {
                ScoreLevel1Label.Text = ("B");
            }
            else
            {
                ScoreLevel1Label.Text = ("A");
            }



            if (second < 60)
            {
                ScoreLevel2Label.Text = ("F");
            }
            else if (second < 70)
            {
                ScoreLevel2Label.Text = ("D");
            }
            else if (second < 80)
            {
                ScoreLevel2Label.Text = ("C");
            }
            else if (second < 90)
            {
                ScoreLevel2Label.Text = ("B");
            }
            else
            {
                ScoreLevel2Label.Text = ("A");
            }



            if (third < 60)
            {
                ScoreLevel3Label.Text = ("F");
            }
            else if (third < 70)
            {
                ScoreLevel3Label.Text = ("D");
            }
            else if (third < 80)
            {
                ScoreLevel3Label.Text = ("C");
            }
            else if (third < 90)
            {
                ScoreLevel3Label.Text = ("B");
            }
            else
            {
                ScoreLevel3Label.Text = ("A");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //清除上一筆資料
            FirstScoreTextBox.Text = ("");
            SecondScoreTextBox.Text = ("");
            ThirdScoreTextBox.Text = ("");
            ScoreLevel1Label.Text = ("");
            ScoreLevel2Label.Text = ("");
            ScoreLevel3Label.Text = ("");
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            //關閉表單
            this.Close();
        }
    }
}