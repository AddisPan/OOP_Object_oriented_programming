using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentInformation_Form stu = new studentInformation_Form();
            stu.ShowDialog();
        }

        private void backeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backery back = new backery();
            back.ShowDialog();
        }

        private void funGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funGame funG = new funGame();
            funG.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
