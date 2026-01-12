using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreWindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputScoreButton_Click(object sender, EventArgs e)
        {
            //班級人數
            int NumberOfStudent;
            Random rand = new Random();
            if (int.TryParse(NumberTextBox.Text,out NumberOfStudent) == true && NumberOfStudent >= 10 && NumberOfStudent <= 120)
            {
                for (int i = 0 ; i < NumberOfStudent ; i ++)
                {
                    ScoreListBox.Items.Add(rand.Next(1, 100));
                }
                //開啟統計成績按鈕
                ComputeScoreButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("請輸入學生人數(有效範圍10~120))");
                NumberTextBox.Text = "";
                NumberTextBox.Focus();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NumberTextBox.Text = "";
            ScoreListBox.Items.Clear();
            AverageScoreLabel.Text = "";
            HighestScoreLabel.Text = "";
            LowestLabel.Text = "";
        }

        private void ComputeScoreButton_Click(object sender, EventArgs e)
        {
            int SIZE = 120; //最大人數限制為120人
            double averageScore;
            //宣告陣列儲存listbox上顯示的成績
            int[] studentScore = new int[SIZE];
            for (int i = 0 ; i < ScoreListBox.Items.Count ; i ++)
            {
                studentScore[i] = int.Parse(ScoreListBox.Items[i].ToString()); //將listbox裡面的物件轉成整數的陣列
                //MessageBox.Show(studentScore.ToString());
            }

            int theHighestscore;
            int theLowestscore;
            //呼叫計算平均的Method
            averageScore = ComputeAverage(studentScore,ScoreListBox.Items.Count);
            AverageScoreLabel.Text = averageScore.ToString();
            //呼叫最高分的Method
            theHighestscore = FindthehighestScore(studentScore, ScoreListBox.Items.Count);
            HighestScoreLabel.Text = theHighestscore.ToString();
            //呼叫最低分的Method
            theLowestscore = FindtheLowestScore(studentScore, ScoreListBox.Items.Count);
            LowestLabel.Text = theLowestscore.ToString();
        }

        //定義FindtheLowestScore的Method
        private int FindtheLowestScore(int[] studentScore, int count)
        {
            int theLowestscore = 0;
            theLowestscore = studentScore[0]; //將最低分設為第一筆資料
            for (int i = 1; i < count; i++)
            {
                if (theLowestscore > studentScore[i])
                {
                    theLowestscore = studentScore[i]; //如果以分數比目前的最低分的低,將最低分轉換
                }
            }
            return theLowestscore;
        }

        //定義FindthehighestScore的Method
        private int FindthehighestScore(int[] studentScore, int count)
        {
            int theHighestscore = 0;
            theHighestscore = studentScore[0]; //將最高分設為第一筆資料
            for (int i = 1 ; i < count ; i ++)
            {
                if (theHighestscore < studentScore [i])
                {
                    theHighestscore = studentScore [i]; //如果以分數比目前的最高分的高,將最高分轉換
                }
            }
            return theHighestscore;
        }

        //定義ComputeAverage的Method
        private double ComputeAverage(int [] studentScore, int count )
        {
            double averageScore = 0;
            double totalScore = 0;
            for (int i = 0 ; i < count ; i ++  )
            {
                totalScore += studentScore[i];
            }
            averageScore = totalScore / count;
            return averageScore;
        } //end of ComputeAverage()

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
