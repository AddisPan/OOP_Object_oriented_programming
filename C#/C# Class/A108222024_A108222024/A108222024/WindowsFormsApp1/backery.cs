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
    public partial class backery : Form
    {
        public backery()
        {
            InitializeComponent();
        }
        private List<string> timeList = new List<string>();
        private int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            timeList.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
            count++;
            if (count > 366)
            {
                MessageBox.Show("超過一年了");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                }
                else
                {
                    if (int.Parse(textBox1.Text) > 1440)
                    {
                        int.Parse("AA");
                    }
                }
                
                        
            }
            catch
            {
                MessageBox.Show("請輸入正確的時間");
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter output = File.CreateText("Time.txt");
            output.Write(string.Join(",",timeList));
            output.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader input = File.OpenText("Time.txt");
            string[] temp = input.ReadLine().Split(',');
            int total = 0;
            for (int i = 0; i<temp.Length;i++)
            {
                listBox1.Items.Add($"第{i + 1}天 : {temp[i]}");
                total += int.Parse(temp[i]);
            }
            (total / temp.Length).ToString("n2");
            listBox1.Items.Add($"平均時間 : {((float)total / temp.Length).ToString("N2")}");
        }
    }
}
