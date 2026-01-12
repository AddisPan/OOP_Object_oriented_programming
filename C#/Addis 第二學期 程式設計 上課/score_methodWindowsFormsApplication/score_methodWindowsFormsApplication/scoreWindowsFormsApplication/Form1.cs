using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoreWindowsFormsApplication
{
    public partial class 成績輸入統計 : Form
    {
        public 成績輸入統計()
        {
            InitializeComponent();
        }

        private void inputkbutton_Click(object sender, EventArgs e)
        {
            
            int score;
            
            if (int.TryParse(inputtextBox.Text, out score) == true)//將使用者輸入的"正確"資料放入表單
            {
                if (score >= 0 && score <= 100)//成績0~100
                {
                    scorelistBox.Items.Add(inputtextBox.Text);//將成績放入列表
                }
                else
                {
                    MessageBox.Show("有效成績0~100");
                }
            }
            else
            {
                MessageBox.Show("請輸入整數");
            }
            inputtextBox.Text = "";
            inputtextBox.Focus();

        }

        private void Rbutton_Click(object sender, EventArgs e)
        {
            int h_score,l_score;
            float averagescore;

            h_score = FindHighscore();//呼叫method計算最高分
            MessageBox.Show("最高分:" + h_score.ToString());

            l_score = FindLowscore();//呼叫method計算最低分
            MessageBox.Show("最低分:" + l_score.ToString());

        }

        private int FindHighscore()//Method_1
        {
            int highestscore = 0;
            int counter = 0;
            int score;

            while (counter < scorelistBox.Items.Count)//尋找之數字數量小於listBox裡資料數量
            {
                score = int.Parse(scorelistBox.Items[counter].ToString());//將listBox轉成整數分數
                if (score > highestscore)//如抓取之分數大於前抓取分數
                {
                    highestscore = score;//此抓取分數取代前抓取分數
                    
                }
                counter ++;//抓取下一個分數
            }//--> whlie
            return highestscore;//回傳值

        }//--> FindHighscore()

        private int FindLowscore()//Method_2
        {
            int lowestscore = 100;
            int counter = 0;
            int score;

            while (counter < scorelistBox.Items.Count)
            {
                score = int.Parse(scorelistBox.Items[counter].ToString());
                if (score < lowestscore)//如抓取之分數小於前抓取分數
                {
                    lowestscore = score;//此抓取分數取代前抓取分數

                }
                counter++;
            }//--> whlie
            return lowestscore;//回傳值

        }//--> FindLowscore()
    }
}
