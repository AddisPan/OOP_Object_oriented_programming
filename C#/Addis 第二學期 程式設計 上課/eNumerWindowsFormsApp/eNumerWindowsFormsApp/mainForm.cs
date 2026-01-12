using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eNumerWindowsFormsApp
{
    //定義一個列舉
    enum Colorer
    {
        Red, Orange, Yellow, Green, Blue, Indigo, Purple
    }
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            //宣告一個資料型態為列舉的變數;
            Colorer selectedColor;
            selectedColor = Colorer.Indigo;

            //列出你選擇的日期
            switch (selectedColor)
            {
                case Colorer.Red:
                    MessageBox.Show("Red");
                    BackColor = Color.Red;
                    break;
                case Colorer.Orange:
                    MessageBox.Show("Orange");
                    BackColor = Color.Orange;
                    break;
                case Colorer.Yellow:
                    MessageBox.Show("Yellow");
                    BackColor = Color.Yellow;
                    break;
                case Colorer.Green:
                    MessageBox.Show("Green");
                    BackColor = Color.Green;
                    break;
                case Colorer.Blue:
                    MessageBox.Show("Blue");
                    BackColor = Color.Blue;
                    break;
                case Colorer.Indigo:
                    MessageBox.Show("Indigo");
                    BackColor = Color.Indigo;
                    break;
                case Colorer.Purple:
                    MessageBox.Show("Purple");
                    BackColor = Color.Purple;
                    break;
                default:
                    break;
            }

        }
    }
}
