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

namespace GradesWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile; 
                string line;
                int count = 0; 
                int total; 
                double average; 
                char[] delim = { ',' };

                inputFile = File.OpenText("Score.txt");
                while (!inputFile.EndOfStream)
                {
                    count++;
                    line = inputFile.ReadLine();
                    string[] tokens = line.Split(delim);
                    total = 0;
                    foreach (string str in tokens)
                    {
                        total += int.Parse(str);
                    }
                    average = (double)total / tokens.Length;
                    averagesListBox.Items.Add("The average for student " +
                    count + " is " + average.ToString("n1"));
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
