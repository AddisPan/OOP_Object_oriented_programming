using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootBirdWindowsFormsApp
{
    public partial class SbForm : Form
    {
        public SbForm()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int score = 0;
        int total_Shots = 0;
        int miss_Shots = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = rand.Next(300,600);
            y = rand.Next(50,300);
            BirdPictureBox.Location = new Point(x,y);
            if (miss_Shots >= 10)
            {
                timer1.Stop();
                GameOverlabel.Text = "Game Over!";
            }
        }

        private void BirdPictureBox_Click(object sender, EventArgs e)
        {
            Shot();
        }

        private void Shot()
        {
            score++;
            ScoreLabel.Text = "Score" + score.ToString();
            total_Shots++;
            TotalScorelabel.Text = "Total Shots = " + total_Shots.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Miss_Shot();
        }

        private void Miss_Shot()
        {
            miss_Shots++;
            MissTotalShotlabel.Text = "Missing Shots = " + miss_Shots.ToString();
            total_Shots++;
            TotalScorelabel.Text = "Total Shots = " + total_Shots.ToString();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            score = 0;
            miss_Shots = 0;
            total_Shots = 0;
            ScoreLabel.Text = "Score" + score.ToString();
            MissTotalShotlabel.Text = "Missing Shots = " + miss_Shots.ToString();
            TotalScorelabel.Text = "Total Shots = " + total_Shots.ToString();
            timer1.Start();
            GameOverlabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
