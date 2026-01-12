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
    public partial class backeryForm : Form
    {
        public backeryForm()
        {
            InitializeComponent();
        }

        private void SaveFilebutton_Click(object sender, EventArgs e)
        {
            int time;
            int counter = 0;
            time = int.Parse(TimeTextBox.Text);
            if (time > 0 && time < 1440)
            {
                time = int.Parse(TimeTextBox.Text);
                counter++;
                if (counter > 366)
                {
                    MessageBox.Show("超過");
                }
            }
            else
            {
                MessageBox.Show("輸入格式不對");
            }

            StreamWriter outputfile;
            saveFileDialog1.InitialDirectory = "C://Data";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputfile = File.CreateText(saveFileDialog1.FileName);

                outputfile.WriteLine(TimeTextBox.Text);

                outputfile.Close();
            }
            else
            {
                MessageBox.Show("錯誤");
            }
        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            StreamReader inputfile;
            openFileDialog1.InitialDirectory = "C://Data";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputfile = File.OpenText(openFileDialog1.FileName);
                string time;
                while (!inputfile.EndOfStream)
                {
                    time = inputfile.ReadLine();
                    TimelistBox.Items.Add(time);
                }
                inputfile.Close();
            }
        }

        private void Averagebutton_Click(object sender, EventArgs e)
        {
            int total = 0;
            float average = 0;


            for (int i = 0 ; i < TimelistBox.Items.Count ; i++)
            {
                total += i;               
            }
            average = total / TimelistBox.Items.Count;
            MessageBox.Show("平均是:" + average.ToString());
        }
    }
}
