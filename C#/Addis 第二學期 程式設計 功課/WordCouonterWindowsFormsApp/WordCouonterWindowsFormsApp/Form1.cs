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

namespace WordCouonterWindowsFormsApp
{
    public partial class Form1 : Form
    {
        List<int> WordCounterList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {

            WordCounterList.Add(int.Parse(WordTextBox.Text));

            string line = " ";

            foreach (int item in WordCounterList)
            {
                line = line + item + '\t';
            }
            WordListBox.Items.Add(line);

            for (int i = 0; i < WordListBox.Items.Count; i++)
            {
                line = WordListBox.Items[i].ToString(); ;
            }

            MessageBox.Show("總共有" + line.ToString());
        }       
     }   
}

