using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesWindowsFormsApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            //執行計算
            double rightValue = double.Parse(DisplayLabel.Text); //計算式的右值
            double answer = 0;

            //根據運算值來做計算
            switch (op)
            {
                case "+":
                    answer = leftValue + rightValue;
                    break;
                case "-":
                    answer = leftValue - rightValue;
                    break;
                case "*":
                    answer = leftValue * rightValue;
                    break;
                case "/":
                    answer = leftValue / rightValue;
                    break;
            }
            //將目前計算結果顯示在表單上
            DisplayLabel.Text = answer.ToString();
            leftValue = answer;
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (DisplayLabel.Text == "0")
            {
                DisplayLabel.Text = "";
            }
            DisplayLabel.Text += ((Button)sender).Text; //將按鍵輸入的數字串接在之前的字串裡
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            this.OneButton.Click += new System.EventHandler(this.ZeroButton_Click);
            this.TwoButton.Click += new System.EventHandler(this.ZeroButton_Click);
            this.ThreeButton.Click += new System.EventHandler(this.ZeroButton_Click);
            this.FourButton.Click += new System.EventHandler(this.ZeroButton_Click);
            this.FiveButton.Click += new System.EventHandler(this.ZeroButton_Click);
            this.SixButton.Click += new System.EventHandler(this.ZeroButton_Click);
            this.SevenButton.Click += new System.EventHandler(this.ZeroButton_Click);
            this.EightButton.Click += new System.EventHandler(this.ZeroButton_Click);
            this.NineButton.Click += new System.EventHandler(this.ZeroButton_Click);

            this.MinusButton.Click += new System.EventHandler(this.PlusButton_Click);
            this.MultiplyButton.Click += new System.EventHandler(this.PlusButton_Click);
            this.DivideButton.Click += new System.EventHandler(this.PlusButton_Click);
        }
        //輸入運算元
        double leftValue; //計算式的左值
        string op;
        private void PlusButton_Click(object sender, EventArgs e)
        {
            leftValue = double.Parse(DisplayLabel.Text);
            DisplayLabel.Text = "0";
            op = ((Button)sender).Text;
        }

        
    }
}
