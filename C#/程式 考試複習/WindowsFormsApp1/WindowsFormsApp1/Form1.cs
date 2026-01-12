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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int timesalary;
            int times;
            int totalsalary;

            timesalary = int.Parse(TimesalaryTextBox.Text);
            times = int.Parse(HoursTextBox.Text);
            totalsalary = timesalary * times;

            TotalSalaryLabel.Text = totalsalary.ToString();

        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("你確定要關閉嗎?", "結束表單",MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("請問確定要清除上一筆資料?", "關閉表單", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                TimesalaryTextBox.Text = "";
                HoursTextBox.Text = "";
                TotalSalaryLabel.Text = "";
            }
        }
    }
}
