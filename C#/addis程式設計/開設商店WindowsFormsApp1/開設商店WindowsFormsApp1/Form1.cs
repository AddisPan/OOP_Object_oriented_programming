using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//date:2019/10/7
//Autor:A108222040_潘凌徵
//Objective:開設商店
namespace 開設商店WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //把定價設成常數變數
        const int Chicken_Prize = 45;
        const int Bacon_Prize = 45;
        const int Potato_Prize = 45;
        const int Shallot_Prize = 45;
        public Form1()
        {
            InitializeComponent();
        }

        private void ChickenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //如果查核方塊是勾選的,將數量改為一
            if (ChickenCheckBox.Checked == true)
            {
                ChickenTextBox.Text = "1";
            }

            //如果查核方塊狗成不勾選,將數量變成零
            if (ChickenCheckBox.Checked == false)
            {
                ChickenTextBox.Text = "0";
            }
        }

        private void BaconCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //如果查核方塊是勾選的,將數量改為一
            if (BaconCheckBox.Checked == true)
            {
                BaconTextBox.Text = "1";
            }

            //如果查核方塊狗成不勾選,將數量變成零
            if (BaconCheckBox.Checked == false)
            {
                BaconTextBox.Text = "0";
            }
        }

        private void PotatoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //如果查核方塊是勾選的,將數量改為一
            if (PotatoCheckBox.Checked == true)
            {
                PotatoTextBox.Text = "1";
            }

            //如果查核方塊狗成不勾選,將數量變成零
            if (PotatoCheckBox.Checked == false)
            {
                PotatoTextBox.Text = "0";
            }
        }

        private void ShallotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //如果查核方塊是勾選的,將數量改為一
            if (ShallotCheckBox.Checked == true)
            {
                ShallotTextBox.Text = "1";
            }

            //如果查核方塊狗成不勾選,將數量變成零
            if (ShallotCheckBox.Checked == false)
            {
                ShallotTextBox.Text = "0";
            }
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            //將使用者點餐的餐點加總
            int totalBill = 0;
            int subTotal; //各單項總價

            //香煎嫩雞吐司總訂購價錢
            subTotal = int.Parse(ChickenTextBox.Text);
            //totalBill = totalBill + subTotal
            totalBill += subTotal * Chicken_Prize;

            //培根蛋吐司的總訂購價錢
            subTotal = int.Parse(BaconTextBox.Text);
            totalBill += subTotal * Bacon_Prize;

            //薯餅蛋漢堡的總訂購價錢
            subTotal = int.Parse(PotatoTextBox.Text);
            totalBill += subTotal * Potato_Prize;

            //三星蔥油餅的總訂購價錢
            subTotal = int.Parse(ShallotTextBox.Text);
            totalBill += subTotal * Shallot_Prize;

            //一般會員打9折,VIP打75折
            if (NormalRadioButton.Checked == true)
            {
                totalBill = (int)(totalBill * 0.9);
            }

            if (VIPRadioButton.Checked == true)
            {
                totalBill = (int)(totalBill * 0.75);
            }

            //顯示消費金額
            AmountsPayLabel.Text = totalBill.ToString("C");

            //讀取使用者付費的金額
            try
            {
                int payMoney = int.Parse(PayTextBox.Text);
                //如果錢不夠,顯示錢不夠
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

        private void ChickenTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //讀取使用者輸入,如果是整數,將ChickenCheckBox做勾選
                int number; //飲料的數量
                number = int.Parse(ChickenTextBox.Text);
                if (number != 0) //使用者輸入新的數量
                {
                    //將ChickenCheckBox做勾選
                    ChickenCheckBox.Checked = true;
                }
            }
            catch
            {
                //輸入非整數
                MessageBox.Show("請輸入整數!");
                ChickenTextBox.Text = "0";
            }
        }

        private void BaconTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //讀取使用者輸入,如果是整數,將BaconCheckBox做勾選
                int number; //飲料的數量
                number = int.Parse(BaconTextBox.Text);
                if (number != 0) //使用者輸入新的數量
                {
                    //將BaconCheckBox做勾選
                    BaconCheckBox.Checked = true;
                }
            }
            catch
            {
                //輸入非整數
                MessageBox.Show("請輸入整數!");
                BaconTextBox.Text = "0";
            }
        }

        private void PotatoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //讀取使用者輸入,如果是整數,將PotatoCheckBox做勾選
                int number; //飲料的數量
                number = int.Parse(PotatoTextBox.Text);
                if (number != 0) //使用者輸入新的數量
                {
                    //將PotatoCheckBox做勾選
                    PotatoCheckBox.Checked = true;
                }
            }
            catch
            {
                //輸入非整數
                MessageBox.Show("請輸入整數!");
                PotatoTextBox.Text = "0";
            }
        }

        private void ShallotTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //讀取使用者輸入,如果是整數,將 ShallotCheckBox做勾選
                int number; //飲料的數量
                number = int.Parse(ShallotTextBox.Text);
                if (number != 0) //使用者輸入新的數量
                {
                    //將 ShallotCheckBox做勾選
                    ShallotCheckBox.Checked = true;
                }
            }
            catch
            {
                //輸入非整數
                MessageBox.Show("請輸入整數!");
                ShallotTextBox.Text = "0";
            }
        }

        private void PayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NormalRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
