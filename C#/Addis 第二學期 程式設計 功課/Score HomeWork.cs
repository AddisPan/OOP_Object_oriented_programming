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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            //宣告變數來reference(參考或指向) StreamReader 物件
            StreamReader inputfile;
            int number;

            //開啟檔案--File.OpenText
            inputfile = File.OpenText("score.txt");

            //將資料從檔案中讀出
            while (!inputfile.EndOfStream)
            {
                number = int.Parse(inputfile.ReadLine());
                diaplayLst.Items.Add(number);
            }

            //關閉檔案
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            diaplayLst.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //宣告變數來reference(參考或指向) StreamReader 物件
            StreamReader inputfile;

            //指定對話框開始的起始路徑--InitialDirectory Property
            openfile.InitialDirectory = "C:/data";

            //開啟檔案--1.利用ShowDialog() 開啟檔案對話框
            //          2.讓試用者點選欲開啟之檔案,並按下確認鍵--DialogResult.OK
            //          3.讓file object(上列宣告之變數inputfile) reference 實體的檔案

            if(openfile.ShowDialog() == DialogResult.OK)
            {
                inputfile = File.OpenText(openfile.FileName);
                int numberfile;
                while (!inputfile.EndOfStream)
                {
                    numberfile = int.Parse(inputfile.ReadLine());
                    numberfile = numberfile + 10;
                    diaplayLst.Items.Add(numberfile);
                }
                //關閉檔案
                inputfile.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //宣告變數來reference(參考或指向) StreamWriter 物件
            StreamWriter outputfile;

            //指定對話框開始的起始路徑--InitialDirectory Property
            saveFileDialog.InitialDirectory = "C:/data";

            //開啟檔案--1.利用ShowDialog() 開啟檔案對話框
            //          2.讓試用者點選欲開啟之檔案,並按下確認鍵--DialogResult.OK
            //          3.讓file object(上列宣告之變數inputfile) reference 實體的檔案

            Random rand = new Random();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputfile = File.CreateText(saveFileDialog.FileName);
                
                for (int i = 0;i < 50; i++)
                {
                    outputfile.WriteLine(rand.Next(100));
                }
                //關閉檔案
                outputfile.Close();
            }
            else
            {
                MessageBox.Show("You clicked the cancel button.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter adjustFile;
            saveFileDialog.InitialDirectory = "C:/data";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                adjustFile = File.CreateText(saveFileDialog.FileName);
                for (int i = 0 ; i < 40 ; i ++)
                {
                    adjustFile.WriteLine(diaplayLst.Items[i]);
                }

                adjustFile.Close();
            }
        }
    }
}
