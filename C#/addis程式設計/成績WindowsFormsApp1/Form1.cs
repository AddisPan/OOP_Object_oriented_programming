using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 成績WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            //將使用者輸入正確的資料放入表單中
            int score;

            if (int.TryParse(InputTextBox.Text, out score))
            {
                //有效成績是 0~100
                if (score >= 0 && score <= 100)
                {
                    //將成績放入列表
                    ScoreListbox.Items.Add(InputTextBox.Text);
                }
                else
                {
                    MessageBox.Show("有效成績是0~100!");
                }
            }
            else
            {
                MessageBox.Show("請輸入整數資料!");
            }
            InputTextBox.Text = "";
            InputTextBox.Focus();
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            // 宣告變數
            int highestScore;
            int lowestScore;
            float AverageScore;
            //呼叫Method計算最高分
            highestScore = FindHighScore();
            MessageBox.Show("最高分是:" + highestScore.ToString());
            //呼叫Method計算低高分
            lowestScore = FindLowestScore();
            MessageBox.Show("最低分是:" + lowestScore.ToString());
            //呼叫Method計算平均
            AverageScore = FindAverageScore();
            MessageBox.Show("平均是:" + AverageScore.ToString());
        }
        //定義FindHighScore() method
        private int FindHighScore()
        {
            int highScore = 0;
            int counter = 0;
            int score;
            while (counter < ScoreListbox.Items.Count) //從listbox中逐筆找出最高分
            {
                score = int.Parse(ScoreListbox.Items[counter].ToString()); //將listbox資料轉成整數分數
                if (score > highScore) //如果分數大於目前最高分
                {
                    highScore = score; //分數取代原先最高分
                }
                //讀下一筆資料
                counter++;
            } //end of while
            return highScore;
        } //end of FindHighScore()

        //定義FindLowScore() method
        private int FindLowestScore()
        {
            int LowScore = 100; //將目前最低分設為100
            int counter = 0;
            int score;
            while (counter < ScoreListbox.Items.Count) //從listbox中逐筆找出最低分
            {
                score = int.Parse(ScoreListbox.Items[counter].ToString()); //將listbox資料轉成整數分數
                if (score < LowScore) //如果分數大於目前最低分
                {
                    LowScore = score; //分數取代原先最低分
                }
                //讀下一筆資料
                counter++;
            } //end of while
            return LowScore;
        } //end of FindLowScore()

        //定義AverageScore() method
        private int FindAverageScore()
        {
            int AverageScore;
            int counter = 0;
            int score;
            int total = 0;
            while (counter < ScoreListbox.Items.Count) //從listbox中逐筆找出平均
            {
                score = int.Parse(ScoreListbox.Items[counter].ToString()); //將listbox資料轉成整數分數

                total = total + score;
                counter++;
            } //end of while
            AverageScore = total / counter;
            return AverageScore;
        }//end of FindAverageScore()

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ScoreListbox.Items.Clear();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
