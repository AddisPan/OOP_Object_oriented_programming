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
    public partial class surfingLoginForm : Form
    {
        public surfingLoginForm()
        {
            InitializeComponent();
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            
            if (int.Parse(TimetextBox.Text) < 1440 && TimeListBox.Items.Count < 365)
            {
                TimeListBox.Items.Add(int.Parse(TimetextBox.Text));
            }
            else
            {
                MessageBox.Show("Wrong");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StreamWriter saveFile;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int line = 0;
                saveFile = File.CreateText(saveFileDialog1.FileName);
                //將listbox的資料寫入檔案中
                foreach (int item in TimeListBox.Items)
                {
                    saveFile.WriteLine(item.ToString());

                    line++;
                }
                saveFile.Close();
            }
        }
    }
}
