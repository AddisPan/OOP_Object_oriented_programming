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
        const int SIZE = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile;
            //設定開檔對話框的起始路徑
            saveFileDialog.InitialDirectory = "D:\\WindowsFormsApp1";
            //開啟存檔對話框,讓使用者選定檔案
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //檔案實際的名字和路徑存在對話框filename的屬性裡面
                outputfile = File.CreateText(saveFileDialog.FileName);
                //將listbox的資料寫入檔案
                for (int i = 0 ; i < ScoreListBox.Items.Count ; i++ )
                {
                    outputfile.WriteLine(ScoreListBox.Items[i]);
                }
                //關閉檔案
                outputfile.Close();
            }
            else //使用者在對話框中選擇取消
            {
                MessageBox.Show("使用者取消存檔");
            }
        }

        private void generateScoreButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //自動產生N筆成績存入listbox
            for (int i = 0 ; i < SIZE ; i++)
            {
                //將隨機產生的成績放入Listbox
                ScoreListBox.Items.Add(rand.Next(1,50));
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ScoreListBox.Items.Clear();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            StreamReader inputfile;
            //設定開檔對話框的起始路徑
            openFileDialog1.InitialDirectory = "D:\\WindowsFormsApp1";

            //開啟存檔對話框,讓使用者選定檔案
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputfile = File.OpenText(openFileDialog1.FileName);

                //在檔案讀出來的資料顯示在listbox中
                while (!inputfile.EndOfStream) //當沒有讀到檔尾,也可以寫成 intputFile.EndOfStream == false
                {
                    ScoreListBox.Items.Add(inputfile.ReadLine());
                }
                //關閉檔案
                inputfile.Close();
            }
            else
            {
                MessageBox.Show("使用者選擇取消");
            }
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0 ; i < ScoreListBox.Items.Count ; i++ )
            {
                total = total + int.Parse(ScoreListBox.Items[i].ToString());
            }
            //計算平均,將平均計算至小數點後兩位,計算前必須將其中一個整數型態的變數強制轉型為douoble
            MessageBox.Show(((double)total / ScoreListBox.Items.Count).ToString("n2"));
        }

        private void FriendsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0 ; i < ScoreListBox.Items.Count ;i++ )
            {
                MessageBox.Show("你是我的朋友嗎?" + ScoreListBox.Items[i]);
            }
        }
    }
}
