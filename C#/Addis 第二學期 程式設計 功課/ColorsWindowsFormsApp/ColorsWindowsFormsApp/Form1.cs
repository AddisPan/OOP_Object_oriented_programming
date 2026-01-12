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

namespace ColorsWindowsFormsApp
{
    public partial class Form1 : Form
    {
        List<string> colorList = new List<string>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputfile;

                string line; //存放從檔案讀取的一行資料
                char[] delim = { ',' };

                string[] tokens; //使用line.split()之後儲存每個token的

                inputfile = File.OpenText("Color.txt");

                //讀第一筆資料...是標題直接放入listbox
                line = inputfile.ReadLine();

                ColorListBox.Items.Add(line);

                tokens = line.Split(null);

                for (int i = 0; i < tokens.Length; i++)
                 {
                     line = line + "\t" + tokens[i];

                    if (ColorTextBox.Text == tokens[i])
                    {
                        ShowColorListBox.Items.Add(line);
                    }
                }

            } //End Of try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {

            int[] colorData = new int[15];

            ColorMention(colorData);
        }

        private void ColorMention(int  colorData)
        {
             colorData = ColorListBox.Items.Add(int.Parse(ColorTextBox.Text));
        }
    }
}
