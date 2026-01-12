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

namespace Test1WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            StreamReader intputfile;
            int number;

            intputfile = File.OpenText("1.txt");

            while (intputfile.EndOfStream)
            {
                number = int.Parse(intputfile.ReadLine());
                displayList.Items.Add(number);
            }
            intputfile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader inputfile;

            openFileDialog1.InitialDirectory = "D:/程式 下學期期中";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputfile = File.OpenText(openFileDialog1.FileName);
                int numberfile;
                while (!inputfile.EndOfStream)
                {
                    numberfile = int.Parse(inputfile.ReadLine());
                    numberfile = numberfile + 10;
                    displayList.Items.Add(numberfile);
                }
                inputfile.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile;

            saveFileDialog1.InitialDirectory = "D:/ 程式 下學期期中";

            Random rand = new Random();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputfile = File.CreateText(saveFileDialog1.FileName);

                for (int i = 0; i < 50; i++)
                {
                    outputfile.WriteLine(rand.Next(100));
                }
                outputfile.Close();
            }
            else 
            {
                MessageBox.Show("You clicked the cancel button");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter adjustfile;

            saveFileDialog1.InitialDirectory = "D:/ 程式 下學期期中";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adjustfile = File.CreateText(saveFileDialog1.FileName);

                for (int i = 0 ; i < 40 ; i++)
                {
                    adjustfile.WriteLine(displayList.Items[i]);
                }
                adjustfile.Close();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            displayList.Items.Clear();
        }
    }
}
