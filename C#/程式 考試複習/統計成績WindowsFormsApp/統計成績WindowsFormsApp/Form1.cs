using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 統計成績WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            int score;

            if (int.TryParse(InputTextBox.Text,out score))
            {
                if (score >= 0 && score <= 100)
                {
                    ScoreListBox.Items.Add(InputTextBox.Text);
                }
                else
                {
                    MessageBox.Show("請輸入有效數字1~100");
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
            int highestScore;
            int lowestScore;
            float averageScore;

            highestScore = FindHighestScore();
            MessageBox.Show("最高分是:" + highestScore.ToString());

            lowestScore = FindLowestScore();
            MessageBox.Show("最低分是:" + lowestScore.ToString());

            averageScore = FindAverageScore();
            MessageBox.Show("平均分是:" + averageScore.ToString());
        }

        private int FindHighestScore()
        {
            int highScore = 0;
            int counter = 0;
            int score;

            while (counter < ScoreListBox.Items.Count)
            {
                score = int.Parse(ScoreListBox.Items[counter].ToString());
                if (score > highScore)
                {
                    highScore = score;
                }

                counter++;
            }
            return highScore;
        }

        private int FindLowestScore()
        {
            int lowScore = 100;
            int counter = 0;
            int score;

            while (counter < ScoreListBox.Items.Count)
            {
                score = int.Parse(ScoreListBox.Items[counter].ToString());
                if (score < lowScore)
                {
                    lowScore = score;
                }
                counter++;
            }
            return lowScore;
        }

        private float FindAverageScore()
        {
            int averageScore;
            int counter = 0;
            int score;
            int total = 0;

            while (counter < ScoreListBox.Items.Count)
            {
                score = int.Parse(ScoreListBox.Items[counter].ToString());
                total = total + score;
                counter++;
            }
            averageScore = total / counter;
            return averageScore;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ScoreListBox.Items.Clear();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
