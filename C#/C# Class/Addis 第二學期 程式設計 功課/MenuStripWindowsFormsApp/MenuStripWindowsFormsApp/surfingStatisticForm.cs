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

namespace MenuStripWindowsFormsApp
{
    public partial class surfingStatisticForm : Form
    {
        List<int> surfingTimeList = new List<int>();
        public surfingStatisticForm()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
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
                        surfingTimeListBox.Items.Add(line);
                        surfingTimeList.Clear();
                    }
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
    }
}
