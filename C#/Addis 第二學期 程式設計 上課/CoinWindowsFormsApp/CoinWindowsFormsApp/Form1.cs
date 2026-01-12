using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TossButton_Click(object sender, EventArgs e)
        {
            //建立銅板物件
            Coin myCoin = new Coin();
            outputlistBox.Items.Clear();
            //丟五次銅板
            for (int count = 0 ; count < 5 ; count++ )
            {
                //擲銅板
                myCoin.Toss();
                //查看結果
                outputlistBox.Items.Add(myCoin.GetsideUp());
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    //自訂類別 Coin
    class Coin
    {
        //定義銅板的正面
        private string sideUp;

        Random rand = new Random();

        //定義建構子
        public Coin()
        {
            sideUp = "Heads";
        }
        //定義類別coin的Method
        public void Toss()
        {
            //擲銅板
            if (rand.Next(2) == 0)
            {
                sideUp = "Heads"; //頭朝上
            }
            else
            {
                sideUp = "Tails";
            }
        }

        public string GetsideUp()//取得銅板正反面
        {
            return sideUp;
        }
    }
}
