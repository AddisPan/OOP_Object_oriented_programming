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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentInformationForm mystudentInformationForm = new studentInformationForm();
            mystudentInformationForm.ShowDialog();
        }

        private void backeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backeryForm mybackeryForm = new backeryForm();
            mybackeryForm.ShowDialog();
        }

        private void funGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funGameForm myfunGameForm = new funGameForm();
            myfunGameForm.ShowDialog();
        }
    }
}
