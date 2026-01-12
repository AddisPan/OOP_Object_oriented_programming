using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeWindowsFormsApp
{
    public partial class Form1 : Form
    {
        Time myTime = new Time();
        public Form1()
        {
            InitializeComponent();
        }

        private void HourButton_Click(object sender, EventArgs e)
        {
            int hour;
            if (int.TryParse(HourTextBox.Text,out hour))
            {
                myTime.Hour = hour;
            }
            else
            {
                MessageBox.Show("輸入小時格式錯誤");
            }
            displayTime();          
        }

        private void displayTime()
        {
            string timeString = "";
            Hourlabel.Text = myTime.Hour.ToString();
            Minutelabel.Text = myTime.Minute.ToString();
            Secondlabel.Text = myTime.Second.ToString();
            timeString = myTime.Hour.ToString() + ":" + myTime.Minute.ToString() + ":" + myTime.Second.ToString();
            ShowListBox.Items.Add(timeString);
        }

        private void MinuteButton_Click(object sender, EventArgs e)
        {
            int minute;
            if (int.TryParse(MinuteTextBox.Text, out minute))
            {
                myTime.Minute = minute;
            }
            else
            {
                MessageBox.Show("輸入分鐘格式錯誤");
            }
            displayTime();
        }

        private void SecondButton_Click(object sender, EventArgs e)
        {
            int second;
            if (int.TryParse(SecondTextBox.Text, out second))
            {
                myTime.Second = second;
            }
            else
            {
                MessageBox.Show("輸入秒格式錯誤");
            }
            displayTime();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int addSecond;
            if (int.TryParse(AddTextBox.Text, out addSecond))
            {
                myTime.addSecond(addSecond);
                displayTime();
            }
            else
            {
                MessageBox.Show("輸入秒格式錯誤");
            }
        }
    }
}
