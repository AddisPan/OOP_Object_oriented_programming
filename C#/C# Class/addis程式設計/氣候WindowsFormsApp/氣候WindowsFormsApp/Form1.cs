using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 氣候WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            //宣告變數
            int Leapyear = 0;
            int inLeapyear = 0;
            int year = int.Parse(YearTextBox.Text);

                //除以四為整除,除以一百不整除,除以四百能整除
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    Leapyear = int.Parse(YearTextBox.Text);
                }
                else
                {
                inLeapyear = int.Parse(YearTextBox.Text);
                }
            //年、月
            int Year;
            int Month;
            Random rand = new Random();
            if (int.TryParse(YearTextBox.Text, out Year) == true && int.TryParse(MonthTextBox.Text, out Month) == true && Month == 31)
            { 
                for (int i = 0; i < Year && i < Month; i++)
                {
                    WeatherListBox.Items.Add(rand.Next(24, 38));
                }
                //開啟統計氣候按鈕
                ComputeButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("請輸入(有效範圍1~12))");
                YearTextBox.Text = "";
                YearTextBox.Focus();
                MonthTextBox.Text = "";
                MonthTextBox.Focus();
            }
        }
    }
}
