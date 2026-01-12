using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripWindowsFormsApp
{
    public partial class orderGoodsForm : Form
    {
        public orderGoodsForm()
        {
            InitializeComponent();
        }

        const int SIZE = 8;
        const int ORDERAMOUNT = 50;

        private void button1_Click(object sender, EventArgs e)
        {
            string[] productID = new string[SIZE];
            int[] productPrice = new int[SIZE];
            int[] totalProductMoney = new int[SIZE];
            int[] totalProductNumber = new int[SIZE];

            int[] orderProductID = new int[ORDERAMOUNT];
            int[] orderProductNumber = new int[ORDERAMOUNT];             

            generateProductID(productID);
            foreach (string product in productID)
            {
                ProductIDListBox.Items.Add(product);
            }

            generateProductPrice(productPrice);
            foreach (int price in productPrice)
            {
                productPriceListBox.Items.Add(price);
            }

            generateOrderProduct(orderProductID,productPrice,orderProductNumber, totalProductMoney,totalProductNumber);

            showOrder(orderProductID,orderProductNumber,productID);
            generateProductPrice(productPrice);
            foreach (int price in totalProductMoney)
            {
                salePriceListBox.Items.Add(price);
            }
            foreach (int product in totalProductNumber)
            {
                NumberListBox.Items.Add(product);
            }
            int i = -1;
            int TopMoney;
            i = findTopMoney(totalProductMoney,out TopMoney);
            Topsaleslabel.Text = productID[i] + "  " + TopMoney.ToString();

            int TopNumber;
            i = findTopNumber(totalProductNumber, out TopNumber);
            TopNumberlabel.Text = productID[i] + "  " + TopNumber.ToString();
        }

        private int findTopMoney(int [] totalProductMoney, out int TopMoney)
        {
            int e = -1;
            TopMoney = 0;
            for (int i = 0 ; i < totalProductMoney.Length ; i++ )
            {
                e = i;
                TopMoney = totalProductMoney[i];
            }
            return e;
        }

        private int findTopNumber(int[] totalProductNumber, out int TopNumber)
        {
            int e = -1;
            TopNumber = 0;
            for (int i = 0; i < totalProductNumber.Length; i++)
            {
                e = i;
                TopNumber = totalProductNumber[i];
            }
            return e;
        }

        private void showOrder(int [] orderProductID, int [] orderProductNumber,string [] productID)
        {
            string id;
            int count;

            for (int i = 0 ; i < ORDERAMOUNT ; i++)
            {
                count = orderProductNumber[i];
                id = productID[orderProductID[i]];
                orderListListBox.Items.Add(id + "\t" + count);
            }
        }

        private void generateOrderProduct(int [] orderProductID,int [] productPrice, int [] orderProductNumber, int [] totalProductMoney,int [] totalProductNumber)
        {
            Random rand = new Random();

            for (int i = 0 ; i < ORDERAMOUNT ; i ++)
            {
                orderProductID[i] = rand.Next(SIZE);
                orderProductNumber[i] = rand.Next(1, 1000);

                totalProductMoney[orderProductID[i]] += orderProductNumber[i] * productPrice[orderProductID[i]];
                totalProductNumber[orderProductID[i]] += orderProductNumber[i];
            }
        }

        private void generateProductPrice(int [] productPrice)
        {
            int startPrice = 40;
            productPrice[0] = 40;
            for (int i = 1 ; i < productPrice.Length ; i ++)
            {
                startPrice += 10;
                productPrice[i] = startPrice;
            }
        }

        private void generateProductID(string[] productID)
        {
            int first = 108222040;
            productID[0] = first.ToString();

            for (int i = 1 ; i < productID.Length ; i++)
            {
                first += 6;
                productID[i] = first.ToString();
            }
        }
    }
}
