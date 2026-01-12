using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Date myDate = new Date(); //新建一個Date的物件
        public Form1()
        {
            InitializeComponent();
        }

        private void MonthButton_Click(object sender, EventArgs e)
        {
            int setMonth;

            if (int.TryParse(MonthTextBox.Text,out setMonth))
            {
                myDate.Month = setMonth;
            }
            else
            {
                MessageBox.Show("輸入錯誤的月分資料");
            }
            displayDate();
        }

        private void displayDate()
        {
            string timeString = "";
            Monthlabel.Text = myDate.Month.ToString();
            Daylabel.Text = myDate.Day.ToString();
            timeString = myDate.Month.ToString() + "/" + myDate.Day.ToString();
            ShowListBox.Items.Add(timeString);
        }

        private void DateButton_Click(object sender, EventArgs e)
        {
            int setDay;

            if (int.TryParse(DateTextBox.Text, out setDay))
            {
                myDate.Day = setDay;
            }
            else
            {
                MessageBox.Show("輸入錯誤的日期資料");
            }
            displayDate();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int moreDays;
            if (int.TryParse(AddTextBox.Text,out moreDays))
            {
                myDate.addDays(moreDays);
                displayDate();
            }
            else
            {
                MessageBox.Show("增加日期格式錯誤");
            }
        }
    }
}
