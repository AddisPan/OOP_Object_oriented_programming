using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//date:2019/10/21
//autor:A108222040_潘凌徵
//Objective:判斷何種三角形
namespace 三角形WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void JudgeButton_Click(object sender, EventArgs e)
        {
            try
            {

                //宣告變數,三邊長
                float A;
                float B;
                float C;

                A = float.Parse(Number1TextBox.Text);
                B = float.Parse(Number2TextBox.Text);
                C = float.Parse(Number3TextBox.Text);


                //判斷兩邊和之長大於第三邊
                if (A < B + C || B < A + C || C < A + B)
                {
                    MessageBox.Show("這是三角形");

                    if (A * A == B * B + C * C || B * B == A * A + C * C || C * C == A * A + B * B)
                    {
                        RighttriangleradioButton1.Checked = true;
                    }
                    else if (A * A > B * B + C * C || B * B > A * A + C * C || C * C > A * A + B * B)
                    {
                        AcutetriangleradioButton2.Checked = true;
                    }
                    else if (A * A < B * B + C * C || B * B < A * A + C * C || C * C < A * A + B * B)
                    {
                        ObtusetriangleradioButton3.Checked = true;
                    }

                }
                else
                {
                    MessageBox.Show("這不是三角形");
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("你確定要清除上一筆資料嗎?", "清除表單", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                Number1TextBox.Text = "";
                Number2TextBox.Text = "";
                Number3TextBox.Text = "";
                RighttriangleradioButton1.Checked = false;
                AcutetriangleradioButton2.Checked = false;
                ObtusetriangleradioButton3.Checked = false;
                
            }
        }
    }
}
