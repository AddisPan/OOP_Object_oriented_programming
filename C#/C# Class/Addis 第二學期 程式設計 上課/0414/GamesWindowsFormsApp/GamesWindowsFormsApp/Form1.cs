using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //利用new產生一個自訂的PianoForm表單物件
            PianoForm myPianoForm = new PianoForm();

            //開啟新的自訂的表單物件
            myPianoForm.ShowDialog();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //利用new產生一個自訂的CalculatorForm表單物件
            CalculatorForm myCalculatorForm = new CalculatorForm();

            //開啟新的自訂的表單物件
            myCalculatorForm.ShowDialog();
        }
    }
}
