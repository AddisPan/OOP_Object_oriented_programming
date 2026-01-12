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

namespace PopulationWindowsFormsApp
{
    public partial class Form1 : Form
    {
        //宣告一個字串的陣列,儲存男生名字
        int[] Population = new int[41];
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadPopulationButton_Click(object sender, EventArgs e)
        {
            StreamReader inputfile;
            //設定開檔對話框的起始路徑
            openFileDialog1.InitialDirectory = "D:\\PopulationWindowsFormsApp";

            //開啟存檔對話框,讓使用者選定檔案
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputfile = File.OpenText(openFileDialog1.FileName);

                //在檔案讀出來的資料顯示在listbox中,同時寫進陣列中
                int i = 0;
                int name;
                while (!inputfile.EndOfStream) //當沒有讀到檔尾,也可以寫成 intputFile.EndOfStream == false
                {
                    name = int.Parse(inputfile.ReadLine());
                    PopulationListBox.Items.Add(name);
                    //將資料加入陣列,並將i+1
                    Population[i++] = name;
                }
                //關閉檔案
                inputfile.Close();
            }
        }

        private void AverageButton_Click(object sender, EventArgs e)
        {
            int averagePopulation = computeAveragePopulation(Population);
            MessageBox.Show("平均成長為" + averagePopulation.ToString());
        }
        
        static int computeAveragePopulation(int [] Population)
        {
            int averagePopulation = 0;
            int total = 0;
            for (int i = 0 ; i < Population.Length-1 ; i ++)
            {
                total += (Population[i + 1] - Population[i]);
            }
            averagePopulation = total / 40;
            return averagePopulation;
        }

        private void BestButton_Click(object sender, EventArgs e)
        {
            int highestPopulation = computeHighestPopulation(Population);
            MessageBox.Show( "最大成長為" + highestPopulation.ToString());
        }

        static int computeHighestPopulation(int[] Population)
        {
            int highestPopulation = 0;
            int year = 0;
            for (int i = 0; i < Population.Length - 1; i++)
            {
               if ((Population[i + 1] - Population[i]) > highestPopulation)
                {
                    highestPopulation = (Population[i + 1] - Population[i]);
                    year = i + 1950;
                }
            }
            MessageBox.Show($"    {year}年到{year + 1}年");
            return highestPopulation;
        }

        private void LowestButton_Click(object sender, EventArgs e)
        {
            int lowestPopulation = computeLowestPopulation(Population);
            MessageBox.Show("最小成長為" + lowestPopulation.ToString());
        }

        static int computeLowestPopulation(int[] Population)
        {
            int lowestPopulation = 300000;
            int year = 0;
            for (int i = 0; i < Population.Length - 1; i++)
            {
                if ((Population[i + 1] - Population[i]) < lowestPopulation)
                {
                    lowestPopulation = (Population[i + 1] - Population[i]);
                    year = i + 1950;
                }
            }
            MessageBox.Show($"    {year}年到{year + 1}年");
            return lowestPopulation;
        }
    }
}
