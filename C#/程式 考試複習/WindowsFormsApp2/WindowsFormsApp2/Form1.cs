using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FruitListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fruit;
            if (FruitListBox.SelectedIndex != -1)
            {
                fruit = FruitListBox.SelectedItem.ToString();
                FruitLabel.Text = fruit;
            }
            else
            {
                MessageBox.Show("請選擇一樣水果");
            }
                
        }
    }
}
