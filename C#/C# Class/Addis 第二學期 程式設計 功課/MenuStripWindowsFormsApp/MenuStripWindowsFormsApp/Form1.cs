using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void orderGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderGoodsForm myorderGoodsForm = new orderGoodsForm();
            myorderGoodsForm.ShowDialog();
        }

        private void surfingLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            surfingLoginForm mysurfingLoginForm = new surfingLoginForm();
            mysurfingLoginForm.ShowDialog();
        }

        private void surfingStatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            surfingStatisticForm mysurfingStatisticForm = new surfingStatisticForm();
            mysurfingStatisticForm.ShowDialog();
        }
    }
}
