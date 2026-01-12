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
        const int Sandwitch_Prize = 60;
        const int CheeseHotDog_Prize = 35;
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            int totalMoney = 0;
            int subMoney;

            subMoney = int.Parse(SandwitchTextBox.Text);
            totalMoney += subMoney * Sandwitch_Prize;

            subMoney = int.Parse(CheeseHotdogTextBox.Text);
            totalMoney += subMoney * CheeseHotDog_Prize;

            if (MumberRadioButton.Checked == true)
            {
                totalMoney = (int)(totalMoney * 0.9);
            }
            if (VIPRadioButton.Checked == true)
            {
                totalMoney = (int)(totalMoney * 0.7);
            }

            AmountsPayLabel.Text = totalMoney.ToString("C");

            int payMoney = int.Parse(PayTextBox.Text);
            //如果錢不夠,顯示錢不夠
            if (payMoney < totalMoney)
            {
                MessageBox.Show("錢不夠!");
                PayTextBox.Text = "";
            }
            else
            {
                //顯示找的金額
                HundredChangesLabel.Text = (payMoney - totalMoney).ToString("C");
            }

            int remain;
            int hundred;
            int ten;
            int one;

            remain = payMoney - totalMoney;

            hundred = remain / 100;
            remain = remain % 100;

            ten = remain / 10;
            remain = remain % 10;

            one = remain;

            HundredChangesLabel.Text = hundred.ToString();
            TenChangesLabel.Text = ten.ToString();
            OneChangesLabel.Text = one.ToString();
        }

        private void SandwitchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwitchCheckBox.Checked == true)
            {
                SandwitchTextBox.Text = "1";
            }
            if (SandwitchCheckBox.Checked == false)
            {
                SandwitchTextBox.Text = "0";
            }
        }

        private void CheeseHotDogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseHotDogCheckBox.Checked == true)
            {
                CheeseHotdogTextBox.Text = "1";
            }
            if (SandwitchCheckBox.Checked == false)
            {
                CheeseHotdogTextBox.Text = "0";
            }
        }

        private void SandwitchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int number;
                number = int.Parse(SandwitchTextBox.Text);
                if (number != 0) //使用者輸入新的數量
                {
                    //將ChickenCheckBox做勾選
                    SandwitchCheckBox.Checked = true;
                }
            }
            catch
            {
                MessageBox.Show("請輸入整數!");
                SandwitchTextBox.Text = "0";
            }
        }
    }
}
