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

namespace WSCWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //宣告一個字串的陣列,儲存球隊名稱
        string [] teamName = new string [50];
        //宣告一個字串,儲存歷年冠軍隊伍
        string[] champion = new string[120];
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            StreamReader inputfile;
            //設定開檔對話框的起始路徑
            openFileDialog1.InitialDirectory = "D:\\WSCWindowsFormsApp1";

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
                    TeamListBox.Items.Add(name);
                    //將資料加入陣列,並將i+1
                    teamName[i++] = name;
                }
                //關閉檔案
                inputfile.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0; //計次歸零
            string name; //使用者選定的隊名
            if (TeamListBox.SelectedIndex != -1)
            {
                name = TeamListBox.SelectedItem.ToString(); //找到使用者選定的隊名
                for (int i = 0 ; i < champion.Length ; i++)
                {
                    if (name == champion[i]) //隊名相符
                    {
                        counter++; //本隊贏得冠軍一次
                    }
                }
                MessageBox.Show(name + " 贏得冠軍的次數 " + counter.ToString());
            }
            else
            {
                MessageBox.Show("使用者沒有點選隊名");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            StreamReader inputfile;
            //設定開檔對話框的起始路徑
            openFileDialog1.InitialDirectory = "D:\\WSCWindowsFormsApp1";

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
                    WorldSerieslistBox.Items.Add(name);
                    //將資料加入陣列,並將i+1
                    champion[i++] = name;
                }
                //關閉檔案
                inputfile.Close();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
