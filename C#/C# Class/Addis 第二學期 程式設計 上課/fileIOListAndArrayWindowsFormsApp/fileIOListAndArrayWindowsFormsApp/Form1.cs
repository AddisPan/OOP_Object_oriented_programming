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

namespace fileIOListAndArrayWindowsFormsApp
{
    public partial class Form1 : Form
    {
        List<int> surfingTimeList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            //將使用者輸入的單周每日上網時間,並顯示在listbox上
            //依序將每日上網資料加入串列中
            surfingTimeList.Add(int.Parse(MondayTextBox.Text));
            surfingTimeList.Add(int.Parse(TuesdayTextBox.Text));
            surfingTimeList.Add(int.Parse(WednesdayTextBox.Text));
            surfingTimeList.Add(int.Parse(ThursdayTextBox.Text));
            surfingTimeList.Add(int.Parse(FridayTextBox.Text));
            surfingTimeList.Add(int.Parse(SaturdayTextBox.Text));
            surfingTimeList.Add(int.Parse(SundayTextBox.Text));
            //將資料顯示在listbox上
            //將每周資料整合在一個字串上,最後在輸出到listbox上
            string line = "";
            foreach (int item in surfingTimeList)
            {
                line = line + item + '\t';
            }
            DisplayListBox.Items.Add(line);
            //清除SurfingTimeList裡面的資料,課本p446
            surfingTimeList.Clear();
            //for (int i = 0 ; i < surfingTime.Count ; i++)
            //{
            //    DisplayListBox.Items.Add(surfingTimeList[i]);
            //}
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MondayTextBox.Text = "";
            TuesdayTextBox.Text = "";
            WednesdayTextBox.Text = "";
            ThursdayTextBox.Text = "";
            FridayTextBox.Text = "";
            SaturdayTextBox.Text = "";
            SundayTextBox.Text = "";
        }

        private void SaveDataIntoFileButton_Click(object sender, EventArgs e)
        {
            string line;
            string[] tokens;
            StreamWriter saveFile;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFile = File.CreateText(saveFileDialog1.FileName);
                //將listbox的資料寫入檔案中
                for (int i = 0 ; i < DisplayListBox.Items.Count ; i ++)
                {
                    line = DisplayListBox.Items[i].ToString();
                    tokens = line.Split(null);
                    line = "";
                    foreach (string item in tokens)
                    {
                        line = line + item + "\t";                       
                    }
                    saveFile.WriteLine(line);
                }
                saveFile.Close();
            }           
        }

        private void ReadDataButton_Click(object sender, EventArgs e)
        {
            //讀取檔案資料,並將資料存入在surfingTimeList裡面
            surfingTimeList.Clear();
            string line;
            string[] token;
            try
            {
                StreamReader inputfile;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputfile = File.OpenText(openFileDialog1.FileName);
                    while (!inputfile.EndOfStream)
                    {
                        line = inputfile.ReadLine().Trim();
                        token = line.Split(null);
                        line = "";
                        //將每日的上網時間放到surfingTimeList裡面
                        foreach (string item in token)
                        {
                            surfingTimeList.Add(int.Parse(item));
                        }
                        //計算當周每日平均上網時間
                        float average;
                        int total = 0;
                        foreach (int item in surfingTimeList)
                        {
                            total = total + item;
                        }
                        average = total / 7;
                        //將surfingTimeList裡面的資料加入到listbox1裡面,包括平均上網時間
                        foreach (int item in surfingTimeList)
                        {
                            line = line + item + '\t';
                        }
                        line += average.ToString();
                        listBox1.Items.Add(line);
                        surfingTimeList.Clear();                    }
                    inputfile.Close();
                }
                else
                {
                    MessageBox.Show("找不到這個檔案");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            //每個月有四周,一周有7天
            int[,] useTime = new int[4, 7] {{1,2,3,4,5,6,7},
                                            {8,9,10,11,12,13,14},
                                            {15,16,17,18,19,20,21},
                                            {22,23,24,25,26,27,28}};
            //顯示二維陣列的內容
            for (int i =0 ; i < useTime.GetLength(0) ; i++)// 取得二維陣列裡面一維陣列有幾個
            {
                line = "";
                for (int j = 0 ; j < useTime.GetLength(1) ; j++) //每個一維陣列有幾個元素
                {
                    line = line + useTime[i, j].ToString() + '\t';
                }
                listBox1.Items.Add(line);
            }
            foreach (int item in useTime)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
