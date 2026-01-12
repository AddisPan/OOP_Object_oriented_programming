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

        private void writeToFileBtn_Click(object sender, EventArgs e)
        {
            //宣告變數來reference(參考或指向) StreamWriter 物件
            StreamWriter outputfile;
            StreamWriter numberfile;

            //開啟檔案--File.CreateText vs. File.AppendText
            outputfile = File.CreateText("namefile.txt");
            numberfile = File.AppendText("numberfile.txt");

            //將資料寫入檔案
            outputfile.WriteLine("Addis");
            outputfile.WriteLine("Jerry");

            for (int i = 1; i < 11; i++)
            {
                numberfile.WriteLine(i);
            }

            //關閉檔案
            outputfile.Close();
            numberfile.Close();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            //宣告變數來reference(參考或指向) StreamReader 物件
            StreamReader inputfile;
            int number;

            //開啟檔案--File.OpenText
            inputfile = File.OpenText("numberfile.txt");

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
                
                for (int i = 0;i < 10; i++)
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
    }
}
