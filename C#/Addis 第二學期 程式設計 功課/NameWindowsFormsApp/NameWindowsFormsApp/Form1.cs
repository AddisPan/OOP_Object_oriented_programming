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

namespace NameWindowsFormsApp
{
    public partial class Form1 : Form
    {
        //宣告一個字串的陣列,儲存男生名字
        string[] BoyName = new string[200];
        //宣告一個字串的陣列,儲存女生名字
        string[] GirlName = new string[200];
        public Form1()
        {
            InitializeComponent();
        }

        private void BoyNameButton_Click(object sender, EventArgs e)
        {
            StreamReader inputfile;
            //設定開檔對話框的起始路徑
            openFileDialog1.InitialDirectory = "D:\\NameWindowsFormsApp";

            //開啟存檔對話框,讓使用者選定檔案
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputfile = File.OpenText(openFileDialog1.FileName);

                //在檔案讀出來的資料顯示在listbox中,同時寫進陣列中
                int i = 0;
                string name;
                while (!inputfile.EndOfStream) //當沒有讀到檔尾,也可以寫成 intputFile.EndOfStream == false
                {
                    name = inputfile.ReadLine();
                    BoyNameListBox.Items.Add(name);
                    //將資料加入陣列,並將i+1
                    BoyName[i++] = name;
                }
                //關閉檔案
                inputfile.Close();
            }
        }

        private void GirlNameButton_Click(object sender, EventArgs e)
        {
            StreamReader inputfile;
            //設定開檔對話框的起始路徑
            openFileDialog1.InitialDirectory = "D:\\NameWindowsFormsApp";

            //開啟存檔對話框,讓使用者選定檔案
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputfile = File.OpenText(openFileDialog1.FileName);

                //在檔案讀出來的資料顯示在listbox中,同時寫進陣列中
                int i = 0;
                string name;
                while (!inputfile.EndOfStream) //當沒有讀到檔尾,也可以寫成 intputFile.EndOfStream == false
                {
                    name = inputfile.ReadLine();
                    GirlNameListBox.Items.Add(name);
                    //將資料加入陣列,並將i+1
                    GirlName[i++] = name;
                }
                //關閉檔案
                inputfile.Close();
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "")
            {
                for (int i = 0; i < BoyNameListBox.Items.Count && i < GirlNameListBox.Items.Count; i++)
                {
                    if (NameTextBox.Text == BoyNameListBox.Items[i].ToString())
                    {
                        MessageBox.Show("是男生的名字");
                    }
                    else if (NameTextBox.Text == GirlNameListBox.Items[i].ToString())
                    {
                        MessageBox.Show("是女生的名字");
                    }
                }
            }
            else
            {
                MessageBox.Show("請輸入名字");
            }
        }
    }
}
