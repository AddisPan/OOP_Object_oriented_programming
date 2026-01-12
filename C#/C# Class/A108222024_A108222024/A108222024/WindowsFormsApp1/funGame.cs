using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class funGame : Form
    {
        public funGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "決鬥")
            {
                timer1.Enabled = true;
                button1.Text = "停止";
            }
            else if (button1.Text =="停止")
            {
                timer1.Enabled = false;
                check();
                button1.Text = "決鬥";
            }
            
            
        }
        private int[] imageCount = new int[6];
        private void timer1_Tick(object sender, EventArgs e)
        {
            int count = 0, temp = 0; ;
            
            Random r1 = new Random();
            count += 1; temp = (r1.Next(0, imageList1.Images.Count) + count) % 6; imageCount[0] = temp;
            pictureBox1.Image = imageList1.Images[temp];
            count += 1; temp = (r1.Next(0, imageList1.Images.Count) + count) % 6; imageCount[1] = temp;
            pictureBox2.Image = imageList1.Images[temp];
            count += 1; temp = (r1.Next(0, imageList1.Images.Count) + count) % 6; imageCount[2] = temp;
            pictureBox3.Image = imageList1.Images[temp];
            count += 1; temp = (r1.Next(0, imageList1.Images.Count) + count) % 6; imageCount[3] = temp;
            pictureBox4.Image = imageList1.Images[temp];
            count += 1; temp = (r1.Next(0, imageList1.Images.Count) + count) % 6; imageCount[4] = temp;
            pictureBox5.Image = imageList1.Images[temp];
            count += 1; temp = (r1.Next(0, imageList1.Images.Count) + count) % 6; imageCount[5] = temp;
            pictureBox6.Image = imageList1.Images[temp];
           
        }
        int playertotal = 0, computertotal = 0,safe =0;
        private void check()
        {
            int player = imageCount[3] + imageCount[4] + imageCount[5] + 3;
            int computer = imageCount[0] + imageCount[1] + imageCount[2] + 3;
            label3.Text = computer.ToString();
            label4.Text = player.ToString();

            if (player > computer)
            {
                MessageBox.Show("玩家獲勝");
                playertotal += 1;
               
            }
            else if (player<computer)
            {
                MessageBox.Show("電腦獲勝");
                
                computertotal +=1;
            }
            else
            {
                MessageBox.Show("平局");
                safe += 1;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (playertotal > computertotal)
            {
                MessageBox.Show($"玩家勝場 : {playertotal} , 電腦勝場 : {computertotal},平局 : {safe} , 玩家此賽勝利");    
            }
            else if (playertotal < computertotal)
            {
                MessageBox.Show($"玩家勝場 : {playertotal} , 電腦勝場 : {computertotal},平局 : {safe} , 電腦此賽勝利");

            }
            else
            {
                MessageBox.Show($"玩家勝場 : {playertotal} , 電腦勝場 : {computertotal},平局 : {safe} , 平局");

            }
            this.Close();
        }
    }
}
