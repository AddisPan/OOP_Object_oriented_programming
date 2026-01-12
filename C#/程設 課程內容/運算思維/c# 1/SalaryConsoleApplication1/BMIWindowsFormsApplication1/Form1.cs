using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//date:2019/10/15
//autor:A108222040_潘凌徵
//Objective:判斷BMI等級
namespace BMIWindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            //結束表單前詢問使用者是否確定
            DialogResult answer;
            answer = MessageBox.Show("你確定要結束表單嗎?","結束表單",MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes) //確定結束表單
            {
                this.Close();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //清除上一個使用者的資訊
            DialogResult answer;
            answer = MessageBox.Show("你確定要清除上一筆資料嗎?", "清除表單", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                TooThinRadioButton.Checked = false;
                NormalRadioButton.Checked = false;
                OverWeightRadioButton.Checked = false;
                MildobesiteRadioButton.Checked = false;
                ModerateobesityradioButton.Checked = false;
                ExtreneobesityradioButton.Checked = false;
                HeightTextBox.Text = "0";
                WeightTextBox.Text = "0";
                BMIGroupBox.Enabled = false; //將不讓使用者自行輸入BMIGroupBox
                HeightTextBox.Focus(); //讓游標出現輸入身高的位置
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BMIGroupBox.Enabled = false;
        }

        private void CaculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                float height;
                float weight;
                float BMIindex;

                //讀入使用者的身高(公分)
                height = float.Parse(HeightTextBox.Text);
                weight = float.Parse(WeightTextBox.Text);

                //計算BMI 身高單位轉為公尺
                height = height / 100; //height /= 100
                BMIindex = weight / (height * height);

                //啟用BMI判斷的顯示表格
                BMIGroupBox.Enabled = true;

                //判斷BMI等級
                if (BMIindex <= 18.5) //過輕
                {
                    TooThinRadioButton.Checked = true;
                }
                else if (BMIindex < 24 ) //18.5 <= BMI < 24 正常
                {
                    NormalRadioButton.Checked = true;
                }
                else if (BMIindex < 27) //24 <= BMI <27 過重
                {
                    OverWeightRadioButton.Checked = true;
                }
                else if (BMIindex < 30) //27 <= BMI <30 輕度肥胖
                {
                    MildobesiteRadioButton.Checked = true;
                }
                else if (BMIindex < 35) //30 <= BMI <35 中度肥胖
                {
                    ModerateobesityradioButton.Checked = true;
                }
                else //BMI >= 35
                {
                    ExtreneobesityradioButton.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                HeightTextBox.Focus(); //把游標移至輸入身高的位置
            }
        }
    }
}
