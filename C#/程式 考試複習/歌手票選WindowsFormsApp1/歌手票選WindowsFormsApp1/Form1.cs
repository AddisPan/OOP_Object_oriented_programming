using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 歌手票選WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int highestScore = -1;
        int secondScore = -1;
        string highestfood;
        string secondfood;

        int Chickenscore = 0;
        int Hamburgerscore = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void VoteButton_Click(object sender, EventArgs e)
        {
            if (ChickenRadioButton.Checked == true)
            {
                Chickenscore += 1;
            }

            if (HamburgerRadioButton.Checked == true)
            {
                Hamburgerscore += 1;
            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            DialogResult answer;

            answer = MessageBox.Show("只顯示地一名嗎?", "選擇票選結果", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                if (Chickenscore >= highestScore)
                {
                    highestScore = Chickenscore;
                    highestfood = ChickenRadioButton.Text;
                }
                if (Hamburgerscore >= highestScore)
                {
                    highestScore = Hamburgerscore;
                    highestfood = HamburgerRadioButton.Text;
                }
                HighestScoreLabel.Text = highestScore.ToString();
                HighestFoodLabel.Text = highestfood;
                
            }
            else
            {
                if (Chickenscore > Hamburgerscore)
                {

                    highestScore = Chickenscore;
                    highestfood = ChickenRadioButton.Text;

                    secondScore = Hamburgerscore;
                    secondfood = HamburgerRadioButton.Text;
                }
                else
                {
                    highestScore = Hamburgerscore;
                    highestfood = HamburgerRadioButton.Text;

                    secondScore = Chickenscore;
                    secondfood = ChickenRadioButton.Text;
                }
                HighestScoreLabel.Text = highestScore.ToString();
                HighestFoodLabel.Text = highestfood;
                SecondScoreLabel.Text = secondScore.ToString();
                SecondFoodLabel.Text = secondfood;
            }
        }

        private void NextseasonButton_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("確定要清空目前的資料嗎?", "新一季的投票開始", MessageBoxButtons.OKCancel);
            if (ans == DialogResult.OK)
            {
                Chickenscore = 0;
                Hamburgerscore = 0;

                highestScore = 0;
                secondScore = 0;

                highestfood = "";
                secondfood = "";

                HighestScoreLabel.Text = "";
                HighestFoodLabel.Text = "";

                SecondScoreLabel.Text = "";
                SecondFoodLabel.Text = "";
            }

        }
    }
}    
