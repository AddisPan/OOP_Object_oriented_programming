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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeToFileBtn_Click(object sender, EventArgs e)
        {
            //宣告變數來reference(參考或指向) StreamWriter 物件
            StreamWriter outputfile;

            //開啟檔案--File.CreateText vs. File.AppendText
            outputfile = File.CreateText("namefile.txt");

            //將資料寫入檔案
            outputfile.WriteLine("Addis");
            outputfile.WriteLine("Jerry");

            //關閉檔案
            outputfile.Close();
        }
    }
}
