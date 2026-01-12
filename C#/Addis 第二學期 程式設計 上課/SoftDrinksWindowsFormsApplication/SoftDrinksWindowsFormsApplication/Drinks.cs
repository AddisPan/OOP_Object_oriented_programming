using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftDrinksWindowsFormsApplication
{
    public partial class Drinks : Form
    {
        //把定價設成常數變數
        const int Black_Tea_Prize = 25;
        const int Green_Tea_Prize = 25;
        const int Orange_Juice_Prize = 30;
        const int Pearl_Milk_Tea_Prize = 45;
        public Drinks()
        {
            InitializeComponent();
        }




        private void BlackTeaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //如果查核方塊是勾選的,將數量改為一
            if (BlackTeaCheckBox.Checked == true)
            {
                BlackTeaTextBox.Text = "1";
            }

            //如果查核方塊改成不勾選,將數量改成零
            if (BlackTeaCheckBox.Checked == false)
            {
                BlackTeaTextBox.Text = "0";
            }
        }

        private void GreenTeaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //如果查核方塊是勾選的,將數量改為一
            if (GreenTeaCheckBox.Checked == true)
            {
                GreenTeaTextBox.Text = "1";
            }

            //如果查核方塊改成不勾選,將數量改成零
            if (GreenTeaCheckBox.Checked == false)
            {
                GreenTeaTextBox.Text = "0";
            }
        }

        private void OrangeJuiceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //如果查核方塊是勾選的,將數量改為一
            if (OrangeJuiceCheckBox.Checked == true)
            {
                OrangeJuiceTextBox.Text = "1";
            }

            //如果查核方塊改成不勾選,將數量改成零
            if (OrangeJuiceCheckBox.Checked == false)
            {
                OrangeJuiceTextBox.Text = "0";
            }
        }

        private void PearlMilkTeaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //如果查核方塊是勾選的,將數量改為一
            if (PearlMilkTeaCheckBox.Checked == true)
            {
                PearlMilkTeaTextBox.Text = "1";
            }

            //如果查核方塊改成部勾選,將數量改成零
            if (PearlMilkTeaCheckBox.Checked == false)
            {
                PearlMilkTeaTextBox.Text = "0";
            }
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {

            //將使用者訂購的飲料加總
            int totalBill = 0;
            int subTotal; //各單項的總價

            //紅茶的總訂購價錢
            subTotal = int.Parse(BlackTeaTextBox.Text);
            //totalBill = totalBill + subTotal;
            totalBill += subTotal * Black_Tea_Prize;

            //綠茶的總訂購價錢
            subTotal = int.Parse(GreenTeaTextBox.Text);
            totalBill += subTotal * Green_Tea_Prize;

            //柳橙汁的總訂購價錢
            subTotal = int.Parse(OrangeJuiceTextBox.Text);
            totalBill += subTotal * Orange_Juice_Prize;

            //珍珠奶茶的總訂購價錢
            subTotal = int.Parse(PearlMilkTeaTextBox.Text);
            totalBill += subTotal * Pearl_Milk_Tea_Prize;

            //會員打95折,VIP打75折
            if (MemberRadioButton.Checked == true)
            {
                totalBill = (int)(totalBill * 0.95);

            }

            if (VIPRadioButton.Checked == true)
            {
                totalBill = (int)(totalBill * 0.75);
            }

            //顯示消費金額
            AmountsPayLabel.Text = totalBill.ToString("C");

            //讀取使用者付費金額
            try
            {
                int payMoney = int.Parse(PayTextBox.Text);
                //如果錢不夠,顯示前不夠
                if (payMoney < totalBill)
                {
                    MessageBox.Show("錢不夠!");
                    PayTextBox.Text = "";
                }
                else
                {
                    //顯示找的金額
                    ChangesLabel.Text = (payMoney - totalBill).ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BlackTeaTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //讀取使用者輸入,如果是整數,將BlackTeaTextBox做勾選
                int number; //飲料的數量
                number = int.Parse(BlackTeaTextBox.Text);
                if (number != 0) //使用者輸入新的數量
                {
                    //將BlackTeaTextBox勾選
                    BlackTeaCheckBox.Checked = true;
                }

            }
            catch
            {
                //輸入非整數
                MessageBox.Show("請輸入整數!");
                BlackTeaTextBox.Text = "0";
            }
        }

        private void GreenTeaTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //讀取使用者輸入,如果是整數,將GreenTeaTextBox做勾選
                int number; //飲料的數量
                number = int.Parse(GreenTeaTextBox.Text);
                if (number != 0) //使用者輸入新的數量
             
                    //將GreenTeaTextBox勾選
                    GreenTeaCheckBox.Checked = true;
            }
            catch
            {
                //輸入非整數
                MessageBox.Show("請輸入整數!");
                GreenTeaTextBox.Text = "0";
            }
        }

        private void OrangeJuiceTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //讀取使用者輸入,如果是整數,將OrangeJuiceTextBox做勾選
                int number; //飲料的數量
                number = int.Parse(OrangeJuiceTextBox.Text);
                if (number != 0) //使用者輸入新的數量

                    //將OrangeJuiceTextBox勾選
                    OrangeJuiceCheckBox.Checked = true;
            }
            catch
            {
                //輸入非整數
                MessageBox.Show("請輸入整數!");
                OrangeJuiceTextBox.Text = "0";
            }
        }

        private void PearlMilkTeaTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //讀取使用者輸入,如果是整數,將PearlMilkTeaTextBox做勾選
                int number; //飲料的數量
                number = int.Parse(PearlMilkTeaTextBox.Text);
                if (number != 0) //使用者輸入新的數量

                    //將PearlMilkTeaTextBox勾選
                    PearlMilkTeaCheckBox.Checked = true;
            }
            catch
            {
                //輸入非整數
                MessageBox.Show("請輸入整數!");
                PearlMilkTeaTextBox.Text = "0";
            }
        }

        private void BlackTeaTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

