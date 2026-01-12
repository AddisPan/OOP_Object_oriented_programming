using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWindowsFormsApp
{
    public partial class ScreenSaverForm : Form
    {
        public ScreenSaverForm()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            //顯示目前時間
            TimeLabel.Text = DateTime.Now.ToString();
            TimeLabel.Left -= 15; //小時鐘往左移
            if (TimeLabel.Right < 0) //移出左邊邊界時候
            {
                TimeLabel.Left = this.Width; //移到右方出場  
                TimeLabel.Top = rand.Next(this.Height - TimeLabel.Height); //隨機變化出現的高度
            }
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString();
            timer1.Start(); //啟動小時鐘
            timer2.Start(); //啟動小時鐘
            timer3.Start();
        }

        private void ScreenSaverForm_Click(object sender, EventArgs e)
        {
            Application.Exit(); //退出(結束)
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int D = rand.Next(this.Height); //隨機決定半徑
            int X = rand.Next(this.Width - D); //隨機決定左緣座標
            int Y = rand.Next(this.Height - D); //隨機決定上緣座標
            Bitmap bg = new Bitmap(this.Width,this.Height); //建立影像的物件
            Graphics g = Graphics.FromImage(bg); //建立繪圖的物件
            Color C = Color.FromArgb(rand.Next(0,255), rand.Next(0, 255), rand.Next(0, 255)); //隨機決定顏色
            SolidBrush B = new SolidBrush(C); //建立筆刷物件
            g.FillEllipse(B,X,Y,D,D); //繪製實心的圓

            this.BackgroundImage = bg; //設定為表單背景的影像
        }

        int curPicture = 0; //目前影像編號
        private void timer3_Tick(object sender, EventArgs e)
        {
            curPicture += 1; //下一張

            if (curPicture > 4)
            {
                curPicture = 1; //播完從頭
            }
            switch (curPicture)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.Sponge;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.Earth;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.Lake;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources.Sun;
                    break;
            }
        }
    }
}
