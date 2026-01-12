using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//date:2019/9/24
//Autor:A108222040
//Objective:資料型態轉換練習
namespace averageWindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //將使用者輸入的成績轉為整數資料型態
            int first = int.Parse(FirstscoreTextBox.Text);
            int second = int.Parse(SecondscoreTextBox.Text);
            int third = int.Parse(ThirdscoreTextBox.Text);

            //宣告浮點型態變數,儲存平均分數
            float averageScore;

            //將三科總分強制轉型為浮點數型態
            averageScore = (float)(first + second + third) / 3;

            //將平均成績顯示在表單上,取小數點後一位
            Averagelabel.Text = averageScore.ToString("n1");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //關閉表單
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //清除上一筆資料
            FirstscoreTextBox.Text = "";
            SecondscoreTextBox.Text = "";
            ThirdscoreTextBox.Text = "";
            Averagelabel.Text = "";
        }
    }
}
