using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GoodsWindowsFormsApp
{
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }
        int goodsItems; //商品品項的數量代表二維陣列的ROW
        int totalStores; //分店的數量代表二維陣列的COLUMNS
        private void ReadDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputfile;

                string line; //存放從檔案讀取的一行資料
                char[] delim = {','};

                string[] tokens; //使用line.split()之後儲存每個token的

                inputfile = File.OpenText("Goods.txt");

                //讀第一筆資料...是標題直接放入listbox
                line = inputfile.ReadLine();

                saleslistBox.Items.Add(line);

                //預備二維陣列的列數和行數
                goodsItems = 0; //ROW
                tokens = line.Split(null);

                totalStores = tokens.Length - 1; //分店的數量COL

                //從第二筆讀取資料檔
                while ( !inputfile.EndOfStream)
                {
                    goodsItems ++; //資料品項 + 1,ROW + 1

                    line = inputfile.ReadLine();

                    tokens = line.Split(null);

                    line = tokens[0]; //每一列的第一欄是產品名稱

                    //處理tokens字串陣列,從第二欄開始 
                    for (int i = 1 ; i < tokens.Length ; i ++)
                    {
                        line = line + "\t" + tokens[i];
                    }
                    saleslistBox.Items.Add(line);
                } //End Of while

            } //End Of try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            //宣告整數的二維陣列,儲存銷售資料
            int[,] salesData = new int[goodsItems,totalStores];

            storeDataToArray(salesData);

            showArray(salesData);
        }

        private void storeDataToArray(int[,] salesData)
        {
            string [] tokens;

            int items = 0; //ROW
            int stroe = 0; //COL
            
            //從listbox摘取數據資料,第一筆資料為標題,從第二筆開始
            for (int i = 1 ; i < saleslistBox.Items.Count ; i ++)
            {
                tokens = saleslistBox.Items[i].ToString().Split(null);
                //第一欄是商品名稱不使用,從第二欄存入陣列中

                stroe = 0;

                for (int j = 1 ; j < tokens.Length ; j++)
                {
                    salesData[items, stroe++] = int.Parse(tokens[j]);
                    //store++;
                }
                //讀下一筆資料，next ROW　
                items++;
            }

        }

        private void showArray(int[,] salesData)
        {
            string record; //一筆資料

            for (int item = 0 ; item < goodsItems ; item++)
            {
                record = "";

                for (int store = 0 ; store < totalStores ; store ++)
                {
                    record += salesData[item, store].ToString() + "\t";
                }
                //將一筆資料顯示資料
                showArraylistBox.Items.Add(record);
            }
            
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
